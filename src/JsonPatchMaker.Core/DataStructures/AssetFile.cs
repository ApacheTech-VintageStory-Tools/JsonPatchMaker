// ReSharper disable CommentTypo
// ReSharper disable MemberCanBePrivate.Global

namespace JsonPatchMaker.Core.DataStructures
{
    /// <summary>
    ///     Represents a JSON asset file.
    /// </summary>
    public class AssetFile
    {
        private readonly string _assetString = $"assets{Path.DirectorySeparatorChar}";

        public string Domain { get; set; } = "game";

        public string Directory { get; set; } = "";

        public FileInfo File { get; }

        public bool IsGameAsset { get; }

        /// <summary>
        ///     Initialises a new instance of the <see cref="AssetFile"/> class.
        /// </summary>
        /// <param name="file">The asset file.</param>
        public static AssetFile FromFileInfo(FileInfo file)
        {
            return new AssetFile(file);
        }
        
        private AssetFile(FileInfo file)
        {
            var absolutePath = (File = file).FullName;
            if (string.IsNullOrWhiteSpace(absolutePath)) throw new ArgumentNullException(nameof(absolutePath));
            IsGameAsset = absolutePath.Contains(_assetString);
            if (IsGameAsset)
            {
                DescribeGameAsset(absolutePath);
                return;
            }
            DescribeNonGameAsset(absolutePath);
        }

        public override string ToString()
        {
            var path = string.IsNullOrWhiteSpace(Directory) ? File.Name : $"{Directory}/{File.Name}";
            return $"{Domain}:{path}";
        }

        private void DescribeGameAsset(string absolutePath)
        {
            // If in assets directory...
            // 
            //  - D:\Games\Vintage Story\assets\game\entities\humanoid\player.json
            // 
            // 1. Remove absolute assets path `D:\Games\Vintage Story\assets\`.
            // 
            //  - game\entities\humanoid\player.json
            var index = absolutePath.IndexOf(_assetString, StringComparison.Ordinal) + _assetString.Length;
            var prefix = absolutePath.Remove(index);
            var relativePath = absolutePath[prefix.Length..];

            // 2. Split into an array by Path.DirectorySeparatorChar.
            // 
            //  - { "game", "entities", "humanoid", "player.json" }
            var parts = relativePath.Split(Path.DirectorySeparatorChar).ToList();

            // 3. Assign first string as the Domain.
            var domain = parts[0];
            foreach (var vanillaPath in new[] { "game", "survival", "creative" })
            {
                if (!domain.Equals(vanillaPath)) continue;
                domain = "game";
            }
            Domain = domain;

            // 4. Assign the rest of the array as the path, joined with "/".
            var remainingParts = parts.Skip(1).Except(new[] { parts[^1] });
            Directory = string.Join("/", remainingParts);
        }

        private void DescribeNonGameAsset(string absolutePath)
        {
            // If not in assets directory...
            // 
            // Needs extra input. Do the best we can. 
            // Properties are left mutable for UI to inject values manually.
            // 
            // 1. Assign Domain as "game".
            Domain = "game";

            // 2. Assign directory as the directory the file resides in.
            var parts = absolutePath.Split(Path.DirectorySeparatorChar).ToList();
            Directory = parts[^2];
        }
    }
}