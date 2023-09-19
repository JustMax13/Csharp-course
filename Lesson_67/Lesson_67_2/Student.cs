sealed class Student
{
    // sealed - обозначает что мы не можем создать наследника класса

    // допустим это какой-то класс из библиотеки, а не мы его написали,
    // а нам нужен метод который выведет эти 2 значения на консоль
    public string FirstName { get; set; }
    public string SecondName { get; set; }
}