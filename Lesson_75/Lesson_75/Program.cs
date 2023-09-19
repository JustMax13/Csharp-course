/*
  Полиморфизм / виртуальные методы / virtual | override
 */
class Car
{
    protected void StartEngine()
    {
        Console.WriteLine("Заводим двигатель!");
    }
    public virtual void Stop()
    {
        Console.WriteLine("Останавливаемся");
    }

    public virtual void Drive() // virtual - обозначает что этот метод может быть переопределен
    {
        StartEngine();
        Console.WriteLine("Едим!");
    }
}
class SportCar : Car
{
    public override void Drive() // override - обозначает что метод Drive из базового класса будет тут переопределен
    {
        // тут мы пишем всю логику класса по новой ( точнее переделываем наш метод )
        StartEngine();
        Console.WriteLine("Очень быстро едим!");
    }
    public override void Stop()
    {
        Console.WriteLine("Быстро станавливаемся");
    }
}
class Person
{
    public void Drive(Car car)
    {
        car.Drive();
    }
    public void Stop(Car car)
    {
        car.Stop();
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();
         
        person.Drive(new SportCar());
        person.Stop(new SportCar());

        Console.WriteLine("\n-------------------------\n");

        person.Drive(new Car());
        person.Stop(new Car());
    }
}