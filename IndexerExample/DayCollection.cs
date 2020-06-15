using System;

namespace IndexerExample
{
    public class DayCollection
    {
        private readonly string[] _days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
        private readonly string[] _daysLong = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

        public int this[string day] => FindDayNumber(day);

        private int FindDayNumber(string day)
        {
            for (int i = 0; i < _days.Length; i++)
            {
                if (day == _days[i])
                {
                    return i + 1;
                }
            }

            for (int j = 0; j < _daysLong.Length; j++)
            {
                if (day == _daysLong[j])
                {
                    return j + 1;
                }
            }
            
            throw new ArgumentOutOfRangeException(nameof(day), $"Запись для \"{day}\" не поддерживается. Используйте подобный вариант \"Пн\", \"Вт\" и тд. или полное название \"Понедельник\", \"Вторник\" ");
        }
    }
}