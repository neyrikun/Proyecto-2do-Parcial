/*
 *	Archivo: VentanaAgregarComentario.cs
 *	Descripcion: Contiene la clase VentanaAgregarComentario que maneja 
 *               la insertacion comentarios a la foto seleccionada.
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
    public partial class VentanaAgregarComentario : Form
    {
        VentanaEstudiante vEstud;
        Candidata cand = new Candidata();
        Foto fotito = new Foto();
        /*
		 *	Método: VentanaAgregarComentario
		 *	=======================================
		 *	Crea una nueva pantalla para agregar 
         *  los comentarios a la foto seleccionada 
         *  por el estudiante
		 */
        public VentanaAgregarComentario(Foto fotito, Candidata cand, VentanaEstudiante vEstud)
        {
            this.vEstud = vEstud;
            this.cand = cand;
            this.fotito = fotito;
            InitializeComponent();
            pictureFoto.Load(fotito.Url);
        }
        /*
		 *	Método: button1_Click
		 *	==================================
		 *	Me permite activar el evento de ir
         *  a la pantalla de ver las fotos per-
         *  sonales de las candidatas.
		 */
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            VentanaVerFotosEstud vFotos = new VentanaVerFotosEstud(vEstud, cand);
            vFotos.Show();
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
		 *	Método: btnGuardar_Click
		 *	===================================
		 *	Me permite añadir el comentario 
         *  ingresado a la foto de la candidata
		 */
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text.Trim().CompareTo("") != 0 && textTitulo.Text.Trim().CompareTo("") != 0 && textDescripcion.Text.Trim().CompareTo("") != 0)
            {
                if (Comentario.ValidarComentario(fotito.Mat_Candidata, fotito.Album, fotito.Nombre, textTitulo.Text.Trim()) == 0)
                {
                    Comentario coment = new Comentario(fotito.Mat_Candidata, textUsuario.Text.Trim(), fotito.Album, fotito.Nombre, textTitulo.Text.Trim(), textDescripcion.Text.Trim());
                    coment.guardarComentario(coment);
                    this.Dispose();
                }
                else
                    MessageBox.Show("Ya existe un comentario a la foto con el mismo titulo. Por favor cambie de título", "Reina FIEC-Ingreso de Comentarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No ha ingresado algunos datos necesarios. Por favor Ingreselos", "Reina FIEC-Ingreso de Comentarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void VentanaAgregarComentario_Load(object sender, EventArgs e)
        {

        }
    }
}