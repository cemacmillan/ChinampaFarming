using HarmonyLib;
using Verse;

namespace DIL_ChinampaFarming
{
    public class ChinampaFarming : Mod
    {
        public ChinampaFarming(ModContentPack content) : base(content)
        {
            var harmony = new Harmony("DIL.ChinampaFarming");
            harmony.PatchAll();
        }
    }
}

