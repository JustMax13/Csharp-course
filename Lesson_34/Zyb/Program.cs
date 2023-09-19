Random randomazer = new Random(); 

int[][][] myarray = new int[randomazer.Next(3,6)][][];

for (int i = 0; i < myarray.Length; i++)
{
    myarray[i] = new int[randomazer.Next(2, 6)][];
    for (int j = 0; j < myarray[i].Length; j++)
    {
        myarray[i][j] = new int[randomazer.Next(2,5)];
        for (int k = 0; k < myarray[i][j].Length; k++)
        {
            myarray[i][j][k] = randomazer.Next(1, 15);
        }
    }
}


for (int i = 0; i < myarray.Length; i++)
{
    Console.WriteLine($"==== Page № {i + 1} ====");
    for (int j = 0; j < myarray[i].Length; j++)
    {
       
        for (int k = 0; k < myarray[i][j].Length; k++)
        {
            Console.Write(myarray[i][j][k] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("============================");
}