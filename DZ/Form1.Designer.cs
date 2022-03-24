namespace DZ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.info_button = new System.Windows.Forms.Button();
            this.eng_rb = new System.Windows.Forms.RadioButton();
            this.am_rb = new System.Windows.Forms.RadioButton();
            this.rus_rb = new System.Windows.Forms.RadioButton();
            this.format_text = new System.Windows.Forms.Label();
            this.date1_textbox = new System.Windows.Forms.MaskedTextBox();
            this.date2_textbox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.seconds_button = new System.Windows.Forms.Button();
            this.minutes_button = new System.Windows.Forms.Button();
            this.hours_button = new System.Windows.Forms.Button();
            this.months_button = new System.Windows.Forms.Button();
            this.weeks_button = new System.Windows.Forms.Button();
            this.days_button = new System.Windows.Forms.Button();
            this.history_button = new System.Windows.Forms.Button();
            this.output_text = new System.Windows.Forms.Label();
            this.clearHistory_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.info_button);
            this.groupBox1.Controls.Add(this.eng_rb);
            this.groupBox1.Controls.Add(this.am_rb);
            this.groupBox1.Controls.Add(this.rus_rb);
            this.groupBox1.Controls.Add(this.format_text);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(829, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Формат дат";
            // 
            // info_button
            // 
            this.info_button.Location = new System.Drawing.Point(20, 101);
            this.info_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(84, 45);
            this.info_button.TabIndex = 19;
            this.info_button.Text = "Info";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // eng_rb
            // 
            this.eng_rb.AutoSize = true;
            this.eng_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eng_rb.Location = new System.Drawing.Point(578, 36);
            this.eng_rb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eng_rb.Name = "eng_rb";
            this.eng_rb.Size = new System.Drawing.Size(230, 29);
            this.eng_rb.TabIndex = 2;
            this.eng_rb.TabStop = true;
            this.eng_rb.Text = "Английский формат";
            this.eng_rb.UseVisualStyleBackColor = true;
            this.eng_rb.CheckedChanged += new System.EventHandler(this.eng_rb_CheckedChanged);
            // 
            // am_rb
            // 
            this.am_rb.AutoSize = true;
            this.am_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.am_rb.Location = new System.Drawing.Point(288, 36);
            this.am_rb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.am_rb.Name = "am_rb";
            this.am_rb.Size = new System.Drawing.Size(258, 29);
            this.am_rb.TabIndex = 1;
            this.am_rb.TabStop = true;
            this.am_rb.Text = "Американский формат";
            this.am_rb.UseVisualStyleBackColor = true;
            this.am_rb.CheckedChanged += new System.EventHandler(this.am_rb_CheckedChanged);
            // 
            // rus_rb
            // 
            this.rus_rb.AutoSize = true;
            this.rus_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rus_rb.Location = new System.Drawing.Point(20, 36);
            this.rus_rb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rus_rb.Name = "rus_rb";
            this.rus_rb.Size = new System.Drawing.Size(229, 29);
            this.rus_rb.TabIndex = 0;
            this.rus_rb.TabStop = true;
            this.rus_rb.Text = "Российский формат";
            this.rus_rb.UseVisualStyleBackColor = true;
            this.rus_rb.CheckedChanged += new System.EventHandler(this.rus_rb_CheckedChanged);
            // 
            // format_text
            // 
            this.format_text.AutoSize = true;
            this.format_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.format_text.ForeColor = System.Drawing.Color.DarkGray;
            this.format_text.Location = new System.Drawing.Point(213, 96);
            this.format_text.Name = "format_text";
            this.format_text.Size = new System.Drawing.Size(421, 55);
            this.format_text.TabIndex = 18;
            this.format_text.Text = "DD.MM  hh:mm:ss";
            // 
            // date1_textbox
            // 
            this.date1_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date1_textbox.Location = new System.Drawing.Point(15, 220);
            this.date1_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date1_textbox.Mask = "00/00 00:00:00";
            this.date1_textbox.Name = "date1_textbox";
            this.date1_textbox.Size = new System.Drawing.Size(829, 75);
            this.date1_textbox.TabIndex = 1;
            this.date1_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date2_textbox
            // 
            this.date2_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date2_textbox.Location = new System.Drawing.Point(15, 355);
            this.date2_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date2_textbox.Mask = "00/00 00:00:00";
            this.date2_textbox.Name = "date2_textbox";
            this.date2_textbox.Size = new System.Drawing.Size(829, 75);
            this.date2_textbox.TabIndex = 2;
            this.date2_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(385, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 113);
            this.label1.TabIndex = 3;
            this.label1.Text = "—";
            // 
            // seconds_button
            // 
            this.seconds_button.Location = new System.Drawing.Point(705, 465);
            this.seconds_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seconds_button.Name = "seconds_button";
            this.seconds_button.Size = new System.Drawing.Size(127, 46);
            this.seconds_button.TabIndex = 10;
            this.seconds_button.Text = "Кол-во секунд";
            this.seconds_button.UseVisualStyleBackColor = true;
            this.seconds_button.Click += new System.EventHandler(this.seconds_button_Click);
            // 
            // minutes_button
            // 
            this.minutes_button.Location = new System.Drawing.Point(572, 465);
            this.minutes_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minutes_button.Name = "minutes_button";
            this.minutes_button.Size = new System.Drawing.Size(127, 46);
            this.minutes_button.TabIndex = 11;
            this.minutes_button.Text = "Кол-во минут";
            this.minutes_button.UseVisualStyleBackColor = true;
            this.minutes_button.Click += new System.EventHandler(this.minutes_button_Click);
            // 
            // hours_button
            // 
            this.hours_button.Location = new System.Drawing.Point(438, 465);
            this.hours_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hours_button.Name = "hours_button";
            this.hours_button.Size = new System.Drawing.Size(127, 46);
            this.hours_button.TabIndex = 12;
            this.hours_button.Text = "Кол-во часов";
            this.hours_button.UseVisualStyleBackColor = true;
            this.hours_button.Click += new System.EventHandler(this.hours_button_Click);
            // 
            // months_button
            // 
            this.months_button.Location = new System.Drawing.Point(24, 465);
            this.months_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.months_button.Name = "months_button";
            this.months_button.Size = new System.Drawing.Size(140, 46);
            this.months_button.TabIndex = 15;
            this.months_button.Text = "Кол-во месяцев";
            this.months_button.UseVisualStyleBackColor = true;
            this.months_button.Click += new System.EventHandler(this.months_button_Click);
            // 
            // weeks_button
            // 
            this.weeks_button.Location = new System.Drawing.Point(170, 465);
            this.weeks_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.weeks_button.Name = "weeks_button";
            this.weeks_button.Size = new System.Drawing.Size(127, 46);
            this.weeks_button.TabIndex = 14;
            this.weeks_button.Text = "Кол-во недель";
            this.weeks_button.UseVisualStyleBackColor = true;
            this.weeks_button.Click += new System.EventHandler(this.weeks_button_Click);
            // 
            // days_button
            // 
            this.days_button.Location = new System.Drawing.Point(304, 465);
            this.days_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.days_button.Name = "days_button";
            this.days_button.Size = new System.Drawing.Size(127, 46);
            this.days_button.TabIndex = 13;
            this.days_button.Text = "Кол-во дней";
            this.days_button.UseVisualStyleBackColor = true;
            this.days_button.Click += new System.EventHandler(this.days_button_Click);
            // 
            // history_button
            // 
            this.history_button.Location = new System.Drawing.Point(572, 635);
            this.history_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.history_button.Name = "history_button";
            this.history_button.Size = new System.Drawing.Size(94, 41);
            this.history_button.TabIndex = 17;
            this.history_button.Text = "История";
            this.history_button.UseVisualStyleBackColor = true;
            this.history_button.Click += new System.EventHandler(this.history_button_Click);
            // 
            // output_text
            // 
            this.output_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output_text.ForeColor = System.Drawing.SystemColors.GrayText;
            this.output_text.Location = new System.Drawing.Point(14, 532);
            this.output_text.Name = "output_text";
            this.output_text.Size = new System.Drawing.Size(829, 80);
            this.output_text.TabIndex = 18;
            this.output_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearHistory_button
            // 
            this.clearHistory_button.Location = new System.Drawing.Point(681, 635);
            this.clearHistory_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearHistory_button.Name = "clearHistory_button";
            this.clearHistory_button.Size = new System.Drawing.Size(162, 41);
            this.clearHistory_button.TabIndex = 19;
            this.clearHistory_button.Text = "Очистить историю";
            this.clearHistory_button.UseVisualStyleBackColor = true;
            this.clearHistory_button.Click += new System.EventHandler(this.clearHistory_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 691);
            this.Controls.Add(this.clearHistory_button);
            this.Controls.Add(this.output_text);
            this.Controls.Add(this.history_button);
            this.Controls.Add(this.months_button);
            this.Controls.Add(this.weeks_button);
            this.Controls.Add(this.days_button);
            this.Controls.Add(this.hours_button);
            this.Controls.Add(this.minutes_button);
            this.Controls.Add(this.seconds_button);
            this.Controls.Add(this.date2_textbox);
            this.Controls.Add(this.date1_textbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Калькулятор дат (ДЗ, Вариант 4)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton eng_rb;
        private System.Windows.Forms.RadioButton am_rb;
        private System.Windows.Forms.RadioButton rus_rb;
        private System.Windows.Forms.MaskedTextBox date1_textbox;
        private System.Windows.Forms.MaskedTextBox date2_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button seconds_button;
        private System.Windows.Forms.Button minutes_button;
        private System.Windows.Forms.Button hours_button;
        private System.Windows.Forms.Button months_button;
        private System.Windows.Forms.Button weeks_button;
        private System.Windows.Forms.Button days_button;
        private System.Windows.Forms.Button history_button;
        private System.Windows.Forms.Label format_text;
        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.Label output_text;
        private System.Windows.Forms.Button clearHistory_button;
    }
}

