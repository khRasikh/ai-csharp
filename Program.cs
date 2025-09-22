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

            // Functions 
            Functions f = new Functions();
            f.GreetUser("Rasikh");
            f.DisplayInfo("Rasikh", 28);
            int number = 19;
            f.AddFiveRef(ref number);
            Console.WriteLine($"The ref of number 19 is : {number}");
            string fullName;
            f.GetFullName("Khuda Dad", "Rasikh", out fullName);
            Console.WriteLine($"The updated out fullName is: {fullName}");

            var (sum, product) = f.CalculateSumAndProduct(10, 10);
            var tuple = f.CalculateSumAndProduct(10, 10);
            Console.WriteLine($"Tuple sum: {tuple.sum} and product:{tuple.product}");
            Console.WriteLine($"Tuple sum: {sum} and product:{product}");
        }
    }
}