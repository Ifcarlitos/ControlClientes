
namespace Control_Caldea
{
    partial class test
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
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Control_Caldea.caldeaTableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new Control_Caldea.caldeaTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagTableAdapter = new Control_Caldea.caldeaTableAdapters.tagTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.relaciónBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relaciónTableAdapter = new Control_Caldea.caldeaTableAdapters.RelaciónTableAdapter();
            this.invitadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invitadoTableAdapter = new Control_Caldea.caldeaTableAdapters.invitadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.caldea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciónBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // caldea
            // 
            this.caldea.DataSetName = "caldea";
            this.caldea.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.caldea;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aplicarTableAdapter = null;
            this.tableAdapterManager.areaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.descuentos_personasTableAdapter = null;
            this.tableAdapterManager.descuentoTableAdapter = null;
            this.tableAdapterManager.Info_clienteTableAdapter = null;
            this.tableAdapterManager.info_tiempoTableAdapter = null;
            this.tableAdapterManager.invitadoTableAdapter = this.invitadoTableAdapter;
            this.tableAdapterManager.lecturaTableAdapter = null;
            this.tableAdapterManager.RelaciónTableAdapter = this.relaciónTableAdapter;
            this.tableAdapterManager.tagTableAdapter = this.tagTableAdapter;
            this.tableAdapterManager.UpdateOrder = Control_Caldea.caldeaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar 1000 clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 79);
            this.button2.TabIndex = 1;
            this.button2.Text = "Intentar entrar por el lector 100 veces, con tag no registrado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(480, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 79);
            this.button3.TabIndex = 2;
            this.button3.Text = "cambiar el estado del tag 1000 veces";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tagBindingSource
            // 
            this.tagBindingSource.DataMember = "tag";
            this.tagBindingSource.DataSource = this.caldea;
            // 
            // tagTableAdapter
            // 
            this.tagTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 79);
            this.button4.TabIndex = 3;
            this.button4.Text = "Poner 100 relaciones iguales";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(245, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(203, 79);
            this.button5.TabIndex = 4;
            this.button5.Text = "Agregar 1000 invitados";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(480, 134);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(203, 79);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
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
            // invitadoBindingSource
            // 
            this.invitadoBindingSource.DataMember = "invitado";
            this.invitadoBindingSource.DataSource = this.caldea;
            // 
            // invitadoTableAdapter
            // 
            this.invitadoTableAdapter.ClearBeforeFill = true;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 248);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caldea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciónBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private caldea caldea;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private caldeaTableAdapters.clienteTableAdapter clienteTableAdapter;
        private caldeaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private caldeaTableAdapters.tagTableAdapter tagTableAdapter;
        private System.Windows.Forms.BindingSource tagBindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private caldeaTableAdapters.RelaciónTableAdapter relaciónTableAdapter;
        private System.Windows.Forms.BindingSource relaciónBindingSource;
        private caldeaTableAdapters.invitadoTableAdapter invitadoTableAdapter;
        private System.Windows.Forms.BindingSource invitadoBindingSource;
    }
}