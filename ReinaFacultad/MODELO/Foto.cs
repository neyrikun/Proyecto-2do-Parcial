using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Foto
    {
        private String mat_Candidata;
        private String album;
        private String nombre;
        private String descripcion;
        private String url;
        /*
         *	Método Constructor: Foto
         *	==========================================
         *	Me crea un nuevo objeto de tipo Foto para
         *  almacenar los datos de una nueva foto in-
         *  gresada al sistema.
         */
        public Foto()
        {
            this.mat_Candidata = "";
            this.album = "";
            this.nombre = "";
            this.descripcion = "";
            this.url = "";
        }
        /*
         *	Método Constructor: Foto
         *	==========================================
         *	Me crea un nuevo objeto de tipo Foto para
         *  almacenar los datos de una nueva foto in-
         *  gresada al sistema.
         */
        public Foto(String mat, String album, String nombre, String desc, String url)
        {
            this.mat_Candidata = mat;
            this.album = album;
            this.nombre = nombre;
            this.descripcion = desc;
            this.url = url;
        }

        #region Metodos Get & Set

        public String Mat_Candidata
        {
            get { return mat_Candidata; }
            set { mat_Candidata = value; }
        }

        public String Album
        {
            get { return album; }
            set { album = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public String Url
        {
            get { return url; }
            set { url = value; }
        }

        #endregion

        /*
         *	Método: aniadirFotoAdb
         *	============================================
         *	Me almacena los datos respectivos a una nue-
         *  va foto ingresada al sistema.
         */
        public void aniadirFotoAdb(Foto fotito)
        {
            Conexion con = new Conexion();
            con.conectar();
            string sql = "insert into Fotos (Nro_Matricula,Album,Nombre,Descripcion,Url) values('" + fotito.Mat_Candidata + "','" + fotito.Album + "','" + fotito.Nombre + "','" + fotito.Descripcion + "','" + fotito.Url + "')";
            con.guardarActualizar(sql);
            con.desconectar();
        }
        /*
         *	Método: buscarFotosXnumMatricula
         *	============================================
         *	Me permite obtener el listado de las fotos 
         *  de una determinada candidata.
         */
        public static object[] buscarFotosXnumMatricula(string codMat_cand, string Album)
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;
            ArrayList lFotos = new ArrayList();
            string tmp = "";

            c.conectar();
            String sql = "select Nombre from Fotos where Nro_Matricula='" + codMat_cand + "' and Album='" + Album + "'";
            datos_db = c.consultar(sql);
            while (datos_db.Read())
            {
                lFotos.Add(datos_db.GetString(0));
            }
            c.desconectar();
            Array lFotosArray = lFotos.ToArray();
            object[] Fotos = new object[lFotosArray.Length];
            for (int i = 0; i < lFotosArray.Length; i++)
            {
                tmp = (String)lFotosArray.GetValue(i);
                Fotos[i] = tmp;
            }
            return Fotos;
        }
        /*
         *	Método: buscarXnombre
         *	============================================
         *	Me permite obtener la foto de una candidata 
         *  por el nombre de la foto.
         */
        public Foto buscarXnombre(string codMat_cand, string Album, string nombre)
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;
            Foto fotito;

            c.conectar();
            String sql = "select * from Fotos where Nro_Matricula='" + codMat_cand + "' and Album='" + Album + "' and Nombre='" + nombre + "'";
            datos_db = c.consultar(sql);
            datos_db.Read();
            fotito = new Foto(datos_db.GetString(0), datos_db.GetString(1), datos_db.GetString(2), datos_db.GetString(3), datos_db.GetString(4));
            c.desconectar();
            return fotito;
        }
        /*
         *	Método: ValidarSiFotoYaExiste
         *	================================================
         *	Me permite validar si la Foto que deseo Insertar, 
         *  ya existe en el sistema.
         */
        public static int ValidarSiFotoYaExiste(string codMat_cand, string Album, string nombre)
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;
            ArrayList lFoto = new ArrayList();

            c.conectar();
            String sql = "select Nombre from Fotos where Nro_Matricula='" + codMat_cand + "' and Album='" + Album + "' and Nombre='" + nombre + "'";
            datos_db = c.consultar(sql);
            while (datos_db.Read())
            {
                lFoto.Add(datos_db.GetString(0));
            }
            c.desconectar();
            return lFoto.Count;
        }
    }
}
