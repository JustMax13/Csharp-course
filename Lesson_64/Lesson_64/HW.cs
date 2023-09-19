// нужно внутри касса описать счетчик, который будет считать количество созданых екземпляров класса и доступ к этому значению нужно описать через свойство
class _MyClass
{
    public static int counter { get; private set; }
    public _MyClass()
    {
        counter++;
    }
}

class HW
{
    public static void test()
    {
        _MyClass first = new _MyClass();
        _MyClass second = new _MyClass();
        _MyClass third = new _MyClass();

        Console.WriteLine("Количество екземпляров класса: " + _MyClass.counter);
    }
}