﻿
namespace CapaPresentacion
{
    partial class FrmEstudiante
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
            this.lblEstudiante_cedula = new System.Windows.Forms.Label();
            this.lblEstudiante_nombre = new System.Windows.Forms.Label();
            this.lblEstudiante_PrimerApellido = new System.Windows.Forms.Label();
            this.lblEstudiante_SegundoNombre = new System.Windows.Forms.Label();
            this.lblEstudiante_telefono = new System.Windows.Forms.Label();
            this.lblEstudiante_CorreoElectronico = new System.Windows.Forms.Label();
            this.lblEstudiante_Dirreccion = new System.Windows.Forms.Label();
            this.txtEstudiante_Cedula = new System.Windows.Forms.TextBox();
            this.txtEstudiante_Nombre = new System.Windows.Forms.TextBox();
            this.txtEstudiante_PrimerApellido = new System.Windows.Forms.TextBox();
            this.txtEstudiante_SegundoApellido = new System.Windows.Forms.TextBox();
            this.txtEstudiante_Telefono = new System.Windows.Forms.TextBox();
            this.txtEstudiante_Email = new System.Windows.Forms.TextBox();
            this.txtEstudiante_Dirreccion = new System.Windows.Forms.TextBox();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnEstudiante_insertar = new System.Windows.Forms.Button();
            this.btnEstudiante_Modificar = new System.Windows.Forms.Button();
            this.cbxEstudiante = new System.Windows.Forms.ComboBox();
            this.lblEstudiante_CargarDatos = new System.Windows.Forms.Label();
            this.btnEstudiante_CargarDatos = new System.Windows.Forms.Button();
            this.cbxEstudiante_Grupo = new System.Windows.Forms.ComboBox();
            this.lblEstudiante_Grupoid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstudiante_cedula
            // 
            this.lblEstudiante_cedula.AutoSize = true;
            this.lblEstudiante_cedula.Location = new System.Drawing.Point(18, 90);
            this.lblEstudiante_cedula.Name = "lblEstudiante_cedula";
            this.lblEstudiante_cedula.Size = new System.Drawing.Size(56, 17);
            this.lblEstudiante_cedula.TabIndex = 0;
            this.lblEstudiante_cedula.Text = "Cedula:";
            // 
            // lblEstudiante_nombre
            // 
            this.lblEstudiante_nombre.AutoSize = true;
            this.lblEstudiante_nombre.Location = new System.Drawing.Point(12, 128);
            this.lblEstudiante_nombre.Name = "lblEstudiante_nombre";
            this.lblEstudiante_nombre.Size = new System.Drawing.Size(62, 17);
            this.lblEstudiante_nombre.TabIndex = 1;
            this.lblEstudiante_nombre.Text = "Nombre:";
            // 
            // lblEstudiante_PrimerApellido
            // 
            this.lblEstudiante_PrimerApellido.AutoSize = true;
            this.lblEstudiante_PrimerApellido.Location = new System.Drawing.Point(12, 168);
            this.lblEstudiante_PrimerApellido.Name = "lblEstudiante_PrimerApellido";
            this.lblEstudiante_PrimerApellido.Size = new System.Drawing.Size(107, 17);
            this.lblEstudiante_PrimerApellido.TabIndex = 2;
            this.lblEstudiante_PrimerApellido.Text = "Primer Apellido:";
            // 
            // lblEstudiante_SegundoNombre
            // 
            this.lblEstudiante_SegundoNombre.AutoSize = true;
            this.lblEstudiante_SegundoNombre.Location = new System.Drawing.Point(12, 206);
            this.lblEstudiante_SegundoNombre.Name = "lblEstudiante_SegundoNombre";
            this.lblEstudiante_SegundoNombre.Size = new System.Drawing.Size(123, 17);
            this.lblEstudiante_SegundoNombre.TabIndex = 3;
            this.lblEstudiante_SegundoNombre.Text = "Segundo Apellido:";
            this.lblEstudiante_SegundoNombre.Click += new System.EventHandler(this.lblEstudiante_SegundoNombre_Click);
            // 
            // lblEstudiante_telefono
            // 
            this.lblEstudiante_telefono.AutoSize = true;
            this.lblEstudiante_telefono.Location = new System.Drawing.Point(12, 244);
            this.lblEstudiante_telefono.Name = "lblEstudiante_telefono";
            this.lblEstudiante_telefono.Size = new System.Drawing.Size(68, 17);
            this.lblEstudiante_telefono.TabIndex = 4;
            this.lblEstudiante_telefono.Text = "Telefono:";
            // 
            // lblEstudiante_CorreoElectronico
            // 
            this.lblEstudiante_CorreoElectronico.AutoSize = true;
            this.lblEstudiante_CorreoElectronico.Location = new System.Drawing.Point(12, 290);
            this.lblEstudiante_CorreoElectronico.Name = "lblEstudiante_CorreoElectronico";
            this.lblEstudiante_CorreoElectronico.Size = new System.Drawing.Size(125, 17);
            this.lblEstudiante_CorreoElectronico.TabIndex = 5;
            this.lblEstudiante_CorreoElectronico.Text = "CorreoElectronico:";
            // 
            // lblEstudiante_Dirreccion
            // 
            this.lblEstudiante_Dirreccion.AutoSize = true;
            this.lblEstudiante_Dirreccion.Location = new System.Drawing.Point(12, 344);
            this.lblEstudiante_Dirreccion.Name = "lblEstudiante_Dirreccion";
            this.lblEstudiante_Dirreccion.Size = new System.Drawing.Size(76, 17);
            this.lblEstudiante_Dirreccion.TabIndex = 6;
            this.lblEstudiante_Dirreccion.Text = "Dirreccion:";
            // 
            // txtEstudiante_Cedula
            // 
            this.txtEstudiante_Cedula.Location = new System.Drawing.Point(83, 90);
            this.txtEstudiante_Cedula.Name = "txtEstudiante_Cedula";
            this.txtEstudiante_Cedula.Size = new System.Drawing.Size(240, 22);
            this.txtEstudiante_Cedula.TabIndex = 7;
            // 
            // txtEstudiante_Nombre
            // 
            this.txtEstudiante_Nombre.Location = new System.Drawing.Point(83, 128);
            this.txtEstudiante_Nombre.Name = "txtEstudiante_Nombre";
            this.txtEstudiante_Nombre.Size = new System.Drawing.Size(240, 22);
            this.txtEstudiante_Nombre.TabIndex = 8;
            // 
            // txtEstudiante_PrimerApellido
            // 
            this.txtEstudiante_PrimerApellido.Location = new System.Drawing.Point(138, 168);
            this.txtEstudiante_PrimerApellido.Name = "txtEstudiante_PrimerApellido";
            this.txtEstudiante_PrimerApellido.Size = new System.Drawing.Size(185, 22);
            this.txtEstudiante_PrimerApellido.TabIndex = 9;
            // 
            // txtEstudiante_SegundoApellido
            // 
            this.txtEstudiante_SegundoApellido.Location = new System.Drawing.Point(138, 206);
            this.txtEstudiante_SegundoApellido.Name = "txtEstudiante_SegundoApellido";
            this.txtEstudiante_SegundoApellido.Size = new System.Drawing.Size(185, 22);
            this.txtEstudiante_SegundoApellido.TabIndex = 10;
            // 
            // txtEstudiante_Telefono
            // 
            this.txtEstudiante_Telefono.Location = new System.Drawing.Point(86, 244);
            this.txtEstudiante_Telefono.Name = "txtEstudiante_Telefono";
            this.txtEstudiante_Telefono.Size = new System.Drawing.Size(237, 22);
            this.txtEstudiante_Telefono.TabIndex = 11;
            this.txtEstudiante_Telefono.TextChanged += new System.EventHandler(this.txtEstudiante_Telefono_TextChanged);
            // 
            // txtEstudiante_Email
            // 
            this.txtEstudiante_Email.Location = new System.Drawing.Point(149, 290);
            this.txtEstudiante_Email.Name = "txtEstudiante_Email";
            this.txtEstudiante_Email.Size = new System.Drawing.Size(174, 22);
            this.txtEstudiante_Email.TabIndex = 12;
            // 
            // txtEstudiante_Dirreccion
            // 
            this.txtEstudiante_Dirreccion.Location = new System.Drawing.Point(94, 339);
            this.txtEstudiante_Dirreccion.Name = "txtEstudiante_Dirreccion";
            this.txtEstudiante_Dirreccion.Size = new System.Drawing.Size(229, 22);
            this.txtEstudiante_Dirreccion.TabIndex = 13;
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(374, 44);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.RowHeadersWidth = 51;
            this.dgvEstudiantes.RowTemplate.Height = 24;
            this.dgvEstudiantes.Size = new System.Drawing.Size(666, 276);
            this.dgvEstudiantes.TabIndex = 14;
            this.dgvEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantes_CellContentClick);
            // 
            // btnEstudiante_insertar
            // 
            this.btnEstudiante_insertar.Location = new System.Drawing.Point(12, 392);
            this.btnEstudiante_insertar.Name = "btnEstudiante_insertar";
            this.btnEstudiante_insertar.Size = new System.Drawing.Size(152, 23);
            this.btnEstudiante_insertar.TabIndex = 15;
            this.btnEstudiante_insertar.Text = "Insertar Estudiante";
            this.btnEstudiante_insertar.UseVisualStyleBackColor = true;
            this.btnEstudiante_insertar.Click += new System.EventHandler(this.btnEstudiante_insertar_Click);
            // 
            // btnEstudiante_Modificar
            // 
            this.btnEstudiante_Modificar.Location = new System.Drawing.Point(187, 392);
            this.btnEstudiante_Modificar.Name = "btnEstudiante_Modificar";
            this.btnEstudiante_Modificar.Size = new System.Drawing.Size(153, 23);
            this.btnEstudiante_Modificar.TabIndex = 16;
            this.btnEstudiante_Modificar.Text = "Modificar Estudiante";
            this.btnEstudiante_Modificar.UseVisualStyleBackColor = true;
            this.btnEstudiante_Modificar.Click += new System.EventHandler(this.btnEstudiante_Modificar_Click);
            // 
            // cbxEstudiante
            // 
            this.cbxEstudiante.FormattingEnabled = true;
            this.cbxEstudiante.Location = new System.Drawing.Point(83, 455);
            this.cbxEstudiante.Name = "cbxEstudiante";
            this.cbxEstudiante.Size = new System.Drawing.Size(162, 24);
            this.cbxEstudiante.TabIndex = 17;
            // 
            // lblEstudiante_CargarDatos
            // 
            this.lblEstudiante_CargarDatos.AutoSize = true;
            this.lblEstudiante_CargarDatos.Location = new System.Drawing.Point(22, 455);
            this.lblEstudiante_CargarDatos.Name = "lblEstudiante_CargarDatos";
            this.lblEstudiante_CargarDatos.Size = new System.Drawing.Size(43, 17);
            this.lblEstudiante_CargarDatos.TabIndex = 18;
            this.lblEstudiante_CargarDatos.Text = "Filtro:";
            // 
            // btnEstudiante_CargarDatos
            // 
            this.btnEstudiante_CargarDatos.Location = new System.Drawing.Point(277, 456);
            this.btnEstudiante_CargarDatos.Name = "btnEstudiante_CargarDatos";
            this.btnEstudiante_CargarDatos.Size = new System.Drawing.Size(99, 23);
            this.btnEstudiante_CargarDatos.TabIndex = 19;
            this.btnEstudiante_CargarDatos.Text = "Cargar datos";
            this.btnEstudiante_CargarDatos.UseVisualStyleBackColor = true;
            this.btnEstudiante_CargarDatos.Click += new System.EventHandler(this.btnEstudiante_CargarDatos_Click);
            // 
            // cbxEstudiante_Grupo
            // 
            this.cbxEstudiante_Grupo.FormattingEnabled = true;
            this.cbxEstudiante_Grupo.Location = new System.Drawing.Point(122, 44);
            this.cbxEstudiante_Grupo.Name = "cbxEstudiante_Grupo";
            this.cbxEstudiante_Grupo.Size = new System.Drawing.Size(197, 24);
            this.cbxEstudiante_Grupo.TabIndex = 20;
            this.cbxEstudiante_Grupo.SelectedIndexChanged += new System.EventHandler(this.cbxEstudiante_Grupo_SelectedIndexChanged);
            // 
            // lblEstudiante_Grupoid
            // 
            this.lblEstudiante_Grupoid.AutoSize = true;
            this.lblEstudiante_Grupoid.Location = new System.Drawing.Point(22, 44);
            this.lblEstudiante_Grupoid.Name = "lblEstudiante_Grupoid";
            this.lblEstudiante_Grupoid.Size = new System.Drawing.Size(52, 17);
            this.lblEstudiante_Grupoid.TabIndex = 21;
            this.lblEstudiante_Grupoid.Text = "Grupo:";
            this.lblEstudiante_Grupoid.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 537);
            this.Controls.Add(this.lblEstudiante_Grupoid);
            this.Controls.Add(this.cbxEstudiante_Grupo);
            this.Controls.Add(this.btnEstudiante_CargarDatos);
            this.Controls.Add(this.lblEstudiante_CargarDatos);
            this.Controls.Add(this.cbxEstudiante);
            this.Controls.Add(this.btnEstudiante_Modificar);
            this.Controls.Add(this.btnEstudiante_insertar);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.txtEstudiante_Dirreccion);
            this.Controls.Add(this.txtEstudiante_Email);
            this.Controls.Add(this.txtEstudiante_Telefono);
            this.Controls.Add(this.txtEstudiante_SegundoApellido);
            this.Controls.Add(this.txtEstudiante_PrimerApellido);
            this.Controls.Add(this.txtEstudiante_Nombre);
            this.Controls.Add(this.txtEstudiante_Cedula);
            this.Controls.Add(this.lblEstudiante_Dirreccion);
            this.Controls.Add(this.lblEstudiante_CorreoElectronico);
            this.Controls.Add(this.lblEstudiante_telefono);
            this.Controls.Add(this.lblEstudiante_SegundoNombre);
            this.Controls.Add(this.lblEstudiante_PrimerApellido);
            this.Controls.Add(this.lblEstudiante_nombre);
            this.Controls.Add(this.lblEstudiante_cedula);
            this.Name = "FrmEstudiante";
            this.Text = "Registro de maticula :: Modulo Estudiante";
            this.Load += new System.EventHandler(this.FrmEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstudiante_cedula;
        private System.Windows.Forms.Label lblEstudiante_nombre;
        private System.Windows.Forms.Label lblEstudiante_PrimerApellido;
        private System.Windows.Forms.Label lblEstudiante_SegundoNombre;
        private System.Windows.Forms.Label lblEstudiante_telefono;
        private System.Windows.Forms.Label lblEstudiante_CorreoElectronico;
        private System.Windows.Forms.Label lblEstudiante_Dirreccion;
        private System.Windows.Forms.TextBox txtEstudiante_Cedula;
        private System.Windows.Forms.TextBox txtEstudiante_Nombre;
        private System.Windows.Forms.TextBox txtEstudiante_PrimerApellido;
        private System.Windows.Forms.TextBox txtEstudiante_SegundoApellido;
        private System.Windows.Forms.TextBox txtEstudiante_Telefono;
        private System.Windows.Forms.TextBox txtEstudiante_Email;
        private System.Windows.Forms.TextBox txtEstudiante_Dirreccion;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Button btnEstudiante_insertar;
        private System.Windows.Forms.Button btnEstudiante_Modificar;
        private System.Windows.Forms.ComboBox cbxEstudiante;
        private System.Windows.Forms.Label lblEstudiante_CargarDatos;
        private System.Windows.Forms.Button btnEstudiante_CargarDatos;
        private System.Windows.Forms.ComboBox cbxEstudiante_Grupo;
        private System.Windows.Forms.Label lblEstudiante_Grupoid;
    }
}