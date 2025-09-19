public class IfCondition
{
    // Method demonstrating if statement
    public void CheckNumber(int number)
    {
        if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else
        {
            Console.WriteLine($"The number {number} is Negative");
        }

    }

    // Method demonstrating if-else statement
    public void CheckEvenOdd(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine($"The number {number} is even.");
        }
        else
        {
            Console.WriteLine($"The number {number} is odd.");
        }
    }

}


public class SwitchStatement
{
    public string GetFirst(string value)
    {
        string result = "";
        switch (value)
        {
            case "one":
                Console.WriteLine($"The value {value} is the first one");
                result = "One";
                break;
            default:
                Console.WriteLine($"The value {value} is the default one");
                result = "default";
                break;
        }
        return result;
    }
}