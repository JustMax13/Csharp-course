interface IInterface
{
    void Somemethod()
    {
        Console.WriteLine("Дефолтнвя реализация метода Somemethod()");
    }

}
class MyClass1 : IInterface
{
    public void Somemethod()
    {
        Console.WriteLine("Метод Somemethod() реализован в классе MyClass");
    }
}
class MyClass2 : IInterface
{
    // тут у нас нет нашего мотода
}

class Program
{
    static void Main()
    {
        IInterface interface1 = new MyClass1();
        MyClass1 Mc1 = new MyClass1();
        IInterface interface2 = new MyClass2();
        MyClass2 Mc2 = new MyClass2();

        interface1.Somemethod();
        Mc1.Somemethod();
        interface2.Somemethod();
        // Mc2.Somemethod(); найти решение
    }
    
}