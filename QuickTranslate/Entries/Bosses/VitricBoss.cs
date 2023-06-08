using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace StarlightRiverZh.QuickTranslate.Entries.Bosses {
    public class VitricBoss : TypeEntry {
        public override Type TargetType => typeof(StarlightRiver.Content.Bosses.VitricBoss.VitricBoss);
        public override void Load() {
            MethodInfo ai = TargetType.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            QTType(ai, ", Shattered Sentinel", "，碎晶哨卫");

            MethodInfo spawnAnimation = TargetType.GetMethod("SpawnAnimation", BindingFlags.NonPublic | BindingFlags.Instance);
            QTType(spawnAnimation, "Shattered Sentinel", "碎晶哨卫");
        }
    }
}