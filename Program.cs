namespace MyCharpTest
{

    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Main function!");

            // // variables 
            // Variables v = new Variables();
            // v.BooleanExample();
            // v.CharExample();
            // v.DecimalExample();
            // v.LongExample();
            // v.FloatExample();
            // v.StringExample();
            // v.ArrayExample();


            // // operators 
            // Operators o = new Operators();
            // o.ArithmeticOperators();
            // o.AssignmentOperators();
            // o.BitwiseOperators();
            // o.ComparisonOperators();
            // o.LogicalOperators();
            // o.UnaryOperators();

            // // conditions 
            // IfCondition c = new IfCondition();
            // c.CheckEvenOdd(10);
            // c.CheckEvenOdd(11);
            // c.CheckEvenOdd(12);
            // c.CheckEvenOdd(15);
            // c.CheckNumber(10);
            // c.CheckNumber(-10);

            // // Switch
            // SwitchStatement s = new SwitchStatement();
            // string d = s.GetFirst("one");
            // Console.WriteLine(d);


            // For loop
            ForLoop l = new ForLoop();
            // l.PrintNumbers(1, 10);
            Console.WriteLine($"Even Numbers: {string.Join(", ", l.GetEvenNumbers(1, 10))}");
            Console.WriteLine($"Factorials: {l.Factorial(10)}");
            Console.WriteLine($"Sum: {l.SumRange(1, 10)}");
            Console.WriteLine($"new list after breaking number 8: {l.BreakIteration([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 8)}");
            Console.WriteLine($"new list after contineuing number 8: {l.ContinueIteration([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 8)}");


            // While loop 
            WhileLoop w = new WhileLoop();
            Console.WriteLine("Factorial(5) with for: " + w.FactorialFor(5));

            w.PrintNumbersWhile(1, 5);
            Console.WriteLine("Factorial(5) with while: " + w.FactorialWhile(5));

            var evensFor = w.GetEvenNumbersFor(1, 10);
            var evensWhile = w.GetEvenNumbersWhile(1, 10);

            Console.WriteLine("\nEvens with for: " + string.Join(", ", evensFor));
            Console.WriteLine("Evens with while: " + string.Join(", ", evensWhile));

        }
    }
}