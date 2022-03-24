        using System;
        using System.Collections.Generic;
        using System.ComponentModel;
        using System.Data;
        using System.Drawing;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;
        using System.Windows.Forms;

        namespace DZ
        {
            public class Calculator
            {
                private List<MyDateTime> dates;
                public List<MyDateTime> date_Parse(MaskedTextBox textBox1, MaskedTextBox textBox2, int activeRB_id)
                {
                    if (textBox1.Text.Count(x => char.IsDigit(x)) != 10 || textBox2.Text.Count(x => char.IsDigit(x)) != 10)
                    {
                        throw new Exception("Дата и время введены не полностью.");
                    }
                    dates = new List<MyDateTime>();
                    string[] datetime1 = textBox1.Text.Split(new char[] { ' ', ':', '.', '/', '-' }, StringSplitOptions.RemoveEmptyEntries);
                    string[] datetime2 = textBox2.Text.Split(new char[] { ' ', ':', '.', '/', '-' }, StringSplitOptions.RemoveEmptyEntries);
                    int d1, m1, h1, min1, s1;
                    int d2, m2, h2, min2, s2;
                    if (activeRB_id == 1)
                    {
                        d1 = int.Parse(datetime1[0]); d2 = int.Parse(datetime2[0]);
                        m1 = int.Parse(datetime1[1]); m2 = int.Parse(datetime2[1]);
                    }
                    else
                    {
                        m1 = int.Parse(datetime1[0]); m2 = int.Parse(datetime2[0]);
                        d1 = int.Parse(datetime1[1]); d2 = int.Parse(datetime2[1]);
                    }
                    h1 = int.Parse(datetime1[2]); h2 = int.Parse(datetime2[2]);
                    min1 = int.Parse(datetime1[3]); min2 = int.Parse(datetime2[3]);
                    s1 = int.Parse(datetime1[4]); s2 = int.Parse(datetime2[4]);
                    MyDateTime date1 = new MyDateTime(d1, m1, h1, min1, s1);
                    MyDateTime date2 = new MyDateTime(d2, m2, h2, min2, s2);
                    string exceptionMessage = "";
                    bool error = false;
                    if (date1.exceptionMessage != "")
                    {
                        exceptionMessage += "Дата №1:\n" + date1.exceptionMessage + "\n";
                        error = true;
                    }
                    if (date2.exceptionMessage != "")
                    {
                        exceptionMessage += "Дата №2:\n" + date2.exceptionMessage + "\n";
                        error = true;
                    }
                    if (error) { throw new Exception(exceptionMessage); }
                    dates.Add(date1); dates.Add(date2);
                    return dates;
                }
        
                public void checkDateTimeDifference()
                {
                    int d1 = dates[0].Days; int d2 = dates[1].Days;
                    int m1 = dates[0].Months; int m2 = dates[1].Months;
                    int h1 = dates[0].Hours; int h2 = dates[1].Hours;
                    int min1 = dates[0].Minutes; int min2 = dates[1].Minutes;
                    int s1 = dates[0].Seconds; int s2 = dates[1].Seconds;
                    if ((m1 < m2) || (m1 == m2 && d1 < d2) || ((m1 == m2 && d1 == d2) && (h1 * 3600 + min1 * 60 + s1) < (h2 * 3600 + min2 * 60 + s2)))
                    {
                        throw new Exception("Первая дата не должна быть меньше второй.");
                    }
                }
                public bool checkDateTimeForErrors(MaskedTextBox date1, MaskedTextBox date2, int id)
                {
                    try
                    {
                        dates = date_Parse(date1, date2, id);
                        checkDateTimeDifference();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                public int calcTotalDays(MyDateTime date)
                {
                    int m = date.Months;
                    int totaldays = date.Days;
                    for (int i = 1; i < m; i++)
                    {
                        if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                        { totaldays += 31; }
                        if (i == 2) { totaldays += 28; }
                        if (i == 4 || i == 6 || i == 9 || i == 11) { totaldays += 30; }
                    }
                    return totaldays;
                }
                public long calcTotalSeconds(MyDateTime date)
                {
                    int d = calcTotalDays(date);
                    int h = date.Hours;
                    int m = date.Minutes;
                    long totalseconds = date.Seconds;
                    totalseconds += d * 24 * 3600 + h * 3600 + m * 60;
                    return totalseconds;
                }
                public long calcSeconds() { return calcTotalSeconds(dates[0]) - calcTotalSeconds(dates[1]); }
                public long calcMinutes() { return calcSeconds() / 60; }
                public long calcHours() { return calcSeconds() / 3600; }
                public int calcDays()
                {
                    if (calcHours() < 24) { return 0; }
                    return calcTotalDays(dates[0]) - calcTotalDays(dates[1]);
                }
                public int calcWeeks() { return calcDays() / 7; }
                public int calcMonths() { return (int)calcSeconds() / 2629743; }
            }
        }
