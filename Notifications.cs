using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using StarlightRiverZh.Utils;

namespace StarlightRiverZh
{
    internal class Notifications : ModPlayer
    {
        public override void OnEnterWorld()
        {
            Main.NewText(Text.GetTaggedText(Text.NotifPath + "Welcome", Color.YellowGreen));
            string log, notifLog;
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
            notifLog = log == string.Empty
                ? Text.GetTaggedText(Text.NotifPath + "NoChangelog", Color.YellowGreen, new object[] { Mod.Version })
                : Text.GetTaggedText(Text.NotifPath + "Changelog", Color.YellowGreen, new object[] {Mod.Version, log});
            Main.NewTextMultiline(notifLog, true);
        }
    }
}

