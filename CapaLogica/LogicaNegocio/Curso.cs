﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resgistro_de_Matricula.CapaLogica.LogicaNegocio
{
    public class Curso
    {
        #region ATRIBUTO

        protected int curso_id;
        protected string curso_nombre;
        protected string curso_creditos;
        protected string curso_cupo;
        protected string curso_estado;
       
        #endregion ATRIBUTO

        #region CONSTRUCTORES
        public Curso()
        {

        }
        /// <summary>
        /// Manejo de procedimientos almacenados de Insertar Curso
        /// </summary>
        /// <param name="Pcurso_nombre"></param>
        /// <param name="Pcurso_creditos"></param>
        /// <param name="Pcurso_cupo"></param>
        /// <param name="Pcurso_estado"></param>
        public Curso(string Pcurso_nombre,string Pcurso_creditos, string Pcurso_cupo, string Pcurso_estado)
        {
            Curso_id = 0;
            Curso_nombre = Pcurso_nombre;
            Curso_creditos = Pcurso_creditos;
            Curso_cupo = Pcurso_cupo;
            Curso_estado = Pcurso_estado;
        }
        /// <summary>
        /// Manejo de procedimientos almacenados de Modificar Curso
        /// </summary>
        /// <param name="Pcurso_nombre"></param>
        /// <param name="Pcurso_creditos"></param>
        /// <param name="Pcurso_cupo"></param>
        /// <param name="Pcurso_estado"></param>
        public Curso(int Pcurso_id, string Pcurso_nombre, string Pcurso_creditos, string Pcurso_cupo, string Pcurso_estado)
        {
            Curso_id = Pcurso_id;
            Curso_nombre = Pcurso_nombre;
            Curso_creditos = Pcurso_creditos;
            Curso_cupo = Pcurso_cupo;
            Curso_estado = Pcurso_estado;
        }

        #endregion CONSTRUCTORES

        #region GET's and SET's
        public int Curso_id { get => curso_id; set => curso_id = value; }
        public string Curso_nombre { get => curso_nombre; set => curso_nombre = value; }
        public string Curso_creditos { get => curso_creditos; set => curso_creditos = value; }
        public string Curso_cupo { get => curso_cupo; set => curso_cupo = value; }
        public string Curso_estado { get => curso_estado; set => curso_estado = value; }
        #endregion GET's and SET's

    }
}
