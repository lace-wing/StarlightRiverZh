using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace StarlightRiverZh.Core.Translation {
    public class ILTranslationSystem : ModSystem {
        public override void PostSetupContent() {
            ILTranslationManager.Load();
        }
        public override void Unload() {
            ILTranslationManager.Unload();
        }
    }
}
