class Lesson48
{
    static void Main()
    {
        int first = 2;
        int second = 5;
        Console.WriteLine(Exhaust(b: second, a: first));
        // b: 5 - показывает что в параметр b мы передаем значение 5
        // а: 2 - показывает что в параметр а мы передаем значение 
        // не зависимо от порядка передачи параметров
    }
    static int Exhaust(int a, int b)
    {
        return a - b;
    }
}