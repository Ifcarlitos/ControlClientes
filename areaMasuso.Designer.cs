
namespace Control_Caldea
{
    partial class areaMasuso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(areaMasuso));
            System.Windows.Forms.Label fecha_entradaLabel;
            System.Windows.Forms.Label fecha_entradaLabel1;
            System.Windows.Forms.Label id_areaLabel;
            this.caldea = new Control_Caldea.caldea();
            this.lecturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturaTableAdapter = new Control_Caldea.caldeaTableAdapters.lecturaTableAdapter();
            this.tableAdapterManager = new Control_Caldea.caldeaTableAdapters.TableAdapterManager();
            this.lecturaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lecturaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fecha_entradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_entradaDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.id_areaTextBox = new System.Windows.Forms.TextBox();
            this.lecturaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            fecha_entradaLabel = new System.Windows.Forms.Label();
            fecha_entradaLabel1 = new System.Windows.Forms.Label();
            id_areaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.caldea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturaBindingNavigator)).BeginInit();
            this.lecturaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // caldea
            // 
            this.caldea.DataSetName = "caldea";
            this.caldea.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturaBindingSource
            // 
            this.lecturaBindingSource.DataMember = "lectura";
            this.lecturaBindingSource.DataSource = this.caldea;
            // 
            // lecturaTableAdapter
            // 
            this.lecturaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aplicarTableAdapter = null;
            this.tableAdapterManager.areaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.descuentos_personasTableAdapter = null;
            this.tableAdapterManager.descuentoTableAdapter = null;
            this.tableAdapterManager.Info_clienteTableAdapter = null;
            this.tableAdapterManager.invitadoTableAdapter = null;
            this.tableAdapterManager.lecturaTableAdapter = this.lecturaTableAdapter;
            this.tableAdapterManager.RelaciónTableAdapter = null;
            this.tableAdapterManager.tagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Control_Caldea.caldeaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lecturaBindingNavigator
            // 
            this.lecturaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lecturaBindingNavigator.BindingSource = this.lecturaBindingSource;
            this.lecturaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lecturaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lecturaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lecturaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lecturaBindingNavigatorSaveItem});
            this.lecturaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lecturaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lecturaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lecturaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lecturaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lecturaBindingNavigator.Name = "lecturaBindingNavigator";
            this.lecturaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lecturaBindingNavigator.Size = new System.Drawing.Size(542, 27);
            this.lecturaBindingNavigator.TabIndex = 0;
            this.lecturaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // lecturaBindingNavigatorSaveItem
            // 
            this.lecturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lecturaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lecturaBindingNavigatorSaveItem.Image")));
            this.lecturaBindingNavigatorSaveItem.Name = "lecturaBindingNavigatorSaveItem";
            this.lecturaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.lecturaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.lecturaBindingNavigatorSaveItem.Click += new System.EventHandler(this.lecturaBindingNavigatorSaveItem_Click);
            // 
            // fecha_entradaLabel
            // 
            fecha_entradaLabel.AutoSize = true;
            fecha_entradaLabel.Location = new System.Drawing.Point(12, 64);
            fecha_entradaLabel.Name = "fecha_entradaLabel";
            fecha_entradaLabel.Size = new System.Drawing.Size(104, 17);
            fecha_entradaLabel.TabIndex = 1;
            fecha_entradaLabel.Text = "Fecha entrada:";
            fecha_entradaLabel.Click += new System.EventHandler(this.fecha_entradaLabel_Click);
            // 
            // fecha_entradaDateTimePicker
            // 
            this.fecha_entradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lecturaBindingSource, "Fecha entrada", true));
            this.fecha_entradaDateTimePicker.Location = new System.Drawing.Point(122, 60);
            this.fecha_entradaDateTimePicker.Name = "fecha_entradaDateTimePicker";
            this.fecha_entradaDateTimePicker.Size = new System.Drawing.Size(270, 22);
            this.fecha_entradaDateTimePicker.TabIndex = 2;
            this.fecha_entradaDateTimePicker.ValueChanged += new System.EventHandler(this.fecha_entradaDateTimePicker_ValueChanged);
            // 
            // fecha_entradaLabel1
            // 
            fecha_entradaLabel1.AutoSize = true;
            fecha_entradaLabel1.Location = new System.Drawing.Point(12, 110);
            fecha_entradaLabel1.Name = "fecha_entradaLabel1";
            fecha_entradaLabel1.Size = new System.Drawing.Size(85, 17);
            fecha_entradaLabel1.TabIndex = 3;
            fecha_entradaLabel1.Text = "Fecha Final:";
            // 
            // fecha_entradaDateTimePicker1
            // 
            this.fecha_entradaDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lecturaBindingSource, "Fecha entrada", true));
            this.fecha_entradaDateTimePicker1.Location = new System.Drawing.Point(122, 106);
            this.fecha_entradaDateTimePicker1.Name = "fecha_entradaDateTimePicker1";
            this.fecha_entradaDateTimePicker1.Size = new System.Drawing.Size(270, 22);
            this.fecha_entradaDateTimePicker1.TabIndex = 4;
            // 
            // id_areaLabel
            // 
            id_areaLabel.AutoSize = true;
            id_areaLabel.Location = new System.Drawing.Point(60, 162);
            id_areaLabel.Name = "id_areaLabel";
            id_areaLabel.Size = new System.Drawing.Size(56, 17);
            id_areaLabel.TabIndex = 5;
            id_areaLabel.Text = "id area:";
            // 
            // id_areaTextBox
            // 
            this.id_areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturaBindingSource, "id_area", true));
            this.id_areaTextBox.Location = new System.Drawing.Point(122, 159);
            this.id_areaTextBox.Name = "id_areaTextBox";
            this.id_areaTextBox.Size = new System.Drawing.Size(159, 22);
            this.id_areaTextBox.TabIndex = 6;
            // 
            // lecturaDataGridView
            // 
            this.lecturaDataGridView.AutoGenerateColumns = false;
            this.lecturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lecturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.lecturaDataGridView.DataSource = this.lecturaBindingSource;
            this.lecturaDataGridView.Location = new System.Drawing.Point(0, 205);
            this.lecturaDataGridView.Name = "lecturaDataGridView";
            this.lecturaDataGridView.RowHeadersWidth = 51;
            this.lecturaDataGridView.RowTemplate.Height = 24;
            this.lecturaDataGridView.Size = new System.Drawing.Size(534, 88);
            this.lecturaDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_tag";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_tag";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_area";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_area";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fecha entrada";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha entrada";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // areaMasuso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lecturaDataGridView);
            this.Controls.Add(id_areaLabel);
            this.Controls.Add(this.id_areaTextBox);
            this.Controls.Add(fecha_entradaLabel1);
            this.Controls.Add(this.fecha_entradaDateTimePicker1);
            this.Controls.Add(fecha_entradaLabel);
            this.Controls.Add(this.fecha_entradaDateTimePicker);
            this.Controls.Add(this.lecturaBindingNavigator);
            this.Name = "areaMasuso";
            this.Text = "areaMasuso";
            this.Load += new System.EventHandler(this.areaMasuso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caldea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturaBindingNavigator)).EndInit();
            this.lecturaBindingNavigator.ResumeLayout(false);
            this.lecturaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private caldea caldea;
        private System.Windows.Forms.BindingSource lecturaBindingSource;
        private caldeaTableAdapters.lecturaTableAdapter lecturaTableAdapter;
        private caldeaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lecturaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lecturaBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker fecha_entradaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_entradaDateTimePicker1;
        private System.Windows.Forms.TextBox id_areaTextBox;
        private System.Windows.Forms.DataGridView lecturaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
    }
}