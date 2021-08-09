
namespace Control_Caldea
{
    partial class tag
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
            System.Windows.Forms.Label id_tagLabel;
            System.Windows.Forms.Label id_clienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tag));
            this.tagBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caldea = new Control_Caldea.caldea();
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
            this.tagBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.id_tagTextBox = new System.Windows.Forms.TextBox();
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            this.tagTableAdapter = new Control_Caldea.caldeaTableAdapters.tagTableAdapter();
            this.tableAdapterManager = new Control_Caldea.caldeaTableAdapters.TableAdapterManager();
            this.tagDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            id_tagLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingNavigator)).BeginInit();
            this.tagBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caldea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_tagLabel
            // 
            id_tagLabel.AutoSize = true;
            id_tagLabel.Location = new System.Drawing.Point(16, 342);
            id_tagLabel.Name = "id_tagLabel";
            id_tagLabel.Size = new System.Drawing.Size(47, 17);
            id_tagLabel.TabIndex = 6;
            id_tagLabel.Text = "id tag:";
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(16, 380);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(68, 17);
            id_clienteLabel.TabIndex = 10;
            id_clienteLabel.Text = "id cliente:";
            // 
            // tagBindingNavigator
            // 
            this.tagBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tagBindingNavigator.BindingSource = this.tagBindingSource;
            this.tagBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tagBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tagBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tagBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tagBindingNavigatorSaveItem});
            this.tagBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tagBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tagBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tagBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tagBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tagBindingNavigator.Name = "tagBindingNavigator";
            this.tagBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tagBindingNavigator.Size = new System.Drawing.Size(864, 27);
            this.tagBindingNavigator.TabIndex = 0;
            this.tagBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // tagBindingSource
            // 
            this.tagBindingSource.DataMember = "tag";
            this.tagBindingSource.DataSource = this.caldea;
            // 
            // caldea
            // 
            this.caldea.DataSetName = "caldea";
            this.caldea.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tagBindingNavigatorSaveItem
            // 
            this.tagBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tagBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tagBindingNavigatorSaveItem.Image")));
            this.tagBindingNavigatorSaveItem.Name = "tagBindingNavigatorSaveItem";
            this.tagBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tagBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tagBindingNavigatorSaveItem.Click += new System.EventHandler(this.tagBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Activar tag";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(571, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Desactivar tag";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Asignar tag";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(171, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "Eliminar tag";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // id_tagTextBox
            // 
            this.id_tagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagBindingSource, "id_tag", true));
            this.id_tagTextBox.Location = new System.Drawing.Point(90, 339);
            this.id_tagTextBox.Name = "id_tagTextBox";
            this.id_tagTextBox.Size = new System.Drawing.Size(104, 22);
            this.id_tagTextBox.TabIndex = 7;
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagBindingSource, "id_cliente", true));
            this.id_clienteTextBox.Location = new System.Drawing.Point(90, 377);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.id_clienteTextBox.Size = new System.Drawing.Size(104, 22);
            this.id_clienteTextBox.TabIndex = 11;
            // 
            // tagTableAdapter
            // 
            this.tagTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aplicarTableAdapter = null;
            this.tableAdapterManager.areaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.descuentoTableAdapter = null;
            this.tableAdapterManager.invitadoTableAdapter = null;
            this.tableAdapterManager.lecturaTableAdapter = null;
            this.tableAdapterManager.RelaciónTableAdapter = null;
            this.tableAdapterManager.tagTableAdapter = this.tagTableAdapter;
            this.tableAdapterManager.UpdateOrder = Control_Caldea.caldeaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tagDataGridView
            // 
            this.tagDataGridView.AutoGenerateColumns = false;
            this.tagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tagDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn2});
            this.tagDataGridView.DataSource = this.tagBindingSource;
            this.tagDataGridView.Location = new System.Drawing.Point(0, 30);
            this.tagDataGridView.Name = "tagDataGridView";
            this.tagDataGridView.RowHeadersWidth = 51;
            this.tagDataGridView.RowTemplate.Height = 24;
            this.tagDataGridView.Size = new System.Drawing.Size(553, 220);
            this.tagDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_tag";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_tag";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Estado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Estado";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_cliente";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "abonado";
            this.dataGridViewCheckBoxColumn2.HeaderText = "abonado";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 125;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(571, 207);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 43);
            this.button5.TabIndex = 13;
            this.button5.Text = "Desabonar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(571, 148);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 43);
            this.button6.TabIndex = 12;
            this.button6.Text = "Abonar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Solo se puede asiganr un tag por cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tagDataGridView);
            this.Controls.Add(id_tagLabel);
            this.Controls.Add(this.id_tagTextBox);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tagBindingNavigator);
            this.Name = "tag";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingNavigator)).EndInit();
            this.tagBindingNavigator.ResumeLayout(false);
            this.tagBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caldea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private caldea caldea;
        private System.Windows.Forms.BindingSource tagBindingSource;
        private caldeaTableAdapters.tagTableAdapter tagTableAdapter;
        private caldeaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tagBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tagBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox id_tagTextBox;
        private System.Windows.Forms.TextBox id_clienteTextBox;
        private System.Windows.Forms.DataGridView tagDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
    }
}