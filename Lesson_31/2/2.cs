int[,] myarray =
{
    {0,0,7,7},
    {1,0,9,-5},
    {3,1,34,-76},
    {5,1,0,-5},
};

for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        Console.Write(myarray[i, j] + "\t");
    }
    Console.WriteLine();
}