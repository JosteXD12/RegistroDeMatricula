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
    public class GestorHorario : servicio, IDisposable
    {
        public GestorHorario()
        {

        }
        public void Dispose()
        {

        }
        public string InsertarHorario(string Horario_descripcion, string Horario_dia, string Horario_horaInicio,
           string Horario_horaFin, string Horario_estado)
        {
            Horario newHorario = new Horario(Horario_descripcion, Horario_dia, Horario_horaInicio,
                Horario_horaFin, Horario_estado);

            using (ServicioHorario elHorario = new ServicioHorario())
                return elHorario.InsertarHorario(newHorario);
        }
        public string ModificarHorario(int Horario_id,string Horario_descripcion, string Horario_dia, string Horario_horaInicio,
           string Horario_horaFin, string Horario_estado)
        {
            Horario newHorario = new Horario(Horario_id, Horario_descripcion, Horario_dia, Horario_horaInicio,
                Horario_horaFin, Horario_estado);

            using (ServicioHorario elHorario = new ServicioHorario())
                return elHorario.ModificarHorario(newHorario);
        }
        public DataSet ConsultarHorario(int Horario_id)
        {

            using (ServicioHorario elHorario = new ServicioHorario())
                return elHorario.ConsultarHorario(Horario_id);
        }
        public DataSet ActivarHorario(int Horario_id)
        {

            using (ServicioHorario elHorario = new ServicioHorario())
                return elHorario.ActivarHorario(Horario_id);
        }

        public DataTable ListarHorario()
        {

            using (ServicioHorario elHorario = new ServicioHorario())
                return elHorario.ListarHorario();
        }
        public DataTable ListarInactivoHorario()
        {

            using (ServicioHorario elHorario = new ServicioHorario())
                return elHorario.ListarInactivoHorario();
        }
        public string eliminarHorario(int Horario_id)
        {
            using (ServicioHorario elHorario = new ServicioHorario())
                return elHorario.eliminarHorario(Horario_id);
        }

        public string inactivarHorario(int Horario_id)
        {
            using (ServicioHorario elHorario = new ServicioHorario())
                return elHorario.inactivarHorario(Horario_id);
        }
    }
}
