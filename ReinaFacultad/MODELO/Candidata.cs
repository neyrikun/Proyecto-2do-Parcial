using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Candidata
    {
        private String codMatricula;
        private String nombre;
        private String apellido;
        private String email;
        private String edad;
        private String carrera;
        private String habilidades;
        private String intereses;
        private String aspiraciones;
        private String pasatiempos;
        private String foto; // Guarda solamente el URL
        /*
         *	Método Constructor: Candidata
         *	==========================================
         *	Me crea un nuevo objeto de tipo Candidata
         *  para almacenar las Candidata ingresadas 
         *  por el Administrador al sistema.
         */
        public Candidata()
        {
            codMatricula = "";
            nombre = "";
            apellido = "";
            email = "";
            edad = "";
            carrera = "";
            habilidades = "";
            intereses = "";
            aspiraciones = "";
            pasatiempos = "";
            foto = "";
        }
        /*
         *	Método Constructor: Candidata
         *	==========================================
         *	Me crea un nuevo objeto de tipo Candidata
         *  para almacenar las Candidata ingresadas 
         *  por el Administrador al sistema.
         */
        public Candidata(String mat, String nomb, String apell, String edad, String email, String car, String asp, String pas, String foto, String hab, String inter)
        {
            this.codMatricula = mat;
            this.nombre = nomb;
            this.apellido = apell;
            this.email = email;
            this.edad = edad;
            this.carrera = car;
            this.habilidades = hab;
            this.intereses = inter;
            this.aspiraciones = asp;
            this.pasatiempos = pas;
            this.foto = foto;
        }

        #region Metodos Get & Set

        public String CodMatricula
        {
            get { return codMatricula; }
            set { codMatricula = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public String Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public String Habilidades
        {
            get { return habilidades; }
            set { habilidades = value; }
        }
        public String Intereses
        {
            get { return intereses; }
            set { intereses = value; }
        }
        public String Aspiraciones
        {
            get { return aspiraciones; }
            set { aspiraciones = value; }
        }
        public String Pasatiempos
        {
            get { return pasatiempos; }
            set { pasatiempos = value; }
        }
        public String Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        #endregion

        /*
         *	Método: guardar
         *	=============================================
         *	Me almacena los datos respectivos de una nue-
         *  va candidata ingresada al sistema.
         */
        public void guardar()
        {
            Conexion con = new Conexion();
            con.conectar();
            string sql = "insert into Candidata (Nro_Matricula,Nombre,Apellido,Edad,Email,Carrera,Habilidades,Intereses,Aspiraciones,Pasatiempos,Foto) values('" + codMatricula + "','" + nombre + "','" + apellido + "','" + edad + "','" + email + "','" + carrera + "','" + habilidades + "','" + intereses + "','" + aspiraciones + "','" + pasatiempos + "','" + foto + "')";
            con.guardarActualizar(sql);
            con.desconectar();
        }

        /*
         *	Método: getListadoCarreras
         *	=============================================
         *	Me devuelve el listado de todas las candidatas
         *  existentes en el sistema
         */
        public static object[] getListadoCarreras()
        {
            Conexion c = new Conexion();
            OleDbDataReader r;
            c.conectar();
            String tmp;
            ArrayList L = new ArrayList();
            Array L2;
            r = c.consultar("select * from Carreras");
            while (r.Read())
            {
                tmp = r.GetString(0);
                L.Add(tmp);
            }
            c.desconectar();
            L2 = L.ToArray();
            object[] Carreras = new object[L2.Length];
            for (int i = 0; i < L2.Length; i++)
            {
                tmp = (String)L2.GetValue(i);
                Carreras[i] = tmp;
            }
            return Carreras;
        }
        /*
         *	Método: getListadoMatriculas
         *	=============================================
         *	Me devuelve el listado de todas las Matriculas
         *  de las candidatas existentes en el sistema.
         */
        public static object[] getListadoMatriculas()
        {
            Conexion c = new Conexion();
            OleDbDataReader r;
            c.conectar();
            String tmp;
            ArrayList L = new ArrayList();
            Array L2;
            r = c.consultar("select Nro_Matricula from Candidata");
            while (r.Read())
            {
                tmp = r.GetString(0);
                L.Add(tmp);
            }
            c.desconectar();
            L2 = L.ToArray();
            object[] Matriculas = new object[L2.Length];
            for (int i = 0; i < L2.Length; i++)
            {
                tmp = (String)L2.GetValue(i);
                Matriculas[i] = tmp;
            }
            return Matriculas;
        }
        /*
         *	Método: getListadoMatriculasArray
         *	===============================================
         *	Me devuelve el listado de todas las Matriculas
         *  de las candidatas existentes en el sistema en
         *  un listado de tipo Array.
         */
        public ArrayList getListadoMatriculasArray()
        {
            Conexion c = new Conexion();
            OleDbDataReader r;
            c.conectar();
            String tmp;
            ArrayList L = new ArrayList();
            r = c.consultar("select Nro_Matricula from Candidata");
            while (r.Read())
            {
                tmp = r.GetString(0);
                L.Add(tmp);
            }
            c.desconectar();
            return L;
        }
        /*
         *	Método: buscarXnumMatricula
         *	===============================================
         *	Me devuelve los datos de la candidata cuyo núme-
         *  ro de matrícula coinciden con los que se reciben
         *  como parámetro.
         */
        public static Candidata buscarXnumMatricula(string codMat_cand)
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;
            Candidata cand;

            c.conectar();
            String sql = "select * from Candidata where Nro_Matricula='" + codMat_cand + "'";
            datos_db = c.consultar(sql);
            datos_db.Read();
            cand = new Candidata(
                datos_db.GetString(0),
                datos_db.GetString(1),
                datos_db.GetString(2),
                datos_db.GetInt16(3).ToString(),
                datos_db.GetString(4),
                datos_db.GetString(5),
                datos_db.GetString(6),
                datos_db.GetString(7),
                datos_db.GetValue(8).ToString(),
                datos_db.GetValue(9).ToString(),
                datos_db.GetValue(10).ToString()
                );
            c.desconectar();
            return cand;
        }
        /*
         *	Método: buscarAlbunesXnumMatricula
         *	===============================================
         *	Me devuelve los Albunes de fotos que tiene la 
         *  candidata cuyo número de matrícula coinciden con
         *  los que se reciben como parámetro.
         */
        public static string[] buscarAlbunesXnumMatricula(string codMat_cand)
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;
            ArrayList lAlbunes = new ArrayList();

            c.conectar();
            String sql = "select * from Album where Nro_Matricula='" + codMat_cand + "'";
            datos_db = c.consultar(sql);
            while (datos_db.Read())
            {
                lAlbunes.Add(datos_db.GetString(1));
            }
            c.desconectar();
            Array albArray = lAlbunes.ToArray();
            string[] albString = new string[albArray.Length];

            for (int i = 0; i < albArray.Length; i++)
            {
                albString[i] = (String)albArray.GetValue(i);
            }
            return albString;
        }

        /*
         *	Método: crearDirectorio
         *	===============================================
         *	Me permite crear un nuevo album de fotos a la ca-
         *  ndidata.
         */
        public void crearDirectorio(Candidata cand, String nombre)
        {
            string sTemp = @"..\Candidatas\" + cand.CodMatricula + @"\" + nombre;
            DirectoryInfo dir = new DirectoryInfo(sTemp);
            dir.Create();
            aniadirDirAdb(cand, nombre);
        }
        /*
         *	Método: aniadirDirAdb
         *	===================================================
         *	Me permite Añadir un nuevo album de fotos de la ca-
         *  ndidata a su listado de albunes existentes.
         */
        public void aniadirDirAdb(Candidata cand, String nombre)
        {
            Conexion con = new Conexion();
            con.conectar();
            string sql = "insert into Album (Nro_Matricula,Nombre,Galeria) values('" + cand.CodMatricula + "','" + nombre + "'," + 0 + ")";
            con.guardarActualizar(sql);
            con.desconectar();
        }
        /*
         *	Método: buscarAlbunesXnumMatricula2
         *	===============================================
         *	Me devuelve los Albunes de fotos que tiene la 
         *  candidata cuyo número de matrícula coinciden con
         *  los que se reciben como parámetro.
         */
        public static object[] buscarAlbunesXnumMatricula2(string codMat_cand)
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;
            ArrayList lAlbunes = new ArrayList();
            string tmp = "";

            c.conectar();
            String sql = "select Nombre from Album where Nro_Matricula='" + codMat_cand + "'";
            datos_db = c.consultar(sql);
            while (datos_db.Read())
            {
                lAlbunes.Add(datos_db.GetString(0));
            }
            c.desconectar();
            Array albArray = lAlbunes.ToArray();
            object[] Albunes = new object[albArray.Length];
            for (int i = 0; i < albArray.Length; i++)
            {
                tmp = (String)albArray.GetValue(i);
                Albunes[i] = tmp;
            }
            return Albunes;
        }

        /*
         *	Método: ValidarSiYaExisteAlbum
         *	===============================================
         *	Me permite validar si el album que deseo crear, 
         *  ya existe en el sistema.
         */
        public static int ValidarSiYaExisteAlbum(string codMat_cand, string nombreAlbum)
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;
            ArrayList lAlbun = new ArrayList();

            c.conectar();
            String sql = "select Nombre from Album where Nro_Matricula='" + codMat_cand + "' and Nombre='" + nombreAlbum + "'";
            datos_db = c.consultar(sql);
            while (datos_db.Read())
            {
                lAlbun.Add(datos_db.GetString(0));
            }
            c.desconectar();
            return lAlbun.Count;
        }

        /*
         *	Método: obtenerListCandidatas
         *	===================================================
         *	Me devuelve un listado de todas las candidatas 
         *  así como de todos sus datos personales y sus Fotos.
         */
        public static ArrayList obtenerListCandidatas()
        {
            Conexion c = new Conexion();
            OleDbDataReader datos_db;
            ArrayList lCandidatas = new ArrayList();
            Candidata cand;

            c.conectar();
            String sql = "select * from Candidata";
            datos_db = c.consultar(sql);
            while (datos_db.Read())
            {
                Debug.WriteLine(
                    "\n> VALOR0:" + datos_db.GetValue(0).GetType().ToString() + " | " + datos_db.GetName(0) +
                    "\n> VALOR1:" + datos_db.GetValue(1).GetType().ToString() + " | " + datos_db.GetName(1) +
                    "\n> VALOR2:" + datos_db.GetValue(2).GetType().ToString() + " | " + datos_db.GetName(2) +
                    "\n> VALOR3:" + datos_db.GetValue(3).GetType().ToString() + " | " + datos_db.GetName(3) +
                    "\n> VALOR4:" + datos_db.GetValue(4).GetType().ToString() + " | " + datos_db.GetName(4) +
                    "\n> VALOR5:" + datos_db.GetValue(5).GetType().ToString() + " | " + datos_db.GetName(5) +
                    "\n> VALOR6:" + datos_db.GetValue(6).GetType().ToString() + " | " + datos_db.GetName(6) +
                    "\n> VALOR7:" + datos_db.GetValue(7).GetType().ToString() + " | " + datos_db.GetName(7) +
                    "\n> VALOR8:" + datos_db.GetValue(8).GetType().ToString() + " | " + datos_db.GetName(8) +
                    "\n> VALOR9:" + datos_db.GetValue(9).GetType().ToString() + " | " + datos_db.GetName(9) +
                    "\n> VALOR10:" + datos_db.GetValue(10).GetType().ToString() + " | " + datos_db.GetName(10) +
                    "\n");
                cand = new Candidata(
                    datos_db.GetString(0),
                    datos_db.GetString(1),
                    datos_db.GetString(2),
                    datos_db.GetInt16(3).ToString(),
                    datos_db.GetString(4),
                    datos_db.GetString(5),
                    datos_db.GetString(6),
                    datos_db.GetString(7),
                    datos_db.GetValue(8).ToString(),
                    datos_db.GetValue(9).ToString(),
                    datos_db.GetValue(10).ToString()
                    );
                lCandidatas.Add(cand);
            }
            return lCandidatas;
        }
    }
}
