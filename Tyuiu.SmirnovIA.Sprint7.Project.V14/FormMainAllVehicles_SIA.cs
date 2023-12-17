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

        static int rows = 0;
        static int columns = 4;
        static string openFilePath = "";
        static string[,] arrayValues = new string[rows, columns];
        static int newID = 0;
        static bool wasTrue = false;
        static bool isSaved = true;
        DataService ds = new DataService();
        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath, Encoding.GetEncoding(1251));
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
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
            }
            catch 
            {
                rows = 0;
                columns = 4;
                arrayValues = new string[rows, columns];
            }
            

            return arrayValues;
        }

        private void Save()
        {

            FileInfo fileInfo = new FileInfo(openFilePath);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(openFilePath);
            }
            string str = "";
            dataGridViewVehicles_SIA.Sort(dataGridViewVehicles_SIA.Columns[0], ListSortDirection.Ascending);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewVehicles_SIA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewVehicles_SIA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(openFilePath, str + Environment.NewLine, Encoding.GetEncoding(1251));
                str = "";
            }
            isSaved = true;
        }

        private void UpdateTable()
        {
            dataGridViewVehicles_SIA.Rows.Clear();
            for (int r = 0; r < rows; r++)
            {
                dataGridViewVehicles_SIA.Rows.Add();
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewVehicles_SIA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
        }

        private void buttonGoToVehicle_SIA_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddVehicle_SIA_Click(object sender, EventArgs e)
        {
            dataGridViewVehicles_SIA.Rows.Add();
            buttonGoToVehicle_SIA.Enabled = true;
            buttonDeleteVehicle_SIA.Enabled = true;
            wasTrue = true;
            isSaved = false;
            rows++;

            for  (int i = 1; i < columns; i++)
            {
                dataGridViewVehicles_SIA.Rows[rows - 1].Cells[i].Value = "";
            }
            
            for (int i = 0;i < rows-1; i++)
            {
                newID = Math.Max(Convert.ToInt32(dataGridViewVehicles_SIA.Rows[i].Cells[0].Value), newID);
            }
            newID++;
            dataGridViewVehicles_SIA.Rows[rows-1].Cells[0].Value = Convert.ToString(newID);
            arrayValues = new string[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToString(dataGridViewVehicles_SIA.Rows[r].Cells[c].Value);

                }
            }
        }

        private void buttonDeleteVehicle_SIA_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить выбранные элементы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            isSaved = false;
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dataGridViewVehicles_SIA.SelectedRows)
                {
                    dataGridViewVehicles_SIA.Rows.RemoveAt(item.Index);
                    rows--;
                }
                arrayValues = new string[rows, columns];
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        arrayValues[r, c] = Convert.ToString(dataGridViewVehicles_SIA.Rows[r].Cells[c].Value);

                    }
                }
                newID = 0;
            }
        }
            

        private void DataGridViewVehicles_SIA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ToolStripMenuItemOpen_SIA_Click(object sender, EventArgs e)
        {

            openFileDialogTable_SIA.ShowDialog();
            openFilePath = openFileDialogTable_SIA.FileName;

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewVehicles_SIA.ColumnCount = columns;
            dataGridViewVehicles_SIA.RowCount = rows;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewVehicles_SIA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonGoToVehicle_SIA.Enabled = true;
            buttonDeleteVehicle_SIA.Enabled = true;
            wasTrue = true;
        }

        private void DataGridViewVehicles_SIA_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewVehicles_SIA.SelectedRows.Count > 1)
            {
                buttonGoToVehicle_SIA.Enabled = false;
            }
            else if (wasTrue)
            {
                buttonGoToVehicle_SIA.Enabled = true;
            }
        }

        private void ToolStripMenuItemSave_SIA_Click(object sender, EventArgs e)
        {
            if (openFilePath != "")
            {
                Save();
            }
            else
            {
                saveFileDialogSaveTo_SIA.FileName = "Транспорт.csv";
                saveFileDialogSaveTo_SIA.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogSaveTo_SIA.ShowDialog();

                openFilePath = saveFileDialogSaveTo_SIA.FileName;
                Save();
            }
        }

        private void ToolStripMenuItemSaveAs_SIA_Click(object sender, EventArgs e)
        {
            saveFileDialogSaveTo_SIA.FileName = "Транспорт.csv";
            saveFileDialogSaveTo_SIA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogSaveTo_SIA.ShowDialog();

            openFilePath = saveFileDialogSaveTo_SIA.FileName;
            Save();
        }

        private void dataGridViewVehicles_SIA_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 0 || e.Column.Index == 2)
            {
                e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                e.Handled = true;
            }

        }

        private void ToolStripMenuItemNewTable_SIA_Click(object sender, EventArgs e)
        {
            if (!isSaved) { 
            DialogResult dialogResult = MessageBox.Show("У вас есть несохранённые данные.\nСоздать новую таблицу? ", "Новая таблица", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                rows = 0;
                columns = 4;
                openFilePath = "";
                arrayValues = new string[rows, columns];
                newID = 0;
                dataGridViewVehicles_SIA.Rows.Clear();
                buttonGoToVehicle_SIA.Enabled = false;
                buttonDeleteVehicle_SIA.Enabled = false;
                wasTrue = false;
                isSaved = true;
            }
            }
            else
            {
                rows = 0;
                columns = 4;
                openFilePath = "";
                arrayValues = new string[rows, columns];
                newID = 0;
                dataGridViewVehicles_SIA.Rows.Clear();
                buttonGoToVehicle_SIA.Enabled = false;
                buttonDeleteVehicle_SIA.Enabled = false;
                wasTrue = false;
                isSaved = true;
            }
        }

        private void numericUpDownID_SIA_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewVehicles_SIA.Rows.Clear();
            for (int i = 0; i < rows; i++)
            {
                if (arrayValues[i, 0] == Convert.ToString(numericUpDownID_SIA.Value))
                {
                    dataGridViewVehicles_SIA.Rows.Add(arrayValues[i, 0]);
                    for (int j = 1; j < columns; j++)
                    {
                        dataGridViewVehicles_SIA.Rows[dataGridViewVehicles_SIA.RowCount - 1].Cells[j].Value = arrayValues[i, j];
                    }
                        
                }

            }
        }
            

        private void dataGridViewVehicles_SIA_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            isSaved = false;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < dataGridViewVehicles_SIA.Rows.Count; j++)
                {
                    if (Convert.ToString(dataGridViewVehicles_SIA.Rows[j].Cells[0].Value) == arrayValues[i, 0])
                    {
                        for (int k = 1; k < columns; k++)
                        {
                            arrayValues[i, k] = Convert.ToString(dataGridViewVehicles_SIA.Rows[j].Cells[k].Value);
                        }
                    }

                }
        }

        private void buttonResetFilters_SIA_Click(object sender, EventArgs e)
        {
            comboBoxVehicleType_SIA.Text = string.Empty;
            numericUpDownRouteID_SIA.Value = 0;
            numericUpDownID_SIA.Value = 0;
            dateTimePickerInUseFrom_SIA.Value = System.DateTime.Now;
            UpdateTable();
        }


        private void comboBoxVehicleType_SIA_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewVehicles_SIA.Rows.Clear();
            for (int i = 0; i < rows; i++)
            {
                if (arrayValues[i, 1] == Convert.ToString(comboBoxVehicleType_SIA.Text))
                {
                    dataGridViewVehicles_SIA.Rows.Add(arrayValues[i, 0]);
                    for (int j = 1; j < columns; j++)
                    {
                        dataGridViewVehicles_SIA.Rows[dataGridViewVehicles_SIA.RowCount - 1].Cells[j].Value = arrayValues[i, j];
                    }

                }

            }
        }

        private void numericUpDownRouteID_SIA_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewVehicles_SIA.Rows.Clear();
            for (int i = 0; i < rows; i++)
            {
                if (arrayValues[i, 2] == Convert.ToString(numericUpDownRouteID_SIA.Value))
                {
                    dataGridViewVehicles_SIA.Rows.Add(arrayValues[i, 0]);
                    for (int j = 1; j < columns; j++)
                    {
                        dataGridViewVehicles_SIA.Rows[dataGridViewVehicles_SIA.RowCount - 1].Cells[j].Value = arrayValues[i, j];
                    }

                }

            }
        }

        private void dateTimePickerInUseFrom_SIA_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewVehicles_SIA.Rows.Clear();
            for (int i = 0; i < rows; i++)
            {
                if (arrayValues[i, 3] == Convert.ToString(dateTimePickerInUseFrom_SIA.Value))
                {
                    dataGridViewVehicles_SIA.Rows.Add(arrayValues[i, 0]);
                    for (int j = 1; j < columns; j++)
                    {
                        dataGridViewVehicles_SIA.Rows[dataGridViewVehicles_SIA.RowCount - 1].Cells[j].Value = arrayValues[i, j];
                    }

                }

            }
        }
    }
}

