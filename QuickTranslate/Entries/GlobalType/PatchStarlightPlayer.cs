using StarlightRiver.Core;
using Terraria.Localization;

namespace StarlightRiverZh.QuickTranslate.Entries.GlobalType;

public class PatchStarlightPlayer : MethodEntry
{
    public PatchStarlightPlayer() : base(typeof(StarlightPlayer), "OnEnterWorld") {}

    public override void ILLoad()
    {
        TranslateTargetMethod("Warning - Master Mode", "警告 - 大师模式");
        TranslateTargetMethod(@"Starlight River has unique behavior for its bosses in Master Mode. This behavior is intended to be immensely difficult over anything else, and assumes a high amount of knowldge about " +
            "both the mod and base game. Starlight River Master Mode is not intended for a first playthrough. Starlight River Master Mode is not intended to be fair. Starlight River Master Mode is not intended to be fun for everyone. " +
            "Please remember that the health, both physical and mental, of yourself and those around you is far more important than this game or anything inside of it.", Language.GetTextValue("Mods.StarlightRiver.Common.MasterWarning"));
    }
}