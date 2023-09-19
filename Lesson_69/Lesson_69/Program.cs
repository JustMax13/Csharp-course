/*
 разница const и readonly
 */
class MyClass
{
    public const int value = 5; // не может не присвоить сразу значение 
    public readonly int value_ro; // можем не присвоить изначально значения
    public static readonly int valuero;
    static MyClass()
    {
        for (bool Try = false; Try == false; )
        {
            Try = int.TryParse(Console.ReadLine(), out valuero);
        }      
    }
    public MyClass(int value_ro)
    {
        this.value_ro = value_ro;
    }
    public static int Sum2value()
    {
        return value + value;
    }

}
class Program
{
    static void Main()
    {
        Console.WriteLine(MyClass.value);
    }
}