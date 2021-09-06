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
    public class ServicioMatricula : servicio, IDisposable
    {
        private SqlCommand miComando;
        private String respuesta;
        public void Dispose()
        {

        }
        public ServicioMatricula()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }
        public String InsertarMatricula(Matricula laMatricula)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Matricula");
            miComando.CommandText = "InsertarMatricula";

            miComando.Parameters.Add("Estudiante_id", SqlDbType.Int);
            miComando.Parameters["Estudiante_id"].Value = laMatricula.Estudiante_id;

            miComando.Parameters.Add("Grupo_id", SqlDbType.Int);
            miComando.Parameters["Grupo_id"].Value = laMatricula.Grupo_id;

            miComando.Parameters.Add("Curso_id", SqlDbType.Int);
            miComando.Parameters["Curso_id"].Value = laMatricula.Curso_id;

            miComando.Parameters.Add("Profesor_id", SqlDbType.Int);
            miComando.Parameters["Profesor_id"].Value = laMatricula.Profesor_id;

            miComando.Parameters.Add("Horario_id", SqlDbType.Int);
            miComando.Parameters["Horario_id"].Value = laMatricula.Horario_id;

            miComando.Parameters.Add("Aula_id", SqlDbType.Int);
            miComando.Parameters["Aula_id"].Value = laMatricula.Aula_id;

            miComando.Parameters.Add("Matricula_comprobante", SqlDbType.Int);
            miComando.Parameters["Matricula_comprobante"].Value = laMatricula.Matricula_comprobante;

            miComando.Parameters.Add("Matricula_estado", SqlDbType.Int);
            miComando.Parameters["Matricula_estado"].Value = laMatricula.Matricula_estado;

            respuesta = this.ejecutarsentencia(miComando);
            if (respuesta == "")
            {
                respuesta += "Se ha realizado correctamente";
            }
            Console.WriteLine("Fin Servicio Insertar Matricula");
            return respuesta;
        }
        public String ModificarMatricula(Matricula laMatricula)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Matricula");
            miComando.CommandText = "InsertarMatricula";

            miComando.Parameters.Add("Matricula_id", SqlDbType.Int);
            miComando.Parameters["Matricula_id"].Value = laMatricula.Matricula_id;

            miComando.Parameters.Add("Estudiante_id", SqlDbType.Int);
            miComando.Parameters["Estudiante_id"].Value = laMatricula.Estudiante_id;

            miComando.Parameters.Add("Grupo_id", SqlDbType.Int);
            miComando.Parameters["Grupo_id"].Value = laMatricula.Grupo_id;

            miComando.Parameters.Add("Curso_id", SqlDbType.Int);
            miComando.Parameters["Curso_id"].Value = laMatricula.Curso_id;

            miComando.Parameters.Add("Profesor_id", SqlDbType.Int);
            miComando.Parameters["Profesor_id"].Value = laMatricula.Profesor_id;

            miComando.Parameters.Add("Horario_id", SqlDbType.Int);
            miComando.Parameters["Horario_id"].Value = laMatricula.Horario_id;

            miComando.Parameters.Add("Aula_id", SqlDbType.Int);
            miComando.Parameters["Aula_id"].Value = laMatricula.Aula_id;

            miComando.Parameters.Add("Matricula_comprobante", SqlDbType.Int);
            miComando.Parameters["Matricula_comprobante"].Value = laMatricula.Matricula_comprobante;

            miComando.Parameters.Add("Matricula_estado", SqlDbType.Int);
            miComando.Parameters["Matricula_estado"].Value = laMatricula.Matricula_estado;

            respuesta = this.ejecutarsentencia(miComando);
            if (respuesta == "")
            {
                respuesta += "Se ha realizado correctamente";
            }
            Console.WriteLine("Fin Servicio Modificar Matricula");
            return respuesta;
        }
        public DataSet consultarMatricula(int Matricula_Id)
        {
            miComando.CommandText = "ConsultarMatricula";
            miComando.Parameters.AddWithValue(@"Matricula_Id", SqlDbType.Int);
            miComando.Parameters["Matricula_Id"].Value = Matricula_Id;

            DataSet miDataSet = new DataSet();
            this.abrirconexion();
            miDataSet = this.SeleccinarInformacion(miComando);

            this.cerrarconexion();
            return miDataSet;
        }
        public DataTable ListarMatricula()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Matricula");
            miComando.CommandText = "ListarMatricula";

            DataSet laMatricula = new DataSet();
            this.abrirconexion();
            laMatricula = this.SeleccinarInformacion(miComando);
            DataTable miTabla = laMatricula.Tables[0];

            return miTabla;

        }
        public string inactivarMatricula(int Matricula_Id)
        {
            miComando.CommandText = "InactivarMatricula";
            miComando.Parameters.AddWithValue("@Matricula_id", SqlDbType.Int);
            miComando.Parameters["@Matricula_id"].Value = Matricula_Id;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción inactivar Matricula";

            Console.WriteLine("Fin servicio InactivararMatricula");

            return respuesta;
        }
        public string eliminarMatricula(int Matricula_Id)
        {
            miComando.CommandText = "EliminarMatricula";
            miComando.Parameters.AddWithValue("@Matricula_id", SqlDbType.Int);
            miComando.Parameters["@Matricula_id"].Value = Matricula_Id;

            respuesta = this.ejecutarsentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción Eliminar Matricula";

            Console.WriteLine("Fin servicio EliminarMatricula");

            return respuesta;
        }
    }
}