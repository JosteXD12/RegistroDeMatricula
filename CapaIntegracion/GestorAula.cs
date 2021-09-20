using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resgistro_de_Matricula.CapaLogica.LogicaNegocio;
using Resgistro_de_Matricula.CapaLogica.Servicios;
using Resgistro_de_Matricula.CapaConexion;
using System.Data;

namespace Resgistro_de_Matricula.CapaIntegracion
{
    public class GestorAula : servicio, IDisposable
    {
        public GestorAula()
        {

        }
        public void Dispose()
        {

        }
        public string InsertarAula(string Aula_descripcion, string Aula_capacidad, string Aula_estado)
        {
            Aula newAula = new Aula(Aula_descripcion, Aula_capacidad, Aula_estado);

            using (ServicioAula elAula = new ServicioAula())
                return elAula.insertarAula(newAula);
        }
        public string ModificarAula(int Aula_id,string Aula_descripcion, string Aula_capacidad, string Aula_estado)
        {
            Aula newAula = new Aula(Aula_id, Aula_descripcion, Aula_capacidad, Aula_estado);

            using (ServicioAula elAula = new ServicioAula())
                return elAula.ModificarAula(newAula);
        }
        public DataSet consultarAula(int Aula_Id)
        {

            using (ServicioAula laAula = new ServicioAula())
                return laAula.consultarAula(Aula_Id);
        }

        public DataTable ListarAula()
        {

            using (ServicioAula laAula = new ServicioAula())
                return laAula.ListarAula();
        }
        public string eliminarAula(int Aula_Id)
        {
            using (ServicioAula laAula = new ServicioAula())
                return laAula.eliminarAula(Aula_Id);
        }

        public string inactivarAula(int Aula_Id)
        {
            using (ServicioAula laAula = new ServicioAula())
                return laAula.inactivarAula(Aula_Id);
        }

    }
}
