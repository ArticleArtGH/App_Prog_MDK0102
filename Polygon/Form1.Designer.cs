namespace Polygon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown_AmountTop = new System.Windows.Forms.NumericUpDown();
            this.trackBar_Radius = new System.Windows.Forms.TrackBar();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Draw = new System.Windows.Forms.Button();
            this.numericUpDown_Rotate = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Rotate = new System.Windows.Forms.CheckBox();
            this.checkBox_ConnectTop = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_Mono = new System.Windows.Forms.PictureBox();
            this.label_Depth = new System.Windows.Forms.Label();
            this.trackBar_Depth = new System.Windows.Forms.TrackBar();
            this.radioButton_Color = new System.Windows.Forms.RadioButton();
            this.radioButton_Mono = new System.Windows.Forms.RadioButton();
            this.label_Radius = new System.Windows.Forms.Label();
            this.label_AmountTop = new System.Windows.Forms.Label();
            this.pictureBox_Polygon = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AmountTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rotate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Polygon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.numericUpDown_AmountTop);
            this.panel1.Controls.Add(this.trackBar_Radius);
            this.panel1.Controls.Add(this.button_Clear);
            this.panel1.Controls.Add(this.button_Draw);
            this.panel1.Controls.Add(this.numericUpDown_Rotate);
            this.panel1.Controls.Add(this.checkBox_Rotate);
            this.panel1.Controls.Add(this.checkBox_ConnectTop);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label_Radius);
            this.panel1.Controls.Add(this.label_AmountTop);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 488);
            this.panel1.TabIndex = 0;
            // 
            // numericUpDown_AmountTop
            // 
            this.numericUpDown_AmountTop.Location = new System.Drawing.Point(148, 9);
            this.numericUpDown_AmountTop.Name = "numericUpDown_AmountTop";
            this.numericUpDown_AmountTop.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown_AmountTop.TabIndex = 9;
            // 
            // trackBar_Radius
            // 
            this.trackBar_Radius.Location = new System.Drawing.Point(117, 35);
            this.trackBar_Radius.Maximum = 240;
            this.trackBar_Radius.MaximumSize = new System.Drawing.Size(100, 100);
            this.trackBar_Radius.Minimum = 1;
            this.trackBar_Radius.MinimumSize = new System.Drawing.Size(1, 1);
            this.trackBar_Radius.Name = "trackBar_Radius";
            this.trackBar_Radius.Size = new System.Drawing.Size(100, 45);
            this.trackBar_Radius.TabIndex = 8;
            this.trackBar_Radius.TickFrequency = 5;
            this.trackBar_Radius.Value = 100;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(9, 395);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(216, 65);
            this.button_Clear.TabIndex = 7;
            this.button_Clear.Text = "Очистить";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Draw
            // 
            this.button_Draw.Location = new System.Drawing.Point(9, 324);
            this.button_Draw.Name = "button_Draw";
            this.button_Draw.Size = new System.Drawing.Size(216, 65);
            this.button_Draw.TabIndex = 6;
            this.button_Draw.Text = "Рисовать";
            this.button_Draw.UseVisualStyleBackColor = true;
            this.button_Draw.Click += new System.EventHandler(this.button_Draw_Click);
            // 
            // numericUpDown_Rotate
            // 
            this.numericUpDown_Rotate.Location = new System.Drawing.Point(109, 274);
            this.numericUpDown_Rotate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Rotate.Name = "numericUpDown_Rotate";
            this.numericUpDown_Rotate.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Rotate.TabIndex = 5;
            // 
            // checkBox_Rotate
            // 
            this.checkBox_Rotate.AutoSize = true;
            this.checkBox_Rotate.Location = new System.Drawing.Point(13, 274);
            this.checkBox_Rotate.Name = "checkBox_Rotate";
            this.checkBox_Rotate.Size = new System.Drawing.Size(71, 17);
            this.checkBox_Rotate.TabIndex = 4;
            this.checkBox_Rotate.Text = "Вращать";
            this.checkBox_Rotate.UseVisualStyleBackColor = true;
            this.checkBox_Rotate.CheckedChanged += new System.EventHandler(this.checkBox_Rotate_CheckedChanged);
            // 
            // checkBox_ConnectTop
            // 
            this.checkBox_ConnectTop.AutoSize = true;
            this.checkBox_ConnectTop.Location = new System.Drawing.Point(13, 241);
            this.checkBox_ConnectTop.Name = "checkBox_ConnectTop";
            this.checkBox_ConnectTop.Size = new System.Drawing.Size(129, 17);
            this.checkBox_ConnectTop.TabIndex = 3;
            this.checkBox_ConnectTop.Text = "Соединить вершины";
            this.checkBox_ConnectTop.UseVisualStyleBackColor = true;
            this.checkBox_ConnectTop.CheckedChanged += new System.EventHandler(this.checkBox_ConnectTop_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_Mono);
            this.groupBox1.Controls.Add(this.label_Depth);
            this.groupBox1.Controls.Add(this.trackBar_Depth);
            this.groupBox1.Controls.Add(this.radioButton_Color);
            this.groupBox1.Controls.Add(this.radioButton_Mono);
            this.groupBox1.Location = new System.Drawing.Point(3, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pen";
            // 
            // pictureBox_Mono
            // 
            this.pictureBox_Mono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Mono.Location = new System.Drawing.Point(118, 19);
            this.pictureBox_Mono.Name = "pictureBox_Mono";
            this.pictureBox_Mono.Size = new System.Drawing.Size(100, 26);
            this.pictureBox_Mono.TabIndex = 5;
            this.pictureBox_Mono.TabStop = false;
            this.pictureBox_Mono.Click += new System.EventHandler(this.pictureBox_Mono_Click);
            // 
            // label_Depth
            // 
            this.label_Depth.AutoSize = true;
            this.label_Depth.Location = new System.Drawing.Point(10, 105);
            this.label_Depth.Name = "label_Depth";
            this.label_Depth.Size = new System.Drawing.Size(53, 13);
            this.label_Depth.TabIndex = 4;
            this.label_Depth.Text = "Толщина";
            // 
            // trackBar_Depth
            // 
            this.trackBar_Depth.Location = new System.Drawing.Point(114, 87);
            this.trackBar_Depth.MaximumSize = new System.Drawing.Size(100, 100);
            this.trackBar_Depth.Minimum = 1;
            this.trackBar_Depth.MinimumSize = new System.Drawing.Size(1, 1);
            this.trackBar_Depth.Name = "trackBar_Depth";
            this.trackBar_Depth.Size = new System.Drawing.Size(100, 45);
            this.trackBar_Depth.TabIndex = 3;
            this.trackBar_Depth.Value = 5;
            // 
            // radioButton_Color
            // 
            this.radioButton_Color.AutoSize = true;
            this.radioButton_Color.Location = new System.Drawing.Point(13, 61);
            this.radioButton_Color.Name = "radioButton_Color";
            this.radioButton_Color.Size = new System.Drawing.Size(68, 17);
            this.radioButton_Color.TabIndex = 1;
            this.radioButton_Color.TabStop = true;
            this.radioButton_Color.Text = "Цветное";
            this.radioButton_Color.UseVisualStyleBackColor = true;
            // 
            // radioButton_Mono
            // 
            this.radioButton_Mono.AutoSize = true;
            this.radioButton_Mono.Location = new System.Drawing.Point(13, 28);
            this.radioButton_Mono.Name = "radioButton_Mono";
            this.radioButton_Mono.Size = new System.Drawing.Size(52, 17);
            this.radioButton_Mono.TabIndex = 0;
            this.radioButton_Mono.TabStop = true;
            this.radioButton_Mono.Text = "Моно";
            this.radioButton_Mono.UseVisualStyleBackColor = true;
            // 
            // label_Radius
            // 
            this.label_Radius.AutoSize = true;
            this.label_Radius.Location = new System.Drawing.Point(13, 55);
            this.label_Radius.Name = "label_Radius";
            this.label_Radius.Size = new System.Drawing.Size(43, 13);
            this.label_Radius.TabIndex = 1;
            this.label_Radius.Text = "Радиус";
            // 
            // label_AmountTop
            // 
            this.label_AmountTop.AutoSize = true;
            this.label_AmountTop.Location = new System.Drawing.Point(13, 20);
            this.label_AmountTop.Name = "label_AmountTop";
            this.label_AmountTop.Size = new System.Drawing.Size(82, 13);
            this.label_AmountTop.TabIndex = 0;
            this.label_AmountTop.Text = "Кол-во вершин";
            // 
            // pictureBox_Polygon
            // 
            this.pictureBox_Polygon.BackColor = System.Drawing.Color.White;
            this.pictureBox_Polygon.Location = new System.Drawing.Point(242, 0);
            this.pictureBox_Polygon.Name = "pictureBox_Polygon";
            this.pictureBox_Polygon.Size = new System.Drawing.Size(488, 488);
            this.pictureBox_Polygon.TabIndex = 1;
            this.pictureBox_Polygon.TabStop = false;
            this.pictureBox_Polygon.Click += new System.EventHandler(this.pictureBox_Polygon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 490);
            this.Controls.Add(this.pictureBox_Polygon);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AmountTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rotate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Polygon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_Rotate;
        private System.Windows.Forms.CheckBox checkBox_ConnectTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Depth;
        private System.Windows.Forms.TrackBar trackBar_Depth;
        private System.Windows.Forms.RadioButton radioButton_Color;
        private System.Windows.Forms.RadioButton radioButton_Mono;
        private System.Windows.Forms.Label label_Radius;
        private System.Windows.Forms.Label label_AmountTop;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Draw;
        private System.Windows.Forms.NumericUpDown numericUpDown_Rotate;
        private System.Windows.Forms.PictureBox pictureBox_Mono;
        private System.Windows.Forms.PictureBox pictureBox_Polygon;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown_AmountTop;
        private System.Windows.Forms.TrackBar trackBar_Radius;
    }
}

