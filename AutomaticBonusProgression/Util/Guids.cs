﻿namespace AutomaticBonusProgression.Util
{
  /// <summary>
  /// List of new and mod Guids.
  /// </summary>
  internal class Guids
  {
    private static readonly Logging.Logger Logger = Logging.GetLogger(nameof(Guids));

    #region Attunement
    // Enchantment used to calculate armor / weapon / shield enhancement bonuses
    internal const string EnhancementCalculator = "945f05cf-ffb5-489d-b4d8-2687d1f1b835";

    internal const string ArmorAttunement = "32fca48a-12dd-4b1c-a678-ada1bdbbde4a";
    internal const string ArmorAttunementBase = "24af67c6-bc58-4dba-a9bf-d7d00925e7c7";
    internal const string ShieldAttunement = "58b87d99-125c-4300-9c87-ba0d90168ca2";
    internal const string ShieldAttunementBase = "c31f69e1-73cd-4137-96ac-f5420ab9fa70";

    internal const string WeaponAttunement = "137eeed7-8487-411c-b861-15ded694bd08";
    internal const string WeaponAttunementBase = "f98a2678-3840-4604-9ebc-45b46ea9aff9";
    internal const string OffHandAttunement = "84fedf0f-50fa-4b26-8e61-5c2e280bfc8e";
    internal const string OffHandAttunementBase = "6aadde0f-4dbd-433a-969d-cc75a1f01004";

    internal const string Deflection = "b9af42db-c718-42c5-89e1-5376619e2460";
    internal const string DeflectionBase = "793ff28d-f24a-405e-90f6-b6e87cde1070";
    internal const string Toughening = "0de33c56-4913-4b69-b1d0-619cd663beff";
    internal const string TougheningBase = "593afbcf-6641-4ea0-ae95-122b3c36cf56";
    internal const string Resistance = "a5011356-2852-40ee-9841-d8bbf58d6336";
    internal const string ResistanceBase = "b67b1c21-55b1-4a2c-a5d1-49b8bff86b2d";

    internal const string MentalProwess = "e7df3b10-578f-439d-8976-657af9b68965";
    internal const string IntProwess = "ea260889-0874-45aa-9e79-4351dfc626e8";
    internal const string WisProwess = "927f8f04-9ad3-4b5b-a789-dc4dd5cb00f8";
    internal const string ChaProwess = "a2b5f61a-8468-43bb-a3e7-87908fe45f9c";

    internal const string PhysicalProwess = "25c94c69-c2e1-4ccc-a3e5-0fe6c9f1bb05";
    internal const string StrProwess = "7d2b1e99-808c-455f-977a-547eca0bbfc3";
    internal const string DexProwess = "f400157d-d8a8-4b2a-9daa-5866a5f61dfd";
    internal const string ConProwess = "2ca04f63-07ef-4ed5-9796-3ad1e4b04b55";
    #endregion

    #region Item Changes
    internal const string Str2 = "2516a223-396e-4ee7-b5bf-a8dfafe4c020";
    internal const string Dex2 = "ff6596ab-3f23-44cf-87e7-ae40ff936e48";
    internal const string Con2 = "d6a4aadd-2e68-464b-93be-5a5e7d9a1713";
    internal const string Int2 = "ab2488ac-4f43-436f-8d4c-4c6ddc0a64de";
    internal const string Wis2 = "ee8bb9bb-be97-4fc9-a48d-7cc84dd5473d";
    internal const string Cha2 = "e08b8724-d021-4610-9901-63672b011c4c";

    internal const string IncreaseResist1 = "7c9d64c3-8569-40af-b3c7-e8a0fa0cf375";
    internal const string IncreaseDeflection1 = "cbc9cab4-aaa4-47c8-9182-41322b0dc160";
    internal const string IncreaseNaturalArmor1 = "f2a8ae72-baab-4604-879b-7b181025bad6";

    internal const string Trickery2 = "a4737149-4b0e-4030-afe5-e4d89abea53e";
    internal const string Mobility2 = "a4dad0a8-b298-4642-b2dd-199a02294967";
    internal const string Persuasion2 = "43ea6c62-adac-4afb-95e3-ed1eeb874404";

    internal const string WizardBuff = "8483953a-2a86-44d6-97d3-6d00a0e9a904";

    internal const string TricksterArcanaBuff = "925974a2-3a4f-4123-9112-1e16796ecfc6";
    #endregion

    #region Legendary Gifts
    internal const string LegendaryStrength = "b8c3a13e-ba3e-47a5-a1fa-f2016d0fb682";
    internal const string LegendaryDexterity = "64cd8ffd-134a-4e63-8e7e-1a6ba328a6b0";
    internal const string LegendaryConstitution = "a8aab8e0-e601-4b71-82db-ecd5dfdb5953";
    internal const string LegendaryIntelligence = "49fc30e1-bd73-413d-948c-c47493d310db";
    internal const string LegendaryWisdom = "e2411919-40ff-4acf-bb75-0f5a27ad6c88";
    internal const string LegendaryCharisma = "95483f02-93c5-4301-99e5-38e8ea2ca3bb";

    internal const string LegendaryShieldmaster = "baef229b-a7fa-4618-88ed-23f9e6875d18";
    internal const string LegendaryTwinWeapons = "d910642b-7719-4607-b6e0-0d614f1a30e0";

    internal const string LegendaryPhysicalProwess = "4af6f190-145c-473e-a584-bcc0143e838d";
    internal const string LegendaryMentalProwess = "4494c7c0-bb7f-468c-ba2a-26b866ea459d";

    #region Legendary Armor / Shield
    internal const string LegendaryArmor = "171db362-874c-468a-8626-b3e2c9deb1d4";
    internal const string LegendaryArmorAbility = "b1c038e4-f34f-443b-b080-23d44cfba390";
    internal const string LegendaryArmorResource = "f671f985-52fd-40ef-97c4-542fa485d7a5";

    internal const string LegendaryShield = "1b2c33c3-672f-47c3-b4a2-e2a0167ff953";
    internal const string LegendaryShieldAbility = "39db45ad-8f6f-4317-a0e6-6ae78e426d8e";
    internal const string LegendaryShieldResource = "0c8ee313-ab76-4e48-bdea-041cf7732f44";

    internal const string BalancedEffect = "395f73da-d5a6-440c-a018-e9c0b83a92b6";
    internal const string BalancedBuff = "fe735c67-37a2-412e-88cb-032ef9feacb8";

    internal const string BashingEffect = "01a0061e-5fe1-40a1-b870-84dbfacf04de";
    internal const string BashingBuff = "d3db2785-81b5-4a9f-aa1e-e91dc8b1bd95";

    internal const string BlindingEffect = "72a010f1-2f82-4361-b591-d57bf448cecf";
    internal const string BlindingBuff = "7b6a19ad-2a0e-4845-8ff7-33a656a97825";
    internal const string BlindingAbility = "d7305e2a-3b76-480e-96e7-4db4515407cd";
    internal const string BlindingResource = "6b9e185f-9e53-4344-9df1-46df15ff8c74";

    internal const string BolsteringEffect = "32731c48-a494-48eb-a11e-d4725a808849";
    internal const string BolsteringTargetBuff = "d2022e07-3594-4563-b50b-bce30378c4f0";
    internal const string BolsteringBuff = "7e724a6b-54a2-4c93-bece-9bd18b3961dc";
    internal const string BolsteringShieldBuff = "649dbf11-9213-409c-bf27-d833778621ba";

    internal const string BrawlingEffect = "10fc122a-2307-4f34-993b-63ae6b6bdc47";
    internal const string BrawlingBuff = "3668e7c1-3ebf-4fd9-a6df-4d1768259649";

    internal const string ChampionEffect = "481c31bb-24ef-45be-aa53-55587f8e4377";
    internal const string ChampionBuff = "ff5e6c75-9b43-473c-a174-61663c709fb9";

    internal const string CreepingEffect = "d6a3ac53-2012-4444-adc6-4fa9194af62a";
    internal const string CreepingBuff = "87eaad30-abdc-4cc1-8bea-46ca587e77d7";
    internal const string CreepingAbility = "a233ebd4-a677-4100-b417-209bf5daafb6";
    internal const string CreepingCastBuff = "95ab4589-fcb6-4254-a0fe-e09d2b4a78b2";
    internal const string CreepingResource = "ecd8026d-4884-4108-bf86-67bf58456f85";

    internal const string DastardEffect = "4abddf52-82b5-4d6a-a533-de8180ecfc79";
    internal const string DastardBuff = "a21bd358-167e-4482-82ec-2362bfbfcb61";

    internal const string DeathlessEffect = "d44cfbde-4b53-4507-9dd2-e21b3ec48bab";
    internal const string DeathlessBuff = "a0750060-80f0-4652-b4fd-dd4bae5cca67";

    #region Defiant
    internal const string DefiantAberrationsEffect = "192c32aa-5995-464c-8c5f-52298f8366f4";
    internal const string DefiantAberrationsBuff = "ba3eba6b-3fe1-479a-81b7-b222321e52dd";
    internal const string DefiantAberrationsShieldBuff = "da005b7d-a2af-430f-ab7f-7bba8e69fff8";

    internal const string DefiantAnimalsEffect = "43374da6-5f08-4adf-bb7f-a6b3c8b24cbc";
    internal const string DefiantAnimalsBuff = "a15c9d9c-f900-47ce-8ecb-059b668659d3";
    internal const string DefiantAnimalsShieldBuff = "025f0216-9c6e-4a64-bc32-25e1beebd051";

    internal const string DefiantConstructsEffect = "2699b5ec-17e1-4503-b1af-c174103295a1";
    internal const string DefiantConstructsBuff = "3e5e8c87-c603-4498-b189-76b9d075089c";
    internal const string DefiantConstructsShieldBuff = "0609550c-0f0c-4aea-a1a3-954cfbdb0fb3";

    internal const string DefiantDragonsEffect = "15e363fd-6b81-47e0-b7d6-c70847fadc56";
    internal const string DefiantDragonsBuff = "68ef104d-bf90-48c6-aa5a-6f15e318fee5";
    internal const string DefiantDragonsShieldBuff = "88c61541-98a8-4a43-9a63-edaf9ea942dd";

    internal const string DefiantFeyEffect = "6fc07785-7e74-4b65-ad9f-0b2ad0f4619d";
    internal const string DefiantFeyBuff = "d801a36a-df08-4d41-829a-00541ccab9e8";
    internal const string DefiantFeyShieldBuff = "055863b2-1a9f-4c74-a320-5e46049541f1";

    internal const string DefiantHumanoidGiantEffect = "bcda585d-bf64-4f33-adf2-ab140f95aa6b";
    internal const string DefiantHumanoidGiantBuff = "e2453e4f-384b-4332-8cfa-126960c991c5";
    internal const string DefiantHumanoidGiantShieldBuff = "a8ad1a79-34e2-4a25-b69e-6b012478acc6";

    internal const string DefiantHumanoidReptilianEffect = "a92b6974-9ca1-43bd-8ad6-7e3578554723";
    internal const string DefiantHumanoidReptilianBuff = "5f022777-fd7e-48fe-8f74-4230b63419f4";
    internal const string DefiantHumanoidReptilianShieldBuff = "b7e6e592-2bed-498a-a0b8-f7259392c803";

    internal const string DefiantHumanoidMonstrousEffect = "03628a54-2498-4d61-bd79-cf1156adedc3";
    internal const string DefiantHumanoidMonstrousBuff = "3feb2322-5ee5-42e3-97db-05352deb6af4";
    internal const string DefiantHumanoidMonstrousShieldBuff = "ab5468f1-b134-4ba4-b8ac-5ef74816756e";

    internal const string DefiantMagicalBeastsEffect = "d2b09fe0-2eb2-4a33-a095-7b48e5db64fc";
    internal const string DefiantMagicalBeastsBuff = "e2dd7276-49fd-476a-87b3-ebfd37fcc8b6";
    internal const string DefiantMagicalBeastsShieldBuff = "c994ebcf-85b6-46e2-98c8-fd857aaf9f62";

    internal const string DefiantOutsiderGoodEffect = "365053c4-672b-4706-909c-39d1df92f267";
    internal const string DefiantOutsiderGoodBuff = "a02c7c21-3e2b-422a-a222-12ddd1f7de11";
    internal const string DefiantOutsiderGoodShieldBuff = "e1ee5b41-2ac2-45b9-95a1-70773783ffe6";

    internal const string DefiantOutsiderEvilEffect = "e7b9f37a-ac9e-4cf3-9f7a-007e2ec416da";
    internal const string DefiantOutsiderEvilBuff = "ae263068-dfd9-45e9-9bcb-358e180486ea";
    internal const string DefiantOutsiderEvilShieldBuff = "b96bde35-e59c-4271-b719-711d788f565f";

    internal const string DefiantOutsiderLawfulEffect = "223f9cdf-0f58-4ef3-bdae-cfcf0d929460";
    internal const string DefiantOutsiderLawfulBuff = "4cc5dc5c-186d-4de1-9818-8e7792600368";
    internal const string DefiantOutsiderLawfulShieldBuff = "0d1e0971-f9d5-4200-b6f2-5c6c46ec6f16";

    internal const string DefiantOutsiderChaoticEffect = "75bc18f1-81ad-464c-94de-b2d4a94aca58";
    internal const string DefiantOutsiderChaoticBuff = "09fdab88-6744-4d72-a38b-4419e527b9c3";
    internal const string DefiantOutsiderChaoticShieldBuff = "867036b8-aaba-42b6-9425-4fca7132370a";

    internal const string DefiantOutsiderNeutralEffect = "1c052f78-bb2e-4783-a3a9-06ecada8915b";
    internal const string DefiantOutsiderNeutralBuff = "d8895833-86cb-4883-af3d-ba19d2867887";
    internal const string DefiantOutsiderNeutralShieldBuff = "9c2d748d-6c18-4cd6-96db-d21576e3aed7";

    internal const string DefiantPlantsEffect = "31890128-fbc4-4994-b0ba-2a8ba8f7b12f";
    internal const string DefiantPlantsBuff = "3b2f059b-3233-4dee-a188-ec06f89a791c";
    internal const string DefiantPlantsShieldBuff = "bcb894fb-4dc2-477e-8d74-8fe3f64ca2e5";

    internal const string DefiantUndeadEffect = "598998fe-1999-4670-b184-fce2661dda81";
    internal const string DefiantUndeadBuff = "a767aa99-3c8f-4533-a226-4ae5b2f45afd";
    internal const string DefiantUndeadShieldBuff = "d7b3b11a-7ae7-4e55-aa9c-fecca4eb04fa";

    internal const string DefiantVerminEffect = "b4508f69-8316-47ee-ac3c-1b9ea8979103";
    internal const string DefiantVerminBuff = "cd0fa7ea-3954-4f54-8dd6-c1a502d9fc32";
    internal const string DefiantVerminShieldBuff = "dc684853-855e-48bb-8b19-354509c157ce";
    #endregion

    internal const string DeterminationEffect = "76df287a-eb8b-46e4-aefb-b0b8bdffb6e2";
    internal const string DeterminationBuff = "0be08da1-8f39-459e-a6e8-89eead23a135";
    internal const string DeterminationShieldBuff = "73b3c2d3-0cf4-47c4-a8b2-536d7c7b7515";
    internal const string DeterminationResource = "45e5d3b4-3c7d-4156-986f-aa731cf95811";
    internal const string DeterminationShieldResource = "3d9d0bbb-87fa-4c1c-8cf1-e2385dfc006f";

    #region Energy Resistance
    internal const string AcidResist10Effect = "459f021a-ff77-410f-8e24-32d541505961";
    internal const string AcidResist10Buff = "737b2b79-63d6-4677-ab4b-57e1c6d4c0a6";
    internal const string AcidResist10ShieldBuff = "060761d3-7975-44b0-a8ac-9da29df413c0";

    internal const string ColdResist10Effect = "cec7be47-fa90-4664-8a84-9a1730b1ca09";
    internal const string ColdResist10Buff = "6e3b9b46-ed38-4cb7-9083-54e427b2deee";
    internal const string ColdResist10ShieldBuff = "521f1397-27dc-4dea-b780-de09ef5f0abf";

    internal const string ElectricityResist10Effect = "b57b6d8d-cf93-4580-8d0e-85e645433914";
    internal const string ElectricityResist10Buff = "5b78e287-397c-45c7-8b02-8a74c1db6081";
    internal const string ElectricityResist10ShieldBuff = "bb2fb8a9-a420-481b-89f2-24fb5a4f405a";

    internal const string FireResist10Effect = "f18fd49d-943f-461c-b274-4e6f1f21efa0";
    internal const string FireResist10Buff = "a8cf1622-79a9-45c2-9429-51a963f29406";
    internal const string FireResist10ShieldBuff = "15f74b99-8c1c-4485-8925-cd506b869c3d";

    internal const string SonicResist10Effect = "1e2d6827-fe4d-4c58-acb2-cedf71255ecf";
    internal const string SonicResist10Buff = "36d2ec4d-d1bd-4dfa-aee0-e18f0ca338b6";
    internal const string SonicResist10ShieldBuff = "a995f85d-ee8a-4c9b-887c-efa0cce8865f";

    internal const string AcidResist20Effect = "4a61cdfc-1e55-4a39-8022-6826b7edc113";
    internal const string AcidResist20Buff = "0efd352a-b3d2-41e7-9cd6-7b8a84493c08";
    internal const string AcidResist20ShieldBuff = "02f8fd02-2dc1-442c-8c35-6634ee6f0b33";

    internal const string ColdResist20Effect = "34518a03-6ccb-43ac-9bea-9a4aafe3b9cc";
    internal const string ColdResist20Buff = "77502710-6b75-4db7-811d-f7a903e5b109";
    internal const string ColdResist20ShieldBuff = "d86e95a7-60db-4860-b5ea-5ea74bca13ff";

    internal const string ElectricityResist20Effect = "9f598605-ec89-44d5-8194-bd72da9c1cfe";
    internal const string ElectricityResist20Buff = "4ad93d3c-1632-464a-989f-2be2d5dd4354";
    internal const string ElectricityResist20ShieldBuff = "da176901-dba0-499f-a702-8c2feb00570c";

    internal const string FireResist20Effect = "8c94339b-2fbf-4fd0-bff5-1626905d8423";
    internal const string FireResist20Buff = "cebaa178-8457-4e76-a2d8-52865ad55020";
    internal const string FireResist20ShieldBuff = "f41f3a61-699f-42d5-b8b0-bac37f34e3dd";

    internal const string SonicResist20Effect = "b3a09bb3-b5df-490d-ad67-8b63ea5e6439";
    internal const string SonicResist20Buff = "e36f3f8c-a81d-4de4-b0b2-4eb039f73f5a";
    internal const string SonicResist20ShieldBuff = "d1fe93c4-5b9a-4c66-95a7-8500268a2da0";

    internal const string AcidResist30Effect = "af71eebc-bfb3-4d5a-bed9-10cf81ca2382";
    internal const string AcidResist30Buff = "50fc2507-045b-4ae1-87c6-c5f5e19524a0";
    internal const string AcidResist30ShieldBuff = "c19ba6f4-342c-401d-8d29-1fd48e2cd500";

    internal const string ColdResist30Effect = "fbacbbb6-f776-46ce-bf23-a4e2498d2a20";
    internal const string ColdResist30Buff = "c6dbd36b-e791-48ae-8774-cef122b0107d";
    internal const string ColdResist30ShieldBuff = "2693383c-2935-470f-bbb1-d0632585158a";

    internal const string ElectricityResist30Effect = "2b3eb230-055c-4aea-9f85-9a8af61221e1";
    internal const string ElectricityResist30Buff = "50ebb877-881b-45ec-97de-2a22f635ed0f";
    internal const string ElectricityResist30ShieldBuff = "53314f1b-26bf-4ffb-bc50-617f00a1bfec";

    internal const string FireResist30Effect = "5ca47d6d-4c04-407e-97c4-0dff35d394f3";
    internal const string FireResist30Buff = "cbf5f8a2-5bb1-419b-9fbe-bac804dea9a5";
    internal const string FireResist30ShieldBuff = "3a88e1c8-643f-49dd-92aa-3b028f6dd783";

    internal const string SonicResist30Effect = "e0736dad-d2e3-40be-b88b-57f225fe3e12";
    internal const string SonicResist30Buff = "15c76fa0-08f9-4dae-a6a3-adc26551d1d7";
    internal const string SonicResist30ShieldBuff = "f9a9cacc-ab26-4d27-b587-f2aab4d45777";
    #endregion

    internal const string ExpeditiousEffect = "31136772-b598-4af7-a752-f22c48975df1";
    internal const string ExpeditiousBuff = "c737fc3f-d4ee-485b-97b9-d4255cca521a";
    internal const string ExpeditiousAbility = "9d94a4f9-88b1-49d4-9379-f88ffce54478";
    internal const string ExpeditiousCastBuff = "ad7d2353-1959-45d8-84a2-7fb93f15f8a2";
    internal const string ExpeditiousResource = "cb3168e0-c05f-41b2-a9f3-c3fd7dfb34b3";

    internal const string FortificationEffect = "8c0470a2-a1fa-44f9-8d42-a46faf3145c1";
    internal const string FortificationBuff = "b8b39cb6-7ce3-4a10-ab24-0f773e22f9b2";
    internal const string FortificationShieldBuff = "035bf5bc-4180-4163-a2f7-377a1e12b9e6";

    internal const string ImprovedFortificationEffect = "450ca6b5-6951-4e76-ab21-fb9f62fc901b";
    internal const string ImprovedFortificationBuff = "bb04409f-824e-4c0b-b3ab-457bbfebf38d";
    internal const string ImprovedFortificationShieldBuff = "9e471109-647b-427b-9aa0-858518489952";

    internal const string GreaterFortificationEffect = "73f6c79d-9e1e-49bd-a097-b0beaa1ab4c0";
    internal const string GreaterFortificationBuff = "a5fbdedb-4d43-4b5a-8fe3-016e12dd90ed";
    internal const string GreaterFortificationShieldBuff = "c0dd6ab0-d52c-4772-8811-1d4aa422e550";

    internal const string GhostArmorEffect = "d3b28fd9-e3db-415b-9754-012fa6aaccd8";
    internal const string GhostArmorBuff = "0ad47b7c-4790-4da6-821e-deec92371a61";
    internal const string GhostArmorShieldEffect = "0ac87ee2-c1f0-4c40-bc1c-b1e49cc0be5a";
    internal const string GhostArmorShieldBuff = "af372ef8-26cc-41b3-8301-6e653c98409f";

    internal const string InvulnerabilityEffect = "03d89904-8e99-4856-8c9c-719e77463141";
    internal const string InvulnerabilityBuff = "d77e2446-276a-4246-924e-d679b526eea8";

    internal const string MartyringEffect = "78bf888f-1501-467a-9b0b-b17da3decebf";
    internal const string MartyringBuff = "14df227c-794d-4328-acbb-389c9d9b081f";
    internal const string MartyringResource = "f6bc327f-4031-42b0-b068-16992ce73975";

    internal const string RallyingEffect = "cfc8a849-c422-4043-b6e3-f96506b6b5b3";
    internal const string RallyingBuff = "d513d85b-636f-46c0-9359-316bf7b23ba1";
    internal const string RallyingShieldBuff = "635a522c-880c-4eeb-a599-361ea3f6cb70";
    internal const string RallyingAura = "087eee7a-8632-4d9b-b5f3-074b23c52371";
    internal const string RallyingAuraBuff = "298dbc80-b704-446c-a3fd-efcdea5190ec";

    internal const string ReflectingEffect = "88947511-2103-40b2-9c9e-4e26c2618952";
    internal const string ReflectingBuff = "93474eb1-e45e-40c5-a437-15963b72527e";
    internal const string ReflectingCastAbility = "5a5517af-27bb-4cc0-ac03-947e37472476";
    internal const string ReflectingCastBuff = "2c483050-4c83-4afc-b671-4ee96b29882f";
    internal const string ReflectingCastResource = "c6b43c97-649b-42e4-b026-37cae8bca7f3";

    internal const string RighteousEffect = "851716fc-bb95-4b35-8fc5-690a590030fa";
    internal const string RighteousBuff = "9a5872b7-ca30-4f0b-98e2-8e2cb0fc6c4c";
    internal const string RighteousCastAbility = "aa581f86-1d74-4cc2-9e8b-d312719b88f1";
    internal const string RighteousCastResource = "ea9b5caf-e283-4614-b51f-8a60cd128b43";

    internal const string ShadowEffect = "86580aff-6433-4b70-823a-8d4d8d904f46";
    internal const string ShadowBuff = "1cb18f84-4ae0-4990-930f-f47f42ff549d";

    internal const string ImprovedShadowEffect = "c06851ca-0d5e-45ae-a18d-de485622e4f1";
    internal const string ImprovedShadowBuff = "8026ac99-35ce-43c2-8e0b-f076530882f8";

    internal const string GreaterShadowEffect = "090411ba-8a36-4077-a558-b8d3e497f09f";
    internal const string GreaterShadowBuff = "3b48de35-4127-474e-a3bb-020329815de4";

    internal const string SpellResistance13Effect = "e60ba111-956c-437d-8491-b4f4e4ecadb7";
    internal const string SpellResistance13Buff = "d96fab7a-c514-42ff-b336-a27a8e6e7730";
    internal const string SpellResistance13ShieldBuff = "e81c3f44-0ad2-40a1-b0d1-d3fea8358039";

    internal const string SpellResistance16Effect = "00c6c4f2-72e1-4be4-8f3f-9c501f71ee44";
    internal const string SpellResistance16Buff = "0a254e25-aa90-4c6c-a0bc-0950eb00e923";
    internal const string SpellResistance16ShieldBuff = "be265426-e20b-4e3b-88b5-c04211adb69e";

    internal const string SpellResistance19Effect = "b74f7f6d-b20b-4168-b648-edc11051c349";
    internal const string SpellResistance19Buff = "ad53e752-146a-484c-a8e4-53eeff4c62f9";
    internal const string SpellResistance19ShieldBuff = "0c9b59d7-bf67-45ec-aca1-5cf21efc5da8";

    internal const string SpellResistance22Effect = "8771a086-5fe3-41ee-a917-761e7982a0fd";
    internal const string SpellResistance22Buff = "70b71910-1c40-476a-84d6-cd838ced2260";
    internal const string SpellResistance22ShieldBuff = "15c1bbf0-db26-4a92-b309-345f8159395c";

    internal const string WyrmsbreathEffect = "834c540c-25f8-4341-956e-cf3d5c7b9172";
    internal const string WyrmsbreathBuff = "904e71ac-9dab-4880-92c0-63c3c33ebaab";
    internal const string WyrmsbreathResource = "a4fc0d20-70cf-4350-9c92-f7fe2ce987be";

    internal const string WyrmsbreathAcidAbility = "47d87415-0471-4a90-91ac-070dc3c74d7a";
    internal const string WyrmsbreathColdAbility = "7c9acbf9-3b16-4abd-b287-0697c342d303";
    internal const string WyrmsbreathElectricityAbility = "f6bdf2f2-97c8-4a3a-ad09-03c19984a121";
    internal const string WyrmsbreathFireAbility = "ee07cef2-167a-46ef-953b-e7a8e596b744";
    #endregion

    #region Legendary Weapon
    internal const string LegendaryWeapon = "d21246ce-21dc-4489-b3d4-746ec56ad4d4";
    internal const string LegendaryWeaponAbility = "f1c418f2-4184-41dd-ae6b-7b099c39fc55";
    internal const string LegendaryWeaponResource = "e43a806b-55be-42b7-9b31-3dd502d98132";

    internal const string LegendaryOffHand = "066851c2-7e02-403e-8180-737f1bb63737";
    internal const string LegendaryOffHandAbility = "d241dda4-6ae1-4d80-954c-d529e0ba8565";
    internal const string LegendaryOffHandResource = "1cf05e9b-a91e-4227-a3a9-b2e2e78d4c3b";

    #region Aligned
    internal const string AnarchicEnchantCopy = "ce30e25a-c486-4bcf-86a7-aebb49a4d5fd";
    internal const string AnarchicBuff = "7fb69f0d-d42c-4ed5-834f-55c370e24a5b";
    internal const string AnarchicEffect = "2db78f54-8ca3-4f6d-932a-4af1333c8b33";
    internal const string AnarchicOffHandBuff = "3983cf73-b0c9-4312-b7a6-fcd9465cab13";
    internal const string AnarchicOffHandEffect = "6cda7695-3744-4066-8106-5d6ab893ae0a";

    internal const string AxiomaticEnchantCopy = "ef8d7f5c-b602-4c2e-9171-d59148adf7a2";
    internal const string AxiomaticBuff = "739364fd-e9b4-4443-922b-d76644c04fd4";
    internal const string AxiomaticEffect = "4a3f6871-9524-4bc1-8924-76125c5dbb2c";
    internal const string AxiomaticOffHandBuff = "c7e82684-7db6-488d-bea5-3aaa703be1ef";
    internal const string AxiomaticOffHandEffect = "de65125c-d25c-405e-81c3-147a214ae76f";

    internal const string HolyEnchantCopy = "2f11ec34-baee-40f6-9ce8-98e1e16cef0c";
    internal const string HolyBuff = "cb4879ca-ebd6-41bb-bb37-0cdc01f75279";
    internal const string HolyEffect = "0fa7d3e8-c4d3-4ab1-ad75-c651016f93b8";
    internal const string HolyOffHandBuff = "1ac96982-430d-4813-9c59-4767701e79cb";
    internal const string HolyOffHandEffect = "5f066698-2c6e-49a5-8257-1f5fc99e4644";

    internal const string UnholyEnchantCopy = "4557af10-6fff-4ea1-9597-13d643038002";
    internal const string UnholyBuff = "491bdb14-96f7-4df8-a514-490535173793";
    internal const string UnholyEffect = "4eb299b0-ebb5-4411-a176-b1f86c490757";
    internal const string UnholyOffHandBuff = "d6ac35f8-67d0-428c-843d-51e9c12ac524";
    internal const string UnholyOffHandEffect = "8cfa8aee-d292-457f-9a24-d4087db80b57";
    #endregion

    #region Bane
    internal const string BaneAberrationsEnchantCopy = "167198e9-4113-48b5-b512-1512e4fb9530";
    internal const string BaneAberrationsEffect = "26cd7f9c-3918-416d-bb18-76fd6c661473";
    internal const string BaneAberrationsBuff = "86bbf892-b3be-41f6-a4e0-3741dd9f80e6";
    internal const string BaneAberrationsOffHandEffect = "2ffcb62a-0f50-44fa-bea8-ba97e4bc44b0";
    internal const string BaneAberrationsOffHandBuff = "ce6e2ae7-cd8a-44a9-98b7-f57fbc196f78";

    internal const string BaneAnimalsEnchantCopy = "4da5ea16-6441-4100-84eb-eaf266a8c7b3";
    internal const string BaneAnimalsEffect = "20b09219-0b83-4237-9952-144c5716ca2a";
    internal const string BaneAnimalsBuff = "1392ee6e-2656-4ef4-9d70-e5acab76144b";
    internal const string BaneAnimalsOffHandEffect = "2680b317-724b-4622-9ee5-e16fedd5365e";
    internal const string BaneAnimalsOffHandBuff = "05dfac76-360b-47fc-8241-1c0a33da2221";

    internal const string BaneConstructsEnchantCopy = "c29fdd0e-fd5b-4996-a836-af00c25018e0";
    internal const string BaneConstructsEffect = "d578d3ad-a0fa-45dd-84e5-8b413887fe4a";
    internal const string BaneConstructsBuff = "0b3448b2-99c4-497a-b416-4e277d81fe81";
    internal const string BaneConstructsOffHandEffect = "87bf6bfb-a258-48b9-b4cf-eea26521015c";
    internal const string BaneConstructsOffHandBuff = "40e909df-2763-4b55-96cf-7aeee0f8debe";

    internal const string BaneDragonsEnchantCopy = "d9e9084c-4b76-4588-bc81-f2d57cf8b97a";
    internal const string BaneDragonsEffect = "4b9af299-1774-4028-b792-fdbf6af22933";
    internal const string BaneDragonsBuff = "c4137bad-890a-47dc-bfc9-2c31f974beeb";
    internal const string BaneDragonsOffHandEffect = "b62b6ffd-aca5-49ec-835f-69fed541cf7d";
    internal const string BaneDragonsOffHandBuff = "c7ff2350-8a07-4579-82ff-c10daf58e395";

    internal const string BaneFeyEnchantCopy = "506b7dc9-c475-40b8-975d-2c22695ea0a8";
    internal const string BaneFeyEffect = "a1222582-54c4-47ba-8ca9-17dc8267dd48";
    internal const string BaneFeyBuff = "7449b6e3-3e0e-485c-829d-744750356a90";
    internal const string BaneFeyOffHandEffect = "7a7fffe1-fcf7-441b-85e2-c44588687a93";
    internal const string BaneFeyOffHandBuff = "db82d7e1-fec9-4388-afeb-042bddebb12e";

    internal const string BaneHumanoidGiantEnchantCopy = "f39c8cb5-e834-422b-a2be-539f317194c4";
    internal const string BaneHumanoidGiantEffect = "6cd57c75-6406-46ae-a07e-271e134f9599";
    internal const string BaneHumanoidGiantBuff = "1343c94b-e317-4ddb-90d1-ddfaed3f9ec9";
    internal const string BaneHumanoidGiantOffHandEffect = "1ceb03c4-6d52-48d5-8125-2686ea1e68f8";
    internal const string BaneHumanoidGiantOffHandBuff = "4b35fe40-2cec-4926-8bd3-1893318946ef";

    internal const string BaneHumanoidReptilianEnchantCopy = "7d31a08a-091a-4c3e-845b-cac752f00b48";
    internal const string BaneHumanoidReptilianEffect = "c538d0ae-fe14-4675-98aa-7d514decbd27";
    internal const string BaneHumanoidReptilianBuff = "f3c52a04-2288-4981-a62a-40109c984f95";
    internal const string BaneHumanoidReptilianOffHandEffect = "b05e03af-b745-40e1-b201-011790072a47";
    internal const string BaneHumanoidReptilianOffHandBuff = "ffbbef60-cdd6-49df-854a-6ac2211d914d";

    internal const string BaneHumanoidMonstrousEnchantCopy = "d8576737-3c43-4c7e-b84b-91cee134b53a";
    internal const string BaneHumanoidMonstrousEffect = "c5215f24-adf6-4680-9f52-6ab8a8cf53cc";
    internal const string BaneHumanoidMonstrousBuff = "44355137-0834-45d7-8d0c-933c2814dac5";
    internal const string BaneHumanoidMonstrousOffHandEffect = "7e8d4f98-27a3-4357-bfa6-948a7e6985d1";
    internal const string BaneHumanoidMonstrousOffHandBuff = "d95986d4-26fd-421c-bb6b-672d986b9d19";

    internal const string BaneMagicalBeastsEnchantCopy = "aadec2d6-895e-4450-812a-1573ecd22940";
    internal const string BaneMagicalBeastsEffect = "6ab0aa75-d20d-4205-be2e-ea574ed64431";
    internal const string BaneMagicalBeastsBuff = "1f99a96c-c10a-46ca-93b5-ee821e3af99a";
    internal const string BaneMagicalBeastsOffHandEffect = "1984f80d-178b-43e7-b9ba-574cb3d14b8b";
    internal const string BaneMagicalBeastsOffHandBuff = "c9651ae6-b710-415a-b497-976896d588d0";

    internal const string BaneOutsiderGoodEnchantCopy = "f5918c02-70cb-421e-9f44-fbbab7be34aa";
    internal const string BaneOutsiderGoodEffect = "bd73ee6f-6047-4ed7-97dc-77689fad2eea";
    internal const string BaneOutsiderGoodBuff = "c95e24ce-f033-4915-ba46-a29e632ea5a5";
    internal const string BaneOutsiderGoodOffHandEffect = "1b4cbc4a-52d3-4b19-b40c-77fa21a4d9b4";
    internal const string BaneOutsiderGoodOffHandBuff = "3ffbd7d7-c4ee-4624-b44d-0dcae088f59f";

    internal const string BaneOutsiderEvilEnchantCopy = "3b724ddc-748f-41cf-9686-e61e5ae34f78";
    internal const string BaneOutsiderEvilEffect = "633b8ffd-62e9-4378-9396-eef0eb7d6e6b";
    internal const string BaneOutsiderEvilBuff = "2b32f2da-0349-4d2b-886d-c6fb0b9efbc9";
    internal const string BaneOutsiderEvilOffHandEffect = "9dc39a25-c780-4db6-8f8d-9abf33ab3687";
    internal const string BaneOutsiderEvilOffHandBuff = "ab2b5426-5234-4a0d-a6d2-a76b29b79e3f";

    internal const string BaneOutsiderLawfulEnchantCopy = "6d793500-f4e4-4d19-88d8-29a08e0f214e";
    internal const string BaneOutsiderLawfulEffect = "e311444e-8816-4f5d-bbac-9ff159f0f50d";
    internal const string BaneOutsiderLawfulBuff = "c36b0a59-6242-4d07-8601-d637ae411187";
    internal const string BaneOutsiderLawfulOffHandEffect = "cd76446e-ca85-47fa-8f9c-49d71c53eac8";
    internal const string BaneOutsiderLawfulOffHandBuff = "69bdb177-ad92-43d2-a7c6-115b4a433331";

    internal const string BaneOutsiderChaoticEnchantCopy = "14e6b708-4341-4024-9a75-3312703525cc";
    internal const string BaneOutsiderChaoticEffect = "b0f01aca-1db1-4b42-bd56-fe056e750bbb";
    internal const string BaneOutsiderChaoticBuff = "67a7f984-a0a5-47bb-a873-82cf4166c338";
    internal const string BaneOutsiderChaoticOffHandEffect = "ec887bc5-6d85-4cbc-9d2b-99f72eae777c";
    internal const string BaneOutsiderChaoticOffHandBuff = "8771bd44-970c-4d57-8db5-132609a00010";

    internal const string BaneOutsiderNeutralEnchantCopy = "a601b497-e953-4748-8f16-ab588f3d9b44";
    internal const string BaneOutsiderNeutralEffect = "654037f4-7bc0-4e39-8fa9-19dad814793c";
    internal const string BaneOutsiderNeutralBuff = "2fac2652-a5ec-44b7-a718-3dd979c4e2c3";
    internal const string BaneOutsiderNeutralOffHandEffect = "efb08a5e-bad5-43cc-a595-93da107c5d78";
    internal const string BaneOutsiderNeutralOffHandBuff = "1311b4ec-8691-4a18-95a3-875a206dceb4";

    internal const string BanePlantsEnchantCopy = "66bff0ae-0b7b-4dbf-996e-71966343b501";
    internal const string BanePlantsEffect = "195ab6ed-0497-432c-91bd-2b55feca8e89";
    internal const string BanePlantsBuff = "89372337-a298-4cc3-aee0-3b2267ae031b";
    internal const string BanePlantsOffHandEffect = "90171cbe-debe-4086-9716-885bd251c711";
    internal const string BanePlantsOffHandBuff = "6bb662e7-fcc1-48f7-a382-64f8932b56c4";

    internal const string BaneUndeadEnchantCopy = "ff05b89a-2fe0-480e-acb5-d995db466a6b";
    internal const string BaneUndeadEffect = "8d12b391-66e9-4efa-9d20-c2f2ab2881d2";
    internal const string BaneUndeadBuff = "816efdd2-7ed5-40c0-82a7-0f07160ef6f0";
    internal const string BaneUndeadOffHandEffect = "b9627943-d0a4-441e-a8b3-57103332109a";
    internal const string BaneUndeadOffHandBuff = "9eb8eb99-84b9-40fc-80e8-15a3e8cda69f";

    internal const string BaneVerminEnchantCopy = "3f84a4c1-e3ed-4639-be42-6a5832ab4638";
    internal const string BaneVerminEffect = "f40857cf-24bc-4ccc-8f56-511d22276fc6";
    internal const string BaneVerminBuff = "9ac438a7-8a8b-4459-a0dd-a80b951a06a0";
    internal const string BaneVerminOffHandEffect = "2ceecea3-5fee-49a0-94c1-b757475bf9bf";
    internal const string BaneVerminOffHandBuff = "ff8f020d-485d-4eb4-9abd-00049c7e0fc8";
    #endregion

    internal const string BrilliantEnergyEnchantCopy = "f23463d7-aee5-4e1c-bcf6-12d5bed8da83";
    internal const string BrilliantEnergyBuff = "223d8cc8-9589-4b7f-9e70-b059b164ea7c";
    internal const string BrilliantEnergyEffect = "fea94225-69c9-44a4-94dd-711c9f2e9dcf";
    internal const string BrilliantEnergyOffHandBuff = "297b6629-07ae-4a14-a1d5-182e61a0c962";
    internal const string BrilliantEnergyOffHandEffect = "7eebfbd6-2978-4406-aa49-395473a3d4e2";

    internal const string CruelEnchantCopy = "6f646c1f-bf9d-4722-98f1-215b7b9a2ac4";
    internal const string CruelBuff = "203aa908-fe97-4890-ba65-3431789bc29f";
    internal const string CruelEffect = "432eef6e-d029-48cc-8eb1-9127fb78adb5";
    internal const string CruelOffHandBuff = "c57a472b-c7cb-407e-9ed6-bd7f0648f7b9";
    internal const string CruelOffHandEffect = "c05a21dd-2a8f-4411-abf3-eb1dc4b0431c";

    internal const string DisruptionEnchantCopy = "ac53ee64-9b31-461f-b07c-85976b5f22c2";
    internal const string DisruptionBuff = "870b65ba-9340-4251-bb36-c0394d4fd707";
    internal const string DisruptionEffect = "620fc9ef-b25d-4f81-a582-10ebad78037c";
    internal const string DisruptionOffHandBuff = "92215b67-2232-4828-b240-08a0d10c90fe";
    internal const string DisruptionOffHandEffect = "2f6d54ed-a3e7-404d-89c6-d26f684fd37e";

    #region Elemental
    internal const string CorrosiveEnchantCopy = "414a1d7d-8bff-45f0-9ed9-1fe05b379532";
    internal const string CorrosiveBuff = "59021693-62be-4be5-85cd-6a1598348c90";
    internal const string CorrosiveEffect = "fd68cd77-05c0-4f8b-a34e-047ce37c10df";
    internal const string CorrosiveOffHandBuff = "9bd11c5b-e7c9-4369-87db-88cabb6283da";
    internal const string CorrosiveOffHandEffect = "1613c489-1c26-4f36-b55e-30bfad52c327";

    internal const string CorrosiveBurstEnchantCopy = "0e1d954e-2404-422d-85a6-464445642be6";
    internal const string CorrosiveBurstBuff = "bdfb34a0-fa61-4943-a372-f873a89ccbd4";
    internal const string CorrosiveBurstEffect = "bc00ab1d-9db8-4a14-87a2-69ba1a62583e";
    internal const string CorrosiveBurstOffHandBuff = "58afa2ce-149b-40e2-883a-00a260b83b30";
    internal const string CorrosiveBurstOffHandEffect = "c0712ed6-a5dc-4a13-ab6d-5e50a811e58d";

    internal const string FlamingEnchantCopy = "d5175ff6-fd78-4d0a-a473-6983e0f7df23";
    internal const string FlamingBuff = "f442738a-81a1-436d-b465-f9ffdaaac2c8";
    internal const string FlamingEffect = "413ee8a3-e4a2-4c25-b95f-34a15e90f1a1";
    internal const string FlamingOffHandBuff = "67ca3c41-5f3a-4f9a-b877-b32d8f53cf5a";
    internal const string FlamingOffHandEffect = "df3a9d56-7118-41dc-9986-94b53738ea75";

    internal const string FlamingBurstEnchantCopy = "86de020f-5255-44ee-ae15-d6133aef8868";
    internal const string FlamingBurstBuff = "bf5309f0-6fd5-4e4b-bad4-41bdb2f5fa98";
    internal const string FlamingBurstEffect = "695c0008-692d-4b4e-9d2c-f54fc13e381d";
    internal const string FlamingBurstOffHandBuff = "bca7d0ab-8398-4d52-8eb4-ca5437a81231";
    internal const string FlamingBurstOffHandEffect = "dd8a63d8-24e9-4685-a97d-93ee98312c28";

    internal const string FrostEnchantCopy = "b0cec783-e300-436a-818a-6df5b3343928";
    internal const string FrostBuff = "9660ec9d-0154-41d5-9d6e-934842956c1d";
    internal const string FrostEffect = "d130c546-f304-47eb-9e0e-aa59c3bfcd63";
    internal const string FrostOffHandBuff = "f6a6e6e9-0157-4521-9a40-a7a4f2bd6e74";
    internal const string FrostOffHandEffect = "18a52b28-0a66-4635-b101-16fc65eed553";

    internal const string FrostBurstEnchantCopy = "492cc3f4-bc49-48be-89e1-dd15ac5ea92b";
    internal const string FrostBurstBuff = "18edc29f-1875-47b3-be96-fafffe7d26b1";
    internal const string FrostBurstEffect = "55990a44-19f7-4f51-a497-e05dbd022517";
    internal const string FrostBurstOffHandBuff = "095b455c-3e5a-4267-8811-f7c452e0912a";
    internal const string FrostBurstOffHandEffect = "2931f47d-dce0-432c-a495-04ed646b6182";

    internal const string ShockingEnchantCopy = "f7bf56b6-7362-45fc-baf3-f1d9ca03d73a";
    internal const string ShockingBuff = "c08b4487-2ae4-4fdf-b005-09a333f93240";
    internal const string ShockingEffect = "3b701980-2283-4422-b3c0-bab8a600e4e0";
    internal const string ShockingOffHandBuff = "adc49834-2bce-457e-a940-12b2a5c9add3";
    internal const string ShockingOffHandEffect = "a47ac76a-2c93-49fa-a5e0-d30ec41391ab";

    internal const string ShockingBurstEnchantCopy = "2b0ccc0c-307c-4eca-be37-9a1fdd218117";
    internal const string ShockingBurstBuff = "463f118d-272c-4b79-8791-26ef1834c803";
    internal const string ShockingBurstEffect = "e9903bae-a045-446c-b74a-5bbb7ab30cb2";
    internal const string ShockingBurstOffHandBuff = "d9b70c17-fb3b-4577-8fe1-9a8868fa80f6";
    internal const string ShockingBurstOffHandEffect = "225ac6d6-05c5-4907-8150-046139770b33";

    internal const string ThunderingEnchantCopy = "31dbf01c-b045-49c5-838f-5b7efc5cc285";
    internal const string ThunderingBuff = "1b6e7c76-a3e2-48cd-835a-968a12aeeb85";
    internal const string ThunderingEffect = "88a91a89-a2fe-4c1e-9220-c9c5ac8ba4c1";
    internal const string ThunderingOffHandBuff = "59bf1e95-abd5-418e-ad0a-b2fdaf679791";
    internal const string ThunderingOffHandEffect = "7ff2f114-f972-4753-aac0-3634a248b683";

    internal const string ThunderingBurstEnchantCopy = "20d17c46-38f6-4099-be44-61f13a24c5c3";
    internal const string ThunderingBurstBuff = "125a95f1-fd5d-495b-b5ee-c59f254a20c7";
    internal const string ThunderingBurstEffect = "4ef1c726-aca8-41cf-a190-a7262394e76f";
    internal const string ThunderingBurstOffHandBuff = "98b0d30d-d5e4-41f6-b7ba-e42000204249";
    internal const string ThunderingBurstOffHandEffect = "a74c44d6-e3f8-4d3b-8b62-89ab34ee4d15";
    #endregion

    internal const string FuriousEnchantCopy = "003429f8-c879-46d0-b61e-9d3de2c87064";
    internal const string FuriousBuff = "d3a5ee89-2229-4363-83e2-c084d465a5b9";
    internal const string FuriousEffect = "358b988a-c8c0-4c08-bea2-eb13ecbfee3f";
    internal const string FuriousOffHandBuff = "5528b7f9-aa1e-46fc-91cc-2a56dff3379b";
    internal const string FuriousOffHandEffect = "34f1c59c-0d40-443d-babf-bee92f99a7d7";

    internal const string FurybornEnchantCopy = "79fe08ed-b3de-401d-920e-1f617b9eb14c";
    internal const string FurybornBuff = "5375df52-a30b-4747-948f-717146b87313";
    internal const string FurybornEffect = "be71b219-dddc-437f-9506-6ab98bc4ee8a";
    internal const string FurybornOffHandBuff = "c6c6d634-9855-4965-85cf-b1e866d01c01";
    internal const string FurybornOffHandEffect = "d3f9ba08-37ef-43bc-894e-1962a1ec5cff";

    internal const string GhostTouchEnchantCopy = "2644029e-97bb-40dc-a7cb-ec2e35c58f77";
    internal const string GhostTouchBuff = "44daeabf-f774-4139-9be2-5ea702f3336d";
    internal const string GhostTouchEffect = "8e837ee5-8df1-4503-ab42-f43937104831";
    internal const string GhostTouchOffHandBuff = "8ba2cbdf-72e0-44ed-a2c4-997aff2e75dc";
    internal const string GhostTouchOffHandEffect = "80aba733-2e12-4111-b981-7277f4b340b8";

    internal const string HeartseekerEnchantCopy = "baf17287-e1c4-4d69-a8ef-8708e754df96";
    internal const string HeartseekerBuff = "3be8c66f-e7da-4f64-8d23-e0b96fb22f2a";
    internal const string HeartseekerEffect = "5e7e0efc-2921-4128-97c2-c4dd17c4f54b";
    internal const string HeartseekerOffHandBuff = "bfc38426-fd8c-4f89-8d0a-48b2edb91437";
    internal const string HeartseekerOffHandEffect = "20b82354-6e97-4127-8587-89a1a82d814c";

    internal const string KeenEnchantCopy = "98b46ce1-bed3-47c6-976e-ec8b1e8c4d03";
    internal const string KeenBuff = "40b6c8c0-3013-4777-9173-bf270d4c04f2";
    internal const string KeenEffect = "f89239b5-cd80-4b4d-b1c7-4b9d30fdba27";
    internal const string KeenOffHandBuff = "ddec7c67-e357-4964-9e01-c57310fbca14";
    internal const string KeenOffHandEffect = "48c41966-78f2-44bf-af4b-ab1672a4b5d9";

    internal const string NullifyingEnchantCopy = "9cda595a-3fcd-4ae8-bffa-94051317fb23";
    internal const string NullifyingBuff = "53755dd2-a2c6-4315-8161-9ebb95fd70f4";
    internal const string NullifyingEffect = "6091c9b0-a870-437a-bb19-a35852de58c9";
    internal const string NullifyingOffHandBuff = "b732f30a-e39a-4a39-8250-442f1523728a";
    internal const string NullifyingOffHandEffect = "be9003ae-3199-4003-a281-fa9e5fe84a4a";

    internal const string SpeedEnchantCopy = "b334274e-98f3-4d1a-85dd-2fec32194c71";
    internal const string SpeedBuff = "96db140b-5594-43be-a5c9-2638c06d84b7";
    internal const string SpeedEffect = "33eef0e2-94d0-4278-af9e-c7de15bae40a";
    internal const string SpeedOffHandBuff = "f6aa3e9f-9936-481e-99f4-6463983834b6";
    internal const string SpeedOffHandEffect = "b7925863-7804-4a90-b72e-98a87f6000f3";

    internal const string ViciousEnchantCopy = "15156622-869e-4659-9ce5-96af1efadee3";
    internal const string ViciousBuff = "643d73c3-fc70-4586-bb9e-c61c38965b52";
    internal const string ViciousEffect = "87ad40c7-b53e-4338-909d-0767e3fbfacd";
    internal const string ViciousOffHandBuff = "6cf56b5f-3cbe-4b47-b282-ac97a94ec4df";
    internal const string ViciousOffHandEffect = "b074977a-a62c-40b3-aa2a-1c4260513198";

    internal const string VorpalEnchantCopy = "a93adad6-3c20-4d6a-a158-6b76c3a45910";
    internal const string VorpalBuff = "13d7b04c-9bb2-4bfc-9dfb-5abf591c707f";
    internal const string VorpalEffect = "7e13f050-52b7-493a-add6-7070930df8a1";
    internal const string VorpalOffHandBuff = "75516c9a-f165-4b56-acba-042ca6f6fb86";
    internal const string VorpalOffHandEffect = "a6caa93e-6e15-40a2-bc2c-c746b6e12803";
    #endregion
    #endregion

    #region DLC
    internal const string Rekarth_FeatureList = "53593192-0946-4482-8959-3db1c1f10e80";
    #endregion

    #region From Mods
    // Expanded Content - Anti-Paladin Smite
    internal const string SinfulAbsolutionBuff = "B13960D1-559A-414D-819B-FA53CF8526D4";

    // Microscopic Content Expansion - Anti-Paladin Smite
    internal const string SmiteGoodBuff = "7ff9e143-dd21-4641-a7f5-3ee10d7e98b5";
    #endregion
  }
}