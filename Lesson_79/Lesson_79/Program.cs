interface IFirstInterface
{
    void Action();
}
interface ISecondInterface
{
    void Action();
}
class Class : IFirstInterface, ISecondInterface
{
    public void Action()
    {
        Console.WriteLine("Шо это вообще такое");
    }
}
class MyClass : IFirstInterface, ISecondInterface
{
    // тут мы явно реализовали метод Action 2х интерфейсов
    void IFirstInterface.Action()
    {
        Console.WriteLine("Я IFirstInterface.Action()");
    }

    void ISecondInterface.Action()
    {
        Console.WriteLine("Я ISecondInterface.Action()");
    }
}

class Program
{
    static void Main()
    {
        Foo(new Class());
        Bar(new Class());

        Console.WriteLine("------------");

        Foo(new MyClass());
        Bar(new MyClass());

        Console.WriteLine("------------");

        MyClass myClass = new MyClass();
        ((IFirstInterface)myClass).Action();
        ((ISecondInterface)myClass).Action();

        Console.WriteLine("------------");
        
        object obj = new object();
        MyClass MyClass1= new MyClass();

        // ((IFirstInterface)obj).Action(); приведет к ошибке, поэтому нужно сделать поверку:
        if (obj is IFirstInterface firstInterface)
        {
            firstInterface.Action();
        }
        if (MyClass1 is ISecondInterface secondInterface)
        {
            secondInterface.Action();
        }
    }
    static void Foo(IFirstInterface firstInterface)
    {
        firstInterface.Action();
    }
    static void Bar(ISecondInterface secondInterface)
    {
        secondInterface.Action();
    }
}