using JsonPatchMaker.Core.DataStructures;
using Newtonsoft.Json.Linq;

namespace JsonPatchMaker.Core
{
    public static class Patcher
    {
        // relPath = [assets/] => [game/lang/en.json]
        public static JToken GeneratePatch(string leftJson, string rightJson, string path, AppSide side)
        {
            try
            {
                var left = JToken.Parse(leftJson);
                var right = JToken.Parse(rightJson);
                var diff = JsonDiffer.Diff(left, right, false);
                var patchFile = JToken.Parse(diff.ToString());
                var relPath = GetRelativePath(path);
                foreach (var patch in patchFile)
                {
                    var str = "";
                    foreach (var vanillaPath in new[] { "game", "survival", "creative" })
                    {
                        if (!relPath.StartsWith($"{vanillaPath}/")) continue;
                        str = "game:";
                        relPath = relPath[$"{vanillaPath}/".Length..];
                    }
                    patch["file"] = JToken.FromObject(str + relPath);
                    if (side != AppSide.Universal)
                    {
                        patch["side"] = JToken.FromObject(side.ToString());
                    }
                }
                return patchFile;
            }
            catch
            {
                return JToken.Parse("[]");
            }
        }


        private static string GetRelativePath(string path)
        {
            var directory = new DirectoryInfo(path);
            while (!directory!.Name.Equals("assets")) directory = directory!.Parent;
            var relPath = path.Replace($"{directory.FullName}\\", "");
            return relPath.Replace(Path.DirectorySeparatorChar.ToString(), "/");
        }

        private static string GetRelativePath(FileInfo file)
        {
            var directory = file.Directory;
            while (!directory!.Name.Equals("assets")) directory = directory!.Parent;
            var relPath = file.FullName.Replace($"{directory.FullName}\\", "");
            return relPath.Replace(Path.DirectorySeparatorChar.ToString(), "/");
        }

        public static string GeneratePatch(FileInfo originalFile, string editedJson, AppSide side)
        {
            var relPath = GetRelativePath(originalFile);
            var originalJson = originalFile.ToString();
            return GeneratePatch(originalJson, editedJson, relPath, side).ToString();
        }
    }
}