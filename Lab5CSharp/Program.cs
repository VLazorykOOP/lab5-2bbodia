#region Task1 and Task2
using System.Runtime.CompilerServices;

void Task1Task2()
{
    List<Person> people = new List<Person>
    {
       new Person("Bohdan", "Bandura", 19),
    new Employee("Nazar", "Boiko", 25, 10000),
   new Officer("Vasia", "Chmut", 30, 15000, Guid.NewGuid()),
    new Engineer("Dmytro", "Tusk", 40, 2000, 10)
};

    foreach (var pers in people)
    {
        Console.WriteLine($"{pers.GetType().Name}    {pers.ShowInfo()}");
    }
}

Task1Task2();
GC.Collect();
Thread.Sleep(2000); 
Console.WriteLine("Press any key to continue...");
Console.ReadKey();

Console.Clear();
#endregion

#region Task3
List<Function> functions = new List<Function>
{
    new Line(1,2),
    new Quadratic(1,2,3),
    new Hyperbola(5)
};
double x = 4;
foreach (var func in functions)
{
    Console.WriteLine(func);
    Console.WriteLine($"X = {x}");
    Console.WriteLine($"Y = {func.Calculate(x)}");
}
#endregion