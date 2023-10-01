using StarlightRiverZh.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace StarlightRiverZh.QuickTranslate.MiscThing {
    public class AbilityDisplay : TypeEntry {
        public AbilityDisplay() : base(typeof(StarlightRiver.Content.GUI.AbilityInventory)) {}

        public override void Load() {
            MethodInfo AbilityDisplay = TargetType.GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(AbilityDisplay,
            $"{ability.Name}    {ability.ActivationCostDefault} SP",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.SP").Value);
        }
    }

    public class BarrierDyeSlotElement : TypeEntry {
        public BarrierDyeSlotElement() : base(typeof(StarlightRiver.Content.GUI.BarrierDyeSlot)) {}

        public override void Load() {
            MethodInfo BarrierDyeSlotElement = TargetType.GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(BarrierDyeSlotElement,
            "Barrier Tincture",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Tincture").Value);
        }
    }

    public class BossRushMenu : TypeEntry {
        public BossRushMenu() : base(typeof(StarlightRiver.Content.GUI.BossRushButton)) {}

        public override void Load() {
            MethodInfo BossRushMenu = TargetType.GetMethod("OnInitialize", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(BossRushMenu,
            "Back",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Back").Value);
        }
    }

    public class BossRushChoice : TypeEntry {
        public BossRushChoice() : base(typeof(StarlightRiver.Content.GUI.BossRushButton)) {}

        public override void Load() {
            MethodInfo BossRushChoice = TargetType.GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(BossRushChoice,
            $"Score: {sourceScore}",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.ScoreN").Value);
            TranslateTargetType(BossRushChoice,
            "No score!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.NoScore").Value);
        }
    }

    public class BossRushScore : TypeEntry {
        public BossRushScore() : base(typeof(StarlightRiver.Content.GUI.BossRushScore)) {}

        public override void Load() {
            MethodInfo BossRushScore = TargetType.GetMethod("OnInitialize", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(BossRushScore,
            "Done",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Done").Value);

            MethodInfo BossRushScore2 = TargetType.GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(BossRushScore2,
            "Results",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Results").Value);

            TranslateTargetType(BossRushScore2,
            $"Damage: {(int)Helpers.Helper.LerpFloat(0, BossRushSystem.damageScore, progress)}",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.ResultDamage").Value);
            TranslateTargetType(BossRushScore2,
            $"Kills: {(int)Helpers.Helper.LerpFloat(0, BossRushSystem.killScore, progress)}",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.ResultKill").Value);
            TranslateTargetType(BossRushScore2,
            $"Time: {(int)Helpers.Helper.LerpFloat(0, BossRushSystem.timeScore, progress)}",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.ResultTime").Value);
            TranslateTargetType(BossRushScore2,
            $"{BossRushSystem.hitsTaken} Hits taken: {(int)Helpers.Helper.LerpFloat(0, BossRushSystem.HurtScore, progress)}",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.ResultTaken").Value);
            TranslateTargetType(BossRushScore2,
            $"Multiplier: {(int)Helpers.Helper.LerpFloat(0, BossRushSystem.scoreMult, progress)}x",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.ResultMultiplier").Value);
            TranslateTargetType(BossRushScore2,
            $"Total score: {(int)Helpers.Helper.LerpFloat(0, BossRushSystem.Score, progress)}",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.ResultTotal").Value);
        }
    }

    public class TownButton : TypeEntry {
        public TownButton() : base(typeof(StarlightRiver.Content.GUI.ChatboxOverUI)) {}

        public override void Load() {
            MethodInfo TownButton = TargetType.GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(TownButton,
            "Locked",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Locked").Value);
        }
    }

    public class CookingUI : TypeEntry {
        public CookingUI() : base(typeof(StarlightRiver.Content.GUI.CookingUI)) {}

        public override void Load() {
            MethodInfo CookingUI = TargetType.GetMethod("ScrollStats", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(CookingUI,
            "Place a Main Course in\nthe top slot to start\ncooking",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Cooking1").Value);
            TranslateTargetType(CookingUI,
            " seconds duration",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Cooking2").Value);
            TranslateTargetType(CookingUI,
            " seconds fullness",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Cooking3").Value);
        }
    }

    public class CookingSlot : TypeEntry {
        public CookingSlot() : base(typeof(StarlightRiver.Content.GUI.CookingUI)) {}

        public override void Load() {
            MethodInfo CookingSlot = TargetType.GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(CookingSlot,
            "Place [c/",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Cooking4").Value);
            TranslateTargetType(CookingSlot,
            ":",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Cooking5").Value);
            TranslateTargetType(CookingSlot,
            "] here",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Cooking6").Value);
        }
    }

    public class ExtraDefenseStats : TypeEntry {
        public ExtraDefenseStats() : base(typeof(StarlightRiver.Content.GUI.ExtraDefenseStats)) {}

        public override void Load() {
            MethodInfo ExtraDefenseStats = TargetType.GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(ExtraDefenseStats,
            $"\n{resistPercent}% {{Inoculation}}",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Inoculation").Value);
        }
    }

    public class LootUI : TypeEntry {
        public LootUI() : base(typeof(StarlightRiver.Content.GUI.LootUI)) {}

        public override void Load() {
            MethodInfo LootUI = TargetType.GetMethod("OnInitialize", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(LootUI,
            "Loot?",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Loot.1").Value);
            TranslateTargetType(LootUI,
            "Loot!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Loot.2").Value);
            TranslateTargetType(LootUI,
            "Shiny treasures!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Loot.3").Value);
            TranslateTargetType(LootUI,
            "Shinies!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Loot.4").Value);
            TranslateTargetType(LootUI,
            "Treasure!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Loot.5").Value);
            TranslateTargetType(LootUI,
            "For your troubles...",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Loot.6").Value);
            TranslateTargetType(LootUI,
            "This looks valuable...",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Loot.7").Value);
            TranslateTargetType(LootUI,
            "Not a mimic!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Loot.8").Value);
            TranslateTargetType(LootUI,
            "Shiny!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Loot.9").Value);

            MethodInfo LootUI2 = TargetType.GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(LootUI2,
            "You get:",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Loot.Get").Value);
            TranslateTargetType(LootUI2,
            "Pick two:",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Loot.Pick").Value);

            TranslateTargetType(LootUI2,
            " (",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Loot.L").Value);
            TranslateTargetType(LootUI2,
            ")",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Loot.R").Value);
        }
    }

    public class LootSelection : TypeEntry {
        public LootSelection() : base(typeof(StarlightRiver.Content.GUI.ExtraDefenseStats)) {}

        public override void Load() {
            MethodInfo LootSelection = TargetType.GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(LootSelection,
            " (",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Loot.L").Value);
            TranslateTargetType(LootSelection,
            ")",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Loot.R").Value);
        }
    }

    public class Stamina : TypeEntry {
        public Stamina() : base(typeof(StarlightRiver.Content.GUI.Stamina)) {}

        public override void Load() {
            MethodInfo Stamina = TargetType.GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Stamina,
            $"Starlight: {stamina}/{staminaMax}",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Stamina").Value);
        }
    }

    public class Tooltip : TypeEntry {
        public Tooltip() : base(typeof(StarlightRiver.Content.GUI.Tooltip)) {}

        public override void Load() {
            MethodInfo Tooltip = TargetType.GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Tooltip,
            "{Dummy}\n",
            Language.GetText("Mods.StarlightRiverZh.MiscText.GUI.Dummy").Value);
        }
    }
}