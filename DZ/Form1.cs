using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DZ
{
    public partial class Form1 : Form
    {
        Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }
        private void rus_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rus_rb.Checked)
            {
                format_text.Text = "DD.MM  hh:mm:ss";
                date1_textbox.Clear();
                date1_textbox.Culture = new System.Globalization.CultureInfo("ru-RU");
                date2_textbox.Clear();
                date2_textbox.Culture = new System.Globalization.CultureInfo("ru-RU");
            }
        }
        private void am_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (am_rb.Checked)
            {
                format_text.Text = "MM-DD  hh:mm:ss";
                date1_textbox.Clear();
                date1_textbox.Culture = new System.Globalization.CultureInfo("af");
                date2_textbox.Clear();
                date2_textbox.Culture = new System.Globalization.CultureInfo("af");
            }
        }
        private void eng_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (eng_rb.Checked)
            {
                format_text.Text = "DD/MM  hh:mm:ss";
                date1_textbox.Clear();
                date1_textbox.Culture = new System.Globalization.CultureInfo("en");
                date2_textbox.Clear();
                date2_textbox.Culture = new System.Globalization.CultureInfo("en");
            }
        }
        private void info_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DD - день(1-31)\nMM - месяц(1-12)\n" +
                "hh - часы(0-23)\nmm - минуты(0-60)\nss - секунды(0-60)\nОбратите внимание, что " +
                "для работы программы первая дата должна быть больше второй!",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public int activeRB_id()
        {
            if (rus_rb.Checked || eng_rb.Checked) { return 1; }
            else { return 2; }
        }
        private void months_button_Click(object sender, EventArgs e)
        {
            if (calculator.checkDateTimeForErrors(date1_textbox, date2_textbox, activeRB_id()))
            {
                output_text.Text = calculator.calcMonths().ToString() + " мес.";
                historyProcessing(months_button.Text, output_text.Text);
            }
            else { historyProcessing(months_button.Text, "Возникла ошибка"); }
        }
        private void weeks_button_Click(object sender, EventArgs e)
        {
            if (calculator.checkDateTimeForErrors(date1_textbox, date2_textbox, activeRB_id()))
            {
                output_text.Text = calculator.calcWeeks().ToString() + " нед.";
                historyProcessing(weeks_button.Text, output_text.Text);
            }
            else { historyProcessing(weeks_button.Text, "Возникла ошибка"); }
        }
        private void days_button_Click(object sender, EventArgs e)
        {
            if (calculator.checkDateTimeForErrors(date1_textbox, date2_textbox, activeRB_id()))
            {
                output_text.Text = calculator.calcDays().ToString() + " д.";
                historyProcessing(days_button.Text, output_text.Text);
            }
            else { historyProcessing(days_button.Text, "Возникла ошибка"); }
        }
        private void hours_button_Click(object sender, EventArgs e)
        {
            if (calculator.checkDateTimeForErrors(date1_textbox, date2_textbox, activeRB_id()))
            {
                output_text.Text = calculator.calcHours().ToString() + " ч.";
                historyProcessing(hours_button.Text, output_text.Text);
            }
            else { historyProcessing(hours_button.Text, "Возникла ошибка"); }
        }
        private void minutes_button_Click(object sender, EventArgs e)
        {
            if (calculator.checkDateTimeForErrors(date1_textbox, date2_textbox, activeRB_id()))
            {
                output_text.Text = calculator.calcMinutes().ToString() + " мин.";
                historyProcessing(minutes_button.Text, output_text.Text);
            }
            else { historyProcessing(minutes_button.Text, "Возникла ошибка"); }
        }
        private void seconds_button_Click(object sender, EventArgs e)
        {
            if (calculator.checkDateTimeForErrors(date1_textbox, date2_textbox, activeRB_id()))
            {
                output_text.Text = calculator.calcSeconds().ToString() + " сек.";
                historyProcessing(seconds_button.Text, output_text.Text);
            }
            else { historyProcessing(seconds_button.Text, "Возникла ошибка"); }
        }
        private void historyProcessing(string operation, string resultMessage)
        {
            string date1 = date1_textbox.Text;
            string date2 = date2_textbox.Text;
            using (var sw = new StreamWriter("history.txt", true))
            {
                sw.WriteLine($"{date1} — {date2} | {operation} | {resultMessage}");
            }
        }
        private void history_button_Click(object sender, EventArgs e)
        {
            var history = new List<string>();
            using (var sr = new StreamReader("history.txt"))
            {
                while (sr.Peek() != -1) { history.Add(sr.ReadLine()); }
            }
            string historyMessage = "";
            if (history.Count == 0) { historyMessage = "Нет записей."; }
            else
            {
                historyMessage = "Последние 5 операций:\n";
                int n = 0;
                for (int i = history.Count - 1; i >= 0; i--)
                {
                    historyMessage += history[i] + "\n";
                    n++;
                    if (n == 5) { break; }
                }
            }
            MessageBox.Show(historyMessage, "История", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void clearHistory_button_Click(object sender, EventArgs e)
        {
            var sw = new StreamWriter("history.txt", false);
            MessageBox.Show("История успешно очищена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sw.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
