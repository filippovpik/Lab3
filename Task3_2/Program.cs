namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 numbers");
            int a = Convert.ToInt32(Console.ReadLine()); //input number
            int b = Convert.ToInt32(Console.ReadLine()); //input number
            int c = Convert.ToInt32(Console.ReadLine()); //input number
            int max=0;
                       
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b; 
            }

            if (c > a)
            {
                max = c;
            }


            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}
