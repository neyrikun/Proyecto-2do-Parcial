using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Voto
    {
        private String matEstudiante;
        private String matCandidata;
        private String categoria;
        /*
         *	Método Constructor: Voto
         *	====================================
         *	Me crea un nuevo objeto de tipo Voto
         *  para almacenar los Votos ingresados 
         *  por los estudiantes al sistema.
         */
        public Voto()
        {
            this.matEstudiante = "";
            this.matCandidata = "";
            this.categoria = "";
        }
        /*
         *	Método Constructor: Voto
         *	====================================
         *	Me crea un nuevo objeto de tipo Voto
         *  para almacenar los Votos ingresados 
         *  por los estudiantes al sistema.
         */
        public Voto(string mat_est, string mat_cand, string categ)
        {
            this.matEstudiante = mat_est;
            this.matCandidata = mat_cand;
            this.categoria = categ;
        }

        #region Metodos Get & Set

        public String MatEstudiante
        {
            get { return matEstudiante; }
            set { matEstudiante = value; }
        }
        public String MatCandidata
        {
            get { return matCandidata; }
            set { matCandidata = value; }
        }
        public String Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        #endregion

        /*
         *	Método: guardar
         *	=======================================
         *	Me permite almacenar un nuevo voto rea-
         *  lizado por el estudiante.
         */
        public void guardar()
        {
            Conexion con = new Conexion();
            con.conectar();
            string sql = "insert into Votacion (Mat_Estudiante,Mat_Candidata,Categoria) values('" + this.matEstudiante + "','" + this.matCandidata + "','" + this.categoria + "')";
            con.guardarActualizar(sql);
            con.desconectar();
        }
        /*
         *	Método: validarSiVoto
         *	=======================================
         *	Me permite Validar si el estudiante que
         *  desea efectuar la votacion, ya ha ejer-
         *  cido este derecho en la categoría pasada
         *  como parámetro.
         */
        public int validarSiVoto(string matEstudiante, string categoria)
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;
            ArrayList votos = new ArrayList();
            c.conectar();
            String sql = "select * from Votacion where Mat_Estudiante='" + matEstudiante + "' and Categoria='" + categoria + "'";
            datos_db = c.consultar(sql);
            while (datos_db.Read())
            {
                Voto v = new Voto(datos_db.GetString(0), datos_db.GetString(1), datos_db.GetString(2));
                votos.Add(v);
            }
            c.desconectar();
            if (votos.Count != 0)
                return 1;
            return 0;
        }
        /*
         *	Método: getCategorias
         *	================================================
         *	Me permite Obtener las categorías a seleccionar 
         *  para las elecciones de las candidatas.
         */
        public object[] getCategorias(string matEstudiante)
        {
            ArrayList Categ_List = new ArrayList();
            String tmp;
            if (validarSiVoto(matEstudiante, "Reina FIEC") == 0)
            {
                Categ_List.Add("Reina FIEC");
            }
            if (validarSiVoto(matEstudiante, "Miss Fotogenia") == 0)
            {
                Categ_List.Add("Miss Fotogenia");
            }
            Array Categ_Array = Categ_List.ToArray();
            object[] Categorias = new object[Categ_Array.Length];
            for (int i = 0; i < Categ_Array.Length; i++)
            {
                tmp = (String)Categ_Array.GetValue(i);
                Categorias[i] = tmp;
            }
            return Categorias;
        }
        /*
         *	Método: generarResultados
         *	================================================
         *	Me permite Obtener los resultados de las eleccio-
         *  nes de las candidatas.
         */
        public void generarResultados()
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;
            ArrayList mat_Candidatas = new ArrayList();
            Candidata cand = new Candidata();
            Array cand_Array;
            Array categ_Array;
            ArrayList votos = new ArrayList();
            ArrayList categoria = new ArrayList();

            //Asigno valores de las categorias
            mat_Candidatas = cand.getListadoMatriculasArray();
            cand_Array = mat_Candidatas.ToArray();
            categoria.Add("Reina FIEC");
            categoria.Add("Miss Fotogenia");
            categ_Array = categoria.ToArray();

            //Inserto, consulto y elimino de la base de datos
            c.conectar();
            String sql = "delete * from Resultados";
            c.guardarActualizar(sql);
            for (int i = 0; i < mat_Candidatas.Count; i++)
            {
                for (int j = 0; j < categ_Array.Length; j++)
                {
                    votos.Clear();
                    sql = "select * from Votacion where Mat_Candidata='" + cand_Array.GetValue(i) + "' and Categoria='" + categ_Array.GetValue(j) + "'";
                    datos_db = c.consultar(sql);
                    while (datos_db.Read())
                    {
                        votos.Add(datos_db.GetString(1));
                    }
                    sql = "insert into Resultados (Nro_Matricula,Votos,Categoria) values('" + cand_Array.GetValue(i) + "'," + votos.Count + ",'" + categ_Array.GetValue(j) + "')";
                    Debug.WriteLine("> DATOS ITERACIÓN: " + cand_Array.GetValue(i).ToString() + " | " + categ_Array.GetValue(j).ToString());
                    c.guardarActualizar(sql);
                }
            }
            c.desconectar();
        }
        /*
         *	Método: consultarVotos
         *	================================================
         *	Me permite Obtener el numero de votos de una can-
         *  didata en la categoría seleccionada.
         */
        public int consultarVotos(string codMat_Cand, string categ)
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;
            int numVotos = 0;
            c.conectar();
            String sql = "select Votos from Resultados where Nro_Matricula='" + codMat_Cand + "' and Categoria='" + categ + "'";
            datos_db = c.consultar(sql);
            datos_db.Read();
            numVotos = datos_db.GetInt32(0);
            return numVotos;
        }
        /*
         *	Método: obtenerMasVotada
         *	==========================================
         *	Me permite Obtener la candidata mas votada 
         *  en la categoría pasada como parametro.
         */
        public string obtenerMasVotada(string Categoria)
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;

            c.conectar();
            string sql = "select * from Resultados where Categoria='" + Categoria + "' order by Votos DESC";
            datos_db = c.consultar(sql);
            datos_db.Read();
            return datos_db.GetString(0);
        }

    }
}
