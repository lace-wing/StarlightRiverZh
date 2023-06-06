using StarlightRiverZh.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace StarlightRiverZh.QuickTranslate {
    public class GlassweaverBoss : Entry {

        public override void Load() {
            Type type = typeof(StarlightRiver.Content.Bosses.GlassMiniboss.Glassweaver);
            MethodInfo ai = type.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            QuickTrans(type, ai, "Glassweaver", Language.GetTextValue("Mods.StarlightRiver.NPCs.Glassweaver.DisplayName"));
            QuickTrans(type, ai, "Worker of the Anvil", "锻砧匠人");

            MethodInfo gauntletWave0 = type.GetMethod("GauntletWave0", BindingFlags.NonPublic | BindingFlags.Instance);
            QuickTrans(type, gauntletWave0, "Begin!", "开始！");
        }
    }
}
