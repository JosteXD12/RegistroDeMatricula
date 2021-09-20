
namespace CapaPresentacion
{
    partial class frmGrupo
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
            this.dgvGrupo = new System.Windows.Forms.DataGridView();
            this.btnGrupo_Insertar = new System.Windows.Forms.Button();
            this.btnGrupo_modificar = new System.Windows.Forms.Button();
            this.lblGrupo_Descripccion = new System.Windows.Forms.Label();
            this.txtGrupo_Descripcion = new System.Windows.Forms.TextBox();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.lblGrupo_Filtro = new System.Windows.Forms.Label();
            this.btnGrupo_CargarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupo
            // 
            this.dgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupo.Location = new System.Drawing.Point(441, 32);
            this.dgvGrupo.Name = "dgvGrupo";
            this.dgvGrupo.RowHeadersWidth = 51;
            this.dgvGrupo.RowTemplate.Height = 24;
            this.dgvGrupo.Size = new System.Drawing.Size(619, 282);
            this.dgvGrupo.TabIndex = 0;
            this.dgvGrupo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupo_CellContentClick);
            // 
            // btnGrupo_Insertar
            // 
            this.btnGrupo_Insertar.Location = new System.Drawing.Point(34, 258);
            this.btnGrupo_Insertar.Name = "btnGrupo_Insertar";
            this.btnGrupo_Insertar.Size = new System.Drawing.Size(120, 23);
            this.btnGrupo_Insertar.TabIndex = 1;
            this.btnGrupo_Insertar.Text = "Insertar Grupo";
            this.btnGrupo_Insertar.UseVisualStyleBackColor = true;
            this.btnGrupo_Insertar.Click += new System.EventHandler(this.btnGrupo_Insertar_Click);
            // 
            // btnGrupo_modificar
            // 
            this.btnGrupo_modificar.Location = new System.Drawing.Point(199, 258);
            this.btnGrupo_modificar.Name = "btnGrupo_modificar";
            this.btnGrupo_modificar.Size = new System.Drawing.Size(124, 23);
            this.btnGrupo_modificar.TabIndex = 2;
            this.btnGrupo_modificar.Text = "Modificar Grupo";
            this.btnGrupo_modificar.UseVisualStyleBackColor = true;
            this.btnGrupo_modificar.Click += new System.EventHandler(this.btnGrupo_modificar_Click);
            // 
            // lblGrupo_Descripccion
            // 
            this.lblGrupo_Descripccion.AutoSize = true;
            this.lblGrupo_Descripccion.Location = new System.Drawing.Point(31, 75);
            this.lblGrupo_Descripccion.Name = "lblGrupo_Descripccion";
            this.lblGrupo_Descripccion.Size = new System.Drawing.Size(86, 17);
            this.lblGrupo_Descripccion.TabIndex = 3;
            this.lblGrupo_Descripccion.Text = "Descripcion:";
            // 
            // txtGrupo_Descripcion
            // 
            this.txtGrupo_Descripcion.Location = new System.Drawing.Point(123, 75);
            this.txtGrupo_Descripcion.Name = "txtGrupo_Descripcion";
            this.txtGrupo_Descripcion.Size = new System.Drawing.Size(276, 22);
            this.txtGrupo_Descripcion.TabIndex = 4;
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(90, 439);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(121, 24);
            this.cbxGrupo.TabIndex = 5;
            this.cbxGrupo.SelectedIndexChanged += new System.EventHandler(this.cbxGrupo_SelectedIndexChanged);
            // 
            // lblGrupo_Filtro
            // 
            this.lblGrupo_Filtro.AutoSize = true;
            this.lblGrupo_Filtro.Location = new System.Drawing.Point(34, 442);
            this.lblGrupo_Filtro.Name = "lblGrupo_Filtro";
            this.lblGrupo_Filtro.Size = new System.Drawing.Size(39, 17);
            this.lblGrupo_Filtro.TabIndex = 6;
            this.lblGrupo_Filtro.Text = "Filtro";
            // 
            // btnGrupo_CargarDatos
            // 
            this.btnGrupo_CargarDatos.Location = new System.Drawing.Point(265, 439);
            this.btnGrupo_CargarDatos.Name = "btnGrupo_CargarDatos";
            this.btnGrupo_CargarDatos.Size = new System.Drawing.Size(125, 24);
            this.btnGrupo_CargarDatos.TabIndex = 7;
            this.btnGrupo_CargarDatos.Text = "Cargar Datos";
            this.btnGrupo_CargarDatos.UseVisualStyleBackColor = true;
            this.btnGrupo_CargarDatos.Click += new System.EventHandler(this.btnGrupo_CargarDatos_Click);
            // 
            // frmGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 562);
            this.Controls.Add(this.btnGrupo_CargarDatos);
            this.Controls.Add(this.lblGrupo_Filtro);
            this.Controls.Add(this.cbxGrupo);
            this.Controls.Add(this.txtGrupo_Descripcion);
            this.Controls.Add(this.lblGrupo_Descripccion);
            this.Controls.Add(this.btnGrupo_modificar);
            this.Controls.Add(this.btnGrupo_Insertar);
            this.Controls.Add(this.dgvGrupo);
            this.Name = "frmGrupo";
            this.Text = "Registro de maticula :: Modulo Grupo";
            this.Load += new System.EventHandler(this.frmGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupo;
        private System.Windows.Forms.Button btnGrupo_Insertar;
        private System.Windows.Forms.Button btnGrupo_modificar;
        private System.Windows.Forms.Label lblGrupo_Descripccion;
        private System.Windows.Forms.TextBox txtGrupo_Descripcion;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.Label lblGrupo_Filtro;
        private System.Windows.Forms.Button btnGrupo_CargarDatos;
    }
}