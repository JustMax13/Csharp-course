namespace Person
{
    class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public void PrintFullName()
        {
            Console.WriteLine($"Name: {FirstName}, SecondName: {SecondName}");
        }
    }
}