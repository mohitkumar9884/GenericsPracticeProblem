namespace GenericsPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 58, 67, 98, 45 };
            double[] doubleArray = { 20.25, 40.31, 68.99, 43.32 };
            char[] charArray = { 'D', 'R', 'E', 'A', 'M' };
            int x = 25, y = 98, z = 19;
            float a = 25.98f, b = 98.19f, c = 19.25f;

            Console.WriteLine("Welcome to GenericsPracticeProblem");
            Console.WriteLine("Please choose any one program from below options.");
            Console.WriteLine("\n.1.IntegerFindMaxValue\n.2.FloatFindMaxValue\n.3. ");
            Console.WriteLine(" ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Given input are {0},{1},{2}",x,y,z);
                    FindMaxValue.FindMax(x, y, z);
                    break;
                case 2:
                    Console.WriteLine("Given input are {0},{1},{2}",a,b,c);
                    FindMaxValue.FindMax(a, b, c);
                    break;
                   

                default:
                    Console.WriteLine("Please choose number within given options.");
                    break;
            }
        }
    }
}