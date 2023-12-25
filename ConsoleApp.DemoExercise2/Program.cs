//declaring variables
int num1 = 0, num2 = 0;
int option = 0;
decimal result;

Console.WriteLine("***********Welcome to the sample calculator************");

while (option != -1)
{
    try
    {
        Console.Write("Enter a choice(enter -1 to exit):\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Modulus\nOption = ");
        option = Convert.ToInt32(Console.ReadLine());
        
        if (option == -1)
        {
            break;
        }
        Console.Write("Enter number 1: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 2: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        switch (option)
        {
            case 1:
                result = (decimal)num1 + num2;
                Console.WriteLine($"The sum of {num1} and {num2} is {result}");
                break;
            case 2:
                if (num1 > num2)
                {
                    result = (decimal)num1 - num2;
                    Console.WriteLine($"The difference of {num1} and {num2} is {result}");
                }
                else
                {
                    result = (decimal)num2 - num1;
                    Console.WriteLine($"The difference of {num1} and {num2} is {result}");
                }
                break;
            case 3:
                result = (decimal)num1 * num2;
                Console.WriteLine($"The multiplication of {num1} and {num2} is {result}");
                break;
            case 4:
                result = (decimal)num1 / num2;
                Console.WriteLine($"The division of {num1} by {num2} is {result}");
                break;
            case 5:
                result = (decimal)num1 % num2;
                Console.WriteLine($"The modulus of {num1} and {num2} is {result}");
                break;
            default:
                throw new Exception("Invalid item selected");
        }  
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
        Console.Clear();
    }
    
};
Console.WriteLine("***********Thank you for using the calculator************");