using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Collections;
using System.Diagnostics;

namespace MODELO
{
	/// <summary>
	/// Clase para la conexión con la base de datos
	/// </summary>
	public class Conexion
	{
        static string Ruta = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "DataBase",
            "ReinaFIECdb.mdb"
        );
        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Ruta + ";Persist Security Info=False;";

        OleDbConnection con;

        public Conexion()
		{ }
		public void conectar()
		{

            con = new OleDbConnection(cadenaConexion);
			con.Open();
		}
		public void desconectar()
		{
			con.Close();
		}
		public void guardarActualizar(string sql)
		{
			OleDbCommand ORDEN;
			ORDEN = new OleDbCommand(sql, con);
			ORDEN.ExecuteNonQuery();

		}
		public OleDbDataReader consultar(string sql)
		{
			OleDbCommand ORDEN;
			OleDbDataReader lectura;
			ORDEN = new OleDbCommand(sql, con);
            lectura = ORDEN.ExecuteReader();
            return lectura;
		}
		public OleDbConnection Con
		{
			get{return con;}
			set{con=value;}
		}
	}
}