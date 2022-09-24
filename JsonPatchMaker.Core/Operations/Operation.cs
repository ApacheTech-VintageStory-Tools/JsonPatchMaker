using JsonPatchMaker.Core.Tavis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// ReSharper disable MemberCanBeProtected.Global

namespace JsonPatchMaker.Core.Operations
{
    public abstract class Operation
    {
        public JsonPointer Path { get; set; }

        public abstract void Write(JsonWriter writer);

        protected static void WriteOp(JsonWriter writer, string op)
        {
            writer.WritePropertyName(nameof(op));
            writer.WriteValue(op);
        }

        protected static void WritePath(JsonWriter writer, JsonPointer pointer)
        {
            writer.WritePropertyName("path");
            writer.WriteValue(pointer.ToString());
        }

        protected static void WriteFromPath(JsonWriter writer, JsonPointer pointer)
        {
            writer.WritePropertyName("from");
            writer.WriteValue(pointer.ToString());
        }

        protected static void WriteValue(JsonWriter writer, JToken value)
        {
            writer.WritePropertyName(nameof(value));
            value.WriteTo(writer, Array.Empty<JsonConverter>());
        }

        public abstract void Read(JObject jOperation);

        public static Operation Parse(string json) => Build(JObject.Parse(json));

        public static Operation Build(JObject jOperation)
        {
            var operation = PatchDocument.CreateOperation(jOperation["op"].ToObject<string>());
            operation.Read(jOperation);
            return operation;
        }
    }
}