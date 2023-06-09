using System;
using System.Reflection;
using Terraria.ModLoader;

namespace StarlightRiverZh
{
	public class StarlightRiverZh : Mod
	{
		private static StarlightRiverZh _instance;
		public static StarlightRiverZh Instance => _instance;

        internal static Type[] starlightRiverTypes;
        public static Type[] StarlightRiverTypes => starlightRiverTypes;

        public override void Load() {
            _instance = this;
        }
    }
}