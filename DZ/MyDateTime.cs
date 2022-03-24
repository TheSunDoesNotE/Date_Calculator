using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    public class MyDateTime
    {
        private int days;
        private int months;
        private int hours;
        private int minutes;
        private int seconds;
        public string exceptionMessage;
        public int Days
        {
            get { return days; }
            set
            {
                if (value == 0) { exceptionMessage += "0 дня не существует.\n"; }
                else if (value > 31) { exceptionMessage += "В месяце не может быть больше 31 дня.\n"; }
                else
                {
                    switch (Months)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            days = value;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            if (value <= 30) { days = value; }
                            else { exceptionMessage += $"В {Months} месяце не может быть больше 30 дней.\n"; }
                            break;
                        case 2:
                            if (value <= 29) { days = value; }
                            else { exceptionMessage += "Во 2 месяце не может быть больше 29 дней.\n"; }
                            break;
                    }
                }
            }
        }
        public int Months
        {
            get { return months; }
            set
            {
                if (value == 0) { exceptionMessage += "0 месяца не существует.\n"; }
                else if (value <= 12) { months = value; }
                else { exceptionMessage += "В году не может быть больше 12 месяцев.\n"; }
            }
        }
        public int Hours
        {
            get { return hours; }
            set
            {
                if (value <= 23) { hours = value; }
                else { exceptionMessage += "Часы записываются в диапазоне от 0 до 23.\n"; }
            }
        }
        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value <= 60) { minutes = value; }
                else { exceptionMessage += "Минуты записываются в диапазоне от 0 до 60.\n"; }
            }
        }
        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value <= 60) { seconds = value; }
                else { exceptionMessage += "Секунды записываются в диапазоне от 0 до 60.\n"; }
            }
        }
        public MyDateTime(int d, int m, int h, int min, int s)
        {
            exceptionMessage = "";
            Months = m;
            Days = d;
            Hours = h;
            Minutes = min;
            Seconds = s;
        }
    }
}
