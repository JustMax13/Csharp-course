class PointOn3D
{
    public PointOn3D()
    {

    }
    public PointOn3D(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
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
}

class Program
{
    static void Main()
    {
        PointOn3D point_1 = new PointOn3D(2,4,0);
        PointOn3D point_2 = new PointOn3D(point_1);

        point_2.ChangeX(0);

        point_1.PrintPoint();
        point_2.PrintPoint();
    }
}