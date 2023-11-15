/* using StarlightRiverZh.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace StarlightRiverZh.QuickTranslate.MiscThing {
    public class ArchaeologyMapLayer : TypeEntry {
        public ArchaeologyMapLayer() : base(typeof(StarlightRiver.Content.Archaeology.ArchaeologyMapLayer)) {}

        public override void Load() {
            MethodInfo ArchaeologyMapLayer = TargetType.GetMethod("Draw", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(ArchaeologyMapLayer,
            "Artifact",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Archaeology.Artifact").Value);
        }
    }

    public class AstralMeteor : TypeEntry {
        public AstralMeteor() : base(typeof(StarlightRiver.Content.CustomHooks.AstralMeteor)) {}

        public override void Load() {
            MethodInfo AluminumMeteor = TargetType.GetMethod("AluminumMeteor", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(AluminumMeteor,
            "A shard of the moon has landed!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.CustomHooks.AstralMeteor").Value);
        }
    }

    public class PrehardmodeWarning : TypeEntry {
        public PrehardmodeWarning() : base(typeof(StarlightRiver.Content.CustomHooks.PrehardmodeWarning)) {}

        public override void Load() {
            MethodInfo WorldGen_StartHardmode = TargetType.GetMethod("WorldGen_StartHardmode", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(WorldGen_StartHardmode,
            "Thank you for playing!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.CustomHooks.PrehardmodeWarningThank").Value);
            TranslateTargetType(WorldGen_StartHardmode,
            "You've reached the current end of Starlight River. Hardmode content is planned and under development, follow us on social media for spoilers and future updates.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.CustomHooks.PrehardmodeWarning").Value);
        }
    }

    public class StarlightEventSequenceSystem : TypeEntry {
        public StarlightEventSequenceSystem() : base(typeof(StarlightRiver.Content.Events.StarlightEventSequenceSystem)) {}

        public override void Load() {
            MethodInfo text = TargetType.GetMethod("PostUpdateTime", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(text,
            "A strange traveler has arrived...",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Events.TravelerArrived").Value);

            TranslateTargetType(text,
            "Wanderer, I await you at the place you entered this strange world...",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Events.Wanderer1").Value);

            TranslateTargetType(text,
            "Wanderer, do not keep me waiting...",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Events.Wanderer2").Value);

            TranslateTargetType(text,
            "Wanderer, I brought a gift... and ice cream...",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Events.Wanderer3").Value);

            MethodInfo text2 = TargetType.GetMethod("LoadWorldData", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(text2,
            "A strange traveler has arrived...",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Events.TravelerArrived").Value);
        }
    }

    public class OvergrowKey : TypeEntry {
        public OvergrowKey() : base(typeof(StarlightRiver.Content.Keys.OvergrowKey)) {}

        public override void Load() {
            MethodInfo OvergrowKey = TargetType.GetMethod("OnPickup", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(OvergrowKey,
            "Got: Overgrowth Key",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Keys.OvergrowKey").Value);
        }
    }

    public class ForbiddenWindsPickup : TypeEntry {
        public ForbiddenWindsPickup() : base(typeof(StarlightRiver.Content.Pickups.ForbiddenWindsPickup)) {}

        public override void Load() {
            MethodInfo ForbiddenWindsPickup = TargetType.GetMethod("PickupVisuals", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(ForbiddenWindsPickup,
            "Press W/A/S/D + ",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Pickups.ForbiddenWindsPickup.1").Value);
            TranslateTargetType(ForbiddenWindsPickup,
            " to dash.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Pickups.ForbiddenWindsPickup.2").Value);
            TranslateTargetType(ForbiddenWindsPickup,
            "Press W/A/S/D + [Please Bind a Key] to dash.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Pickups.ForbiddenWindsPickup.3.").Value);

            MethodInfo ForbiddenWindsGetHint = TargetType.GetMethod("GetHint", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(ForbiddenWindsGetHint,
            "A dense conflux of Starlight energy... could this be the tangle Alican mentioned?",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Pickups.ForbiddenWindsPickup.Hint").Value);
        }
    }

    public class InfusionSlotPickup : TypeEntry {
        public InfusionSlotPickup() : base(typeof(StarlightRiver.Content.Pickups.InfusionSlotPickup)) {}

        public override void Load() {
            MethodInfo InfusionSlotPickup = TargetType.GetMethod("PickupVisuals", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(InfusionSlotPickup,
            "Mysterious Technology",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Pickups.InfusionSlotPickup.1").Value);
            TranslateTargetType(InfusionSlotPickup,
            "What has it done to you?",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Pickups.InfusionSlotPickup.2").Value);
        }
    }

    public class StaminaShardPickup : TypeEntry {
        public StaminaShardPickup() : base(typeof(StarlightRiver.Content.Pickups.StaminaShardPickup)) {}

        public override void Load() {
            MethodInfo StaminaShardPickup = TargetType.GetMethod("PickupEffects", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(StaminaShardPickup,
            "Starlight Vessel",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Pickups.StaminaShardPickup.1").Value);
            TranslateTargetType(StaminaShardPickup,
            "Your maximum starlight has increased by 1",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Pickups.StaminaShardPickup.2").Value);
            TranslateTargetType(StaminaShardPickup,
            "Starlight Vessel Shard",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Pickups.StaminaShardPickup.3").Value);
            TranslateTargetType(StaminaShardPickup,
            "Collect ",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Pickups.StaminaShardPickup.4").Value);
            TranslateTargetType(StaminaShardPickup,
            " more to increase your maximum starlight",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Pickups.StaminaShardPickup.5").Value);
        }
    }

    public class StaminaShardTile : TypeEntry {
        public StaminaShardTile() : base(typeof(StarlightRiver.Content.Pickups.StaminaShardTile)) {}

        public override void Load() {
            MethodInfo StaminaShardTile = TargetType.GetMethod("KillTile", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(StaminaShardTile,
            "pickup set to stamina shard number ",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Pickups.StaminaShardTile").Value);
        }
    }
} */