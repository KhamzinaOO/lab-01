using System;

namespace hello__user
{
    class Program
    {
        static bool checkData (int day, int month, int year)
        {
            bool febCheck = true;
            if (month == 2)
            {
                if (day > 28)
                {
                    if ((day == 29) && (year % 4 == 0) || (year % 100 != 0 && year % 400 == 0))
                    {
                        febCheck = true;
                    }
                    else
                    {
                        febCheck = false;
                    }
                }
            }
            if (day > 0 && day <= 31 && month > 0 && month <= 12 && febCheck == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, как тебя зовут?");
            var name = Console.ReadLine();
            int year;
            int day;
            int month;
            bool dataValid;
            int cycleCount = 0;
            do
            {
                if (cycleCount > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Некорректная дата. Попробуйте еще раз.");
                }
                Console.WriteLine("В какой день ты родился?");
                day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("В каком месяце ты родился?");
                month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("В каком году ты родился?");
                year = Convert.ToInt32(Console.ReadLine());
                dataValid = checkData(day, month, year);
                ++cycleCount;
            }
            while (!dataValid);
            DateTime age = DateTime.Today.AddYears(-year).AddMonths(-month).AddDays(-day);
            Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + (age.Year) + " лет. Приятно позакомиться.");
        }
    }
}
