/*
 *	Archivo: VentanaCandidata.cs
 *	Descripcion: Contiene la clase VentanaCandidata que maneja 
 *               la presentación de las candidatas con sus datos p-
 *               ersonales.
 *	Autor:	 Franklin Parrales
 *	Fecha de creacion: 2007-07-07
 */
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VISTA
{
    public partial class VentanaCandidata : Form
    {
        VentanaPrincipal vPrincipal;
        Candidata cand;
        /*
		 *	Método: VentanaCandidataEstud
		 *	================================
		 *	Crea una nueva pantalla para mostrar los datos 
         *  personales de las candidatas, así como un enlace
         *  para ver sus fotos ingresadas.
		 */
        public VentanaCandidata(VentanaPrincipal vPrincipal, Candidata cand)
        {
            this.vPrincipal = vPrincipal;
            this.cand = cand;
            InitializeComponent();
            cargarImagen();
            llenarDatos();
        }
        /*
		 *	Método: llenarDatos
		 *	====================
		 *	Llena los datos de la Candidata
		 */
        private void llenarDatos()
        {
            labelMat.Text = cand.CodMatricula;
            labelName.Text = cand.Nombre;
            labelApell.Text = cand.Apellido;
            labelEd.Text = cand.Edad;
            labelEma.Text = cand.Email;
            labelCarr.Text = cand.Carrera;
            labelHab.Text = cand.Habilidades;
            labelInter.Text = cand.Intereses;
            labelPas.Text = cand.Pasatiempos;
            labelAsp.Text = cand.Aspiraciones;
        }
        /*
		 *	Método: cargarImagen
		 *	====================
		 *	Carga la foto de la Candidata
		 */

        private void cargarImagen()
        {
            try
            {
                pictureBox1.Load(cand.Foto);
            }

            catch (System.Exception)
            {
                Console.WriteLine("Error al cargar la imagen " + cand.Foto);
            }

        }
        /*
		 *	Método: btn_Salir_Click
		 *	==============================
		 *	Me permite activar el evento 
         *  para volver a la pantalla pri-
         *  ncipal.
		 */
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /*
		 *	Método: btnVerFotos_Click
		 *	==================================
		 *	Me permite activar el evento de ir
         *  a la pantalla de ver las fotos per-
         *  sonales de las candidatas.
		 */
        private void btnVerFotos_Click(object sender, EventArgs e)
        {
            VentanaVerFotos vLook = new VentanaVerFotos(vPrincipal, cand);
            vLook.Show();
            this.Dispose();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}