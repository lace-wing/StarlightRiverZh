using StarlightRiverZh.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace StarlightRiverZh.QuickTranslate.MiscThing {
    public class Blink : TypeEntry {
        public Blink() : base(typeof(StarlightRiver.Content.Abilities.ForbiddenWinds.Pulse)) {}

        public override void Load() {
            MethodInfo Pulse = TargetType.GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Pulse,
            "Implement Objectives",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Abilities.ImplementObjectives").Value);
        }
    }

    public class Astral : TypeEntry {
        public Astral() : base(typeof(StarlightRiver.Content.Abilities.ForbiddenWinds.Astral)) {}

        public override void Load() {
            MethodInfo Astral = TargetType.GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Astral,
            "Strike Foes",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Abilities.StrikeFoes").Value);
            TranslateTargetType(Astral,
            "Loot Fallen Stars",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Abilities.LootFallenStars").Value);
        }
    }

    public class Blink : TypeEntry {
        public Blink() : base(typeof(StarlightRiver.Content.Abilities.ForbiddenWinds.Astral)) {}

        public override void Load() {
            MethodInfo Blink = TargetType.GetMethod("SetDefaults", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Blink,
            "Implement Objectives",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Abilities.ImplementObjectives").Value);
        }
    }

    public class HintAbility : TypeEntry {
        public HintAbility() : base(typeof(StarlightRiver.Content.Abilities.Hint.HintAbility)) {}

        public override void Load() {
            MethodInfo HintAbility = TargetType.GetMethod("OnActivate", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(HintAbility,
            "Nothing interesting here...",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Abilities.Hint.HintToDisplay1").Value);
            TranslateTargetType(HintAbility,
            $"It's my good friend, {npc.FullName}!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Abilities.Hint.HintToDisplay2").Value);
            TranslateTargetType(HintAbility,
            $"Thats {npc.FullName}! Focus!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Abilities.Hint.HintToDisplay3").Value);
            TranslateTargetType(HintAbility,
            $"It's just a {npc.FullName}.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Abilities.Hint.HintToDisplay4").Value);
            TranslateTargetType(HintAbility,
            $"It's just some {ProcessName(TileID.Search.GetName(tile.TileType))}...",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Abilities.Hint.HintToDisplay5").Value);
        }
    }

    public class InfusionImprint : TypeEntry {
        public InfusionImprint() : base(typeof(StarlightRiver.Content.Abilities.Infusions.InfusionImprint)) {}

        public override void Load() {
            MethodInfo InfusionImprint = TargetType.GetMethod("UpdateInventory", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(InfusionImprint,
            "Objectives Complete! You've obtained: ",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Abilities.Complete").Value);

            MethodInfo InfusionImprint2 = TargetType.GetMethod("ModifyTooltips", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(InfusionImprint2,
            "Imprinted slate: ",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Abilities.Imprinted").Value);
            TranslateTargetType(InfusionImprint2,
            "Complete objectives to transform into an infusion",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Abilities.Transform").Value);
        }
    }
}