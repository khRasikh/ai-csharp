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

            // conditions 
            IfCondition c = new IfCondition();
            c.CheckEvenOdd(10);
            c.CheckEvenOdd(11);
            c.CheckEvenOdd(12);
            c.CheckEvenOdd(15);
            c.CheckNumber(10);
            c.CheckNumber(-10);

            // Switch
            SwitchStatement s = new SwitchStatement();
            string d = s.GetFirst("one");
            Console.WriteLine(d);
        }
    }
}