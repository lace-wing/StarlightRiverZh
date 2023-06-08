using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StarlightRiverZh.QuickTranslate {
    public abstract class TypeEntry : Entry {
        public abstract Type TargetType { get; }

        protected void QTType(string method, string origin, string trans, BindingFlags bindingFlags) {
            QuickTrans(TargetType, method, origin, trans, bindingFlags);
        }
        protected void QTType(MethodInfo? method, string origin, string trans) {
            QuickTrans(TargetType, method, origin, trans);
        }
    }
}
