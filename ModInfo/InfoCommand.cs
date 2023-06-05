using Microsoft.CodeAnalysis.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using StarlightRiverZh.Utils;

namespace StarlightRiverZh.ModInfo
{
    public class InfoCommand : ModCommand
    {
        public override string Command => "slrzh";

        public override CommandType Type => CommandType.Chat;

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            if (!TryGetOptions(args, out Option[] options))
            {
                PopOptionLists();
                return;
            }
            var notif = caller.Player.GetModPlayer<Notifications>();
            if (args.Length < 1)
            {
                notif.PopWelcome();
                notif.PopChangelog();
                return;
            }
            foreach (Option op in options)
            {
                switch (op)
                {
                    case Option.Version:
                        notif.PopVersion();
                        break;
                    case Option.Changelog:
                        notif.PopChangelog();
                        break;
                    case Option.Help:
                        PopOptionLists();
                        break;
                    case Option.Welcome:
                        notif.PopWelcome();
                        break;
                    case Option.Info:
                    default: break;
                }
            }
        }

        private enum Option
        {
            Version,
            Changelog,
            Info,
            Help,
            Welcome,
        }
        private string[] GetOptionTriggers(Option option)
        {
            switch (option)
            {
                case Option.Version: return new string[] { "version", "ver", "v" };
                case Option.Changelog: return new string[] { "changelog", "log", "change", "c" };
                case Option.Info: return new string[] { "info", "desc", "i" };
                case Option.Help: return new string[] { "help", "h" };
                case Option.Welcome: return new string[] { "welcome", "w" };
                default: return null;
            }
        }
        private bool TryGetOption(string arg, out Option option)
        {
            option = default;
            arg = arg.ToLower();
            foreach (Option op in Enum.GetValues(typeof(Option)))
            {
                if (GetOptionTriggers(op).Contains(arg))
                {
                    option = op;
                    return true;
                }
            }
            return false;
        }
        private bool TryGetOptions(string[] args, out Option[] options)
        {
            options = default;
            List<Option> ops = new List<Option>();
            List<string> cache = new List<string>();
            for (int i = 0; i < args.Length; i++)
            {
                if (!TryGetOption(args[i], out Option option))
                {
                    return false;
                }
                if (cache.Contains(args[i]))
                {
                    continue;
                }
                cache.Add(args[i]);
                ops.Add(option);
            }
            options = ops.ToArray();
            return true;
        }
        private string GetTriggerList(Option option)
        {
            return $"{option}: {string.Join(", ", GetOptionTriggers(option))}";
        }
        private void PopOptionLists()
        {
            List<string> lists = new List<string>();
            foreach (Option op in Enum.GetValues(typeof(Option)))
            {
                lists.Add(GetTriggerList(op));
            }
            Main.NewTextMultiline("---\n" + Text.TagColor(string.Join('\n', lists), Color.Yellow) + "\n---", true);
        }
    }
}
