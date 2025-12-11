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
"{\"name\":\"Kris\",\"age\":30}";
var obj = JObject.Parse(json);
// Modify the JSON
obj["age"] = 31;
obj["city"] = "Vienna";
Console.WriteLine(obj);