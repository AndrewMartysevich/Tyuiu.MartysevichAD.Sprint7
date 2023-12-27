using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Lib;


namespace Project.V4
{
    
    public partial class FormBooks : Form
    {
        static int rows;
        public string path;
        static int cost;
        DataService ds = new DataService();
        static int columns;
        static string openFilePath;
        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');

            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];


            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = line_r[j];
                }
            }
            return arrayValues;
        }   
        public FormBooks()
        {
            InitializeComponent();
        }

        private void buttonOut_MAD_Click(object sender, EventArgs e)
        {
            saveFileDialog_MAD.FileName = "OutPutFile.csv";
            saveFileDialog_MAD.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_MAD.ShowDialog();

            string path = saveFileDialog_MAD.FileName;

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridView_MAD.RowCount;
            int columns = dataGridView_MAD.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridView_MAD.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridView_MAD.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonIn_MAD_Click(object sender, EventArgs e)
        {
            openFileDialog_MAD.ShowDialog();
            openFilePath = openFileDialog_MAD.FileName;
            path = openFileDialog_MAD.FileName; 

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridView_MAD.ColumnCount = columns;
            dataGridView_MAD.RowCount = rows;
            

            for (int i = 0; i < columns; i++)
            {
                dataGridView_MAD.Columns[i].Width = 100;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridView_MAD.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

           // arrayValues = ds.GetMatrix(openFilePath);
            buttonOut_MAD.Enabled = true;
        }

        private void FormBooks_Load(object sender, EventArgs e)
        {
            dataGridView_MAD.ColumnCount = 50;            
            dataGridView_MAD.RowCount = 50;                     
            for (int i = 0; i < 50; i++)
            {
                dataGridView_MAD.Columns[i].Width = 25;               
            }
        }

        private void buttonInf_MAD_Click(object sender, EventArgs e)
        {
            FormGuid formGuid = new FormGuid();
            formGuid.ShowDialog();
        }

        private void textBoxSearcch_MAD_TextChanged(object sender, EventArgs e)
        {
            
                try
                {
                    string searchValue = textBoxSearcch_MAD.Text.ToLower();

                    foreach (DataGridViewRow row in dataGridView_MAD.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue))
                            {
                                cell.Style.BackColor = Color.Yellow; // цвет  найденной ячейки
                            }
                            else
                            {
                                cell.Style.BackColor = Color.White; // цвета по умолчанию
                            }
                        }
                    }
                }

                catch
                {
                    MessageBox.Show("Что-то пошло не так, попробуйте снова", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void buttonCancel_MAD_Click(object sender, EventArgs e)
        {
            textBoxSearcch_MAD.Text = null;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView_MAD.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }
   
        private void buttonSum_MAD_Click(object sender, EventArgs e)
        {
            textBoxSum_MAD.Text = Convert.ToString(ds.BookCount(path, cost));
        }

        private void textBoxSum_MAD_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMax_MAD_Click(object sender, EventArgs e)
        {
            
            
        }

        private void buttonMin_MAD_Click(object sender, EventArgs e)
        {
            
        }
    }
}
