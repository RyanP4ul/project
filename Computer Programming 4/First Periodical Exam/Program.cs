namespace TestConsole;

public class Program {

    public static void Main(String[] args)
    {
        FirstPeriodicalExam();
    }
    
    public static void FirstPeriodicalExam()
    {
        Horizontal();
        Console.WriteLine("First Periodical Exam");
        Console.WriteLine("Please choose a number(1-3)");
        Console.WriteLine("1. A simple number calculator");
        Console.WriteLine("2. A program that draws a pyramid");
        Console.WriteLine("3. A program that displays basic information about a person using classes and objects");

        do
        {
            Console.Write("Enter a number: ");
            var choose = Console.ReadLine();

            if (!Int32.TryParse(choose, out int _))
            {
                Console.WriteLine("Input is not integer format!");
            }
            else if (Convert.ToInt32(choose) < 1 || Convert.ToInt32(choose) > 3)
            {
                Console.WriteLine("Out of range!");
            }
            else
            {
                switch (Convert.ToInt32(choose))
                {
                    case 1:
                        SimpleNumberCalculator();
                        break;
                    case 2:
                        DrawPyramid();
                        break;
                    case 3:
                        BasicInformation();
                        break;
                }
                
                break;
            }
        } while (true);
    }

    private static void Horizontal()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("******************************");
        Console.ResetColor();
    }
    
    private static void SimpleNumberCalculator()
    {
        Horizontal();
        Console.WriteLine("A simple number calculator");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        do
        {
            Console.Write("Enter a number: ");
            var n = Console.ReadLine();

            if (!Int32.TryParse(n, out int _))
            {
                Console.WriteLine("Input is not integer format!");
            }
            else if (Convert.ToInt32(n) < 1 || Convert.ToInt32(n) > 4)
            {
                Console.WriteLine("Out of range!");
            }
            else
            {
                string? firstNumber;
                string? secondNumber;

                do
                {
                    Console.Write("First Number: ");
                    firstNumber = Console.ReadLine();
                } while (!Int32.TryParse(firstNumber, out int _));

                do
                {
                    Console.Write("Second Number: ");
                    secondNumber = Console.ReadLine();
                } while (!Int32.TryParse(secondNumber, out int _));

                var result = Convert.ToInt32(n) switch
                {
                    1 => (Convert.ToInt32(firstNumber) + Convert.ToInt32(secondNumber)).ToString(),
                    2 => (Convert.ToInt32(firstNumber) - Convert.ToInt32(secondNumber)).ToString(),
                    3 => (Convert.ToInt32(firstNumber) * Convert.ToInt32(secondNumber)).ToString(),
                    4 => (Convert.ToInt32(firstNumber) / Convert.ToInt32(secondNumber)).ToString(),
                    _ => ""
                };

                Console.WriteLine(result);
                
                break;
            }
        } while (true);
    }

    private static void DrawPyramid()
    {
        Horizontal();
        Console.WriteLine("A program that draws a pyramid");

        do
        {
            Console.Write("Enter a number: ");
            var n = Console.ReadLine();
            
            if (!Int32.TryParse(n, out int _))
            {
                Console.WriteLine("Input is not integer format!");
            }
            else
            {
                for (int i = 1; i <= Convert.ToInt32(n); i++)
                {
                    for (int j = i; j <= Convert.ToInt32(n); j++)
                    {
                        Console.Write("  ");
                    }
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*" + " ");
                    }
                    Console.WriteLine();
                }

                break;
            }
        } while (true);
    }

    private static void BasicInformation()
    {
        Horizontal();
        Console.WriteLine("A program that displays basic information about a person using classes and objects");

        var person = new Person
        {
            FirstName = "Ryan Paul",
            MiddleName = "Losanez",
            LastName = "Espinola",
            Age = 17
        };

        Console.WriteLine(person.FirstName);
        Console.WriteLine(person.MiddleName);
        Console.WriteLine(person.LastName);
        Console.WriteLine(person.Age);
    }
    
}

class Person
{
    private string first_name;
    private string middle_name;
    private string last_name;
    private int age;

    public string FirstName
    {
        get { return first_name; }
        set { first_name = value; }
    }
    
    public string MiddleName
    {
        get { return middle_name; }
        set { middle_name = value; }
    }
    
    public string LastName
    {
        get { return last_name; }
        set { last_name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}