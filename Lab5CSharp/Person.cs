class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public Person(string name, string surname, int age)
    {
        Console.WriteLine("Person constructor");
        Name = name;
        Surname = surname;
        Age = age;
    }
    public Person(string name, string surname) : this(name, surname, 18)
    {
    }
    public Person(string name) : this(name, string.Empty, 18)
    {
    }

    ~Person()
    {
        Console.WriteLine($"Person {Name} {Surname} destructor");
    }

    public virtual string ShowInfo()
    {
        return $"Name: {Name}, Surname: {Surname}, Age: {Age}";
    }
}