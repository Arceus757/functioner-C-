internal class Program
{
    private static void Main(string[] args)
    {
    //     Console.WriteLine("Converting SEK to YEN");
    //     Console.WriteLine("Enter amount in SEK to convert:");
    //     string input = Console.ReadLine();
        
    //     if (double.TryParse(input, out double sekAmount))
    //     {
    //         double jpyAmount = ConvertSekToJpy(sekAmount);
    //         Console.WriteLine($"{sekAmount} SEK = {jpyAmount} YEN");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Invalid input. Please enter a numeric value.");
    //     }
    // }

    // private static double ConvertSekToJpy(double sek)
    // {
    //     double conversionRate = 13.0; // Example conversion rate, 1 SEK = 13 JPY
    //     return sek * conversionRate;


    // Uppgift 2
    // Console.WriteLine("Enter rectangle base:");
    //     string baseInput = Console.ReadLine();
        
    //     Console.WriteLine("Enter rectangle height:");
    //     string heightInput = Console.ReadLine();

    //     if (double.TryParse(baseInput, out double rectangleBase) && double.TryParse(heightInput, out double rectangleHeight))
    //     {
    //         double area = CalculateRectangleArea(rectangleBase, rectangleHeight);
    //         double circumference = CalculateRectangleCircumference(rectangleBase, rectangleHeight);
    //         Console.WriteLine($"Area: {area}");
    //         Console.WriteLine($"Circumference: {circumference}");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Invalid input. Please enter numeric values.");
    //     }
    // }

    // private static double CalculateRectangleArea(double rectangleBase, double rectangleHeight)
    // {
    //     return rectangleBase * rectangleHeight;
    // }

    // private static double CalculateRectangleCircumference(double rectangleBase, double rectangleHeight)
    // {
    //     return 2 * (rectangleBase + rectangleHeight);


    // Uppgift 3
    // LucasNumber(10);

    // }

    // static void LucasNumber(int length, int numOne=2, int numTwo=1) {
    //     if (length <= 0) {
    //         return;
    //     }

    //     Console.WriteLine(numOne);
    //     Console.WriteLine(numTwo);
    //     int sum = numOne + numTwo;
    //     length -= 1;

    //     LucasNumber(length, sum, sum + numTwo);

    // Uppgift 4
    // Console.WriteLine(Power(6, 7)); // Exempelanrop
    // }

    // private static double Power(double baseNumber, int exponent)
    // {
    //     if (exponent == 0)
    //     {
    //         return 1;
    //     }
    //     else if (exponent > 0)
    //     {
    //         return baseNumber * Power(baseNumber, exponent - 1);
    //     }
    //     else
    //     {
    //         return 1 / Power(baseNumber, -exponent);
    //     }

    // Uppgift 5
    Console.WriteLine("Enter an expression (e.g., 42+4):");
        string input = Console.ReadLine();
        double result = CalculateExpression(input);
        Console.WriteLine($"Result: {result}");
    }

    private static double CalculateExpression(string input)
    {
        char[] inputArray = input.ToCharArray();
        int index = 0;
        double num1 = 0;
        double num2 = 0;
        char operation = ' ';

        // Extract the first number
        while (index < inputArray.Length && char.IsDigit(inputArray[index]))
        {
            num1 = num1 * 10 + (inputArray[index] - '0');
            index++;
        }

        // Extract the operation
        if (index < inputArray.Length && (inputArray[index] == '+' || inputArray[index] == '-' || inputArray[index] == '*' || inputArray[index] == '/'))
        {
            operation = inputArray[index];
            index++;
        }

        // Extract the second number
        while (index < inputArray.Length && char.IsDigit(inputArray[index]))
        {
            num2 = num2 * 10 + (inputArray[index] - '0');
            index++;
        }

        // Perform the operation
        switch (operation)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                return num1 / num2;
            default:
                throw new InvalidOperationException("Invalid operation");
        }

    }
}