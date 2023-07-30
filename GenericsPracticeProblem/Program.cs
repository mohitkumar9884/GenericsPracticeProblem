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
            string str1 = "Hello", str2 = "Hi", str3 = "Sayo";

            Console.WriteLine("Welcome to GenericsPracticeProblem");
            Console.WriteLine("Please choose any one program from below options.");
            Console.WriteLine("\n.1.IntegerFindMaxValue\n.2.FloatFindMaxValue\n.3.StringFindMaxValue\n.4.FindMaxValueUsingGenerics\n.5.ExtendMax");
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
                case 3:
                    Console.WriteLine("Given input are {0},{1}",str1,str2,str3);
                    FindMaxValue.FindMax(str1, str2, str3);
                    break; 
                case 4:
                    FindMaxValueUsingGenerics<int> intObj=new FindMaxValueUsingGenerics<int>(x,y,z);
                    intObj.TestMaximum();
                    Console.WriteLine(" ");
                    FindMaxValueUsingGenerics<float> floatObj=new FindMaxValueUsingGenerics<float>(a,b,c);
                    floatObj.TestMaximum();
                    Console.WriteLine(" ");
                    FindMaxValueUsingGenerics<string> stringObj=new FindMaxValueUsingGenerics<string>(str1,str2,str3);
                    stringObj.TestMaximum();
                    break;
                case 5:
                    FindMaxValueUsingGenerics<int> intobj = new FindMaxValueUsingGenerics<int>(new int[] { 58, 67, 98, 45, 72, 33 });
                    intobj.TestMaximum();

                    FindMaxValueUsingGenerics<float> floatobj = new FindMaxValueUsingGenerics<float>(new float[] { 20.25f, 40.31f, 68.99f, 43.32f, 55.75f });
                    floatobj.TestMaximum();

                    FindMaxValueUsingGenerics<string> stringobj = new FindMaxValueUsingGenerics<string>(new string[] { "Hello", "Hi", "Sayo", "Nope", "Generics" });
                    stringobj.TestMaximum();

                    break; 
                case 6:
                   
                default:
                    Console.WriteLine("Please choose number within given options.");
                    break;
            }
        }
    }
}