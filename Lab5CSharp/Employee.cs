class Employee : Person
{
    public Employee(string name, string surname, int age, int salary) : base(name, surname, age)
    {
        Console.WriteLine("Employee constructor");
        Salary = salary;
    }
    public Employee(string name,string surname, int age) : this(name,surname,age, 6500) { }
    public Employee(string name, string surname) : this(name, surname, 18) { }
    ~Employee()
    {
        Console.WriteLine($"Employee {Name} {Surname} destructor");
    }
    public int Salary { get; set; }

    public override string ShowInfo()
    {
        return base.ShowInfo() + $", Salary: {Salary}";
    }
}