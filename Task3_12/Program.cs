namespace Task3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a three digit number");
            int a = Convert.ToInt32(Console.ReadLine()); //input number

            int pos1 = a/100;
            int pos2 = (a%100)/10;
            int pos3 = a%10;

            string pos1Char = "сто";
            string pos2Char = "двадцать";
            string pos3Char = "один";

            switch (pos1) //search hundreds
            {
                case 1:
                    {
                        pos1Char = "сто";
                        break;
                    }
                case 2:
                    {
                        pos1Char = "двести";
                        break;
                    }
                case 3:
                    {
                        pos1Char = "триста";
                        break;
                    }
                case 4:
                    {
                        pos1Char = "четыреста";
                        break;
                    }
                case 5:
                    {
                        pos1Char = "пятьсот";
                        break;
                    }
                case 6:
                    {
                        pos1Char = "шестьсот";
                        break;
                    }
                case 7:
                    {
                        pos1Char = "семьсот";
                        break;
                    }
                case 8:
                    {
                        pos1Char = "восемьсот";
                        break;
                    }
                case 9:
                    {
                        pos1Char = "девятьсот";
                        break;
                    }
            }

            switch (pos2) //search tens
            {
                case 1:
                    {
                        pos2Char = "десять";
                        break;
                    }
                case 2:
                    {
                        pos2Char = "двадцать";
                        break;
                    }
                case 3:
                    {
                        pos2Char = "тридцать";
                        break;
                    }
                case 4:
                    {
                        pos2Char = "сорок";
                        break;
                    }
                case 5:
                    {
                        pos2Char = "пятьдесят";
                        break;
                    }
                case 6:
                    {
                        pos2Char = "шестьдесят";
                        break;
                    }
                case 7:
                    {
                        pos2Char = "семьдесят";
                        break;
                    }
                case 8:
                    {
                        pos2Char = "восемьдесят";
                        break;
                    }
                case 9:
                    {
                        pos2Char = "девяносто";
                        break;
                    }
            }

            switch (pos3) //search ones
            {
                case 1:
                    {
                        pos3Char = "один";
                        break;
                    }
                case 2:
                    {
                        pos3Char = "два";
                        break;
                    }
                case 3:
                    {
                        pos3Char = "три";
                        break;
                    }
                case 4:
                    {
                        pos3Char = "четыре";
                        break;
                    }
                case 5:
                    {
                        pos3Char = "пять";
                        break;
                    }
                case 6:
                    {
                        pos3Char = "шесть";
                        break;
                    }
                case 7:
                    {
                        pos3Char = "семь";
                        break;
                    }
                case 8:
                    {
                        pos3Char = "восемь";
                        break;
                    }
                case 9:
                    {
                        pos3Char = "девять";
                        break;
                    }
            }

            switch (a%100) //search 11 to 19
            {
                case 11:
                    {
                        pos2Char = "одиннадцать";
                        pos3Char = "";
                        break;
                    }
                case 12:
                    {
                        pos2Char = "двенадцать";
                        pos3Char = "";
                        break;
                    }
                case 13:
                    {
                        pos2Char = "тринадцать";
                        pos3Char = "";
                        break;
                    }
                case 14:
                    {
                        pos2Char = "четырнадцать";
                        pos3Char = "";
                        break;
                    }
                case 15:
                    {
                        pos2Char = "пятнадцать";
                        pos3Char = "";
                        break;
                    }
                case 16:
                    {
                        pos2Char = "шестнадцать";
                        pos3Char = "";
                        break;
                    }
                case 17:
                    {
                        pos2Char = "семнадцать";
                        pos3Char = "";
                        break;
                    }
                case 18:
                    {
                        pos2Char = "восемнадцать";
                        pos3Char = "";
                        break;
                    }
                case 19:
                    {
                        pos2Char = "девятнадцать";
                        pos3Char = "";
                        break;
                    }
            }
            if (a < 100 || a > 999) //Check acceptability of the number

            {
                pos1Char = "Ошибка";
                pos2Char = "";
                pos3Char = "";

            }
                      
            int num = (a >= 100 && a <= 999) ? num = a : num = 0;

            Console.WriteLine("{0} {1} {2}",pos1Char,pos2Char,pos3Char);
            
            Console.ReadKey();
        }
    }
}
