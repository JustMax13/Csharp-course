enum Color
{
    Red,
    Green,
    Blue,
    White,
    Black
}

class Point // class - тип структуры; Point - название класса
{
    public int x;
    public int y; // public - модификатор доступа
    // переменные в своем созданном классе называются *полями класса*
    public Color color;

    public static void pic()
    {
        // так же в своем классе мы можем описать свои методы
        Console.WriteLine("Hi, its pic");
        // правда пока что я не хна как это работает :3
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(); // Так мы создали объект нашего класса
                                // где р1 - имя нашего объекта, а по правую сторуну от равно мы выделяем
                                // оперативную память в управляемой куче под объект

        // тоесть по сути класс Point - это наш чертеж
        // то объект р1 - это наш уже готовый дом

        p1.x = 4;
        p1.y = 2;
        Console.WriteLine($"X = {p1.x} | Y = {p1.y}");

        Point p2 = new Point();

        p2.x = 3;
        p2.y = 9;
        //
        p2.color = Color.White;
        Console.WriteLine($"P2 color => {p2.color}");
    }
}