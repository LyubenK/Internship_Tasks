using System.Runtime.Serialization.Json;
using Tasks_1_To_12;

var personInput = Console.ReadLine().Split(); 
string name = personInput[0];
int age = int.Parse(personInput[1]);
var person = new Person(name, age);
Console.WriteLine($"{person.Name} {person.Age}");


var childInput = Console.ReadLine().Split();
string childName = childInput[0];
int childAge = int.Parse(childInput[1]);
var child = new Child(childName, childAge);
Console.WriteLine($"{child.Name} {child.Age}");
