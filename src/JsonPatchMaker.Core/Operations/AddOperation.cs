using JsonPatchMaker.Core.Tavis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonPatchMaker.Core.Operations
{
    public class AddOperation : Operation
    {
        public JToken Value { get; set; }
        
        public override void Write(JsonWriter writer)
        {
            if (int.TryParse(Path.Tokens[^1], out _)) Path.Tokens[^1] = "-";
            writer.WriteStartObject();
            WriteOp(writer, "add");
            WritePath(writer, Path);
            WriteValue(writer, Value);
            writer.WriteEndObject();
        }

        public override void Read(JObject jOperation)
        {
            Path = new JsonPointer(jOperation.GetValue("path")!.ToObject<string>()!);
            Value = jOperation.GetValue("value");
        }
    }
}