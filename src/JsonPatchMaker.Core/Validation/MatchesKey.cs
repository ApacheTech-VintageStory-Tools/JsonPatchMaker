using Newtonsoft.Json.Linq;

namespace JsonPatchMaker.Core.Validation
{
    public class MatchesKey : IEqualityComparer<KeyValuePair<string, JToken>>
    {
        public static readonly MatchesKey Instance = new();

        public bool Equals(KeyValuePair<string, JToken> x, KeyValuePair<string, JToken> y) => x.Key.Equals(y.Key);

        public int GetHashCode(KeyValuePair<string, JToken> obj) => obj.Key.GetHashCode();
    }
}