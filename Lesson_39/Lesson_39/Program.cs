﻿class Proram
{
    static void Foo()
    {
        int[] a = new int[10];
        
    }
    static void Main()
    {
        Foo();
    }
    // после такого удалиться только ссылка на данные в массиве,
    // а сами данные в массиве остануться в управляемой куче.
    // Так же работают все ссылочные типы
    
}