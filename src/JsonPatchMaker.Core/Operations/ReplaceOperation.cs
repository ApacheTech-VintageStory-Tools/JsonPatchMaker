using JsonPatchMaker.Core.Tavis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonPatchMaker.Core.Operations
{
    public class ReplaceOperation : Operation
    {
        public JToken Value { get; set; }

        public override void Write(JsonWriter writer)
        {
            writer.WriteStartObject();
            WriteOp(writer, "replace");
            WritePath(writer, Path);
            WriteValue(writer, Value);
            writer.WriteEndObject();
        }

        public override void Read(JObject jOperation)
        {
            Path = new JsonPointer(jOperation.GetValue("path")!.ToObject<string>());
            Value = jOperation.GetValue("value");
        }
    }
}