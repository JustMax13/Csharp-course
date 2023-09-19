using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_67_ExtentionMetod
{
    // Напишем Extention ( разширяющий ) метод для структуры DateTime
    // Хотим сделать чтобы данные из переменной типа DateTime можно было сразу выводить. к примеру опишем
    // метод Print()
    static class MyExtentions
    {
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }
        public static void Print(this DateTime dateTime, int example )
        {
            Console.WriteLine(dateTime + "\nПросто 2й аргуент для примера, что можно так делать и + перегружать метод: ");
        }
    }
}
