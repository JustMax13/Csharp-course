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
    public int y;
    public Color color;

    public void write() // Так мы создаем метод в классе
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
    }
}