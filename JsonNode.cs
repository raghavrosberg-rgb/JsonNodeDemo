//What is JsonNode?
//Modern, mutable JSON from System.Text.Json.Nodes(.NET 6 +).

//Mutable - modify JSON dynamically
//Built into .NET 6+
//Better performance than JObject
//Part of System.Text.Json ecosystem
//Supports LINQ queries
//Easier integration with other System.Text.Json features
//Example usage of JsonNode
#:package System.Text.Json@10.0.1
using System.Text.Json.Nodes;

string json =
"{\"name\":\"MyDotNet\",\"since\":2016}";
var node = JsonNode.Parse(json);
// Modify the JSON
node["since"] = 2017;
node["city"] = "Mysuru";
Console.WriteLine(node.ToJsonString());