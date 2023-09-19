bool acceptPassword;
string password = "1234";
string enteredPassword = Console.ReadLine();
/*
if ( password == enteredPassword)
{
    acceptPassword = true;
}
else
{
    acceptPassword =    false;
}
*/
acceptPassword = password == enteredPassword ? true : false;
Console.WriteLine(acceptPassword);