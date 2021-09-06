
namespace CapaPresentacion
{
    partial class frmProfesor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProfesor_Cedula = new System.Windows.Forms.Label();
            this.lblProfesor_nombre = new System.Windows.Forms.Label();
            this.lblProfesorPrimerApellido = new System.Windows.Forms.Label();
            this.lblProfesor_segundoApellido = new System.Windows.Forms.Label();
            this.lblProfesor_Telefono = new System.Windows.Forms.Label();
            this.lblProfesor_correoElectronico = new System.Windows.Forms.Label();
            this.lblProfesor_Dirreccion = new System.Windows.Forms.Label();
            this.txtProfesor_Cedula = new System.Windows.Forms.TextBox();
            this.txtProfesor_PrimerApeliido = new System.Windows.Forms.TextBox();
            this.txtProfesor_nombre = new System.Windows.Forms.TextBox();
            this.txtProfesor_telefono = new System.Windows.Forms.TextBox();
            this.txtProfesor_SegundoApeliido = new System.Windows.Forms.TextBox();
            this.txtProfesor_CorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtProfesor_Dirreccion = new System.Windows.Forms.TextBox();
            this.btnProfesor_Insertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dvgProfesores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.cbxProfesor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfesor_Cedula
            // 
            this.lblProfesor_Cedula.AutoSize = true;
            this.lblProfesor_Cedula.Location = new System.Drawing.Point(21, 37);
            this.lblProfesor_Cedula.Name = "lblProfesor_Cedula";
            this.lblProfesor_Cedula.Size = new System.Drawing.Size(56, 17);
            this.lblProfesor_Cedula.TabIndex = 0;
            this.lblProfesor_Cedula.Text = "Cédula:";
            this.lblProfesor_Cedula.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProfesor_nombre
            // 
            this.lblProfesor_nombre.AutoSize = true;
            this.lblProfesor_nombre.Location = new System.Drawing.Point(21, 86);
            this.lblProfesor_nombre.Name = "lblProfesor_nombre";
            this.lblProfesor_nombre.Size = new System.Drawing.Size(62, 17);
            this.lblProfesor_nombre.TabIndex = 1;
            this.lblProfesor_nombre.Text = "Nombre:";
            // 
            // lblProfesorPrimerApellido
            // 
            this.lblProfesorPrimerApellido.AutoSize = true;
            this.lblProfesorPrimerApellido.Location = new System.Drawing.Point(21, 135);
            this.lblProfesorPrimerApellido.Name = "lblProfesorPrimerApellido";
            this.lblProfesorPrimerApellido.Size = new System.Drawing.Size(103, 17);
            this.lblProfesorPrimerApellido.TabIndex = 2;
            this.lblProfesorPrimerApellido.Text = "PrimerApellido:";
            this.lblProfesorPrimerApellido.Click += new System.EventHandler(this.PrimerApellido_Click);
            // 
            // lblProfesor_segundoApellido
            // 
            this.lblProfesor_segundoApellido.AutoSize = true;
            this.lblProfesor_segundoApellido.Location = new System.Drawing.Point(21, 182);
            this.lblProfesor_segundoApellido.Name = "lblProfesor_segundoApellido";
            this.lblProfesor_segundoApellido.Size = new System.Drawing.Size(119, 17);
            this.lblProfesor_segundoApellido.TabIndex = 5;
            this.lblProfesor_segundoApellido.Text = "SegundoApellido:";
            // 
            // lblProfesor_Telefono
            // 
            this.lblProfesor_Telefono.AutoSize = true;
            this.lblProfesor_Telefono.Location = new System.Drawing.Point(21, 228);
            this.lblProfesor_Telefono.Name = "lblProfesor_Telefono";
            this.lblProfesor_Telefono.Size = new System.Drawing.Size(68, 17);
            this.lblProfesor_Telefono.TabIndex = 4;
            this.lblProfesor_Telefono.Text = "Telefono:";
            // 
            // lblProfesor_correoElectronico
            // 
            this.lblProfesor_correoElectronico.AutoSize = true;
            this.lblProfesor_correoElectronico.Location = new System.Drawing.Point(21, 272);
            this.lblProfesor_correoElectronico.Name = "lblProfesor_correoElectronico";
            this.lblProfesor_correoElectronico.Size = new System.Drawing.Size(125, 17);
            this.lblProfesor_correoElectronico.TabIndex = 3;
            this.lblProfesor_correoElectronico.Text = "CorreoElectronico:";
            this.lblProfesor_correoElectronico.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblProfesor_Dirreccion
            // 
            this.lblProfesor_Dirreccion.AutoSize = true;
            this.lblProfesor_Dirreccion.Location = new System.Drawing.Point(21, 322);
            this.lblProfesor_Dirreccion.Name = "lblProfesor_Dirreccion";
            this.lblProfesor_Dirreccion.Size = new System.Drawing.Size(76, 17);
            this.lblProfesor_Dirreccion.TabIndex = 6;
            this.lblProfesor_Dirreccion.Text = "Dirreccion:";
            this.lblProfesor_Dirreccion.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtProfesor_Cedula
            // 
            this.txtProfesor_Cedula.Location = new System.Drawing.Point(85, 36);
            this.txtProfesor_Cedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_Cedula.Name = "txtProfesor_Cedula";
            this.txtProfesor_Cedula.Size = new System.Drawing.Size(167, 22);
            this.txtProfesor_Cedula.TabIndex = 7;
            this.txtProfesor_Cedula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtProfesor_PrimerApeliido
            // 
            this.txtProfesor_PrimerApeliido.Location = new System.Drawing.Point(120, 135);
            this.txtProfesor_PrimerApeliido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_PrimerApeliido.Name = "txtProfesor_PrimerApeliido";
            this.txtProfesor_PrimerApeliido.Size = new System.Drawing.Size(132, 22);
            this.txtProfesor_PrimerApeliido.TabIndex = 8;
            this.txtProfesor_PrimerApeliido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtProfesor_nombre
            // 
            this.txtProfesor_nombre.Location = new System.Drawing.Point(85, 85);
            this.txtProfesor_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_nombre.Name = "txtProfesor_nombre";
            this.txtProfesor_nombre.Size = new System.Drawing.Size(167, 22);
            this.txtProfesor_nombre.TabIndex = 9;
            this.txtProfesor_nombre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtProfesor_telefono
            // 
            this.txtProfesor_telefono.Location = new System.Drawing.Point(85, 225);
            this.txtProfesor_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_telefono.Name = "txtProfesor_telefono";
            this.txtProfesor_telefono.Size = new System.Drawing.Size(167, 22);
            this.txtProfesor_telefono.TabIndex = 10;
            this.txtProfesor_telefono.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtProfesor_SegundoApeliido
            // 
            this.txtProfesor_SegundoApeliido.Location = new System.Drawing.Point(141, 178);
            this.txtProfesor_SegundoApeliido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_SegundoApeliido.Name = "txtProfesor_SegundoApeliido";
            this.txtProfesor_SegundoApeliido.Size = new System.Drawing.Size(111, 22);
            this.txtProfesor_SegundoApeliido.TabIndex = 11;
            this.txtProfesor_SegundoApeliido.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtProfesor_CorreoElectronico
            // 
            this.txtProfesor_CorreoElectronico.Location = new System.Drawing.Point(152, 272);
            this.txtProfesor_CorreoElectronico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_CorreoElectronico.Name = "txtProfesor_CorreoElectronico";
            this.txtProfesor_CorreoElectronico.Size = new System.Drawing.Size(100, 22);
            this.txtProfesor_CorreoElectronico.TabIndex = 12;
            this.txtProfesor_CorreoElectronico.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtProfesor_Dirreccion
            // 
            this.txtProfesor_Dirreccion.Location = new System.Drawing.Point(103, 319);
            this.txtProfesor_Dirreccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_Dirreccion.Name = "txtProfesor_Dirreccion";
            this.txtProfesor_Dirreccion.Size = new System.Drawing.Size(149, 22);
            this.txtProfesor_Dirreccion.TabIndex = 13;
            this.txtProfesor_Dirreccion.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // btnProfesor_Insertar
            // 
            this.btnProfesor_Insertar.Location = new System.Drawing.Point(12, 385);
            this.btnProfesor_Insertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfesor_Insertar.Name = "btnProfesor_Insertar";
            this.btnProfesor_Insertar.Size = new System.Drawing.Size(133, 23);
            this.btnProfesor_Insertar.TabIndex = 14;
            this.btnProfesor_Insertar.Text = "Insertar Profesor ";
            this.btnProfesor_Insertar.UseVisualStyleBackColor = true;
            this.btnProfesor_Insertar.Click += new System.EventHandler(this.btnProfesor_Insertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(171, 385);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(128, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dvgProfesores
            // 
            this.dvgProfesores.ColumnHeadersHeight = 29;
            this.dvgProfesores.Location = new System.Drawing.Point(291, 11);
            this.dvgProfesores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgProfesores.Name = "dvgProfesores";
            this.dvgProfesores.RowHeadersWidth = 51;
            this.dvgProfesores.Size = new System.Drawing.Size(913, 353);
            this.dvgProfesores.TabIndex = 0;
            this.dvgProfesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProfesores_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 465);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(313, 465);
            this.btnCargarDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(128, 28);
            this.btnCargarDatos.TabIndex = 17;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // cbxProfesor
            // 
            this.cbxProfesor.FormattingEnabled = true;
            this.cbxProfesor.Location = new System.Drawing.Point(92, 465);
            this.cbxProfesor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxProfesor.Name = "cbxProfesor";
            this.cbxProfesor.Size = new System.Drawing.Size(160, 24);
            this.cbxProfesor.TabIndex = 18;
            // 
            // frmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 571);
            this.Controls.Add(this.cbxProfesor);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgProfesores);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnProfesor_Insertar);
            this.Controls.Add(this.txtProfesor_Dirreccion);
            this.Controls.Add(this.txtProfesor_CorreoElectronico);
            this.Controls.Add(this.txtProfesor_SegundoApeliido);
            this.Controls.Add(this.txtProfesor_telefono);
            this.Controls.Add(this.txtProfesor_nombre);
            this.Controls.Add(this.txtProfesor_PrimerApeliido);
            this.Controls.Add(this.txtProfesor_Cedula);
            this.Controls.Add(this.lblProfesor_Dirreccion);
            this.Controls.Add(this.lblProfesor_segundoApellido);
            this.Controls.Add(this.lblProfesor_Telefono);
            this.Controls.Add(this.lblProfesor_correoElectronico);
            this.Controls.Add(this.lblProfesorPrimerApellido);
            this.Controls.Add(this.lblProfesor_nombre);
            this.Controls.Add(this.lblProfesor_Cedula);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProfesor";
            this.Text = " Registro de maticula :: Modulo Profesor";
            this.Load += new System.EventHandler(this.frmProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfesor_Cedula;
        private System.Windows.Forms.Label lblProfesor_nombre;
        private System.Windows.Forms.Label lblProfesorPrimerApellido;
        private System.Windows.Forms.Label lblProfesor_segundoApellido;
        private System.Windows.Forms.Label lblProfesor_Telefono;
        private System.Windows.Forms.Label lblProfesor_correoElectronico;
        private System.Windows.Forms.Label lblProfesor_Dirreccion;
        private System.Windows.Forms.TextBox txtProfesor_Cedula;
        private System.Windows.Forms.TextBox txtProfesor_PrimerApeliido;
        private System.Windows.Forms.TextBox txtProfesor_nombre;
        private System.Windows.Forms.TextBox txtProfesor_telefono;
        private System.Windows.Forms.TextBox txtProfesor_SegundoApeliido;
        private System.Windows.Forms.TextBox txtProfesor_CorreoElectronico;
        private System.Windows.Forms.TextBox txtProfesor_Dirreccion;
        private System.Windows.Forms.Button btnProfesor_Insertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dvgProfesores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.ComboBox cbxProfesor;
    }
}

