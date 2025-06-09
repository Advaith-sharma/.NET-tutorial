// using Newtonsoft.json;

// public class Product{
//     public string Name{ get; set;}
//     public string Price{ get; set;}
//     public List<string> Tags{ get; set;} 
// }

// public class Program{
//     public static void Main(){
//         //Serialize
//         string json="{\"Name\": \"Laptop\", \"Price\": 999.99, \"Tags\": [\"Electronics\", \"Computers\"]}";
//         Product product = JsonConvert.DeserializeObject<Product>(json);
//         Console.WriteLine[$"Product: {product.Name}, Price:{product.Price}, Tags:{string.join(", ", product.Tags)}"];

//         //Deserialize
//         // Product newProduct=new Product{
//         //     Name="Smartphone",
//         //     Price=699.99m,
//         //     Tags=new List<string>{"Electronics","Mobile"},
//         // };
//         // string newJson=JsonConvert.SerializeObject(newProduct,Formatting.Indented);
//         // Console.WriteLine($"Serialized JSON: \n{newJson}");
//     }
// }

using System;
using Newtonsoft.Json;
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
public class Program
{
    public static void Main()
    {
        // Deserialize JSON to Person object
        string json = "{\"Name\": \"John Doe\", \"Age\": 30}";
        Person person = JsonConvert.DeserializeObject<Person>(json);
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        // Serialize Person object to JSON
        Person newPerson = new Person { Name = "Ping Jeong", Age = 25 };
        string newJson = JsonConvert.SerializeObject(newPerson);
        Console.WriteLine($"Serialized JSON: {newJson}");
    }
}