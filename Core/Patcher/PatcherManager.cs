using MonoMod.RuntimeDetour;
using StarlightRiverZh.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarlightRiverZh.Core.Patcher {
    public class PatcherManager {
        private List<ILHook> ilHooks;
        public PatcherManager() {
            ilHooks = new List<ILHook>();
        }
        public void Load() {
            foreach (ILHook hook in ilHooks) {
                if (hook != null) {
                    hook.Apply();
                }
            }
        }
        public void UnLoad() {
            foreach (ILHook hook in ilHooks) {
                if (hook != null) {
                    hook.Dispose();
                }
            }
            ilHooks.Clear();
        }

        public void AddILHook(ILHook hook) {
            ilHooks.Add(hook);
        }
    }
}
