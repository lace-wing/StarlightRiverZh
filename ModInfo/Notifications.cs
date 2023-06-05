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
using Terraria.ModLoader.IO;

namespace StarlightRiverZh.ModInfo
{
    public class Notifications : ModPlayer
    {
        public static string LastVersion;
        public override void OnEnterWorld()
        {
            PopWelcome();
            PopMoreInfo();
            if (LastVersion != Mod.Version.ToString())
            {
                PopChangelog();
            }
        }
        public override void SaveData(TagCompound tag)
        {
            tag.Add("LastVersion", Mod.Version.ToString());
        }
        public override void LoadData(TagCompound tag)
        {
            if (tag.ContainsKey("LastVersion"))
            {
                LastVersion = tag.GetString("LastVersion");
            }
        }

        public void PopVersion()
        {
            Main.NewText(Text.TagColor(Mod.Version.ToString(), Text.VersionColor));
        }
        public void PopWelcome()
        {
            Main.NewText(Text.GetTaggedText(Text.NotifPath + "Welcome", Text.TextColor));
        }
        public void PopMoreInfo()
        {
            Main.NewText(Text.GetTaggedText(Text.NotifPath + "MoreInfo", Text.InfoColor));
        }
        public void PopChangelog()
        {
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
            log = log == string.Empty
                ? Text.GetTaggedText(Text.NotifPath + "NoChangelog", Text.InfoColor, new object[] { Mod.Version })
                : Text.GetTaggedText(Text.NotifPath + "Changelog", Text.VersionColor, new object[] { Mod.Version, log });
            Main.NewTextMultiline("---\n" + log + "\n---", true);
        }
    }
}

