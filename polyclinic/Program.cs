using System;

namespace polyclinic
{
    class Program
    {
        static void Main(string[] args)
        {
            int old_ladies;
            int time_hour;
            int time_minute;
            int time_work = 10;

            Console.Write("Введите длину очереди:");
            old_ladies = Convert.ToInt32(Console.ReadLine());
            time_hour = (old_ladies * time_work) / 60;
            time_minute = (old_ladies * time_work) % 60;
            Console.Write("Время ожидания в очереди " + time_hour + " часов и " + time_minute + " минут");


        }
    }
}