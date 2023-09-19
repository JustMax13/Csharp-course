class MyClass
{
    public static int a;
    public int b;
    public void Bar()
    {
        Console.WriteLine("Вызван метод Bar");
        Foo();
        Console.WriteLine("Продолжение Bar");
        b = a + 1;
        Console.WriteLine("b = " + b);
    }
    public static void Foo()
    {
        Console.WriteLine("Вызван метод Foo");
        a = 22;
        Console.WriteLine("a = " + a);
    }


    private static int _c;

    public static int c
    {
        get { return _c; }
        set { _c = value; }
    }



}
class Program
{
    static void Main()
    {
        MyClass obj = new MyClass();

        obj.Bar();

        MyClass.c = 5;
        //----------------

        HW.test();
    }
}