class Program
{
    static void Main()
    {
        Console.WriteLine("Сумма целых чисел: " + Sum(5, 7, 2));
    }
    static int Sum(params int[] paramrters)
    {
        int result = 0;
        for (int i = 0; i < paramrters.Length; i++)
        {
            result += paramrters[i];
        }
        return result;
    }
}

