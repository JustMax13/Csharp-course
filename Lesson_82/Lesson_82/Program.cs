// boxing && unboxing
class Program
{
    static void Main()
    {
        int a = 5;
        object b = a; // поскольку int - struct, a object - class, то тут у нас происходит запаковка
        // тоесть мы помещаем значемый тип в ссылочный
        int c = (int)b; // тут происходит распаковка
        // так же если мы запаковали тип int, то и распаковывать мы можем только в int
        decimal d = (decimal)b; // выдаст ошибку InvalidCastException
    }
}