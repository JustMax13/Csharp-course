class Program
{
    static void Main()
    {
        double result = Multiply(3,4);
        Console.WriteLine(result);

        result = Multiply(3, 4, 5);
        Console.WriteLine(result);

        result = Multiply(4.6 , 2);
        Console.WriteLine(result);
    }
    /// <summary>
    /// Multeplication of two integers 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    static int Multiply(int a, int b)
    {
        return a * b;
    }
    static int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }
    static double Multiply(double a, double b)
    {
        return a * b;
    }
}