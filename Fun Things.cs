/*
    <<--------->>
    This is a collection of tools that I have made in C#, a lot are ideas from edabit.com
    The code is probably not the best, but if it ain't broke...
    <<--------->>
*/

public static void Main(string[] args)
{
    Console.Title = "Gizmos";
    bool menu = true;
    Console.WriteLine($"\t\t\tHello!");

    while (menu)
    {
        Console.WriteLine("**----------------------------------------------------**"); // Little menu thing to let users know what they can do
        Console.WriteLine("1 - Calculate the area of a triangle\t4 - Fizz Buzz");
        Console.WriteLine("2 - How many days old\t\t\t5 - Scream");
        Console.WriteLine("3 - Seconds in Minutes\t\t\t6 - Number Guessing Game");
        Console.WriteLine("7 - Calculator\t\t 8 - Inches to Centimetres");
        Console.WriteLine("9 - Divisible by 5");

        Console.WriteLine();



        Console.WriteLine("Enter a number above or type \"Bye\" to exit.");
        Console.WriteLine();
        Console.WriteLine("ps, this doesnt have exception handling, so play by the rules please!"); // Too lazy to add it
        string toolInput = Console.ReadLine(); 
        Console.WriteLine();

        switch (toolInput) // lets the user enter a number to enter a tool, or type "Bye" to exit
        {
            case null: Console.WriteLine("Enter a number above or type \"Bye\" to exit."); break;
            case "1": AreaOfTriangle(); break;
            case "2": DaysOld(); break;
            case "3": MinutesToSeconds(); break;
            case "4": FizzBuzz(); break;
            case "5": Scream(); break;
            case "6": guessingGame(); break;
            case "7": Calculator(); break;
            case "8": inchesToCentimetres(); break;
            case "9": DivisibleBy5(); break;
            case "Bye": Console.WriteLine("Ok, bye!"); menu = false; break;
        }
    }
}

static void AreaOfTriangle() // Self explanatory 
{
    Console.Write("What's the base of the triangle? - "); 
    double BOT = Convert.ToDouble(Console.ReadLine());
    Console.Write("What's the height? - ");
    double HOT = Convert.ToDouble(Console.ReadLine());
    double AOT = (BOT * HOT) / 2;
    Console.WriteLine($"The area of the triangle is {AOT}");
    Console.WriteLine();
}

static void DaysOld() // I like this one
{
    Console.Write("What is your age? - ");
    int age = Convert.ToInt32(Console.ReadLine());
    int days = age * 365;
    Console.WriteLine($"You are around {days} days old");
    Console.WriteLine();
}

static void MinutesToSeconds() // I like this one too
{
    Console.Write("How many minutes do you want to convert into seconds? - ");
    int minutes = Convert.ToInt32(Console.ReadLine());
    int seconds = minutes * 60;
    Console.WriteLine($"{minutes} minutes is {seconds} seconds.");
    Console.WriteLine();
}

static void Calculator() // My favourite! I love making calculators 
{
    Console.Write("Number 1 - ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Number 2 - ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"What do you want to do?");
    Console.WriteLine("+ Addition\n- Subraction\nx Multiplication\n/ Division");
    string func = Console.ReadLine();

    switch (func)
    {
        case null: Console.WriteLine("Enter a function above"); break;
        case "+": Console.WriteLine($"{x} {func} {y} = {x + y}"); Console.WriteLine(); break;
        case "-": Console.WriteLine($"{x} {func} {y} = {x - y}"); Console.WriteLine(); break;
        case "X":
        case "x": Console.WriteLine($"{x} {func} {y} = {x * y}"); Console.WriteLine(); break;
        case "/": Console.WriteLine($"{x} {func} {y} = {x / y}"); Console.WriteLine(); break;
    }
}

static void inchesToCentimetres() // Just use metric system
{
    Console.Write("Type the amount of inches - ");
    double inches = Convert.ToDouble(Console.ReadLine());
    double cm = inches * 2.54;
    Console.WriteLine($"{inches} inches is {cm} centimetres");
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
                Console.WriteLine("Guess is too high");
            }
            else if (guess < number)
            {
                Console.WriteLine("Guess is too low");
            }
            guesses++;
        }
        Console.WriteLine($"Number - {number}");
        Console.WriteLine("You win!");
        Console.WriteLine($"It took {guesses} guesses to get it");

        Console.WriteLine("Play again? y/n ");
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
    Console.WriteLine("Enter a number, and I'll tell you if it's evenly divisible by 5 - ");
    int input = Convert.ToInt32(Console.ReadLine());

    if (input % 5 == 0)
        Console.WriteLine($"Yes, {input} is evenly divisible by 5");
    else
        Console.WriteLine($"No, {input} is not evenly divisible by 5");
}

static void scream() // This ones funny
{
    Console.Write("Type anything, and I'll scream it back at you very loudly - ");
    string input = Console.ReadLine();

    Console.WriteLine($"{input.ToUpper()}!!!");
}

static void fizzBuzz() // Annoying, I hate fizz buzz things.
{
  Console.Write("Type a number, and I'll output FizzBuzz up to that number - ");
  int input = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= input; i++)
  {
    if (i % 3 == 0 && i % 5 == 0)
    {
      Console.WriteLine("Fizz Buzz!");
    }
    else if (i % 3 == 0)
    {
      Console.WriteLine("Fizz!");
    }
    else if (i % 5 == 0)
    {
      Console.WriteLine("Buzz!");
    }
    else
    {
      Console.WriteLine(i);
    }
  }
}