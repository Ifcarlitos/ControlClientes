
namespace Control_Caldea
{
    partial class Comprobar_relación
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
            System.Windows.Forms.Label id_areaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprobar_relación));
            this.label1 = new System.Windows.Forms.Label();
            this.caldea = new Control_Caldea.caldea();
            this.relaciónBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relaciónTableAdapter = new Control_Caldea.caldeaTableAdapters.RelaciónTableAdapter();
            this.tableAdapterManager = new Control_Caldea.caldeaTableAdapters.TableAdapterManager();
            this.relaciónBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.relaciónBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_tagTextBox = new System.Windows.Forms.TextBox();
            this.id_areaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            id_tagLabel = new System.Windows.Forms.Label();
            id_areaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.caldea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciónBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciónBindingNavigator)).BeginInit();
            this.relaciónBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_tagLabel
            // 
            id_tagLabel.AutoSize = true;
            id_tagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_tagLabel.Location = new System.Drawing.Point(12, 62);
            id_tagLabel.Name = "id_tagLabel";
            id_tagLabel.Size = new System.Drawing.Size(65, 25);
            id_tagLabel.TabIndex = 2;
            id_tagLabel.Text = "id tag:";
            // 
            // id_areaLabel
            // 
            id_areaLabel.AutoSize = true;
            id_areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_areaLabel.Location = new System.Drawing.Point(12, 97);
            id_areaLabel.Name = "id_areaLabel";
            id_areaLabel.Size = new System.Drawing.Size(77, 25);
            id_areaLabel.TabIndex = 4;
            id_areaLabel.Text = "id area:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 48);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // caldea
            // 
            this.caldea.DataSetName = "caldea";
            this.caldea.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relaciónBindingSource
            // 
            this.relaciónBindingSource.DataMember = "Relación";
            this.relaciónBindingSource.DataSource = this.caldea;
            // 
            // relaciónTableAdapter
            // 
            this.relaciónTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.info_tiempoTableAdapter = null;
            this.tableAdapterManager.invitadoTableAdapter = null;
            this.tableAdapterManager.lecturaTableAdapter = null;
            this.tableAdapterManager.RelaciónTableAdapter = this.relaciónTableAdapter;
            this.tableAdapterManager.tagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Control_Caldea.caldeaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // relaciónBindingNavigator
            // 
            this.relaciónBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.relaciónBindingNavigator.BindingSource = this.relaciónBindingSource;
            this.relaciónBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.relaciónBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.relaciónBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.relaciónBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.relaciónBindingNavigatorSaveItem});
            this.relaciónBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.relaciónBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.relaciónBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.relaciónBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.relaciónBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.relaciónBindingNavigator.Name = "relaciónBindingNavigator";
            this.relaciónBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.relaciónBindingNavigator.Size = new System.Drawing.Size(615, 31);
            this.relaciónBindingNavigator.TabIndex = 1;
            this.relaciónBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // relaciónBindingNavigatorSaveItem
            // 
            this.relaciónBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.relaciónBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("relaciónBindingNavigatorSaveItem.Image")));
            this.relaciónBindingNavigatorSaveItem.Name = "relaciónBindingNavigatorSaveItem";
            this.relaciónBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.relaciónBindingNavigatorSaveItem.Text = "Guardar datos";
            this.relaciónBindingNavigatorSaveItem.Click += new System.EventHandler(this.relaciónBindingNavigatorSaveItem_Click);
            // 
            // id_tagTextBox
            // 
            this.id_tagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.relaciónBindingSource, "id_tag", true));
            this.id_tagTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tagTextBox.Location = new System.Drawing.Point(149, 55);
            this.id_tagTextBox.Name = "id_tagTextBox";
            this.id_tagTextBox.Size = new System.Drawing.Size(139, 30);
            this.id_tagTextBox.TabIndex = 3;
            // 
            // id_areaTextBox
            // 
            this.id_areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.relaciónBindingSource, "id_area", true));
            this.id_areaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_areaTextBox.Location = new System.Drawing.Point(149, 91);
            this.id_areaTextBox.Name = "id_areaTextBox";
            this.id_areaTextBox.Size = new System.Drawing.Size(139, 30);
            this.id_areaTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "Permiso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Comprobar_relación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 150);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_tagLabel);
            this.Controls.Add(this.id_tagTextBox);
            this.Controls.Add(id_areaLabel);
            this.Controls.Add(this.id_areaTextBox);
            this.Controls.Add(this.relaciónBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Comprobar_relación";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caldea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciónBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciónBindingNavigator)).EndInit();
            this.relaciónBindingNavigator.ResumeLayout(false);
            this.relaciónBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private caldea caldea;
        private System.Windows.Forms.BindingSource relaciónBindingSource;
        private caldeaTableAdapters.RelaciónTableAdapter relaciónTableAdapter;
        private caldeaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator relaciónBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton relaciónBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_tagTextBox;
        private System.Windows.Forms.TextBox id_areaTextBox;
        private System.Windows.Forms.Button button1;
    }
}