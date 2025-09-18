public class Operators
{
    // Fields for demonstration
    private int a = 10;
    private int b = 3;
    private bool flag1 = true;
    private bool flag2 = false;

    public void ArithmeticOperators()
    {
        Console.WriteLine("=== Arithmetic Operators ===");
        Console.WriteLine($"a + b = {a + b}");
        Console.WriteLine($"a - b = {a - b}");
        Console.WriteLine($"a * b = {a * b}");
        Console.WriteLine($"a / b = {a / b}");
        Console.WriteLine($"a % b = {a % b}");
        Console.WriteLine();
    }

    public void ComparisonOperators()
    {
        Console.WriteLine("=== Comparison Operators ===");
        Console.WriteLine($"a == b: {a == b}");
        Console.WriteLine($"a != b: {a != b}");
        Console.WriteLine($"a > b: {a > b}");
        Console.WriteLine($"a < b: {a < b}");
        Console.WriteLine($"a >= b: {a >= b}");
        Console.WriteLine($"a <= b: {a <= b}");
        Console.WriteLine();
    }

    public void LogicalOperators()
    {
        Console.WriteLine("=== Logical Operators ===");
        Console.WriteLine($"flag1 && flag2: {flag1 && flag2}");
        Console.WriteLine($"flag1 || flag2: {flag1 || flag2}");
        Console.WriteLine($"!flag1: {!flag1}");
        Console.WriteLine();
    }

    public void BitwiseOperators()
    {
        Console.WriteLine("=== Bitwise Operators ===");
        Console.WriteLine($"a & b: {a & b}");
        Console.WriteLine($"a | b: {a | b}");
        Console.WriteLine($"a ^ b: {a ^ b}");
        Console.WriteLine($"~a: {~a}");
        Console.WriteLine($"a << 1: {a << 1}");
        Console.WriteLine($"a >> 1: {a >> 1}");
        Console.WriteLine();
    }

    public void AssignmentOperators()
    {
        Console.WriteLine("=== Assignment Operators ===");
        int x = a;
        Console.WriteLine($"x = {x}");
        x += b; Console.WriteLine($"x += b: {x}");
        x -= b; Console.WriteLine($"x -= b: {x}");
        x *= b; Console.WriteLine($"x *= b: {x}");
        x /= b; Console.WriteLine($"x /= b: {x}");
        x %= b; Console.WriteLine($"x %= b: {x}");
        x &= b; Console.WriteLine($"x &= b: {x}");
        x |= b; Console.WriteLine($"x |= b: {x}");
        x ^= b; Console.WriteLine($"x ^= b: {x}");
        x <<= 1; Console.WriteLine($"x <<= 1: {x}");
        x >>= 1; Console.WriteLine($"x >>= 1: {x}");
        Console.WriteLine();
    }

    public void UnaryOperators()
    {
        Console.WriteLine("=== Unary Operators ===");
        int y = a;
        Console.WriteLine($"y = {y}");
        Console.WriteLine($"++y: {++y}");
        Console.WriteLine($"y++: {y++} (after this y = {y})");
        Console.WriteLine($"--y: {--y}");
        Console.WriteLine($"y--: {y--} (after this y = {y})");
        Console.WriteLine($"-y: {-y}");
        Console.WriteLine($"+y: {+y}");
        Console.WriteLine($"!flag1: {!flag1}");
        Console.WriteLine();
    }
}

