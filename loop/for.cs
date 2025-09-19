public class ForLoop
{
    // Method to print numbers from start to end
    public void PrintNumbers(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.WriteLine(i);
        }
    }

    // Method to get all even numbers in a range
    public List<int> GetEvenNumbers(int start, int end)
    {
        List<int> evens = new List<int>();

        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
                evens.Add(i);
        }
        return evens;
    }

    // Method to calculate factorial using for loop
    public long Factorial(int number)
    {
        long result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }

    // Method to sum all numbers in a range
    public int SumRange(int start, int end)
    {
        int sum = 0;

        for (int i = start; i <= end; i++)
        {
            sum += i;
        }

        return sum;
    }

    // Method to reverse a string using for loop
    public string ReverseString(string input)
    {
        char[] reversed = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            reversed[i] = input[input.Length - 1 - i];
        }

        return new string(reversed);
    }

    
    public string BreakIteration(int[] list, int breakingValue)
    {
        List<int> newList = new List<int>();

        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] == breakingValue)
            {
                break;
            }
            newList.Add(list[i]);
        }
        return string.Join(", ", newList);

    }
    
    public string ContinueIteration(int[] list, int breakingValue)
    {
        List<int> newList = new List<int>();

        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] == breakingValue)
            {
                continue;
            }
            newList.Add(list[i]);
        }
        return string.Join(", ", newList);

    }
}
