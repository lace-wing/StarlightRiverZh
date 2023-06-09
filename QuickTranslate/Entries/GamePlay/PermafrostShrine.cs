using System.Reflection;

namespace StarlightRiverZh.QuickTranslate.Entries.GamePlay;

public class PermafrostShrine : MethodEntry
{
    public PermafrostShrine() : base("DoorBombShooter", "PostDraw") { }
    
    public override void Load()
    {
        QTTM("Place blocks on", "把方块放置在");
        QTTM("BLUE", "蓝色");
        QTTM("squares", "区域");
    }
}