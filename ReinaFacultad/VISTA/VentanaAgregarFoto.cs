/*
 *	Archivo: VentanaAgregarFoto.cs
 *	Descripcion: Contiene la clase VentanaAgregarFoto que maneja 
 *               la insertacion de fotos para la candidata selec-
 *               cionada
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
using System.IO;
using MODELO;
using System.Diagnostics;

namespace VISTA
{
    public partial class VentanaAgregarFoto : Form
    {
        Candidata cand = new Candidata();
        VentanaPrincipal vPrincipal = new VentanaPrincipal();
        /*
		 *	Método: VentanaAgregarFoto
		 *	=====================================
		 *	Crea una nueva pantalla para agregar 
         *  fotos a las candidatas en sus respec-
         *  tivos albunes.
		 */
        public VentanaAgregarFoto(VentanaPrincipal vPrincipal)
        {
            InitializeComponent();
            Inicializar();
            comboAlbunes.Items.Clear();
            this.vPrincipal = vPrincipal;
            comboMatricula.Items.Clear();
            comboMatricula.Items.AddRange(Candidata.getListadoMatriculas());
        }
        /*
		 *	Método: comboMatricula_SelectedIndexChanged
		 *	============================================
		 *	Me permite generar el evento de mostrar el 
         *  listado de albunes creados de la candidata 
         *  seleccionada, así como sus datos personales
		 */
        private void comboMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            Candidata c = Candidata.buscarXnumMatricula(comboMatricula.Text.Trim());
            this.cand = c;
            Inicializar();
            if (c.Foto is not string)
                pictureFoto.Load(c.Foto);
            labelName.Text = c.Nombre;
            labelApe.Text = c.Apellido;
            comboAlbunes.Items.Clear();
            comboAlbunes.Items.AddRange(Candidata.buscarAlbunesXnumMatricula2(c.CodMatricula));
        }
        /*
		 *	Método: lnkImportar_LinkClicked
		 *	============================================
		 *	Me permite generar el evento de mostrar la 
         *  foto seleccionada para ingresarla al sistema
		 */
        private void lnkImportar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFoto.ShowDialog() == DialogResult.OK)
            {
                pictureFoto.Load(openFoto.FileName);
            }
        }
        /*
		 *	Método: btnCancelar_Click
		 *	==============================
		 *	Me permite activar el evento 
         *  para volver a la pantalla pri-
         *  ncipal.
		 */
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            vPrincipal.Show();
        }
        /*
		 *	Método: btnAgregar_Click
		 *	==============================
		 *	Me permite activar el evento 
         *  para volver a la pantalla pri-
         *  ncipal.
		 */
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (textNameFoto.Text.Trim().CompareTo("") == 0 || textDescripcion.Text.Trim().CompareTo("")==0)
            {
                MessageBox.Show("Llene todos los campos. Por favor.", "Reina FIEC-Agregar Foto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((Foto.ValidarSiFotoYaExiste(cand.CodMatricula, comboAlbunes.Text.Trim(), textNameFoto.Text.Trim()) == 0)&& textNameFoto.Text.Trim().CompareTo("") != 0 && textDescripcion.Text.Trim().CompareTo("")!=0)
            {
                Foto fotito = new Foto(cand.CodMatricula, comboAlbunes.Text.Trim(), textNameFoto.Text.Trim(), textDescripcion.Text.Trim(), "");
                fotito.Url = guardarFoto(fotito);
                fotito.aniadirFotoAdb(fotito);
                this.Hide();
                vPrincipal.Show();
            }
            else
                MessageBox.Show("La foto que desea ingresar al sistema, ya existe. Por favor, insertela en otro album o ingrese otra foto", "Reina FIEC-Agregar Foto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /*
		 *	Método: guardarFoto
		 *	===================================================
		 *	Me permite crear una copia de la foto insertada 
         *  y guardarla en el album respectivo de la candidata
		 */
        private string guardarFoto(Foto foto)
        {
            string sTemp = @"..\Candidatas\" + foto.Mat_Candidata + @"\" + foto.Album + @"\"+ foto.Nombre + @".jpg";
            Image tmp;
            try
            {
                Debug.WriteLine("> STEMP: " + sTemp.ToString());
                FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                tmp = Image.FromFile(openFoto.FileName);
                tmp.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                fs.Close();
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("POR FAVOR: Inserte una Foto Antes de Ingresarla al sistema", "Reina FIEC-Agregar Fotos a Candidata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return sTemp;
        }
        /*
		 *	Método: Inicializar
		 *	===================================================
		 *	Me permite Deshabilitar las opciones pertinentes a 
         *  la inserción de fotos hasta que el administrador ha-
         *  ya  seleccionado un album respectivo y ingresado la 
         *  foto.
		 */
        private void Inicializar()
        {
            textNameFoto.Enabled = false;
            textDescripcion.Enabled = false;
            lnkImportar.Enabled = false;
            btnAgregar.Enabled = false;
        }
        /*
		 *	Método: comboAlbunes_SelectedIndexChanged
		 *	===================================================
		 *	Me permite Habilitar las opciones pertinentes a 
         *  la inserción de fotos para que el administrador 
         *  seleccione un album respectivo y ingrese la foto.
		 */
        private void comboAlbunes_SelectedIndexChanged(object sender, EventArgs e)
        {
            textNameFoto.Enabled = true;
            textDescripcion.Enabled = true;
            lnkImportar.Enabled = true;
            btnAgregar.Enabled = true;
        }

    }
}