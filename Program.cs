// See https://aka.ms/new-console-template for more information
using MyFirstConsoleIBMproject;
using MyFirstConsoleIBMProject;

//Console.WriteLine("Hello, World!");
//Console.WriteLine("Welcome to C#.NET Programming Fundamentals.");

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

//StudentAvgMark();
static void StudentAvgMark()
{
    StudentMark student = new StudentMark();
    student.InputDetails();
    student.PrintResult();
}

//TwoDimensionalArrayDemo();
static void TwoDimensionalArrayDemo()
{
    int[,] twoDimensionalArray = new int[3, 3]
    {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
    };

    for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
        {
            Console.Write(twoDimensionalArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//JaggedArrayDemo();

static void JaggedArrayDemo()
{
    int[][] jaggedArray = new int[3][];
    jaggedArray[0] = new int[] { 1, 2, 3 };
    jaggedArray[1] = new int[] { 4, 5 };
    jaggedArray[2] = new int[] { 6, 7, 8, 9 };
    Console.WriteLine("Jagged Array:");
    foreach (var row in jaggedArray)
    {
        foreach (var item in row)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

//EmployeeDemo();

static void EmployeeDemo()
{
    Employee emp = new Employee();
    emp.InputDetails();
    emp.CalculateSalary();
    emp.PrintDetails();
}

//PrimitiveDataTypes
//DataTypesDemo();
static void DataTypesDemo()
{
    Console.WriteLine($"byte: " + byte.MinValue + " " + byte.MaxValue);
    Console.WriteLine($"int: " + int.MinValue + " " + int.MaxValue);
    Console.WriteLine($"short: " + short.MinValue + " " + short.MaxValue);
    Console.WriteLine($"long: " + long.MinValue + " " + long.MaxValue);
    Console.WriteLine($"float: " + float.MinValue + " " + float.MaxValue);
    Console.WriteLine($"double: " + double.MinValue + " " + double.MaxValue);
    Console.WriteLine($"decimal: " + decimal.MinValue + " " + decimal.MaxValue);
    Console.WriteLine($"char: " + char.MinValue + " " + char.MaxValue);
    Console.WriteLine($"bool: " + bool.TrueString + " " + bool.FalseString);
}

//ProductDemo();
static void ProductDemo()
{
    //constructor
    //Product product = new Product("Laptop", 55000.00, 30);

    //getter and setter
    Product product = new Product();
    product.ProductName = "Laptop";
    product.ProductPrice = 55000.00;
    product.ProductQuantity = 30;

    //display product details with getter
    //product.DisplayProductDetails();

    product.InteractiveMethodMenu();
}

//PersonDetailsDemo();
static void PersonDetailsDemo()
{
    Person person = new Person(1, "John Doe", "New York", 30);
    person.DisplayPersonDetails();
    Console.WriteLine($"Person info:{person.GetPersonInfo()}");
    // Updating person details
    person.UpdatePersonDetails("Munna", "Bangalore", 28);
    person.DisplayPersonDetails();


    Person person1 = new Person();
    person1.Id = 2;
    person1.Name = "Jane Smith";
    person1.City = "Chennai";

    person1.Age = 25;
    person1.DisplayPersonDetails();
    // Using auto-implemented properties
    Console.WriteLine($"Person info:{person1.GetPersonInfo()}");
    Console.WriteLine(person1.ToString());
}

//SingleInheritenceDemo();
static void SingleInheritenceDemo()
{
    EmployeeChild employee = new EmployeeChild();
    Console.WriteLine("Please enter your ID:");
    employee.Id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter your Employee ID:");
    employee.EmployeeId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter your Name:");
    employee.Name = Console.ReadLine();
    Console.WriteLine("Please enter your City:");
    employee.City = Console.ReadLine();
    Console.WriteLine("Please enter your Age:");
    employee.Age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter your Role:");
    employee.Role = Console.ReadLine();
    Console.WriteLine("Please enter your Email:");
    employee.Email = Console.ReadLine();
    Console.WriteLine("Please enter your Salary:");
    employee.Salary = Convert.ToDouble(Console.ReadLine());
    employee.DisplayPersonDetails();
    Console.WriteLine($"Personal Info: {employee.GetPersonInfo()}");
    Console.WriteLine($"Employee Info: {employee.EmployeeId}, Role: {employee.Role}, Email: {employee.Email}, Salary: {employee.Salary:C}"); // :C formats as currency
}

//ConsultingEmployee(); //Multilevel Inheritence Demo
static void ConsultingEmployee()
{
    ConsultingEmployee consultingEmployee = new ConsultingEmployee();
    Console.WriteLine("Please enter your ID:");
    consultingEmployee.Id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter your Employee ID:");
    consultingEmployee.EmployeeId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter your Name:");
    consultingEmployee.Name = Console.ReadLine();
    Console.WriteLine("Please enter your City:");
    consultingEmployee.City = Console.ReadLine();
    Console.WriteLine("Please enter your Age:");
    consultingEmployee.Age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter your Role:");
    consultingEmployee.Role = Console.ReadLine();
    Console.WriteLine("Please enter your Email:");
    consultingEmployee.Email = Console.ReadLine();
    Console.WriteLine("Please enter your Salary:");
    consultingEmployee.Salary = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please enter your Consulting Firm:");
    consultingEmployee.ConsultingFirm = Console.ReadLine();
    Console.WriteLine("Please enter your Contract Duration (in months):");
    consultingEmployee.ContractDuration = Convert.ToInt32(Console.ReadLine());
    //consultingEmployee.DisplayPersonDetails();
    Console.WriteLine($"Personal Info: {consultingEmployee.GetPersonInfo()}");

    Console.WriteLine($"Employee Info: {consultingEmployee.EmployeeId}, Role: {consultingEmployee.Role}, Email: {consultingEmployee.Email}, Salary: {consultingEmployee.Salary:C}"); // :C formats as currency
    Console.WriteLine($"Consulting Firm: {consultingEmployee.ConsultingFirm}, Contract Duration: {consultingEmployee.ContractDuration} months");
}



//Multilevel Inheritence - Bank Account Demo
BankAccount();
static void BankAccount()
{
    Account acc = null;
    SavingsAccount savAcc = null;
    SalaryAccount salAcc = null;

    while (true)
    {
        Console.WriteLine("\n--- Bank Account Menu ---");
        Console.WriteLine("1. Open Account");
        Console.WriteLine("2. Open Savings Account");
        Console.WriteLine("3. Open Salary Account");
        Console.WriteLine("4. Use Account");
        Console.WriteLine("5. Use Savings Account");
        Console.WriteLine("6. Use Salary Account");
        Console.WriteLine("7. Edit Account Details");
        Console.WriteLine("8. Exit");
        Console.Write("Select an option: ");
        string mainChoice = Console.ReadLine();

        if (mainChoice == "8")
            break;

        switch (mainChoice)
        {
            case "1":
                acc = CreateAccount();
                break;
            case "2":
                savAcc = CreateSavingsAccount();
                break;
            case "3":
                salAcc = CreateSalaryAccount();
                break;
            case "4":
                if (acc != null)
                    AccountMenu(acc);
                else
                    Console.WriteLine("No Account found. Please open an Account first.");
                break;
            case "5":
                if (savAcc != null)
                    SavingsAccountMenu(savAcc);
                else
                    Console.WriteLine("No Savings Account found. Please open a Savings Account first.");
                break;
            case "6":
                if (salAcc != null)
                    SalaryAccountMenu(salAcc);
                else
                    Console.WriteLine("No Salary Account found. Please open a Salary Account first.");
                break;
            case "7":
                EditAccountDetails(ref acc, ref savAcc, ref salAcc);
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }
    Console.WriteLine("Thank you for using the Bank Account System!");
}

// Methods to create accounts
static Account CreateAccount()
{
    Console.WriteLine("\n--- Open Account ---");
    Console.Write("Enter Account Number: ");
    string accNo = Console.ReadLine();
    Console.Write("Enter Account Holder Name: ");
    string name = Console.ReadLine();
    Console.Write("Enter Initial Balance: ");
    double balance = double.TryParse(Console.ReadLine(), out double b) ? b : 0;
    return new Account(accNo, name, balance);
}
// Methods to create Savings accounts
static SavingsAccount CreateSavingsAccount()
{
    Console.WriteLine("\n--- Open Savings Account ---");
    Console.Write("Enter Account Number: ");
    string accNo = Console.ReadLine();
    Console.Write("Enter Account Holder Name: ");
    string name = Console.ReadLine();
    Console.Write("Enter Initial Balance: ");
    double balance = double.TryParse(Console.ReadLine(), out double b) ? b : 0;
    Console.Write("Enter Interest Rate (%): ");
    double rate = double.TryParse(Console.ReadLine(), out double r) ? r : 0;
    return new SavingsAccount(accNo, name, balance, rate);
}
// Methods to create Salary accounts
static SalaryAccount CreateSalaryAccount()
{
    Console.WriteLine("\n--- Open Salary Account ---");
    Console.Write("Enter Account Number: ");
    string accNo = Console.ReadLine();
    Console.Write("Enter Account Holder Name: ");
    string name = Console.ReadLine();
    Console.Write("Enter Initial Balance: ");
    double balance = double.TryParse(Console.ReadLine(), out double b) ? b : 0;
    Console.Write("Enter Interest Rate (%): ");
    double rate = double.TryParse(Console.ReadLine(), out double r) ? r : 0;
    Console.Write("Enter Employer Name: ");
    string employer = Console.ReadLine();
    return new SalaryAccount(accNo, name, balance, rate, employer);
}

// Methods to edit account details
static void EditAccountDetails(ref Account acc, ref SavingsAccount savAcc, ref SalaryAccount salAcc)
{
    Console.WriteLine("\n--- Edit Account Details ---");
    Console.WriteLine("1. Edit Account");
    Console.WriteLine("2. Edit Savings Account");
    Console.WriteLine("3. Edit Salary Account");
    Console.WriteLine("4. Back");
    Console.Write("Select an option: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            if (acc != null)
                EditBasicAccount(acc);
            else
                Console.WriteLine("No Account found.");
            break;
        case "2":
            if (savAcc != null)
                EditSavingsAccount(savAcc);
            else
                Console.WriteLine("No Savings Account found.");
            break;
        case "3":
            if (salAcc != null)
                EditSalaryAccount(salAcc);
            else
                Console.WriteLine("No Salary Account found.");
            break;
        case "4":
            break;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}
// Methods to edit basic account details
static void EditBasicAccount(Account acc)
{
    Console.WriteLine("\nEdit Account Details:");
    Console.WriteLine("1. Account Number");
    Console.WriteLine("2. Account Holder Name");
    Console.WriteLine("3. Back");
    Console.Write("Select field to edit: ");
    string field = Console.ReadLine();
    switch (field)
    {
        case "1":
            Console.Write("Enter new Account Number: ");
            acc.AccountNumber = Console.ReadLine();
            break;
        case "2":
            Console.Write("Enter new Account Holder Name: ");
            acc.AccountHolderName = Console.ReadLine();
            break;
        case "3":
            break;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}
// Methods to edit savings account details
static void EditSavingsAccount(SavingsAccount savAcc)
{
    EditBasicAccount(savAcc);
    Console.WriteLine("4. Interest Rate");
    Console.WriteLine("5. Back");
    Console.Write("Select field to edit: ");
    string field = Console.ReadLine();
    switch (field)
    {
        case "4":
            Console.Write("Enter new Interest Rate: ");
            if (double.TryParse(Console.ReadLine(), out double rate))
                savAcc.InterestRate = rate;
            else
                Console.WriteLine("Invalid rate.");
            break;
        case "5":
            break;
        default:
            break;
    }
}
// Methods to edit salary account details
static void EditSalaryAccount(SalaryAccount salAcc)
{
    EditSavingsAccount(salAcc);
    Console.WriteLine("6. Employer Name");
    Console.WriteLine("7. Back");
    Console.Write("Select field to edit: ");
    string field = Console.ReadLine();
    switch (field)
    {
        case "6":
            Console.Write("Enter new Employer Name: ");
            salAcc.EmployerName = Console.ReadLine();
            break;
        case "7":
            break;
        default:
            break;
    }
}

// Methods to handle account operationss
static void AccountMenu(Account acc)
{
    while (true)
    {
        Console.WriteLine($"\n--- Account ({acc.AccountHolderName}) ---");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Get Balance");
        Console.WriteLine("4. Back to Main Menu");
        Console.Write("Select an option: ");
        string choice = Console.ReadLine();

        if (choice == "4")
            break;

        switch (choice)
        {
            case "1":
                Console.Write("Enter deposit amount: ");
                if (double.TryParse(Console.ReadLine(), out double depAmt))
                    acc.Deposit(depAmt);
                else
                    Console.WriteLine("Invalid amount.");
                break;
            case "2":
                Console.Write("Enter withdrawal amount: ");
                if (double.TryParse(Console.ReadLine(), out double withAmt))
                    acc.Withdraw(withAmt);
                else
                    Console.WriteLine("Invalid amount.");
                break;
            case "3":
                Console.WriteLine($"Current Balance: {acc.GetBalance()}");
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
}
// Methods to handle savings account operations
static void SavingsAccountMenu(SavingsAccount savAcc)
{
    while (true)
    {
        Console.WriteLine($"\n--- Savings Account ({savAcc.AccountHolderName}) ---");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Get Balance");
        Console.WriteLine("4. Apply Interest");
        Console.WriteLine("5. Back to Main Menu");
        Console.Write("Select an option: ");
        string choice = Console.ReadLine();

        if (choice == "5")
            break;

        switch (choice)
        {
            case "1":
                Console.Write("Enter deposit amount: ");
                if (double.TryParse(Console.ReadLine(), out double depAmt))
                    savAcc.Deposit(depAmt);
                else
                    Console.WriteLine("Invalid amount.");
                break;
            case "2":
                Console.Write("Enter withdrawal amount: ");
                if (double.TryParse(Console.ReadLine(), out double withAmt))
                    savAcc.Withdraw(withAmt);
                else
                    Console.WriteLine("Invalid amount.");
                break;
            case "3":
                Console.WriteLine($"Current Balance: {savAcc.GetBalance()}");
                break;
            case "4":
                savAcc.ApplyInterest();
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
}
// Methods to handle salary account operations
static void SalaryAccountMenu(SalaryAccount salAcc)
{
    while (true)
    {
        Console.WriteLine($"\n--- Salary Account ({salAcc.AccountHolderName}, Employer: {salAcc.EmployerName}) ---");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Get Balance");
        Console.WriteLine("4. Apply Interest");
        Console.WriteLine("5. Back to Main Menu");
        Console.Write("Select an option: ");
        string choice = Console.ReadLine();

        if (choice == "5")
            break;

        switch (choice)
        {
            case "1":
                Console.Write("Enter deposit amount: ");
                if (double.TryParse(Console.ReadLine(), out double depAmt))
                    salAcc.Deposit(depAmt);
                else
                    Console.WriteLine("Invalid amount.");
                break;
            case "2":
                Console.Write("Enter withdrawal amount: ");
                if (double.TryParse(Console.ReadLine(), out double withAmt))
                    salAcc.Withdraw(withAmt);
                else
                    Console.WriteLine("Invalid amount.");
                break;
            case "3":
                Console.WriteLine($"Current Balance: {salAcc.GetBalance()}");
                break;
            case "4":
                salAcc.ApplyInterest();
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
}

