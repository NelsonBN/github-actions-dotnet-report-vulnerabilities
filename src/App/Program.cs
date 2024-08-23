var json = """
{
  "name": "John",
  "age": 30
}
""";

var person = Lib.Tool.Method(json);


Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
