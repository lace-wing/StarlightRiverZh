using StarlightRiverZh.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace StarlightRiverZh.QuickTranslate.Entries {
    public class GlassweaverBoss : TypeEntry {
        public GlassweaverBoss() : base(typeof(StarlightRiver.Content.Bosses.GlassMiniboss.Glassweaver)) {}

        public override void Load() {
            MethodInfo ai = TargetType.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(ai, "Glassweaver", Language.GetTextValue("Mods.StarlightRiver.NPCs.Glassweaver.DisplayName"));
            TranslateTargetType(ai, "Worker of the Anvil", "锻砧匠人");

            MethodInfo gauntletWave0 = TargetType.GetMethod("GauntletWave0", BindingFlags.NonPublic | BindingFlags.Instance);
            TranslateTargetType(gauntletWave0, "Begin!", "开始！");
        }
    }
}
