using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resgistro_de_Matricula.CapaLogica.LogicaNegocio
{
    public class Grupo
    {
        #region ATRIBUTOS

        protected int grupo_id;
        protected string grupo_descripcion;
        protected string grupo_estado;

        #endregion ATRIBUTOS

        #region CONSTRUCTORES

        public Grupo()
        {
        }
        /// <summary>
        /// Manejo de procedimientos almacenados de Insertar Grupo
        /// </summary>
        /// <param name="Pgrupo_descripcion"></param>
        /// <param name="Pgrupo_estado"></param>
        public Grupo(string Pgrupo_descripcion, string Pgrupo_estado)
        {
            Grupo_id = 0;
            Grupo_descripcion = Pgrupo_descripcion;
            Grupo_estado = Pgrupo_estado;
        }
        /// <summary>
        /// Manejo de procedimientos almacenados de Modificar Grupo
        /// </summary>
        /// <param name="Pgrupo_id"></param>
        /// <param name="Pgrupo_descripcion"></param>
        /// <param name="Pgrupo_estado"></param>
        public Grupo(int Pgrupo_id, string Pgrupo_descripcion, string Pgrupo_estado)
        {
            Grupo_id = grupo_id;
            Grupo_descripcion = Pgrupo_descripcion;
            Grupo_estado = Pgrupo_estado;
        }


        #endregion CONSTRUCTORES

        #region GET's and SET's

        public int Grupo_id { get => grupo_id; set => grupo_id = value; }
        public string Grupo_descripcion { get => grupo_descripcion; set => grupo_descripcion = value; }
        public string Grupo_estado { get => grupo_estado; set => grupo_estado = value; }
        
        #endregion GET's and SET's
    }
}
