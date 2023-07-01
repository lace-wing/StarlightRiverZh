using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StarlightRiverZh.QuickTranslate {
    public abstract class MethodEntry : TypeEntry {
        protected MethodEntry(Type targetType, string methodName) : base(targetType) => MethodName = methodName;
        protected MethodEntry(string targetTypeName, string methodName) : base(targetTypeName) => MethodName = methodName;

        protected readonly string MethodName;
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

        protected void TranslateTargetMethod(string origin, string trans) {
            QuickTranslation(TargetType, method, origin, trans);
        }
    }
}
