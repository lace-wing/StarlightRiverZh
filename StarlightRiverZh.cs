using Terraria.ModLoader;

namespace StarlightRiverZh
{
	public class StarlightRiverZh : Mod
	{
		private static StarlightRiverZh _instance;
		public static StarlightRiverZh Instance => _instance;
        public override void Load() {
            _instance = this;
        }
    }
}