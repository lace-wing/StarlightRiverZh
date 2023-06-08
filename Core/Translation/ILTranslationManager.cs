using MonoMod.Utils;
using StarlightRiverZh.Core.Patcher;
using StarlightRiverZh.QuickTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StarlightRiverZh.Core.Translation {
    public static class ILTranslationManager {
        public static PatcherManager patcherManager;
        public static void Load() {
            patcherManager = new PatcherManager();
            foreach (Type type in StarlightRiverZh.Instance.Code.GetTypes()) {
                if (type.IsSubclassOf(typeof(TypeEntry)) && !type.IsAbstract) {
                    Entry entry = Activator.CreateInstance(type) as Entry;
                    if (entry != null) {
                        entry.Load();
                    }
                }
            }

            // All entry loaded
            patcherManager.Load();
        }
        public static void Unload() {
            patcherManager.UnLoad();
            ClearCache();
        }

        public static void ClearCache() {
            if (typeof(ReflectionHelper).GetField("AssembliesCache", BindingFlags.Static | BindingFlags.NonPublic)?.GetValue(null) is Dictionary<string, WeakReference[]> cache1) {
                foreach (var key in cache1.Keys.ToArray()) {
                    cache1.Remove(key);
                }
            }

            if (typeof(ReflectionHelper).GetField("ResolveReflectionCache", BindingFlags.Static | BindingFlags.NonPublic)?.GetValue(null) is Dictionary<string, WeakReference> cache2) {
                foreach (var key in cache2.Keys.ToArray()) {
                    cache2.Remove(key);
                }
            }
        }
    }
}
