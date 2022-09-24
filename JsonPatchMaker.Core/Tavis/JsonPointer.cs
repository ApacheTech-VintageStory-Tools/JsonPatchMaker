#nullable enable
using Newtonsoft.Json.Linq;

namespace JsonPatchMaker.Core.Tavis
{
    public class JsonPointer
    {
        public List<string> Tokens { get; }

        public JsonPointer(string pointer)
        {
            Tokens = pointer
                .Split('/')
                .Skip(1)
                .Select(Decode)
                .ToList();
        }

        private JsonPointer(IEnumerable<string> tokens) => Tokens = tokens.ToList();

        private static string Decode(string token) => Uri
            .UnescapeDataString(token)
            .Replace("~1", "/")
            .Replace("~0", "~");

        public bool IsNewPointer() => Tokens.Last() == "-";

        public JsonPointer? ParentPointer => Tokens.Count == 0 ? null : new JsonPointer(Tokens.Take(Tokens.Count - 1).ToArray());

        public JToken? Find(JToken? sample)
        {
            if (Tokens.Count == 0) return sample;

            try
            {
                var token = sample;
                foreach (var t in Tokens)
                {
                    if (token is JArray)
                    {
                        token = token[Convert.ToInt32(t)];
                        continue;
                    }
                    token = token?[t];
                    if (token is null) throw new ArgumentException("Cannot find " + t);
                }
                return token;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Failed to dereference pointer", ex);
            }
        }

        public override string ToString() => "/" + string.Join("/", Tokens);
    }
}