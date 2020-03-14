namespace Clock_Paint
{
    partial class Form_Clock_Paint
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox_ClockPaint = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_ClockPaint = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ClockPaint)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_ClockPaint
            // 
            this.pictureBox_ClockPaint.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_ClockPaint.Name = "pictureBox_ClockPaint";
            this.pictureBox_ClockPaint.Size = new System.Drawing.Size(404, 404);
            this.pictureBox_ClockPaint.TabIndex = 0;
            this.pictureBox_ClockPaint.TabStop = false;
            this.pictureBox_ClockPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_ClockPaint_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(3, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Включить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(328, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выключить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(84, 435);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(80, 5, 80, 5);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(239, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Будильник";
            // 
            // timer_ClockPaint
            // 
            this.timer_ClockPaint.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Clock_Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox_ClockPaint);
            this.Name = "Form_Clock_Paint";
            this.Text = "Clock_Paint";
            this.Load += new System.EventHandler(this.Form_Clock_Paint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ClockPaint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ClockPaint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_ClockPaint;
    }
}

