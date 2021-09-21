
namespace CapaPresentacion
{
    partial class frmCurso
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
            this.gpbCurso_Admin = new System.Windows.Forms.GroupBox();
            this.btnEliminar_Admin = new System.Windows.Forms.Button();
            this.btnAdmin_Activar = new System.Windows.Forms.Button();
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.btnCurso_CargarDatos = new System.Windows.Forms.Button();
            this.lblCurso_CargarDatos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCurso_insertar = new System.Windows.Forms.Button();
            this.btnCurso_Eliminar = new System.Windows.Forms.Button();
            this.btnCurso_Modificar = new System.Windows.Forms.Button();
            this.lblCurso_nombre = new System.Windows.Forms.Label();
            this.lblCurso_Credito = new System.Windows.Forms.Label();
            this.lblCurso_Cupos = new System.Windows.Forms.Label();
            this.txtCurso_Nombre = new System.Windows.Forms.TextBox();
            this.txtCurso_Creditos = new System.Windows.Forms.TextBox();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.txtCurso_Cupos = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gpbCurso_Admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.gpbCurso_Admin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblCurso_nombre);
            this.panel1.Controls.Add(this.lblCurso_Credito);
            this.panel1.Controls.Add(this.lblCurso_Cupos);
            this.panel1.Controls.Add(this.txtCurso_Nombre);
            this.panel1.Controls.Add(this.txtCurso_Creditos);
            this.panel1.Controls.Add(this.dgvCurso);
            this.panel1.Controls.Add(this.txtCurso_Cupos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 606);
            this.panel1.TabIndex = 0;
            // 
            // gpbCurso_Admin
            // 
            this.gpbCurso_Admin.Controls.Add(this.btnEliminar_Admin);
            this.gpbCurso_Admin.Controls.Add(this.btnAdmin_Activar);
            this.gpbCurso_Admin.Controls.Add(this.dgv_admin);
            this.gpbCurso_Admin.Location = new System.Drawing.Point(472, 320);
            this.gpbCurso_Admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbCurso_Admin.Name = "gpbCurso_Admin";
            this.gpbCurso_Admin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbCurso_Admin.Size = new System.Drawing.Size(690, 266);
            this.gpbCurso_Admin.TabIndex = 55;
            this.gpbCurso_Admin.TabStop = false;
            this.gpbCurso_Admin.Text = "Admin";
            // 
            // btnEliminar_Admin
            // 
            this.btnEliminar_Admin.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar_Admin.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar_Admin.Location = new System.Drawing.Point(406, 217);
            this.btnEliminar_Admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar_Admin.Name = "btnEliminar_Admin";
            this.btnEliminar_Admin.Size = new System.Drawing.Size(99, 27);
            this.btnEliminar_Admin.TabIndex = 20;
            this.btnEliminar_Admin.Text = "Eliminar ";
            this.btnEliminar_Admin.UseVisualStyleBackColor = true;
            this.btnEliminar_Admin.Click += new System.EventHandler(this.btnEliminar_Admin_Click_1);
            // 
            // btnAdmin_Activar
            // 
            this.btnAdmin_Activar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnAdmin_Activar.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin_Activar.ForeColor = System.Drawing.Color.White;
            this.btnAdmin_Activar.Location = new System.Drawing.Point(268, 217);
            this.btnAdmin_Activar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdmin_Activar.Name = "btnAdmin_Activar";
            this.btnAdmin_Activar.Size = new System.Drawing.Size(104, 27);
            this.btnAdmin_Activar.TabIndex = 20;
            this.btnAdmin_Activar.Text = "Activar";
            this.btnAdmin_Activar.UseVisualStyleBackColor = false;
            this.btnAdmin_Activar.Click += new System.EventHandler(this.btnAdmin_Activar_Click_1);
            // 
            // dgv_admin
            // 
            this.dgv_admin.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin.Location = new System.Drawing.Point(22, 24);
            this.dgv_admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_admin.Name = "dgv_admin";
            this.dgv_admin.RowHeadersWidth = 51;
            this.dgv_admin.RowTemplate.Height = 24;
            this.dgv_admin.Size = new System.Drawing.Size(648, 185);
            this.dgv_admin.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbxCurso);
            this.panel3.Controls.Add(this.btnCurso_CargarDatos);
            this.panel3.Controls.Add(this.lblCurso_CargarDatos);
            this.panel3.Location = new System.Drawing.Point(12, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 112);
            this.panel3.TabIndex = 54;
            // 
            // cbxCurso
            // 
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Location = new System.Drawing.Point(70, 41);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(162, 24);
            this.cbxCurso.TabIndex = 51;
            // 
            // btnCurso_CargarDatos
            // 
            this.btnCurso_CargarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnCurso_CargarDatos.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurso_CargarDatos.ForeColor = System.Drawing.Color.White;
            this.btnCurso_CargarDatos.Location = new System.Drawing.Point(241, 37);
            this.btnCurso_CargarDatos.Name = "btnCurso_CargarDatos";
            this.btnCurso_CargarDatos.Size = new System.Drawing.Size(112, 31);
            this.btnCurso_CargarDatos.TabIndex = 53;
            this.btnCurso_CargarDatos.Text = "Cargar datos";
            this.btnCurso_CargarDatos.UseVisualStyleBackColor = false;
            // 
            // lblCurso_CargarDatos
            // 
            this.lblCurso_CargarDatos.AutoSize = true;
            this.lblCurso_CargarDatos.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso_CargarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblCurso_CargarDatos.Location = new System.Drawing.Point(13, 43);
            this.lblCurso_CargarDatos.Name = "lblCurso_CargarDatos";
            this.lblCurso_CargarDatos.Size = new System.Drawing.Size(51, 19);
            this.lblCurso_CargarDatos.TabIndex = 52;
            this.lblCurso_CargarDatos.Text = "Filtro:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCurso_insertar);
            this.panel2.Controls.Add(this.btnCurso_Eliminar);
            this.panel2.Controls.Add(this.btnCurso_Modificar);
            this.panel2.Location = new System.Drawing.Point(12, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 111);
            this.panel2.TabIndex = 52;
            // 
            // btnCurso_insertar
            // 
            this.btnCurso_insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnCurso_insertar.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurso_insertar.ForeColor = System.Drawing.Color.White;
            this.btnCurso_insertar.Location = new System.Drawing.Point(14, 31);
            this.btnCurso_insertar.Name = "btnCurso_insertar";
            this.btnCurso_insertar.Size = new System.Drawing.Size(152, 33);
            this.btnCurso_insertar.TabIndex = 49;
            this.btnCurso_insertar.Text = "Insertar ";
            this.btnCurso_insertar.UseVisualStyleBackColor = false;
            this.btnCurso_insertar.Click += new System.EventHandler(this.btnCurso_insertar_Click_1);
            // 
            // btnCurso_Eliminar
            // 
            this.btnCurso_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnCurso_Eliminar.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurso_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btnCurso_Eliminar.Location = new System.Drawing.Point(199, 31);
            this.btnCurso_Eliminar.Name = "btnCurso_Eliminar";
            this.btnCurso_Eliminar.Size = new System.Drawing.Size(142, 33);
            this.btnCurso_Eliminar.TabIndex = 51;
            this.btnCurso_Eliminar.Text = "Eliminar ";
            this.btnCurso_Eliminar.UseVisualStyleBackColor = false;
            this.btnCurso_Eliminar.Click += new System.EventHandler(this.btnCurso_Eliminar_Click_1);
            // 
            // btnCurso_Modificar
            // 
            this.btnCurso_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnCurso_Modificar.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurso_Modificar.ForeColor = System.Drawing.Color.White;
            this.btnCurso_Modificar.Location = new System.Drawing.Point(99, 70);
            this.btnCurso_Modificar.Name = "btnCurso_Modificar";
            this.btnCurso_Modificar.Size = new System.Drawing.Size(153, 33);
            this.btnCurso_Modificar.TabIndex = 50;
            this.btnCurso_Modificar.Text = "Modificar";
            this.btnCurso_Modificar.UseVisualStyleBackColor = false;
            this.btnCurso_Modificar.Click += new System.EventHandler(this.btnCurso_Modificar_Click_1);
            // 
            // lblCurso_nombre
            // 
            this.lblCurso_nombre.AutoSize = true;
            this.lblCurso_nombre.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblCurso_nombre.Location = new System.Drawing.Point(12, 67);
            this.lblCurso_nombre.Name = "lblCurso_nombre";
            this.lblCurso_nombre.Size = new System.Drawing.Size(71, 19);
            this.lblCurso_nombre.TabIndex = 42;
            this.lblCurso_nombre.Text = "Nombre:";
            // 
            // lblCurso_Credito
            // 
            this.lblCurso_Credito.AutoSize = true;
            this.lblCurso_Credito.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso_Credito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblCurso_Credito.Location = new System.Drawing.Point(12, 128);
            this.lblCurso_Credito.Name = "lblCurso_Credito";
            this.lblCurso_Credito.Size = new System.Drawing.Size(132, 19);
            this.lblCurso_Credito.TabIndex = 43;
            this.lblCurso_Credito.Text = "Numero Creditos:";
            // 
            // lblCurso_Cupos
            // 
            this.lblCurso_Cupos.AutoSize = true;
            this.lblCurso_Cupos.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso_Cupos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblCurso_Cupos.Location = new System.Drawing.Point(8, 185);
            this.lblCurso_Cupos.Name = "lblCurso_Cupos";
            this.lblCurso_Cupos.Size = new System.Drawing.Size(140, 19);
            this.lblCurso_Cupos.TabIndex = 44;
            this.lblCurso_Cupos.Text = "Numero de cupos :";
            // 
            // txtCurso_Nombre
            // 
            this.txtCurso_Nombre.Location = new System.Drawing.Point(163, 67);
            this.txtCurso_Nombre.Name = "txtCurso_Nombre";
            this.txtCurso_Nombre.Size = new System.Drawing.Size(282, 22);
            this.txtCurso_Nombre.TabIndex = 45;
            this.txtCurso_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurso_Nombre_KeyPress);
            // 
            // txtCurso_Creditos
            // 
            this.txtCurso_Creditos.Location = new System.Drawing.Point(163, 125);
            this.txtCurso_Creditos.Name = "txtCurso_Creditos";
            this.txtCurso_Creditos.Size = new System.Drawing.Size(282, 22);
            this.txtCurso_Creditos.TabIndex = 46;
            this.txtCurso_Creditos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurso_Creditos_KeyPress);
            // 
            // dgvCurso
            // 
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Location = new System.Drawing.Point(472, 50);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.RowHeadersWidth = 51;
            this.dgvCurso.RowTemplate.Height = 24;
            this.dgvCurso.Size = new System.Drawing.Size(690, 263);
            this.dgvCurso.TabIndex = 48;
            this.dgvCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurso_CellContentClick_1);
            // 
            // txtCurso_Cupos
            // 
            this.txtCurso_Cupos.Location = new System.Drawing.Point(163, 182);
            this.txtCurso_Cupos.Name = "txtCurso_Cupos";
            this.txtCurso_Cupos.Size = new System.Drawing.Size(282, 22);
            this.txtCurso_Cupos.TabIndex = 47;
            this.txtCurso_Cupos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurso_Cupos_KeyPress);
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 606);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCurso";
            this.Text = "Registro de maticula :: Modulo Curso";
            this.Load += new System.EventHandler(this.frmCurso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbCurso_Admin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCurso_CargarDatos;
        private System.Windows.Forms.Label lblCurso_CargarDatos;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.Button btnCurso_Modificar;
        private System.Windows.Forms.Button btnCurso_insertar;
        private System.Windows.Forms.DataGridView dgvCurso;
        private System.Windows.Forms.TextBox txtCurso_Cupos;
        private System.Windows.Forms.TextBox txtCurso_Creditos;
        private System.Windows.Forms.TextBox txtCurso_Nombre;
        private System.Windows.Forms.Label lblCurso_Cupos;
        private System.Windows.Forms.Label lblCurso_Credito;
        private System.Windows.Forms.Label lblCurso_nombre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCurso_Eliminar;
        private System.Windows.Forms.GroupBox gpbCurso_Admin;
        private System.Windows.Forms.Button btnEliminar_Admin;
        private System.Windows.Forms.Button btnAdmin_Activar;
        private System.Windows.Forms.DataGridView dgv_admin;
    }
}