namespace Person
{
    class Employee : Person
    {
        public decimal Salary { get; set; }
        private static string whoIsIt;
        public static void WhoIsIt()
        {
            Console.WriteLine(whoIsIt);
        }
        //private string WhoIsIt;
        //public string whoIsIt
        //{
        //    get { return WhoIsIt; }
        //    private set { WhoIsIt = value; }
        //}
        public static void PrintWhoIsIt()
        {
            Console.WriteLine();
        }
    }
}
