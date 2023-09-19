class Cat
{
    public int Age { get; set; }
    public string Name { get; set;}
    public Cat()
    {

    }
    public Cat(string Name)
    {
        this.Name = Name;
    }
    public void PrintCat()
    {
        Console.WriteLine($"{Name} is  {Age}");
    }
}
class Program
{
    static void Main()
    {
        // --- 1й способ---
        Cat Cat1 = new Cat();
        Cat1.Name = "Masha";
        Cat1.Age = 1;
        // --- 2й способ---
        Cat Cat2 = new Cat { Age = 2, Name = "Barsik" };

        // --- 1й способ---
        Cat Cat3 = new Cat("Gala");
        Cat3.Age = 3;
        // --- 2й способ---
        Cat Cat4 = new Cat("Nija")
        {
            Age = 4,
        };
    }
}