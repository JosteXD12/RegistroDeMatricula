
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGrupo_CargarDatos = new System.Windows.Forms.Button();
            this.lblGrupo_Filtro = new System.Windows.Forms.Label();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.txtGrupo_Descripcion = new System.Windows.Forms.TextBox();
            this.lblGrupo_Descripccion = new System.Windows.Forms.Label();
            this.btnGrupo_modificar = new System.Windows.Forms.Button();
            this.btnGrupo_Insertar = new System.Windows.Forms.Button();
            this.dgvGrupo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGrupo_eliminar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gpbGrupo_Admin = new System.Windows.Forms.GroupBox();
            this.btnEliminar_Admin = new System.Windows.Forms.Button();
            this.btnAdmin_Activar = new System.Windows.Forms.Button();
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gpbGrupo_Admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.gpbGrupo_Admin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvGrupo);
            this.panel1.Controls.Add(this.txtGrupo_Descripcion);
            this.panel1.Controls.Add(this.lblGrupo_Descripccion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 432);
            this.panel1.TabIndex = 0;
            // 
            // btnGrupo_CargarDatos
            // 
            this.btnGrupo_CargarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnGrupo_CargarDatos.ForeColor = System.Drawing.Color.White;
            this.btnGrupo_CargarDatos.Location = new System.Drawing.Point(211, 34);
            this.btnGrupo_CargarDatos.Name = "btnGrupo_CargarDatos";
            this.btnGrupo_CargarDatos.Size = new System.Drawing.Size(125, 30);
            this.btnGrupo_CargarDatos.TabIndex = 15;
            this.btnGrupo_CargarDatos.Text = "Cargar Datos";
            this.btnGrupo_CargarDatos.UseVisualStyleBackColor = false;
            this.btnGrupo_CargarDatos.Click += new System.EventHandler(this.btnGrupo_CargarDatos_Click_1);
            // 
            // lblGrupo_Filtro
            // 
            this.lblGrupo_Filtro.AutoSize = true;
            this.lblGrupo_Filtro.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo_Filtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblGrupo_Filtro.Location = new System.Drawing.Point(3, 40);
            this.lblGrupo_Filtro.Name = "lblGrupo_Filtro";
            this.lblGrupo_Filtro.Size = new System.Drawing.Size(47, 19);
            this.lblGrupo_Filtro.TabIndex = 14;
            this.lblGrupo_Filtro.Text = "Filtro";
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(56, 37);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(143, 27);
            this.cbxGrupo.TabIndex = 13;
            // 
            // txtGrupo_Descripcion
            // 
            this.txtGrupo_Descripcion.Location = new System.Drawing.Point(115, 83);
            this.txtGrupo_Descripcion.Multiline = true;
            this.txtGrupo_Descripcion.Name = "txtGrupo_Descripcion";
            this.txtGrupo_Descripcion.Size = new System.Drawing.Size(276, 25);
            this.txtGrupo_Descripcion.TabIndex = 12;
            // 
            // lblGrupo_Descripccion
            // 
            this.lblGrupo_Descripccion.AutoSize = true;
            this.lblGrupo_Descripccion.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo_Descripccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblGrupo_Descripccion.Location = new System.Drawing.Point(15, 83);
            this.lblGrupo_Descripccion.Name = "lblGrupo_Descripccion";
            this.lblGrupo_Descripccion.Size = new System.Drawing.Size(94, 19);
            this.lblGrupo_Descripccion.TabIndex = 11;
            this.lblGrupo_Descripccion.Text = "Descripcion:";
            // 
            // btnGrupo_modificar
            // 
            this.btnGrupo_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnGrupo_modificar.ForeColor = System.Drawing.Color.White;
            this.btnGrupo_modificar.Location = new System.Drawing.Point(92, 58);
            this.btnGrupo_modificar.Name = "btnGrupo_modificar";
            this.btnGrupo_modificar.Size = new System.Drawing.Size(124, 26);
            this.btnGrupo_modificar.TabIndex = 10;
            this.btnGrupo_modificar.Text = "Modificar ";
            this.btnGrupo_modificar.UseVisualStyleBackColor = false;
            this.btnGrupo_modificar.Click += new System.EventHandler(this.btnGrupo_modificar_Click_1);
            // 
            // btnGrupo_Insertar
            // 
            this.btnGrupo_Insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnGrupo_Insertar.ForeColor = System.Drawing.Color.White;
            this.btnGrupo_Insertar.Location = new System.Drawing.Point(14, 15);
            this.btnGrupo_Insertar.Name = "btnGrupo_Insertar";
            this.btnGrupo_Insertar.Size = new System.Drawing.Size(120, 27);
            this.btnGrupo_Insertar.TabIndex = 9;
            this.btnGrupo_Insertar.Text = "Insertar";
            this.btnGrupo_Insertar.UseVisualStyleBackColor = false;
            this.btnGrupo_Insertar.Click += new System.EventHandler(this.btnGrupo_Insertar_Click_1);
            // 
            // dgvGrupo
            // 
            this.dgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupo.Location = new System.Drawing.Point(406, 55);
            this.dgvGrupo.Name = "dgvGrupo";
            this.dgvGrupo.RowHeadersWidth = 51;
            this.dgvGrupo.RowTemplate.Height = 24;
            this.dgvGrupo.Size = new System.Drawing.Size(402, 160);
            this.dgvGrupo.TabIndex = 8;
            this.dgvGrupo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupo_CellContentClick_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGrupo_eliminar);
            this.panel2.Controls.Add(this.btnGrupo_Insertar);
            this.panel2.Controls.Add(this.btnGrupo_modificar);
            this.panel2.Location = new System.Drawing.Point(18, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 100);
            this.panel2.TabIndex = 13;
            // 
            // btnGrupo_eliminar
            // 
            this.btnGrupo_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnGrupo_eliminar.ForeColor = System.Drawing.Color.White;
            this.btnGrupo_eliminar.Location = new System.Drawing.Point(158, 16);
            this.btnGrupo_eliminar.Name = "btnGrupo_eliminar";
            this.btnGrupo_eliminar.Size = new System.Drawing.Size(124, 26);
            this.btnGrupo_eliminar.TabIndex = 11;
            this.btnGrupo_eliminar.Text = "Eliminar ";
            this.btnGrupo_eliminar.UseVisualStyleBackColor = false;
            this.btnGrupo_eliminar.Click += new System.EventHandler(this.btnGrupo_eliminar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGrupo_CargarDatos);
            this.panel3.Controls.Add(this.lblGrupo_Filtro);
            this.panel3.Controls.Add(this.cbxGrupo);
            this.panel3.Location = new System.Drawing.Point(12, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 100);
            this.panel3.TabIndex = 14;
            // 
            // gpbGrupo_Admin
            // 
            this.gpbGrupo_Admin.Controls.Add(this.btnEliminar_Admin);
            this.gpbGrupo_Admin.Controls.Add(this.btnAdmin_Activar);
            this.gpbGrupo_Admin.Controls.Add(this.dgv_admin);
            this.gpbGrupo_Admin.Location = new System.Drawing.Point(406, 222);
            this.gpbGrupo_Admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbGrupo_Admin.Name = "gpbGrupo_Admin";
            this.gpbGrupo_Admin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbGrupo_Admin.Size = new System.Drawing.Size(402, 197);
            this.gpbGrupo_Admin.TabIndex = 44;
            this.gpbGrupo_Admin.TabStop = false;
            this.gpbGrupo_Admin.Text = "Admin";
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
            // frmGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(834, 432);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGrupo";
            this.Text = "Registro de maticula :: Modulo Grupo";
            this.Load += new System.EventHandler(this.frmGrupo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gpbGrupo_Admin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGrupo_CargarDatos;
        private System.Windows.Forms.Label lblGrupo_Filtro;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGrupo_eliminar;
        private System.Windows.Forms.Button btnGrupo_Insertar;
        private System.Windows.Forms.Button btnGrupo_modificar;
        private System.Windows.Forms.DataGridView dgvGrupo;
        private System.Windows.Forms.TextBox txtGrupo_Descripcion;
        private System.Windows.Forms.Label lblGrupo_Descripccion;
        private System.Windows.Forms.GroupBox gpbGrupo_Admin;
        private System.Windows.Forms.Button btnEliminar_Admin;
        private System.Windows.Forms.Button btnAdmin_Activar;
        private System.Windows.Forms.DataGridView dgv_admin;
    }
}