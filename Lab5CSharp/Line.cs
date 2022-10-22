

class Line : Function
{
    private double A { get; set; }
    private double B { get; set; }

    public Line(double a, double b)
    {
        A = a;
        B = b;
    }

    public override double Calculate(double x)
    {
        return A * x + B;
    }

    public override string ToString()
    {
        return $"Line : A-{A} B-{B}";
    }
}
