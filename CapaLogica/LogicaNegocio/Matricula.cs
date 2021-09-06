using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resgistro_de_Matricula.CapaLogica.LogicaNegocio
{
    public class Matricula
    {
        #region ATRIBUTOS; 
       protected int matricula_id;
       protected int estudiante_id;
       protected int grupo_id;
       protected int curso_id;
       protected int profesor_id;
       protected int horario_id;
       protected int aula_id;
       protected string matricula_comprobante;
       protected string matricula_estado;
        #endregion ATRIBUTOS  

        #region CONSTRUCTORES 
        public Matricula()
        {
        }
        /// <summary>
        /// Manejo procedimiento almacenado de insertar Matricula 
        /// </summary>
        /// <param name="mEstudiante_id"></param>
        /// <param name="mGrupo_id"></param>
        /// <param name="mCurso_id"></param>
        /// <param name="mProfesor_id"></param>
        /// <param name="mHorario_id"></param>
        /// <param name="mAula_id"></param>
        /// <param name="mMatricula_comprobante"></param>
        /// <param name="mMatricula_estado"></param>
        public Matricula(int mEstudiante_id, int mGrupo_id, int mCurso_id,
                        int mProfesor_id, int mHorario_id, int mAula_id, 
                        string mMatricula_comprobante, string mMatricula_estado)
        {
            Matricula_id = 0;
            Estudiante_id = mEstudiante_id;
            Grupo_id = mGrupo_id;
            Curso_id = mCurso_id;
            Profesor_id = mProfesor_id;
            Horario_id = mHorario_id;
            Aula_id = mAula_id;
            Matricula_comprobante = mMatricula_comprobante;
            Matricula_estado = mMatricula_estado;

        }
        /// <summary>
        /// Manejo procedimiento almacenado de Modificar Matricula
        /// </summary>
        /// <param name="mMatricula_id"></param>
        /// <param name="mEstudiante_id"></param>
        /// <param name="mGrupo_id"></param>
        /// <param name="mCurso_id"></param>
        /// <param name="mProfesor_id"></param>
        /// <param name="mHorario_id"></param>
        /// <param name="mAula_id"></param>
        /// <param name="mMatricula_comprobante"></param>
        /// <param name="mMatricula_estado"></param>
        public Matricula(int mMatricula_id, int mEstudiante_id, int mGrupo_id, int mCurso_id,
                        int mProfesor_id, int mHorario_id, int mAula_id, 
                        string mMatricula_comprobante, string mMatricula_estado)
        {
            Matricula_id = mMatricula_id;
            Estudiante_id = mEstudiante_id;
            Grupo_id = mGrupo_id;
            Curso_id = mCurso_id;
            Profesor_id = mProfesor_id;
            Horario_id = mHorario_id;
            Aula_id = mAula_id;
            Matricula_comprobante = mMatricula_comprobante;
            Matricula_estado = mMatricula_estado;

        }
        #endregion CONSTRUCTORES 

        #region GET's and SET's
        public int Matricula_id { get => matricula_id; set => matricula_id = value; }
        public int Estudiante_id { get => estudiante_id; set => estudiante_id = value; }
        public int Grupo_id { get => grupo_id; set => grupo_id = value; }
        public int Curso_id { get => curso_id; set => curso_id = value; }
        public int Profesor_id { get => profesor_id; set => profesor_id = value; }
        public int Horario_id { get => horario_id; set => horario_id = value; }
        public int Aula_id { get => aula_id; set => aula_id = value; }
        public string Matricula_comprobante { get => matricula_comprobante; set => matricula_comprobante = value; }
        public string Matricula_estado { get => matricula_estado; set => matricula_estado = value; }
        #endregion GET's and SET's

    }
}