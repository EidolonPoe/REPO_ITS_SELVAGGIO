// See https://aka.ms/new-console-template for more information
using ConsoleReflection;

Console.WriteLine("Hello, World!");

//reflection utizzata per ottenere le classi, metodi e proprietà 

var macchina = new Car();

Type type = typeof(Car);

foreach (var property in type.GetProperties())
{
    Console.WriteLine($"Property: {property.Name}- type: {property.PropertyType}");
}

foreach (var method in type.GetMethods())
{
    Console.WriteLine($"Method: {method.Name}- type: {method.ReturnType}");
}