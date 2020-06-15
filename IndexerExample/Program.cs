using System;

namespace IndexerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = new DayCollection();

            var dayShortName = "Пн";
            var dayFoolName = "Понедельник";
            
            var dayNumberShortName = days[dayShortName];
            var dayNumberFoolName = days[dayFoolName];

            Console.WriteLine($"Номер дня:");
            Console.WriteLine($"\"{dayShortName}\" - {dayNumberShortName}");
            Console.WriteLine($"\"{dayFoolName}\" - {dayNumberFoolName}");
            
            Console.ReadLine();
        }
    }
}