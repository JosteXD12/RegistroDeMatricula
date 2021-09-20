
namespace CapaPresentacion
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aulaAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modulosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestorProfesorToolStripMenuItem,
            this.gestorToolStripMenuItem,
            this.gestorToolStripMenuItem1,
            this.gestorToolStripMenuItem2,
            this.gestorToolStripMenuItem3,
            this.gestorCursoToolStripMenuItem,
            this.aulaAulaToolStripMenuItem});
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.modulosToolStripMenuItem.Text = "Modulos";
            // 
            // gestorProfesorToolStripMenuItem
            // 
            this.gestorProfesorToolStripMenuItem.Name = "gestorProfesorToolStripMenuItem";
            this.gestorProfesorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gestorProfesorToolStripMenuItem.Text = "Gestor Profesor ";
            this.gestorProfesorToolStripMenuItem.Click += new System.EventHandler(this.gestorProfesorToolStripMenuItem_Click);
            // 
            // gestorToolStripMenuItem
            // 
            this.gestorToolStripMenuItem.Name = "gestorToolStripMenuItem";
            this.gestorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gestorToolStripMenuItem.Text = "Gestor Matricula";
            this.gestorToolStripMenuItem.Click += new System.EventHandler(this.gestorToolStripMenuItem_Click);
            // 
            // gestorToolStripMenuItem1
            // 
            this.gestorToolStripMenuItem1.Name = "gestorToolStripMenuItem1";
            this.gestorToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.gestorToolStripMenuItem1.Text = "Gestor Horario";
            this.gestorToolStripMenuItem1.Click += new System.EventHandler(this.gestorToolStripMenuItem1_Click);
            // 
            // gestorToolStripMenuItem2
            // 
            this.gestorToolStripMenuItem2.Name = "gestorToolStripMenuItem2";
            this.gestorToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.gestorToolStripMenuItem2.Text = "Gestor Grupo";
            this.gestorToolStripMenuItem2.Click += new System.EventHandler(this.gestorToolStripMenuItem2_Click);
            // 
            // gestorToolStripMenuItem3
            // 
            this.gestorToolStripMenuItem3.Name = "gestorToolStripMenuItem3";
            this.gestorToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.gestorToolStripMenuItem3.Text = "Gestor Estudiante";
            this.gestorToolStripMenuItem3.Click += new System.EventHandler(this.gestorToolStripMenuItem3_Click);
            // 
            // gestorCursoToolStripMenuItem
            // 
            this.gestorCursoToolStripMenuItem.Name = "gestorCursoToolStripMenuItem";
            this.gestorCursoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gestorCursoToolStripMenuItem.Text = "Gestor Curso";
            this.gestorCursoToolStripMenuItem.Click += new System.EventHandler(this.gestorCursoToolStripMenuItem_Click);
            // 
            // aulaAulaToolStripMenuItem
            // 
            this.aulaAulaToolStripMenuItem.Name = "aulaAulaToolStripMenuItem";
            this.aulaAulaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aulaAulaToolStripMenuItem.Text = "Aula Aula";
            this.aulaAulaToolStripMenuItem.Click += new System.EventHandler(this.aulaAulaToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 485);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Registro de maticula :: Modulo Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestorProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestorToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem gestorCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aulaAulaToolStripMenuItem;
    }
}