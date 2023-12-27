
namespace Project.V4
{
    partial class FormGuid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuid));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonClose_MAD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(720, 178);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonClose_MAD
            // 
            this.buttonClose_MAD.Location = new System.Drawing.Point(753, 116);
            this.buttonClose_MAD.Name = "buttonClose_MAD";
            this.buttonClose_MAD.Size = new System.Drawing.Size(94, 74);
            this.buttonClose_MAD.TabIndex = 1;
            this.buttonClose_MAD.Text = "ОК";
            this.buttonClose_MAD.UseVisualStyleBackColor = true;
            this.buttonClose_MAD.Click += new System.EventHandler(this.buttonClose_MAD_Click);
            this.buttonClose_MAD.MouseEnter += new System.EventHandler(this.buttonClose_MAD_MouseEnter);
            this.buttonClose_MAD.MouseLeave += new System.EventHandler(this.buttonClose_MAD_MouseLeave);
            // 
            // FormGuid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(864, 211);
            this.Controls.Add(this.buttonClose_MAD);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormGuid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Краткое Руководство";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonClose_MAD;
    }
}