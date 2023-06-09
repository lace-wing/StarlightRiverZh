using System;
using System.Reflection;
using Terraria.ModLoader;

namespace StarlightRiverZh
{
	public class StarlightRiverZh : Mod
	{
		private static StarlightRiverZh _instance;
		public static StarlightRiverZh Instance => _instance;

        private static Type[] _starlightRiverTypes;

        public static Type[] StarlightRiverTypes => _starlightRiverTypes;

        public override void Load() {
            _instance = this;
            _starlightRiverTypes = typeof(StarlightRiver.StarlightRiver).Assembly.GetTypes();
        }
    }
}