namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input length of the site");
            int lSite = Convert.ToInt32(Console.ReadLine()); //input number_
            Console.WriteLine("Input width of the site");
            int wSite = Convert.ToInt32(Console.ReadLine()); //input number
            Console.WriteLine("Input length of the first house");
            int lHouse1 = Convert.ToInt32(Console.ReadLine()); //input number
            Console.WriteLine("Input width of the first house");
            int wHouse1 = Convert.ToInt32(Console.ReadLine()); //input number
            Console.WriteLine("Input length of the second house");
            int lHouse2 = Convert.ToInt32(Console.ReadLine()); //input number
            Console.WriteLine("Input width of the second house");
            int wHouse2 = Convert.ToInt32(Console.ReadLine()); //input number
            int l1=lHouse1 + lHouse2;
            int l2=lHouse1 + wHouse2;
            int l3 = (lHouse1>lHouse2)? lHouse1:lHouse2;
            int l4 = (lHouse1 > wHouse2) ? lHouse1 : wHouse2;
            int l5 = wHouse1 + lHouse2;
            int l6 = wHouse1 + wHouse2;
            int l7 = (wHouse1 > wHouse2) ? wHouse1 : wHouse2;
            int l8 = (lHouse2 > wHouse1) ? lHouse2 : wHouse1;
            int w1= (wHouse1 > wHouse2) ? wHouse1 : wHouse2;
            int w2= (wHouse1 > lHouse2) ? wHouse1 : lHouse2;
            int w3=wHouse1 + wHouse2;
            int w4=wHouse1 + lHouse2;
            int w5= (lHouse1 > wHouse2) ? lHouse1 : wHouse2;
            int w6= (lHouse1 > lHouse2) ? lHouse1 : lHouse2;
            int w7=lHouse1 + lHouse2;
            int w8=wHouse2 + lHouse1;
            string pos = "Не возможно разместить";



            if ((l1 <= lSite)&&(w1<=wSite))
            {
                pos = "Возможно разместить";
            }
            if ((l2 <= lSite) && (w2 <= wSite))
            {
                pos = "Возможно разместить";
            }
            if ((l3 <= lSite) && (w3 <= wSite))
            {
                pos = "Возможно разместить";
            }
            if ((l4 <= lSite) && (w4 <= wSite))
            {
                pos = "Возможно разместить";
            }
            if ((l5 <= lSite) && (w5 <= wSite))
            {
                pos = "Возможно разместить";
            }
            if ((l6 <= lSite) && (w6 <= wSite))
            {
                pos = "Возможно разместить";
            }
            if ((l7 <= lSite) && (w7 <= wSite))
            {
                pos = "Возможно разместить";
            }
            if ((l8 <= lSite) && (w8 <= wSite))
            {
                pos = "Возможно разместить";
            }


            Console.WriteLine(pos);

            Console.ReadKey();
        }
    }
}
