﻿using AutomaticBonusProgression.Util;
using BlueprintCore.Utils;
using HarmonyLib;
using Kingmaker;
using Kingmaker.ElementsSystem;
using Kingmaker.PubSubSystem;
using Kingmaker.UI.FullScreenUITypes;
using Kingmaker.UI.MVVM._PCView.ChangeVisual;
using Kingmaker.UI.MVVM._PCView.InGame;
using Owlcat.Runtime.UI.Controls.Button;
using Owlcat.Runtime.UI.Controls.Other;
using Owlcat.Runtime.UI.MVVM;
using System;
using System.Collections.Generic;
using TMPro;
using UniRx;
using UnityEngine;

namespace AutomaticBonusProgression.UI.Attunement
{
  internal class AttunementView : ViewBase<AttunementVM>
  {
    private static readonly Logging.Logger Logger = Logging.GetLogger(nameof(AttunementView));

    #region Static
    private static AttunementView BaseView;
    internal static readonly ReactiveProperty<AttunementVM> AttunementVM = new();

    internal static void ShowWindow()
    {
      AttunementVM.Value = new(DisposeWindow);
    }

    internal static void DisposeWindow()
    {
      AttunementVM.Value?.Dispose();
      AttunementVM.Value = null;
    }
    #endregion

    private Transform Window;
    private OwlcatButton CloseButton;
    private TextMeshProUGUI Header;

    private EnchantmentsView Enchantments;

    private readonly List<Transform> Children = new();

    public override void BindViewImplementation()
    {
      gameObject.SetActive(true);
      AddDisposable(Game.Instance.UI.EscManager.Subscribe(ViewModel.Close));
      AddDisposable(CloseButton.OnLeftClickAsObservable().Subscribe(_ => ViewModel.Close()));

      Header.text = ViewModel.GetHeader();
      Enchantments.Bind(new());
    }

    public override void DestroyViewImplementation()
    {
      gameObject.SetActive(false);

      Children.ForEach(child => DestroyImmediate(child.gameObject));
      Children.Clear();
    }

    internal void Initialize()
    {
      Window = gameObject.ChildObject("Window").transform;
      CloseButton = gameObject.ChildObject("Window/Close").GetComponent<OwlcatButton>();
      Header = gameObject.ChildObject("Window/Header").GetComponentInChildren<TextMeshProUGUI>();
      Enchantments = EnchantmentsView.Instantiate(Window);
    }

    #region Setup
    [HarmonyPatch(typeof(InGameStaticPartPCView))]
    static class InGameStaticPartPCView_Patch
    {
      [HarmonyPatch(nameof(InGameStaticPartPCView.Initialize)), HarmonyPostfix]
      static void Initialize(InGameStaticPartPCView __instance)
      {
        try
        {
          Logger.Log("Initializing WindowView BaseView");
          Prefabs.Create();
          BaseView = Create(__instance.m_ChangeVisualPCView);
        }
        catch (Exception e)
        {
          Logger.LogException("InGameStaticPartPCView_Patch.Initialize", e);
        }
      }

        [HarmonyPatch(nameof(InGameStaticPartPCView.BindViewImplementation)), HarmonyPostfix]
        static void BindViewImplementation(InGameStaticPartPCView __instance)
        {
          try
          {
              Logger.Log("Binding to AttunementVM");
              __instance.AddDisposable(AttunementVM.Subscribe(BaseView.Bind));
          }
          catch (Exception e)
          {
              Logger.LogException("InGameStaticPartPCView_Patch.BindViewImplementation", e);
          }
        }

        internal static AttunementView Create(ChangeVisualPCView changeVisualView)
        {
          var obj = Instantiate(changeVisualView.gameObject);
          obj.transform.AddTo(changeVisualView.transform.parent);
          obj.MakeSibling("ServiceWindowsPCView");

          obj.DestroyComponents<ChangeVisualPCView>();
          // TODO: Add as components!
          obj.DestroyChildren(
            "Window/InteractionSlot",
            "Window/Inventory",
            "Window/Doll",
            "Window/BackToStashButton",
            "Window/ChangeItemsPool");

          var view = obj.AddComponent<AttunementView>();
          view.Initialize();
          return view;
        }
    }
    #endregion
  }

  internal class AttunementVM : BaseDisposable, IViewModel
  {
    private readonly Action DisposeAction;

    private AttunementType Type = AttunementType.Weapon;

    internal AttunementVM(Action disposeAction)
    {
      DisposeAction = disposeAction;
      EventBus.RaiseEvent<IFullScreenUIHandler>(h => h.HandleFullScreenUiChanged(state: true, FullScreenUIType.Unknown));
    }

    public override void DisposeImplementation()
    {
      DisposeAction();
      EventBus.RaiseEvent<IFullScreenUIHandler>(h => h.HandleFullScreenUiChanged(state: false, FullScreenUIType.Unknown));
    }

    internal void Close()
    {
      DisposeImplementation();
    }

    internal string GetHeader()
    {
      return Type switch
      {
        AttunementType.Weapon => UITool.GetString("Attunement.Weapon"),
        AttunementType.OffHand => UITool.GetString("Attunement.OffHand"),
        AttunementType.Armor => UITool.GetString("Attunement.Armor"),
        AttunementType.Shield => UITool.GetString("Attunement.Shield"),
        _ => throw new InvalidOperationException($"Unknown attunement type: {Type}"),
      };
    }
  }

  internal enum AttunementType
  {
    Weapon,
    OffHand,
    Armor,
    Shield
  }

  internal class ShowAttunement : GameAction
  {
    public override string GetCaption()
    {
      return "Shows the attunement window";
    }

    public override void RunAction()
    {
      AttunementView.ShowWindow();
    }
  }
}