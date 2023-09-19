uint size;

Console.WriteLine("Введите длину массива: ");
bool ifnum = uint.TryParse(Console.ReadLine(), out size);

for (; ifnum == false;)
{
    Console.WriteLine("Введите длину массива числом!: ");
    ifnum = uint.TryParse(Console.ReadLine(), out size);
}

double[] array = new double[size];
for (int i = 0, score = 1; i < size; i++)
{

    Console.WriteLine($"Введите {score++}й елемент массива:");
    ifnum = double.TryParse(Console.ReadLine(), out array[i]);

    for (; ifnum == false;)
    {
        Console.WriteLine("Введите елемент массива числом!: ");
        ifnum = double.TryParse(Console.ReadLine(), out array[i]);
    }

}

double min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if(array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine("Минимальное значение массива: " + min);
