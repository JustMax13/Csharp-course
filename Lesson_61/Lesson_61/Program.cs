class PointOn3D
{
    public PointOn3D()
    {

    }
    public PointOn3D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
    public PointOn3D(float x, float y, float z) : this(x,y) // По сути мы ключевым словом this  вызываем конструктор класса с 2мя параметрами
    {
        this.z = z;
    }
    public PointOn3D(PointOn3D point)
    {
        this.x = point.x;
        this.y = point.y;
        this.z = point.z;
    }
    private float x, y, z;
    public void PrintPoint()
    {
        Console.WriteLine($"X: {x};\nY: {y};\nZ: {z}.\n");
    }
    public void ChangeX(float x)
    {
        this.x = x;
    }
    public void ChangeY(float y)
    {
        this.y = y;
    }
    public void ChangeZ(float z)
    {
        this.z = z;
    }
}

class Program
{
    static void Main()
    {
        PointOn3D point_1 = new PointOn3D(0,0,8);
        PointOn3D point_2 = new PointOn3D(point_1);

        point_2.ChangeX(3);
        point_1.ChangeY(1);

        point_1.PrintPoint();
        point_2.PrintPoint();
    }
}