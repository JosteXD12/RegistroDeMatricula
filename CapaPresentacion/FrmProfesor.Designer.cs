
namespace CapaPresentacion
{
    partial class FrmProfesor
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxProfesor = new System.Windows.Forms.ComboBox();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProfesor_Insertar = new System.Windows.Forms.Button();
            this.btnProfesora_Eliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gpbProfesor_Admin = new System.Windows.Forms.GroupBox();
            this.btnEliminar_Admin = new System.Windows.Forms.Button();
            this.btnAdmin_Activar = new System.Windows.Forms.Button();
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.dvgProfesores = new System.Windows.Forms.DataGridView();
            this.txtProfesor_Dirreccion = new System.Windows.Forms.TextBox();
            this.txtProfesor_CorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtProfesor_SegundoApeliido = new System.Windows.Forms.TextBox();
            this.txtProfesor_telefono = new System.Windows.Forms.TextBox();
            this.txtProfesor_nombre = new System.Windows.Forms.TextBox();
            this.txtProfesor_PrimerApeliido = new System.Windows.Forms.TextBox();
            this.txtProfesor_Cedula = new System.Windows.Forms.TextBox();
            this.lblProfesor_Dirreccion = new System.Windows.Forms.Label();
            this.lblProfesor_segundoApellido = new System.Windows.Forms.Label();
            this.lblProfesor_Telefono = new System.Windows.Forms.Label();
            this.lblProfesor_correoElectronico = new System.Windows.Forms.Label();
            this.lblProfesorPrimerApellido = new System.Windows.Forms.Label();
            this.lblProfesor_nombre = new System.Windows.Forms.Label();
            this.lblProfesor_Cedula = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gpbProfesor_Admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProfesores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbxProfesor);
            this.panel3.Controls.Add(this.btnCargarDatos);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(22, 533);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 101);
            this.panel3.TabIndex = 45;
            // 
            // cbxProfesor
            // 
            this.cbxProfesor.FormattingEnabled = true;
            this.cbxProfesor.Location = new System.Drawing.Point(82, 37);
            this.cbxProfesor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxProfesor.Name = "cbxProfesor";
            this.cbxProfesor.Size = new System.Drawing.Size(180, 24);
            this.cbxProfesor.TabIndex = 44;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnCargarDatos.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.ForeColor = System.Drawing.Color.White;
            this.btnCargarDatos.Location = new System.Drawing.Point(291, 30);
            this.btnCargarDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(144, 33);
            this.btnCargarDatos.TabIndex = 43;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Filtro";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnProfesor_Insertar);
            this.panel2.Controls.Add(this.btnProfesora_Eliminar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Location = new System.Drawing.Point(22, 422);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 103);
            this.panel2.TabIndex = 44;
            // 
            // btnProfesor_Insertar
            // 
            this.btnProfesor_Insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnProfesor_Insertar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnProfesor_Insertar.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesor_Insertar.ForeColor = System.Drawing.Color.White;
            this.btnProfesor_Insertar.Location = new System.Drawing.Point(3, 23);
            this.btnProfesor_Insertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfesor_Insertar.Name = "btnProfesor_Insertar";
            this.btnProfesor_Insertar.Size = new System.Drawing.Size(150, 27);
            this.btnProfesor_Insertar.TabIndex = 37;
            this.btnProfesor_Insertar.Text = "Insertar ";
            this.btnProfesor_Insertar.UseVisualStyleBackColor = false;
            this.btnProfesor_Insertar.Click += new System.EventHandler(this.btnProfesor_Insertar_Click);
            // 
            // btnProfesora_Eliminar
            // 
            this.btnProfesora_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnProfesora_Eliminar.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesora_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btnProfesora_Eliminar.Location = new System.Drawing.Point(201, 23);
            this.btnProfesora_Eliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProfesora_Eliminar.Name = "btnProfesora_Eliminar";
            this.btnProfesora_Eliminar.Size = new System.Drawing.Size(145, 27);
            this.btnProfesora_Eliminar.TabIndex = 42;
            this.btnProfesora_Eliminar.Text = "Eliminar ";
            this.btnProfesora_Eliminar.UseVisualStyleBackColor = false;
            this.btnProfesora_Eliminar.Click += new System.EventHandler(this.btnProfesora_Eliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.btnModificar.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(99, 66);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(144, 27);
            this.btnModificar.TabIndex = 38;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gpbProfesor_Admin
            // 
            this.gpbProfesor_Admin.Controls.Add(this.btnEliminar_Admin);
            this.gpbProfesor_Admin.Controls.Add(this.btnAdmin_Activar);
            this.gpbProfesor_Admin.Controls.Add(this.dgv_admin);
            this.gpbProfesor_Admin.Location = new System.Drawing.Point(480, 375);
            this.gpbProfesor_Admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbProfesor_Admin.Name = "gpbProfesor_Admin";
            this.gpbProfesor_Admin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbProfesor_Admin.Size = new System.Drawing.Size(597, 266);
            this.gpbProfesor_Admin.TabIndex = 43;
            this.gpbProfesor_Admin.TabStop = false;
            this.gpbProfesor_Admin.Text = "Admin";
            // 
            // btnEliminar_Admin
            // 
            this.btnEliminar_Admin.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar_Admin.Location = new System.Drawing.Point(326, 217);
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
            this.btnAdmin_Activar.Location = new System.Drawing.Point(199, 218);
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
            this.dgv_admin.Size = new System.Drawing.Size(575, 185);
            this.dgv_admin.TabIndex = 0;
            // 
            // dvgProfesores
            // 
            this.dvgProfesores.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.dvgProfesores.BackgroundColor = System.Drawing.Color.Azure;
            this.dvgProfesores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgProfesores.ColumnHeadersHeight = 29;
            this.dvgProfesores.GridColor = System.Drawing.Color.Azure;
            this.dvgProfesores.Location = new System.Drawing.Point(480, 15);
            this.dvgProfesores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgProfesores.Name = "dvgProfesores";
            this.dvgProfesores.RowHeadersWidth = 51;
            this.dvgProfesores.Size = new System.Drawing.Size(582, 337);
            this.dvgProfesores.TabIndex = 23;
            this.dvgProfesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProfesores_CellContentClick);
            // 
            // txtProfesor_Dirreccion
            // 
            this.txtProfesor_Dirreccion.Location = new System.Drawing.Point(184, 375);
            this.txtProfesor_Dirreccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_Dirreccion.Name = "txtProfesor_Dirreccion";
            this.txtProfesor_Dirreccion.Size = new System.Drawing.Size(223, 22);
            this.txtProfesor_Dirreccion.TabIndex = 36;
            // 
            // txtProfesor_CorreoElectronico
            // 
            this.txtProfesor_CorreoElectronico.Location = new System.Drawing.Point(184, 316);
            this.txtProfesor_CorreoElectronico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_CorreoElectronico.Name = "txtProfesor_CorreoElectronico";
            this.txtProfesor_CorreoElectronico.Size = new System.Drawing.Size(223, 22);
            this.txtProfesor_CorreoElectronico.TabIndex = 35;
            // 
            // txtProfesor_SegundoApeliido
            // 
            this.txtProfesor_SegundoApeliido.Location = new System.Drawing.Point(182, 209);
            this.txtProfesor_SegundoApeliido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_SegundoApeliido.Name = "txtProfesor_SegundoApeliido";
            this.txtProfesor_SegundoApeliido.Size = new System.Drawing.Size(226, 22);
            this.txtProfesor_SegundoApeliido.TabIndex = 34;
            this.txtProfesor_SegundoApeliido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfesor_SegundoApeliido_KeyPress);
            // 
            // txtProfesor_telefono
            // 
            this.txtProfesor_telefono.Location = new System.Drawing.Point(182, 264);
            this.txtProfesor_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_telefono.Name = "txtProfesor_telefono";
            this.txtProfesor_telefono.Size = new System.Drawing.Size(226, 22);
            this.txtProfesor_telefono.TabIndex = 33;
            this.txtProfesor_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfesor_telefono_KeyPress);
            // 
            // txtProfesor_nombre
            // 
            this.txtProfesor_nombre.Location = new System.Drawing.Point(182, 99);
            this.txtProfesor_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_nombre.Name = "txtProfesor_nombre";
            this.txtProfesor_nombre.Size = new System.Drawing.Size(226, 22);
            this.txtProfesor_nombre.TabIndex = 32;
            this.txtProfesor_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfesor_nombre_KeyPress);
            // 
            // txtProfesor_PrimerApeliido
            // 
            this.txtProfesor_PrimerApeliido.Location = new System.Drawing.Point(182, 157);
            this.txtProfesor_PrimerApeliido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_PrimerApeliido.Name = "txtProfesor_PrimerApeliido";
            this.txtProfesor_PrimerApeliido.Size = new System.Drawing.Size(226, 22);
            this.txtProfesor_PrimerApeliido.TabIndex = 31;
            this.txtProfesor_PrimerApeliido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfesor_PrimerApeliido_KeyPress);
            // 
            // txtProfesor_Cedula
            // 
            this.txtProfesor_Cedula.Location = new System.Drawing.Point(182, 40);
            this.txtProfesor_Cedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_Cedula.Name = "txtProfesor_Cedula";
            this.txtProfesor_Cedula.Size = new System.Drawing.Size(226, 22);
            this.txtProfesor_Cedula.TabIndex = 30;
            this.txtProfesor_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfesor_Cedula_KeyPress);
            // 
            // lblProfesor_Dirreccion
            // 
            this.lblProfesor_Dirreccion.AutoSize = true;
            this.lblProfesor_Dirreccion.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_Dirreccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblProfesor_Dirreccion.Location = new System.Drawing.Point(18, 379);
            this.lblProfesor_Dirreccion.Name = "lblProfesor_Dirreccion";
            this.lblProfesor_Dirreccion.Size = new System.Drawing.Size(85, 19);
            this.lblProfesor_Dirreccion.TabIndex = 29;
            this.lblProfesor_Dirreccion.Text = "Dirreccion:";
            // 
            // lblProfesor_segundoApellido
            // 
            this.lblProfesor_segundoApellido.AutoSize = true;
            this.lblProfesor_segundoApellido.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_segundoApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblProfesor_segundoApellido.Location = new System.Drawing.Point(18, 213);
            this.lblProfesor_segundoApellido.Name = "lblProfesor_segundoApellido";
            this.lblProfesor_segundoApellido.Size = new System.Drawing.Size(133, 19);
            this.lblProfesor_segundoApellido.TabIndex = 28;
            this.lblProfesor_segundoApellido.Text = "SegundoApellido:";
            // 
            // lblProfesor_Telefono
            // 
            this.lblProfesor_Telefono.AutoSize = true;
            this.lblProfesor_Telefono.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_Telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblProfesor_Telefono.Location = new System.Drawing.Point(18, 267);
            this.lblProfesor_Telefono.Name = "lblProfesor_Telefono";
            this.lblProfesor_Telefono.Size = new System.Drawing.Size(74, 19);
            this.lblProfesor_Telefono.TabIndex = 27;
            this.lblProfesor_Telefono.Text = "Telefono:";
            // 
            // lblProfesor_correoElectronico
            // 
            this.lblProfesor_correoElectronico.AutoSize = true;
            this.lblProfesor_correoElectronico.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_correoElectronico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblProfesor_correoElectronico.Location = new System.Drawing.Point(18, 319);
            this.lblProfesor_correoElectronico.Name = "lblProfesor_correoElectronico";
            this.lblProfesor_correoElectronico.Size = new System.Drawing.Size(139, 19);
            this.lblProfesor_correoElectronico.TabIndex = 26;
            this.lblProfesor_correoElectronico.Text = "CorreoElectronico:";
            // 
            // lblProfesorPrimerApellido
            // 
            this.lblProfesorPrimerApellido.AutoSize = true;
            this.lblProfesorPrimerApellido.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesorPrimerApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblProfesorPrimerApellido.Location = new System.Drawing.Point(18, 157);
            this.lblProfesorPrimerApellido.Name = "lblProfesorPrimerApellido";
            this.lblProfesorPrimerApellido.Size = new System.Drawing.Size(121, 19);
            this.lblProfesorPrimerApellido.TabIndex = 25;
            this.lblProfesorPrimerApellido.Text = "PrimerApellido:";
            // 
            // lblProfesor_nombre
            // 
            this.lblProfesor_nombre.AutoSize = true;
            this.lblProfesor_nombre.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblProfesor_nombre.Location = new System.Drawing.Point(18, 99);
            this.lblProfesor_nombre.Name = "lblProfesor_nombre";
            this.lblProfesor_nombre.Size = new System.Drawing.Size(71, 19);
            this.lblProfesor_nombre.TabIndex = 24;
            this.lblProfesor_nombre.Text = "Nombre:";
            // 
            // lblProfesor_Cedula
            // 
            this.lblProfesor_Cedula.AutoSize = true;
            this.lblProfesor_Cedula.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_Cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.lblProfesor_Cedula.Location = new System.Drawing.Point(18, 40);
            this.lblProfesor_Cedula.Name = "lblProfesor_Cedula";
            this.lblProfesor_Cedula.Size = new System.Drawing.Size(62, 19);
            this.lblProfesor_Cedula.TabIndex = 22;
            this.lblProfesor_Cedula.Text = "Cédula:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gpbProfesor_Admin);
            this.panel1.Controls.Add(this.dvgProfesores);
            this.panel1.Controls.Add(this.txtProfesor_Dirreccion);
            this.panel1.Controls.Add(this.txtProfesor_CorreoElectronico);
            this.panel1.Controls.Add(this.txtProfesor_SegundoApeliido);
            this.panel1.Controls.Add(this.txtProfesor_telefono);
            this.panel1.Controls.Add(this.txtProfesor_nombre);
            this.panel1.Controls.Add(this.txtProfesor_PrimerApeliido);
            this.panel1.Controls.Add(this.txtProfesor_Cedula);
            this.panel1.Controls.Add(this.lblProfesor_Dirreccion);
            this.panel1.Controls.Add(this.lblProfesor_segundoApellido);
            this.panel1.Controls.Add(this.lblProfesor_Telefono);
            this.panel1.Controls.Add(this.lblProfesor_correoElectronico);
            this.panel1.Controls.Add(this.lblProfesorPrimerApellido);
            this.panel1.Controls.Add(this.lblProfesor_nombre);
            this.panel1.Controls.Add(this.lblProfesor_Cedula);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 645);
            this.panel1.TabIndex = 1;
            // 
            // FrmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 645);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FrmProfesor";
            this.Load += new System.EventHandler(this.FrmProfesor_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gpbProfesor_Admin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProfesores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbxProfesor;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProfesor_Insertar;
        private System.Windows.Forms.Button btnProfesora_Eliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gpbProfesor_Admin;
        private System.Windows.Forms.Button btnEliminar_Admin;
        private System.Windows.Forms.Button btnAdmin_Activar;
        private System.Windows.Forms.DataGridView dgv_admin;
        private System.Windows.Forms.DataGridView dvgProfesores;
        private System.Windows.Forms.TextBox txtProfesor_Dirreccion;
        private System.Windows.Forms.TextBox txtProfesor_CorreoElectronico;
        private System.Windows.Forms.TextBox txtProfesor_SegundoApeliido;
        private System.Windows.Forms.TextBox txtProfesor_telefono;
        private System.Windows.Forms.TextBox txtProfesor_nombre;
        private System.Windows.Forms.TextBox txtProfesor_PrimerApeliido;
        private System.Windows.Forms.TextBox txtProfesor_Cedula;
        private System.Windows.Forms.Label lblProfesor_Dirreccion;
        private System.Windows.Forms.Label lblProfesor_segundoApellido;
        private System.Windows.Forms.Label lblProfesor_Telefono;
        private System.Windows.Forms.Label lblProfesor_correoElectronico;
        private System.Windows.Forms.Label lblProfesorPrimerApellido;
        private System.Windows.Forms.Label lblProfesor_nombre;
        private System.Windows.Forms.Label lblProfesor_Cedula;
        private System.Windows.Forms.Panel panel1;
    }
}