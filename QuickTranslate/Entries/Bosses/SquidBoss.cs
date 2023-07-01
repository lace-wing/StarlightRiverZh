using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace StarlightRiverZh.QuickTranslate.Entries.Bosses {
    public class SquidBoss : TypeEntry {
        public SquidBoss() : base(typeof(StarlightRiver.Content.Bosses.SquidBoss.SquidBoss)) {}
        public override void Load() {
            MethodInfo ai = TargetType.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(ai, ", The Venerated", "，冰海崇灵");

            MethodInfo spawnAnimation = TargetType.GetMethod("SpawnAnimation", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(spawnAnimation, "Jammed Mod", "卡住模组");
            TranslateTargetType(spawnAnimation, "The Venerated", "冰海崇灵");
            TranslateTargetType(spawnAnimation, "Auroracle", Language.GetTextValue("Mods.StarlightRiver.NPCs.SquidBoss.DisplayName"));
        }
    }
}
