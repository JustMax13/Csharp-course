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
        myarray ??=  new int[0];
        Console.WriteLine("Количество елементов в массиве: " + myarray.Length);
    }
}