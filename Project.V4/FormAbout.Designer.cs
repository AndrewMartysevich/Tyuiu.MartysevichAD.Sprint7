
namespace Project.V4
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCr_MAD = new System.Windows.Forms.TextBox();
            this.buttonClose_MAD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCr_MAD
            // 
            this.textBoxCr_MAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCr_MAD.Location = new System.Drawing.Point(13, 13);
            this.textBoxCr_MAD.Multiline = true;
            this.textBoxCr_MAD.Name = "textBoxCr_MAD";
            this.textBoxCr_MAD.ReadOnly = true;
            this.textBoxCr_MAD.Size = new System.Drawing.Size(526, 178);
            this.textBoxCr_MAD.TabIndex = 0;
            this.textBoxCr_MAD.Text = "Разработчик : Мартысевич А.Д.\r\nГруппа ИИПб 23-3\r\n\r\nПрограмма разработана в рамках" +
    " изучения языка C#\r\n\r\nТюменский Индустриальный Университет(с)\r\nВысшая Школа Цифр" +
    "овых Технологий(с)";
            // 
            // buttonClose_MAD
            // 
            this.buttonClose_MAD.Location = new System.Drawing.Point(554, 125);
            this.buttonClose_MAD.Name = "buttonClose_MAD";
            this.buttonClose_MAD.Size = new System.Drawing.Size(87, 66);
            this.buttonClose_MAD.TabIndex = 1;
            this.buttonClose_MAD.Text = "ОК";
            this.buttonClose_MAD.UseVisualStyleBackColor = true;
            this.buttonClose_MAD.Click += new System.EventHandler(this.buttonClose_MAD_Click);
            this.buttonClose_MAD.MouseEnter += new System.EventHandler(this.buttonClose_MAD_MouseEnter);
            this.buttonClose_MAD.MouseLeave += new System.EventHandler(this.buttonClose_MAD_MouseLeave);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(648, 202);
            this.Controls.Add(this.buttonClose_MAD);
            this.Controls.Add(this.textBoxCr_MAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создатель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCr_MAD;
        private System.Windows.Forms.Button buttonClose_MAD;
    }
}