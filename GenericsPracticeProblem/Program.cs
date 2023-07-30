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

            Console.WriteLine("Welcome to GenericsPracticeProblem");
            Console.WriteLine("Please choose any one program from below options.");
            Console.WriteLine("\n1.FindMaxValue ");
            Console.WriteLine(" ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Given input are {0},{1},{2}",x,y,z);
                    FindMaxValue.FindMax(x, y, z);
                    break;
                   

                default:
                    Console.WriteLine("Please choose number within given options.");
                    break;
            }
        }
    }
}