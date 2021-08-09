
namespace Control_Caldea
{
    partial class comprobar_descuento
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
            this.caldea = new Control_Caldea.caldea();
            this.descuentos_personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descuentos_personasTableAdapter = new Control_Caldea.caldeaTableAdapters.descuentos_personasTableAdapter();
            this.tableAdapterManager = new Control_Caldea.caldeaTableAdapters.TableAdapterManager();
            this.descuentos_personasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.caldea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentos_personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentos_personasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // caldea
            // 
            this.caldea.DataSetName = "caldea";
            this.caldea.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.aplicarTableAdapter = null;
            this.tableAdapterManager.areaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.descuentos_personasTableAdapter = this.descuentos_personasTableAdapter;
            this.tableAdapterManager.descuentoTableAdapter = null;
            this.tableAdapterManager.invitadoTableAdapter = null;
            this.tableAdapterManager.lecturaTableAdapter = null;
            this.tableAdapterManager.RelaciónTableAdapter = null;
            this.tableAdapterManager.tagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Control_Caldea.caldeaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // descuentos_personasDataGridView
            // 
            this.descuentos_personasDataGridView.AutoGenerateColumns = false;
            this.descuentos_personasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.descuentos_personasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.descuentos_personasDataGridView.DataSource = this.descuentos_personasBindingSource;
            this.descuentos_personasDataGridView.Location = new System.Drawing.Point(49, 57);
            this.descuentos_personasDataGridView.Name = "descuentos_personasDataGridView";
            this.descuentos_personasDataGridView.RowHeadersWidth = 51;
            this.descuentos_personasDataGridView.RowTemplate.Height = 24;
            this.descuentos_personasDataGridView.Size = new System.Drawing.Size(689, 343);
            this.descuentos_personasDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_invitado";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre_invitado";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descuento";
            this.dataGridViewTextBoxColumn3.HeaderText = "descuento";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // comprobar_descuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descuentos_personasDataGridView);
            this.Name = "comprobar_descuento";
            this.Text = "comprobar_descuento";
            this.Load += new System.EventHandler(this.comprobar_descuento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caldea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentos_personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentos_personasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private caldea caldea;
        private System.Windows.Forms.BindingSource descuentos_personasBindingSource;
        private caldeaTableAdapters.descuentos_personasTableAdapter descuentos_personasTableAdapter;
        private caldeaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView descuentos_personasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}