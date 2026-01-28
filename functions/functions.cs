
public class Functions
{
    // Function basics
    public void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    // Named and default parameters
    public void DisplayInfo(string name, int age = 25, string city = "Munich")
    {
        Console.WriteLine($"{name}, {age} years old, lives in {city}");
    }

    // Reference (ref) parameter
    public void AddFiveRef(ref int number)
    {
        number += 5;
    }

    // Out parameter
    public void GetFullName(string firstName, string lastName, out string fullName)
    {
        fullName = firstName + " " + lastName;
    }

    // Returning multiple values using tuple
    public (int sum, int product) CalculateSumAndProduct(int a, int b)
    {
        int sum = a + b;
        int product = a * b;
        return (sum, product);
    }
}
