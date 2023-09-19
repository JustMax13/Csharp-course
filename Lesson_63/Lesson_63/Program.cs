class MyClass
{
    public static int b { get; set; }
    public void PrintB()
    {
        Console.WriteLine(b);
    }
}
class Program
{
    static void Main()
    {
        MyClass mc1 = new MyClass();
        MyClass.b = 4;

        MyClass mc2 = new MyClass();
        mc2.PrintB();
    }
}