namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance
            Chef chef = new Chef();
            chef.MakeChicken();
            NigerianChef nigerianChef = new NigerianChef();
            nigerianChef.MakeChicken();
            nigerianChef.MakeSpecialDish();
            // static methods and classes
            // Console.WriteLine(Math.Sqrt(144));
            // Classes and Objects
            // static
            // Song blindedByYourGrace = new Song("Stormzy", "Blinded By Your Grace", 3);
            // Song dumebi = new Song("Rema", "Dumebi", 3);
            // Console.WriteLine(blindedByYourGrace.getSongCount());
            // static attributes in classes
            // private
            // Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            // Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            // avengers.Rating = "R";
            // Console.WriteLine(avengers.Rating);
            // constructors and methods
            // Student student1 = new Student("Jim", "Economics", 3.8);
            // Student student2 = new Student("Maria", "Economics", 2.8);
            // Console.WriteLine(student2.HasHonours());
            // Book book1 = new Book("Harry Potter", "J.K Rowling", 400);
            // Book book2 = new Book("Lord of the Rings", "Tolkein", 700);
            // book2.title = "The Hobbit";
            // Console.WriteLine(book2.title);

            // Exception Handling
            // try
            // {
            //     Console.Write("Enter a number: ");
            //     int num1 = Convert.ToInt32(Console.ReadLine());

            //     Console.Write("Enter second number: ");
            //     int num2 = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine(num1 / num2);
            // }
            // catch (DivideByZeroException e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            // catch (FormatException e)
            // {
            //     Console.WriteLine(e.Message);
            // }

            // 2D Arrays
            // int[,] numberGrid = {
            //     {1, 2},
            //     {3, 4},
            //     {5, 6}
            // };
            // Console.WriteLine(numberGrid[1, 1]);

            // Building an exponent method
            // Console.WriteLine(GetPower(3, 2));

            // For Loops
            // int[] luckyNumbers = { 4, 2, 9, 6, 2 };
            // for (int i = 0; i < luckyNumbers.Length; i++)
            // {
            //     Console.WriteLine(luckyNumbers[i]);
            // }
            // Guessing Game
            // string secretWord = "giraffe";
            // string? guess = "";
            // int guessCount = 0;
            // int guessLimit = 3;
            // bool outOfGuesses = false;
            // while (guess != secretWord && !outOfGuesses)
            // {
            //     if (guessCount < guessLimit)
            //     {
            //         Console.Write("Enter Guess: ");
            //         guess = Console.ReadLine();
            //         guessCount += 1;
            //     }
            //     else
            //     {
            //         outOfGuesses = true;
            //     }
            // }
            // if (outOfGuesses)
            // {
            //     Console.Write("You Lose!");

            // }
            // else
            // {
            //     Console.Write("You Win!");

            // }

            // While Loops
            // int index = 6;
            // do
            // {
            //     Console.WriteLine(index);
            //     index += 1;
            // } while (index <= 5);
            // Switch Statements
            // Console.WriteLine(GetDay(50));

            // Better Calculator
            // Console.Write("Enter a number: ");
            // double num1 = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Operator + - / * : ");
            // string? op = Console.ReadLine();
            // Console.Write("Enter second number: ");
            // double num2 = Convert.ToDouble(Console.ReadLine());

            // if (op == "+")
            // {
            //     Console.WriteLine(num1 + num2);
            // }
            // else if (op == "-")
            // {
            //     Console.WriteLine(num1 - num2);
            // }
            // else if (op == "/")
            // {
            //     Console.WriteLine(num1 / num2);
            // }
            // else if (op == "*")
            // {
            //     Console.WriteLine(num1 * num2);
            // }
            // else
            // {
            //     Console.WriteLine("Invalid Operator");
            // }

            // if statements
            // Console.WriteLine(GetMax(15, 60, 19));
            // bool isMale = true;
            // bool isTall = false;
            // if (isMale && isTall)
            // {
            //     Console.WriteLine("You are a tall male");
            // }
            // else if (isMale && !isTall)
            // {
            //     Console.WriteLine("You are a short male");
            // }
            // else if (!isMale && isTall)
            // {
            //     Console.WriteLine("You are a not male but tall");
            // }
            // else
            // {
            //     Console.WriteLine("You are not male and not tall");
            // }

            // Methods
            // Console.WriteLine(Cube(5));
            // SayHi("Kay", 10);

            // Arrays
            // int[] luckyNumbers = { 4, 2, 9, 6, 2 };
            // string[] friends = new string[5];
            // friends[0] = "Tommy";
            // Console.WriteLine(luckyNumbers[2]);

            // Building a Mad Libs Game
            // string? color, pluralNoun, celebrity;
            // Console.Write("Enter a color: ");
            // color = Console.ReadLine();
            // Console.Write("Enter a plural noun: ");
            // pluralNoun = Console.ReadLine();
            // Console.Write("Enter a celebrity: ");
            // celebrity = Console.ReadLine();
            // Console.WriteLine("Roses are " + color);
            // Console.WriteLine(pluralNoun + " are blue");
            // Console.WriteLine("I love " + celebrity);

            // Basic Calculator
            // Console.Write("Enter a number: ");
            // double num1 = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Enter another number: ");
            // double num2 = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine(num1 + num2);

            // Getting user input
            // Console.Write("Enter your name: ");
            // string? name = Console.ReadLine();
            // Console.WriteLine("Hello " + name);

            // Math and String Methods
            // Data Types
            // string phrase = "Hello World!";
            // char grade = "A";
            // int age = "21";
            // double gpa = 3.3;
            // // float, double, decimal >>>
            // bool isMale = true;

            // Variables
            // string characterName = "Tom";
            // int characterAge;
            // characterAge = 25;
            // Console.WriteLine("There once was a man named " + characterName);
            // Console.WriteLine("He was " + characterAge + " years old");
            // characterName = "Jim";
            // Console.WriteLine("He really liked the name " + characterName);
            // Console.WriteLine("But he didn't like being " + characterAge);

            Console.ReadLine();
        }
        // static int GetPower(int baseNum, int powerNum)
        // {
        //     int result = 1;

        //     for (int i = 0; i < powerNum; i++)
        //     {
        //         result = Convert.ToInt32(result * baseNum);
        //     }

        //     return result;
        // }
        // static string GetDay(int dayNum)
        // {
        //     string dayName;
        //     switch (dayNum)
        //     {
        //         case 0:
        //             dayName = "Sunday";
        //             break;
        //         case 1:
        //             dayName = "Monday";
        //             break;
        //         case 2:
        //             dayName = "Tuesday";
        //             break;
        //         case 3:
        //             dayName = "Wednesday";
        //             break;
        //         case 4:
        //             dayName = "Thursday";
        //             break;
        //         case 5:
        //             dayName = "Friday";
        //             break;
        //         case 6:
        //             dayName = "Saturday";
        //             break;
        //         default:
        //             dayName = "Invalid Day Number";
        //             break;
        //     }

        //     return dayName;
        // }
        // static int GetMax(int num1, int num2, int num3)
        // {
        //     int result;
        //     if (num1 >= num2 && num1 >= num3)
        //     {
        //         result = num1;
        //     }
        //     else if (num2 >= num1 && num2 >= num3)
        //     {
        //         result = num2;
        //     }
        //     else
        //     {
        //         result = num3;
        //     }

        //     return result;
        // }
        // static int Cube(int num)
        // {
        //     int result = num * num * num;
        //     return result;
        // }
        // static void SayHi(string name, int age)
        // {
        //     Console.WriteLine("Hello " + name + ", You are " + age);
        // }
    }
}