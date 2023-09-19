class Program
{
    static void Main()
    {
        //int a = 11;
        //// это будет равно:
        //System.Int32 b = 11;
        //Random rand = new Random();
        int a = 9;
        integ(a);
        Console.WriteLine(a);

        int[] myaaray = new int[10];
        myaaray[0] = 8;
        array(myaaray);
        Console.WriteLine(myaaray[0]);

        int[] myaaray2 = new int[10];
        myaaray2 = myaaray;
        myaaray2[0] = 3;
        Console.WriteLine(myaaray[0]);
        Console.WriteLine(myaaray2[0]);
    }
    static void integ(int value1)
    {
        value1 = 6;
    }
    static void array(int[] myarray)
    {
        myarray[0] = 2;
    }
}