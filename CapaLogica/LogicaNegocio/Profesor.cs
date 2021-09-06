using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resgistro_de_Matricula.CapaLogica.LogicaNegocio
{
    public class Profesor
    {
        #region ATRIBUTOS 
        protected int profesor_id;
        protected string profesor_cedula;
        protected string profesor_nombre;
        protected string profesor_primerApellido;
        protected string profesor_segundoApellido;
        protected string profesor_Telefono;
        protected string profesor_correoElectronico;
        protected string profesor_direccion;
        protected string profesor_estado;
        #endregion

        #region CONSTRUCTORES
        public Profesor()
        {
        }
     /// <summary>
     /// Manejo de procedimientos almacenados de insertar profesor
     /// </summary>
     /// <param name="Pprofesor_cedula"></param>
     /// <param name="Pprofesor_nombre"></param>
     /// <param name="Pprofesor_primerApellido"></param>
     /// <param name="Pprofesor_segundoApellido"></param>
     /// <param name="Pprofesor_Telefono"></param>
     /// <param name="Pprofesor_correoElectronico"></param>
     /// <param name="Pprofesor_direccion"></param>
     /// <param name="Pprofesor_estado"></param>
        public Profesor(string Pprofesor_cedula, string Pprofesor_nombre, string Pprofesor_primerApellido,
            string Pprofesor_segundoApellido, string Pprofesor_Telefono, string Pprofesor_correoElectronico, string Pprofesor_direccion,
            string Pprofesor_estado)
        {
            Profesor_id =0;
            profesor_cedula = Pprofesor_cedula;
            profesor_nombre = Pprofesor_nombre;
            profesor_primerApellido = Pprofesor_primerApellido;
            profesor_segundoApellido = Pprofesor_segundoApellido;
            profesor_Telefono = Pprofesor_Telefono;  
            profesor_correoElectronico = Pprofesor_correoElectronico;
            profesor_direccion = Pprofesor_direccion;
            Profesor_estado = Pprofesor_estado;
        }

        /// <summary>
        /// Manejo de procedimientos almacenados de Modificar profesor
        /// </summary>
        /// <param name="Pprofesor_id"></param>
        /// <param name="Pprofesor_cedula"></param>
        /// <param name="Pprofesor_nombre"></param>
        /// <param name="Pprofesor_primerApellido"></param>
        /// <param name="Pprofesor_segundoApellido"></param>
        /// <param name="Pprofesor_Telefono"></param>
        /// <param name="Pprofesor_correoElectronico"></param>
        /// <param name="Pprofesor_direccion"></param>
        /// <param name="Pprofesor_estado"></param>
        public Profesor(int Pprofesor_id, string Pprofesor_cedula, string Pprofesor_nombre, string Pprofesor_primerApellido,
            string Pprofesor_segundoApellido, string Pprofesor_Telefono, string Pprofesor_correoElectronico, string Pprofesor_direccion,
            string Pprofesor_estado)
        {
            Profesor_id = Pprofesor_id;
            profesor_cedula = Pprofesor_cedula;
            profesor_nombre = Pprofesor_nombre;
            profesor_primerApellido = Pprofesor_primerApellido;
            profesor_segundoApellido = Pprofesor_segundoApellido;
            profesor_Telefono = Pprofesor_Telefono;
            profesor_correoElectronico = Pprofesor_correoElectronico;
            profesor_direccion = Pprofesor_direccion;
            profesor_estado = Pprofesor_estado;
        }

        #endregion CONSTRUCTORES

        #region GET's and SET's
        public int Profesor_id { get => profesor_id; set => profesor_id = value; }
        public string Profesor_cedula { get => profesor_cedula; set => profesor_cedula = value; }
        public string Profesor_nombre { get => profesor_nombre; set => profesor_nombre = value; }
        public string Profesor_primerApellido { get => profesor_primerApellido; set => profesor_primerApellido = value; }
        public string Profesor_segundoApellido { get => profesor_segundoApellido; set => profesor_segundoApellido = value; }
        public string Profesor_Telefono { get => profesor_Telefono; set => profesor_Telefono = value; }
        public string Profesor_correoElectronico { get => profesor_correoElectronico; set => profesor_correoElectronico = value; }
        public string Profesor_direccion { get => profesor_direccion; set => profesor_direccion = value; }
        public string Profesor_estado { get => profesor_estado; set => profesor_estado = value; }
        #endregion GET's and SET's


    }
}
