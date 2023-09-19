static class MyClass
{
    static MyClass()
    {
        Console.WriteLine("Обращение к статическому классу");
    }
    public static void Foo()
    {
        Console.WriteLine("Статический метод Foo");
    }

}
class Program
{
    static void Main()
    {
        MyClass.Foo();
    }
}