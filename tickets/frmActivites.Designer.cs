namespace tickets
{
    partial class frmActivites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivites));
            System.Windows.Forms.Label act_titleLabel;
            System.Windows.Forms.Label act_dateLabel;
            System.Windows.Forms.Label act_use_idLabel;
            System.Windows.Forms.Label act_loc_idLabel;
            this.ticketsDataSet = new tickets.ticketsDataSet();
            this.activitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activitesTableAdapter = new tickets.ticketsDataSetTableAdapters.activitesTableAdapter();
            this.tableAdapterManager = new tickets.ticketsDataSetTableAdapters.TableAdapterManager();
            this.activitesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.activitesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.activitesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.act_titleTextBox = new System.Windows.Forms.TextBox();
            this.act_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new tickets.ticketsDataSetTableAdapters.usersTableAdapter();
            this.locationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationsTableAdapter = new tickets.ticketsDataSetTableAdapters.locationsTableAdapter();
            act_titleLabel = new System.Windows.Forms.Label();
            act_dateLabel = new System.Windows.Forms.Label();
            act_use_idLabel = new System.Windows.Forms.Label();
            act_loc_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitesBindingNavigator)).BeginInit();
            this.activitesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activitesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketsDataSet
            // 
            this.ticketsDataSet.DataSetName = "ticketsDataSet";
            this.ticketsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activitesBindingSource
            // 
            this.activitesBindingSource.DataMember = "activites";
            this.activitesBindingSource.DataSource = this.ticketsDataSet;
            // 
            // activitesTableAdapter
            // 
            this.activitesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.activitesTableAdapter = this.activitesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.divisionsTableAdapter = null;
            this.tableAdapterManager.locationsTableAdapter = this.locationsTableAdapter;
            this.tableAdapterManager.requestersTableAdapter = null;
            this.tableAdapterManager.ticketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tickets.ticketsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // activitesBindingNavigator
            // 
            this.activitesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.activitesBindingNavigator.BindingSource = this.activitesBindingSource;
            this.activitesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.activitesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.activitesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.activitesBindingNavigatorSaveItem});
            this.activitesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.activitesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.activitesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.activitesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.activitesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.activitesBindingNavigator.Name = "activitesBindingNavigator";
            this.activitesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.activitesBindingNavigator.Size = new System.Drawing.Size(870, 25);
            this.activitesBindingNavigator.TabIndex = 0;
            this.activitesBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // activitesBindingNavigatorSaveItem
            // 
            this.activitesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.activitesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("activitesBindingNavigatorSaveItem.Image")));
            this.activitesBindingNavigatorSaveItem.Name = "activitesBindingNavigatorSaveItem";
            this.activitesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.activitesBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.activitesBindingNavigatorSaveItem.Click += new System.EventHandler(this.activitesBindingNavigatorSaveItem_Click_1);
            // 
            // activitesDataGridView
            // 
            this.activitesDataGridView.AutoGenerateColumns = false;
            this.activitesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.activitesDataGridView.DataSource = this.activitesBindingSource;
            this.activitesDataGridView.Location = new System.Drawing.Point(303, 48);
            this.activitesDataGridView.Name = "activitesDataGridView";
            this.activitesDataGridView.Size = new System.Drawing.Size(546, 220);
            this.activitesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "act_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "act_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "act_title";
            this.dataGridViewTextBoxColumn2.HeaderText = "act_title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "act_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "act_date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "act_use_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "act_use_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "act_loc_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "act_loc_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // act_titleLabel
            // 
            act_titleLabel.AutoSize = true;
            act_titleLabel.Location = new System.Drawing.Point(15, 51);
            act_titleLabel.Name = "act_titleLabel";
            act_titleLabel.Size = new System.Drawing.Size(54, 13);
            act_titleLabel.TabIndex = 2;
            act_titleLabel.Text = "Atividade:";
            // 
            // act_titleTextBox
            // 
            this.act_titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activitesBindingSource, "act_title", true));
            this.act_titleTextBox.Location = new System.Drawing.Point(75, 48);
            this.act_titleTextBox.Name = "act_titleTextBox";
            this.act_titleTextBox.Size = new System.Drawing.Size(210, 20);
            this.act_titleTextBox.TabIndex = 3;
            // 
            // act_dateLabel
            // 
            act_dateLabel.AutoSize = true;
            act_dateLabel.Location = new System.Drawing.Point(15, 74);
            act_dateLabel.Name = "act_dateLabel";
            act_dateLabel.Size = new System.Drawing.Size(33, 13);
            act_dateLabel.TabIndex = 4;
            act_dateLabel.Text = "Data:";
            // 
            // act_dateDateTimePicker
            // 
            this.act_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.activitesBindingSource, "act_date", true));
            this.act_dateDateTimePicker.Location = new System.Drawing.Point(75, 74);
            this.act_dateDateTimePicker.Name = "act_dateDateTimePicker";
            this.act_dateDateTimePicker.Size = new System.Drawing.Size(210, 20);
            this.act_dateDateTimePicker.TabIndex = 5;
            // 
            // act_use_idLabel
            // 
            act_use_idLabel.AutoSize = true;
            act_use_idLabel.Location = new System.Drawing.Point(15, 103);
            act_use_idLabel.Name = "act_use_idLabel";
            act_use_idLabel.Size = new System.Drawing.Size(49, 13);
            act_use_idLabel.TabIndex = 6;
            act_use_idLabel.Text = "Técnico:";
            // 
            // act_loc_idLabel
            // 
            act_loc_idLabel.AutoSize = true;
            act_loc_idLabel.Location = new System.Drawing.Point(15, 130);
            act_loc_idLabel.Name = "act_loc_idLabel";
            act_loc_idLabel.Size = new System.Drawing.Size(35, 13);
            act_loc_idLabel.TabIndex = 8;
            act_loc_idLabel.Text = "Setor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inserir ou alterar registro(s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lista de registros:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.activitesBindingSource, "act_use_id", true));
            this.comboBox1.DataSource = this.usersBindingSource;
            this.comboBox1.DisplayMember = "use_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "use_id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.activitesBindingSource, "act_loc_id", true));
            this.comboBox2.DataSource = this.locationsBindingSource;
            this.comboBox2.DisplayMember = "loc_title";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(75, 127);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(210, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.ValueMember = "loc_id";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.ticketsDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // locationsBindingSource
            // 
            this.locationsBindingSource.DataMember = "locations";
            this.locationsBindingSource.DataSource = this.ticketsDataSet;
            // 
            // locationsTableAdapter
            // 
            this.locationsTableAdapter.ClearBeforeFill = true;
            // 
            // frmActivites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 292);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(act_loc_idLabel);
            this.Controls.Add(act_use_idLabel);
            this.Controls.Add(act_dateLabel);
            this.Controls.Add(this.act_dateDateTimePicker);
            this.Controls.Add(act_titleLabel);
            this.Controls.Add(this.act_titleTextBox);
            this.Controls.Add(this.activitesDataGridView);
            this.Controls.Add(this.activitesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActivites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Atividades";
            this.Load += new System.EventHandler(this.frmActivites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitesBindingNavigator)).EndInit();
            this.activitesBindingNavigator.ResumeLayout(false);
            this.activitesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activitesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ticketsDataSet ticketsDataSet;
        private System.Windows.Forms.BindingSource activitesBindingSource;
        private ticketsDataSetTableAdapters.activitesTableAdapter activitesTableAdapter;
        private ticketsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator activitesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton activitesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView activitesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox act_titleTextBox;
        private System.Windows.Forms.DateTimePicker act_dateDateTimePicker;
        private ticketsDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private ticketsDataSetTableAdapters.locationsTableAdapter locationsTableAdapter;
        private System.Windows.Forms.BindingSource locationsBindingSource;
    }
}