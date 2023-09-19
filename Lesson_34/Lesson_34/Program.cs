int [,,] myarray = new int [4,3,5];

Random rand = new Random();

for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        for (int k = 0; k < myarray.GetLength(2); k++)
        {
            myarray[i,j,k] = rand.Next(1,6); 
        }
    }
}

for (int i = 0; i < myarray.GetLength(0); i++)
{
    Console.WriteLine($"Страница номер {i+1}\n");
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        for (int k = 0; k < myarray.GetLength(2); k++)
        {
            Console.Write(myarray[i,j,k] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("==============================");
}