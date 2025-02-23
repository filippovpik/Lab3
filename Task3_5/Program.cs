namespace Task3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int a = Convert.ToInt32(Console.ReadLine()); //input number

            string c = ("=");


            c = (a % 10 == 0) ? c = "Да" : c = "Нет";


            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
