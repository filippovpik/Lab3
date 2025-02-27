namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 numbers");
            int a = Convert.ToInt32(Console.ReadLine()); //input number_
            int b = Convert.ToInt32(Console.ReadLine()); //input number
            int c = Convert.ToInt32(Console.ReadLine()); //input number
            int max = 0;

            if ((a > b)&&(a<c))
            {
                b = c;
            }

            if (b > c)
            {
                b = a;
            }

            


            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
