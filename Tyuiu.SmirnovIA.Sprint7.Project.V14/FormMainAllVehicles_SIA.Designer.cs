namespace Tyuiu.SmirnovIA.Sprint7.Project.V14
{
    partial class FormMainAllVehicles_SIA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainAllVehicles_SIA));
            this.dataGridViewVehicles_SIA = new System.Windows.Forms.DataGridView();
            this.Vehicle_Id_SIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType_SIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteID_SIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InUseFrom_SIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startStop_SIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalStop_SIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInRoute_SIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes_SIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxFilters_SIA = new System.Windows.Forms.GroupBox();
            this.numericUpDownRouteTime_SIA = new System.Windows.Forms.NumericUpDown();
            this.textBoxFinalStop_SIA = new System.Windows.Forms.TextBox();
            this.textBoxStartStop_SIA = new System.Windows.Forms.TextBox();
            this.labelRouteTime_SIA = new System.Windows.Forms.Label();
            this.labelFinalStop_SIA = new System.Windows.Forms.Label();
            this.labelStartStop_SIA = new System.Windows.Forms.Label();
            this.buttonResetFilters_SIA = new System.Windows.Forms.Button();
            this.comboBoxVehicleType_SIA = new System.Windows.Forms.ComboBox();
            this.numericUpDownRouteID_SIA = new System.Windows.Forms.NumericUpDown();
            this.labelInUseFrom_SIA = new System.Windows.Forms.Label();
            this.numericUpDownID_SIA = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerInUseFrom_SIA = new System.Windows.Forms.DateTimePicker();
            this.labelRouteID_SIA = new System.Windows.Forms.Label();
            this.labelVehicleType_SIA = new System.Windows.Forms.Label();
            this.labelID_SIA = new System.Windows.Forms.Label();
            this.menuStripAppMenu_SIA = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile_SIA = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewTable_SIA = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen_SIA = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSave_SIA = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveAs_SIA = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp_SIA = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUserGuide_SIA = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout_SIA = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxTools_SIA = new System.Windows.Forms.GroupBox();
            this.labelSearch_SIA = new System.Windows.Forms.Label();
            this.textBoxSearch_SIA = new System.Windows.Forms.TextBox();
            this.buttonDeleteVehicle_SIA = new System.Windows.Forms.Button();
            this.buttonAddVehicle_SIA = new System.Windows.Forms.Button();
            this.buttonGoToVehicle_SIA = new System.Windows.Forms.Button();
            this.toolTipOnButtonHold_SIA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogSaveTo_SIA = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTable_SIA = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxStats_SIA = new System.Windows.Forms.GroupBox();
            this.radioButtonRoute_SIA = new System.Windows.Forms.RadioButton();
            this.radioButtonGeneral_SIA = new System.Windows.Forms.RadioButton();
            this.textBoxVehicleAmount_SIA = new System.Windows.Forms.TextBox();
            this.labelVehicleAmount_SIA = new System.Windows.Forms.Label();
            this.textBoxAvgTime_SIA = new System.Windows.Forms.TextBox();
            this.textBoxMaxTime_SIA = new System.Windows.Forms.TextBox();
            this.textBoxMinTime_SIA = new System.Windows.Forms.TextBox();
            this.textBoxRouteAmount_SIA = new System.Windows.Forms.TextBox();
            this.labelAvgTime_SIA = new System.Windows.Forms.Label();
            this.labelMaxTime_SIA = new System.Windows.Forms.Label();
            this.labelMinTime_SIA = new System.Windows.Forms.Label();
            this.labelRouteAmount_SIA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles_SIA)).BeginInit();
            this.groupBoxFilters_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouteTime_SIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouteID_SIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID_SIA)).BeginInit();
            this.menuStripAppMenu_SIA.SuspendLayout();
            this.groupBoxTools_SIA.SuspendLayout();
            this.groupBoxStats_SIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVehicles_SIA
            // 
            this.dataGridViewVehicles_SIA.AllowUserToAddRows = false;
            this.dataGridViewVehicles_SIA.AllowUserToDeleteRows = false;
            this.dataGridViewVehicles_SIA.AllowUserToResizeColumns = false;
            this.dataGridViewVehicles_SIA.AllowUserToResizeRows = false;
            this.dataGridViewVehicles_SIA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVehicles_SIA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVehicles_SIA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewVehicles_SIA.ColumnHeadersHeight = 45;
            this.dataGridViewVehicles_SIA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vehicle_Id_SIA,
            this.VehicleType_SIA,
            this.RouteID_SIA,
            this.InUseFrom_SIA,
            this.startStop_SIA,
            this.finalStop_SIA,
            this.timeInRoute_SIA,
            this.notes_SIA});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVehicles_SIA.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewVehicles_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVehicles_SIA.Location = new System.Drawing.Point(0, 117);
            this.dataGridViewVehicles_SIA.Name = "dataGridViewVehicles_SIA";
            this.dataGridViewVehicles_SIA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVehicles_SIA.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewVehicles_SIA.RowHeadersVisible = false;
            this.dataGridViewVehicles_SIA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.NullValue = null;
            this.dataGridViewVehicles_SIA.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewVehicles_SIA.RowTemplate.Height = 25;
            this.dataGridViewVehicles_SIA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVehicles_SIA.Size = new System.Drawing.Size(930, 414);
            this.dataGridViewVehicles_SIA.TabIndex = 0;
            this.dataGridViewVehicles_SIA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVehicles_SIA_CellClick);
            this.dataGridViewVehicles_SIA.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVehicles_SIA_CellEndEdit);
            this.dataGridViewVehicles_SIA.SelectionChanged += new System.EventHandler(this.DataGridViewVehicles_SIA_SelectionChanged);
            this.dataGridViewVehicles_SIA.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridViewVehicles_SIA_SortCompare);
            // 
            // Vehicle_Id_SIA
            // 
            this.Vehicle_Id_SIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Vehicle_Id_SIA.HeaderText = "ID";
            this.Vehicle_Id_SIA.Name = "Vehicle_Id_SIA";
            this.Vehicle_Id_SIA.ReadOnly = true;
            this.Vehicle_Id_SIA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Vehicle_Id_SIA.Width = 49;
            // 
            // VehicleType_SIA
            // 
            this.VehicleType_SIA.HeaderText = "Вид транспорта";
            this.VehicleType_SIA.MinimumWidth = 100;
            this.VehicleType_SIA.Name = "VehicleType_SIA";
            this.VehicleType_SIA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // RouteID_SIA
            // 
            this.RouteID_SIA.HeaderText = "Номер Маршрута";
            this.RouteID_SIA.Name = "RouteID_SIA";
            this.RouteID_SIA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // InUseFrom_SIA
            // 
            dataGridViewCellStyle7.NullValue = null;
            this.InUseFrom_SIA.DefaultCellStyle = dataGridViewCellStyle7;
            this.InUseFrom_SIA.HeaderText = "Дата введения маршрута";
            this.InUseFrom_SIA.Name = "InUseFrom_SIA";
            this.InUseFrom_SIA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // startStop_SIA
            // 
            this.startStop_SIA.HeaderText = "Начальная Остановка";
            this.startStop_SIA.MinimumWidth = 150;
            this.startStop_SIA.Name = "startStop_SIA";
            // 
            // finalStop_SIA
            // 
            this.finalStop_SIA.HeaderText = "Конечная остановка";
            this.finalStop_SIA.MinimumWidth = 150;
            this.finalStop_SIA.Name = "finalStop_SIA";
            // 
            // timeInRoute_SIA
            // 
            this.timeInRoute_SIA.HeaderText = "Время в пути";
            this.timeInRoute_SIA.Name = "timeInRoute_SIA";
            // 
            // notes_SIA
            // 
            this.notes_SIA.HeaderText = "Примечание";
            this.notes_SIA.MinimumWidth = 150;
            this.notes_SIA.Name = "notes_SIA";
            // 
            // groupBoxFilters_SIA
            // 
            this.groupBoxFilters_SIA.Controls.Add(this.numericUpDownRouteTime_SIA);
            this.groupBoxFilters_SIA.Controls.Add(this.textBoxFinalStop_SIA);
            this.groupBoxFilters_SIA.Controls.Add(this.textBoxStartStop_SIA);
            this.groupBoxFilters_SIA.Controls.Add(this.labelRouteTime_SIA);
            this.groupBoxFilters_SIA.Controls.Add(this.labelFinalStop_SIA);
            this.groupBoxFilters_SIA.Controls.Add(this.labelStartStop_SIA);
            this.groupBoxFilters_SIA.Controls.Add(this.buttonResetFilters_SIA);
            this.groupBoxFilters_SIA.Controls.Add(this.comboBoxVehicleType_SIA);
            this.groupBoxFilters_SIA.Controls.Add(this.numericUpDownRouteID_SIA);
            this.groupBoxFilters_SIA.Controls.Add(this.labelInUseFrom_SIA);
            this.groupBoxFilters_SIA.Controls.Add(this.numericUpDownID_SIA);
            this.groupBoxFilters_SIA.Controls.Add(this.dateTimePickerInUseFrom_SIA);
            this.groupBoxFilters_SIA.Controls.Add(this.labelRouteID_SIA);
            this.groupBoxFilters_SIA.Controls.Add(this.labelVehicleType_SIA);
            this.groupBoxFilters_SIA.Controls.Add(this.labelID_SIA);
            this.groupBoxFilters_SIA.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxFilters_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFilters_SIA.Location = new System.Drawing.Point(930, 24);
            this.groupBoxFilters_SIA.Name = "groupBoxFilters_SIA";
            this.groupBoxFilters_SIA.Size = new System.Drawing.Size(206, 507);
            this.groupBoxFilters_SIA.TabIndex = 3;
            this.groupBoxFilters_SIA.TabStop = false;
            this.groupBoxFilters_SIA.Text = "Фильтры";
            // 
            // numericUpDownRouteTime_SIA
            // 
            this.numericUpDownRouteTime_SIA.Location = new System.Drawing.Point(49, 411);
            this.numericUpDownRouteTime_SIA.Name = "numericUpDownRouteTime_SIA";
            this.numericUpDownRouteTime_SIA.Size = new System.Drawing.Size(111, 24);
            this.numericUpDownRouteTime_SIA.TabIndex = 25;
            this.numericUpDownRouteTime_SIA.ValueChanged += new System.EventHandler(this.numericUpDownRouteTime_SIA_ValueChanged);
            // 
            // textBoxFinalStop_SIA
            // 
            this.textBoxFinalStop_SIA.Location = new System.Drawing.Point(27, 352);
            this.textBoxFinalStop_SIA.Name = "textBoxFinalStop_SIA";
            this.textBoxFinalStop_SIA.Size = new System.Drawing.Size(156, 24);
            this.textBoxFinalStop_SIA.TabIndex = 24;
            this.textBoxFinalStop_SIA.TextChanged += new System.EventHandler(this.textBoxFinalStop_SIA_TextChanged);
            // 
            // textBoxStartStop_SIA
            // 
            this.textBoxStartStop_SIA.Location = new System.Drawing.Point(28, 287);
            this.textBoxStartStop_SIA.Name = "textBoxStartStop_SIA";
            this.textBoxStartStop_SIA.Size = new System.Drawing.Size(156, 24);
            this.textBoxStartStop_SIA.TabIndex = 23;
            this.textBoxStartStop_SIA.TextChanged += new System.EventHandler(this.textBoxStartStop_SIA_TextChanged);
            // 
            // labelRouteTime_SIA
            // 
            this.labelRouteTime_SIA.AutoSize = true;
            this.labelRouteTime_SIA.Location = new System.Drawing.Point(37, 390);
            this.labelRouteTime_SIA.Name = "labelRouteTime_SIA";
            this.labelRouteTime_SIA.Size = new System.Drawing.Size(136, 18);
            this.labelRouteTime_SIA.TabIndex = 22;
            this.labelRouteTime_SIA.Text = "Время в пути(мин)";
            // 
            // labelFinalStop_SIA
            // 
            this.labelFinalStop_SIA.AutoSize = true;
            this.labelFinalStop_SIA.Location = new System.Drawing.Point(31, 331);
            this.labelFinalStop_SIA.Name = "labelFinalStop_SIA";
            this.labelFinalStop_SIA.Size = new System.Drawing.Size(152, 18);
            this.labelFinalStop_SIA.TabIndex = 21;
            this.labelFinalStop_SIA.Text = "Конечная остановка";
            // 
            // labelStartStop_SIA
            // 
            this.labelStartStop_SIA.AutoSize = true;
            this.labelStartStop_SIA.Location = new System.Drawing.Point(31, 266);
            this.labelStartStop_SIA.Name = "labelStartStop_SIA";
            this.labelStartStop_SIA.Size = new System.Drawing.Size(161, 18);
            this.labelStartStop_SIA.TabIndex = 20;
            this.labelStartStop_SIA.Text = "Начальная остановка";
            // 
            // buttonResetFilters_SIA
            // 
            this.buttonResetFilters_SIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonResetFilters_SIA.Location = new System.Drawing.Point(31, 466);
            this.buttonResetFilters_SIA.Name = "buttonResetFilters_SIA";
            this.buttonResetFilters_SIA.Size = new System.Drawing.Size(153, 33);
            this.buttonResetFilters_SIA.TabIndex = 4;
            this.buttonResetFilters_SIA.Text = "Сбросить фильтры";
            this.buttonResetFilters_SIA.UseVisualStyleBackColor = true;
            this.buttonResetFilters_SIA.Click += new System.EventHandler(this.buttonResetFilters_SIA_Click);
            // 
            // comboBoxVehicleType_SIA
            // 
            this.comboBoxVehicleType_SIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVehicleType_SIA.FormattingEnabled = true;
            this.comboBoxVehicleType_SIA.Items.AddRange(new object[] {
            "Автобус",
            "Маршрутное такси",
            "Трамвай",
            "Троллейбус"});
            this.comboBoxVehicleType_SIA.Location = new System.Drawing.Point(34, 104);
            this.comboBoxVehicleType_SIA.Name = "comboBoxVehicleType_SIA";
            this.comboBoxVehicleType_SIA.Size = new System.Drawing.Size(149, 26);
            this.comboBoxVehicleType_SIA.Sorted = true;
            this.comboBoxVehicleType_SIA.TabIndex = 13;
            this.comboBoxVehicleType_SIA.SelectedIndexChanged += new System.EventHandler(this.comboBoxVehicleType_SIA_SelectedIndexChanged);
            // 
            // numericUpDownRouteID_SIA
            // 
            this.numericUpDownRouteID_SIA.Location = new System.Drawing.Point(77, 164);
            this.numericUpDownRouteID_SIA.Name = "numericUpDownRouteID_SIA";
            this.numericUpDownRouteID_SIA.Size = new System.Drawing.Size(67, 24);
            this.numericUpDownRouteID_SIA.TabIndex = 12;
            this.numericUpDownRouteID_SIA.ValueChanged += new System.EventHandler(this.numericUpDownRouteID_SIA_ValueChanged);
            // 
            // labelInUseFrom_SIA
            // 
            this.labelInUseFrom_SIA.AutoSize = true;
            this.labelInUseFrom_SIA.Location = new System.Drawing.Point(16, 207);
            this.labelInUseFrom_SIA.Name = "labelInUseFrom_SIA";
            this.labelInUseFrom_SIA.Size = new System.Drawing.Size(184, 18);
            this.labelInUseFrom_SIA.TabIndex = 11;
            this.labelInUseFrom_SIA.Text = "Дата введения маршрута";
            // 
            // numericUpDownID_SIA
            // 
            this.numericUpDownID_SIA.Location = new System.Drawing.Point(77, 44);
            this.numericUpDownID_SIA.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownID_SIA.Name = "numericUpDownID_SIA";
            this.numericUpDownID_SIA.Size = new System.Drawing.Size(67, 24);
            this.numericUpDownID_SIA.TabIndex = 10;
            this.numericUpDownID_SIA.ValueChanged += new System.EventHandler(this.numericUpDownID_SIA_ValueChanged);
            // 
            // dateTimePickerInUseFrom_SIA
            // 
            this.dateTimePickerInUseFrom_SIA.AllowDrop = true;
            this.dateTimePickerInUseFrom_SIA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInUseFrom_SIA.Location = new System.Drawing.Point(19, 228);
            this.dateTimePickerInUseFrom_SIA.Name = "dateTimePickerInUseFrom_SIA";
            this.dateTimePickerInUseFrom_SIA.Size = new System.Drawing.Size(173, 24);
            this.dateTimePickerInUseFrom_SIA.TabIndex = 4;
            this.dateTimePickerInUseFrom_SIA.ValueChanged += new System.EventHandler(this.dateTimePickerInUseFrom_SIA_ValueChanged);
            // 
            // labelRouteID_SIA
            // 
            this.labelRouteID_SIA.AutoSize = true;
            this.labelRouteID_SIA.Location = new System.Drawing.Point(46, 143);
            this.labelRouteID_SIA.Name = "labelRouteID_SIA";
            this.labelRouteID_SIA.Size = new System.Drawing.Size(127, 18);
            this.labelRouteID_SIA.TabIndex = 8;
            this.labelRouteID_SIA.Text = "Номер маршрута";
            // 
            // labelVehicleType_SIA
            // 
            this.labelVehicleType_SIA.AutoSize = true;
            this.labelVehicleType_SIA.Location = new System.Drawing.Point(50, 83);
            this.labelVehicleType_SIA.Name = "labelVehicleType_SIA";
            this.labelVehicleType_SIA.Size = new System.Drawing.Size(118, 18);
            this.labelVehicleType_SIA.TabIndex = 7;
            this.labelVehicleType_SIA.Text = "Вид транспорта";
            // 
            // labelID_SIA
            // 
            this.labelID_SIA.AutoSize = true;
            this.labelID_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID_SIA.Location = new System.Drawing.Point(50, 26);
            this.labelID_SIA.Name = "labelID_SIA";
            this.labelID_SIA.Size = new System.Drawing.Size(105, 18);
            this.labelID_SIA.TabIndex = 6;
            this.labelID_SIA.Text = "ID транспорта";
            // 
            // menuStripAppMenu_SIA
            // 
            this.menuStripAppMenu_SIA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile_SIA,
            this.ToolStripMenuItemHelp_SIA});
            this.menuStripAppMenu_SIA.Location = new System.Drawing.Point(0, 0);
            this.menuStripAppMenu_SIA.Name = "menuStripAppMenu_SIA";
            this.menuStripAppMenu_SIA.Size = new System.Drawing.Size(1136, 24);
            this.menuStripAppMenu_SIA.TabIndex = 7;
            this.menuStripAppMenu_SIA.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile_SIA
            // 
            this.ToolStripMenuItemFile_SIA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNewTable_SIA,
            this.ToolStripMenuItemOpen_SIA,
            this.ToolStripMenuItemSave_SIA,
            this.ToolStripMenuItemSaveAs_SIA});
            this.ToolStripMenuItemFile_SIA.Name = "ToolStripMenuItemFile_SIA";
            this.ToolStripMenuItemFile_SIA.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenuItemFile_SIA.Text = "Файл";
            // 
            // ToolStripMenuItemNewTable_SIA
            // 
            this.ToolStripMenuItemNewTable_SIA.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemNewTable_SIA.Image")));
            this.ToolStripMenuItemNewTable_SIA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItemNewTable_SIA.Name = "ToolStripMenuItemNewTable_SIA";
            this.ToolStripMenuItemNewTable_SIA.Size = new System.Drawing.Size(179, 38);
            this.ToolStripMenuItemNewTable_SIA.Text = "Новая таблица";
            this.ToolStripMenuItemNewTable_SIA.Click += new System.EventHandler(this.ToolStripMenuItemNewTable_SIA_Click);
            // 
            // ToolStripMenuItemOpen_SIA
            // 
            this.ToolStripMenuItemOpen_SIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ToolStripMenuItemOpen_SIA.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemOpen_SIA.Image")));
            this.ToolStripMenuItemOpen_SIA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripMenuItemOpen_SIA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItemOpen_SIA.Name = "ToolStripMenuItemOpen_SIA";
            this.ToolStripMenuItemOpen_SIA.Size = new System.Drawing.Size(179, 38);
            this.ToolStripMenuItemOpen_SIA.Text = "Открыть...";
            this.ToolStripMenuItemOpen_SIA.Click += new System.EventHandler(this.ToolStripMenuItemOpen_SIA_Click);
            // 
            // ToolStripMenuItemSave_SIA
            // 
            this.ToolStripMenuItemSave_SIA.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemSave_SIA.Image")));
            this.ToolStripMenuItemSave_SIA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItemSave_SIA.Name = "ToolStripMenuItemSave_SIA";
            this.ToolStripMenuItemSave_SIA.Size = new System.Drawing.Size(179, 38);
            this.ToolStripMenuItemSave_SIA.Text = "Сохранить";
            this.ToolStripMenuItemSave_SIA.Click += new System.EventHandler(this.ToolStripMenuItemSave_SIA_Click);
            // 
            // ToolStripMenuItemSaveAs_SIA
            // 
            this.ToolStripMenuItemSaveAs_SIA.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemSaveAs_SIA.Image")));
            this.ToolStripMenuItemSaveAs_SIA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItemSaveAs_SIA.Name = "ToolStripMenuItemSaveAs_SIA";
            this.ToolStripMenuItemSaveAs_SIA.Size = new System.Drawing.Size(179, 38);
            this.ToolStripMenuItemSaveAs_SIA.Text = "Сохранить как...";
            this.ToolStripMenuItemSaveAs_SIA.Click += new System.EventHandler(this.ToolStripMenuItemSaveAs_SIA_Click);
            // 
            // ToolStripMenuItemHelp_SIA
            // 
            this.ToolStripMenuItemHelp_SIA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemUserGuide_SIA,
            this.ToolStripMenuItemAbout_SIA});
            this.ToolStripMenuItemHelp_SIA.Name = "ToolStripMenuItemHelp_SIA";
            this.ToolStripMenuItemHelp_SIA.Size = new System.Drawing.Size(68, 20);
            this.ToolStripMenuItemHelp_SIA.Text = "Помощь";
            // 
            // ToolStripMenuItemUserGuide_SIA
            // 
            this.ToolStripMenuItemUserGuide_SIA.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemUserGuide_SIA.Image")));
            this.ToolStripMenuItemUserGuide_SIA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItemUserGuide_SIA.Name = "ToolStripMenuItemUserGuide_SIA";
            this.ToolStripMenuItemUserGuide_SIA.Size = new System.Drawing.Size(239, 38);
            this.ToolStripMenuItemUserGuide_SIA.Text = "Руководство Пользователя";
            // 
            // ToolStripMenuItemAbout_SIA
            // 
            this.ToolStripMenuItemAbout_SIA.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemAbout_SIA.Image")));
            this.ToolStripMenuItemAbout_SIA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItemAbout_SIA.Name = "ToolStripMenuItemAbout_SIA";
            this.ToolStripMenuItemAbout_SIA.Size = new System.Drawing.Size(239, 38);
            this.ToolStripMenuItemAbout_SIA.Text = "О программме";
            // 
            // groupBoxTools_SIA
            // 
            this.groupBoxTools_SIA.Controls.Add(this.labelSearch_SIA);
            this.groupBoxTools_SIA.Controls.Add(this.textBoxSearch_SIA);
            this.groupBoxTools_SIA.Controls.Add(this.buttonDeleteVehicle_SIA);
            this.groupBoxTools_SIA.Controls.Add(this.buttonAddVehicle_SIA);
            this.groupBoxTools_SIA.Controls.Add(this.buttonGoToVehicle_SIA);
            this.groupBoxTools_SIA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTools_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTools_SIA.Location = new System.Drawing.Point(0, 24);
            this.groupBoxTools_SIA.Name = "groupBoxTools_SIA";
            this.groupBoxTools_SIA.Size = new System.Drawing.Size(930, 93);
            this.groupBoxTools_SIA.TabIndex = 4;
            this.groupBoxTools_SIA.TabStop = false;
            this.groupBoxTools_SIA.Text = "Инструменты";
            // 
            // labelSearch_SIA
            // 
            this.labelSearch_SIA.AutoSize = true;
            this.labelSearch_SIA.Location = new System.Drawing.Point(675, 36);
            this.labelSearch_SIA.Name = "labelSearch_SIA";
            this.labelSearch_SIA.Size = new System.Drawing.Size(52, 18);
            this.labelSearch_SIA.TabIndex = 5;
            this.labelSearch_SIA.Text = "Поиск";
            // 
            // textBoxSearch_SIA
            // 
            this.textBoxSearch_SIA.Location = new System.Drawing.Point(678, 57);
            this.textBoxSearch_SIA.Name = "textBoxSearch_SIA";
            this.textBoxSearch_SIA.Size = new System.Drawing.Size(222, 24);
            this.textBoxSearch_SIA.TabIndex = 4;
            // 
            // buttonDeleteVehicle_SIA
            // 
            this.buttonDeleteVehicle_SIA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteVehicle_SIA.BackgroundImage")));
            this.buttonDeleteVehicle_SIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDeleteVehicle_SIA.Enabled = false;
            this.buttonDeleteVehicle_SIA.Location = new System.Drawing.Point(193, 27);
            this.buttonDeleteVehicle_SIA.Name = "buttonDeleteVehicle_SIA";
            this.buttonDeleteVehicle_SIA.Size = new System.Drawing.Size(66, 54);
            this.buttonDeleteVehicle_SIA.TabIndex = 3;
            this.buttonDeleteVehicle_SIA.UseVisualStyleBackColor = true;
            this.buttonDeleteVehicle_SIA.Click += new System.EventHandler(this.buttonDeleteVehicle_SIA_Click);
            // 
            // buttonAddVehicle_SIA
            // 
            this.buttonAddVehicle_SIA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddVehicle_SIA.BackgroundImage")));
            this.buttonAddVehicle_SIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddVehicle_SIA.Location = new System.Drawing.Point(121, 26);
            this.buttonAddVehicle_SIA.Name = "buttonAddVehicle_SIA";
            this.buttonAddVehicle_SIA.Size = new System.Drawing.Size(66, 56);
            this.buttonAddVehicle_SIA.TabIndex = 1;
            this.buttonAddVehicle_SIA.UseVisualStyleBackColor = true;
            this.buttonAddVehicle_SIA.Click += new System.EventHandler(this.buttonAddVehicle_SIA_Click);
            // 
            // buttonGoToVehicle_SIA
            // 
            this.buttonGoToVehicle_SIA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGoToVehicle_SIA.BackgroundImage")));
            this.buttonGoToVehicle_SIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonGoToVehicle_SIA.Enabled = false;
            this.buttonGoToVehicle_SIA.Location = new System.Drawing.Point(16, 20);
            this.buttonGoToVehicle_SIA.Name = "buttonGoToVehicle_SIA";
            this.buttonGoToVehicle_SIA.Size = new System.Drawing.Size(80, 71);
            this.buttonGoToVehicle_SIA.TabIndex = 0;
            this.buttonGoToVehicle_SIA.UseVisualStyleBackColor = true;
            this.buttonGoToVehicle_SIA.Click += new System.EventHandler(this.buttonGoToVehicle_SIA_Click);
            // 
            // openFileDialogTable_SIA
            // 
            this.openFileDialogTable_SIA.FileName = "openFileDialog1";
            // 
            // groupBoxStats_SIA
            // 
            this.groupBoxStats_SIA.Controls.Add(this.radioButtonRoute_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.radioButtonGeneral_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.textBoxVehicleAmount_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.labelVehicleAmount_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.textBoxAvgTime_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.textBoxMaxTime_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.textBoxMinTime_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.textBoxRouteAmount_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.labelAvgTime_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.labelMaxTime_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.labelMinTime_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.labelRouteAmount_SIA);
            this.groupBoxStats_SIA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxStats_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxStats_SIA.Location = new System.Drawing.Point(0, 531);
            this.groupBoxStats_SIA.Name = "groupBoxStats_SIA";
            this.groupBoxStats_SIA.Size = new System.Drawing.Size(1136, 112);
            this.groupBoxStats_SIA.TabIndex = 4;
            this.groupBoxStats_SIA.TabStop = false;
            this.groupBoxStats_SIA.Text = "Статистика";
            // 
            // radioButtonRoute_SIA
            // 
            this.radioButtonRoute_SIA.AutoSize = true;
            this.radioButtonRoute_SIA.Location = new System.Drawing.Point(930, 70);
            this.radioButtonRoute_SIA.Name = "radioButtonRoute_SIA";
            this.radioButtonRoute_SIA.Size = new System.Drawing.Size(178, 22);
            this.radioButtonRoute_SIA.TabIndex = 19;
            this.radioButtonRoute_SIA.Text = "Статистика маршрута";
            this.radioButtonRoute_SIA.UseVisualStyleBackColor = true;
            // 
            // radioButtonGeneral_SIA
            // 
            this.radioButtonGeneral_SIA.AutoSize = true;
            this.radioButtonGeneral_SIA.Checked = true;
            this.radioButtonGeneral_SIA.Location = new System.Drawing.Point(930, 42);
            this.radioButtonGeneral_SIA.Name = "radioButtonGeneral_SIA";
            this.radioButtonGeneral_SIA.Size = new System.Drawing.Size(155, 22);
            this.radioButtonGeneral_SIA.TabIndex = 18;
            this.radioButtonGeneral_SIA.TabStop = true;
            this.radioButtonGeneral_SIA.Text = "Общая статистика";
            this.radioButtonGeneral_SIA.UseVisualStyleBackColor = true;
            this.radioButtonGeneral_SIA.CheckedChanged += new System.EventHandler(this.radioButtonGeneral_SIA_CheckedChanged);
            // 
            // textBoxVehicleAmount_SIA
            // 
            this.textBoxVehicleAmount_SIA.Location = new System.Drawing.Point(6, 70);
            this.textBoxVehicleAmount_SIA.Name = "textBoxVehicleAmount_SIA";
            this.textBoxVehicleAmount_SIA.ReadOnly = true;
            this.textBoxVehicleAmount_SIA.Size = new System.Drawing.Size(103, 24);
            this.textBoxVehicleAmount_SIA.TabIndex = 17;
            // 
            // labelVehicleAmount_SIA
            // 
            this.labelVehicleAmount_SIA.AutoSize = true;
            this.labelVehicleAmount_SIA.Location = new System.Drawing.Point(11, 49);
            this.labelVehicleAmount_SIA.Name = "labelVehicleAmount_SIA";
            this.labelVehicleAmount_SIA.Size = new System.Drawing.Size(85, 18);
            this.labelVehicleAmount_SIA.TabIndex = 16;
            this.labelVehicleAmount_SIA.Text = "Кол-во т.с.";
            // 
            // textBoxAvgTime_SIA
            // 
            this.textBoxAvgTime_SIA.Location = new System.Drawing.Point(687, 70);
            this.textBoxAvgTime_SIA.Name = "textBoxAvgTime_SIA";
            this.textBoxAvgTime_SIA.ReadOnly = true;
            this.textBoxAvgTime_SIA.Size = new System.Drawing.Size(141, 24);
            this.textBoxAvgTime_SIA.TabIndex = 15;
            // 
            // textBoxMaxTime_SIA
            // 
            this.textBoxMaxTime_SIA.Location = new System.Drawing.Point(495, 70);
            this.textBoxMaxTime_SIA.Name = "textBoxMaxTime_SIA";
            this.textBoxMaxTime_SIA.ReadOnly = true;
            this.textBoxMaxTime_SIA.Size = new System.Drawing.Size(141, 24);
            this.textBoxMaxTime_SIA.TabIndex = 14;
            // 
            // textBoxMinTime_SIA
            // 
            this.textBoxMinTime_SIA.Location = new System.Drawing.Point(316, 70);
            this.textBoxMinTime_SIA.Name = "textBoxMinTime_SIA";
            this.textBoxMinTime_SIA.ReadOnly = true;
            this.textBoxMinTime_SIA.Size = new System.Drawing.Size(141, 24);
            this.textBoxMinTime_SIA.TabIndex = 13;
            // 
            // textBoxRouteAmount_SIA
            // 
            this.textBoxRouteAmount_SIA.Location = new System.Drawing.Point(148, 70);
            this.textBoxRouteAmount_SIA.Name = "textBoxRouteAmount_SIA";
            this.textBoxRouteAmount_SIA.ReadOnly = true;
            this.textBoxRouteAmount_SIA.Size = new System.Drawing.Size(126, 24);
            this.textBoxRouteAmount_SIA.TabIndex = 12;
            // 
            // labelAvgTime_SIA
            // 
            this.labelAvgTime_SIA.AutoSize = true;
            this.labelAvgTime_SIA.Location = new System.Drawing.Point(700, 49);
            this.labelAvgTime_SIA.Name = "labelAvgTime_SIA";
            this.labelAvgTime_SIA.Size = new System.Drawing.Size(115, 18);
            this.labelAvgTime_SIA.TabIndex = 11;
            this.labelAvgTime_SIA.Text = "Среднее время";
            // 
            // labelMaxTime_SIA
            // 
            this.labelMaxTime_SIA.AutoSize = true;
            this.labelMaxTime_SIA.Location = new System.Drawing.Point(485, 49);
            this.labelMaxTime_SIA.Name = "labelMaxTime_SIA";
            this.labelMaxTime_SIA.Size = new System.Drawing.Size(161, 18);
            this.labelMaxTime_SIA.TabIndex = 10;
            this.labelMaxTime_SIA.Text = "Максимальное время";
            // 
            // labelMinTime_SIA
            // 
            this.labelMinTime_SIA.AutoSize = true;
            this.labelMinTime_SIA.Location = new System.Drawing.Point(313, 49);
            this.labelMinTime_SIA.Name = "labelMinTime_SIA";
            this.labelMinTime_SIA.Size = new System.Drawing.Size(153, 18);
            this.labelMinTime_SIA.TabIndex = 9;
            this.labelMinTime_SIA.Text = "Минимальное время";
            // 
            // labelRouteAmount_SIA
            // 
            this.labelRouteAmount_SIA.AutoSize = true;
            this.labelRouteAmount_SIA.Location = new System.Drawing.Point(129, 49);
            this.labelRouteAmount_SIA.Name = "labelRouteAmount_SIA";
            this.labelRouteAmount_SIA.Size = new System.Drawing.Size(169, 18);
            this.labelRouteAmount_SIA.TabIndex = 8;
            this.labelRouteAmount_SIA.Text = "Движутся по маршруту";
            this.labelRouteAmount_SIA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMainAllVehicles_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 643);
            this.Controls.Add(this.dataGridViewVehicles_SIA);
            this.Controls.Add(this.groupBoxTools_SIA);
            this.Controls.Add(this.groupBoxFilters_SIA);
            this.Controls.Add(this.menuStripAppMenu_SIA);
            this.Controls.Add(this.groupBoxStats_SIA);
            this.MinimumSize = new System.Drawing.Size(654, 580);
            this.Name = "FormMainAllVehicles_SIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Весь транспорт";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles_SIA)).EndInit();
            this.groupBoxFilters_SIA.ResumeLayout(false);
            this.groupBoxFilters_SIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouteTime_SIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouteID_SIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID_SIA)).EndInit();
            this.menuStripAppMenu_SIA.ResumeLayout(false);
            this.menuStripAppMenu_SIA.PerformLayout();
            this.groupBoxTools_SIA.ResumeLayout(false);
            this.groupBoxTools_SIA.PerformLayout();
            this.groupBoxStats_SIA.ResumeLayout(false);
            this.groupBoxStats_SIA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewVehicles_SIA;
        private System.Windows.Forms.GroupBox groupBoxFilters_SIA;
        private System.Windows.Forms.Label labelInUseFrom_SIA;
        private System.Windows.Forms.NumericUpDown numericUpDownID_SIA;
        private System.Windows.Forms.DateTimePicker dateTimePickerInUseFrom_SIA;
        private System.Windows.Forms.Label labelRouteID_SIA;
        private System.Windows.Forms.Label labelVehicleType_SIA;
        private System.Windows.Forms.Label labelID_SIA;
        private System.Windows.Forms.MenuStrip menuStripAppMenu_SIA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile_SIA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen_SIA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSave_SIA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveAs_SIA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp_SIA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUserGuide_SIA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout_SIA;
        private System.Windows.Forms.GroupBox groupBoxTools_SIA;
        private System.Windows.Forms.Button buttonDeleteVehicle_SIA;
        private System.Windows.Forms.Button buttonAddVehicle_SIA;
        private System.Windows.Forms.Button buttonGoToVehicle_SIA;
        private System.Windows.Forms.NumericUpDown numericUpDownRouteID_SIA;
        private System.Windows.Forms.ToolTip toolTipOnButtonHold_SIA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSaveTo_SIA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable_SIA;
        private System.Windows.Forms.ComboBox comboBoxVehicleType_SIA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewTable_SIA;
        private System.Windows.Forms.Button buttonResetFilters_SIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle_Id_SIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType_SIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteID_SIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn InUseFrom_SIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn startStop_SIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalStop_SIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInRoute_SIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes_SIA;
        private System.Windows.Forms.GroupBox groupBoxStats_SIA;
        private System.Windows.Forms.NumericUpDown numericUpDownRouteTime_SIA;
        private System.Windows.Forms.TextBox textBoxFinalStop_SIA;
        private System.Windows.Forms.TextBox textBoxStartStop_SIA;
        private System.Windows.Forms.Label labelRouteTime_SIA;
        private System.Windows.Forms.Label labelFinalStop_SIA;
        private System.Windows.Forms.Label labelStartStop_SIA;
        private System.Windows.Forms.TextBox textBoxAvgTime_SIA;
        private System.Windows.Forms.TextBox textBoxMaxTime_SIA;
        private System.Windows.Forms.TextBox textBoxMinTime_SIA;
        private System.Windows.Forms.TextBox textBoxRouteAmount_SIA;
        private System.Windows.Forms.Label labelAvgTime_SIA;
        private System.Windows.Forms.Label labelMaxTime_SIA;
        private System.Windows.Forms.Label labelMinTime_SIA;
        private System.Windows.Forms.Label labelRouteAmount_SIA;
        private System.Windows.Forms.TextBox textBoxVehicleAmount_SIA;
        private System.Windows.Forms.Label labelVehicleAmount_SIA;
        private System.Windows.Forms.Label labelSearch_SIA;
        private System.Windows.Forms.TextBox textBoxSearch_SIA;
        private System.Windows.Forms.RadioButton radioButtonRoute_SIA;
        private System.Windows.Forms.RadioButton radioButtonGeneral_SIA;
    }
}

