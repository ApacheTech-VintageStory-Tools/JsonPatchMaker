using JsonPatchMaker.Core.Tavis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonPatchMaker.Core.Operations
{
    public class RemoveOperation : Operation
    {
        public override void Write(JsonWriter writer)
        {
            writer.WriteStartObject();
            WriteOp(writer, "remove");
            WritePath(writer, Path);
            writer.WriteEndObject();
        }

        public override void Read(JObject jOperation) => Path = new JsonPointer(jOperation.GetValue("path")!.ToObject<string>());
    }
}