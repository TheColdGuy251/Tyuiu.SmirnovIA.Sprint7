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
using Tyuiu.SmirnovIA.Sprint7.Project.V14.Lib;


namespace Tyuiu.SmirnovIA.Sprint7.Project.V14
{
    public partial class FormMainAllVehicles_SIA : Form
    {
        public FormMainAllVehicles_SIA()
        {
            InitializeComponent();
            openFileDialogTable_SIA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogSaveTo_SIA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;
        static string[,] arrayValues;
        DataService ds = new DataService();
        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath, Encoding.GetEncoding(1251));
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            arrayValues = new string[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }

            return arrayValues;
        }
        private void buttonGoToVehicle_SIA_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddVehicle_SIA_Click(object sender, EventArgs e)
        {
            DataGridViewVehicles_SIA.Rows.Add();
            buttonGoToVehicle_SIA.Enabled = true;
            buttonEditVehicle_SIA.Enabled = true;
            buttonDeleteVehicle_SIA.Enabled = true;
            rows++;
            int newID;
            try
            {
                newID = Convert.ToInt32(DataGridViewVehicles_SIA.Rows[rows - 2].Cells[0].Value) + 1;
            }
            catch 
            {
                newID = 1;
            }
            DataGridViewVehicles_SIA.Rows[rows-1].Cells[0].Value = Convert.ToString(newID);
            DataGridViewVehicles_SIA.Rows[rows-1].Cells[1].ReadOnly = false;
            DataGridViewVehicles_SIA.Rows[rows-1].Cells[2].ReadOnly = false;
            DataGridViewVehicles_SIA.Rows[rows-1].Cells[3].ReadOnly = false;
        }

        private void buttonDeleteVehicle_SIA_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.DataGridViewVehicles_SIA.SelectedRows)
            {
                DataGridViewVehicles_SIA.Rows.RemoveAt(item.Index);
                rows--;
            }
            arrayValues = new string[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToString(DataGridViewVehicles_SIA.Rows[r].Cells[c].Value);

                }
            }
        }

        private void buttonEditVehicle_SIA_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewVehicles_SIA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ToolStripMenuItemOpen_SIA_Click(object sender, EventArgs e)
        {

            openFileDialogTable_SIA.ShowDialog();
            openFilePath = openFileDialogTable_SIA.FileName;

            arrayValues = LoadFromFileData(openFilePath);

            DataGridViewVehicles_SIA.ColumnCount = columns;
            DataGridViewVehicles_SIA.RowCount = rows;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    DataGridViewVehicles_SIA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonGoToVehicle_SIA.Enabled = true;
            buttonEditVehicle_SIA.Enabled = true;
            buttonDeleteVehicle_SIA.Enabled = true;
        }

        private void DataGridViewVehicles_SIA_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
