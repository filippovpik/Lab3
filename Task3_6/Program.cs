namespace Task3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int a = Convert.ToInt32(Console.ReadLine()); //input number_

            string c = ("=");


            c = (a % 2 == 0) ? c = "Да" : c = "Нет";


            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
