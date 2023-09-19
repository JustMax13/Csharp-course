class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Конструктор класса");
    }
    static MyClass()
    {
        Console.WriteLine("Статический конструктор класса");
    }
}

class Program
{
    static void Main()
    {
        MyClass myClass = new MyClass();

        new MyClass();
        new MyClass();
        new MyClass();
    }
}