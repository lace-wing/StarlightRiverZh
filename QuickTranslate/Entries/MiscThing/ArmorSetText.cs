/* using StarlightRiverZh.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace StarlightRiverZh.QuickTranslate.MiscThing {
    public class BreacherChest : TypeEntry {
        public BreacherChest() : base(typeof(StarlightRiver.Content.Items.Breacher.BreacherChest)) {}

        public override void Load() {
            MethodInfo Breacher = TargetType.GetMethod("UpdateArmorSet", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Breacher,
            "A spotter drone follows you, building energy with kills\nDouble tap DOWN to consume it and call down an orbital strike on an enemy",
            Language.GetText("Mods.StarlightRiverZh.MiscText.ArmorSet.Breacher").Value);
        }
    }

    public class GeomancerRobe : TypeEntry {
        public GeomancerRobe() : base(typeof(StarlightRiver.Content.Items.Geomancer.GeomancerRobe)) {}

        public override void Load() {
            MethodInfo Geomancer = TargetType.GetMethod("UpdateArmorSet", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Geomancer,
            "Kills and critical strikes with magic have a chance to drop magic gems\n" +
			"Each gem activates a different effect when picked up\n" +
			"Obtaining another gem stores the previous effect\n" +
			"Collecting all briefly activates every effect at once",
            Language.GetText("Mods.StarlightRiverZh.MiscText.ArmorSet.Geomancer").Value);
        }
    }

    public class MoonstoneHead : TypeEntry {
        public MoonstoneHead() : base(typeof(StarlightRiver.Content.Items.Moonstone.MoonstoneHead)) {}

        public override void Load() {
            MethodInfo Moonstone = TargetType.GetMethod("UpdateArmorSet", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Moonstone,
            "Accumulate lunar energy by dealing melee damage\nDouble tap DOWN to summon the legendary spear Datsuzei\nDatsuzei consumes this lunar energy and dissapears at zero",
            Language.GetText("Mods.StarlightRiverZh.MiscText.ArmorSet.Moonstone").Value);

            MethodInfo MoonstoneHead2 = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(MoonstoneHead2,
            "hold UP for Datsuzei stats",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.MoonstoneHead").Value);
        }
    }

    public class PoltergeistHead : TypeEntry {
        public PoltergeistHead() : base(typeof(StarlightRiver.Content.Items.Haunted.PoltergeistHead)) {}

        public override void Load() {
            MethodInfo Haunted = TargetType.GetMethod("UpdateArmorSet", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Haunted,
            "Double tap DOWN with a magic weapon to haunt or unhaunt it, or with an empty hand to unhaunt all\n" +
			"Haunted weapons float around you and attack automatically, but {{Reserve}} mana\n" +
			"Haunted weapons become disinterested in non-magic users and can't be used while haunted",
            Language.GetText("Mods.StarlightRiverZh.MiscText.ArmorSet.Haunted").Value);
            TranslateTargetType(Haunted,
            "Your haunted weapons seem bored...",
            Language.GetText("Mods.StarlightRiverZh.MiscText.ArmorSet.HauntedBored").Value);
        }
    }

    public class SlimePrinceHead : TypeEntry {
        public SlimePrinceHead() : base(typeof(StarlightRiver.Content.Items.Forest.SlimePrinceHead)) {}

        public override void Load() {
            MethodInfo Forest = TargetType.GetMethod("UpdateArmorSet", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Forest,
            "A slime prince follows you around\nDouble tap DOWN to fuse with the prince\nYou can control the prince during this time\nThe prince takes damage instead of you during this time",
            Language.GetText("Mods.StarlightRiverZh.MiscText.ArmorSet.Forest").Value);
        }
    }

    public class StarwoodChest : TypeEntry {
        public StarwoodChest() : base(typeof(StarlightRiver.Content.Items.Starwood.StarwoodChest)) {}

        public override void Load() {
            MethodInfo Starwood = TargetType.GetMethod("UpdateArmorSet", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Starwood,
            "Picking up mana stars empowers Starwood items, temporarily granting them new effects\nAll enemies have a chance of dropping mana stars on death",
            Language.GetText("Mods.StarlightRiverZh.MiscText.ArmorSet.Starwood").Value);
        }
    }

    public class VitricHead : TypeEntry {
        public VitricHead() : base(typeof(StarlightRiver.Content.Items.Vitric.VitricHead)) {}

        public override void Load() {
            MethodInfo Vitric = TargetType.GetMethod("UpdateArmorSet", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Vitric,
            "Accumulate powerful glass shards over time\nDouble tap DOWN to load these shards into your bow\nShards fired from bows have high velocity and damage",
            Language.GetText("Mods.StarlightRiverZh.MiscText.ArmorSet.Vitric").Value);
        }
    }
} */