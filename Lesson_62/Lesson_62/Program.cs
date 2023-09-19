class HP
{
    private float Armor;

    public void SetX(float x)
    {
        if (x < 0)
        {
            Armor = 0;
            return;
        }
        if (x > 200)
        {
            Armor = 200;
            return;
        }
        Armor = x;
    }
    public float GetX() => Armor;

    // Но так в С# не прописывают эти методы, для них есть спецыальные свойства ( Properties )
    // ---------------
    private float _HP;
    public float forHP
    {
        get => _HP;
        set 
        {          
            if (value < 0)
            {
                _HP = 0;
                return;
            }
            if (value > 100)
            {
                _HP = 100;
                return;
            }
            _HP = value;
        }
    }
    // ---------------
    public float Attack { get; set; } // Автоматический снипит ( prop )
}

class Program
{
    static void Main()
    {
        HP point = new HP();

        point.SetX(1000);
        float armor = point.GetX();

        //----------------------------------
        
        point.forHP = 300;
        float hp = point.forHP;

        //----------------------------------

        point.Attack = 30;
        float attack = point.Attack;
    }
}