using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StarlightRiverZh.QuickTranslate {
    public abstract class MethodEntry : TypeEntry {
        public abstract string MethodName { get; }
        public BindingFlags Flags {
            get {
                return BindingFlags.Public | BindingFlags.Instance;
            }
        }
        private MethodInfo method;
        public virtual void ILLoad() { }

        /// <summary>
        /// 不要用这个，除非要自定义读取MethodInfo（如函数重载）
        /// </summary>
        public override void Load() {
            method = TargetType.GetMethod(MethodName, Flags);
            ILLoad();
        }

        protected void QTTM(string origin, string trans) {
            QuickTrans(TargetType, method, origin, trans);
        }
    }
}
