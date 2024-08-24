using HarmonyLib;
using Verse;

namespace DIL_ChinampaFarming
{
    public class ChinampaFarming : Mod
    {
        public ChinampaFarming(ModContentPack content) : base(content)
        {
            Log.Message("<color=#00FF7F>[Chinampas Farming]</color>v1.5.2");
            var harmony = new Harmony("DIL.ChinampaFarming");
            harmony.PatchAll();
        }
    }
}

