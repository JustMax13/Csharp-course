namespace Lesson_71
{ // --- Наследованиe ---
    class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public void PrintName()
        {
            Console.WriteLine($"Меня зовут {FirstName}");
        }
    }
    // К примеру нам нужен класс с схожим функционалом, к примеру класс Student
    class Student : Person
    {
        public void Learn()
        {
            Console.WriteLine("Студент учится...");
        }
    }

    class Program
    {
        static void Main()
        {
            Person person_1 = new Person()
            {
                FirstName = "Max",
                SecondName = "Khryis",
            };
            person_1.PrintName();

            Student student = new Student()
            {
                FirstName = "Igor (Student)",
            };
            student.PrintName();
            student.Learn();
        }
    }
}