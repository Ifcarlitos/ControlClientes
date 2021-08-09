
namespace Control_Caldea
{
    partial class Tiempo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tiempo));
            System.Windows.Forms.Label id_tagLabel;
            System.Windows.Forms.Label id_areaLabel;
            System.Windows.Forms.Label tiempoLabel;
            System.Windows.Forms.Label fechaLabel;
            this.caldea = new Control_Caldea.caldea();
            this.info_tiempoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.info_tiempoTableAdapter = new Control_Caldea.caldeaTableAdapters.info_tiempoTableAdapter();
            this.tableAdapterManager = new Control_Caldea.caldeaTableAdapters.TableAdapterManager();
            this.info_tiempoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.info_tiempoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.info_tiempoDataGridView = new System.Windows.Forms.DataGridView();
            this.id_tagTextBox = new System.Windows.Forms.TextBox();
            this.id_areaTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.info_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.info_clienteTableAdapter = new Control_Caldea.caldeaTableAdapters.Info_clienteTableAdapter();
            this.idtagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            id_tagLabel = new System.Windows.Forms.Label();
            id_areaLabel = new System.Windows.Forms.Label();
            tiempoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.caldea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_tiempoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_tiempoBindingNavigator)).BeginInit();
            this.info_tiempoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info_tiempoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // caldea
            // 
            this.caldea.DataSetName = "caldea";
            this.caldea.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // info_tiempoBindingSource
            // 
            this.info_tiempoBindingSource.DataMember = "info_tiempo";
            this.info_tiempoBindingSource.DataSource = this.caldea;
            // 
            // info_tiempoTableAdapter
            // 
            this.info_tiempoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aplicarTableAdapter = null;
            this.tableAdapterManager.areaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.descuentos_personasTableAdapter = null;
            this.tableAdapterManager.descuentoTableAdapter = null;
            this.tableAdapterManager.Info_clienteTableAdapter = this.info_clienteTableAdapter;
            this.tableAdapterManager.info_tiempoTableAdapter = this.info_tiempoTableAdapter;
            this.tableAdapterManager.invitadoTableAdapter = null;
            this.tableAdapterManager.lecturaTableAdapter = null;
            this.tableAdapterManager.RelaciónTableAdapter = null;
            this.tableAdapterManager.tagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Control_Caldea.caldeaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // info_tiempoBindingNavigator
            // 
            this.info_tiempoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.info_tiempoBindingNavigator.BindingSource = this.info_tiempoBindingSource;
            this.info_tiempoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.info_tiempoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.info_tiempoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.info_tiempoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.info_tiempoBindingNavigatorSaveItem});
            this.info_tiempoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.info_tiempoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.info_tiempoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.info_tiempoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.info_tiempoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.info_tiempoBindingNavigator.Name = "info_tiempoBindingNavigator";
            this.info_tiempoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.info_tiempoBindingNavigator.Size = new System.Drawing.Size(550, 27);
            this.info_tiempoBindingNavigator.TabIndex = 0;
            this.info_tiempoBindingNavigator.Text = "bindingNavigator1";
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
            // info_tiempoBindingNavigatorSaveItem
            // 
            this.info_tiempoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.info_tiempoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("info_tiempoBindingNavigatorSaveItem.Image")));
            this.info_tiempoBindingNavigatorSaveItem.Name = "info_tiempoBindingNavigatorSaveItem";
            this.info_tiempoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.info_tiempoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.info_tiempoBindingNavigatorSaveItem.Click += new System.EventHandler(this.info_tiempoBindingNavigatorSaveItem_Click);
            // 
            // info_tiempoDataGridView
            // 
            this.info_tiempoDataGridView.AutoGenerateColumns = false;
            this.info_tiempoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.info_tiempoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtagDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.tiempoDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn});
            this.info_tiempoDataGridView.DataSource = this.info_clienteBindingSource;
            this.info_tiempoDataGridView.Location = new System.Drawing.Point(12, 30);
            this.info_tiempoDataGridView.Name = "info_tiempoDataGridView";
            this.info_tiempoDataGridView.RowHeadersWidth = 51;
            this.info_tiempoDataGridView.RowTemplate.Height = 24;
            this.info_tiempoDataGridView.Size = new System.Drawing.Size(518, 220);
            this.info_tiempoDataGridView.TabIndex = 1;
            // 
            // id_tagLabel
            // 
            id_tagLabel.AutoSize = true;
            id_tagLabel.Location = new System.Drawing.Point(16, 277);
            id_tagLabel.Name = "id_tagLabel";
            id_tagLabel.Size = new System.Drawing.Size(47, 17);
            id_tagLabel.TabIndex = 2;
            id_tagLabel.Text = "id tag:";
            // 
            // id_tagTextBox
            // 
            this.id_tagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.info_tiempoBindingSource, "id_tag", true));
            this.id_tagTextBox.Location = new System.Drawing.Point(78, 274);
            this.id_tagTextBox.Name = "id_tagTextBox";
            this.id_tagTextBox.Size = new System.Drawing.Size(252, 22);
            this.id_tagTextBox.TabIndex = 3;
            // 
            // id_areaLabel
            // 
            id_areaLabel.AutoSize = true;
            id_areaLabel.Location = new System.Drawing.Point(16, 305);
            id_areaLabel.Name = "id_areaLabel";
            id_areaLabel.Size = new System.Drawing.Size(56, 17);
            id_areaLabel.TabIndex = 4;
            id_areaLabel.Text = "id area:";
            // 
            // id_areaTextBox
            // 
            this.id_areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.info_tiempoBindingSource, "id_area", true));
            this.id_areaTextBox.Location = new System.Drawing.Point(78, 302);
            this.id_areaTextBox.Name = "id_areaTextBox";
            this.id_areaTextBox.Size = new System.Drawing.Size(252, 22);
            this.id_areaTextBox.TabIndex = 5;
            // 
            // tiempoLabel
            // 
            tiempoLabel.AutoSize = true;
            tiempoLabel.Location = new System.Drawing.Point(16, 334);
            tiempoLabel.Name = "tiempoLabel";
            tiempoLabel.Size = new System.Drawing.Size(128, 17);
            tiempoLabel.TabIndex = 6;
            tiempoLabel.Text = "tiempo (hh:mm:ss):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 334);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 86);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar tiempo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // info_clienteBindingSource
            // 
            this.info_clienteBindingSource.DataMember = "Info_cliente";
            this.info_clienteBindingSource.DataSource = this.caldea;
            // 
            // info_clienteTableAdapter
            // 
            this.info_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // idtagDataGridViewTextBoxColumn
            // 
            this.idtagDataGridViewTextBoxColumn.DataPropertyName = "id_tag";
            this.idtagDataGridViewTextBoxColumn.HeaderText = "id_tag";
            this.idtagDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtagDataGridViewTextBoxColumn.Name = "idtagDataGridViewTextBoxColumn";
            this.idtagDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tiempoDataGridViewTextBoxColumn
            // 
            this.tiempoDataGridViewTextBoxColumn.DataPropertyName = "tiempo";
            this.tiempoDataGridViewTextBoxColumn.HeaderText = "tiempo";
            this.tiempoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tiempoDataGridViewTextBoxColumn.Name = "tiempoDataGridViewTextBoxColumn";
            this.tiempoDataGridViewTextBoxColumn.Width = 125;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "area";
            this.areaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(25, 366);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(47, 17);
            fechaLabel.TabIndex = 9;
            fechaLabel.Text = "fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.info_clienteBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(78, 362);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(252, 22);
            this.fechaDateTimePicker.TabIndex = 10;
            // 
            // Tiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 429);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(id_tagLabel);
            this.Controls.Add(this.id_tagTextBox);
            this.Controls.Add(id_areaLabel);
            this.Controls.Add(this.id_areaTextBox);
            this.Controls.Add(tiempoLabel);
            this.Controls.Add(this.info_tiempoDataGridView);
            this.Controls.Add(this.info_tiempoBindingNavigator);
            this.Name = "Tiempo";
            this.Text = "Tiempo";
            this.Load += new System.EventHandler(this.Tiempo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caldea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_tiempoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_tiempoBindingNavigator)).EndInit();
            this.info_tiempoBindingNavigator.ResumeLayout(false);
            this.info_tiempoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info_tiempoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private caldea caldea;
        private System.Windows.Forms.BindingSource info_tiempoBindingSource;
        private caldeaTableAdapters.info_tiempoTableAdapter info_tiempoTableAdapter;
        private caldeaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator info_tiempoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton info_tiempoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView info_tiempoDataGridView;
        private System.Windows.Forms.TextBox id_tagTextBox;
        private System.Windows.Forms.TextBox id_areaTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private caldeaTableAdapters.Info_clienteTableAdapter info_clienteTableAdapter;
        private System.Windows.Forms.BindingSource info_clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
    }
}