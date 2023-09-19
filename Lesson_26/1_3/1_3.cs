int size;

Console.WriteLine("Введите длину массива: ");
bool ifnum = int.TryParse(Console.ReadLine(), out size);

for (; ifnum == false;)
{
    Console.WriteLine("Введите длину массива числом!: ");
    ifnum = int.TryParse(Console.ReadLine(), out size);
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

Console.WriteLine("\n");
for (int i = 0; i < size; i++)
{
    if (array[i] % 2 != 0)
    {
        array[i] = 0;
    }
}
array = array.Except(new double[] { 0 }).ToArray();

double sum = 0;
for (int i = 0 ; i < array.Length; i++)
{
    sum = sum + array[(int)i];
}

Console.WriteLine("Сумма четных чисел массива: " + sum);