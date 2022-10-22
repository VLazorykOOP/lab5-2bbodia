class Officer : Employee
{
    public Officer(string name, string surname, int age, int salary, Guid signNumber)
        : base(name, surname, age, salary)
    {
        Console.WriteLine("Officer constructor");
        SignNumber = signNumber;
    }
    public Officer(string name, string surname, int age, int salary) : this(name, surname, age, salary, Guid.NewGuid())
    {
    }
    public Officer(string name, string surname, int age) : this(name, surname, age, 20000)
    {
    }
    ~Officer()
    {
        Console.WriteLine($"Officer {Name} {Surname} destructor");
    }

    public Guid SignNumber { get; set; }

    public override string ShowInfo()
    {
        return base.ShowInfo() + $", SignNumber: {SignNumber}";
    }


}