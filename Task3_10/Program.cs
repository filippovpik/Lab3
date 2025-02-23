namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            int n = Convert.ToInt32(Console.ReadLine()); //input number_
            string ending = "ов";



            switch (n%10)
            {
                case 1:
                    {
                        ending="";
                        break;
                    }
                case 2:
                case 3:
                case 4:

                    {
                        ending = "а";
                        break;
                    }
                
            }

            if (n%100 > 10 && n%100<15)
            {
                ending = "ов";
            }

            Console.WriteLine("Мы построили {0} дом{1}", n,ending);
            Console.ReadKey();
        }
    }
}
