namespace Samples
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RunThreeBtn = new System.Windows.Forms.Button();
            this.RunFirstBtn = new System.Windows.Forms.Button();
            this.SecondRunBtn = new System.Windows.Forms.Button();
            this.runFourthBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunThreeBtn
            // 
            this.RunThreeBtn.Location = new System.Drawing.Point(12, 68);
            this.RunThreeBtn.Name = "RunThreeBtn";
            this.RunThreeBtn.Size = new System.Drawing.Size(75, 23);
            this.RunThreeBtn.TabIndex = 0;
            this.RunThreeBtn.Text = "Three";
            this.RunThreeBtn.UseVisualStyleBackColor = true;
            this.RunThreeBtn.Click += new System.EventHandler(this.RunFirstBtn_Click);
            // 
            // RunFirstBtn
            // 
            this.RunFirstBtn.Location = new System.Drawing.Point(12, 12);
            this.RunFirstBtn.Name = "RunFirstBtn";
            this.RunFirstBtn.Size = new System.Drawing.Size(75, 23);
            this.RunFirstBtn.TabIndex = 1;
            this.RunFirstBtn.Text = "First";
            this.RunFirstBtn.UseVisualStyleBackColor = true;
            this.RunFirstBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecondRunBtn
            // 
            this.SecondRunBtn.Location = new System.Drawing.Point(12, 39);
            this.SecondRunBtn.Name = "SecondRunBtn";
            this.SecondRunBtn.Size = new System.Drawing.Size(75, 23);
            this.SecondRunBtn.TabIndex = 2;
            this.SecondRunBtn.Text = "Second";
            this.SecondRunBtn.UseVisualStyleBackColor = true;
            this.SecondRunBtn.Click += new System.EventHandler(this.SecondRunBtnClick);
            // 
            // runFourthBtn
            // 
            this.runFourthBtn.Location = new System.Drawing.Point(12, 97);
            this.runFourthBtn.Name = "runFourthBtn";
            this.runFourthBtn.Size = new System.Drawing.Size(75, 23);
            this.runFourthBtn.TabIndex = 3;
            this.runFourthBtn.Text = "Fourth";
            this.runFourthBtn.UseVisualStyleBackColor = true;
            this.runFourthBtn.Click += new System.EventHandler(this.RunFourthBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 568);
            this.Controls.Add(this.runFourthBtn);
            this.Controls.Add(this.SecondRunBtn);
            this.Controls.Add(this.RunFirstBtn);
            this.Controls.Add(this.RunThreeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunThreeBtn;
        private System.Windows.Forms.Button RunFirstBtn;
        private System.Windows.Forms.Button SecondRunBtn;
        private System.Windows.Forms.Button runFourthBtn;
    }
}

