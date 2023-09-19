interface IInterface
{

}
public class ClassPoint : IInterface
{
    public int X { get; set; }
    public int Y { get; set; }
    public void PrintPoint()
    {
        Console.WriteLine($"X: {X}\nY: {Y}\n");
    }
}
struct StractPoint : IInterface // реализация интерфейсов в структурах - возможна.
{
    public int X { get; set; }
    public int Y { get; set; }
    public void PrintPoint()
    {
        Console.WriteLine($"X: {X}\nY: {Y}\n");
    }
}

class Program
{
    static void Foo(ClassPoint classPoint)
    {
        classPoint.X++;
        classPoint.Y++;
    }
    static void Bar(StractPoint stractPoint)
    {
        stractPoint.X++;
        stractPoint.Y++;
    }
    static void Bar(ref StractPoint stractPoint)
    {
        stractPoint.X++;
        stractPoint.Y++;
    }
    static void Main()
    {
        //ClassPoint classPoint = new ClassPoint();
        //StractPoint stractPoint = new StractPoint(); // но это не обозначает что мы выделяем оперативную память про 
        //// структуру а значит что мы можем обращаться к полям и свойствам в этой структуре, ибо туда были присвоены
        //// дефолтные значения под их использования
        //// -------------------------------------

        //Console.WriteLine(stractPoint.X); // к примеру выведем значение на консоль

        //int a = new int(); // По сути явно сказали, чтовызываем дефолтный конструктор / присваиваем дефолтное значение
        ////если бы у нас тут не было присвоенно значение, то мы бы не смогли вывести переменную
        //// хоть там и было б дефолтное значение
        //Console.WriteLine(a);


        //// ----------------------------------------------------


        //Foo(classPoint); // в этом случае свойства Х и Y будут увеличены на 1
        //Bar(stractPoint); // в этом случае свойства Х и Y останутся прежними, ибо в функцию мы скопировали эти данные
        //// в таком случае нам прийдется передать ссылку на обьект структуры:
        //StractPoint stractPoint1 = new StractPoint();
        //Bar(ref stractPoint1);

        ClassPoint classPoint1 = new ClassPoint { X = 2, Y = 3 };
        ClassPoint classPoint2 = new ClassPoint { X = 2, Y = 3 };

        bool classesAreEqual = classPoint1.Equals(classPoint2); // в переменной будет false, ибо проверяет ссылки, куда они ссылаются

        StractPoint stractPoint1 = new StractPoint { X = 2, Y = 3 };
        StractPoint stractPoint2 = new StractPoint { X = 2, Y = 3 };

        bool stractAreEqual = stractPoint1.Equals(stractPoint2); // в переменной будет true, ибо проверяет значение
    }
}
