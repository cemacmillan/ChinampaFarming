using System.Text;
using System.Text.RegularExpressions;
using RimWorld;
using Verse;

namespace DIL_ChinampaFarming
{
    public class BuildingChinampa : Building_PlantGrower
    {
        public override string GetInspectString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            // Append the base inspect string, if it's not empty.
            string baseInspectString = base.GetInspectString();
            if (!string.IsNullOrEmpty(baseInspectString))
            {
                Log.Message("Appending base inspect string: " + baseInspectString);
                stringBuilder.AppendLine("Base inspect string: " + baseInspectString);
            }

            // Append the growth season string.
            if (base.Spawned)
            {
                if (!PlantUtility.GrowthSeasonNow(base.Position, base.Map, forSowing: true))
                {
                    Log.Message("Appending 'CannotGrowBadSeasonTemperature' string");
                    stringBuilder.AppendLine("CannotGrowBadSeasonTemperature".Translate());
                }
                else
                {
                    Log.Message("Appending 'GrowSeasonHereNow' string");
                    stringBuilder.AppendLine("GrowSeasonHereNow".Translate());
                }
            }

            // Convert the StringBuilder to a string and return it.
            string inspectString = stringBuilder.ToString();

            // Remove any trailing newline characters.
            inspectString = inspectString.TrimEnd('\r', '\n');

            // Log the final inspect string.
            Log.Message("Final inspect string for " + this + ": " + inspectString);

            return inspectString;
        }

        public override float Fertility
        {
            get
            {
                if (this.Map.terrainGrid.TerrainAt(this.Position).defName == "MarshyTerrain")
                {
                    return 2.0f;
                }
                else
                {
                    return base.Fertility;
                }
            }
        }




    }
}


