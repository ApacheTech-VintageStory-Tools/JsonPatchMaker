using JsonPatchMaker.Core.DataStructures;
using Newtonsoft.Json.Linq;

namespace JsonPatchMaker.Core
{
    public static class Patcher
    {
        public static JToken GeneratePatch(AssetFile originalFile, string editedJson, AppSide side)
        {
            var originalJson = File.ReadAllText(originalFile.File.FullName);

            try
            {
                var left = JToken.Parse(originalJson);
                var right = JToken.Parse(editedJson);
                var diff = JsonDiffer.Diff(left, right, false);
                var patchFile = JToken.Parse(diff.ToString());
                foreach (var patch in patchFile)
                {
                    ApplyPathToken(patch, originalFile);
                    ApplySideToken(patch, side);
                }
                return patchFile;
            }
            catch
            {
                return JToken.Parse("[]");
            }

        }

        private static void ApplyPathToken(JToken patch, AssetFile assetFile)
        {
            patch["file"] = JToken.FromObject(assetFile.ToString());
        }

        private static void ApplySideToken(JToken patch, AppSide side)
        {
            if (side == AppSide.Universal) return;
            patch["side"] = JToken.FromObject(side.ToString());
        }
    }
}