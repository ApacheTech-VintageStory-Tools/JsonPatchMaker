using System.Text;
using JsonPatchMaker.Core.Operations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global

namespace JsonPatchMaker.Core
{
    public class PatchDocument
    {
        public PatchDocument(params Operation[] operations)
        {
            foreach (var operation in operations)
                AddOperation(operation);
        }

        public List<Operation> Operations { get; } = new();

        public void AddOperation(Operation operation) => Operations.Add(operation);

        public static PatchDocument Load(Stream document) => Parse(new StreamReader(document).ReadToEnd());

        public static PatchDocument Load(JArray document)
        {
            var patchDocument = new PatchDocument(Array.Empty<Operation>());
            if (document is null) return patchDocument;
            foreach (var jOperation in document.Children().Cast<JObject>())
            {
                var operation = Operation.Build(jOperation);
                patchDocument.AddOperation(operation);
            }
            return patchDocument;
        }

        public static PatchDocument Parse(string jsonDocument) => Load(JToken.Parse(jsonDocument) as JArray);

        public static Operation CreateOperation(string op)
        {
            return op switch
            {
                "add" => new AddOperation(),
                "copy" => new CopyOperation(),
                "move" => new MoveOperation(),
                "remove" => new RemoveOperation(),
                "replace" => new ReplaceOperation(),
                _ => new TestOperation()
            };
        }

        public MemoryStream ToStream()
        {
            var stream = new MemoryStream();
            CopyToStream(stream);
            stream.Flush();
            stream.Position = 0L;
            return stream;
        }

        public void CopyToStream(Stream stream, Formatting formatting = Formatting.Indented)
        {
            var writer = new JsonTextWriter(new StreamWriter(stream))
            {
                Formatting = formatting
            };
            writer.WriteStartArray();
            foreach (var operation in Operations)
                operation.Write(writer);
            writer.WriteEndArray();
            writer.Flush();
        }

        public override string ToString() => ToString((Formatting)1);

        public string ToString(Formatting formatting)
        {
            using var memoryStream = new MemoryStream();
            CopyToStream(memoryStream, formatting);
            memoryStream.Position = 0L;
            using var streamReader = new StreamReader(memoryStream, Encoding.UTF8);
            return streamReader.ReadToEnd();
        }
    }
}