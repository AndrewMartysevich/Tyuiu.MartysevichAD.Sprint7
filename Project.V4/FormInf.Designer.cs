
namespace Project.V4
{
    partial class FormInf
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
            this.buttonInf1_MAD = new System.Windows.Forms.Button();
            this.buttonInf3_MAD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInf1_MAD
            // 
            this.buttonInf1_MAD.Location = new System.Drawing.Point(147, 12);
            this.buttonInf1_MAD.Name = "buttonInf1_MAD";
            this.buttonInf1_MAD.Size = new System.Drawing.Size(225, 59);
            this.buttonInf1_MAD.TabIndex = 0;
            this.buttonInf1_MAD.Text = "Создатель";
            this.buttonInf1_MAD.UseVisualStyleBackColor = true;
            this.buttonInf1_MAD.Click += new System.EventHandler(this.buttonInf1_MAD_Click);
            this.buttonInf1_MAD.MouseEnter += new System.EventHandler(this.buttonInf1_MAD_MouseEnter);
            this.buttonInf1_MAD.MouseLeave += new System.EventHandler(this.buttonInf1_MAD_MouseLeave);
            // 
            // buttonInf3_MAD
            // 
            this.buttonInf3_MAD.Location = new System.Drawing.Point(147, 179);
            this.buttonInf3_MAD.Name = "buttonInf3_MAD";
            this.buttonInf3_MAD.Size = new System.Drawing.Size(225, 59);
            this.buttonInf3_MAD.TabIndex = 0;
            this.buttonInf3_MAD.Text = "Вернуться";
            this.buttonInf3_MAD.UseVisualStyleBackColor = true;
            this.buttonInf3_MAD.Click += new System.EventHandler(this.buttonInf3_MAD_Click);
            this.buttonInf3_MAD.MouseEnter += new System.EventHandler(this.buttonInf3_MAD_MouseEnter);
            this.buttonInf3_MAD.MouseLeave += new System.EventHandler(this.buttonInf3_MAD_MouseLeave);
            // 
            // FormInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 273);
            this.Controls.Add(this.buttonInf3_MAD);
            this.Controls.Add(this.buttonInf1_MAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInf1_MAD;
        private System.Windows.Forms.Button buttonInf3_MAD;
    }
}