using MyClass;
// покажем в чем приймущество 2го способа над первым:
class Person
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public Address address { get; set; }
}
class Program
{
    static void Main()
    {
        // ---1й способ---
        Person person = new Person();
        person.FirstName = "Max";
        person.SecondName = "Khris";

        Address address = new Address();
        address.Country = "Ukraine";
        address.City = "Kiev";

        person.address = address;
        // ---2й способ---
        Person person2 = new Person
        {
            FirstName = "Max",
            SecondName = "Khris",
            address = new Address()
            {
                City = "Kiev",
                Country = "Ukraine",
            }
        };
    }
}