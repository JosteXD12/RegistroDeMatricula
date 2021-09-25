using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resgistro_de_Matricula.CapaConexion
{
    public class servicio
    {
        private SqlConnection conexion;

        public servicio()
        {
            conexion = new SqlConnection(@" server=(local); integrated security = true;
              DataBase = Registro_de_Matricula;connection timeout=30");
        }

        protected void abrirconexion()
        {
            conexion.Open();
        }

        protected void cerrarconexion()
        {
            conexion.Close();
        }

        protected string ejecutarsentencia(string sentencia)
        {
            SqlCommand Comando = new SqlCommand(sentencia, conexion);
            try
            {
                this.abrirconexion();
                Comando.ExecuteScalar();
            }
            catch (Exception error)
            {
                this.cerrarconexion();
                return error.Message;
            }

            this.cerrarconexion();
            return "";
        }
        protected string ejecutarsentencia(SqlCommand miComando)
        {
            miComando.Connection = conexion;
            miComando.CommandType = CommandType.StoredProcedure;
            miComando.CommandTimeout = 6000;

            try
            {
                this.abrirconexion(); 
                miComando.ExecuteScalar();
            }
            catch(SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
            }
            catch(Exception error)
            {
                this.cerrarconexion();
                return error.Message;
            }

           
            this.cerrarconexion();
            return "";
        }

        protected DataSet SeleccinarInformacion (string sentencia)
        {
            DataSet miDataSet = new DataSet();
            SqlCommand miSqlCommand = conexion.CreateCommand();
             
            miSqlCommand.CommandText = sentencia;
            SqlDataAdapter miSqlDataAdapter = new SqlDataAdapter();
            
            miSqlDataAdapter.SelectCommand = miSqlCommand;
            miSqlDataAdapter.Fill(miDataSet);

            return miDataSet; 
        }

        protected DataSet SeleccinarInformacion (SqlCommand miComando)
        {
            DataSet miDataSet = new DataSet();
            SqlDataAdapter miSqlDataAdapter = new SqlDataAdapter();

            miComando.CommandTimeout = 2000;    
            miComando.Connection = conexion;

            miComando.CommandType = CommandType.StoredProcedure;
            miSqlDataAdapter.SelectCommand = miComando;
            miSqlDataAdapter.Fill(miDataSet);

            return miDataSet;
        }

    }

}
