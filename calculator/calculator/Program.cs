internal class Program
{
    private static void Main()
    {
        //calculator
        Console.WriteLine("calculator");
        int a, b, c;
        Console.WriteLine("enter a operation to perform");
        string operation = Console.ReadLine();

        Console.WriteLine("enter the first number (a): ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the second number (b): ");
        b = Convert.ToInt32(Console.ReadLine());
        if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "%")
        {
            if (operation == "+")
            {
                c = a + b;
                Console.WriteLine("a+b=" + c);
            }
            else if (operation == "-")
            {
                c = a - b;
                Console.WriteLine("a-b={0}", c);
            }
            else if (operation == "*")
            {
                c = a * b;
                Console.WriteLine("a*b={0}", c);
            }
            else if (operation == "/")
            {
                if (b != 0)
                {
                    c = a / b;
                    Console.WriteLine($"result: {a} / {b} = {c}");
                }
                else
                {
                    Console.WriteLine("error: division by zero is not allowed.");
                }
            }
            else if (operation == "%")
            {
                c = a % b;
                Console.WriteLine("a%b={0}", c);
            }

        }
        else
        {
            Console.WriteLine("error: invalid operation. please enter one of +, -, *, /,%.");
        }
        //logical operator
        
        Console.WriteLine((a < b) ? $"B is the greater Number: {b}" : $"A is the greater Number:{a}");


        //assignment operator
        int d = 5;
        Console.WriteLine(d);
        d = 6;
        Console.WriteLine(d);
        //ternary operator
        int number = 10;
        string result = (number % 2 == 0) ? "Even" : "Odd";
        Console.WriteLine($"The number {number} is {result}.");

        //bitwise operator
        int age = 65;
        bool pension = false;
        if (age >= 65 && pension == true)
        {
            Console.WriteLine("You are getting pension from government");
        }
        else
        {
            Console.WriteLine("you are not eligible");
        }


        bool hasPermission = false;

        // Using the OR operator to check conditions
        if (age < 18 || hasPermission)
        {
            Console.WriteLine("Access denied: You must be at least 18 years old or have permission.");
        }
        else
        {
            Console.WriteLine("Access granted: You are allowed to proceed.");

        }
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
        //accessing array element
        Console.WriteLine(numbers[0]);
        string[] month = new string[5];
        //adding element in empty array
        month[1] = "feburary";
        month[2] = "march";
        month[3] = "april";
        month[4] = "may";
        month[0] = "januaury";
        Console.WriteLine(month[0]);

        //dynamic initialization
        string[] cars = new string[]
        {
            "volvo","maruti","rolls royes"
        };
        Console.WriteLine(cars[0]);
        //modifying arrray elements
        cars[2] = "bmw";
        Console.WriteLine(cars[2]);
        //length of an array 
        Console.WriteLine(cars.Length);
        //cars[3] = "tesla";//index was out of the bound of the array.
        //Console.WriteLine(cars.Length);

        int[] price;
        //instantiation of array
        price = new int[]
        {
            1,2,3,4,5,
        };

        //implicitly typed array
        var num = new[] { 5, 6, 7 };
        Console.WriteLine(num[1]);

        //object Arrays
        object[] mixedArray = new object[3];
        mixedArray[1] = "Hello World";
        mixedArray[2] = 21;
        mixedArray[0] = true;
        Console.WriteLine($"{mixedArray[1]}, {mixedArray[2]},{mixedArray[0]}");

        object[] mixedArray2 = new object[]
        {
          "hello",
          
          23,
          false,

    };
        Console.WriteLine($"{mixedArray2[1]}, {mixedArray2[2]},{mixedArray2[0]}");

        //type casting
        double g= 3.14;
        int h=Convert.ToInt32( g );//create a copy and store in another variable without modifying main variable
        Console.WriteLine(h);
        Console.WriteLine(g);
        Console.WriteLine(h.GetType());
        Console.WriteLine(g.GetType());
        int l = 2;
        double db = Convert.ToDouble( l );
        Console.WriteLine(l);
        Console.WriteLine(db);
        Console.WriteLine(l.GetType());
        Console.WriteLine(db.GetType());
        int i = 123;
        string s=Convert.ToString( i );
        //if you Convert number to string you cannot use number further on but if you Convert string to number it is further used for mathmatics.
        Console.WriteLine(s);
        Console.WriteLine(i);
        Console.WriteLine(i.GetType());
        Console.WriteLine(s.GetType());
        string k = "$";
        char e=Convert.ToChar( k );
        Console.WriteLine(k);
        Console.WriteLine(e);
        Console.WriteLine(e.GetType());
        Console.WriteLine(k.GetType());
        string m = "true";
        bool z= Convert.ToBoolean( m );
        Console.WriteLine(m);
        Console.WriteLine(z);
        Console.WriteLine(m.GetType());
        Console.WriteLine(z.GetType()); 


    }
}