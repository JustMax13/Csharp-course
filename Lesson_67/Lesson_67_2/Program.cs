using Stud;
class Program
{
    static void Main()
    {
        Student student = new Student() { FirstName = "Max", SecondName = "Khris" }; // в фигурных скобках сразу задаем поля екземпляра класса

        student.PrintInfoAboutStudent();
    }
}