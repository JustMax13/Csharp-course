class Program
{
    static int[] GetArray()
    {
        int[] array = null;
        return array;
    }
    static void Main()
    {
        int[] myarray = GetArray();

        Console.WriteLine("Сумма элементов массивов: " + (myarray?.Sum() ?? 0));
    }
}