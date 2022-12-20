



//Calculate();
using Polymorphism_Abstraction_Interface;
using Polymorphism_Abstraction_Interface;
using Polymorphism_Abstraction_Interface.Interface;

static void Calculate()
{
    ICalculation Calculation = new Calculation();

    Console.WriteLine("Birinci reqemi daxil edin");

Number1: string strNum1 = Console.ReadLine();
    double checkedNum1;
    bool isParseNum1 = double.TryParse(strNum1, out checkedNum1);

    if (!isParseNum1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Duzgun reqem daxil edin");
        Console.ResetColor();
        goto Number1;
    }


    Console.WriteLine("Operator daxil edin");
    string operation = Console.ReadLine();


    Console.WriteLine("ikinci reqemi daxil edin");
Number2: string strNum2 = Console.ReadLine();
    double checkedNum2;
    bool isParseNum2 = double.TryParse(strNum2, out checkedNum2);

    if (!isParseNum2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Duzgun reqem daxil edin");
        Console.ResetColor();
        goto Number2;
    }

    if (checkedNum2 == 0 && operation == "/")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Sifira bolmek olmur");
        Console.ResetColor();
        goto Number2;

    }

    var result = Calculation.Calculate(checkedNum1, checkedNum2, operation);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Result =" + result);
    Console.ResetColor();
}



////2) Login mentiqini service ve interface ile yazmaq. 
////  (IAccountService, AccountService isdifade etmekle).


//IAccountService AccountService = new AccountService();

//AccountService.Login("Ceyhun123", "Ceyhun2000");