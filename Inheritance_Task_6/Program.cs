using Inheritance_Task_6;

Animal animal;

string animalType = Console.ReadLine();
var animalInfo = Console.ReadLine().Split();
var name = animalInfo[0];
var age = int.Parse(animalInfo[1]);

if (animalType.ToLower() == "dog")
{
    var gender = animalInfo[2];
    animal = new Dog(name, age, gender);
}
else if (animalType.ToLower() == "cat")
{
    var gender = animalInfo[2];
    animal = new Cat(name, age, gender);
}
else if (animalType.ToLower() == "frog")
{
    var gender = animalInfo[2];
    animal = new Frog(name, age, gender);
}
else if (animalType.ToLower() == "kittens")
{
    animal = new Kittens(name, age);
}
else if (animalType.ToLower() == "tomcat")
{
    animal = new Tomcat(name, age);
}
else
{
    throw new Exception("Invalid input!");
}

Console.WriteLine($"{animal.Name} - {animal.Age} - {animal.Gender}");
Console.WriteLine(animal.ProduceSound());