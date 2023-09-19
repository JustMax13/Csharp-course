struct Mystruct
{
    public int a;
    public double b;
    public float c;
}

class Program
{
    static void Foo(ref Mystruct myStruct)
    {
        myStruct.b = 2.8;
    }
    static void Main()
    {
        
        Mystruct myStruct = new Mystruct();

        Foo(ref myStruct);
    }
}