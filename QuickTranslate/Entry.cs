using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using StarlightRiverZh.Core.Translation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace StarlightRiverZh.QuickTranslate {
    public abstract class Entry {
        public virtual bool AutoLoad() {
            return SlrzhConfig.Instance.ILTranslate;
        }

        public virtual void Load() {

        }
        public static void QuickTrans(Type type, string method, string origin, string trans, BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public) {
            MethodInfo me = type.GetMethod(method, bindingFlags);
            QuickTrans(type, me, origin, trans);
        }

        public static void QuickTrans(Type type, MethodInfo? method, string origin, string trans) {
            if (method is null) {
                StarlightRiverZh.Instance.Logger.Warn("Fail to get method in type \"" + type.FullName + "\"");
                return;
            }
            ILTranslationManager.patcherManager.AddILHook(new ILHook(
            method,
            new ILContext.Manipulator(il => {
                var cursor = new ILCursor(il);
                if (!cursor.TryGotoNext(i => i.MatchLdstr(origin)))
                    StarlightRiverZh.Instance.Logger.Warn("Fail to locate string \"" + origin + "\" in method \"" + method.Name + "\" in type \"" + type.FullName + "\"");
                cursor.Index++;
                cursor.EmitDelegate<Func<string, string>>((orig) => trans);
            })));
        }
    }
}
