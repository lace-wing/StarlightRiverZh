using MonoMod.RuntimeDetour;
using StarlightRiverZh.Core.OnPatch;
using System.Reflection;
using StarlightRiver.Content.GUI;
using Terraria;
using Terraria.Localization;

namespace StarlightRiverZh.OnPatches;

public class MasterDeathText : IOnPatch
{
    public Hook Load()
    {
        MethodBase m = typeof(MasterDeathTicker)?.GetMethod("ShowDeathCounter", BindingFlags.Static | BindingFlags.Public);
        return m is null ? null : new Hook(m, ShowDeathCounterOverride);
    }

    private delegate void ShowDeathCounterDelegate(string name, int deaths);
    private void ShowDeathCounterOverride(ShowDeathCounterDelegate orig, string name, int deaths)
    {
        orig.Invoke(name, deaths);
        name = name switch
        {
            "Auroracle" => "极光之触",
            "Ceiros" => "塞洛斯",
            _ => name
        };
        FieldInfo f = typeof(MasterDeathTicker).GetField("name", BindingFlags.Static | BindingFlags.NonPublic);
        if (f is null)
        {
            StarlightRiverZh.Instance.Logger.Warn("MasterDeathText patch failed to load on field \"name\"!");
            return;
        }
        f.SetValue(null, name);

        FieldInfo t = typeof(MasterDeathTicker).GetField("tease", BindingFlags.Static | BindingFlags.NonPublic);
        if (t is null)
        {
            StarlightRiverZh.Instance.Logger.Warn("MasterDeathText patch failed to load on field \"tease\"!");
            return;
        }
        string text = t.GetValue(null) as string;
        for (int i = 0; i <= 15; i++)
        {
            if (i == 14)
            {
                if (text == Language.GetTextValue($"Mods.StarlightRiver.Common.EN.MasterDeathText.{i}", Main.cJump))
                {
                    t.SetValue(null, Language.GetTextValue($"Mods.StarlightRiver.Common.MasterDeathText.{i}", Main.cJump));
                    return;
                }
            }
            else if (text == Language.GetTextValue($"Mods.StarlightRiver.Common.EN.MasterDeathText.{i}"))
            {
                t.SetValue(null, Language.GetTextValue($"Mods.StarlightRiver.Common.MasterDeathText.{i}"));
                return;
            }
        }
    }
}