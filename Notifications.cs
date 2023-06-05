using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace StarlightRiverZh
{
    internal class Notifications : ModPlayer
    {
        public override void OnEnterWorld()
        {
            Main.NewText("欢迎使用由星光之舟汉化组制作的星光之河汉化补丁。 制作仓促，目前翻译尚不完善。 我们会逐渐改进，感谢您的耐心和理解。", Color.YellowGreen);
            string log;
            var stream = Mod.GetFileStream("changelog.txt");
            try
            {
                using var reader = new StreamReader(stream);
                log = reader.ReadToEnd();
            }
            catch
            {
                throw;
            }
            log = log == string.Empty ? $"{Mod.Version} 未检测到更新日志" : log.Insert(0, $"v{Mod.Version} 更新日志\n");
            Main.NewTextMultiline(log, true, Color.YellowGreen);
        }
    }
}

