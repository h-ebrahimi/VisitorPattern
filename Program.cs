// See https://aka.ms/new-console-template for more information
using VisitorPattern.App;

Console.WriteLine("Hello, World!");

IVisitor visitor = new Visitor();
visitor.AddComponent(new Odd());
visitor.AddComponent(new Even());

var number = 546131;
var component = visitor.Components.FirstOrDefault(f => f.Can(number));
var result = component.Do(number);

Console.WriteLine(result);
Console.ReadLine();