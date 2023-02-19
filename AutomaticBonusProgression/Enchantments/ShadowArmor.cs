﻿using AutomaticBonusProgression.Components;
using AutomaticBonusProgression.Util;
using BlueprintCore.Blueprints.Configurators.Items.Ecnchantments;
using BlueprintCore.Blueprints.Configurators.UnitLogic.ActivatableAbilities;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using BlueprintCore.Blueprints.References;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.UnitLogic.FactLogic;

namespace AutomaticBonusProgression.Enchantments
{
  internal class ShadowArmor
  {
    private static readonly Logging.Logger Logger = Logging.GetLogger(nameof(ShadowArmor));

    private const string ShadowArmorName = "LegendaryArmor.Shadow";
    private const string BuffName = "LegendaryArmor.Shadow.Buff";
    private const string AbilityName = "LegendaryArmor.Shadow.Ability";

    private const string DisplayName = "LegendaryArmor.Shadow.Name";

    internal static BlueprintFeature Configure()
    {
      Logger.Log($"Configuring Shadow Armor");

      var equivalence = new EnhancementEquivalenceComponent(EnhancementType.Armor, 5); // TODO: This should be 2 after testing
      var shadowFeature = FeatureConfigurator.For(FeatureRefs.ArcaneArmorShadowFeature)
        .AddComponent(equivalence) 
        .Configure();
      ArmorEnchantmentConfigurator.For(ArmorEnchantmentRefs.ShadowArmor)
        .AddComponent(equivalence)
        .Configure();

      var enchant = ArmorEnchantmentRefs.ArcaneArmorShadowEnchant.Reference.Get();
      var buff = BuffConfigurator.New(BuffName, Guids.ShadowArmorBuff)
        .SetDisplayName(DisplayName)
        .SetDescription(enchant.m_Description)
        //.SetIcon()
        .AddComponent(shadowFeature.GetComponent<AddStatBonus>())
        .AddComponent(new EnhancementEquivalenceComponent(EnhancementType.Armor, 5, checkOnChange: true))
        .Configure();

      var ability = ActivatableAbilityConfigurator.New(AbilityName, Guids.ShadowArmorAbility)
        .SetDisplayName(DisplayName)
        .SetDescription(enchant.m_Description)
        //.SetIcon()
        .SetBuff(buff)
        // .AddActivatableAbilityVariants()
        .Configure();

      return FeatureConfigurator.New(ShadowArmorName, Guids.ShadowArmor)
        .SetIsClassFeature()
        .SetDisplayName(DisplayName)
        .SetDescription(enchant.m_Description)
        //.SetIcon()
        .AddFacts(new() { ability })
        .Configure();
    }
  }
}