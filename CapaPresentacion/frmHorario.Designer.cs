
namespace CapaPresentacion
{
    partial class frmHorario
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
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.gpbHorario_Admin = new System.Windows.Forms.GroupBox();
            this.btnEliminar_Admin = new System.Windows.Forms.Button();
            this.btnAdmin_Activar = new System.Windows.Forms.Button();
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxHorario = new System.Windows.Forms.ComboBox();
            this.btnHorario_CargarDatos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Eliminar_Horario = new System.Windows.Forms.Button();
            this.btnHorario_insertar = new System.Windows.Forms.Button();
            this.btnHorario_modificar = new System.Windows.Forms.Button();
            this.txtHorario_horaFinalizacion = new System.Windows.Forms.TextBox();
            this.txtHorario_HoraInicio = new System.Windows.Forms.TextBox();
            this.txtHorario_Dia = new System.Windows.Forms.TextBox();
            this.txtHorario_Descripccion = new System.Windows.Forms.TextBox();
            this.lblHorario_Horalinal = new System.Windows.Forms.Label();
            this.lblHorario_HoraInicio = new System.Windows.Forms.Label();
            this.lblHorario_dia = new System.Windows.Forms.Label();
            this.lblHorario_descripcion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            this.gpbHorario_Admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.dgvHorario);
            this.panel1.Controls.Add(this.gpbHorario_Admin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtHorario_horaFinalizacion);
            this.panel1.Controls.Add(this.txtHorario_HoraInicio);
            this.panel1.Controls.Add(this.txtHorario_Dia);
            this.panel1.Controls.Add(this.txtHorario_Descripccion);
            this.panel1.Controls.Add(this.lblHorario_Horalinal);
            this.panel1.Controls.Add(this.lblHorario_HoraInicio);
            this.panel1.Controls.Add(this.lblHorario_dia);
            this.panel1.Controls.Add(this.lblHorario_descripcion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 536);
            this.panel1.TabIndex = 0;
            // 
            // dgvHorario
            // 
            this.dgvHorario.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.dgvHorario.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHorario.ColumnHeadersHeight = 29;
            this.dgvHorario.GridColor = System.Drawing.Color.Azure;
            this.dgvHorario.Location = new System.Drawing.Point(411, 25);
            this.dgvHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.RowHeadersWidth = 51;
            this.dgvHorario.Size = new System.Drawing.Size(525, 263);
            this.dgvHorario.TabIndex = 45;
            this.dgvHorario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorario_CellContentClick);
            // 
            // gpbHorario_Admin
            // 
            this.gpbHorario_Admin.Controls.Add(this.btnEliminar_Admin);
            this.gpbHorario_Admin.Controls.Add(this.btnAdmin_Activar);
            this.gpbHorario_Admin.Controls.Add(this.dgv_admin);
            this.gpbHorario_Admin.Location = new System.Drawing.Point(411, 294);
            this.gpbHorario_Admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbHorario_Admin.Name = "gpbHorario_Admin";
            this.gpbHorario_Admin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbHorario_Admin.Size = new System.Drawing.Size(525, 230);
            this.gpbHorario_Admin.TabIndex = 44;
            this.gpbHorario_Admin.TabStop = false;
            this.gpbHorario_Admin.Text = "Admin";
            // 
            // btnEliminar_Admin
            // 
            this.btnEliminar_Admin.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar_Admin.Location = new System.Drawing.Point(287, 188);
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
            this.btnAdmin_Activar.Location = new System.Drawing.Point(161, 188);
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
            this.dgv_admin.Location = new System.Drawing.Point(7, 24);
            this.dgv_admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_admin.Name = "dgv_admin";
            this.dgv_admin.RowHeadersWidth = 51;
            this.dgv_admin.RowTemplate.Height = 24;
            this.dgv_admin.Size = new System.Drawing.Size(512, 156);
            this.dgv_admin.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cbxHorario);
            this.panel3.Controls.Add(this.btnHorario_CargarDatos);
            this.panel3.Location = new System.Drawing.Point(29, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 100);
            this.panel3.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.label6.Location = new System.Drawing.Point(9, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Filtro:";
            // 
            // cbxHorario
            // 
            this.cbxHorario.FormattingEnabled = true;
            this.cbxHorario.Location = new System.Drawing.Point(58, 34);
            this.cbxHorario.Name = "cbxHorario";
            this.cbxHorario.Size = new System.Drawing.Size(147, 24);
            this.cbxHorario.TabIndex = 24;
            // 
            // btnHorario_CargarDatos
            // 
            this.btnHorario_CargarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnHorario_CargarDatos.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorario_CargarDatos.ForeColor = System.Drawing.Color.White;
            this.btnHorario_CargarDatos.Location = new System.Drawing.Point(223, 34);
            this.btnHorario_CargarDatos.Name = "btnHorario_CargarDatos";
            this.btnHorario_CargarDatos.Size = new System.Drawing.Size(106, 29);
            this.btnHorario_CargarDatos.TabIndex = 26;
            this.btnHorario_CargarDatos.Text = "Cargar Datos";
            this.btnHorario_CargarDatos.UseVisualStyleBackColor = false;
            this.btnHorario_CargarDatos.Click += new System.EventHandler(this.btnHorario_CargarDatos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Eliminar_Horario);
            this.panel2.Controls.Add(this.btnHorario_insertar);
            this.panel2.Controls.Add(this.btnHorario_modificar);
            this.panel2.Location = new System.Drawing.Point(29, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 107);
            this.panel2.TabIndex = 40;
            // 
            // Eliminar_Horario
            // 
            this.Eliminar_Horario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.Eliminar_Horario.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_Horario.ForeColor = System.Drawing.Color.White;
            this.Eliminar_Horario.Location = new System.Drawing.Point(168, 20);
            this.Eliminar_Horario.Name = "Eliminar_Horario";
            this.Eliminar_Horario.Size = new System.Drawing.Size(147, 28);
            this.Eliminar_Horario.TabIndex = 29;
            this.Eliminar_Horario.Text = "Eliminar";
            this.Eliminar_Horario.UseVisualStyleBackColor = false;
            this.Eliminar_Horario.Click += new System.EventHandler(this.Eliminar_Horario_Click);
            // 
            // btnHorario_insertar
            // 
            this.btnHorario_insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnHorario_insertar.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorario_insertar.ForeColor = System.Drawing.Color.White;
            this.btnHorario_insertar.Location = new System.Drawing.Point(13, 20);
            this.btnHorario_insertar.Name = "btnHorario_insertar";
            this.btnHorario_insertar.Size = new System.Drawing.Size(132, 28);
            this.btnHorario_insertar.TabIndex = 27;
            this.btnHorario_insertar.Text = "Insertar";
            this.btnHorario_insertar.UseVisualStyleBackColor = false;
            this.btnHorario_insertar.Click += new System.EventHandler(this.btnHorario_insertar_Click);
            // 
            // btnHorario_modificar
            // 
            this.btnHorario_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnHorario_modificar.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorario_modificar.ForeColor = System.Drawing.Color.White;
            this.btnHorario_modificar.Location = new System.Drawing.Point(99, 64);
            this.btnHorario_modificar.Name = "btnHorario_modificar";
            this.btnHorario_modificar.Size = new System.Drawing.Size(147, 28);
            this.btnHorario_modificar.TabIndex = 28;
            this.btnHorario_modificar.Text = "Modificar";
            this.btnHorario_modificar.UseVisualStyleBackColor = false;
            this.btnHorario_modificar.Click += new System.EventHandler(this.btnHorario_modificar_Click);
            // 
            // txtHorario_horaFinalizacion
            // 
            this.txtHorario_horaFinalizacion.Location = new System.Drawing.Point(181, 207);
            this.txtHorario_horaFinalizacion.Name = "txtHorario_horaFinalizacion";
            this.txtHorario_horaFinalizacion.Size = new System.Drawing.Size(204, 22);
            this.txtHorario_horaFinalizacion.TabIndex = 39;
            // 
            // txtHorario_HoraInicio
            // 
            this.txtHorario_HoraInicio.Location = new System.Drawing.Point(181, 164);
            this.txtHorario_HoraInicio.Name = "txtHorario_HoraInicio";
            this.txtHorario_HoraInicio.Size = new System.Drawing.Size(204, 22);
            this.txtHorario_HoraInicio.TabIndex = 38;
            // 
            // txtHorario_Dia
            // 
            this.txtHorario_Dia.Location = new System.Drawing.Point(181, 123);
            this.txtHorario_Dia.Name = "txtHorario_Dia";
            this.txtHorario_Dia.Size = new System.Drawing.Size(204, 22);
            this.txtHorario_Dia.TabIndex = 37;
            // 
            // txtHorario_Descripccion
            // 
            this.txtHorario_Descripccion.Location = new System.Drawing.Point(181, 73);
            this.txtHorario_Descripccion.Name = "txtHorario_Descripccion";
            this.txtHorario_Descripccion.Size = new System.Drawing.Size(204, 22);
            this.txtHorario_Descripccion.TabIndex = 36;
            // 
            // lblHorario_Horalinal
            // 
            this.lblHorario_Horalinal.AutoSize = true;
            this.lblHorario_Horalinal.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario_Horalinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblHorario_Horalinal.Location = new System.Drawing.Point(41, 209);
            this.lblHorario_Horalinal.Name = "lblHorario_Horalinal";
            this.lblHorario_Horalinal.Size = new System.Drawing.Size(137, 19);
            this.lblHorario_Horalinal.TabIndex = 35;
            this.lblHorario_Horalinal.Text = "Hora Finalizacion:";
            // 
            // lblHorario_HoraInicio
            // 
            this.lblHorario_HoraInicio.AutoSize = true;
            this.lblHorario_HoraInicio.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario_HoraInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblHorario_HoraInicio.Location = new System.Drawing.Point(41, 166);
            this.lblHorario_HoraInicio.Name = "lblHorario_HoraInicio";
            this.lblHorario_HoraInicio.Size = new System.Drawing.Size(90, 19);
            this.lblHorario_HoraInicio.TabIndex = 34;
            this.lblHorario_HoraInicio.Text = "Hora inicio:";
            // 
            // lblHorario_dia
            // 
            this.lblHorario_dia.AutoSize = true;
            this.lblHorario_dia.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario_dia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblHorario_dia.Location = new System.Drawing.Point(41, 125);
            this.lblHorario_dia.Name = "lblHorario_dia";
            this.lblHorario_dia.Size = new System.Drawing.Size(38, 19);
            this.lblHorario_dia.TabIndex = 33;
            this.lblHorario_dia.Text = "Dia:";
            // 
            // lblHorario_descripcion
            // 
            this.lblHorario_descripcion.AutoSize = true;
            this.lblHorario_descripcion.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblHorario_descripcion.Location = new System.Drawing.Point(41, 80);
            this.lblHorario_descripcion.Name = "lblHorario_descripcion";
            this.lblHorario_descripcion.Size = new System.Drawing.Size(98, 19);
            this.lblHorario_descripcion.TabIndex = 32;
            this.lblHorario_descripcion.Text = "Descripcion: ";
            // 
            // Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 536);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Horario";
            this.Text = "Horario";
            this.Load += new System.EventHandler(this.Horario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            this.gpbHorario_Admin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxHorario;
        private System.Windows.Forms.Button btnHorario_CargarDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Eliminar_Horario;
        private System.Windows.Forms.Button btnHorario_insertar;
        private System.Windows.Forms.Button btnHorario_modificar;
        private System.Windows.Forms.TextBox txtHorario_horaFinalizacion;
        private System.Windows.Forms.TextBox txtHorario_HoraInicio;
        private System.Windows.Forms.TextBox txtHorario_Dia;
        private System.Windows.Forms.TextBox txtHorario_Descripccion;
        private System.Windows.Forms.Label lblHorario_Horalinal;
        private System.Windows.Forms.Label lblHorario_HoraInicio;
        private System.Windows.Forms.Label lblHorario_dia;
        private System.Windows.Forms.Label lblHorario_descripcion;
        private System.Windows.Forms.GroupBox gpbHorario_Admin;
        private System.Windows.Forms.Button btnEliminar_Admin;
        private System.Windows.Forms.Button btnAdmin_Activar;
        private System.Windows.Forms.DataGridView dgv_admin;
        private System.Windows.Forms.DataGridView dgvHorario;
    }
}