//DRY - Do not Repeat Yourself

//Void Functions - Completes a task and moves along
//Without parameters
void PrintName()
{
    Console.WriteLine("Hello Mathew!");
}

//With parameters
void Addition(int num1, int num2)
{
    Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
}

//Value returning functions - Completes a task and returns a value

int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;
    if(largest < num2)
    {
        largest = num2;
    }
    if(largest < num3)
    {
        largest = num3;
    }
    return largest;
}
Console.Write("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

PrintName();
Addition(number1, number2);

int result = LargestNumber(number1, number2, number3);
Console.WriteLine($"The largest number is {result}");
