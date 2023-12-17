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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainAllVehicles_SIA));
            this.dataGridViewVehicles_SIA = new System.Windows.Forms.DataGridView();
            this.Vehicle_Id_SIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType_SIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteID_SIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InUseFrom_SIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxFilters_SIA = new System.Windows.Forms.GroupBox();
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
            this.buttonDeleteVehicle_SIA = new System.Windows.Forms.Button();
            this.buttonAddVehicle_SIA = new System.Windows.Forms.Button();
            this.buttonGoToVehicle_SIA = new System.Windows.Forms.Button();
            this.toolTipOnButtonHold_SIA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogSaveTo_SIA = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTable_SIA = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles_SIA)).BeginInit();
            this.groupBoxFilters_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouteID_SIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID_SIA)).BeginInit();
            this.menuStripAppMenu_SIA.SuspendLayout();
            this.groupBoxTools_SIA.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVehicles_SIA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVehicles_SIA.ColumnHeadersHeight = 35;
            this.dataGridViewVehicles_SIA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vehicle_Id_SIA,
            this.VehicleType_SIA,
            this.RouteID_SIA,
            this.InUseFrom_SIA});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVehicles_SIA.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewVehicles_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVehicles_SIA.Location = new System.Drawing.Point(0, 117);
            this.dataGridViewVehicles_SIA.Name = "dataGridViewVehicles_SIA";
            this.dataGridViewVehicles_SIA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVehicles_SIA.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewVehicles_SIA.RowHeadersVisible = false;
            this.dataGridViewVehicles_SIA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewVehicles_SIA.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewVehicles_SIA.RowTemplate.Height = 25;
            this.dataGridViewVehicles_SIA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVehicles_SIA.Size = new System.Drawing.Size(743, 424);
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
            this.VehicleType_SIA.MinimumWidth = 200;
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
            dataGridViewCellStyle2.NullValue = null;
            this.InUseFrom_SIA.DefaultCellStyle = dataGridViewCellStyle2;
            this.InUseFrom_SIA.HeaderText = "Дата введения маршрута";
            this.InUseFrom_SIA.Name = "InUseFrom_SIA";
            this.InUseFrom_SIA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // groupBoxFilters_SIA
            // 
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
            this.groupBoxFilters_SIA.Location = new System.Drawing.Point(743, 24);
            this.groupBoxFilters_SIA.Name = "groupBoxFilters_SIA";
            this.groupBoxFilters_SIA.Size = new System.Drawing.Size(206, 517);
            this.groupBoxFilters_SIA.TabIndex = 3;
            this.groupBoxFilters_SIA.TabStop = false;
            this.groupBoxFilters_SIA.Text = "Фильтры";
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
            this.comboBoxVehicleType_SIA.Location = new System.Drawing.Point(32, 130);
            this.comboBoxVehicleType_SIA.Name = "comboBoxVehicleType_SIA";
            this.comboBoxVehicleType_SIA.Size = new System.Drawing.Size(149, 26);
            this.comboBoxVehicleType_SIA.Sorted = true;
            this.comboBoxVehicleType_SIA.TabIndex = 13;
            this.comboBoxVehicleType_SIA.SelectedIndexChanged += new System.EventHandler(this.comboBoxVehicleType_SIA_SelectedIndexChanged);
            // 
            // numericUpDownRouteID_SIA
            // 
            this.numericUpDownRouteID_SIA.Location = new System.Drawing.Point(77, 194);
            this.numericUpDownRouteID_SIA.Name = "numericUpDownRouteID_SIA";
            this.numericUpDownRouteID_SIA.Size = new System.Drawing.Size(67, 24);
            this.numericUpDownRouteID_SIA.TabIndex = 12;
            this.numericUpDownRouteID_SIA.ValueChanged += new System.EventHandler(this.numericUpDownRouteID_SIA_ValueChanged);
            // 
            // labelInUseFrom_SIA
            // 
            this.labelInUseFrom_SIA.AutoSize = true;
            this.labelInUseFrom_SIA.Location = new System.Drawing.Point(16, 231);
            this.labelInUseFrom_SIA.Name = "labelInUseFrom_SIA";
            this.labelInUseFrom_SIA.Size = new System.Drawing.Size(184, 18);
            this.labelInUseFrom_SIA.TabIndex = 11;
            this.labelInUseFrom_SIA.Text = "Дата введения маршрута";
            // 
            // numericUpDownID_SIA
            // 
            this.numericUpDownID_SIA.Location = new System.Drawing.Point(77, 69);
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
            this.dateTimePickerInUseFrom_SIA.Location = new System.Drawing.Point(19, 252);
            this.dateTimePickerInUseFrom_SIA.Name = "dateTimePickerInUseFrom_SIA";
            this.dateTimePickerInUseFrom_SIA.Size = new System.Drawing.Size(173, 24);
            this.dateTimePickerInUseFrom_SIA.TabIndex = 4;
            this.dateTimePickerInUseFrom_SIA.ValueChanged += new System.EventHandler(this.dateTimePickerInUseFrom_SIA_ValueChanged);
            // 
            // labelRouteID_SIA
            // 
            this.labelRouteID_SIA.AutoSize = true;
            this.labelRouteID_SIA.Location = new System.Drawing.Point(44, 173);
            this.labelRouteID_SIA.Name = "labelRouteID_SIA";
            this.labelRouteID_SIA.Size = new System.Drawing.Size(127, 18);
            this.labelRouteID_SIA.TabIndex = 8;
            this.labelRouteID_SIA.Text = "Номер маршрута";
            // 
            // labelVehicleType_SIA
            // 
            this.labelVehicleType_SIA.AutoSize = true;
            this.labelVehicleType_SIA.Location = new System.Drawing.Point(50, 109);
            this.labelVehicleType_SIA.Name = "labelVehicleType_SIA";
            this.labelVehicleType_SIA.Size = new System.Drawing.Size(118, 18);
            this.labelVehicleType_SIA.TabIndex = 7;
            this.labelVehicleType_SIA.Text = "Вид транспорта";
            // 
            // labelID_SIA
            // 
            this.labelID_SIA.AutoSize = true;
            this.labelID_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID_SIA.Location = new System.Drawing.Point(50, 48);
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
            this.menuStripAppMenu_SIA.Size = new System.Drawing.Size(949, 24);
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
            this.ToolStripMenuItemNewTable_SIA.Size = new System.Drawing.Size(196, 38);
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
            this.ToolStripMenuItemOpen_SIA.Size = new System.Drawing.Size(196, 38);
            this.ToolStripMenuItemOpen_SIA.Text = "Открыть...";
            this.ToolStripMenuItemOpen_SIA.Click += new System.EventHandler(this.ToolStripMenuItemOpen_SIA_Click);
            // 
            // ToolStripMenuItemSave_SIA
            // 
            this.ToolStripMenuItemSave_SIA.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemSave_SIA.Image")));
            this.ToolStripMenuItemSave_SIA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItemSave_SIA.Name = "ToolStripMenuItemSave_SIA";
            this.ToolStripMenuItemSave_SIA.Size = new System.Drawing.Size(196, 38);
            this.ToolStripMenuItemSave_SIA.Text = "Сохранить";
            this.ToolStripMenuItemSave_SIA.Click += new System.EventHandler(this.ToolStripMenuItemSave_SIA_Click);
            // 
            // ToolStripMenuItemSaveAs_SIA
            // 
            this.ToolStripMenuItemSaveAs_SIA.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemSaveAs_SIA.Image")));
            this.ToolStripMenuItemSaveAs_SIA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItemSaveAs_SIA.Name = "ToolStripMenuItemSaveAs_SIA";
            this.ToolStripMenuItemSaveAs_SIA.Size = new System.Drawing.Size(196, 38);
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
            this.groupBoxTools_SIA.Controls.Add(this.buttonDeleteVehicle_SIA);
            this.groupBoxTools_SIA.Controls.Add(this.buttonAddVehicle_SIA);
            this.groupBoxTools_SIA.Controls.Add(this.buttonGoToVehicle_SIA);
            this.groupBoxTools_SIA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTools_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTools_SIA.Location = new System.Drawing.Point(0, 24);
            this.groupBoxTools_SIA.Name = "groupBoxTools_SIA";
            this.groupBoxTools_SIA.Size = new System.Drawing.Size(743, 93);
            this.groupBoxTools_SIA.TabIndex = 4;
            this.groupBoxTools_SIA.TabStop = false;
            this.groupBoxTools_SIA.Text = "Инструменты";
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
            // FormMainAllVehicles_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 541);
            this.Controls.Add(this.dataGridViewVehicles_SIA);
            this.Controls.Add(this.groupBoxTools_SIA);
            this.Controls.Add(this.groupBoxFilters_SIA);
            this.Controls.Add(this.menuStripAppMenu_SIA);
            this.MinimumSize = new System.Drawing.Size(654, 580);
            this.Name = "FormMainAllVehicles_SIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Весь транспорт";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles_SIA)).EndInit();
            this.groupBoxFilters_SIA.ResumeLayout(false);
            this.groupBoxFilters_SIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouteID_SIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID_SIA)).EndInit();
            this.menuStripAppMenu_SIA.ResumeLayout(false);
            this.menuStripAppMenu_SIA.PerformLayout();
            this.groupBoxTools_SIA.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle_Id_SIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType_SIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteID_SIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn InUseFrom_SIA;
        private System.Windows.Forms.Button buttonResetFilters_SIA;
    }
}

