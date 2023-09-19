#define Try

class Program
{
    static private void Main()
    {
#if DEBUG // проверяет есть ли встроенная деректива DEBUG. При компиляции в релизе ее нет.
        Console.WriteLine("Начало цыкла");
#endif
        for (int i = 0; i < 5; i++)
            Console.WriteLine(i);
#if DEBUG
        Console.WriteLine("Конец цыкла");
#endif
        // если нужно использовать свою дерективу
#if DEBUG
        Console.WriteLine("гыгы");
#elif Try
        Console.WriteLine("Есть деректива Try"); // можно проверить работу, если перейти в релизную версию
#endif
    }
}