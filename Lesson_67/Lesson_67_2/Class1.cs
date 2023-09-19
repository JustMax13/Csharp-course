namespace Stud
{
    static class StudentInfo
    {
        public static void PrintInfoAboutStudent(this Student student)
        {
            Console.WriteLine(student.FirstName + " " + student.SecondName);
        }
    }
}