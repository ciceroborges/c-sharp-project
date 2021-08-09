namespace tickets
{
    partial class frmRequesters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequesters));
            System.Windows.Forms.Label req_nameLabel;
            System.Windows.Forms.Label req_contactLabel;
            System.Windows.Forms.Label req_loc_idLabel;
            this.ticketsDataSet = new tickets.ticketsDataSet();
            this.requestersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestersTableAdapter = new tickets.ticketsDataSetTableAdapters.requestersTableAdapter();
            this.tableAdapterManager = new tickets.ticketsDataSetTableAdapters.TableAdapterManager();
            this.requestersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.requestersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.requestersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.req_nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.locationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationsTableAdapter = new tickets.ticketsDataSetTableAdapters.locationsTableAdapter();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            req_nameLabel = new System.Windows.Forms.Label();
            req_contactLabel = new System.Windows.Forms.Label();
            req_loc_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestersBindingNavigator)).BeginInit();
            this.requestersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketsDataSet
            // 
            this.ticketsDataSet.DataSetName = "ticketsDataSet";
            this.ticketsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestersBindingSource
            // 
            this.requestersBindingSource.DataMember = "requesters";
            this.requestersBindingSource.DataSource = this.ticketsDataSet;
            // 
            // requestersTableAdapter
            // 
            this.requestersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.activitesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.divisionsTableAdapter = null;
            this.tableAdapterManager.locationsTableAdapter = this.locationsTableAdapter;
            this.tableAdapterManager.requestersTableAdapter = this.requestersTableAdapter;
            this.tableAdapterManager.ticketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tickets.ticketsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // requestersBindingNavigator
            // 
            this.requestersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.requestersBindingNavigator.BindingSource = this.requestersBindingSource;
            this.requestersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.requestersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.requestersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.requestersBindingNavigatorSaveItem});
            this.requestersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.requestersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.requestersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.requestersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.requestersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.requestersBindingNavigator.Name = "requestersBindingNavigator";
            this.requestersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.requestersBindingNavigator.Size = new System.Drawing.Size(673, 25);
            this.requestersBindingNavigator.TabIndex = 0;
            this.requestersBindingNavigator.Text = "bindingNavigator1";
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
            // requestersBindingNavigatorSaveItem
            // 
            this.requestersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.requestersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("requestersBindingNavigatorSaveItem.Image")));
            this.requestersBindingNavigatorSaveItem.Name = "requestersBindingNavigatorSaveItem";
            this.requestersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.requestersBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.requestersBindingNavigatorSaveItem.Click += new System.EventHandler(this.requestersBindingNavigatorSaveItem_Click);
            // 
            // requestersDataGridView
            // 
            this.requestersDataGridView.AutoGenerateColumns = false;
            this.requestersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.requestersDataGridView.DataSource = this.requestersBindingSource;
            this.requestersDataGridView.Location = new System.Drawing.Point(210, 55);
            this.requestersDataGridView.Name = "requestersDataGridView";
            this.requestersDataGridView.Size = new System.Drawing.Size(445, 220);
            this.requestersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "req_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "req_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "req_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "req_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "req_contact";
            this.dataGridViewTextBoxColumn3.HeaderText = "req_contact";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "req_loc_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "req_loc_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // req_nameLabel
            // 
            req_nameLabel.AutoSize = true;
            req_nameLabel.Location = new System.Drawing.Point(12, 58);
            req_nameLabel.Name = "req_nameLabel";
            req_nameLabel.Size = new System.Drawing.Size(38, 13);
            req_nameLabel.TabIndex = 2;
            req_nameLabel.Text = "Nome:";
            // 
            // req_nameTextBox
            // 
            this.req_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestersBindingSource, "req_name", true));
            this.req_nameTextBox.Location = new System.Drawing.Point(65, 55);
            this.req_nameTextBox.Name = "req_nameTextBox";
            this.req_nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.req_nameTextBox.TabIndex = 3;
            // 
            // req_contactLabel
            // 
            req_contactLabel.AutoSize = true;
            req_contactLabel.Location = new System.Drawing.Point(12, 83);
            req_contactLabel.Name = "req_contactLabel";
            req_contactLabel.Size = new System.Drawing.Size(47, 13);
            req_contactLabel.TabIndex = 4;
            req_contactLabel.Text = "Contato:";
            // 
            // req_loc_idLabel
            // 
            req_loc_idLabel.AutoSize = true;
            req_loc_idLabel.Location = new System.Drawing.Point(12, 106);
            req_loc_idLabel.Name = "req_loc_idLabel";
            req_loc_idLabel.Size = new System.Drawing.Size(35, 13);
            req_loc_idLabel.TabIndex = 6;
            req_loc_idLabel.Text = "Setor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Inserir ou alterar registro(s):";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.requestersBindingSource, "req_loc_id", true));
            this.comboBox1.DataSource = this.locationsBindingSource;
            this.comboBox1.DisplayMember = "loc_title";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "loc_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lista de registros:";
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestersBindingSource, "req_contact", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(65, 80);
            this.maskedTextBox1.Mask = "(99) 99999-9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(120, 20);
            this.maskedTextBox1.TabIndex = 11;
            // 
            // frmRequesters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 301);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(req_loc_idLabel);
            this.Controls.Add(req_contactLabel);
            this.Controls.Add(req_nameLabel);
            this.Controls.Add(this.req_nameTextBox);
            this.Controls.Add(this.requestersDataGridView);
            this.Controls.Add(this.requestersBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRequesters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Solicitantes";
            this.Load += new System.EventHandler(this.frmRequesters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestersBindingNavigator)).EndInit();
            this.requestersBindingNavigator.ResumeLayout(false);
            this.requestersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ticketsDataSet ticketsDataSet;
        private System.Windows.Forms.BindingSource requestersBindingSource;
        private ticketsDataSetTableAdapters.requestersTableAdapter requestersTableAdapter;
        private ticketsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator requestersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton requestersBindingNavigatorSaveItem;
        private ticketsDataSetTableAdapters.locationsTableAdapter locationsTableAdapter;
        private System.Windows.Forms.DataGridView requestersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox req_nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource locationsBindingSource;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}