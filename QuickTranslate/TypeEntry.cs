using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StarlightRiverZh.QuickTranslate {
    public abstract class TypeEntry : Entry
    {
        protected TypeEntry(Type targetType) => TargetType = targetType;
        protected TypeEntry(string targetTypeName) => TargetType = GetSlrType(targetTypeName);

        protected readonly Type TargetType;
        
        protected void QTType(string method, string origin, string trans, BindingFlags bindingFlags) {
            QuickTrans(TargetType, method, origin, trans, bindingFlags);
        }
        protected void QTType(MethodInfo? method, string origin, string trans) {
            QuickTrans(TargetType, method, origin, trans);
        }

        protected static Type GetSlrType(string type) => StarlightRiverZh.StarlightRiverTypes.FirstOrDefault(t => t.Name == type) ?? throw new Exception($"No type named {type} found in StarlightRiver assembly");
    }
}
