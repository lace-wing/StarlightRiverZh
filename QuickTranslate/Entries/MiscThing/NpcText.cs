using StarlightRiverZh.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace StarlightRiverZh.QuickTranslate.MiscThing {
    public class StarlightWaterActor : TypeEntry {
        public StarlightWaterActor() : base(typeof(StarlightRiver.Content.NPCs.Actors.StarlightWaterActor)) {}

        public override void Load() {
            MethodInfo StarlightWaterActor = TargetType.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(StarlightWaterActor,
            "Something went wrong with item conversion: item turning into air!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.StarlightWaterActor").Value);
        }
    }

    public class BossRushGoal : TypeEntry {
        public BossRushGoal() : base(typeof(StarlightRiver.Content.NPCs.BossRush.BossRushGoal)) {}

        public override void Load() {
            MethodInfo BossRushGoal = TargetType.GetMethod("AI", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(BossRushGoal,
            "Boss rush",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.BossRushGoal1").Value);
            TranslateTargetType(BossRushGoal,
            "Boss blitz",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.BossRushGoal2").Value);
            TranslateTargetType(BossRushGoal,
            "Starlight showdown",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.BossRushGoal3").Value);
            TranslateTargetType(BossRushGoal,
            "Invalid",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.BossRushGoal4").Value);
        }
    }

    public class Stalker : TypeEntry {
        public Stalker() : base(typeof(StarlightRiver.Content.NPCs.Corruption.Stalker)) {}

        public override void Load() {
            MethodInfo Stalker = TargetType.GetMethod("GetHint", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Stalker,
            "Theres... nothing there. An illusion.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcHint.Stalker").Value);
        }
    }

    public class Dweller : TypeEntry {
        public Dweller() : base(typeof(StarlightRiver.Content.NPCs.Corruption.Dweller)) {}

        public override void Load() {
            MethodInfo Dweller = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Dweller,
            "They have evolved to camoflauge themselves as trees, and use this ability to ambush unsuspecting victims in comical fashion. The laugh just sells the point.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.Dweller").Value);

            MethodInfo Dweller2 = TargetType.GetMethod("GetHint", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Dweller2,
            "There's something here.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcHint.Dweller").Value);
        }
    }

    public class SoulNibbler : TypeEntry {
        public SoulNibbler() : base(typeof(StarlightRiver.Content.NPCs.Corruption.SoulNibbler)) {}

        public override void Load() {
            MethodInfo SoulNibbler = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(SoulNibbler,
            "These tiny pests take after their larger bretheren, floating eerily and swarming any foolish enough to come near their tiny, but awfully sharp, fangs.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.SoulNibbler").Value);
        }
    }

    public class CrescentCaster : TypeEntry {
        public CrescentCaster() : base(typeof(StarlightRiver.Content.NPCs.Dungeon.CrescentCaster)) {}

        public override void Load() {
            MethodInfo CrescentCaster = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(CrescentCaster,
            "As the first in a long line of dead wizards, this one has had ample time to practice magic. Using its crescent staff, this fiend generates Barrier for all nearby foes - but is immobile while doing so.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.CrescentCaster").Value);

            MethodInfo CrescentCaster2 = TargetType.GetMethod("GetHint", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(CrescentCaster2,
            "There's something here.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcHint.CrescentCaster").Value);
        }
    }

    public class Warbanner : TypeEntry {
        public Warbanner() : base(typeof(StarlightRiver.Content.NPCs.Forest.Warbanner)) {}

        public override void Load() {
            MethodInfo Warbanner = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Warbanner,
            "An artifact from battles past, this cursed sign still inspires others with the enraging spirit of battle to this day.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.Warbanner").Value);

            MethodInfo Warbanner2 = TargetType.GetMethod("GetHint", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Warbanner2,
            "It somehow bolsters nearby foes...",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcHint.Warbanner").Value);
        }
    }

    public class Blover : TypeEntry {
        public Blover() : base(typeof(StarlightRiver.Content.NPCs.Forest.Blover)) {}

        public override void Load() {
            MethodInfo Blover = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Blover,
            "Blovers are clover-based plants that harness the ambient mana during particularly windy days to spin their fan-shaped leaves at approaching creatures. They are immobile, and would serve as a good form of defense if one were to discover a way to move or perhaps plant one.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.Blover").Value);
        }
    }

    public class Fogbinder : TypeEntry {
        public Fogbinder() : base(typeof(StarlightRiver.Content.NPCs.Misc.Fogbinder)) {}

        public override void Load() {
            MethodInfo Fogbinder = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Fogbinder,
            "They call it... The fogbinder. Appearing during thunderstorms, this being is very Spooky, Demented, Demonic, Hellish, and Evil.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.Fogbinder").Value);

            MethodInfo Fogbinder2 = TargetType.GetMethod("GetHint", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Fogbinder2,
            "Disrupted with prolonged contact...",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcHint.Fogbinder").Value);
        }
    }

    public class LootWraith : TypeEntry {
        public LootWraith() : base(typeof(StarlightRiver.Content.NPCs.Misc.LootWraith)) {}

        public override void Load() {
            MethodInfo LootWraith = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(LootWraith,
            "The tortured souls of adventurers obsessed with treasure, forever cursed in death to protect the only thing they cared about in life",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.LootWraith").Value);
        }
    }

    public class Dreambeast : TypeEntry {
        public Dreambeast() : base(typeof(StarlightRiver.Content.NPCs.Moonstone.Dreambeast)) {}

        public override void Load() {
            MethodInfo Dreambeast = TargetType.GetMethod("GetHint", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Dreambeast,
            "It's not real. It's not real. It's not real. IT'S NOT REAL. IT'S NOT REAL. IT'S NOT REAL.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcHint.Dreambeast").Value);
        }
    }

    public class Dreamprism : TypeEntry {
        public Dreamprism() : base(typeof(StarlightRiver.Content.NPCs.Moonstone.Dreamprism)) {}

        public override void Load() {
            MethodInfo Dreamprism = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Dreamprism,
            "These anomalous beings are a collection of previously lifeless rocks possessed by the hopes and dreams of the collective subconscious.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.Dreamprism").Value);
        }
    }

    public class AngryCrescent : TypeEntry {
        public AngryCrescent() : base(typeof(StarlightRiver.Content.NPCs.Moonstone.AngryCrescent)) {}

        public override void Load() {
            MethodInfo AngryCrescent = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(AngryCrescent,
            "A chunk of the moon possessed with hatred for you. These creatures will stop at nothing to protect their home.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.AngryCrescent").Value);
        }
    }

    public class Crusher : TypeEntry {
        public Crusher() : base(typeof(StarlightRiver.Content.NPCs.Overgrow.Crusher)) {}

        public override void Load() {
            MethodInfo Crusher = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Crusher,
            "Watch your step.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.Crusher").Value);
        }
    }

    public class Snoobel : TypeEntry {
        public Snoobel() : base(typeof(StarlightRiver.Content.NPCs.Snow.Snoobel)) {}

        public override void Load() {
            MethodInfo Snoobel = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Snoobel,
            "A curious but cruel creature, the snoobel wanders the frozen caverns, using its trunk as an instrument of absolute death.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.Snoobel").Value);

            MethodInfo Snoobel2 = TargetType.GetMethod("GetHint", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Snoobel2,
            "Extremely ugly. so Fucking ugly.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcHint.Snoobel").Value);
        }
    }

    public class GloomSlime : TypeEntry {
        public GloomSlime() : base(typeof(StarlightRiver.Content.NPCs.Underground.GloomSlime)) {}

        public override void Load() {
            MethodInfo GloomSlime = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(GloomSlime,
            "These drab dribbling droplets descend devilishly after dusk, deep in the depths of doom.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.GloomSlime").Value);
        }
    }

    public class CrystalSlime : TypeEntry {
        public CrystalSlime() : base(typeof(StarlightRiver.Content.NPCs.Vitric.CrystalSlime)) {}

        public override void Load() {
            MethodInfo CrystalSlime = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(CrystalSlime,
            "An extremely elusive specimen. It's taken in a large amount of crystals and Starlight energy, forming a priceless coating over its membrane. Anyone that finds an intact one should be extremely careful not to break it, for it's likely they will never encounter it again.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.CrystalSlime").Value);

            MethodInfo CrystalSlime2 = TargetType.GetMethod("ModifyIncomingHit", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(CrystalSlime2,
            "Dash into me first!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.CrystalSlime2").Value);

            TranslateTargetType(CrystalSlime2,
            "Blocked!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.CrystalSlime3").Value);
        }
    }

    public class DesertWisp : TypeEntry {
        public DesertWisp() : base(typeof(StarlightRiver.Content.NPCs.Vitric.DesertWisp)) {}

        public override void Load() {
            MethodInfo DesertWisp = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(DesertWisp,
            "An extremely elusive specimen. It's taken in a large amount of crystals and Starlight energy, forming a priceless coating over its membrane. Anyone that finds an intact one should be extremely careful not to break it, for it's likely they will never encounter it again.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.DesertWisp").Value);
        }
    }

    public class KettleCreature : TypeEntry {
        public KettleCreature() : base(typeof(StarlightRiver.Content.NPCs.Vitric.KettleCreature)) {}

        public override void Load() {
            MethodInfo KettleCreature = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(KettleCreature,
            "A construct built by an unknown people, seemingly harvesting crystal and processing it internally. It can be assumed that it has run out of storage after an extremely long amount of time unmaintained, so it uses its excess molten crystal as an automatic defense mechanism.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.KettleCreature").Value);
        }
    }

    public class MagmitePassive : TypeEntry {
        public MagmitePassive() : base(typeof(StarlightRiver.Content.NPCs.Vitric.MagmitePassive)) {}

        public override void Load() {
            MethodInfo MagmitePassive = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(MagmitePassive,
            "A barely-sentient bundle of magma, closely related to slimes. Harbors absolutely zero animosity towards anything ever, and would get along well with just about any creature if it weren't for its body being thousands of degrees hotter than they would prefer.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.MagmitePassive").Value);
        }
    }

    public class MagmiteSmol : TypeEntry {
        public MagmiteSmol() : base(typeof(StarlightRiver.Content.NPCs.Vitric.MagmiteSmol)) {}

        public override void Load() {
            MethodInfo MagmiteSmol = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(MagmiteSmol,
            "A tiny sentient drop of magma freshly born from the pools of molten glass. Harbors endless curiosity towards everything and everyone it comes across, but it doesn't yet realize that its body is hundreds of degrees hotter than most living things can bear.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.MagmiteSmol").Value);
        }
    }

    public class MagmiteLarge : TypeEntry {
        public MagmiteLarge() : base(typeof(StarlightRiver.Content.NPCs.Vitric.MagmiteLarge)) {}

        public override void Load() {
            MethodInfo MagmiteLarge = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(MagmiteLarge,
            "A matured magmite, covered with intricate patterns and swirls from the slow cooling of its body. Most creatures dare not approach to admire its magnificence, as it still still brilliantly burns thousands of degrees.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.MagmiteLarge").Value);
        }
    }

    public class Snake : TypeEntry {
        public Snake() : base(typeof(StarlightRiver.Content.NPCs.Vitric.Snake)) {}

        public override void Load() {
            MethodInfo Snake = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(Snake,
            "A territorial species found nesting in the sands of the Vitric Desert. Approach with caution - they are passive only until one encroaches upon their territory.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.Snake").Value);
        }
    }

    public class BoomBug : TypeEntry {
        public BoomBug() : base(typeof(StarlightRiver.Content.NPCs.Vitric.BoomBug)) {}

        public override void Load() {
            MethodInfo BoomBug = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(BoomBug,
            "A swarming insect found in the Vitric Desert. Rapidly calls forth its lesser bretheren as a means of attack, flying close to their target before detonating their molten nectar to burn and cook their prey.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.BoomBug").Value);
        }
    }

    public class LesserFirebug : TypeEntry {
        public LesserFirebug() : base(typeof(StarlightRiver.Content.NPCs.Vitric.LesserFirebug)) {}

        public override void Load() {
            MethodInfo LesserFirebug = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(LesserFirebug,
            "A lesser form of the Firebug, these are at the bottom of the nest's heirarchy. They are regularly sent to their deaths in order to detonate their own bodys to help the hive hunt.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.LesserFirebug").Value);
        }
    }

    public class CoolmitePassive : TypeEntry {
        public CoolmitePassive() : base(typeof(StarlightRiver.Content.NPCs.Vitric.CoolmitePassive)) {}

        public override void Load() {
            MethodInfo CoolmitePassive = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(CoolmitePassive,
            "Through the power of Shimmer, this form of Magmite has magically cooled down to safe temperatures without rendering itself immobile. Unfortunately, this is a rather chilly temperature for a creature used to being submerged in lava, so they go to great lengths to heat themselves back up.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.CoolmitePassive").Value);

            MethodInfo CoolmitePassive2 = TargetType.GetMethod("GetHint", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(CoolmitePassive2,
            "Even cuter in crystal!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcHint.CoolmitePassive").Value);
        }
    }

    public class CoolmiteSmol : TypeEntry {
        public CoolmiteSmol() : base(typeof(StarlightRiver.Content.NPCs.Vitric.CoolmiteSmol)) {}

        public override void Load() {
            MethodInfo CoolmiteSmol = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(CoolmiteSmol,
            "Through the power of Shimmer, this form of Magmite has been cooled into a crystalized shard of sentient magma. Even though this leaves the magmite harmless to other creatures, this rigid form actually hinders its endless curiosity as it can no longer fit itself into small spaces.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.CoolmiteSmol").Value);

            MethodInfo CoolmiteSmol2 = TargetType.GetMethod("GetHint", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(CoolmiteSmol2,
            "Even smoller in crystal!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcHint.CoolmiteSmol").Value);
        }
    }

    public class CoolmiteLarge : TypeEntry {
        public CoolmiteLarge() : base(typeof(StarlightRiver.Content.NPCs.Vitric.CoolmiteLarge)) {}

        public override void Load() {
            MethodInfo CoolmiteLarge = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(CoolmiteLarge,
            "Even through the power of Shimmer, this form of Magmite is so hot that its heat is partially retained. Although its rotund crystal body remains mesmerizing to all that behold it, it seems quite perturbed that it has lost its magnificent swirls.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.CoolmiteLarge").Value);

            MethodInfo CoolmiteLarge2 = TargetType.GetMethod("GetHint", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(CoolmiteLarge2,
            "Even more mesmerizing in crystal!",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcHint.CoolmiteLarge").Value);
        }
    }

    public class CrystalPopper : TypeEntry {
        public CrystalPopper() : base(typeof(StarlightRiver.Content.NPCs.Vitric.CrystalPopper)) {}

        public override void Load() {
            MethodInfo CrystalPopper = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(CrystalPopper,
            "A territorial bat, related to the Sandviper. It launches itself into the air when startled, accompanied with a burst of its nesting crystals towards any nearby foes.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.CrystalPopper").Value);
        }
    }

    public class GruntConstruct : TypeEntry {
        public GruntConstruct() : base(typeof(StarlightRiver.Content.NPCs.Vitric.Gauntlet.GruntConstruct)) {}

        public override void Load() {
            MethodInfo GruntConstruct = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(GruntConstruct,
            "One of the Glassweaver's constructs. Uses its small stature and curved blade to menace challengers up close.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.GruntConstruct").Value);
        }
    }

    public class JuggernautConstruct : TypeEntry {
        public JuggernautConstruct() : base(typeof(StarlightRiver.Content.NPCs.Vitric.Gauntlet.JuggernautConstruct)) {}

        public override void Load() {
            MethodInfo JuggernautConstruct = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(JuggernautConstruct,
            "One of the Glassweaver's constructs. This sturdy brute will often use its allies as projectiles when out of smashing range.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.JuggernautConstruct").Value);
        }
    }

    public class PelterConstruct : TypeEntry {
        public PelterConstruct() : base(typeof(StarlightRiver.Content.NPCs.Vitric.Gauntlet.PelterConstruct)) {}

        public override void Load() {
            MethodInfo PelterConstruct = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(PelterConstruct,
            "One of the Glassweaver's constructs. Relatively fragile, it draws intricate arrows from its own molten body.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.PelterConstruct").Value);
        }
    }

    public class ShieldConstruct : TypeEntry {
        public ShieldConstruct() : base(typeof(StarlightRiver.Content.NPCs.Vitric.Gauntlet.ShieldConstruct)) {}

        public override void Load() {
            MethodInfo ShieldConstruct = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(ShieldConstruct,
            "One of the Glassweaver's constructs. Once its spiked shield is dug into the ground, this stalwart protector is immovable.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.ShieldConstruct").Value);
        }
    }

    public class SupporterConstruct : TypeEntry {
        public SupporterConstruct() : base(typeof(StarlightRiver.Content.NPCs.Vitric.Gauntlet.SupporterConstruct)) {}

        public override void Load() {
            MethodInfo SupporterConstruct = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(SupporterConstruct,
            "One of the Glassweaver's constructs. Channels its power to strengthen its allies' glass bodies. This may result in a power surge.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.SupporterConstruct").Value);
        }
    }

    public class TempleCondition : TypeEntry {
        public TempleCondition() : base(typeof(StarlightRiver.Content.NPCs.Vitric.Gauntlet.TempleCondition)) {}

        public override void Load() {
            MethodInfo TempleCondition = TargetType.GetMethod("GetConditionDescription", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(TempleCondition,
            "When killed inside the vitric forge",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.ConditionDescription.TempleCondition").Value);
        }
    }

    public class FlyingGruntConstruct : TypeEntry {
        public FlyingGruntConstruct() : base(typeof(StarlightRiver.Content.NPCs.Vitric.Gauntlet.FlyingGruntConstruct)) {}

        public override void Load() {
            MethodInfo FlyingGruntConstruct = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(FlyingGruntConstruct,
            "One of the Glassweaver's constructs. An already formidable duelist, made airborne - speed is war.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.FlyingGruntConstruct").Value);
        }
    }

    public class FlyingPelterConstruct : TypeEntry {
        public FlyingPelterConstruct() : base(typeof(StarlightRiver.Content.NPCs.Vitric.Gauntlet.FlyingPelterConstruct)) {}

        public override void Load() {
            MethodInfo FlyingPelterConstruct = TargetType.GetMethod("SetBestiary", BindingFlags.Public | BindingFlags.Instance);
            TranslateTargetType(FlyingPelterConstruct,
            "One of the Glassweaver's constructs. Shares its ground variant's fragility, but it's wings grant it unparalleled vantage.",
            Language.GetText("Mods.StarlightRiverZh.MiscText.Npc.NpcBestiary.FlyingPelterConstruct").Value);
        }
    }
}