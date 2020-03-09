namespace Statement
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Statement = new System.Windows.Forms.TabPage();
            this.label_Count_Subject = new System.Windows.Forms.Label();
            this.label_CountStud = new System.Windows.Forms.Label();
            this.numericUpDown_CountSubject = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CountStud = new System.Windows.Forms.NumericUpDown();
            this.button_AddByHand = new System.Windows.Forms.Button();
            this.button_ReadFile = new System.Windows.Forms.Button();
            this.button_RandomGeneration = new System.Windows.Forms.Button();
            this.dataGridView_Statement = new System.Windows.Forms.DataGridView();
            this.tabPage_StatisticStudent = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage_StatisticsSubject = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage_Scholarship_Debts = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage_Progress_Quality = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox_CellSubject = new System.Windows.Forms.TextBox();
            this.textBox_CellPerson = new System.Windows.Forms.TextBox();
            this.button_AddSubject = new System.Windows.Forms.Button();
            this.button_RemoveSubject = new System.Windows.Forms.Button();
            this.button_AddPerson = new System.Windows.Forms.Button();
            this.button_RemovePerson = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_Statement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CountSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CountStud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Statement)).BeginInit();
            this.tabPage_StatisticStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage_StatisticsSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage_Scholarship_Debts.SuspendLayout();
            this.tabPage_Progress_Quality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Statement);
            this.tabControl1.Controls.Add(this.tabPage_StatisticStudent);
            this.tabControl1.Controls.Add(this.tabPage_StatisticsSubject);
            this.tabControl1.Controls.Add(this.tabPage_Scholarship_Debts);
            this.tabControl1.Controls.Add(this.tabPage_Progress_Quality);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 419);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Statement
            // 
            this.tabPage_Statement.Controls.Add(this.label_Count_Subject);
            this.tabPage_Statement.Controls.Add(this.label_CountStud);
            this.tabPage_Statement.Controls.Add(this.numericUpDown_CountSubject);
            this.tabPage_Statement.Controls.Add(this.numericUpDown_CountStud);
            this.tabPage_Statement.Controls.Add(this.button_AddByHand);
            this.tabPage_Statement.Controls.Add(this.button_ReadFile);
            this.tabPage_Statement.Controls.Add(this.button_RandomGeneration);
            this.tabPage_Statement.Controls.Add(this.dataGridView_Statement);
            this.tabPage_Statement.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Statement.Name = "tabPage_Statement";
            this.tabPage_Statement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Statement.Size = new System.Drawing.Size(652, 393);
            this.tabPage_Statement.TabIndex = 0;
            this.tabPage_Statement.Text = "Ведомость";
            this.tabPage_Statement.UseVisualStyleBackColor = true;
            this.tabPage_Statement.Click += new System.EventHandler(this.tabPage_Statement_Click);
            // 
            // label_Count_Subject
            // 
            this.label_Count_Subject.AutoSize = true;
            this.label_Count_Subject.Location = new System.Drawing.Point(388, 8);
            this.label_Count_Subject.Name = "label_Count_Subject";
            this.label_Count_Subject.Size = new System.Drawing.Size(124, 13);
            this.label_Count_Subject.TabIndex = 7;
            this.label_Count_Subject.Text = "Количество предметов";
            // 
            // label_CountStud
            // 
            this.label_CountStud.AutoSize = true;
            this.label_CountStud.Location = new System.Drawing.Point(70, 8);
            this.label_CountStud.Name = "label_CountStud";
            this.label_CountStud.Size = new System.Drawing.Size(120, 13);
            this.label_CountStud.TabIndex = 6;
            this.label_CountStud.Text = "Количество студентов";
            // 
            // numericUpDown_CountSubject
            // 
            this.numericUpDown_CountSubject.Location = new System.Drawing.Point(516, 6);
            this.numericUpDown_CountSubject.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_CountSubject.Name = "numericUpDown_CountSubject";
            this.numericUpDown_CountSubject.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown_CountSubject.TabIndex = 5;
            this.numericUpDown_CountSubject.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_CountSubject.ValueChanged += new System.EventHandler(this.numericUpDown_CountSubject_ValueChanged);
            // 
            // numericUpDown_CountStud
            // 
            this.numericUpDown_CountStud.Location = new System.Drawing.Point(196, 6);
            this.numericUpDown_CountStud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_CountStud.Name = "numericUpDown_CountStud";
            this.numericUpDown_CountStud.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown_CountStud.TabIndex = 4;
            this.numericUpDown_CountStud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_CountStud.ValueChanged += new System.EventHandler(this.numericUpDown_CountStud_ValueChanged);
            // 
            // button_AddByHand
            // 
            this.button_AddByHand.Location = new System.Drawing.Point(451, 314);
            this.button_AddByHand.Name = "button_AddByHand";
            this.button_AddByHand.Size = new System.Drawing.Size(179, 54);
            this.button_AddByHand.TabIndex = 3;
            this.button_AddByHand.Text = "Добавить вручную";
            this.button_AddByHand.UseVisualStyleBackColor = true;
            this.button_AddByHand.Click += new System.EventHandler(this.button_AddByHand_Click);
            // 
            // button_ReadFile
            // 
            this.button_ReadFile.Location = new System.Drawing.Point(233, 314);
            this.button_ReadFile.Name = "button_ReadFile";
            this.button_ReadFile.Size = new System.Drawing.Size(179, 54);
            this.button_ReadFile.TabIndex = 2;
            this.button_ReadFile.Text = "Читать из файла";
            this.button_ReadFile.UseVisualStyleBackColor = true;
            this.button_ReadFile.Click += new System.EventHandler(this.button_ReadFile_Click);
            // 
            // button_RandomGeneration
            // 
            this.button_RandomGeneration.Location = new System.Drawing.Point(18, 314);
            this.button_RandomGeneration.Name = "button_RandomGeneration";
            this.button_RandomGeneration.Size = new System.Drawing.Size(179, 54);
            this.button_RandomGeneration.TabIndex = 1;
            this.button_RandomGeneration.Text = "Случайная генерация";
            this.button_RandomGeneration.UseVisualStyleBackColor = true;
            this.button_RandomGeneration.Click += new System.EventHandler(this.button_RandomGeneration_Click);
            // 
            // dataGridView_Statement
            // 
            this.dataGridView_Statement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Statement.Location = new System.Drawing.Point(6, 34);
            this.dataGridView_Statement.Name = "dataGridView_Statement";
            this.dataGridView_Statement.Size = new System.Drawing.Size(640, 254);
            this.dataGridView_Statement.TabIndex = 0;
            // 
            // tabPage_StatisticStudent
            // 
            this.tabPage_StatisticStudent.Controls.Add(this.dataGridView2);
            this.tabPage_StatisticStudent.Location = new System.Drawing.Point(4, 22);
            this.tabPage_StatisticStudent.Name = "tabPage_StatisticStudent";
            this.tabPage_StatisticStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_StatisticStudent.Size = new System.Drawing.Size(652, 393);
            this.tabPage_StatisticStudent.TabIndex = 1;
            this.tabPage_StatisticStudent.Text = "Статистика по студентам";
            this.tabPage_StatisticStudent.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(640, 299);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage_StatisticsSubject
            // 
            this.tabPage_StatisticsSubject.Controls.Add(this.dataGridView3);
            this.tabPage_StatisticsSubject.Location = new System.Drawing.Point(4, 22);
            this.tabPage_StatisticsSubject.Name = "tabPage_StatisticsSubject";
            this.tabPage_StatisticsSubject.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_StatisticsSubject.Size = new System.Drawing.Size(652, 393);
            this.tabPage_StatisticsSubject.TabIndex = 2;
            this.tabPage_StatisticsSubject.Text = "Статистика по предеметам";
            this.tabPage_StatisticsSubject.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(640, 299);
            this.dataGridView3.TabIndex = 1;
            // 
            // tabPage_Scholarship_Debts
            // 
            this.tabPage_Scholarship_Debts.Controls.Add(this.listBox2);
            this.tabPage_Scholarship_Debts.Controls.Add(this.listBox1);
            this.tabPage_Scholarship_Debts.Controls.Add(this.label3);
            this.tabPage_Scholarship_Debts.Controls.Add(this.label4);
            this.tabPage_Scholarship_Debts.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Scholarship_Debts.Name = "tabPage_Scholarship_Debts";
            this.tabPage_Scholarship_Debts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Scholarship_Debts.Size = new System.Drawing.Size(652, 393);
            this.tabPage_Scholarship_Debts.TabIndex = 3;
            this.tabPage_Scholarship_Debts.Text = "Степендии/Долги";
            this.tabPage_Scholarship_Debts.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(413, 71);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(139, 199);
            this.listBox2.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(101, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 199);
            this.listBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // tabPage_Progress_Quality
            // 
            this.tabPage_Progress_Quality.Controls.Add(this.chart2);
            this.tabPage_Progress_Quality.Controls.Add(this.chart1);
            this.tabPage_Progress_Quality.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Progress_Quality.Name = "tabPage_Progress_Quality";
            this.tabPage_Progress_Quality.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Progress_Quality.Size = new System.Drawing.Size(652, 393);
            this.tabPage_Progress_Quality.TabIndex = 4;
            this.tabPage_Progress_Quality.Text = "Успеваемость/Качество";
            this.tabPage_Progress_Quality.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(346, 24);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(6, 21);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // textBox_CellSubject
            // 
            this.textBox_CellSubject.Location = new System.Drawing.Point(34, 463);
            this.textBox_CellSubject.Name = "textBox_CellSubject";
            this.textBox_CellSubject.Size = new System.Drawing.Size(179, 20);
            this.textBox_CellSubject.TabIndex = 1;
            // 
            // textBox_CellPerson
            // 
            this.textBox_CellPerson.Location = new System.Drawing.Point(34, 517);
            this.textBox_CellPerson.Name = "textBox_CellPerson";
            this.textBox_CellPerson.Size = new System.Drawing.Size(179, 20);
            this.textBox_CellPerson.TabIndex = 2;
            // 
            // button_AddSubject
            // 
            this.button_AddSubject.Location = new System.Drawing.Point(249, 448);
            this.button_AddSubject.Name = "button_AddSubject";
            this.button_AddSubject.Size = new System.Drawing.Size(126, 35);
            this.button_AddSubject.TabIndex = 3;
            this.button_AddSubject.Text = "Добавить предмет";
            this.button_AddSubject.UseVisualStyleBackColor = true;
            this.button_AddSubject.Click += new System.EventHandler(this.button_AddSubject_Click);
            // 
            // button_RemoveSubject
            // 
            this.button_RemoveSubject.Location = new System.Drawing.Point(407, 448);
            this.button_RemoveSubject.Name = "button_RemoveSubject";
            this.button_RemoveSubject.Size = new System.Drawing.Size(126, 35);
            this.button_RemoveSubject.TabIndex = 4;
            this.button_RemoveSubject.Text = "Убрать предмет";
            this.button_RemoveSubject.UseVisualStyleBackColor = true;
            this.button_RemoveSubject.Click += new System.EventHandler(this.button_RemoveSubject_Click);
            // 
            // button_AddPerson
            // 
            this.button_AddPerson.Location = new System.Drawing.Point(249, 502);
            this.button_AddPerson.Name = "button_AddPerson";
            this.button_AddPerson.Size = new System.Drawing.Size(126, 35);
            this.button_AddPerson.TabIndex = 5;
            this.button_AddPerson.Text = "Добавить человека";
            this.button_AddPerson.UseVisualStyleBackColor = true;
            // 
            // button_RemovePerson
            // 
            this.button_RemovePerson.Location = new System.Drawing.Point(407, 502);
            this.button_RemovePerson.Name = "button_RemovePerson";
            this.button_RemovePerson.Size = new System.Drawing.Size(126, 35);
            this.button_RemovePerson.TabIndex = 6;
            this.button_RemovePerson.Text = "Убрать человека";
            this.button_RemovePerson.UseVisualStyleBackColor = true;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(559, 448);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(87, 89);
            this.button_Reset.TabIndex = 7;
            this.button_Reset.Text = "Cброс значений";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_RemovePerson);
            this.Controls.Add(this.button_AddPerson);
            this.Controls.Add(this.button_RemoveSubject);
            this.Controls.Add(this.button_AddSubject);
            this.Controls.Add(this.textBox_CellPerson);
            this.Controls.Add(this.textBox_CellSubject);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Ведомость";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Statement.ResumeLayout(false);
            this.tabPage_Statement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CountSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CountStud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Statement)).EndInit();
            this.tabPage_StatisticStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage_StatisticsSubject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage_Scholarship_Debts.ResumeLayout(false);
            this.tabPage_Scholarship_Debts.PerformLayout();
            this.tabPage_Progress_Quality.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Statement;
        private System.Windows.Forms.TabPage tabPage_StatisticStudent;
        private System.Windows.Forms.TabPage tabPage_StatisticsSubject;
        private System.Windows.Forms.TabPage tabPage_Scholarship_Debts;
        private System.Windows.Forms.TabPage tabPage_Progress_Quality;
        private System.Windows.Forms.Label label_Count_Subject;
        private System.Windows.Forms.Label label_CountStud;
        private System.Windows.Forms.NumericUpDown numericUpDown_CountSubject;
        private System.Windows.Forms.NumericUpDown numericUpDown_CountStud;
        private System.Windows.Forms.Button button_AddByHand;
        private System.Windows.Forms.Button button_ReadFile;
        private System.Windows.Forms.Button button_RandomGeneration;
        private System.Windows.Forms.DataGridView dataGridView_Statement;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox_CellSubject;
        private System.Windows.Forms.TextBox textBox_CellPerson;
        private System.Windows.Forms.Button button_AddSubject;
        private System.Windows.Forms.Button button_RemoveSubject;
        private System.Windows.Forms.Button button_AddPerson;
        private System.Windows.Forms.Button button_RemovePerson;
        private System.Windows.Forms.Button button_Reset;
    }
}

