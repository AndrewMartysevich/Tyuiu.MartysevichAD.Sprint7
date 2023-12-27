
namespace Project.V4
{
    partial class FormBooks
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBooks));
            this.buttonIn_MAD = new System.Windows.Forms.Button();
            this.buttonOut_MAD = new System.Windows.Forms.Button();
            this.toolTip_MAD = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_MAD = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView_MAD = new System.Windows.Forms.DataGridView();
            this.saveFileDialog_MAD = new System.Windows.Forms.SaveFileDialog();
            this.buttonInf_MAD = new System.Windows.Forms.Button();
            this.groupBoxSearch_MAD = new System.Windows.Forms.GroupBox();
            this.buttonCancel_MAD = new System.Windows.Forms.Button();
            this.textBoxSearcch_MAD = new System.Windows.Forms.TextBox();
            this.textBoxSea_MAD = new System.Windows.Forms.TextBox();
            this.buttonCount_MAD = new System.Windows.Forms.Button();
            this.textBoxSum_MAD = new System.Windows.Forms.TextBox();
            this.buttonExit_MAD = new System.Windows.Forms.Button();
            this.buttonSort_MAD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MAD)).BeginInit();
            this.groupBoxSearch_MAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonIn_MAD
            // 
            this.buttonIn_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonIn_MAD.Image = ((System.Drawing.Image)(resources.GetObject("buttonIn_MAD.Image")));
            this.buttonIn_MAD.Location = new System.Drawing.Point(13, 13);
            this.buttonIn_MAD.Name = "buttonIn_MAD";
            this.buttonIn_MAD.Size = new System.Drawing.Size(101, 90);
            this.buttonIn_MAD.TabIndex = 0;
            this.buttonIn_MAD.UseVisualStyleBackColor = false;
            this.buttonIn_MAD.Click += new System.EventHandler(this.buttonIn_MAD_Click);
            this.buttonIn_MAD.MouseEnter += new System.EventHandler(this.buttonIn_MAD_MouseEnter);
            // 
            // buttonOut_MAD
            // 
            this.buttonOut_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonOut_MAD.Enabled = false;
            this.buttonOut_MAD.Image = ((System.Drawing.Image)(resources.GetObject("buttonOut_MAD.Image")));
            this.buttonOut_MAD.Location = new System.Drawing.Point(130, 12);
            this.buttonOut_MAD.Name = "buttonOut_MAD";
            this.buttonOut_MAD.Size = new System.Drawing.Size(103, 90);
            this.buttonOut_MAD.TabIndex = 1;
            this.buttonOut_MAD.UseVisualStyleBackColor = false;
            this.buttonOut_MAD.Click += new System.EventHandler(this.buttonOut_MAD_Click);
            this.buttonOut_MAD.MouseEnter += new System.EventHandler(this.buttonOut_MAD_MouseEnter);
            // 
            // toolTip_MAD
            // 
            this.toolTip_MAD.IsBalloon = true;
            this.toolTip_MAD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_MAD.ToolTipTitle = "Подсказка";
            this.toolTip_MAD.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip_MAD_Popup);
            // 
            // openFileDialog_MAD
            // 
            this.openFileDialog_MAD.FileName = "openFileDialog1";
            // 
            // dataGridView_MAD
            // 
            this.dataGridView_MAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MAD.Location = new System.Drawing.Point(13, 110);
            this.dataGridView_MAD.Name = "dataGridView_MAD";
            this.dataGridView_MAD.RowHeadersWidth = 51;
            this.dataGridView_MAD.RowTemplate.Height = 24;
            this.dataGridView_MAD.Size = new System.Drawing.Size(894, 399);
            this.dataGridView_MAD.TabIndex = 2;
            // 
            // buttonInf_MAD
            // 
            this.buttonInf_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonInf_MAD.Image = ((System.Drawing.Image)(resources.GetObject("buttonInf_MAD.Image")));
            this.buttonInf_MAD.Location = new System.Drawing.Point(798, 16);
            this.buttonInf_MAD.Name = "buttonInf_MAD";
            this.buttonInf_MAD.Size = new System.Drawing.Size(109, 76);
            this.buttonInf_MAD.TabIndex = 3;
            this.buttonInf_MAD.UseVisualStyleBackColor = false;
            this.buttonInf_MAD.Click += new System.EventHandler(this.buttonInf_MAD_Click);
            this.buttonInf_MAD.MouseEnter += new System.EventHandler(this.buttonInf_MAD_MouseEnter);
            // 
            // groupBoxSearch_MAD
            // 
            this.groupBoxSearch_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBoxSearch_MAD.Controls.Add(this.buttonCancel_MAD);
            this.groupBoxSearch_MAD.Controls.Add(this.textBoxSearcch_MAD);
            this.groupBoxSearch_MAD.Controls.Add(this.textBoxSea_MAD);
            this.groupBoxSearch_MAD.Location = new System.Drawing.Point(261, 13);
            this.groupBoxSearch_MAD.Name = "groupBoxSearch_MAD";
            this.groupBoxSearch_MAD.Size = new System.Drawing.Size(266, 91);
            this.groupBoxSearch_MAD.TabIndex = 4;
            this.groupBoxSearch_MAD.TabStop = false;
            this.groupBoxSearch_MAD.Text = "Поиск";
            // 
            // buttonCancel_MAD
            // 
            this.buttonCancel_MAD.BackColor = System.Drawing.Color.Red;
            this.buttonCancel_MAD.Location = new System.Drawing.Point(137, 45);
            this.buttonCancel_MAD.Name = "buttonCancel_MAD";
            this.buttonCancel_MAD.Size = new System.Drawing.Size(87, 34);
            this.buttonCancel_MAD.TabIndex = 2;
            this.buttonCancel_MAD.Text = "Очистить";
            this.buttonCancel_MAD.UseVisualStyleBackColor = false;
            this.buttonCancel_MAD.Click += new System.EventHandler(this.buttonCancel_MAD_Click);
            // 
            // textBoxSearcch_MAD
            // 
            this.textBoxSearcch_MAD.Location = new System.Drawing.Point(7, 51);
            this.textBoxSearcch_MAD.Name = "textBoxSearcch_MAD";
            this.textBoxSearcch_MAD.Size = new System.Drawing.Size(100, 22);
            this.textBoxSearcch_MAD.TabIndex = 1;
            this.textBoxSearcch_MAD.TextChanged += new System.EventHandler(this.textBoxSearcch_MAD_TextChanged);
            // 
            // textBoxSea_MAD
            // 
            this.textBoxSea_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxSea_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSea_MAD.Location = new System.Drawing.Point(7, 22);
            this.textBoxSea_MAD.Multiline = true;
            this.textBoxSea_MAD.Name = "textBoxSea_MAD";
            this.textBoxSea_MAD.ReadOnly = true;
            this.textBoxSea_MAD.Size = new System.Drawing.Size(187, 22);
            this.textBoxSea_MAD.TabIndex = 0;
            this.textBoxSea_MAD.Text = "Введите данные для поиска";
            // 
            // buttonCount_MAD
            // 
            this.buttonCount_MAD.Location = new System.Drawing.Point(533, 12);
            this.buttonCount_MAD.Name = "buttonCount_MAD";
            this.buttonCount_MAD.Size = new System.Drawing.Size(160, 23);
            this.buttonCount_MAD.TabIndex = 5;
            this.buttonCount_MAD.Text = "Количество Книг";
            this.buttonCount_MAD.UseVisualStyleBackColor = true;
            this.buttonCount_MAD.Click += new System.EventHandler(this.buttonSum_MAD_Click);
            // 
            // textBoxSum_MAD
            // 
            this.textBoxSum_MAD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxSum_MAD.Location = new System.Drawing.Point(559, 41);
            this.textBoxSum_MAD.Name = "textBoxSum_MAD";
            this.textBoxSum_MAD.ReadOnly = true;
            this.textBoxSum_MAD.Size = new System.Drawing.Size(100, 22);
            this.textBoxSum_MAD.TabIndex = 6;
            this.textBoxSum_MAD.TextChanged += new System.EventHandler(this.textBoxSum_MAD_TextChanged);
            // 
            // buttonExit_MAD
            // 
            this.buttonExit_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonExit_MAD.Location = new System.Drawing.Point(923, 16);
            this.buttonExit_MAD.Name = "buttonExit_MAD";
            this.buttonExit_MAD.Size = new System.Drawing.Size(108, 76);
            this.buttonExit_MAD.TabIndex = 7;
            this.buttonExit_MAD.Text = "Вернуться";
            this.buttonExit_MAD.UseVisualStyleBackColor = false;
            this.buttonExit_MAD.Click += new System.EventHandler(this.buttonExit_MAD_Click);
            // 
            // buttonSort_MAD
            // 
            this.buttonSort_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSort_MAD.Location = new System.Drawing.Point(922, 110);
            this.buttonSort_MAD.Name = "buttonSort_MAD";
            this.buttonSort_MAD.Size = new System.Drawing.Size(118, 51);
            this.buttonSort_MAD.TabIndex = 8;
            this.buttonSort_MAD.Text = "Сортировать по году";
            this.buttonSort_MAD.UseVisualStyleBackColor = false;
            this.buttonSort_MAD.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 513);
            this.Controls.Add(this.buttonSort_MAD);
            this.Controls.Add(this.buttonExit_MAD);
            this.Controls.Add(this.textBoxSum_MAD);
            this.Controls.Add(this.buttonCount_MAD);
            this.Controls.Add(this.groupBoxSearch_MAD);
            this.Controls.Add(this.buttonInf_MAD);
            this.Controls.Add(this.dataGridView_MAD);
            this.Controls.Add(this.buttonOut_MAD);
            this.Controls.Add(this.buttonIn_MAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книги";
            this.Load += new System.EventHandler(this.FormBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MAD)).EndInit();
            this.groupBoxSearch_MAD.ResumeLayout(false);
            this.groupBoxSearch_MAD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIn_MAD;
        private System.Windows.Forms.Button buttonOut_MAD;
        private System.Windows.Forms.ToolTip toolTip_MAD;
        private System.Windows.Forms.OpenFileDialog openFileDialog_MAD;
        private System.Windows.Forms.DataGridView dataGridView_MAD;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_MAD;
        private System.Windows.Forms.Button buttonInf_MAD;
        private System.Windows.Forms.GroupBox groupBoxSearch_MAD;
        private System.Windows.Forms.TextBox textBoxSearcch_MAD;
        private System.Windows.Forms.TextBox textBoxSea_MAD;
        private System.Windows.Forms.Button buttonCancel_MAD;
        private System.Windows.Forms.Button buttonCount_MAD;
        private System.Windows.Forms.TextBox textBoxSum_MAD;
        private System.Windows.Forms.Button buttonExit_MAD;
        private System.Windows.Forms.Button buttonSort_MAD;
    }
}