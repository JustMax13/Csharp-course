class MyClass
{
    public int ac;
    public double bc;
    public float cc;
}


class Program
{
    static void Foo(MyClass myClass)
    {
        myClass.bc = 2.8;
    }
    static void Main()
    {

        MyClass myStruct = new MyClass();

        Foo(myStruct);
    }
}