int[,] myarray = new int[10,6];

Random rand = new Random();

for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        myarray[i, j] = rand.Next(5,11);
    }
}

for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        Console.Write(myarray[i, j] + "\t");
    }
    Console.WriteLine();
}