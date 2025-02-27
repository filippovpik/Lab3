namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 numbers");
            int a = Convert.ToInt32(Console.ReadLine()); //input number_
            int b = Convert.ToInt32(Console.ReadLine()); //input number
            int c = Convert.ToInt32(Console.ReadLine()); //input number

            int max = a; //search max

            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            int min = a; //search min

            if (b < min)
            {
                min = b;
            }

            if (c < min)
            {
                min = c;
            }

            int mid = a; //search mid

            if ((b != min) && (b != max))
            {
                mid = b;
            }

            if ((c != min) && (c != max))
            {
                mid = c;
            }


            Console.WriteLine(mid);

            Console.ReadKey();
        }
    }
}
