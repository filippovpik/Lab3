namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Input 2 numbers");
                int a = Convert.ToInt32(Console.ReadLine()); //input number_
                int b = Convert.ToInt32(Console.ReadLine()); //input number
                string c = ("=");


                c=(a > b) ? c=">" : c = "=";

                if (a < b)
                {
                    c = "<";
                }
                

                Console.WriteLine(c);
                
                Console.ReadKey();
            }
        }
    }
}
