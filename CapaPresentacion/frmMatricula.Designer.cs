
namespace CapaPresentacion
{
    partial class frmMatricula
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
            this.gpbMatricula_Admin = new System.Windows.Forms.GroupBox();
            this.btnEliminar_Admin = new System.Windows.Forms.Button();
            this.btnAdmin_Activar = new System.Windows.Forms.Button();
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.dgvMatricula = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMatricula_Insertar = new System.Windows.Forms.Button();
            this.btnMatricula_Eliminar = new System.Windows.Forms.Button();
            this.btnMatricula_Modificar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnLoadDatos = new System.Windows.Forms.Button();
            this.cbxMatricula = new System.Windows.Forms.ComboBox();
            this.txtComprobanteMatricula = new System.Windows.Forms.TextBox();
            this.cbxAulaID = new System.Windows.Forms.ComboBox();
            this.cbxHorarioID = new System.Windows.Forms.ComboBox();
            this.cbxProfesorID = new System.Windows.Forms.ComboBox();
            this.cbxCursoID = new System.Windows.Forms.ComboBox();
            this.cbxGrupoID = new System.Windows.Forms.ComboBox();
            this.cbxEstudianteID = new System.Windows.Forms.ComboBox();
            this.lblMatricula_ComprobanteMatricula = new System.Windows.Forms.Label();
            this.lblMatricula_AulaID = new System.Windows.Forms.Label();
            this.lblMatricula_HorarioID = new System.Windows.Forms.Label();
            this.lblMatricula_ProfesorID = new System.Windows.Forms.Label();
            this.lblMatricula_CursoID = new System.Windows.Forms.Label();
            this.lblMatricula_GrupoID = new System.Windows.Forms.Label();
            this.lblMatricula_EstudianteID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpbMatricula_Admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatricula)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.gpbMatricula_Admin);
            this.panel1.Controls.Add(this.dgvMatricula);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtComprobanteMatricula);
            this.panel1.Controls.Add(this.cbxAulaID);
            this.panel1.Controls.Add(this.cbxHorarioID);
            this.panel1.Controls.Add(this.cbxProfesorID);
            this.panel1.Controls.Add(this.cbxCursoID);
            this.panel1.Controls.Add(this.cbxGrupoID);
            this.panel1.Controls.Add(this.cbxEstudianteID);
            this.panel1.Controls.Add(this.lblMatricula_ComprobanteMatricula);
            this.panel1.Controls.Add(this.lblMatricula_AulaID);
            this.panel1.Controls.Add(this.lblMatricula_HorarioID);
            this.panel1.Controls.Add(this.lblMatricula_ProfesorID);
            this.panel1.Controls.Add(this.lblMatricula_CursoID);
            this.panel1.Controls.Add(this.lblMatricula_GrupoID);
            this.panel1.Controls.Add(this.lblMatricula_EstudianteID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 595);
            this.panel1.TabIndex = 0;
            // 
            // gpbMatricula_Admin
            // 
            this.gpbMatricula_Admin.Controls.Add(this.btnEliminar_Admin);
            this.gpbMatricula_Admin.Controls.Add(this.btnAdmin_Activar);
            this.gpbMatricula_Admin.Controls.Add(this.dgv_admin);
            this.gpbMatricula_Admin.Location = new System.Drawing.Point(423, 337);
            this.gpbMatricula_Admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbMatricula_Admin.Name = "gpbMatricula_Admin";
            this.gpbMatricula_Admin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbMatricula_Admin.Size = new System.Drawing.Size(638, 255);
            this.gpbMatricula_Admin.TabIndex = 44;
            this.gpbMatricula_Admin.TabStop = false;
            this.gpbMatricula_Admin.Text = "Admin";
            // 
            // btnEliminar_Admin
            // 
            this.btnEliminar_Admin.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar_Admin.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar_Admin.Location = new System.Drawing.Point(326, 217);
            this.btnEliminar_Admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar_Admin.Name = "btnEliminar_Admin";
            this.btnEliminar_Admin.Size = new System.Drawing.Size(102, 29);
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
            this.btnAdmin_Activar.Location = new System.Drawing.Point(199, 218);
            this.btnAdmin_Activar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdmin_Activar.Name = "btnAdmin_Activar";
            this.btnAdmin_Activar.Size = new System.Drawing.Size(102, 29);
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
            this.dgv_admin.Size = new System.Drawing.Size(625, 185);
            this.dgv_admin.TabIndex = 0;
            // 
            // dgvMatricula
            // 
            this.dgvMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatricula.Location = new System.Drawing.Point(423, 36);
            this.dgvMatricula.Name = "dgvMatricula";
            this.dgvMatricula.RowHeadersWidth = 51;
            this.dgvMatricula.RowTemplate.Height = 24;
            this.dgvMatricula.Size = new System.Drawing.Size(631, 294);
            this.dgvMatricula.TabIndex = 23;
            this.dgvMatricula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatricula_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMatricula_Insertar);
            this.panel3.Controls.Add(this.btnMatricula_Eliminar);
            this.panel3.Controls.Add(this.btnMatricula_Modificar);
            this.panel3.Location = new System.Drawing.Point(12, 367);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 90);
            this.panel3.TabIndex = 22;
            // 
            // btnMatricula_Insertar
            // 
            this.btnMatricula_Insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnMatricula_Insertar.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricula_Insertar.ForeColor = System.Drawing.Color.White;
            this.btnMatricula_Insertar.Location = new System.Drawing.Point(32, 15);
            this.btnMatricula_Insertar.Name = "btnMatricula_Insertar";
            this.btnMatricula_Insertar.Size = new System.Drawing.Size(102, 29);
            this.btnMatricula_Insertar.TabIndex = 16;
            this.btnMatricula_Insertar.Text = "Insertar";
            this.btnMatricula_Insertar.UseVisualStyleBackColor = false;
            this.btnMatricula_Insertar.Click += new System.EventHandler(this.btnMatricula_Insertar_Click);
            // 
            // btnMatricula_Eliminar
            // 
            this.btnMatricula_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnMatricula_Eliminar.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricula_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btnMatricula_Eliminar.Location = new System.Drawing.Point(192, 15);
            this.btnMatricula_Eliminar.Name = "btnMatricula_Eliminar";
            this.btnMatricula_Eliminar.Size = new System.Drawing.Size(102, 29);
            this.btnMatricula_Eliminar.TabIndex = 17;
            this.btnMatricula_Eliminar.Text = "Eliminar ";
            this.btnMatricula_Eliminar.UseVisualStyleBackColor = false;
            this.btnMatricula_Eliminar.Click += new System.EventHandler(this.btnMatricula_Eliminar_Click);
            // 
            // btnMatricula_Modificar
            // 
            this.btnMatricula_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnMatricula_Modificar.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricula_Modificar.ForeColor = System.Drawing.Color.White;
            this.btnMatricula_Modificar.Location = new System.Drawing.Point(108, 50);
            this.btnMatricula_Modificar.Name = "btnMatricula_Modificar";
            this.btnMatricula_Modificar.Size = new System.Drawing.Size(102, 29);
            this.btnMatricula_Modificar.TabIndex = 18;
            this.btnMatricula_Modificar.Text = "Modificar ";
            this.btnMatricula_Modificar.UseVisualStyleBackColor = false;
            this.btnMatricula_Modificar.Click += new System.EventHandler(this.btnMatricula_Modificar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblFiltro);
            this.panel2.Controls.Add(this.btnLoadDatos);
            this.panel2.Controls.Add(this.cbxMatricula);
            this.panel2.Location = new System.Drawing.Point(12, 486);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 97);
            this.panel2.TabIndex = 21;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(6, 44);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(55, 19);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Filtro: ";
            // 
            // btnLoadDatos
            // 
            this.btnLoadDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnLoadDatos.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDatos.ForeColor = System.Drawing.Color.White;
            this.btnLoadDatos.Location = new System.Drawing.Point(216, 40);
            this.btnLoadDatos.Name = "btnLoadDatos";
            this.btnLoadDatos.Size = new System.Drawing.Size(102, 29);
            this.btnLoadDatos.TabIndex = 19;
            this.btnLoadDatos.Text = "Cargar Datos";
            this.btnLoadDatos.UseVisualStyleBackColor = false;
            this.btnLoadDatos.Click += new System.EventHandler(this.btnLoadDatos_Click);
            // 
            // cbxMatricula
            // 
            this.cbxMatricula.FormattingEnabled = true;
            this.cbxMatricula.Location = new System.Drawing.Point(67, 39);
            this.cbxMatricula.Name = "cbxMatricula";
            this.cbxMatricula.Size = new System.Drawing.Size(143, 27);
            this.cbxMatricula.TabIndex = 20;
            // 
            // txtComprobanteMatricula
            // 
            this.txtComprobanteMatricula.Location = new System.Drawing.Point(204, 302);
            this.txtComprobanteMatricula.Name = "txtComprobanteMatricula";
            this.txtComprobanteMatricula.Size = new System.Drawing.Size(192, 26);
            this.txtComprobanteMatricula.TabIndex = 14;
            // 
            // cbxAulaID
            // 
            this.cbxAulaID.FormattingEnabled = true;
            this.cbxAulaID.Location = new System.Drawing.Point(204, 256);
            this.cbxAulaID.Name = "cbxAulaID";
            this.cbxAulaID.Size = new System.Drawing.Size(192, 27);
            this.cbxAulaID.TabIndex = 13;
            // 
            // cbxHorarioID
            // 
            this.cbxHorarioID.FormattingEnabled = true;
            this.cbxHorarioID.Location = new System.Drawing.Point(204, 210);
            this.cbxHorarioID.Name = "cbxHorarioID";
            this.cbxHorarioID.Size = new System.Drawing.Size(192, 27);
            this.cbxHorarioID.TabIndex = 12;
            // 
            // cbxProfesorID
            // 
            this.cbxProfesorID.FormattingEnabled = true;
            this.cbxProfesorID.Location = new System.Drawing.Point(204, 166);
            this.cbxProfesorID.Name = "cbxProfesorID";
            this.cbxProfesorID.Size = new System.Drawing.Size(192, 27);
            this.cbxProfesorID.TabIndex = 11;
            // 
            // cbxCursoID
            // 
            this.cbxCursoID.FormattingEnabled = true;
            this.cbxCursoID.Location = new System.Drawing.Point(204, 121);
            this.cbxCursoID.Name = "cbxCursoID";
            this.cbxCursoID.Size = new System.Drawing.Size(192, 27);
            this.cbxCursoID.TabIndex = 10;
            // 
            // cbxGrupoID
            // 
            this.cbxGrupoID.FormattingEnabled = true;
            this.cbxGrupoID.Location = new System.Drawing.Point(204, 78);
            this.cbxGrupoID.Name = "cbxGrupoID";
            this.cbxGrupoID.Size = new System.Drawing.Size(192, 27);
            this.cbxGrupoID.TabIndex = 9;
            // 
            // cbxEstudianteID
            // 
            this.cbxEstudianteID.FormattingEnabled = true;
            this.cbxEstudianteID.Location = new System.Drawing.Point(204, 36);
            this.cbxEstudianteID.Name = "cbxEstudianteID";
            this.cbxEstudianteID.Size = new System.Drawing.Size(192, 27);
            this.cbxEstudianteID.TabIndex = 8;
            // 
            // lblMatricula_ComprobanteMatricula
            // 
            this.lblMatricula_ComprobanteMatricula.AutoSize = true;
            this.lblMatricula_ComprobanteMatricula.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula_ComprobanteMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblMatricula_ComprobanteMatricula.Location = new System.Drawing.Point(12, 302);
            this.lblMatricula_ComprobanteMatricula.Name = "lblMatricula_ComprobanteMatricula";
            this.lblMatricula_ComprobanteMatricula.Size = new System.Drawing.Size(183, 19);
            this.lblMatricula_ComprobanteMatricula.TabIndex = 6;
            this.lblMatricula_ComprobanteMatricula.Text = "Comprobante Matricula:";
            // 
            // lblMatricula_AulaID
            // 
            this.lblMatricula_AulaID.AutoSize = true;
            this.lblMatricula_AulaID.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula_AulaID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblMatricula_AulaID.Location = new System.Drawing.Point(18, 256);
            this.lblMatricula_AulaID.Name = "lblMatricula_AulaID";
            this.lblMatricula_AulaID.Size = new System.Drawing.Size(66, 19);
            this.lblMatricula_AulaID.TabIndex = 5;
            this.lblMatricula_AulaID.Text = "Aula ID:";
            // 
            // lblMatricula_HorarioID
            // 
            this.lblMatricula_HorarioID.AutoSize = true;
            this.lblMatricula_HorarioID.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula_HorarioID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblMatricula_HorarioID.Location = new System.Drawing.Point(12, 210);
            this.lblMatricula_HorarioID.Name = "lblMatricula_HorarioID";
            this.lblMatricula_HorarioID.Size = new System.Drawing.Size(88, 19);
            this.lblMatricula_HorarioID.TabIndex = 4;
            this.lblMatricula_HorarioID.Text = "Horario ID:";
            // 
            // lblMatricula_ProfesorID
            // 
            this.lblMatricula_ProfesorID.AutoSize = true;
            this.lblMatricula_ProfesorID.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula_ProfesorID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblMatricula_ProfesorID.Location = new System.Drawing.Point(12, 166);
            this.lblMatricula_ProfesorID.Name = "lblMatricula_ProfesorID";
            this.lblMatricula_ProfesorID.Size = new System.Drawing.Size(92, 19);
            this.lblMatricula_ProfesorID.TabIndex = 3;
            this.lblMatricula_ProfesorID.Text = "Profesor ID:";
            // 
            // lblMatricula_CursoID
            // 
            this.lblMatricula_CursoID.AutoSize = true;
            this.lblMatricula_CursoID.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula_CursoID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblMatricula_CursoID.Location = new System.Drawing.Point(12, 121);
            this.lblMatricula_CursoID.Name = "lblMatricula_CursoID";
            this.lblMatricula_CursoID.Size = new System.Drawing.Size(72, 19);
            this.lblMatricula_CursoID.TabIndex = 2;
            this.lblMatricula_CursoID.Text = "Curso ID:";
            // 
            // lblMatricula_GrupoID
            // 
            this.lblMatricula_GrupoID.AutoSize = true;
            this.lblMatricula_GrupoID.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula_GrupoID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblMatricula_GrupoID.Location = new System.Drawing.Point(12, 78);
            this.lblMatricula_GrupoID.Name = "lblMatricula_GrupoID";
            this.lblMatricula_GrupoID.Size = new System.Drawing.Size(78, 19);
            this.lblMatricula_GrupoID.TabIndex = 1;
            this.lblMatricula_GrupoID.Text = "Grupo ID:";
            // 
            // lblMatricula_EstudianteID
            // 
            this.lblMatricula_EstudianteID.AutoSize = true;
            this.lblMatricula_EstudianteID.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula_EstudianteID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblMatricula_EstudianteID.Location = new System.Drawing.Point(12, 36);
            this.lblMatricula_EstudianteID.Name = "lblMatricula_EstudianteID";
            this.lblMatricula_EstudianteID.Size = new System.Drawing.Size(107, 19);
            this.lblMatricula_EstudianteID.TabIndex = 0;
            this.lblMatricula_EstudianteID.Text = "Estudiante ID:";
            // 
            // frmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 595);
            this.Controls.Add(this.panel1);
            this.Name = "frmMatricula";
            this.Text = "frmMatricula";
            this.Load += new System.EventHandler(this.frmMatricula_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbMatricula_Admin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatricula)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMatricula_GrupoID;
        private System.Windows.Forms.Label lblMatricula_EstudianteID;
        private System.Windows.Forms.DataGridView dgvMatricula;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMatricula_Insertar;
        private System.Windows.Forms.Button btnMatricula_Eliminar;
        private System.Windows.Forms.Button btnMatricula_Modificar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnLoadDatos;
        private System.Windows.Forms.ComboBox cbxMatricula;
        private System.Windows.Forms.TextBox txtComprobanteMatricula;
        private System.Windows.Forms.ComboBox cbxAulaID;
        private System.Windows.Forms.ComboBox cbxHorarioID;
        private System.Windows.Forms.ComboBox cbxProfesorID;
        private System.Windows.Forms.ComboBox cbxCursoID;
        private System.Windows.Forms.ComboBox cbxGrupoID;
        private System.Windows.Forms.ComboBox cbxEstudianteID;
        private System.Windows.Forms.Label lblMatricula_ComprobanteMatricula;
        private System.Windows.Forms.Label lblMatricula_AulaID;
        private System.Windows.Forms.Label lblMatricula_HorarioID;
        private System.Windows.Forms.Label lblMatricula_ProfesorID;
        private System.Windows.Forms.Label lblMatricula_CursoID;
        private System.Windows.Forms.GroupBox gpbMatricula_Admin;
        private System.Windows.Forms.Button btnEliminar_Admin;
        private System.Windows.Forms.Button btnAdmin_Activar;
        private System.Windows.Forms.DataGridView dgv_admin;
    }
}