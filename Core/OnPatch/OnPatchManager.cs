using System;
using System.Collections.Generic;
using System.Linq;
using MonoMod.RuntimeDetour;
using Terraria.ModLoader;

namespace StarlightRiverZh.Core.OnPatch;

public class OnPatchManager : ModSystem
{
    private List<Hook> _hooks;

    public override void PostSetupContent()
    {
        _hooks = new List<Hook>();
        foreach (Type type in Mod.Code.GetTypes())
        {
            if (type.GetInterfaces().Contains(typeof(IOnPatch)))
            {
                Hook hook = (Activator.CreateInstance(type) as IOnPatch)!.Load();
                if (hook is null)
                {
                    Mod.Logger.Warn($"{type.FullName} failed to load!");
                    continue;
                }
                _hooks.Add(hook);
                hook.Apply();
            }
        }
    }
    
    public override void Unload()
    {
        foreach (Hook hook in _hooks)
        {
            hook?.Dispose();
        }
        _hooks = null;
    }
}