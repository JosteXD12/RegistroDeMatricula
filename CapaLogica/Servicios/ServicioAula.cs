using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Resgistro_de_Matricula.CapaConexion;
using Resgistro_de_Matricula.CapaLogica.LogicaNegocio;


namespace Resgistro_de_Matricula.CapaLogica.Servicios
{
    public class ServicioAula : servicio, IDisposable
    {
        private SqlCommand miComando;
        private String respuesta;
        public void Dispose()
        {

        }

        public ServicioAula()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }
        public String insertarAula(Aula laAula)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Aula");
            miComando.CommandText = "InsertarAula";

            miComando.Parameters.Add("Aula_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Aula_descripcion"].Value = laAula.Aula_descripcion;

            miComando.Parameters.Add("Aula_capacidad", SqlDbType.VarChar);
            miComando.Parameters["Aula_capacidad"].Value = laAula.Aula_capacidad;

            miComando.Parameters.Add("Aula_estado", SqlDbType.VarChar);
            miComando.Parameters["Aula_estado"].Value = laAula.Aula_estado;
            
            respuesta = this.ejecutarsentencia(miComando);
            if (respuesta == "")
            {
                respuesta += "Se ha realizado correctamente";
            }
            Console.WriteLine("Fin Servicio Insertar Aula");
            return respuesta;
        }
        public String ModificarAula(Aula laAula)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Aula");
            miComando.CommandText = "ModificarAula";

            miComando.Parameters.Add("Aula_id", SqlDbType.Int);
            miComando.Parameters["Aula_id"].Value = laAula.Aula_id;

            miComando.Parameters.Add("Aula_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Aula_descripcion"].Value = laAula.Aula_descripcion;

            miComando.Parameters.Add("Aula_capacidad", SqlDbType.VarChar);
            miComando.Parameters["Aula_capacidad"].Value = laAula.Aula_capacidad;

            miComando.Parameters.Add("Aula_estado", SqlDbType.VarChar);
            miComando.Parameters["Aula_estado"].Value = laAula.Aula_estado;
           
            respuesta = this.ejecutarsentencia(miComando);
            if (respuesta == "")
            {
                respuesta += "Se ha realizado correctamente";
            }
            Console.WriteLine("Fin Servicio Modificar Aula");
            return respuesta;
        }
        public DataSet consultarAula(int Aula_Id)
        {
            miComando.CommandText = "ConsultarAula";
            miComando.Parameters.AddWithValue(@"Aula_Id", SqlDbType.Int);
            miComando.Parameters["Aula_Id"].Value = Aula_Id;

            DataSet miDataSet = new DataSet();
            this.abrirconexion();
            miDataSet = this.SeleccinarInformacion(miComando);
            this.cerrarconexion();
            return miDataSet;
        }
        public DataTable ListarAula()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Aula");
            miComando.CommandText = "ListarAula";

            DataSet laAula = new DataSet();
            this.abrirconexion();
            laAula = this.SeleccinarInformacion(miComando);
            DataTable miTabla = laAula.Tables[0];

            return miTabla;

        }
        public string inactivarAula(int Aula_Id)
        {
            miComando.CommandText = "InactivarAula";
            miComando.Parameters.AddWithValue("@Aula_id", SqlDbType.Int);
            miComando.Parameters["@Aula_id"].Value = Aula_Id;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción inactivar Aula";

            Console.WriteLine("Fin servicio InactivararAula");

            return respuesta;
        }
        public string eliminarAula(int Aula_Id)
        {
            miComando.CommandText = "EliminarAula";
            miComando.Parameters.AddWithValue("@Aula_id", SqlDbType.Int);
            miComando.Parameters["@Aula_id"].Value = Aula_Id;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción Eliminar Aula";

            Console.WriteLine("Fin servicio EliminarAula");

            return respuesta;
        }
    }
}
