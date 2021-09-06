using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resgistro_de_Matricula.CapaLogica.LogicaNegocio
{
    public class Aula
    {
        #region ATRIBUTOS; 
        protected int aula_id;
        protected string aula_descripcion;
        protected string aula_capacidad;
        protected string aula_estado;
        #endregion ATRIBUTOS 
        public Aula()
        {
        }
        /// <summary> 
        /// Manejo procedimiento almacenado de Insertar Aula 
        /// </summary> 
        /// <param name="aAula_descripcion"></param> 
        /// <param name="aAula_capacidad"></param> 
        /// <param name="aAula_estado"></param> 
        public Aula(String aAula_descripcion, String aAula_capacidad, String aAula_estado)
        {
            aula_id = 0;
            aula_descripcion = aAula_descripcion;
            aula_capacidad = aAula_capacidad;
            aula_estado = aAula_estado;
        }
        /// <summary> 
        /// Manejo procedimiento almacenado de Modificar Aula 
        /// </summary> 
        /// <param name="aAula_id"></param> 
        /// <param name="aAula_descripcion"></param> 
        /// <param name="aAula_capacidad"></param> 
        /// <param name="aAula_estado"></param> 
        public Aula(int aAula_id, String aAula_descripcion, String aAula_capacidad, String aAula_estado)
        {
            aula_id = aAula_id;
            aula_descripcion = aAula_descripcion;
            aula_capacidad = aAula_capacidad;
            aula_estado = aAula_estado;
        }

        #region GET's and SET's 

        public int Aula_id { get => aula_id; set => aula_id = value; }
        public string Aula_descripcion { get => aula_descripcion; set => aula_descripcion = value; }
        public string Aula_capacidad { get => aula_capacidad; set => aula_capacidad = value; }
        public string Aula_estado { get => aula_estado; set => aula_estado = value; }

        #endregion GET's and SET's

    }
}
