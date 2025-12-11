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
// ensure Parse returned a non-null node
var node = JsonNode.Parse(json) ?? throw new InvalidOperationException("Failed to parse JSON.");
// Modify the JSON
node["since"] = 2017;
node["city"] = "Mysuru";
Console.WriteLine(node.ToJsonString());

//Linq query example
string usersJson =
@"{ ""users"": [ { ""name"": ""MyDotNetUser1"", ""age"": 18 }, { ""name"": ""MyDotNetUser2"", ""age"": 25 } ] }";

var root = JsonNode.Parse(usersJson);
var users = root?["users"]?.AsArray()?
    .Select(u => new { age = u?["age"]?.GetValue<int?>(), name = u?["name"]?.GetValue<string?>() })
    .Where(x => (x.age ?? 0) >= 18 && x.name is not null)
    .Select(x => x.name!)
    .ToList() ?? new List<string>();

foreach (var user in users)
{
    Console.WriteLine(user);
}