

class Quadratic : Function
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Quadratic(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public override double Calculate(double x)
    {
        return A * Math.Pow(x, 2) + B * x + C; 
    }

    public override string ToString()
    {
        return $"Quadratic: A-{A}  B-{B}  C-{C}";
    }
}
