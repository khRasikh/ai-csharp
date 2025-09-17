public class Variables
{
    // Example of an integer variable
    public void IntegerExample()
    {
        int age = 25;
        Console.WriteLine($"Integer: {age}");
    }

    // Example of a double variable
    public void DoubleExample()
    {
        double price = 19.99;
        Console.WriteLine($"Double: {price}");
    }

    // Example of a string variable
    public void StringExample()
    {
        string name = "Alice";
        Console.WriteLine($"String: {name}");
    }

    // Example of a boolean variable
    public void BooleanExample()
    {
        bool isActive = true;
        Console.WriteLine($"Boolean: {isActive}");
    }

    // Example of a char variable
    public void CharExample()
    {
        char grade = 'A';
        Console.WriteLine($"Char: {grade}");
    }

    // Example of a float variable
    public void FloatExample()
    {
        float temperature = 36.6f;
        Console.WriteLine($"Float: {temperature}");
    }

    // Example of a long variable
    public void LongExample()
    {
        long population = 7800000000;
        Console.WriteLine($"Long: {population}");
    }

    // Example of a decimal variable
    public void DecimalExample()
    {
        decimal salary = 12345.67m;
        Console.WriteLine($"Decimal: {salary}");
    }

    public void ArrayExample()
    {
        // Correct array initialization
        int[] numbers = { 1, 2, 3, 435, 34543, 534, 34543, 534, 543, 53, 534, 53 };

        int total = 0;

        // Loop through the array
        for (int i = 0; i < numbers.Length; i++)
        {
            total += numbers[i];
            Console.WriteLine($"Array of Numbers: index {i} is {numbers[i]}");
        }

        // Print the total
        Console.WriteLine($"Total is: {total}");
    }

}