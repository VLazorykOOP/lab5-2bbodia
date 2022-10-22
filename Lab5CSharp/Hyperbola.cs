

class Hyperbola : Function
{
    public double K { get; set; }

    public Hyperbola(double k)
    {
        K = k;
    }

    public override double Calculate(double x)
    {
        return K / x;
    }

    public override string ToString()
    {
        return $"Hyperbola: K-{K}";
    }
}