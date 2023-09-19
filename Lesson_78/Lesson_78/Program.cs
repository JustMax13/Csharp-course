
interface IThrowingWeapon : IWeapon
{
    void Throw();
}

interface IGetInfo
{
    void ShowInfo();
}
interface IWeapon : IGetInfo
{
    int Damage { get; }
    void Fire();

}

abstract class Weapon : IWeapon
{
    public abstract int Damage { get; }
    public virtual void Fire()
    {
        Console.WriteLine($"Было снято {Damage}HP");
    }
    public abstract float ReloadInSecond { get; }
    public abstract void Reload();
    public void ShowInfo()
    {
        Console.Write(GetType().Name + "\n");
        Reload();
    }
}
class Bow : Weapon
{
    public override int Damage { get { return 40; } } // = public override int Damage => 40

    public override float ReloadInSecond { get { return 3.5f; } }

    public override void Fire()
    {
        Console.WriteLine("Пдщщ");

        base.Fire();
    }

    public override void Reload()
    {

        Console.WriteLine($"Перезарядка длилась {ReloadInSecond} секунд");
    }
}
class AK47 : Weapon
{
    public override int Damage { get { return 180; } }

    public override float ReloadInSecond { get { return 2.5f; } }

    public override void Reload()
    {
        Console.WriteLine($"Перезарядка длилась {ReloadInSecond} секунд");
    }
    public override void Fire()
    {
        Console.WriteLine("Тф-тф-тф-тф-тф-тф");
        base.Fire();
    }
}
// далее в классе Knife ты хотим еще реализовать возможность бросать нож, но при этом
// не хотим ломать логику нашего игрока
class Knife : IThrowingWeapon
{
    public int Damage { get { return 200; } }

    public void Fire()
    {
        Console.WriteLine("Фуф-фуф");
        Console.WriteLine($"Было снято {Damage}HP");
    }

    public void ShowInfo()
    {
        Console.Write(GetType().Name + "\n");
    }

    public void Throw()
    {
        Console.WriteLine("Фьюффф");
    }
}

class Player
{
    public void Fire(IWeapon weapon)
    {
        weapon.Fire();
    }
    public void CheckInfo(IGetInfo item)
    {
        item.ShowInfo();
    }
    public void Throw(IThrowingWeapon throwingWeapon)
    {
        throwingWeapon.Throw();
    }
}

class Program
{
    static void Main()
    {
        Player player = new Player();

        IWeapon[] inventory = { new Bow(), new AK47(), new Knife() };
        foreach (var weapon in inventory)
        {
            player.Fire(weapon);

            Console.Write("Удар был нанесен оружием: ");
            player.CheckInfo(weapon);

            Console.WriteLine("------------------------");
        }
        Console.WriteLine("---------------------------------");
        player.Throw(new Knife());
    }
}
