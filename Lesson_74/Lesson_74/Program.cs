public class A
{
    public int publicField;
    private int privateField;
    protected int protectedField;
    public A()
    {
        Console.WriteLine(publicField);
        Console.WriteLine(privateField);
        Console.WriteLine(protectedField);
    }
}
class B : A
{
    public B()
    {
        Console.WriteLine(publicField); 
        // Console.WriteLine(privateField); поле не доступно
        Console.WriteLine(protectedField);
    }
}

class Program
{
    static void Main()
    {
        A a = new A();

        a.publicField = 0;
        //a.privateField = 0; поле не доступно
        //a.protectedField = 0; поле не доступно

        B b = new B();

        b.publicField = 0;
        //b.privateField = 0; поле не доступно
        //b.protectedField = 0; поле не доступно
    }
}