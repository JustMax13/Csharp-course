class Point2D
{
    public Point2D(int X, int Y)
    {
        Console.WriteLine("Вызван конструктор класса Point2D");
        this.X = X;
        this.Y = Y;
        
    }
    public int X { get; set; }
    public int Y { get; set; }
    public void Print2D()
    {
        Console.WriteLine($"X: {X},\nY: {Y}");
    }
}
class Point3D : Point2D
{
    public Point3D(int X, int Y, int Z) : base(X, Y)
    {
        Console.WriteLine("Вызван конструктор класса Point3D");
        this.Z = Z;
    }
    public int Z { get; set; }
    public void Print3D()
    {
        Print2D();
        Console.WriteLine($"Z: {Z}");
    }
}

class Program
{
    static void Main()
    {
        Point3D point = new Point3D(3,6,9);
        point.Print3D();
    }
}