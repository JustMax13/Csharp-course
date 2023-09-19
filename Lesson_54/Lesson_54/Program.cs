class Program
{
    enum DayofWeek : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    // enum - указываем что это у нас будет enum
    // DayofWeek - название нашего енама
    static void Main()
    {
        DayOfWeek Day = DayOfWeek.Monday; // Так в переменную Day мы присвоили Monday
        Console.WriteLine(Day);
    }
}
