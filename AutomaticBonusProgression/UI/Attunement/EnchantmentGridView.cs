﻿using AutomaticBonusProgression.Components;
using AutomaticBonusProgression.UnitParts;
using AutomaticBonusProgression.Util;
using BlueprintCore.Utils;
using Kingmaker;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.EntitySystem.Entities;
using Kingmaker.UI;
using Kingmaker.UnitLogic;
using Owlcat.Runtime.UI.MVVM;
using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace AutomaticBonusProgression.UI.Attunement
{
  internal class EnchantmentGridView : ViewBase<EnchantmentsVM>
  {
    internal static EnchantmentGridView Instantiate(Transform parent)
    {
      var transform = UnityEngine.Object.Instantiate(Prefabs.EnchantmentContainer).transform;
      var scrollView = transform.Find("StandardScrollView");

      // Create grid params
      var gridLayout = scrollView.GetComponentInChildren<GridLayoutGroupWorkaround>();
      gridLayout.startAxis = GridLayoutGroup.Axis.Horizontal;
      gridLayout.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
      gridLayout.constraintCount = 4;
      gridLayout.cellSize = new(353, 75);

      // Add the view & make sure viewport scales to fit
      var view = scrollView.gameObject.CreateComponent<EnchantmentGridView>(view => view.Grid = gridLayout.transform);
      scrollView.transform.Find("Viewport").Rect().offsetMin = Vector2.zero;

      // Add before configuring layout params or else some may be overridden
      transform.AddTo(parent);
      //transform.gameObject.AddComponent<Image>().color = Color.blue;

      // Set up the size
      var rect = transform.Rect();
      rect.anchorMin = new(0.11f, 0.30f);
      rect.anchorMax = new(0.90f, 0.85f);
      rect.sizeDelta = Vector2.zero;

      return view;
    }

    // Track children so they are not retained when the window is destroyed
    private readonly List<Transform> Children = new();

    public override void BindViewImplementation()
    {
      gameObject.SetActive(true);
      Refresh();
      // Subscribe to the view model which will call this whenever the view should update
      ViewModel.Subscribe(Refresh);
    }

    public override void DestroyViewImplementation()
    {
      gameObject.SetActive(false);
      DisposeChildren();
    }

    private void Refresh()
    {
      DisposeChildren();
      ViewModel.AvailableEnchantments.ForEach(
        feature =>
        {
          var view = EnchantmentView.Instantiate();
          view.Bind(feature);
          view.transform.AddTo(Grid);
          Children.Add(view.transform);
        });
    }

    private void DisposeChildren()
    {
      Children.ForEach(child => GameObject.DestroyImmediate(child.gameObject));
      Children.Clear();
    }

    internal Transform Grid;
  }

  internal class EnchantmentsVM : BaseDisposable, IViewModel
  {
    private static readonly Logging.Logger Logger = Logging.GetLogger(nameof(EnchantmentsVM));

    internal List<EnchantmentVM> AvailableEnchantments = new();

    private Action OnRefresh;
    private UnitEntityData Unit => Game.Instance.SelectionCharacter.SelectedUnit.Value;
    private readonly ReactiveProperty<EnhancementType> Type;

    internal EnchantmentsVM(ReactiveProperty<EnhancementType> type)
    {
      Type = type;
      AddDisposable(Game.Instance.SelectionCharacter.SelectedUnit.Subscribe(_ => Refresh()));
      AddDisposable(Type.Subscribe(_ => Refresh()));
    }

    public override void DisposeImplementation() { }

    private static BlueprintFeature LegendaryWeapon => LegendaryWeaponRef.Reference.Get();
    private static readonly Blueprint<BlueprintFeatureReference> LegendaryWeaponRef = Guids.LegendaryWeapon;

    private static BlueprintFeature LegendaryOffHand => LegendaryOffHandRef.Reference.Get();
    private static readonly Blueprint<BlueprintFeatureReference> LegendaryOffHandRef = Guids.LegendaryOffHand;

    private static BlueprintFeature LegendaryArmor => LegendaryArmorRef.Reference.Get();
    private static readonly Blueprint<BlueprintFeatureReference> LegendaryArmorRef = Guids.LegendaryArmor;

    private static BlueprintFeature LegendaryShield => LegendaryShieldRef.Reference.Get();
    private static readonly Blueprint<BlueprintFeatureReference> LegendaryShieldRef = Guids.LegendaryShield;

    private void Refresh()
    {
      Logger.Verbose(() => $"Refreshing Enchantment Grid: {Unit}, {Type.Value}");
      foreach (var vm in AvailableEnchantments)
        vm.Dispose();

      AvailableEnchantments.Clear();

      if (Unit is null)
        return;

      var legendaryFeature = Type.Value switch
        {
          EnhancementType.Armor => Unit.GetFeature(LegendaryArmor),
          EnhancementType.Shield => Unit.GetFeature(LegendaryShield),
          EnhancementType.MainHand => Unit.GetFeature(LegendaryWeapon),
          EnhancementType.OffHand => Unit.GetFeature(LegendaryOffHand),
          _ => throw new NotImplementedException(),
        };
      if (legendaryFeature is null)
        return; // TODO: Show text when character doesn't have attunement

      var attunement = legendaryFeature.GetComponent<AttunementBuffsComponent>();
      if (attunement is null)
        throw new InvalidOperationException($"Missing AttunementBuffsComponent: {legendaryFeature.Name}");

      var unitPart = Unit.Ensure<UnitPartEnhancement>();
      unitPart.ResetTempEnhancement(Type.Value, legendaryFeature.GetRank());

      Logger.Verbose(() => $"Adding enchantments: {legendaryFeature.Name}");
      foreach (var buff in attunement.Buffs)
      {
        var bp = buff.Get();
        Logger.Verbose(() => $"Checking {bp.Name}");
        var enhancement = bp.GetComponent<EnhancementEquivalence>();
        if (enhancement is null)
          throw new InvalidOperationException($"Missing EnhancementEquivalentComponent: {bp.Name}");

        if (legendaryFeature.GetRank() < enhancement.Enhancement)
          continue;

        AvailableEnchantments.Add(new EnchantmentVM(bp, enhancement, Unit));
      }

      OnRefresh?.Invoke();
    }

    internal void Subscribe(Action onRefresh)
    {
      OnRefresh = onRefresh;
    }
  }
}
