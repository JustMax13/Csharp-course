class Program
{
    static int Multiplication(int a, int b)
    {
        // можно либо так писать:
        int result = a * b;
        return result;

        // либо так, есть у нас простое действие:
        //return a * b;
    }

    static void Result(int result)
    {
        Console.WriteLine("Результат умножения: " + result);
    }

    static void Main()
    {
        int num1, num2;
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());

        int numresult = Multiplication(num1, num2); // можно либо сначало записать в переменную, а после эту переменную вывести
        Result(numresult);
        // Result(Multiplication(num1, num2)); это что бы в отдельную переменную не записывать
        //Console.WriteLine(Multiplication(num1, num2)); // либо сразу вывести результат метода
    }
}