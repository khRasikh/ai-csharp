public class WhileLoop
{
    // ---------------- FOR LOOP METHODS ----------------
    
    // Print numbers using for loop
    public void PrintNumbersFor(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.WriteLine(i);
        }
    }

    // Get even numbers using for loop
    public List<int> GetEvenNumbersFor(int start, int end)
    {
        List<int> evens = new List<int>();

        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
                evens.Add(i);
        }

        return evens;
    }

    // Factorial with for loop
    public long FactorialFor(int number)
    {
        long result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }

    // ---------------- WHILE LOOP METHODS ----------------
    
    // Print numbers using while loop
    public void PrintNumbersWhile(int start, int end)
    {
        int i = start;
        while (i <= end)
        {
            Console.WriteLine(i);
            i++;
        }
    }

    // Get even numbers using while loop
    public List<int> GetEvenNumbersWhile(int start, int end)
    {
        List<int> evens = new List<int>();
        int i = start;

        while (i <= end)
        {
            if (i % 2 == 0)
                evens.Add(i);
            i++;
        }

        return evens;
    }

    // Factorial with while loop
    public long FactorialWhile(int number)
    {
        long result = 1;
        int i = 1;

        while (i <= number)
        {
            result *= i;
            i++;
        }

        return result;
    }
}
