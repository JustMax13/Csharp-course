int[][] myarray = new int[5][]; 
myarray[0] = new int[4];
myarray[1] = new int[3];
myarray[2] = new int[6];
myarray[3] = new int[2];
myarray[4] = new int[9];

Random rand = new Random();

for (int i = 0; i < myarray.Length; i++)
{
    for (int j = 0; j < myarray[i].Length; j++)
    {
        myarray[i][j] = rand.Next(1, 101);

    }
}

for (int i = 0; i < myarray.Length; i++)
{
    for (int j = 0; j < myarray[i].Length; j++)
    {
        Console.Write(myarray[i][j] + "\t");
    }
    Console.WriteLine("\n");
}