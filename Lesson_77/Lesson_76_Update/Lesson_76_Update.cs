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
    public abstract float ReloadInSecond{ get;}
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
        Console.WriteLine("Пдщщщщ");

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

abstract class Knife : IWeapon
{
    public int Damage { get { return 150; } } // = public override int Damage => 150
    public void Fire()
    {
        Console.WriteLine("Фиф-фуф");
        AnimationKnifeKill();
        Console.WriteLine($"Было снято {Damage}HP");
    }
    public abstract void AnimationKnifeKill();

    public void ShowInfo()
    {
        Console.Write(GetType().Name + "\n");
    }
}
class M4Bayonet : Knife
{
    public override void AnimationKnifeKill()
    {
        Console.WriteLine("Какая-то анимация " + GetType().Name);
    }
}
class Butterfly : Knife
{
    public override void AnimationKnifeKill()
    {
        Console.WriteLine("Какая-то анимация " + GetType().Name);
    }
}
abstract class Box : IGetInfo
{
    abstract public void ShowInfo();
}
class RedBox : Box
{
    public override void ShowInfo()
    {
        Console.WriteLine("Я красная коробка");
    }
}
class BlueBox : Box
{
    public override void ShowInfo()
    {
        Console.WriteLine("Я синяя коробка");
    }
}
class Player
{
    public void Fire(IWeapon weapon)
    {
        weapon.Fire();
    }
    public void CheckInfo(IGetInfo getInfo)
    {
        getInfo.ShowInfo();
    }
}

class Program
{
    static void Main()
    {
        Player player = new Player();

        IWeapon[] inventory = { new Bow(), new AK47(), new M4Bayonet(), new Butterfly() };
        foreach (var weapon in inventory)
        {
            player.Fire(weapon);

            Console.Write("Удар был нанесен оружием: ");
            player.CheckInfo(weapon);

            Console.WriteLine("------------------------");
        }
        Console.WriteLine("--------------------------------------------------\n");
        
        player.CheckInfo(new RedBox());
        player.CheckInfo(new BlueBox());

    }
}
