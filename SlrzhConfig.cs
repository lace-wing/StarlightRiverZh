using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;

namespace StarlightRiverZh {
    public class SlrzhConfig : ModConfig {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        public static SlrzhConfig Instance;
        public override void OnLoaded() {
            Instance = this;
        }

        [ReloadRequired]
        [Header("【测试性】内嵌翻译")]
        [Label("翻译更多文本")]
        [Tooltip("测试功能，开发中，可能造成不可预知的bug，完全不支持多人模式，关闭mod后无法将文本恢复为英文")]
        [DefaultValue(true)]
        public bool ILTranslate;
    }
}
