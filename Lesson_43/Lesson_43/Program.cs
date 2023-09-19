class Program
{
    static void Foo(ref int a)
    {
        a = -5;
    }
    static void Main()
    {
        int a = 2;
        Foo(ref a);

        Console.WriteLine(a);
    }
}