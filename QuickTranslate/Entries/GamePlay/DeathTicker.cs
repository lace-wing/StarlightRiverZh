using System.Reflection;

namespace StarlightRiverZh.QuickTranslate.Entries.GamePlay;

public class DeathTicker : TypeEntry
{
    public DeathTicker() : base(typeof(StarlightRiver.Content.GUI.MasterDeathTicker)){}

    public override void Load()
    {
        MethodInfo draw = TargetType.GetMethod("Draw");
        QTType(draw, "Deaths to ", "死于");
        QTType(draw, ": ", "的次数：");
        MethodInfo show = TargetType.GetMethod("ShowDeathCounter", BindingFlags.Static | BindingFlags.Public);
    }
}