/*
 полиморфизм

абстрактные классы

абстрактные методы

абстрактное свойство
 */

abstract class Weapon
{
    public abstract int Damage  { get; }
    public virtual void Fire()
    {
        Console.WriteLine($"Было снято {Damage}HP");
    }
    public void ShowInfo()
    {
        Console.Write(GetType().Name + "\n"); // GetType().Name - позволяет узнать имя типа данных
    }
}
class Gun : Weapon
{
    public override int Damage { get { return 40; } } // = public override int Damage => 40

    public override void Fire()
    {
        Console.WriteLine("Пыщ-пыщ");
        
        base.Fire();
    }
}
abstract class Knife : Weapon
{
    public override int Damage { get { return 150; } } // = public override int Damage => 150
    public override void Fire()
    {
        Console.WriteLine("Фиф-фуф");
        AnimationKnifeKill();

        base.Fire();
    }
    public abstract void AnimationKnifeKill();
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

class Player
{
    public void Fire(Weapon weapon)
    {
        weapon.Fire();
    } // спомощью этого метода наш игрок сможет стрелять из любого оружия
    public void CheckInfo(Weapon weapon)
    {
        weapon.ShowInfo();
    }
}

class Program
{
    static void Main()
    {
        Player player = new Player();
        
        //player.Fire(new Gun());
        //player.Fire(new M4Bayonet());
        //player.Fire(new Butterfly());

        // те 3 строчки кода равняються следующим 5:
        Weapon[] inventory = {new Gun(), new M4Bayonet(), new Butterfly()};
        foreach (var weapon in inventory)
        {
            player.Fire(weapon);
            
            Console.Write("Удар был нанесен оружием: ");
            player.CheckInfo(weapon);

            Console.WriteLine("------------------------");
        }

        
    }
}