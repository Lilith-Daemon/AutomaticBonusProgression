﻿using AutomaticBonusProgression.Components;
using AutomaticBonusProgression.UI.Attunement;
using AutomaticBonusProgression.Util;
using BlueprintCore.Actions.Builder;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Abilities;
using Kingmaker.Blueprints.Classes;

namespace AutomaticBonusProgression.Features
{
  internal class LegendaryArmor
  {
    private static readonly Logging.Logger Logger = Logging.GetLogger(nameof(LegendaryArmor));

    private const string LegendaryArmorName = "LegendaryArmor";
    private const string LegendaryArmorDisplayName = "LegendaryArmor.Name";
    private const string LegendaryArmorDescription = "LegendaryArmor.Description";
    private const string LegendaryArmorAbility = "LegendaryArmor.Ability";
    internal const string LegendaryArmorAbilityDescription = "LegendaryArmor.Ability.Description";

    internal static BlueprintFeature Configure()
    {
      Logger.Log("Configuring Legendary Armor");

      var ability = AbilityConfigurator.New(LegendaryArmorAbility, Guids.LegendaryArmorAbility)
        .SetDisplayName(LegendaryArmorDisplayName)
        .SetDescription(LegendaryArmorAbilityDescription)
        .AddAbilityCasterInCombat(not: true)
        .AddAbilityEffectRunAction(ActionsBuilder.New().Add<ShowAttunement>())
        .Configure();

      return FeatureConfigurator.New(LegendaryArmorName, Guids.LegendaryArmor)
        .SetIsClassFeature()
        .SetDisplayName(LegendaryArmorDisplayName)
        .SetDescription(LegendaryArmorDescription)
        //.SetIcon()
        .SetRanks(5)
        .AddFacts(new() { ability })
        .AddComponent(
          new AttunementBuffsComponent(
            Guids.BalancedBuff,
            Guids.BolsteringBuff,
            Guids.BrawlingBuff,
            Guids.ChampionBuff,
            Guids.CreepingBuff,
            Guids.DastardBuff,
            Guids.DeathlessBuff,
      #region Defiant
            Guids.DefiantAberrationsBuff,
            Guids.DefiantAnimalsBuff,
            Guids.DefiantConstructsBuff,
            Guids.DefiantDragonsBuff,
            Guids.DefiantFeyBuff,
            Guids.DefiantHumanoidGiantBuff,
            Guids.DefiantHumanoidReptilianBuff,
            Guids.DefiantHumanoidMonstrousBuff,
            Guids.DefiantMagicalBeastsBuff,
            Guids.DefiantOutsiderGoodBuff,
            Guids.DefiantOutsiderEvilBuff,
            Guids.DefiantOutsiderLawfulBuff,
            Guids.DefiantOutsiderChaoticBuff,
            Guids.DefiantOutsiderNeutralBuff,
            Guids.DefiantPlantsBuff,
            Guids.DefiantUndeadBuff,
            Guids.DefiantVerminBuff,
      #endregion
            Guids.DeterminationBuff,
      #region Energy Resistance
            // 10 Armor
            Guids.AcidResist10Buff,
            Guids.ColdResist10Buff,
            Guids.ElectricityResist10Buff,
            Guids.FireResist10Buff,
            Guids.SonicResist10Buff,

            // 20 Armor
            Guids.AcidResist20Buff,
            Guids.ColdResist20Buff,
            Guids.ElectricityResist20Buff,
            Guids.FireResist20Buff,
            Guids.SonicResist20Buff,

            // 30 Armor
            Guids.AcidResist30Buff,
            Guids.ColdResist30Buff,
            Guids.ElectricityResist30Buff,
            Guids.FireResist30Buff,
            Guids.SonicResist30Buff,
      #endregion
            Guids.ExpeditiousBuff,
            Guids.FortificationBuff,
            Guids.GhostArmorBuff,
            Guids.InvulnerabilityBuff,
            Guids.MartyringBuff,
            Guids.RallyingBuff,
            Guids.ReflectingBuff,
            Guids.RighteousBuff,
            Guids.ShadowBuff,
            Guids.ImprovedShadowBuff,
            Guids.GreaterShadowBuff,
            Guids.SpellResistance13Buff,
            Guids.SpellResistance16Buff,
            Guids.SpellResistance19Buff,
            Guids.SpellResistance22Buff
          ))
        .Configure();
    }
  }
}
