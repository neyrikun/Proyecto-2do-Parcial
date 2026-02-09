using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Comentario
    {
        private String codMatricula;
        private String usuario;
        private String album;
        private String nombFoto;
        private String titulo;
        private String descripcion;
        /*
         *	Método Constructor: Comentario
         *	==========================================
         *	Me crea un nuevo objeto de tipo Comentario
         *  para almacenar los comentarios ingresados 
         *  por el estudiante al sistema.
         */
        public Comentario()
        {
            this.codMatricula = "";
            this.usuario = "";
            this.album = "";
            this.nombFoto = "";
            this.titulo = "";
            this.descripcion = "";
        }
        /*
         *	Método Constructor: Comentario
         *	==========================================
         *	Me crea un nuevo objeto de tipo Comentario
         *  para almacenar los comentarios ingresados 
         *  por el estudiante al sistema.
         */
        public Comentario(string codMatricula, string usuario, string album, string nombFoto, string titulo, string descripcion)
        {
            this.codMatricula = codMatricula;
            this.usuario = usuario;
            this.album = album;
            this.nombFoto = nombFoto;
            this.titulo = titulo;
            this.descripcion = descripcion;
        }

        #region Metodos Get & Set

        public String CodMatricula
        {
            get { return codMatricula; }
            set { codMatricula = value; }
        }

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public String Album
        {
            get { return album; }
            set { album = value; }
        }
        public String NombFoto
        {
            get { return nombFoto; }
            set { nombFoto = value; }
        }

        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        #endregion

        /*
         *	Método: guardarComentario
         *	==========================================
         *	Me permite guardar un nuevo comentario a 
         *  una foto de la candidata por parte del es-
         *  tudiante.
         */
        public void guardarComentario(Comentario c)
        {
            Conexion con = new Conexion();
            con.conectar();
            string sql = "insert into Comentarios (Nro_Matricula,Usuario,Album,Nombre,Titulo,Comentario) values('" + c.CodMatricula + "','" + c.Usuario + "','" + c.Album + "','" + c.NombFoto + "','" + c.Titulo + "','" + c.Descripcion + "')";
            con.guardarActualizar(sql);
            con.desconectar();
        }
        /*
         *	Método: buscarComentariosXFotos
         *	==========================================
         *	Me devuelve un listado de los comentarios
         *  hechos a una foto en particular.
         */
        public static object[] buscarComentariosXFotos(Foto fotito)
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;
            ArrayList lComentarios = new ArrayList();
            string tmp = "";

            c.conectar();
            String sql = "select Titulo from Comentarios where Nro_Matricula='" + fotito.Mat_Candidata + "' and Album='" + fotito.Album + "' and Nombre='" + fotito.Nombre + "'";
            datos_db = c.consultar(sql);
            while (datos_db.Read())
            {
                lComentarios.Add(datos_db.GetString(0));
            }
            c.desconectar();
            Array lComentariosArray = lComentarios.ToArray();
            object[] Comentarios = new object[lComentariosArray.Length];
            for (int i = 0; i < lComentariosArray.Length; i++)
            {
                tmp = (String)lComentariosArray.GetValue(i);
                Comentarios[i] = tmp;
            }
            return Comentarios;
        }
        /*
         *	Método: buscarComentarioXFotoAndTitulo
         *	==========================================
         *	Me devuelve el comentario seleccionado por
         *  el titulo y la foto a la cual este hace re-
         *  ferencia.
         */
        public static string buscarComentarioXFotoAndTitulo(Foto fotito, string titulo)
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;
            string Coment = "";

            c.conectar();
            String sql = "select Comentario from Comentarios where Nro_Matricula='" + fotito.Mat_Candidata + "' and Album='" + fotito.Album + "' and Nombre='" + fotito.Nombre + "' and Titulo= '" + titulo + "'";
            datos_db = c.consultar(sql);
            while (datos_db.Read())
            {
                Coment = datos_db.GetString(0);
            }
            c.desconectar();
            return Coment;
        }
        /*
         *	Método: generarMasComentareadas
         *	==========================================
         *	Me permite generar las 5 candidatas mas co-
         *  mentareadas en el sistema.
         */
        public ArrayList generarMasComentareadas()
        {
            Conexion c = new Conexion();
            Candidata cand = new Candidata();
            OleDbDataReader datos_db;
            ArrayList matCandidatas = new ArrayList();
            ArrayList matComent = new ArrayList();
            //borro los datos guardados para volverlos a calcular                        
            c.conectar();
            String sql = "delete * from NumComentarios";
            c.guardarActualizar(sql);
            //Cargo las matriculas de las candidatas
            matCandidatas = cand.getListadoMatriculasArray();
            Array matCand_Array = matCandidatas.ToArray();
            //Inicio mi búsqueda
            for (int i = 0; i < matCand_Array.Length; i++)
            {
                matComent.Clear();
                sql = "select  Nro_Matricula from Comentarios where Nro_Matricula='" + matCand_Array.GetValue(i) + "'";
                datos_db = c.consultar(sql);
                while (datos_db.Read())
                {
                    matComent.Add(datos_db.GetString(0));
                }
                sql = "insert into NumComentarios(Nro_Matricula,Num_Comentarios) values('" + matCand_Array.GetValue(i) + "'," + matComent.Count + ")";
                c.guardarActualizar(sql);
            }
            c.desconectar();
            matComent.Clear();
            matComent = obtenerMasComentareadas(c);
            return matComent;
        }
        /*
         *	Método: obtenerMasComentareadas
         *	==========================================
         *	Me permite obtener la candidata que ha re-
         *  cibido la mayor cantidad de comentarios.
         */
        public ArrayList obtenerMasComentareadas(Conexion c)
        {
            int numMasComent = 0;
            OleDbDataReader datos_db;
            ArrayList masComent = new ArrayList();

            c.conectar();
            string sql = "select * from NumComentarios order by Num_Comentarios DESC";
            datos_db = c.consultar(sql);
            while (datos_db.Read())
            {
                if (numMasComent < 5)
                {
                    masComent.Add(datos_db.GetString(0));
                    numMasComent++;
                }
                else
                    break;
            }
            return masComent;
        }
        /*
         *	Método: convertirArrayToObject
         *	=========================================
         *	Me permite convertir un listado de comen-
         *  tarios desde un Arraylist a un arreglo de
         *  objetos para su posterior uso.
         */
        public object[] convertirArrayToObject(ArrayList numMatCand)
        {
            Array numMat_Array = numMatCand.ToArray();
            object[] numMat_Object = new object[numMat_Array.Length];
            for (int i = 0; i < numMat_Array.Length; i++)
            {
                string tmp = (String)numMat_Array.GetValue(i);
                numMat_Object[i] = tmp;
            }
            return numMat_Object;
        }
        /*
         *	Método: obtenerComentarioCandidata
         *	========================================
         *	Me permite obtener el numero de comenta-
         *  rios realizados a una candidata en parti
         *  cular.
         */
        public int obtenerComentarioCandidata(string codMatCand)
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;

            c.conectar();
            string sql = "select Num_Comentarios from NumComentarios where Nro_Matricula='" + codMatCand + "'";
            datos_db = c.consultar(sql);
            datos_db.Read();
            return (datos_db.GetInt32(0));
        }
        /*
         *	Método: obtenerMasComentareada
         *	========================================
         *	Me permite obtener el codigo de Matricula
         *  de la candidata que ha obtenido la mayor 
         *  cantidad de comentarios por parte de los 
         *  estudiantes.
         */
        public string obtenerMasComentareada()
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;
            string codMat = "";

            c.conectar();
            string sql = "select Nro_Matricula from NumComentarios order by Num_Comentarios DESC";
            datos_db = c.consultar(sql);
            datos_db.Read();
            codMat = datos_db.GetString(0);
            c.desconectar();
            return codMat;
        }
        /*
         *	Método: ValidarComentario
         *	========================================
         *	Me permite validar si ya se ha ingresado
         *  un comentario a una foto con el mismo ti-
         *  tulo y el mismo Album.
         */
        public static int ValidarComentario(string codMatCand, string album, string nomb_Foto, string titulo_Comentario)
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;
            ArrayList lComent = new ArrayList();
            int result = 0;

            c.conectar();
            string sql = "select Nro_Matricula from Comentarios where Nro_Matricula='" + codMatCand + "' and Album='" + album + "' and Nombre='" + nomb_Foto + "' and Titulo='" + titulo_Comentario + "'";
            datos_db = c.consultar(sql);
            while (datos_db.Read())
            {
                lComent.Add(datos_db.GetString(0));
            }
            result = lComent.Count;
            c.desconectar();
            return result;
        }
        /*
         * 
         * 
         */
        public ArrayList lCandidatasMasComentareadas()
        {
            ArrayList lmasComent = generarMasComentareadas();
            Array lmasComentArr = lmasComent.ToArray();
            ArrayList lCandidatas = new ArrayList();
            Candidata cand = new Candidata();

            for (int i = 0; i < lmasComentArr.Length; i++)
            {
                cand = Candidata.buscarXnumMatricula((string)lmasComentArr.GetValue(i));
                lCandidatas.Add(cand);
            }
            return lCandidatas;
        }
    }
}
