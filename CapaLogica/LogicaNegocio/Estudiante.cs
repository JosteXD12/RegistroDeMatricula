using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resgistro_de_Matricula.CapaLogica.LogicaNegocio
{
    public class Estudiante
    {
        #region ATRIBUTOS 

        private int estudiante_id;
        private int grupo_id;
        private string estudiante_cedula;
        private string estudiante_nombre;
        private string estudiante_primerApellido;
        private string estudiante_segundoApellido;
        private string estudiante_Telefono;
        private string estudiante_correoElectronico;
        private string estudiante_direccion;
        private string estudiante_estado;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        public Estudiante()
        {
        }
        /// <summary>
        /// insertar
        /// </summary>
        /// <param name="pgrupo_id"></param>
        /// <param name="Pestudiante_cedula"></param>
        /// <param name="Pestudiante_nombre"></param>
        /// <param name="Pestudiante_primerApellido"></param>
        /// <param name="Pestudiante_segundoApellido"></param>
        /// <param name="Pestudiante_Telefono"></param>
        /// <param name="Pestudiante_correoElectronico"></param>
        /// <param name="Pestudiante_direccion"></param>
        /// <param name="Pestudiante_estado"></param>
        public Estudiante(int pgrupo_id, string Pestudiante_cedula, string Pestudiante_nombre, string Pestudiante_primerApellido,
            string Pestudiante_segundoApellido, string Pestudiante_Telefono, string Pestudiante_correoElectronico, string Pestudiante_direccion,
            string Pestudiante_estado)
        {
            Estudiante_id = 0;
            Grupo_id = pgrupo_id;
            Estudiante_cedula = Pestudiante_cedula;
            Estudiante_nombre = Pestudiante_nombre;
            Estudiante_primerApellido = Pestudiante_primerApellido;
            Estudiante_segundoApellido = Pestudiante_segundoApellido;
            Estudiante_Telefono = Pestudiante_Telefono;
            Estudiante_correoElectronico = Pestudiante_correoElectronico;
            Estudiante_direccion = Pestudiante_direccion;
            Estudiante_estado = Pestudiante_estado;
        }
        /// <summary>
        /// modificar
        /// </summary>
        /// <param name="pgrupo_id"></param>
        /// <param name="Pestudainte_id"></param>
        /// <param name="Pestudiante_cedula"></param>
        /// <param name="Pestudiante_nombre"></param>
        /// <param name="Pestudiante_primerApellido"></param>
        /// <param name="Pestudiante_segundoApellido"></param>
        /// <param name="Pestudiante_Telefono"></param>
        /// <param name="Pestudiante_correoElectronico"></param>
        /// <param name="Pestudiante_direccion"></param>
        /// <param name="Pestudiante_estado"></param>

        public Estudiante(int Pestudainte_id, int pgrupo_id, string Pestudiante_cedula, string Pestudiante_nombre, string Pestudiante_primerApellido,
            string Pestudiante_segundoApellido, string Pestudiante_Telefono, string Pestudiante_correoElectronico, string Pestudiante_direccion,
            string Pestudiante_estado)
        {
            Estudiante_id = Pestudainte_id;
            Grupo_id = pgrupo_id;
            Estudiante_cedula = Pestudiante_cedula;
            Estudiante_nombre = Pestudiante_nombre;
            Estudiante_primerApellido = Pestudiante_primerApellido;
            Estudiante_segundoApellido = Pestudiante_segundoApellido;
            Estudiante_Telefono = Pestudiante_Telefono;
            Estudiante_correoElectronico = Pestudiante_correoElectronico;
            Estudiante_direccion = Pestudiante_direccion;
            Estudiante_estado = Pestudiante_estado;
        }

        #endregion CONSTRUCTORES

        #region GET's and SET's
       public int Estudiante_id { get => estudiante_id; set => estudiante_id = value; }
       public int Grupo_id { get => grupo_id; set => grupo_id = value; }
       public string Estudiante_cedula { get => estudiante_cedula; set => estudiante_cedula = value; }
       public string Estudiante_nombre { get => estudiante_nombre; set => estudiante_nombre = value; }
       public string Estudiante_primerApellido { get => estudiante_primerApellido; set => estudiante_primerApellido = value; }
       public string Estudiante_segundoApellido { get => estudiante_segundoApellido; set => estudiante_segundoApellido = value; }
       public string Estudiante_Telefono { get => estudiante_Telefono; set => estudiante_Telefono = value; }
       public string Estudiante_correoElectronico { get => estudiante_correoElectronico; set => estudiante_correoElectronico = value; }
       public string Estudiante_direccion { get => estudiante_direccion; set => estudiante_direccion = value; }
       public string Estudiante_estado { get => estudiante_estado; set => estudiante_estado = value; }

        #endregion GET's and SET's
    }
}
