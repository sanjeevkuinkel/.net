internal class Program
{
    private static void Main()
    {

        //string concatenation using +operator
        string firstName = "John ";
        string lastName = "Doe";
        string fullName = firstName + lastName;
        Console.WriteLine(fullName); // Output: John Doe

        Console.WriteLine("Enter Your full Name");
        string name= Console.ReadLine();
        Console.WriteLine("Enter Your Address");
        string location= Console.ReadLine();
        Console.WriteLine("Enter Your Age");
        string age= Console.ReadLine();
        Console.WriteLine("Enter Your Profession");
        string profession = Console.ReadLine();
        Console.WriteLine("Enter your working position");
        string position= Console.ReadLine();
        Console.WriteLine("Enter your working field");
        string field= Console.ReadLine();

        Console.WriteLine("Hello! My name is " + name+" I am from " +location);
        //Composite Formatting Using Placeholders
        Console.WriteLine("and I am {0} years old.I am a passionate {1} currently working as an {2}.",age,profession,position);
        //String Interpolation
        Console.WriteLine($"I want to improve my coding skill in {field} while working as {position}");

        var number = 12;
        //var keyword is not dynamic but its type is assigned during compile time
        
        

    }
}