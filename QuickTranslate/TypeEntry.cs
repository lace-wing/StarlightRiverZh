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
        
        protected void TranslateTargetType(string method, string origin, string trans, BindingFlags bindingFlags) {
            QuickTranslation(TargetType, method, origin, trans, bindingFlags);
        }
        protected void TranslateTargetType(MethodInfo? method, string origin, string trans) {
            QuickTranslation(TargetType, method, origin, trans);
        }

        public static Type GetSlrType(string type) => StarlightRiverZh.StarlightRiverTypes.FirstOrDefault(t => t.Name == type) ?? throw new Exception($"No type named {type} found in StarlightRiver assembly");
    }
}
