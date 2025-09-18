namespace MyCharpTest
{

    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Main function!");

            // variables 
            Variables v = new Variables();
            v.BooleanExample();
            v.CharExample();
            v.DecimalExample();
            v.LongExample();
            v.FloatExample();
            v.StringExample();
            v.ArrayExample();


            // operators 
            Operators o = new Operators();
            o.ArithmeticOperators();
            o.AssignmentOperators();
            o.BitwiseOperators();
            o.ComparisonOperators();
            o.LogicalOperators();
            o.UnaryOperators();
        }
    }
}