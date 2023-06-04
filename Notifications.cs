using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader

namespace StarlightRiverZh;

internal class Notifications : ModPlayer
{
    public override void OnEnterWorld()
    {
        Main.NewText("欢迎使用由星光之舟汉化组制作的星光之河汉化补丁。制作仓促，目前翻译尚不完善。我们会逐渐改进，感谢您的耐心和理解。");
    }
}
