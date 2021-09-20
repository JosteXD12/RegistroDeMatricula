
namespace CapaPresentacion
{
    partial class frmAula
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
            this.btnCurso_CargarDatos = new System.Windows.Forms.Button();
            this.lblAula_CargarDatos = new System.Windows.Forms.Label();
            this.cbxAula = new System.Windows.Forms.ComboBox();
            this.btnAula_Modificar = new System.Windows.Forms.Button();
            this.btnAula_insertar = new System.Windows.Forms.Button();
            this.dgvAula = new System.Windows.Forms.DataGridView();
            this.txtAula_Capacidad = new System.Windows.Forms.TextBox();
            this.txtAula_Descripcion = new System.Windows.Forms.TextBox();
            this.lblAula_Capacidad = new System.Windows.Forms.Label();
            this.lblAula_descripcion = new System.Windows.Forms.Label();
            this.btnAula_Inactivar = new System.Windows.Forms.Button();
            this.btnAula_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAula)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCurso_CargarDatos
            // 
            this.btnCurso_CargarDatos.Location = new System.Drawing.Point(274, 400);
            this.btnCurso_CargarDatos.Name = "btnCurso_CargarDatos";
            this.btnCurso_CargarDatos.Size = new System.Drawing.Size(99, 23);
            this.btnCurso_CargarDatos.TabIndex = 53;
            this.btnCurso_CargarDatos.Text = "Cargar datos";
            this.btnCurso_CargarDatos.UseVisualStyleBackColor = true;
            this.btnCurso_CargarDatos.Click += new System.EventHandler(this.btnCurso_CargarDatos_Click);
            // 
            // lblAula_CargarDatos
            // 
            this.lblAula_CargarDatos.AutoSize = true;
            this.lblAula_CargarDatos.Location = new System.Drawing.Point(12, 399);
            this.lblAula_CargarDatos.Name = "lblAula_CargarDatos";
            this.lblAula_CargarDatos.Size = new System.Drawing.Size(43, 17);
            this.lblAula_CargarDatos.TabIndex = 52;
            this.lblAula_CargarDatos.Text = "Filtro:";
            // 
            // cbxAula
            // 
            this.cbxAula.FormattingEnabled = true;
            this.cbxAula.Location = new System.Drawing.Point(74, 399);
            this.cbxAula.Name = "cbxAula";
            this.cbxAula.Size = new System.Drawing.Size(162, 24);
            this.cbxAula.TabIndex = 51;
            // 
            // btnAula_Modificar
            // 
            this.btnAula_Modificar.Location = new System.Drawing.Point(173, 302);
            this.btnAula_Modificar.Name = "btnAula_Modificar";
            this.btnAula_Modificar.Size = new System.Drawing.Size(153, 23);
            this.btnAula_Modificar.TabIndex = 50;
            this.btnAula_Modificar.Text = "Modificar Aula";
            this.btnAula_Modificar.UseVisualStyleBackColor = true;
            this.btnAula_Modificar.Click += new System.EventHandler(this.btnAula_Modificar_Click);
            // 
            // btnAula_insertar
            // 
            this.btnAula_insertar.Location = new System.Drawing.Point(3, 302);
            this.btnAula_insertar.Name = "btnAula_insertar";
            this.btnAula_insertar.Size = new System.Drawing.Size(152, 23);
            this.btnAula_insertar.TabIndex = 49;
            this.btnAula_insertar.Text = "Insertar Aula";
            this.btnAula_insertar.UseVisualStyleBackColor = true;
            this.btnAula_insertar.Click += new System.EventHandler(this.btnAula_insertar_Click);
            // 
            // dgvAula
            // 
            this.dgvAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAula.Location = new System.Drawing.Point(453, 12);
            this.dgvAula.Name = "dgvAula";
            this.dgvAula.RowHeadersWidth = 51;
            this.dgvAula.RowTemplate.Height = 24;
            this.dgvAula.Size = new System.Drawing.Size(666, 276);
            this.dgvAula.TabIndex = 48;
            this.dgvAula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAula_CellContentClick);
            // 
            // txtAula_Capacidad
            // 
            this.txtAula_Capacidad.Location = new System.Drawing.Point(106, 132);
            this.txtAula_Capacidad.Name = "txtAula_Capacidad";
            this.txtAula_Capacidad.Size = new System.Drawing.Size(285, 22);
            this.txtAula_Capacidad.TabIndex = 46;
            // 
            // txtAula_Descripcion
            // 
            this.txtAula_Descripcion.Location = new System.Drawing.Point(106, 75);
            this.txtAula_Descripcion.Multiline = true;
            this.txtAula_Descripcion.Name = "txtAula_Descripcion";
            this.txtAula_Descripcion.Size = new System.Drawing.Size(285, 46);
            this.txtAula_Descripcion.TabIndex = 45;
            // 
            // lblAula_Capacidad
            // 
            this.lblAula_Capacidad.AutoSize = true;
            this.lblAula_Capacidad.Location = new System.Drawing.Point(21, 137);
            this.lblAula_Capacidad.Name = "lblAula_Capacidad";
            this.lblAula_Capacidad.Size = new System.Drawing.Size(79, 17);
            this.lblAula_Capacidad.TabIndex = 43;
            this.lblAula_Capacidad.Text = "Capacidad:";
            // 
            // lblAula_descripcion
            // 
            this.lblAula_descripcion.AutoSize = true;
            this.lblAula_descripcion.Location = new System.Drawing.Point(21, 75);
            this.lblAula_descripcion.Name = "lblAula_descripcion";
            this.lblAula_descripcion.Size = new System.Drawing.Size(86, 17);
            this.lblAula_descripcion.TabIndex = 42;
            this.lblAula_descripcion.Text = "Descripcion:";
            // 
            // btnAula_Inactivar
            // 
            this.btnAula_Inactivar.Location = new System.Drawing.Point(446, 302);
            this.btnAula_Inactivar.Name = "btnAula_Inactivar";
            this.btnAula_Inactivar.Size = new System.Drawing.Size(92, 23);
            this.btnAula_Inactivar.TabIndex = 55;
            this.btnAula_Inactivar.Text = "Inactivar";
            this.btnAula_Inactivar.UseVisualStyleBackColor = true;
            this.btnAula_Inactivar.Click += new System.EventHandler(this.btnAula_Inactivar_Click);
            // 
            // btnAula_Eliminar
            // 
            this.btnAula_Eliminar.Location = new System.Drawing.Point(341, 302);
            this.btnAula_Eliminar.Name = "btnAula_Eliminar";
            this.btnAula_Eliminar.Size = new System.Drawing.Size(88, 23);
            this.btnAula_Eliminar.TabIndex = 54;
            this.btnAula_Eliminar.Text = "Eliminar ";
            this.btnAula_Eliminar.UseVisualStyleBackColor = true;
            this.btnAula_Eliminar.Click += new System.EventHandler(this.btnAula_Eliminar_Click);
            // 
            // frmAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 472);
            this.Controls.Add(this.btnAula_Inactivar);
            this.Controls.Add(this.btnAula_Eliminar);
            this.Controls.Add(this.btnCurso_CargarDatos);
            this.Controls.Add(this.lblAula_CargarDatos);
            this.Controls.Add(this.cbxAula);
            this.Controls.Add(this.btnAula_Modificar);
            this.Controls.Add(this.btnAula_insertar);
            this.Controls.Add(this.dgvAula);
            this.Controls.Add(this.txtAula_Capacidad);
            this.Controls.Add(this.txtAula_Descripcion);
            this.Controls.Add(this.lblAula_Capacidad);
            this.Controls.Add(this.lblAula_descripcion);
            this.Name = "frmAula";
            this.Text = "Registro de maticula :: Modulo Aula";
            this.Load += new System.EventHandler(this.frmAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCurso_CargarDatos;
        private System.Windows.Forms.Label lblAula_CargarDatos;
        private System.Windows.Forms.ComboBox cbxAula;
        private System.Windows.Forms.Button btnAula_Modificar;
        private System.Windows.Forms.Button btnAula_insertar;
        private System.Windows.Forms.DataGridView dgvAula;
        private System.Windows.Forms.TextBox txtAula_Capacidad;
        private System.Windows.Forms.TextBox txtAula_Descripcion;
        private System.Windows.Forms.Label lblAula_Capacidad;
        private System.Windows.Forms.Label lblAula_descripcion;
        private System.Windows.Forms.Button btnAula_Inactivar;
        private System.Windows.Forms.Button btnAula_Eliminar;
    }
}