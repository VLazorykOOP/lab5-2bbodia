class Engineer : Employee
{
    public Engineer(string name, string surname, int age, int salary, int experience) :
        base(name, surname, age, salary)
    {
        Console.WriteLine("Engineer constructor");
        Experience = experience;
    }
    public Engineer(string name, string surname, int age, int salary) : this(name, surname, age, salary, 0)
    {
    }
    public Engineer(string name, string surname, int age) : this(name, surname, age, 10000)
    {
    }
    ~Engineer()
    {
        Console.WriteLine($"Engineer {Name} {Surname} destructor");
    }
    public int Experience { get; set; }

    public override string ShowInfo()
    {
        return base.ShowInfo() + $", Experience: {Experience}";
    }
}