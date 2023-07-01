using System.Reflection;

namespace StarlightRiverZh.QuickTranslate.Entries.GamePlay;

public class PermafrostShrine : MethodEntry
{
    public PermafrostShrine() : base("DoorBombShooter", "PostDraw") { }

    public override void ILLoad()
    {
        TranslateTargetMethod("Place blocks on", "把方块放置在");
        TranslateTargetMethod("BLUE", "蓝色");
        TranslateTargetMethod("squares", "区域");
    }
}