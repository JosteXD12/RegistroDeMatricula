
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAula_Eliminar = new System.Windows.Forms.Button();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gpbAula_Admin = new System.Windows.Forms.GroupBox();
            this.btnEliminar_Admin = new System.Windows.Forms.Button();
            this.btnAdmin_Activar = new System.Windows.Forms.Button();
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAula)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gpbAula_Admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.gpbAula_Admin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvAula);
            this.panel1.Controls.Add(this.txtAula_Descripcion);
            this.panel1.Controls.Add(this.txtAula_Capacidad);
            this.panel1.Controls.Add(this.lblAula_descripcion);
            this.panel1.Controls.Add(this.lblAula_Capacidad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 497);
            this.panel1.TabIndex = 0;
            // 
            // btnAula_Eliminar
            // 
            this.btnAula_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnAula_Eliminar.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAula_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btnAula_Eliminar.Location = new System.Drawing.Point(173, 16);
            this.btnAula_Eliminar.Name = "btnAula_Eliminar";
            this.btnAula_Eliminar.Size = new System.Drawing.Size(113, 28);
            this.btnAula_Eliminar.TabIndex = 66;
            this.btnAula_Eliminar.Text = "Eliminar ";
            this.btnAula_Eliminar.UseVisualStyleBackColor = false;
            this.btnAula_Eliminar.Click += new System.EventHandler(this.btnAula_Eliminar_Click_1);
            // 
            // btnCurso_CargarDatos
            // 
            this.btnCurso_CargarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnCurso_CargarDatos.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurso_CargarDatos.ForeColor = System.Drawing.Color.White;
            this.btnCurso_CargarDatos.Location = new System.Drawing.Point(245, 33);
            this.btnCurso_CargarDatos.Name = "btnCurso_CargarDatos";
            this.btnCurso_CargarDatos.Size = new System.Drawing.Size(111, 25);
            this.btnCurso_CargarDatos.TabIndex = 65;
            this.btnCurso_CargarDatos.Text = "Cargar datos";
            this.btnCurso_CargarDatos.UseVisualStyleBackColor = false;
            this.btnCurso_CargarDatos.Click += new System.EventHandler(this.btnCurso_CargarDatos_Click_1);
            // 
            // lblAula_CargarDatos
            // 
            this.lblAula_CargarDatos.AutoSize = true;
            this.lblAula_CargarDatos.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAula_CargarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblAula_CargarDatos.Location = new System.Drawing.Point(3, 41);
            this.lblAula_CargarDatos.Name = "lblAula_CargarDatos";
            this.lblAula_CargarDatos.Size = new System.Drawing.Size(51, 19);
            this.lblAula_CargarDatos.TabIndex = 64;
            this.lblAula_CargarDatos.Text = "Filtro:";
            // 
            // cbxAula
            // 
            this.cbxAula.FormattingEnabled = true;
            this.cbxAula.Location = new System.Drawing.Point(60, 33);
            this.cbxAula.Name = "cbxAula";
            this.cbxAula.Size = new System.Drawing.Size(162, 27);
            this.cbxAula.TabIndex = 63;
            // 
            // btnAula_Modificar
            // 
            this.btnAula_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnAula_Modificar.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAula_Modificar.ForeColor = System.Drawing.Color.White;
            this.btnAula_Modificar.Location = new System.Drawing.Point(96, 50);
            this.btnAula_Modificar.Name = "btnAula_Modificar";
            this.btnAula_Modificar.Size = new System.Drawing.Size(115, 27);
            this.btnAula_Modificar.TabIndex = 62;
            this.btnAula_Modificar.Text = "Modificar";
            this.btnAula_Modificar.UseVisualStyleBackColor = false;
            this.btnAula_Modificar.Click += new System.EventHandler(this.btnAula_Modificar_Click_1);
            // 
            // btnAula_insertar
            // 
            this.btnAula_insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnAula_insertar.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAula_insertar.ForeColor = System.Drawing.Color.White;
            this.btnAula_insertar.Location = new System.Drawing.Point(7, 16);
            this.btnAula_insertar.Name = "btnAula_insertar";
            this.btnAula_insertar.Size = new System.Drawing.Size(113, 28);
            this.btnAula_insertar.TabIndex = 61;
            this.btnAula_insertar.Text = "Insertar";
            this.btnAula_insertar.UseVisualStyleBackColor = false;
            this.btnAula_insertar.Click += new System.EventHandler(this.btnAula_insertar_Click_1);
            // 
            // dgvAula
            // 
            this.dgvAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAula.Location = new System.Drawing.Point(454, 23);
            this.dgvAula.Name = "dgvAula";
            this.dgvAula.RowHeadersWidth = 51;
            this.dgvAula.RowTemplate.Height = 24;
            this.dgvAula.Size = new System.Drawing.Size(431, 276);
            this.dgvAula.TabIndex = 60;
            this.dgvAula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAula_CellContentClick_1);
            // 
            // txtAula_Capacidad
            // 
            this.txtAula_Capacidad.Location = new System.Drawing.Point(154, 162);
            this.txtAula_Capacidad.Name = "txtAula_Capacidad";
            this.txtAula_Capacidad.Size = new System.Drawing.Size(285, 26);
            this.txtAula_Capacidad.TabIndex = 59;
            // 
            // txtAula_Descripcion
            // 
            this.txtAula_Descripcion.Location = new System.Drawing.Point(154, 81);
            this.txtAula_Descripcion.Multiline = true;
            this.txtAula_Descripcion.Name = "txtAula_Descripcion";
            this.txtAula_Descripcion.Size = new System.Drawing.Size(285, 46);
            this.txtAula_Descripcion.TabIndex = 58;
            // 
            // lblAula_Capacidad
            // 
            this.lblAula_Capacidad.AutoSize = true;
            this.lblAula_Capacidad.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAula_Capacidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblAula_Capacidad.Location = new System.Drawing.Point(31, 162);
            this.lblAula_Capacidad.Name = "lblAula_Capacidad";
            this.lblAula_Capacidad.Size = new System.Drawing.Size(89, 19);
            this.lblAula_Capacidad.TabIndex = 57;
            this.lblAula_Capacidad.Text = "Capacidad:";
            // 
            // lblAula_descripcion
            // 
            this.lblAula_descripcion.AutoSize = true;
            this.lblAula_descripcion.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAula_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblAula_descripcion.Location = new System.Drawing.Point(31, 94);
            this.lblAula_descripcion.Name = "lblAula_descripcion";
            this.lblAula_descripcion.Size = new System.Drawing.Size(94, 19);
            this.lblAula_descripcion.TabIndex = 56;
            this.lblAula_descripcion.Text = "Descripcion:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAula_insertar);
            this.panel2.Controls.Add(this.btnAula_Eliminar);
            this.panel2.Controls.Add(this.btnAula_Modificar);
            this.panel2.Location = new System.Drawing.Point(34, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 92);
            this.panel2.TabIndex = 67;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCurso_CargarDatos);
            this.panel3.Controls.Add(this.lblAula_CargarDatos);
            this.panel3.Controls.Add(this.cbxAula);
            this.panel3.Location = new System.Drawing.Point(34, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 80);
            this.panel3.TabIndex = 68;
            // 
            // gpbAula_Admin
            // 
            this.gpbAula_Admin.Controls.Add(this.btnEliminar_Admin);
            this.gpbAula_Admin.Controls.Add(this.btnAdmin_Activar);
            this.gpbAula_Admin.Controls.Add(this.dgv_admin);
            this.gpbAula_Admin.Location = new System.Drawing.Point(454, 306);
            this.gpbAula_Admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbAula_Admin.Name = "gpbAula_Admin";
            this.gpbAula_Admin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbAula_Admin.Size = new System.Drawing.Size(431, 187);
            this.gpbAula_Admin.TabIndex = 69;
            this.gpbAula_Admin.TabStop = false;
            this.gpbAula_Admin.Text = "Admin";
            // 
            // btnEliminar_Admin
            // 
            this.btnEliminar_Admin.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar_Admin.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar_Admin.Location = new System.Drawing.Point(217, 153);
            this.btnEliminar_Admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar_Admin.Name = "btnEliminar_Admin";
            this.btnEliminar_Admin.Size = new System.Drawing.Size(99, 27);
            this.btnEliminar_Admin.TabIndex = 20;
            this.btnEliminar_Admin.Text = "Eliminar ";
            this.btnEliminar_Admin.UseVisualStyleBackColor = true;
            this.btnEliminar_Admin.Click += new System.EventHandler(this.btnEliminar_Admin_Click);
            // 
            // btnAdmin_Activar
            // 
            this.btnAdmin_Activar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnAdmin_Activar.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin_Activar.ForeColor = System.Drawing.Color.White;
            this.btnAdmin_Activar.Location = new System.Drawing.Point(75, 153);
            this.btnAdmin_Activar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdmin_Activar.Name = "btnAdmin_Activar";
            this.btnAdmin_Activar.Size = new System.Drawing.Size(104, 27);
            this.btnAdmin_Activar.TabIndex = 20;
            this.btnAdmin_Activar.Text = "Activar";
            this.btnAdmin_Activar.UseVisualStyleBackColor = false;
            this.btnAdmin_Activar.Click += new System.EventHandler(this.btnAdmin_Activar_Click);
            // 
            // dgv_admin
            // 
            this.dgv_admin.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin.Location = new System.Drawing.Point(6, 19);
            this.dgv_admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_admin.Name = "dgv_admin";
            this.dgv_admin.RowHeadersWidth = 51;
            this.dgv_admin.RowTemplate.Height = 24;
            this.dgv_admin.Size = new System.Drawing.Size(388, 110);
            this.dgv_admin.TabIndex = 0;
            // 
            // frmAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 497);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAula";
            this.Text = "Registro de maticula :: Modulo Aula";
            this.Load += new System.EventHandler(this.frmAula_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAula)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gpbAula_Admin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCurso_CargarDatos;
        private System.Windows.Forms.Label lblAula_CargarDatos;
        private System.Windows.Forms.ComboBox cbxAula;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAula_insertar;
        private System.Windows.Forms.Button btnAula_Eliminar;
        private System.Windows.Forms.Button btnAula_Modificar;
        private System.Windows.Forms.DataGridView dgvAula;
        private System.Windows.Forms.TextBox txtAula_Descripcion;
        private System.Windows.Forms.TextBox txtAula_Capacidad;
        private System.Windows.Forms.Label lblAula_descripcion;
        private System.Windows.Forms.Label lblAula_Capacidad;
        private System.Windows.Forms.GroupBox gpbAula_Admin;
        private System.Windows.Forms.Button btnEliminar_Admin;
        private System.Windows.Forms.Button btnAdmin_Activar;
        private System.Windows.Forms.DataGridView dgv_admin;
    }
}