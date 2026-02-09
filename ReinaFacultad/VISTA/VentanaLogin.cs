/*
 *	Archivo: VentanaLogin.cs
 *	Descripcion: Contiene la clase VentanaLogin que maneja 
 *               el ingreso al sistema.
  *	Autor:	 Franklin Parrales
 *	Fecha de creacion: 2007-07-07
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using MODELO;

namespace VISTA
{
    public partial class VentanaLogin : Form
    {
        /*
         *	Método: VentanaLogin
         *	==================
         *	Crea un objeto del tipo VentanaLogin para 
         *  inicializar la aplicación
         */
        public VentanaLogin()
        {
            InitializeComponent();
            //pictureBox1.Load(@"..\Candidatas\Espol.gif");
        }
        /*
         *	Método: Main
         *	==================
         *	Inicializa la aplicación pidiendome el usuario 
         *  y la contraseña, me valida los datos y luego en-
         *  tra a la respectiva pantalla de cada usuario.
         */
        [STAThread]
        /*
         *	Método: login
         *	==================
         *	Valida los datos y verifica que tipo de usuario
         *  es el que esta ingresando al sistema, luego de
         *  saberlo, decide en que ambiente este trabajará
         *  y finalmente muestra su respectiva pantalla.
         */
        private void login()
        {
            Conexion c = new Conexion();
            OleDbDataReader r;
            c.conectar();
            string sql = "select Usuario from Usuarios where Usuario='" + textUser.Text.Trim() + "' and Contraseña= '" + textPassword.Text.Trim() + "'";
            r = c.consultar(sql);
            if (r.Read())
            {
                if ((r.GetString(0)).CompareTo("administrador") == 0)
                {
                    this.Hide();
                    VentanaPrincipal vPrin = new VentanaPrincipal();
                    vPrin.Show();
                }
                else if ((r.GetString(0)).CompareTo("estudiante") == 0)
                {
                    this.Hide();
                    VentanaEstudiante vEstud = new VentanaEstudiante();
                    vEstud.Show();
                }
            }
            else
                MessageBox.Show("Error de Usuario y/o Contraseña. Vuelva a Ingresar", "Reina FIEC: Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /*
         *	Método: button2_Click
         *	==================
         *	Me activa el evento login
         */
        private void button2_Click(object sender, EventArgs e)
        {
            login();
        }
        /*
         *	Método: button1_Click
         *	==================
         *	Me activa el evento Salir del sistema
         */
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}