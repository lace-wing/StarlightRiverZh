using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StarlightRiverZh.QuickTranslate.Entries.NPCs
{
    internal class Crow : TypeEntry
    {
        public Crow() : base("Crow")
        {
        }
        public override void Load()
        {
            MethodInfo methodInfo = TargetType.GetMethod("GetIntroDialogue", BindingFlags.NonPublic);
            TranslateTargetType(methodInfo,
                "The crow-like... creature... gets up off the ground with a triumphant look in its beady eyes, dusting itself off, and then straightening its ruffled feathers.",
                "WIP");
        }
    }
}
