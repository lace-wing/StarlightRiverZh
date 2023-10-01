using StarlightRiverZh.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace StarlightRiverZh.QuickTranslate.MiscThing {
    public class HotspringHeal : TypeEntry {
        public HotspringHeal() : base(typeof(StarlightRiver.Content.Buffs.HotspringHeal)) {}

        public override void Load() {
            MethodInfo HotspringHeal = TargetType.GetMethod("ModifyBuffText", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(HotspringHeal,
            "An evil presence prevents you from relaxing in the hot springs!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Buff.HotspringHeal").Value);
        }
    }

    public class Claustrophobia : TypeEntry {
        public Claustrophobia() : base(typeof(StarlightRiver.Content.Buffs.Claustrophobia)) {}

        public override void Load() {
            MethodInfo Claustrophobia = TargetType.GetMethod("Update", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Claustrophobia,
            " couldn't maintain their form.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Buff.Claustrophobia").Value);
        }
    }

    public class ImpactSMGBuff : TypeEntry {
        public ImpactSMGBuff() : base(typeof(StarlightRiver.Content.Items.Misc.ImpactSMGBuff)) {}

        public override void Load() {
            MethodInfo ImpactSMGBuff = TargetType.GetMethod("ModifyBuffText", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(ImpactSMGBuff,
            "The Impact SMG deals ",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.ImpactSMGBuff1").Value);
            TranslateTargetType(ImpactSMGBuff,
            "% ",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.ImpactSMGBuff2").Value);
            TranslateTargetType(ImpactSMGBuff,
            "increased damage",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Item.ImpactSMGBuff3").Value);
        }
    }
}