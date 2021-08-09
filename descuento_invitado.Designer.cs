
namespace Control_Caldea
{
    partial class descuento_invitado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(descuento_invitado));
            System.Windows.Forms.Label nombre_invitadoLabel;
            this.caldea = new Control_Caldea.caldea();
            this.invitadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invitadoTableAdapter = new Control_Caldea.caldeaTableAdapters.invitadoTableAdapter();
            this.tableAdapterManager = new Control_Caldea.caldeaTableAdapters.TableAdapterManager();
            this.invitadoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.invitadoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nombre_invitadoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.descuentos_personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descuentos_personasTableAdapter = new Control_Caldea.caldeaTableAdapters.descuentos_personasTableAdapter();
            nombre_invitadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.caldea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitadoBindingNavigator)).BeginInit();
            this.invitadoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descuentos_personasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // caldea
            // 
            this.caldea.DataSetName = "caldea";
            this.caldea.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invitadoBindingSource
            // 
            this.invitadoBindingSource.DataMember = "invitado";
            this.invitadoBindingSource.DataSource = this.caldea;
            // 
            // invitadoTableAdapter
            // 
            this.invitadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aplicarTableAdapter = null;
            this.tableAdapterManager.areaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.descuentos_personasTableAdapter = this.descuentos_personasTableAdapter;
            this.tableAdapterManager.descuentoTableAdapter = null;
            this.tableAdapterManager.invitadoTableAdapter = this.invitadoTableAdapter;
            this.tableAdapterManager.lecturaTableAdapter = null;
            this.tableAdapterManager.RelaciónTableAdapter = null;
            this.tableAdapterManager.tagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Control_Caldea.caldeaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // invitadoBindingNavigator
            // 
            this.invitadoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.invitadoBindingNavigator.BindingSource = this.invitadoBindingSource;
            this.invitadoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invitadoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.invitadoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.invitadoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.invitadoBindingNavigatorSaveItem});
            this.invitadoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.invitadoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invitadoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invitadoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invitadoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invitadoBindingNavigator.Name = "invitadoBindingNavigator";
            this.invitadoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invitadoBindingNavigator.Size = new System.Drawing.Size(577, 27);
            this.invitadoBindingNavigator.TabIndex = 0;
            this.invitadoBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // invitadoBindingNavigatorSaveItem
            // 
            this.invitadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.invitadoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("invitadoBindingNavigatorSaveItem.Image")));
            this.invitadoBindingNavigatorSaveItem.Name = "invitadoBindingNavigatorSaveItem";
            this.invitadoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.invitadoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.invitadoBindingNavigatorSaveItem.Click += new System.EventHandler(this.invitadoBindingNavigatorSaveItem_Click);
            // 
            // nombre_invitadoLabel
            // 
            nombre_invitadoLabel.AutoSize = true;
            nombre_invitadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombre_invitadoLabel.Location = new System.Drawing.Point(12, 93);
            nombre_invitadoLabel.Name = "nombre_invitadoLabel";
            nombre_invitadoLabel.Size = new System.Drawing.Size(132, 20);
            nombre_invitadoLabel.TabIndex = 1;
            nombre_invitadoLabel.Text = "nombre invitado:";
            // 
            // nombre_invitadoTextBox
            // 
            this.nombre_invitadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitadoBindingSource, "nombre invitado", true));
            this.nombre_invitadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_invitadoTextBox.Location = new System.Drawing.Point(167, 90);
            this.nombre_invitadoTextBox.Name = "nombre_invitadoTextBox";
            this.nombre_invitadoTextBox.Size = new System.Drawing.Size(146, 26);
            this.nombre_invitadoTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introduce el nombre de invitado:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // descuentos_personasBindingSource
            // 
            this.descuentos_personasBindingSource.DataMember = "descuentos_personas";
            this.descuentos_personasBindingSource.DataSource = this.caldea;
            // 
            // descuentos_personasTableAdapter
            // 
            this.descuentos_personasTableAdapter.ClearBeforeFill = true;
            // 
            // descuento_invitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 167);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(nombre_invitadoLabel);
            this.Controls.Add(this.nombre_invitadoTextBox);
            this.Controls.Add(this.invitadoBindingNavigator);
            this.Name = "descuento_invitado";
            this.Text = "descuento_invitado";
            this.Load += new System.EventHandler(this.descuento_invitado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caldea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitadoBindingNavigator)).EndInit();
            this.invitadoBindingNavigator.ResumeLayout(false);
            this.invitadoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descuentos_personasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private caldea caldea;
        private System.Windows.Forms.BindingSource invitadoBindingSource;
        private caldeaTableAdapters.invitadoTableAdapter invitadoTableAdapter;
        private caldeaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator invitadoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton invitadoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nombre_invitadoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private caldeaTableAdapters.descuentos_personasTableAdapter descuentos_personasTableAdapter;
        private System.Windows.Forms.BindingSource descuentos_personasBindingSource;
    }
}