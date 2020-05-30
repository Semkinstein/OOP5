namespace OOP5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hoverButtonRound1 = new OOP5.HoverButtonRound();
            this.hoverButton1 = new OOP5.HoverButton();
            this.SuspendLayout();
            // 
            // hoverButtonRound1
            // 
            this.hoverButtonRound1.BackColor = System.Drawing.Color.Black;
            this.hoverButtonRound1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButtonRound1.ForeColor = System.Drawing.Color.White;
            this.hoverButtonRound1.Image = ((System.Drawing.Image)(resources.GetObject("hoverButtonRound1.Image")));
            this.hoverButtonRound1.Location = new System.Drawing.Point(598, 12);
            this.hoverButtonRound1.Name = "hoverButtonRound1";
            this.hoverButtonRound1.Size = new System.Drawing.Size(539, 511);
            this.hoverButtonRound1.TabIndex = 1;
            this.hoverButtonRound1.Text = "hoverButtonRound1";
            this.hoverButtonRound1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hoverButtonRound1.UseVisualStyleBackColor = false;
            // 
            // hoverButton1
            // 
            this.hoverButton1.BackColor = System.Drawing.Color.Black;
            this.hoverButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButton1.ForeColor = System.Drawing.Color.White;
            this.hoverButton1.Image = ((System.Drawing.Image)(resources.GetObject("hoverButton1.Image")));
            this.hoverButton1.Location = new System.Drawing.Point(12, 12);
            this.hoverButton1.Name = "hoverButton1";
            this.hoverButton1.Size = new System.Drawing.Size(543, 511);
            this.hoverButton1.TabIndex = 0;
            this.hoverButton1.Text = "hoverButton1";
            this.hoverButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hoverButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 545);
            this.Controls.Add(this.hoverButtonRound1);
            this.Controls.Add(this.hoverButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private HoverButton hoverButton1;
        private HoverButtonRound hoverButtonRound1;

        
    }
}

