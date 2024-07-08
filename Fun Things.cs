/*
    <<--------->>
    This is a collection of tools that I have made in C#, a lot are ideas from edabit.com
    The code is probably not the best, but if it ain't broke...
    <<--------->>
*/

public static void print(var msg) => Console.WriteLine(msg); // Console.WriteLine is way to long.
public static void printSL(var msg) => Console.Write(msg); // SL stands for "same line"

// ^ These are gonna be horrible for maintainabilty, I dunno why I did this.

public static void Main(string[] args)
{
    Console.Title = "Gizmos";
    bool menu = true;
    print($"\t\t\tHello!");

    while (menu)
    {
        print("**----------------------------------------------------**"); // Little menu thing to let users know what they can do
        print("1 - Calculate the area of a triangle\t4 - Fizz Buzz");
        print("2 - How many days old\t\t\t5 - Scream");
        print("3 - Seconds in Minutes\t\t\t6 - Number Guessing Game");
        print("7 - Calculator\t\t 8 - Inches to Centimetres");
        print("9 - Divisible by 5");

        print();



        print("Enter a number above or type \"Bye\" to exit.");
        print();
        print("ps, this doesnt have exception handling, so play by the rules please!"); // Too lazy to add it
        string toolInput = Console.ReadLine(); 
        print();

        switch (toolInput) // lets the user enter a number to enter a tool, or type "Bye" to exit
        {
            case null: print("Enter a number above or type \"Bye\" to exit."); break;
            case "1": AreaOfTriangle(); break;
            case "2": DaysOld(); break;
            case "3": MinutesToSeconds(); break;
            case "4": FizzBuzz(); break;
            case "5": Scream(); break;
            case "6": guessingGame(); break;
            case "7": Calculator(); break;
            case "8": inchesToCentimetres(); break;
            case "9": DivisibleBy5(); break;
            case "Bye": print("Ok, bye!"); menu = false; break;
        }
    }
}

static void AreaOfTriangle() // Self explanatory 
{
    printSL("What's the base of the triangle? - "); 
    double BOT = Convert.ToDouble(Console.ReadLine()); // Makes BOT, standing for Base of Triangle, HOT, Height of Triangle, and AOT, Area of Triangle. A double is basically a decimal, like 7.34 or something
    printSL("What's the height? - ");
    double HOT = Convert.ToDouble(Console.ReadLine());
    double AOT = (BOT * HOT) / 2;
    print($"The area of the triangle is {AOT}");
    print();
}

static void DaysOld() // I like this one
{
    printSL("What is your age? - ");
    int age = Convert.ToInt32(Console.ReadLine()); // Makes a variable called age, and makes it an int, basically just a normal number like 7 or -13. Has it read input with "Console.ReadLine();" and converts it to a 32 bit integer, aka Int32
    int days = age * 365; // Multiples the input by 365.
    print($"You are around {days} days old");
    print();
}

static void MinutesToSeconds() // I like this one too
{
    printSL("How many minutes do you want to convert into seconds? - ");
    int minutes = Convert.ToInt32(Console.ReadLine());
    int seconds = minutes * 60;
    print($"{minutes} minutes is {seconds} seconds.");
    print();
}

static void Calculator() // My favourite! I love making calculators 
{
    printSL("Number 1 - ");
    int x = Convert.ToInt32(Console.ReadLine());
    printSL("Number 2 - ");
    int y = Convert.ToInt32(Console.ReadLine());
    print($"What do you want to do?");
    print("+ Addition\n- Subraction\nx Multiplication\n/ Division");
    string func = Console.ReadLine();

    switch (func)
    {
        case null: print("Enter a function above"); break;
        case "+": print($"{x} {func} {y} = {x + y}"); print(); break;
        case "-": print($"{x} {func} {y} = {x - y}"); print(); break;
        case "X":
        case "x": print($"{x} {func} {y} = {x * y}"); print(); break;
        case "/": print($"{x} {func} {y} = {x / y}"); print(); break;
    }
}

static void inchesToCentimetres() // Just use metric system
{
    printSL("Type the amount of inches - ");
    double inches = Convert.ToDouble(Console.ReadLine()); // Using "Convert.ToDouble" to, well, convert input to a double.
    double cm = inches * 2.54;
    print($"{inches} inches is {cm} centimetres");
}

static void guessingGame() // Probably a few variables unused but it is what it is
{
    Random random = new Random();
    bool loop = true;
    int guess;
    int number;
    int guesses;
    string answer;

    while (loop)
    {
        guess = 0;
        guesses = 0;
        answer = "";
        number = random.Next(1, 1001);

        while (guess != number)
        {
            Console.Write("Guess a number between 1 and 1000 - ");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess > number)
            {
                print("Guess is too high");
            }
            else if (guess < number)
            {
                print("Guess is too low");
            }
            guesses++;
        }
        print($"Number - {number}");
        print("You win!");
        print($"It took {guesses} guesses to get it");

        print("Play again? y/n ");
        answer = Console.ReadLine();
        answer = answer.ToUpper();

        if (answer == "Y")
            loop = true;
        else if (answer == "N")
            Console.WriteLine("Goodbye!");
        loop = false;
    }
}

static void divisibleFive()
{
    print("Enter a number, and I'll tell you if it's evenly divisible by 5 - ");
    int input = Convert.ToInt32(Console.ReadLine());

    if (input % 5 == 0)
        print($"Yes, {input} is evenly divisible by 5");
    else
        print($"No, {input} is not evenly divisible by 5");
}

static void scream() // This ones funny
{
    printSL("Type anything, and I'll scream it back at you very loudly - ");
    string input = Console.ReadLine();

    print($"{input.ToUpper()}!!!");
}

static void fizzBuzz() // Annoying, I hate fizz buzz things.
{
  printSL("Type a number, and I'll output FizzBuzz up to that number - ");
  int input = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= input; i++)
  {
    if (i % 3 == 0 && i % 5 == 0)
    {
      print("Fizz Buzz!");
    }
    else if (i % 3 == 0)
    {
      print("Fizz!");
    }
    else if (i % 5 == 0)
    {
      print("Buzz!");
    }
    else
    {
      print(i);
    }
  }
}
