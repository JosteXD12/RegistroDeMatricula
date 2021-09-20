
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
            this.lblHorario_descripcion = new System.Windows.Forms.Label();
            this.lblHorario_dia = new System.Windows.Forms.Label();
            this.lblHorario_HoraInicio = new System.Windows.Forms.Label();
            this.lblHorario_Horalinal = new System.Windows.Forms.Label();
            this.txtHorario_Descripccion = new System.Windows.Forms.TextBox();
            this.txtHorario_Dia = new System.Windows.Forms.TextBox();
            this.txtHorario_HoraInicio = new System.Windows.Forms.TextBox();
            this.txtHorario_horaFinalizacion = new System.Windows.Forms.TextBox();
            this.cbxHorario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHorario_CargarDatos = new System.Windows.Forms.Button();
            this.btnHorario_insertar = new System.Windows.Forms.Button();
            this.btnHorario_modificar = new System.Windows.Forms.Button();
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHorario_descripcion
            // 
            this.lblHorario_descripcion.AutoSize = true;
            this.lblHorario_descripcion.Location = new System.Drawing.Point(33, 89);
            this.lblHorario_descripcion.Name = "lblHorario_descripcion";
            this.lblHorario_descripcion.Size = new System.Drawing.Size(90, 17);
            this.lblHorario_descripcion.TabIndex = 0;
            this.lblHorario_descripcion.Text = "Descripcion: ";
            // 
            // lblHorario_dia
            // 
            this.lblHorario_dia.AutoSize = true;
            this.lblHorario_dia.Location = new System.Drawing.Point(61, 136);
            this.lblHorario_dia.Name = "lblHorario_dia";
            this.lblHorario_dia.Size = new System.Drawing.Size(33, 17);
            this.lblHorario_dia.TabIndex = 1;
            this.lblHorario_dia.Text = "Dia:";
            // 
            // lblHorario_HoraInicio
            // 
            this.lblHorario_HoraInicio.AutoSize = true;
            this.lblHorario_HoraInicio.Location = new System.Drawing.Point(33, 177);
            this.lblHorario_HoraInicio.Name = "lblHorario_HoraInicio";
            this.lblHorario_HoraInicio.Size = new System.Drawing.Size(79, 17);
            this.lblHorario_HoraInicio.TabIndex = 2;
            this.lblHorario_HoraInicio.Text = "Hora inicio:";
            // 
            // lblHorario_Horalinal
            // 
            this.lblHorario_Horalinal.AutoSize = true;
            this.lblHorario_Horalinal.Location = new System.Drawing.Point(6, 220);
            this.lblHorario_Horalinal.Name = "lblHorario_Horalinal";
            this.lblHorario_Horalinal.Size = new System.Drawing.Size(121, 17);
            this.lblHorario_Horalinal.TabIndex = 3;
            this.lblHorario_Horalinal.Text = "Hora Finalizacion:";
            // 
            // txtHorario_Descripccion
            // 
            this.txtHorario_Descripccion.Location = new System.Drawing.Point(136, 86);
            this.txtHorario_Descripccion.Name = "txtHorario_Descripccion";
            this.txtHorario_Descripccion.Size = new System.Drawing.Size(186, 22);
            this.txtHorario_Descripccion.TabIndex = 5;
            // 
            // txtHorario_Dia
            // 
            this.txtHorario_Dia.Location = new System.Drawing.Point(118, 136);
            this.txtHorario_Dia.Name = "txtHorario_Dia";
            this.txtHorario_Dia.Size = new System.Drawing.Size(204, 22);
            this.txtHorario_Dia.TabIndex = 6;
            // 
            // txtHorario_HoraInicio
            // 
            this.txtHorario_HoraInicio.Location = new System.Drawing.Point(118, 177);
            this.txtHorario_HoraInicio.Name = "txtHorario_HoraInicio";
            this.txtHorario_HoraInicio.Size = new System.Drawing.Size(204, 22);
            this.txtHorario_HoraInicio.TabIndex = 7;
            // 
            // txtHorario_horaFinalizacion
            // 
            this.txtHorario_horaFinalizacion.Location = new System.Drawing.Point(136, 220);
            this.txtHorario_horaFinalizacion.Name = "txtHorario_horaFinalizacion";
            this.txtHorario_horaFinalizacion.Size = new System.Drawing.Size(186, 22);
            this.txtHorario_horaFinalizacion.TabIndex = 8;
            // 
            // cbxHorario
            // 
            this.cbxHorario.FormattingEnabled = true;
            this.cbxHorario.Location = new System.Drawing.Point(127, 400);
            this.cbxHorario.Name = "cbxHorario";
            this.cbxHorario.Size = new System.Drawing.Size(121, 24);
            this.cbxHorario.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Filtro:";
            // 
            // btnHorario_CargarDatos
            // 
            this.btnHorario_CargarDatos.Location = new System.Drawing.Point(310, 400);
            this.btnHorario_CargarDatos.Name = "btnHorario_CargarDatos";
            this.btnHorario_CargarDatos.Size = new System.Drawing.Size(106, 29);
            this.btnHorario_CargarDatos.TabIndex = 12;
            this.btnHorario_CargarDatos.Text = "Cargar Datos";
            this.btnHorario_CargarDatos.UseVisualStyleBackColor = true;
            this.btnHorario_CargarDatos.Click += new System.EventHandler(this.btnHorario_CargarDatos_Click);
            // 
            // btnHorario_insertar
            // 
            this.btnHorario_insertar.Location = new System.Drawing.Point(36, 315);
            this.btnHorario_insertar.Name = "btnHorario_insertar";
            this.btnHorario_insertar.Size = new System.Drawing.Size(132, 23);
            this.btnHorario_insertar.TabIndex = 13;
            this.btnHorario_insertar.Text = "Insertar Horario";
            this.btnHorario_insertar.UseVisualStyleBackColor = true;
            this.btnHorario_insertar.Click += new System.EventHandler(this.btnHorario_insertar_Click);
            // 
            // btnHorario_modificar
            // 
            this.btnHorario_modificar.Location = new System.Drawing.Point(209, 315);
            this.btnHorario_modificar.Name = "btnHorario_modificar";
            this.btnHorario_modificar.Size = new System.Drawing.Size(147, 23);
            this.btnHorario_modificar.TabIndex = 14;
            this.btnHorario_modificar.Text = "Modificar Horario";
            this.btnHorario_modificar.UseVisualStyleBackColor = true;
            this.btnHorario_modificar.Click += new System.EventHandler(this.btnHorario_modificar_Click);
            // 
            // dgvHorario
            // 
            this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorario.Location = new System.Drawing.Point(379, 35);
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.RowHeadersWidth = 51;
            this.dgvHorario.RowTemplate.Height = 24;
            this.dgvHorario.Size = new System.Drawing.Size(680, 344);
            this.dgvHorario.TabIndex = 15;
            this.dgvHorario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorario_CellContentClick);
            // 
            // frmHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 555);
            this.Controls.Add(this.dgvHorario);
            this.Controls.Add(this.btnHorario_modificar);
            this.Controls.Add(this.btnHorario_insertar);
            this.Controls.Add(this.btnHorario_CargarDatos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxHorario);
            this.Controls.Add(this.txtHorario_horaFinalizacion);
            this.Controls.Add(this.txtHorario_HoraInicio);
            this.Controls.Add(this.txtHorario_Dia);
            this.Controls.Add(this.txtHorario_Descripccion);
            this.Controls.Add(this.lblHorario_Horalinal);
            this.Controls.Add(this.lblHorario_HoraInicio);
            this.Controls.Add(this.lblHorario_dia);
            this.Controls.Add(this.lblHorario_descripcion);
            this.Name = "frmHorario";
            this.Text = "Registro de maticula :: Modulo Horario";
            this.Load += new System.EventHandler(this.frmHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorario_descripcion;
        private System.Windows.Forms.Label lblHorario_dia;
        private System.Windows.Forms.Label lblHorario_HoraInicio;
        private System.Windows.Forms.Label lblHorario_Horalinal;
        private System.Windows.Forms.TextBox txtHorario_Descripccion;
        private System.Windows.Forms.TextBox txtHorario_Dia;
        private System.Windows.Forms.TextBox txtHorario_HoraInicio;
        private System.Windows.Forms.TextBox txtHorario_horaFinalizacion;
        private System.Windows.Forms.ComboBox cbxHorario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHorario_CargarDatos;
        private System.Windows.Forms.Button btnHorario_insertar;
        private System.Windows.Forms.Button btnHorario_modificar;
        private System.Windows.Forms.DataGridView dgvHorario;
    }
}