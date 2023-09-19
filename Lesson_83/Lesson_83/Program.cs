class Program
{
    static void Main()
    {
        int a = 5;
        int b = 6;

        Console.WriteLine($"a: {a}, b: {b}");

        Swap(ref a, ref b);

        Console.WriteLine($"a: {a}, b: {b}");

        string str1 = "hello";
        string str2 = "world";
        Console.WriteLine($"str1 = {str1}, str2 = {str2}");

        Swap(ref str1, ref str2);

        Console.WriteLine($"str1 = {str1}, str2 = {str2}");



        int result = Foo<int>();
    }
    static void Swap<TSwap>(ref TSwap vavue1, ref TSwap value2)
    {
        TSwap temp = vavue1;
        vavue1 = value2;
        value2 = temp;
    }

    static T Foo<T>()
    {
        return default(T);
    }
}