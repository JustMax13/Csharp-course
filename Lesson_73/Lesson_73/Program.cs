//приведение типов и наследование

//использование операторов as и is
class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public void Print()
    {
        Console.WriteLine($"X: {X}\nY: {Y}");
    }
}

class Program
{
    static void Main()
    {
        object obj = new Point() { X = 3, Y = 15 }; // неявное привидения типов
        /*object a = 5;
        object b = "Hello!";
        a = "Даже так можно";*/
        Foo(obj);
        Console.WriteLine("-----------");
        Bar(obj);
    }
    static void Foo(object obj)
    {
        // если бы у нас к примеру obj = "ggghfg" было, то у после кода на следующей строке
        // в point был бы null
        Point point = obj as Point;

        if (point != null)
        {
            point.Print();
        }
    }
    static void Bar(object obj)
    {
        if (obj is Point point)
        {
            point.Print();
        }
    }
}