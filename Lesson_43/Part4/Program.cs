// Ссылочные локальные переменные
class Program
{
    static void Main()
    {
        int[] myArray = { 3, 8, -5 };

        //int b = myArray[0]; - так у нас массив не как не связан с переменной
        ref int b = ref myArray[0]; // так у наас переменная это ссылка на елемент массива

        b = -3;
    }
}