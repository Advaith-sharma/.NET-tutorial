# .NET-tutorial
This repository contains the essentials of 'Intro to backend dev with .NET' course on coursera.

Module 1: Setting up libraries of .NET, C# coding and running them:
Step 1 Code:
Command to initialize a new C# console application:
>> dotnet new console -n JsonExample

To open the project in Visual Studio Code:
>>cd JsonExample
>>code .

Expected output when running the project:
Hello World!

Step 3 Code:
To install the Newtonsoft.Json package using the command line:
>>dotnet add package Newtonsoft.Json

Checking the csproj file will show an entry similar to:

<PackageReference Include="Newtonsoft.Json" Version="13.0.3" />

Step 4 Code:
Here’s the complete C# code after Step 2:

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
        string json = "{\"Name\": \"John Doe\", \"Age\": 30}";
        Person person = JsonConvert.DeserializeObject<Person>(json);
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}

Expected Output for Step 4:
Name: John Doe, Age: 30

Step 5 Code:
Here's the final code with serialization:

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

Expected Output for Step 5:
Name: John Doe, Age: 30
Serialized JSON: {"Name":"Ping Jeong","Age":25}
