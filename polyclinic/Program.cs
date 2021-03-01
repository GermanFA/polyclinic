using System;

namespace polyclinic
{
    class Program
    {
        static void Main(string[] args)
        {
            int queue;
            int timeHour;
            int timeMinute;
            int timeWork = 10;

            Console.Write("Введите длину очереди:");
            queue = Convert.ToInt32(Console.ReadLine());
            timeHour = (queue * timeWork) / 60;
            timeMinute = (queue * timeWork) % 60;
            Console.Write("Время ожидания в очереди " + timeHour + " часов и " + timeMinute + " минут");


        }
    }
}