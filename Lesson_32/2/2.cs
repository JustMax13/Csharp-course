int[,] myarray = new int[2, 3];

for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        Console.WriteLine($"Введите число {j+1}го столбца и {i+1}го ряда: ");
        myarray[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("\n");

for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        Console.Write(myarray[i, j] + "\t");
    }
    Console.WriteLine();
}