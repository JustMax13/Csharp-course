namespace Lesson_84
{
    class Program
    {
        public static void Main()
        {
            int a = 4;
            int b = 12;

            Console.WriteLine($"a = {a}, b = {b}");

            MySwap.GenericSwap(ref a,ref b);

            Console.WriteLine($"a = {a}, b = {b}");

            double v1 = 2.54;
            double v2 = 5.24;

            Console.WriteLine($"v1 = {v1}, v2 = {v2}");

            MySwap.ObjectSwap(ref v1, ref v2);
        }
    }
}

