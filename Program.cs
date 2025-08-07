// See https://aka.ms/new-console-template for more information
using MyFirstConsoleIBMProject;

Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to C#.NET Programming Fundamentals.");

//Variable Declaraction
/*ehh
 ehe*/

//VariableDeclarationDemo();
//PersonDetails();

//string result = CalculationDemo();
//Console.WriteLine($"Calculation result: {result}");
static string CalculationDemo()
{
    Calculator calculator = new Calculator();
    Console.WriteLine("Enter first number:");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Choose an operation: +, -, *, /");
    string operation = Console.ReadLine();
    int result = 0;
    switch (operation)
    {
        case "+":
            result = calculator.Add(firstNumber, secondNumber);
            Console.WriteLine($"The result of {firstNumber} + {secondNumber} is: {result}");
            break;
        case "-":
            result = calculator.Subtract(firstNumber, secondNumber);
            Console.WriteLine($"The result of {firstNumber} - {secondNumber} is: {result}");
            break;
        case "*":
            result = calculator.Multiply(firstNumber, secondNumber);
            Console.WriteLine($"The result of {firstNumber} * {secondNumber} is: {result}");
            break;
        case "/":
            try
            {
                result = (int)calculator.Divide(firstNumber, secondNumber);
                Console.WriteLine($"The result of {firstNumber} / {secondNumber} is: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return "0"; // Exit if division by zero
            }
            break;
        default:
            Console.WriteLine("Invalid operation selected.");
            return "0"; // Exit if invalid operation
    }
    string endResult = $"The result of {firstNumber} {operation} {secondNumber} is: {result}";
    return endResult;
}


//int number1 = Convert.ToInt32(Console.ReadLine);

static void VariableDeclarationDemo()
{
    int number = 10;
    string greeting = "Hello, C#";

    Console.WriteLine($"Number: {number} and {greeting}");
    //previous type of variable incorporation

    Console.WriteLine("Number: {0} and {1}", number, greeting);
}

static void PersonDetails()
{
    Console.WriteLine("Please enter your name");
    string name = Console.ReadLine();

    Console.WriteLine("Please enter your city");
    string city = Console.ReadLine();
    ///Console.WriteLine($"Hello, {name} from {city}!");

    Console.WriteLine("Please enter your age:");
    //int age = Console.ReadLine() !=null ? int.Parse(Console.ReadLine()) : 0;
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Hello, {name} from {city}! You are {age} years old.");  
}

//LoopDemo();
static void LoopDemo()
{
    loops loop = new loops();
    loop.ForLoop();
    loop.WhileLoop();
    loop.DoWhileLoop();
}

StudentAvgMark();
static void StudentAvgMark()
{
    StudentMark student = new StudentMark();
    student.InputDetails();
    student.PrintResult();
}