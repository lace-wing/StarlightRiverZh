using MonoMod.RuntimeDetour;

namespace StarlightRiverZh.Core.OnPatch;

public interface IOnPatch
{
    Hook Load();
}