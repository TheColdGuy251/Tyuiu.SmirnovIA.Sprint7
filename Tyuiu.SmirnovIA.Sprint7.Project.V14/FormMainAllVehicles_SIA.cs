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
        static int columns = 8;
        static string openFilePath = "";
        static string[,] arrayValues = new string[rows, columns];
        static int newID = 0;
        static bool wasTrue = false;
        static bool isSaved = true;
        static string[] filters = new string[7];
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
                columns = 8;
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
            Filter();
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

        private void Filter()
        {
            dataGridViewVehicles_SIA.Rows.Clear();
            for (int i = 0; i < rows; i++)
            {
                if ((arrayValues[i, 0] == filters[0] || string.IsNullOrWhiteSpace(filters[0])) && (arrayValues[i, 1] == filters[1] || string.IsNullOrWhiteSpace(filters[1])) && (arrayValues[i, 2] == filters[2] || string.IsNullOrWhiteSpace(filters[2])) && (arrayValues[i, 3] == filters[3] || string.IsNullOrWhiteSpace(filters[3])) && (arrayValues[i, 6] == filters[6] || string.IsNullOrWhiteSpace(filters[6])))
                {
                    try
                    {
                        if ((arrayValues[i, 4].Contains(filters[4]) || string.IsNullOrWhiteSpace(filters[4])) && (arrayValues[i, 5].Contains(filters[5]) || string.IsNullOrWhiteSpace(filters[5])))
                        {
                            dataGridViewVehicles_SIA.Rows.Add(arrayValues[i, 0]);
                            for (int k = 1; k < columns; k++)
                            {
                                dataGridViewVehicles_SIA.Rows[dataGridViewVehicles_SIA.RowCount - 1].Cells[k].Value = arrayValues[i, k];
                            }
                        }
                    }
                    catch
                    {
                        dataGridViewVehicles_SIA.Rows.Add(arrayValues[i, 0]);
                        for (int k = 1; k < columns; k++)
                        {
                            dataGridViewVehicles_SIA.Rows[dataGridViewVehicles_SIA.RowCount - 1].Cells[k].Value = arrayValues[i, k];
                        }
                    }
                    
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
                dataGridViewVehicles_SIA.Rows[dataGridViewVehicles_SIA.Rows.Count - 1].Cells[i].Value = "";
            }
            
            for (int i = 0; i < rows-1; i++)
            {
                newID = Math.Max(Convert.ToInt32(arrayValues[i, 0]), newID);
            }
            newID++;
            dataGridViewVehicles_SIA.Rows[dataGridViewVehicles_SIA.Rows.Count - 1].Cells[0].Value = Convert.ToString(newID);
            string[,] tempValues = arrayValues;
            arrayValues = new string[rows, columns];
            for (int r = 0; r < rows - 1; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = tempValues[r, c];
                }
            }
            for (int с = 0; с < columns; с++)
                arrayValues[rows - 1, с] = Convert.ToString(dataGridViewVehicles_SIA.Rows[dataGridViewVehicles_SIA.Rows.Count - 1].Cells[с].Value);
        }

        private void buttonDeleteVehicle_SIA_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить выбранные элементы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            isSaved = false;
            if (dialogResult == DialogResult.Yes)
            {
                string[] tempArray = new string[dataGridViewVehicles_SIA.SelectedRows.Count];
                int cnt = 0;
                foreach (DataGridViewRow item in this.dataGridViewVehicles_SIA.SelectedRows)
                {
                    tempArray[cnt] = Convert.ToString(dataGridViewVehicles_SIA.Rows[item.Index].Cells[0].Value);
                    dataGridViewVehicles_SIA.Rows.RemoveAt(item.Index);
                    cnt++;
                }

                UpdateTable();

                for (int i = rows-1; i >= 0; i--)
                {
                    for (int j = 0; j < tempArray.GetLength(0); j++)
                    {
                        try
                        {
                            if (Convert.ToString(dataGridViewVehicles_SIA.Rows[i].Cells[0].Value) == tempArray[j])
                            {
                                dataGridViewVehicles_SIA.Rows.RemoveAt(i);
                                rows--;
                            }
                        }
                        catch {
                            if (Convert.ToString(dataGridViewVehicles_SIA.Rows[dataGridViewVehicles_SIA.Rows.Count-1].Cells[0].Value) == tempArray[j])
                            {
                                dataGridViewVehicles_SIA.Rows.RemoveAt(dataGridViewVehicles_SIA.Rows.Count - 1);
                                rows--;
                            }
                        }
                    }
                    
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
                Filter();
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
            UpdateTable();
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
            UpdateTable();
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
                try 
                {
                    e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                    e.Handled = true;
                }
                catch { }
            }
            if (e.Column.Index == 3)
            {
                try
                {
                    e.SortResult = DateTime.Parse(e.CellValue1.ToString()).CompareTo(DateTime.Parse(e.CellValue2.ToString()));
                    e.Handled = true;
                }
                catch { }
            }
        }
        private void ToolStripMenuItemNewTable_SIA_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                DialogResult dialogResult = MessageBox.Show("У вас есть несохранённые данные.\nСоздать новую таблицу? ", "Новая таблица", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.Yes)
                {
                    rows = 0;
                    columns = 8;
                    openFilePath = "";
                    arrayValues = new string[rows, columns];
                    newID = 0;
                    dataGridViewVehicles_SIA.Rows.Clear();
                    buttonGoToVehicle_SIA.Enabled = false;
                    buttonDeleteVehicle_SIA.Enabled = false;
                    wasTrue = false;
                    isSaved = true;
                    comboBoxVehicleType_SIA.Text = string.Empty;
                    numericUpDownRouteID_SIA.Value = 0;
                    numericUpDownID_SIA.Value = 0;
                    filters = new string[7];
                }
            }
            else
            {
                rows = 0;
                columns = 8;
                openFilePath = "";
                arrayValues = new string[rows, columns];
                newID = 0;
                dataGridViewVehicles_SIA.Rows.Clear();
                buttonGoToVehicle_SIA.Enabled = false;
                buttonDeleteVehicle_SIA.Enabled = false;
                wasTrue = false;
                isSaved = true;
                comboBoxVehicleType_SIA.Text = string.Empty;
                numericUpDownRouteID_SIA.Value = 0;
                numericUpDownID_SIA.Value = 0;
                filters = new string[7];
            }
        }

        private void numericUpDownID_SIA_ValueChanged(object sender, EventArgs e)
        {
            filters[0] = Convert.ToString(numericUpDownID_SIA.Value);
            Filter();
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
            numericUpDownRouteTime_SIA.Value = 0;
            textBoxStartStop_SIA.Text = string.Empty;
            textBoxFinalStop_SIA.Text = string.Empty;
            UpdateTable();
        }


        private void comboBoxVehicleType_SIA_SelectedIndexChanged(object sender, EventArgs e)
        {
            filters[1] = comboBoxVehicleType_SIA.Text;
            Filter();
        }

        private void numericUpDownRouteID_SIA_ValueChanged(object sender, EventArgs e)
        {
            filters[2] = Convert.ToString(numericUpDownRouteID_SIA.Value);
            Filter();
        }

        private void dateTimePickerInUseFrom_SIA_ValueChanged(object sender, EventArgs e)
        {
            filters[3] = dateTimePickerInUseFrom_SIA.Value.ToShortDateString().Replace("/", ".");
            Filter();
        }

        private void textBoxStartStop_SIA_TextChanged(object sender, EventArgs e)
        {
            filters[4] = Convert.ToString(textBoxStartStop_SIA.Text);
            Filter();
        }

        private void textBoxFinalStop_SIA_TextChanged(object sender, EventArgs e)
        {
            filters[5] = Convert.ToString(textBoxStartStop_SIA.Text);
            Filter();
        }

        private void numericUpDownRouteTime_SIA_ValueChanged(object sender, EventArgs e)
        {
            filters[6] = Convert.ToString(numericUpDownRouteTime_SIA.Value);
            Filter();
        }

        private void radioButtonGeneral_SIA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGeneral_SIA.Checked) 
            {
                textBoxVehicleAmount_SIA.Text = Convert.ToString(ds.VehicleAmount(arrayValues));
                textBoxRouteAmount_SIA.Text = Convert.ToString(ds.RouteAmount(arrayValues));
                textBoxMinTime_SIA.Text = Convert.ToString(ds.MinTime(arrayValues));
                textBoxMaxTime_SIA.Text = Convert.ToString(ds.MaxTime(arrayValues));
                textBoxAvgTime_SIA.Text = Convert.ToString(ds.AvgTime(arrayValues));
            }
            else
            {
                foreach (DataGridViewRow item in this.dataGridViewVehicles_SIA.SelectedRows)
                {
                    tempArray[cnt] = Convert.ToString(dataGridViewVehicles_SIA.Rows[item.Index].Cells[0].Value);
                    dataGridViewVehicles_SIA.Rows.RemoveAt(item.Index);
                    cnt++;
                }
                textBoxVehicleAmount_SIA.Text = Convert.ToString(ds.VehicleAmount(arrayValues));
                textBoxRouteAmount_SIA.Text = Convert.ToString(ds.RouteAmount_Route(arrayValues, ));
                textBoxMinTime_SIA.Text = Convert.ToString(ds.MinTime_Route(arrayValues));
                textBoxMaxTime_SIA.Text = Convert.ToString(ds.MaxTime_Route(arrayValues));
                textBoxAvgTime_SIA.Text = Convert.ToString(ds.AvgTime_Route(arrayValues));
            }

        }
    }
}

