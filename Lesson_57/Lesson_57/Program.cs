enum Color
{
    Red,
    Green,
    Blue,
    White,
    Black
}

class Point
{
    public int x;
    private int y;  // мы сделали это поле приватным, поэтому мы не сможем использовать его из вне
    public Color color;
    // Private может быть так же применино к методам

    public void write()
    {
        Console.WriteLine("Hi, its method write");
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point();

        p1.write();
        p1.color = Color.Red;
    }
}