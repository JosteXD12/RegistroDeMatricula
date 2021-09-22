using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resgistro_de_Matricula.CapaLogica.LogicaNegocio
{
    public class Horario
    {
        #region
        protected int horario_id;
        protected string horario_descripcion;
        protected string horario_dia;
        protected string horario_horaInicio;
        protected string horario_horaFin;
        protected string horario_estado;
        #endregion

        #region CONSTRUCTORES 

        public Horario()
        {
        }
        /// <summary>
        /// Manejo de procedimientos almacenados de Insertar Horario
        /// </summary>
        /// <param name="Phorario_descripcion"></param>
        /// <param name="Phorario_dia"></param>
        /// <param name="Phorario_horaInicio"></param>
        /// <param name="Phorario_horaFin"></param>
        /// <param name="Phorario_estado"></param>
        public Horario(string Phorario_descripcion, string Phorario_dia, string Phorario_horaInicio, string Phorario_horaFin,
            string Phorario_estado)
        {
            Horario_id = 0;
            Horario_descripcion = Phorario_descripcion;
            Horario_dia = Phorario_dia;
            Horario_horaInicio = Phorario_horaInicio;
            Horario_horaFin = Phorario_horaFin;
            Horario_estado = Phorario_estado;
        }
        /// <summary>
        /// Manejo de procedimientos almacenados de Modificar Horario
        /// </summary>
        /// <param name="Phorario_id"></param>
        /// <param name="Phorario_descripcion"></param>
        /// <param name="Phorario_dia"></param>
        /// <param name="Phorario_horaInicio"></param>
        /// <param name="Phorario_horaFin"></param>
        /// <param name="Phorario_estado"></param>
        public Horario(int Phorario_id, string Phorario_descripcion, string Phorario_dia, string Phorario_horaInicio, string Phorario_horaFin,
           string Phorario_estado)
        {
            Horario_id = Phorario_id;
            Horario_descripcion = Phorario_descripcion;
            Horario_dia = Phorario_dia;
            Horario_horaInicio = Phorario_horaInicio;
            Horario_horaFin = Phorario_horaFin;
            Horario_estado = Phorario_estado;
        }
        #endregion CONSTRUCTORES 

        #region GET's and SET's
        public int Horario_id { get => horario_id; set => horario_id = value; }
        public string Horario_descripcion { get => horario_descripcion; set => horario_descripcion = value; }
        public string Horario_dia { get => horario_dia; set => horario_dia = value; }
        public string Horario_horaInicio { get => horario_horaInicio; set => horario_horaInicio = value; }
        public string Horario_horaFin { get => horario_horaFin; set => horario_horaFin = value; }
        public string Horario_estado { get => horario_estado; set => horario_estado = value; }
        
        #endregion GET's and SET's
    }
}
