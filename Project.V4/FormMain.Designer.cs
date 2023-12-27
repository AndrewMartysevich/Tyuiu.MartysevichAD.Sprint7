
namespace Project.V4
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel_MAD = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTitle_MAD = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelCentre_MAD = new System.Windows.Forms.Panel();
            this.buttonExit_MAD = new System.Windows.Forms.Button();
            this.buttonInf_MAD = new System.Windows.Forms.Button();
            this.buttonDo_MAD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelCentre_MAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MAD
            // 
            this.panel_MAD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_MAD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_MAD.BackgroundImage")));
            this.panel_MAD.Location = new System.Drawing.Point(12, 16);
            this.panel_MAD.Name = "panel_MAD";
            this.panel_MAD.Size = new System.Drawing.Size(177, 516);
            this.panel_MAD.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxTitle_MAD);
            this.panel1.Location = new System.Drawing.Point(195, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 100);
            this.panel1.TabIndex = 2;
            // 
            // textBoxTitle_MAD
            // 
            this.textBoxTitle_MAD.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxTitle_MAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitle_MAD.ForeColor = System.Drawing.Color.OldLace;
            this.textBoxTitle_MAD.Location = new System.Drawing.Point(4, 4);
            this.textBoxTitle_MAD.Multiline = true;
            this.textBoxTitle_MAD.Name = "textBoxTitle_MAD";
            this.textBoxTitle_MAD.ReadOnly = true;
            this.textBoxTitle_MAD.Size = new System.Drawing.Size(744, 93);
            this.textBoxTitle_MAD.TabIndex = 0;
            this.textBoxTitle_MAD.Text = "    БИБЛИОТЕКА";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 544);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 544);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // panelCentre_MAD
            // 
            this.panelCentre_MAD.Controls.Add(this.buttonExit_MAD);
            this.panelCentre_MAD.Controls.Add(this.buttonInf_MAD);
            this.panelCentre_MAD.Controls.Add(this.buttonDo_MAD);
            this.panelCentre_MAD.Location = new System.Drawing.Point(195, 118);
            this.panelCentre_MAD.Name = "panelCentre_MAD";
            this.panelCentre_MAD.Size = new System.Drawing.Size(751, 414);
            this.panelCentre_MAD.TabIndex = 5;
            // 
            // buttonExit_MAD
            // 
            this.buttonExit_MAD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit_MAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit_MAD.Location = new System.Drawing.Point(230, 311);
            this.buttonExit_MAD.Name = "buttonExit_MAD";
            this.buttonExit_MAD.Size = new System.Drawing.Size(268, 57);
            this.buttonExit_MAD.TabIndex = 0;
            this.buttonExit_MAD.Text = "Выход";
            this.buttonExit_MAD.UseVisualStyleBackColor = false;
            this.buttonExit_MAD.Click += new System.EventHandler(this.buttonExit_MAD_Click);
            this.buttonExit_MAD.MouseEnter += new System.EventHandler(this.buttonExit_MAD_MouseEnter);
            this.buttonExit_MAD.MouseLeave += new System.EventHandler(this.buttonExit_MAD_MouseLeave);
            // 
            // buttonInf_MAD
            // 
            this.buttonInf_MAD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInf_MAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInf_MAD.Location = new System.Drawing.Point(229, 153);
            this.buttonInf_MAD.Name = "buttonInf_MAD";
            this.buttonInf_MAD.Size = new System.Drawing.Size(268, 57);
            this.buttonInf_MAD.TabIndex = 0;
            this.buttonInf_MAD.Text = "Информация";
            this.buttonInf_MAD.UseVisualStyleBackColor = false;
            this.buttonInf_MAD.Click += new System.EventHandler(this.buttonInf_MAD_Click);
            this.buttonInf_MAD.MouseEnter += new System.EventHandler(this.buttonInf_MAD_MouseEnter);
            this.buttonInf_MAD.MouseLeave += new System.EventHandler(this.buttonInf_MAD_MouseLeave);
            // 
            // buttonDo_MAD
            // 
            this.buttonDo_MAD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDo_MAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDo_MAD.Location = new System.Drawing.Point(229, 50);
            this.buttonDo_MAD.Name = "buttonDo_MAD";
            this.buttonDo_MAD.Size = new System.Drawing.Size(268, 57);
            this.buttonDo_MAD.TabIndex = 0;
            this.buttonDo_MAD.Text = "Книги";
            this.buttonDo_MAD.UseVisualStyleBackColor = false;
            this.buttonDo_MAD.Click += new System.EventHandler(this.button1_Click);
            this.buttonDo_MAD.MouseEnter += new System.EventHandler(this.buttonDo_MAD_MouseEnter);
            this.buttonDo_MAD.MouseLeave += new System.EventHandler(this.buttonDo_MAD_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 544);
            this.Controls.Add(this.panelCentre_MAD);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_MAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "БИБЛИОТЕКА";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCentre_MAD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_MAD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTitle_MAD;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panelCentre_MAD;
        private System.Windows.Forms.Button buttonExit_MAD;
        private System.Windows.Forms.Button buttonInf_MAD;
        private System.Windows.Forms.Button buttonDo_MAD;
    }
}