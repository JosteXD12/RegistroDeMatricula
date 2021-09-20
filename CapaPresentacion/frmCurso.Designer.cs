
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
            this.btnCurso_CargarDatos = new System.Windows.Forms.Button();
            this.lblCurso_CargarDatos = new System.Windows.Forms.Label();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.btnCurso_Modificar = new System.Windows.Forms.Button();
            this.btnCurso_insertar = new System.Windows.Forms.Button();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.txtCurso_Cupos = new System.Windows.Forms.TextBox();
            this.txtCurso_Creditos = new System.Windows.Forms.TextBox();
            this.txtCurso_Nombre = new System.Windows.Forms.TextBox();
            this.lblCurso_Cupos = new System.Windows.Forms.Label();
            this.lblCurso_Credito = new System.Windows.Forms.Label();
            this.lblCurso_nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCurso_CargarDatos
            // 
            this.btnCurso_CargarDatos.Location = new System.Drawing.Point(293, 491);
            this.btnCurso_CargarDatos.Name = "btnCurso_CargarDatos";
            this.btnCurso_CargarDatos.Size = new System.Drawing.Size(99, 23);
            this.btnCurso_CargarDatos.TabIndex = 41;
            this.btnCurso_CargarDatos.Text = "Cargar datos";
            this.btnCurso_CargarDatos.UseVisualStyleBackColor = true;
            this.btnCurso_CargarDatos.Click += new System.EventHandler(this.btnCurso_CargarDatos_Click);
            // 
            // lblCurso_CargarDatos
            // 
            this.lblCurso_CargarDatos.AutoSize = true;
            this.lblCurso_CargarDatos.Location = new System.Drawing.Point(58, 490);
            this.lblCurso_CargarDatos.Name = "lblCurso_CargarDatos";
            this.lblCurso_CargarDatos.Size = new System.Drawing.Size(43, 17);
            this.lblCurso_CargarDatos.TabIndex = 40;
            this.lblCurso_CargarDatos.Text = "Filtro:";
            // 
            // cbxCurso
            // 
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Location = new System.Drawing.Point(107, 490);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(162, 24);
            this.cbxCurso.TabIndex = 39;
            // 
            // btnCurso_Modificar
            // 
            this.btnCurso_Modificar.Location = new System.Drawing.Point(227, 373);
            this.btnCurso_Modificar.Name = "btnCurso_Modificar";
            this.btnCurso_Modificar.Size = new System.Drawing.Size(153, 23);
            this.btnCurso_Modificar.TabIndex = 38;
            this.btnCurso_Modificar.Text = "Modificar Modificar";
            this.btnCurso_Modificar.UseVisualStyleBackColor = true;
            this.btnCurso_Modificar.Click += new System.EventHandler(this.btnCurso_Modificar_Click);
            // 
            // btnCurso_insertar
            // 
            this.btnCurso_insertar.Location = new System.Drawing.Point(42, 373);
            this.btnCurso_insertar.Name = "btnCurso_insertar";
            this.btnCurso_insertar.Size = new System.Drawing.Size(152, 23);
            this.btnCurso_insertar.TabIndex = 37;
            this.btnCurso_insertar.Text = "Insertar Curso";
            this.btnCurso_insertar.UseVisualStyleBackColor = true;
            this.btnCurso_insertar.Click += new System.EventHandler(this.btnCurso_insertar_Click);
            // 
            // dgvCurso
            // 
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Location = new System.Drawing.Point(426, 79);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.RowHeadersWidth = 51;
            this.dgvCurso.RowTemplate.Height = 24;
            this.dgvCurso.Size = new System.Drawing.Size(666, 276);
            this.dgvCurso.TabIndex = 36;
            this.dgvCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurso_CellContentClick);
            // 
            // txtCurso_Cupos
            // 
            this.txtCurso_Cupos.Location = new System.Drawing.Point(162, 169);
            this.txtCurso_Cupos.Name = "txtCurso_Cupos";
            this.txtCurso_Cupos.Size = new System.Drawing.Size(230, 22);
            this.txtCurso_Cupos.TabIndex = 31;
            // 
            // txtCurso_Creditos
            // 
            this.txtCurso_Creditos.Location = new System.Drawing.Point(152, 131);
            this.txtCurso_Creditos.Name = "txtCurso_Creditos";
            this.txtCurso_Creditos.Size = new System.Drawing.Size(240, 22);
            this.txtCurso_Creditos.TabIndex = 30;
            // 
            // txtCurso_Nombre
            // 
            this.txtCurso_Nombre.Location = new System.Drawing.Point(107, 79);
            this.txtCurso_Nombre.Name = "txtCurso_Nombre";
            this.txtCurso_Nombre.Size = new System.Drawing.Size(285, 22);
            this.txtCurso_Nombre.TabIndex = 29;
            // 
            // lblCurso_Cupos
            // 
            this.lblCurso_Cupos.AutoSize = true;
            this.lblCurso_Cupos.Location = new System.Drawing.Point(39, 174);
            this.lblCurso_Cupos.Name = "lblCurso_Cupos";
            this.lblCurso_Cupos.Size = new System.Drawing.Size(128, 17);
            this.lblCurso_Cupos.TabIndex = 25;
            this.lblCurso_Cupos.Text = "Numero de cupos :";
            // 
            // lblCurso_Credito
            // 
            this.lblCurso_Credito.AutoSize = true;
            this.lblCurso_Credito.Location = new System.Drawing.Point(39, 131);
            this.lblCurso_Credito.Name = "lblCurso_Credito";
            this.lblCurso_Credito.Size = new System.Drawing.Size(118, 17);
            this.lblCurso_Credito.TabIndex = 24;
            this.lblCurso_Credito.Text = "Numero Creditos:";
            // 
            // lblCurso_nombre
            // 
            this.lblCurso_nombre.AutoSize = true;
            this.lblCurso_nombre.Location = new System.Drawing.Point(39, 82);
            this.lblCurso_nombre.Name = "lblCurso_nombre";
            this.lblCurso_nombre.Size = new System.Drawing.Size(62, 17);
            this.lblCurso_nombre.TabIndex = 23;
            this.lblCurso_nombre.Text = "Nombre:";
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1156, 592);
            this.Controls.Add(this.btnCurso_CargarDatos);
            this.Controls.Add(this.lblCurso_CargarDatos);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.btnCurso_Modificar);
            this.Controls.Add(this.btnCurso_insertar);
            this.Controls.Add(this.dgvCurso);
            this.Controls.Add(this.txtCurso_Cupos);
            this.Controls.Add(this.txtCurso_Creditos);
            this.Controls.Add(this.txtCurso_Nombre);
            this.Controls.Add(this.lblCurso_Cupos);
            this.Controls.Add(this.lblCurso_Credito);
            this.Controls.Add(this.lblCurso_nombre);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmCurso";
            this.Text = "Registro de maticula :: Modulo Curso";
            this.Load += new System.EventHandler(this.frmCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
    }
}