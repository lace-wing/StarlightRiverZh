using StarlightRiverZh.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace StarlightRiverZh.QuickTranslate.MiscThing {
    public class DefenseSystem : TypeEntry {
        public string dealerName = "军火商";
        public DefenseSystem() : base(typeof(StarlightRiver.Content.Items.ArmsDealer.DefenseSystem)) {}

        public override void Load() {

            MethodInfo DefenseSystem = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(DefenseSystem,
            $"{dealerName}'s Defense System",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.DefenseSystem").Value);
            //TODO: public string dealerName = "Arms Dealer"; 不知道怎么加
        }
    }

    public class RelicItem : TypeEntry {
        public RelicItem() : base(typeof(StarlightRiver.Content.Items.BaseTypes.RelicItem)) {}

        public override void Load() {
            MethodInfo RelicItem = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(RelicItem,
            "Twice ",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.RelicItem1").Value);
            TranslateTargetType(RelicItem,
            "Cannot be reforged",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.RelicItem2").Value);
        }
    }

    public class MultiAmmoWeapon : TypeEntry {
        public Item ammoItem;
        public MultiAmmoWeapon() : base(typeof(StarlightRiver.Content.Items.BaseTypes.MultiAmmoWeapon)) {}

        public override void Load() {
            MethodInfo MultiAmmoWeapon = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(MultiAmmoWeapon,
            $"Current Ammo: [i:{ammoItem.type}]{ammoItem.stack}",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.MultiAmmoWeapon").Value);
        }
    }

    public class Ingredient : TypeEntry {
        public Ingredient() : base(typeof(StarlightRiver.Content.Items.Food.Ingredient)) {}

        public override void Load() {
            MethodInfo Ingredient = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Ingredient,
            "adds ",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.Ingredient1").Value);
            TranslateTargetType(Ingredient,
            " seconds duration to food",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.Ingredient2").Value);

            MethodInfo Ingredient2 = TargetType.GetMethod("GetDescription", BindingFlags.Public | BindingFlags.Static);
            TranslateTargetType(Ingredient2,
            "Main Course",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.Ingredient3").Value);
            TranslateTargetType(Ingredient2,
            "Side Dish",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.Ingredient4").Value);
            TranslateTargetType(Ingredient2,
            "Seasonings",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.Ingredient5").Value);
            TranslateTargetType(Ingredient2,
            "Bonus Effects",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.Ingredient6").Value);
        }
    }

    public class Meal : TypeEntry {
        public Meal() : base(typeof(StarlightRiver.Content.Items.Food.Meal)) {}

        public override void Load() {
            MethodInfo Meal = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Meal,
            " with ",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.Meal1").Value);
            TranslateTargetType(Meal,
            " and ",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.Meal2").Value);
            TranslateTargetType(Meal,
            " seconds duration",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.Meal3").Value);
            TranslateTargetType(Meal,
            " seconds fullness",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.Meal4").Value);
        }
    }

    public class GeomancerHood : TypeEntry {
        public GeomancerHood() : base(typeof(StarlightRiver.Content.Items.Geomancer.GeomancerHood)) {}

        public override void Load() {
            MethodInfo GeomancerHood = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(GeomancerHood,
            "hold UP for buff info",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.GeomancerHood").Value);
        }
    }

    public class VengefulSpirit : TypeEntry {
        public VengefulSpirit() : base(typeof(StarlightRiver.Content.Items.Haunted.VengefulSpirit)) {}

        public override void Load() {
            MethodInfo VengefulSpirit = TargetType.GetMethod("SetStaticDefaults", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(VengefulSpirit,
            "Dropped after beating either King Slime, Eye of Cthulhu, or Auroracle",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.VengefulSpirit").Value);
        }
    }

    public class CasualMirrorPlayer : TypeEntry {
        public CasualMirrorPlayer() : base(typeof(StarlightRiver.Content.Items.Misc.CasualMirrorPlayer)) {}

        public override void Load() {
            MethodInfo CasualMirrorPlayer = TargetType.GetMethod("PreKill", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(CasualMirrorPlayer,
            " didn't read the tooltip",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.CasualMirrorPlayer").Value);
        }
    }

    public class GuillotineVFX : TypeEntry {
        public GuillotineVFX() : base(typeof(StarlightRiver.Content.Items.Misc.GuillotineVFX)) {}

        public override void Load() {
            MethodInfo GuillotineVFX = TargetType.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(GuillotineVFX,
            "Ouch!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.GuillotineVFX").Value);
        }
    }

    public class JadeStopwatch : TypeEntry {
        public string feat;
        public string time;
        public JadeStopwatch() : base(typeof(StarlightRiver.Content.Items.Misc.JadeStopwatch)) {}

        public override void Load() {
            MethodInfo JadeStopwatch = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(JadeStopwatch,
            $"Obtained by beating {feat} in {time}",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.JadeStopwatch").Value);
        }
    }

    public class SwordBookParry : TypeEntry {
        public SwordBookParry() : base(typeof(StarlightRiver.Content.Items.Misc.SwordBookParry)) {}

        public override void Load() {
            MethodInfo SwordBookParry = TargetType.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(SwordBookParry,
            "Parry",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.SwordBookParry1").Value);
            TranslateTargetType(SwordBookParry,
            "Cant block!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.SwordBookParry2").Value);
        }
    }

    public class ElectroArrow : TypeEntry {
        public ElectroArrow() : base(typeof(StarlightRiver.Content.Items.Misc.ElectroArrow)) {}

        public override void Load() {
            MethodInfo ElectroArrow = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(ElectroArrow,
            "Deals 25% bow damage",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.ElectroArrow1").Value);
            TranslateTargetType(ElectroArrow,
            "Cannot critically strike",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.ElectroArrow2").Value);
        }
    }

    public class SoilgunGlobalItem : TypeEntry {
        public SoilgunGlobalItem() : base(typeof(StarlightRiver.Content.Items.Misc.SoilgunFiles.SoilgunGlobalItem)) {}

        public override void Load() {
            MethodInfo SoilgunGlobalItem = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(SoilgunGlobalItem,
            "This item can be used as ammo for the Soilgun and Earthduster",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.SoilgunGlobalItem").Value);

            TranslateTargetType(SoilgunGlobalItem,
            "When used with the Soilgun or Earthduster, it will fire out blocks of glassy sand, that cause crystals to grow out of enemies\nFor each crystal an enemy has, they take 2 damage per second, plus a base damage of 4, up to a maximum of 10 crystals\nIf an enemy has had 10 crystals on them for more than 4 seconds, all crystals become charged, exploding shorty after",
            Language.GetText($"Mods.StarlightRiverZh.MiscText.Item.SoilgunGlobalItemTip.1").Value);
            TranslateTargetType(SoilgunGlobalItem,
            "When used with the Soilgun or Earthduster, it will fire out blocks of sand that split into many grains of sand upon death",
            Language.GetText($"Mods.StarlightRiverZh.MiscText.Item.SoilgunGlobalItemTip.2").Value);
            TranslateTargetType(SoilgunGlobalItem,
            "When used with the Soilgun or Earthduster, it will fire out blocks of Crimsand that steal life from hit enemies",
            Language.GetText($"Mods.StarlightRiverZh.MiscText.Item.SoilgunGlobalItemTip.3").Value);
            TranslateTargetType(SoilgunGlobalItem,
            "When used with the Soilgun or Earthduster, it will fire out blocks of Ebonsand that apply stacks of Haunted to enemies",
            Language.GetText($"Mods.StarlightRiverZh.MiscText.Item.SoilgunGlobalItemTip.4").Value);
            TranslateTargetType(SoilgunGlobalItem,
            "When used with the Soilgun or Earthduster, it will fire out blocks of Pearlsand that home in on enemies",
            Language.GetText($"Mods.StarlightRiverZh.MiscText.Item.SoilgunGlobalItemTip.5").Value);
            TranslateTargetType(SoilgunGlobalItem,
            "When used with the Soilgun or Earthduster, it will fire out blocks of dirt",
            Language.GetText($"Mods.StarlightRiverZh.MiscText.Item.SoilgunGlobalItemTip.6").Value);
            TranslateTargetType(SoilgunGlobalItem,
            "When used with the Soilgun or Earthduster, it will fire out blocks of silt, that spawn coins upon hitting enemies",
            Language.GetText($"Mods.StarlightRiverZh.MiscText.Item.SoilgunGlobalItemTip.7").Value);
            TranslateTargetType(SoilgunGlobalItem,
            "When used with the Soilgun or Earthduster, it will fire out blocks of slush that cause hit enemies to have icicles impale them\nHitting and enemy with more than 10 icicles causes all icicles to shatter, causing large amounts of damage",
            Language.GetText($"Mods.StarlightRiverZh.MiscText.Item.SoilgunGlobalItemTip.8").Value);
            TranslateTargetType(SoilgunGlobalItem,
            "When used with the Soilgun or Earthduster, it will fire out blocks of mud that bounce off tiles and enemies",
            Language.GetText($"Mods.StarlightRiverZh.MiscText.Item.SoilgunGlobalItemTip.9").Value);
        }
    }

    public class MoonstoneChest : TypeEntry {
        public MoonstoneChest() : base(typeof(StarlightRiver.Content.Items.Moonstone.MoonstoneChest)) {}

        public override void Load() {
            MethodInfo MoonstoneChest = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(MoonstoneChest,
            "hold UP for Datsuzei stats",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.MoonstoneHead").Value);
        }
    }

    public class MoonstoneLegs : TypeEntry {
        public MoonstoneLegs() : base(typeof(StarlightRiver.Content.Items.Moonstone.MoonstoneLegs)) {}

        public override void Load() {
            MethodInfo MoonstoneLegs = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(MoonstoneLegs,
            "hold UP for Datsuzei stats",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.MoonstoneHead").Value);
        }
    }

    public class Shaker : TypeEntry {
        public Shaker() : base(typeof(StarlightRiver.Content.Items.Overgrow.Shaker)) {}

        public override void Load() {
            MethodInfo Shaker = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Shaker,
            "Snail Speed",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.Shaker").Value);
        }
    }

    public class OverflowingUrn : TypeEntry {
        public OverflowingUrn() : base(typeof(StarlightRiver.Content.Items.Permafrost.OverflowingUrn)) {}

        public override void Load() {
            MethodInfo OverflowingUrn = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(OverflowingUrn,
            "damage over time",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.OverflowingUrn1").Value);
            TranslateTargetType(OverflowingUrn,
            "Cannot critically strike",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.OverflowingUrn2").Value);
        }
    }

    public class ArmorBag : TypeEntry {
        public ArmorBag() : base(typeof(StarlightRiver.Content.Items.Utility.ArmorBag)) {}

        public override void Load() {
            MethodInfo ArmorBag = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(ArmorBag,
            "No helmet",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.ArmorBag1").Value);
            TranslateTargetType(ArmorBag,
            "No chestplate",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.ArmorBag2").Value);
            TranslateTargetType(ArmorBag,
            "No leggings",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.ArmorBag3").Value);
            TranslateTargetType(ArmorBag,
            "Right click to equip stored armor\n" +
            "Right click with armor to add it to the bag\n" +
            "Ctrl-Right click to empty the bag",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.ArmorBag4").Value);
        }
    }

    public class ChefBag : TypeEntry {
        public ChefBag() : base(typeof(StarlightRiver.Content.Items.Utility.ChefBag)) {}

        public override void Load() {
            MethodInfo ChefBag = TargetType.GetMethod("SpecialIngredientPickup", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(ChefBag,
            "Ingredient added to chefs bag",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.ChefBag").Value);
        }
    }

    public class GlassReplica : TypeEntry {
        public GlassReplica() : base(typeof(StarlightRiver.Content.Items.Vitric.GlassReplica)) {}

        public override void Load() {
            MethodInfo GlassReplica = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(GlassReplica,
            "Replica ",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.GlassReplica").Value);
        }
    }

    public class ForgeMap : TypeEntry {
        public ForgeMap() : base(typeof(StarlightRiver.Content.Items.Vitric.ForgeMap)) {}

        public override void Load() {
            MethodInfo ForgeMap = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(ForgeMap,
            "Glassweaver's... Map?",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.ForgeMap1").Value);
            TranslateTargetType(ForgeMap,
            "Erm... This doesn't look quit right...",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.ForgeMap2").Value);
            TranslateTargetType(ForgeMap,
            "Glassweaver's Great Map of the Grand Forge Temple",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.ForgeMap3").Value);
        }
    }

    public class Coalescence : TypeEntry {
        public Coalescence() : base(typeof(StarlightRiver.Content.Items.Vitric.Coalescence)) {}

        public override void Load() {
            MethodInfo Coalescence = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Coalescence,
            "Slow charge",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.Coalescence").Value);
        }
    }

    public class FacetAndLattice : TypeEntry {
        public FacetAndLattice() : base(typeof(StarlightRiver.Content.Items.Vitric.FacetAndLattice)) {}

        public override void Load() {
            MethodInfo FacetAndLattice = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(FacetAndLattice,
            "50 shield life",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.FacetAndLattice").Value);
        }
    }

    public class LatticeProjectile : TypeEntry {
        public LatticeProjectile() : base(typeof(StarlightRiver.Content.Items.Vitric.LatticeProjectile)) {}

        public override void Load() {
            MethodInfo LatticeProjectile = TargetType.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(LatticeProjectile,
            "Cant block!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.SwordBookParry2").Value);
        }
    }
}