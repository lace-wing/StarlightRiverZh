using System.Reflection;
using MonoMod.RuntimeDetour;
using StarlightRiverZh.Core.OnPatch;
using StarlightRiverZh.QuickTranslate;
using Terraria.Localization;

namespace StarlightRiverZh.OnPatches;

public class StarsightHint : IOnPatch
{
    public Hook Load()
    {
        //StarlightRiver.Content.Abilities.Hint.HintAbility.OnActivate()
        MethodBase m = TypeEntry.GetSlrType("HintAbility")?.GetMethod("OnActivate");
        return m is null ? null : new Hook(m, OnActivateOverride);
    }

    private delegate void OnActivateDelegate(object hintAbility);
    private static void OnActivateOverride(OnActivateDelegate orig, object hintAbility)
    {
        orig.Invoke(hintAbility);

        FieldInfo f = hintAbility.GetType().GetField("hintToDisplay", BindingFlags.Static | BindingFlags.Public);
        if (f is null)
        {
            StarlightRiverZh.Instance.Logger.Warn("StarsightHint patch failed to load!");
            return;
        }

        string text = f.GetValue(hintAbility) as string;
        foreach (string key in starsightKeys)
        {
            if (text == Language.GetTextValue($"Mods.StarlightRiver.Common.EN.Starsight.{key}"))
            {
                f.SetValue(hintAbility, Language.GetTextValue($"Mods.StarlightRiver.Common.Starsight.{key}"));
                return;
            }
        }
    }

    private static readonly string[] starsightKeys = 
    {
        "ForbiddenWindsPickup",
        "Coolmite",
        "MagmitePassive",
        "Crow",
        "Snoobel",
        "Crusher",
        "Dreambeast",
        "Fogbinder",
        "Warbanner",
        "CrescentCaster",
        "Dweller",
        "Stalker",
        "BossRushOrb",
        "VitricBoss",
        "SquidBoss",
        "TentacleHurtbox",
        "Glassweaver",
        "GlassweaverWaiting",
        
        "MainForgeDummy",
        "DynamicGearDummy",
        "JellyShroomDummy",

        "VitricBossAltar",
        "VitricBossAltar2",
        "VitricOre",
        "VitricOreFloat",
        "VitricSpike",
        "NPCSpawner",
        "Lens",
        "LightGoal",
        "Reflector",
        "CombatShrine",
        "EvasionShrine",
        "HotspringFountain",
        "MagmiteShrine",
        "WitShrine",
        "DashBarrier",
        "AuroraIce",
        "Touchstone",
        "MoonstoneOre",
        "DisplayCase",
        "DisplayCaseFriendly",
        "Bouncer",
        "StaminaGem",
        "MonkSpear",
        "DesertMonolith",
        "DesertMonolithFlipped",
        "CrashPod",

        "Nothing",
    };
}