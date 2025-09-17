namespace MyCharpTest
{

    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Main function!");

            Variables v = new Variables();
            v.BooleanExample();
            v.CharExample();
            v.DecimalExample();
            v.LongExample();
            v.FloatExample();
            v.StringExample();
            v.ArrayExample();
        }
    }
}