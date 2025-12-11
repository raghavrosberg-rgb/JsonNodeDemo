//What is JObject?
//Flexible, mutable JSON object from Newtonsoft.Json(Json.NET).
//Dynamic editing and building
//Widely used and mature library
//Rich feature set for JSON manipulation
//Supports LINQ to JSON
//Supports LINQ queries
//More feature-rich
//Great for complex transformations
//Example usage of JObject
#:package Newtonsoft.Json@13.0.4
using Newtonsoft.Json.Linq;

string json = 
"{\"name\":\"MyDotNet\",\"since\":2016}";
var obj = JObject.Parse(json);
// Modify the JSON
obj["since"] = 2017;
obj["city"] = "Mysuru";
Console.WriteLine(obj.ToString());

//Linq query example
string usersJson =
@"{ ""users"": [ { ""name"": ""MyDotNetUser1"", ""age"": 18 }, { ""name"": ""MyDotNetUser2"", ""age"": 25 } ] }";

var obj1 = JObject.Parse(usersJson);
var users = obj1["users"]?
    .Children<JObject>()
    .Where(u => ((int?)u["age"] ?? 0) >= 18)
    .Select(u => (string?)u["name"])
    .ToList() ?? new List<string?>();

foreach (var user in users)
{
    Console.WriteLine(user);
}