using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(55, 10);
            DateTime now = DateTime.Now;
            DateTime birthDay;
            TimeSpan daysToBirth;
            bool flag = true;

            while (flag)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите Вашу дату рождения в формате 'гггг.мм.дд'");
                Console.ForegroundColor = ConsoleColor.Yellow;
        
                birthDay = DateTime.Parse(Console.ReadLine());

                DateTime thisyear = new DateTime(now.Year, birthDay.Month, birthDay.Day);//этот год и мой месяц дата(для расчета разницы)

                if (thisyear < now)//если др уже был
                {
                    thisyear = new DateTime(now.Year + 1, birthDay.Month, birthDay.Day);
                    daysToBirth = thisyear - now;
                }
                else
                {
                    daysToBirth = thisyear - now;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("До дня рождения осталось {0} дня(ей)", daysToBirth.Days);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Хотите продолжить? y/n");
                if (Console.ReadLine() == "n")
                {
                    flag = false;
                }
                Console.Clear();
            }
        }
    }
}
