using JsonPatchMaker.Core.Tavis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// ReSharper disable MemberCanBePrivate.Global

namespace JsonPatchMaker.Core.Operations
{
    public class CopyOperation : Operation
    {
        public JsonPointer FromPath { get; set; }

        public override void Write(JsonWriter writer)
        {
            writer.WriteStartObject();
            WriteOp(writer, "copy");
            WritePath(writer, Path);
            WriteFromPath(writer, FromPath);
            writer.WriteEndObject();
        }

        public override void Read(JObject jOperation)
        {
            Path = new JsonPointer(jOperation.GetValue("path")!.ToObject<string>());
            FromPath = new JsonPointer(jOperation.GetValue("from")!.ToObject<string>());
        }
    }
}