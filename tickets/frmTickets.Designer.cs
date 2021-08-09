namespace tickets
{
    partial class frmTickets
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
            System.Windows.Forms.Label tic_titleLabel;
            System.Windows.Forms.Label tic_descriptionLabel;
            System.Windows.Forms.Label tic_open_dateLabel;
            System.Windows.Forms.Label tic_statusLabel;
            System.Windows.Forms.Label tic_close_dateLabel;
            System.Windows.Forms.Label tic_use_idLabel;
            System.Windows.Forms.Label tic_req_idLabel;
            System.Windows.Forms.Label tic_div_idLabel;
            System.Windows.Forms.Label tic_loc_idLabel1;
            System.Windows.Forms.Label tic_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTickets));
            this.ticketsDataSet = new tickets.ticketsDataSet();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsTableAdapter = new tickets.ticketsDataSetTableAdapters.ticketsTableAdapter();
            this.tableAdapterManager = new tickets.ticketsDataSetTableAdapters.TableAdapterManager();
            this.divisionsTableAdapter = new tickets.ticketsDataSetTableAdapters.divisionsTableAdapter();
            this.locationsTableAdapter = new tickets.ticketsDataSetTableAdapters.locationsTableAdapter();
            this.requestersTableAdapter = new tickets.ticketsDataSetTableAdapters.requestersTableAdapter();
            this.usersTableAdapter = new tickets.ticketsDataSetTableAdapters.usersTableAdapter();
            this.ticketsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ticketsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ticketsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tic_titleTextBox = new System.Windows.Forms.TextBox();
            this.tic_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.tic_open_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tic_close_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tic_idTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.divisionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.requestersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.locationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.tickets_FechadosToolStrip = new System.Windows.Forms.ToolStrip();
            this.tickets_FechadosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.abertosToolStrip = new System.Windows.Forms.ToolStrip();
            this.abertosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.todosToolStrip = new System.Windows.Forms.ToolStrip();
            this.todosToolStripButton = new System.Windows.Forms.ToolStripButton();
            tic_titleLabel = new System.Windows.Forms.Label();
            tic_descriptionLabel = new System.Windows.Forms.Label();
            tic_open_dateLabel = new System.Windows.Forms.Label();
            tic_statusLabel = new System.Windows.Forms.Label();
            tic_close_dateLabel = new System.Windows.Forms.Label();
            tic_use_idLabel = new System.Windows.Forms.Label();
            tic_req_idLabel = new System.Windows.Forms.Label();
            tic_div_idLabel = new System.Windows.Forms.Label();
            tic_loc_idLabel1 = new System.Windows.Forms.Label();
            tic_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingNavigator)).BeginInit();
            this.ticketsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            this.tickets_FechadosToolStrip.SuspendLayout();
            this.abertosToolStrip.SuspendLayout();
            this.todosToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tic_titleLabel
            // 
            tic_titleLabel.AutoSize = true;
            tic_titleLabel.Location = new System.Drawing.Point(405, 85);
            tic_titleLabel.Name = "tic_titleLabel";
            tic_titleLabel.Size = new System.Drawing.Size(38, 13);
            tic_titleLabel.TabIndex = 2;
            tic_titleLabel.Text = "Título:";
            // 
            // tic_descriptionLabel
            // 
            tic_descriptionLabel.AutoSize = true;
            tic_descriptionLabel.Location = new System.Drawing.Point(405, 114);
            tic_descriptionLabel.Name = "tic_descriptionLabel";
            tic_descriptionLabel.Size = new System.Drawing.Size(58, 13);
            tic_descriptionLabel.TabIndex = 4;
            tic_descriptionLabel.Text = "Descrição:";
            // 
            // tic_open_dateLabel
            // 
            tic_open_dateLabel.AutoSize = true;
            tic_open_dateLabel.Location = new System.Drawing.Point(26, 56);
            tic_open_dateLabel.Name = "tic_open_dateLabel";
            tic_open_dateLabel.Size = new System.Drawing.Size(90, 13);
            tic_open_dateLabel.TabIndex = 6;
            tic_open_dateLabel.Text = "Data de abertura:";
            // 
            // tic_statusLabel
            // 
            tic_statusLabel.AutoSize = true;
            tic_statusLabel.Location = new System.Drawing.Point(26, 146);
            tic_statusLabel.Name = "tic_statusLabel";
            tic_statusLabel.Size = new System.Drawing.Size(52, 13);
            tic_statusLabel.TabIndex = 8;
            tic_statusLabel.Text = "Situação:";
            // 
            // tic_close_dateLabel
            // 
            tic_close_dateLabel.AutoSize = true;
            tic_close_dateLabel.Location = new System.Drawing.Point(26, 78);
            tic_close_dateLabel.Name = "tic_close_dateLabel";
            tic_close_dateLabel.Size = new System.Drawing.Size(101, 13);
            tic_close_dateLabel.TabIndex = 10;
            tic_close_dateLabel.Text = "Data de Conclusão:";
            // 
            // tic_use_idLabel
            // 
            tic_use_idLabel.AutoSize = true;
            tic_use_idLabel.Location = new System.Drawing.Point(148, 117);
            tic_use_idLabel.Name = "tic_use_idLabel";
            tic_use_idLabel.Size = new System.Drawing.Size(93, 13);
            tic_use_idLabel.TabIndex = 12;
            tic_use_idLabel.Text = "Técnico do ticket:";
            tic_use_idLabel.Click += new System.EventHandler(this.tic_use_idLabel_Click);
            // 
            // tic_req_idLabel
            // 
            tic_req_idLabel.AutoSize = true;
            tic_req_idLabel.Location = new System.Drawing.Point(181, 146);
            tic_req_idLabel.Name = "tic_req_idLabel";
            tic_req_idLabel.Size = new System.Drawing.Size(59, 13);
            tic_req_idLabel.TabIndex = 14;
            tic_req_idLabel.Text = "Solicitante:";
            // 
            // tic_div_idLabel
            // 
            tic_div_idLabel.AutoSize = true;
            tic_div_idLabel.Location = new System.Drawing.Point(404, 52);
            tic_div_idLabel.Name = "tic_div_idLabel";
            tic_div_idLabel.Size = new System.Drawing.Size(54, 13);
            tic_div_idLabel.TabIndex = 16;
            tic_div_idLabel.Text = "Problema:";
            // 
            // tic_loc_idLabel1
            // 
            tic_loc_idLabel1.AutoSize = true;
            tic_loc_idLabel1.Location = new System.Drawing.Point(588, 52);
            tic_loc_idLabel1.Name = "tic_loc_idLabel1";
            tic_loc_idLabel1.Size = new System.Drawing.Size(35, 13);
            tic_loc_idLabel1.TabIndex = 20;
            tic_loc_idLabel1.Text = "Setor:";
            // 
            // tic_idLabel
            // 
            tic_idLabel.AutoSize = true;
            tic_idLabel.Location = new System.Drawing.Point(26, 117);
            tic_idLabel.Name = "tic_idLabel";
            tic_idLabel.Size = new System.Drawing.Size(40, 13);
            tic_idLabel.TabIndex = 24;
            tic_idLabel.Text = "Ticket:";
            // 
            // ticketsDataSet
            // 
            this.ticketsDataSet.DataSetName = "ticketsDataSet";
            this.ticketsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "tickets";
            this.ticketsBindingSource.DataSource = this.ticketsDataSet;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.activitesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.divisionsTableAdapter = this.divisionsTableAdapter;
            this.tableAdapterManager.locationsTableAdapter = this.locationsTableAdapter;
            this.tableAdapterManager.requestersTableAdapter = this.requestersTableAdapter;
            this.tableAdapterManager.ticketsTableAdapter = this.ticketsTableAdapter;
            this.tableAdapterManager.UpdateOrder = tickets.ticketsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // divisionsTableAdapter
            // 
            this.divisionsTableAdapter.ClearBeforeFill = true;
            // 
            // locationsTableAdapter
            // 
            this.locationsTableAdapter.ClearBeforeFill = true;
            // 
            // requestersTableAdapter
            // 
            this.requestersTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // ticketsBindingNavigator
            // 
            this.ticketsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ticketsBindingNavigator.BindingSource = this.ticketsBindingSource;
            this.ticketsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ticketsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ticketsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ticketsBindingNavigatorSaveItem});
            this.ticketsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ticketsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ticketsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ticketsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ticketsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ticketsBindingNavigator.Name = "ticketsBindingNavigator";
            this.ticketsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ticketsBindingNavigator.Size = new System.Drawing.Size(1097, 25);
            this.ticketsBindingNavigator.TabIndex = 0;
            this.ticketsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ticketsBindingNavigatorSaveItem
            // 
            this.ticketsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ticketsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ticketsBindingNavigatorSaveItem.Image")));
            this.ticketsBindingNavigatorSaveItem.Name = "ticketsBindingNavigatorSaveItem";
            this.ticketsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ticketsBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.ticketsBindingNavigatorSaveItem.Click += new System.EventHandler(this.ticketsBindingNavigatorSaveItem_Click);
            // 
            // ticketsDataGridView
            // 
            this.ticketsDataGridView.AutoGenerateColumns = false;
            this.ticketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.ticketsDataGridView.DataSource = this.ticketsBindingSource;
            this.ticketsDataGridView.Location = new System.Drawing.Point(29, 238);
            this.ticketsDataGridView.Name = "ticketsDataGridView";
            this.ticketsDataGridView.Size = new System.Drawing.Size(1043, 275);
            this.ticketsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tic_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "tic_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tic_title";
            this.dataGridViewTextBoxColumn2.HeaderText = "tic_title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tic_description";
            this.dataGridViewTextBoxColumn3.HeaderText = "tic_description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tic_status";
            this.dataGridViewTextBoxColumn4.HeaderText = "tic_status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tic_open_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "tic_open_date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tic_close_date";
            this.dataGridViewTextBoxColumn6.HeaderText = "tic_close_date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tic_use_id";
            this.dataGridViewTextBoxColumn7.HeaderText = "tic_use_id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "tic_req_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "tic_req_id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "tic_div_id";
            this.dataGridViewTextBoxColumn9.HeaderText = "tic_div_id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "tic_loc_id";
            this.dataGridViewTextBoxColumn10.HeaderText = "tic_loc_id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // tic_titleTextBox
            // 
            this.tic_titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "tic_title", true));
            this.tic_titleTextBox.Location = new System.Drawing.Point(464, 82);
            this.tic_titleTextBox.Name = "tic_titleTextBox";
            this.tic_titleTextBox.Size = new System.Drawing.Size(282, 20);
            this.tic_titleTextBox.TabIndex = 3;
            // 
            // tic_descriptionTextBox
            // 
            this.tic_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "tic_description", true));
            this.tic_descriptionTextBox.Location = new System.Drawing.Point(464, 111);
            this.tic_descriptionTextBox.Name = "tic_descriptionTextBox";
            this.tic_descriptionTextBox.Size = new System.Drawing.Size(282, 20);
            this.tic_descriptionTextBox.TabIndex = 5;
            // 
            // tic_open_dateDateTimePicker
            // 
            this.tic_open_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ticketsBindingSource, "tic_open_date", true));
            this.tic_open_dateDateTimePicker.Location = new System.Drawing.Point(133, 52);
            this.tic_open_dateDateTimePicker.Name = "tic_open_dateDateTimePicker";
            this.tic_open_dateDateTimePicker.Size = new System.Drawing.Size(230, 20);
            this.tic_open_dateDateTimePicker.TabIndex = 7;
            // 
            // tic_close_dateDateTimePicker
            // 
            this.tic_close_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ticketsBindingSource, "tic_close_date", true));
            this.tic_close_dateDateTimePicker.Location = new System.Drawing.Point(133, 78);
            this.tic_close_dateDateTimePicker.Name = "tic_close_dateDateTimePicker";
            this.tic_close_dateDateTimePicker.Size = new System.Drawing.Size(230, 20);
            this.tic_close_dateDateTimePicker.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Inserir ou alterar registro(s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Lista de Registros:";
            // 
            // tic_idTextBox
            // 
            this.tic_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "tic_id", true));
            this.tic_idTextBox.Location = new System.Drawing.Point(81, 114);
            this.tic_idTextBox.Name = "tic_idTextBox";
            this.tic_idTextBox.Size = new System.Drawing.Size(61, 20);
            this.tic_idTextBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(715, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "_________________________________________________________________________________" +
    "_____________________________________";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ticketsBindingSource, "tic_div_id", true));
            this.comboBox1.DataSource = this.divisionsBindingSource;
            this.comboBox1.DisplayMember = "div_title";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(464, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.ValueMember = "div_id";
            // 
            // divisionsBindingSource
            // 
            this.divisionsBindingSource.DataMember = "divisions";
            this.divisionsBindingSource.DataSource = this.ticketsDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ticketsBindingSource, "tic_use_id", true));
            this.comboBox2.DataSource = this.usersBindingSource;
            this.comboBox2.DisplayMember = "use_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(247, 113);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(116, 21);
            this.comboBox2.TabIndex = 28;
            this.comboBox2.ValueMember = "use_id";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.ticketsDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ticketsBindingSource, "tic_req_id", true));
            this.comboBox3.DataSource = this.requestersBindingSource;
            this.comboBox3.DisplayMember = "req_name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(247, 142);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(116, 21);
            this.comboBox3.TabIndex = 29;
            this.comboBox3.ValueMember = "req_id";
            // 
            // requestersBindingSource
            // 
            this.requestersBindingSource.DataMember = "requesters";
            this.requestersBindingSource.DataSource = this.ticketsDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ticketsBindingSource, "tic_loc_id", true));
            this.comboBox4.DataSource = this.locationsBindingSource;
            this.comboBox4.DisplayMember = "loc_title";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(630, 49);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(116, 21);
            this.comboBox4.TabIndex = 30;
            this.comboBox4.ValueMember = "loc_id";
            // 
            // locationsBindingSource
            // 
            this.locationsBindingSource.DataMember = "locations";
            this.locationsBindingSource.DataSource = this.ticketsDataSet;
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "tic_status", true));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Aberto",
            "Fechado"});
            this.comboBox5.Location = new System.Drawing.Point(81, 142);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(94, 21);
            this.comboBox5.TabIndex = 31;
            // 
            // tickets_FechadosToolStrip
            // 
            this.tickets_FechadosToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.tickets_FechadosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tickets_FechadosToolStripButton});
            this.tickets_FechadosToolStrip.Location = new System.Drawing.Point(143, 210);
            this.tickets_FechadosToolStrip.Name = "tickets_FechadosToolStrip";
            this.tickets_FechadosToolStrip.Size = new System.Drawing.Size(73, 25);
            this.tickets_FechadosToolStrip.TabIndex = 34;
            this.tickets_FechadosToolStrip.Text = "tickets_FechadosToolStrip";
            // 
            // tickets_FechadosToolStripButton
            // 
            this.tickets_FechadosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tickets_FechadosToolStripButton.Name = "tickets_FechadosToolStripButton";
            this.tickets_FechadosToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.tickets_FechadosToolStripButton.Text = "Fechados";
            this.tickets_FechadosToolStripButton.Click += new System.EventHandler(this.tickets_FechadosToolStripButton_Click);
            // 
            // abertosToolStrip
            // 
            this.abertosToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.abertosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abertosToolStripButton});
            this.abertosToolStrip.Location = new System.Drawing.Point(81, 210);
            this.abertosToolStrip.Name = "abertosToolStrip";
            this.abertosToolStrip.Size = new System.Drawing.Size(64, 25);
            this.abertosToolStrip.TabIndex = 35;
            this.abertosToolStrip.Text = "abertosToolStrip";
            // 
            // abertosToolStripButton
            // 
            this.abertosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.abertosToolStripButton.Name = "abertosToolStripButton";
            this.abertosToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.abertosToolStripButton.Text = "Abertos";
            this.abertosToolStripButton.Click += new System.EventHandler(this.abertosToolStripButton_Click);
            // 
            // todosToolStrip
            // 
            this.todosToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.todosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripButton});
            this.todosToolStrip.Location = new System.Drawing.Point(29, 210);
            this.todosToolStrip.Name = "todosToolStrip";
            this.todosToolStrip.Size = new System.Drawing.Size(54, 25);
            this.todosToolStrip.TabIndex = 36;
            this.todosToolStrip.Text = "todosToolStrip";
            // 
            // todosToolStripButton
            // 
            this.todosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.todosToolStripButton.Name = "todosToolStripButton";
            this.todosToolStripButton.Size = new System.Drawing.Size(42, 22);
            this.todosToolStripButton.Text = "Todos";
            this.todosToolStripButton.Click += new System.EventHandler(this.todosToolStripButton_Click);
            // 
            // frmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1097, 533);
            this.Controls.Add(this.todosToolStrip);
            this.Controls.Add(this.abertosToolStrip);
            this.Controls.Add(this.tickets_FechadosToolStrip);
            this.Controls.Add(this.ticketsDataGridView);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(tic_idLabel);
            this.Controls.Add(this.tic_idTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(tic_loc_idLabel1);
            this.Controls.Add(tic_div_idLabel);
            this.Controls.Add(tic_req_idLabel);
            this.Controls.Add(tic_use_idLabel);
            this.Controls.Add(tic_close_dateLabel);
            this.Controls.Add(this.tic_close_dateDateTimePicker);
            this.Controls.Add(tic_statusLabel);
            this.Controls.Add(tic_open_dateLabel);
            this.Controls.Add(this.tic_open_dateDateTimePicker);
            this.Controls.Add(tic_descriptionLabel);
            this.Controls.Add(this.tic_descriptionTextBox);
            this.Controls.Add(tic_titleLabel);
            this.Controls.Add(this.tic_titleTextBox);
            this.Controls.Add(this.ticketsBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Tickets";
            this.Load += new System.EventHandler(this.frmTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingNavigator)).EndInit();
            this.ticketsBindingNavigator.ResumeLayout(false);
            this.ticketsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            this.tickets_FechadosToolStrip.ResumeLayout(false);
            this.tickets_FechadosToolStrip.PerformLayout();
            this.abertosToolStrip.ResumeLayout(false);
            this.abertosToolStrip.PerformLayout();
            this.todosToolStrip.ResumeLayout(false);
            this.todosToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ticketsDataSet ticketsDataSet;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private ticketsDataSetTableAdapters.ticketsTableAdapter ticketsTableAdapter;
        private ticketsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ticketsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ticketsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ticketsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox tic_titleTextBox;
        private System.Windows.Forms.TextBox tic_descriptionTextBox;
        private System.Windows.Forms.DateTimePicker tic_open_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker tic_close_dateDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tic_idTextBox;
        private System.Windows.Forms.Label label3;
        private ticketsDataSetTableAdapters.divisionsTableAdapter divisionsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource divisionsBindingSource;
        private ticketsDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private ticketsDataSetTableAdapters.requestersTableAdapter requestersTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource requestersBindingSource;
        private ticketsDataSetTableAdapters.locationsTableAdapter locationsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource locationsBindingSource;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ToolStrip tickets_FechadosToolStrip;
        private System.Windows.Forms.ToolStripButton tickets_FechadosToolStripButton;
        private System.Windows.Forms.ToolStrip abertosToolStrip;
        private System.Windows.Forms.ToolStripButton abertosToolStripButton;
        private System.Windows.Forms.ToolStrip todosToolStrip;
        private System.Windows.Forms.ToolStripButton todosToolStripButton;
    }
}