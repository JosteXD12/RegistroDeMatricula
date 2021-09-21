
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaIntegracion;
using Resgistro_de_Matricula.CapaIntegracion;

namespace CapaPresentacion
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }
        
        private void login()
        {
            using (GestorUsuario elUsuario = new GestorUsuario())
            {
                DataSet laData = elUsuario.Login(txtUsuario.Text, txtContraseña.Text);
                DataTable datatable = laData.Tables[0];
                if(datatable.Rows.Count > 0)
                {
                    Principal menu = new Principal(datatable);
                    menu.ShowDialog();
                    
                }
                else 
                {
                 MessageBox.Show(" El usuario o la contraseña es incorrecto");
                }
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
           // Verificacion_espacios();
            login();
        }
        //private void Verificacion_espacios()
        //{
        //    if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContraseña.Text))
        //    {
        //        MessageBox.Show("Alguno de los campos requeridos para iniciar sesion esta vacio");
        //    }
        //}

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                login();
            }
        }
    }
}
