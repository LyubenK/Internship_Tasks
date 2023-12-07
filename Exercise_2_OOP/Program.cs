using Exercise_2_OOP;

int N = int.Parse(Console.ReadLine());
var family = new Family();

for (int i = 0; i < N; i++)
{
    string[] personInformation = Console.ReadLine().Split();
    string name = personInformation[0];
    int age = int.Parse(personInformation[1]);

    Person person = new Person(name, age);

    family.AddMember(person);
}

foreach (var person in family.People)
{
    Console.WriteLine(person.ToString());
}

Console.Write("Oldest member: ");
var oldestPerson = family.GetOldestMember();
Console.WriteLine(oldestPerson.ToString());
