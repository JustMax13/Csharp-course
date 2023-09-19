class Gun
{
    private bool isLoaded;
    private void Reload()
    {
        Console.WriteLine("Перезарядка...");

        isLoaded = true;

        Console.WriteLine("Заряжен!");
    }

    public void Shoot()
    {
        if (!isLoaded)
        {
            Console.WriteLine("Оружие не зажярено!"); 
            Reload();
        }
        Console.WriteLine("Выстрел!");
        isLoaded = false;
    }
}
class Program
{
    static void Main()
    {
        Gun BigGun = new Gun();
        BigGun.Shoot();
    }
}
