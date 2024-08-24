using DIL_ChinampaFarming;
using HarmonyLib;
using RimWorld;

[HarmonyPatch(typeof(Building_PlantGrower), "CanAcceptSowNow")]
public static class CanAcceptSowNow_Patch
{
    public static void Postfix(Building_PlantGrower __instance, ref bool __result)
    {
        if (__instance is BuildingChinampa)
        {
            __result = true;
        }
    }
}

