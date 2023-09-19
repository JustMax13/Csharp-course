
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

Console.WriteLine("Вы успешно записали числа в массив!\n");

Console.WriteLine("Массив выведенный в обратном порядке:\n");

//for (int i = 0; i < size; i++)
//{
//    Console.WriteLine(array[(size-1) - i]);
//}
// или этот чикл будет равняться седующиму:

foreach (int i in array.Reverse())
    Console.Write(i + " ");
