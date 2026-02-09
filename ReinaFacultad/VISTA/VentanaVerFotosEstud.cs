/*
 *	Archivo: VentanaVerFotosEstud.cs
 *	Descripcion: Contiene la clase VentanaVerFotosEstud que maneja 
 *               la visualizacion de las fotos de las candidatas
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
    public partial class VentanaVerFotosEstud : Form
    {
        VentanaEstudiante vEstud;
        Candidata cand;
        Foto fotito = new Foto();
        /*
        *	Método: VentanaVerFotosEstud
        *	==================
        *	Me permite crear un nuevo objeto de la clase 
        *   VentanaVerFotosEstud que me permitirá visua-
        *   lizar las fotos de las candidatas a los est-
        *   udiantes 
        */
        public VentanaVerFotosEstud(VentanaEstudiante vEstud, Candidata cand)
        {
            this.vEstud = vEstud;
            this.cand = cand;
            InitializeComponent();
            comboAlbunes.Items.Clear();
            comboAlbunes.Enabled = true;
            comboFotos.Enabled = false;
            comboComent.Enabled = false;
            llenarDatos();
        }
        /*
         *	Método: llenarDatos
         *	==================
         *	Me llena los datos de la candidata seleccionada
         */
        private void llenarDatos()
        {
            if (cand.Foto is not string)
                pictureFoto.Load(cand.Foto);
            labelMat.Text = cand.CodMatricula;
            labelName.Text = cand.Nombre;
            labelApell.Text = cand.Apellido;
            comboAlbunes.Items.AddRange(Candidata.buscarAlbunesXnumMatricula2(cand.CodMatricula));
            if (comboAlbunes.Items.Count == 0)
            {
                string stemp = "No hay Albunes Creados";
                comboAlbunes.Items.Add((object)stemp);
                comboAlbunes.Enabled = false;
            }
            labelDescrip.Text = "Seleccione un Album y una Foto";
        }
        /*
         *	Método: btn_Salir_Click
         *	==================
         *	Me permite manejar el evento de salir de 
         *  esta opción.
         */
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            vEstud.Show();
        }
        /*
         *	Método: btnVerFotos_Click
         *	==================
         *	Me permite manejar el evento de visualizar 
         *  y cargar la foto seleccionada de la candi-
         *  data.
         */
        private void btnVerFotos_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /*
         *	Método: comboAlbunes_SelectedIndexChanged
         *	==========================================
         *	Me permite manejar el evento de visualizar 
         *  las fotos existentes de la candidata en su
         *  respectivo album.
         */
        private void comboAlbunes_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboFotos.Items.Clear();
            comboFotos.Items.AddRange(Foto.buscarFotosXnumMatricula(this.cand.CodMatricula, comboAlbunes.Text.Trim()));
            comboFotos.Enabled = true;
        }
        /*
         *	Método: comboFotos_SelectedIndexChanged
         *	==========================================
         *	Me permite manejar el evento de visualizar 
         *  los comentarios a la foto seleccionada.
         */
        private void comboFotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboComent.Items.Clear();
            fotito = fotito.buscarXnombre(cand.CodMatricula, comboAlbunes.Text.Trim(), comboFotos.Text.Trim());
            pictureFoto.Load(fotito.Url);
            labelDescrip.Text = fotito.Descripcion;
            comboComent.Enabled = true;
            comboComent.Items.AddRange(Comentario.buscarComentariosXFotos(fotito));
            labelComent.Text = "Seleccione un Comentario";
            if (comboComent.Items.Count == 0)
            {
                comboComent.Enabled = false;
                labelComent.Text = "No hay comentarios creados para esta foto";
            }
            lnkImportar.Enabled = true;

        }
        /*
         *	Método: lnkImportar_LinkClicked
         *	==========================================
         *	Me permite manejar el evento de agregar un 
         *  comentario a la foto seleccionada.
         */
        private void lnkImportar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VentanaAgregarComentario vCom = new VentanaAgregarComentario(fotito, cand, vEstud);
            this.Dispose();
            vCom.Show();
        }
        /*
         *	Método: comboComent_SelectedIndexChanged
         *	==========================================
         *	Me presenta el comentario seleccionado re-
         *  ferente a la foto tambien seleccionada
         */
        private void comboComent_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelComent.Text = Comentario.buscarComentarioXFotoAndTitulo(fotito,comboComent.Text.Trim());
        }

    }
}