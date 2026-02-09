/*
 *	Archivo: VentanaCrearAlbunes.cs
 *	Descripcion: Contiene la clase VentanaCrearAlbunes que maneja 
 *               la creación de albunes de Fotos por parte del Ad-
 *               ministrador.
 *	Autor:	 Franklin Parrales
 *	Fecha de creacion: 2007-07-07
 */
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VISTA
{
    public partial class VentanaCrearAlbunes : Form
    {
        VentanaPrincipal vPrincipal;
        Candidata cand = new Candidata();
        /*
         *	Método: VentanaCrearAlbunes
         *	==============================================
         *  Me permite crear una nueva ventana para crear 
         *  un nuevo album de fotos a la candidata selec-
         *  cionada.
         */
        public VentanaCrearAlbunes(VentanaPrincipal vPrincipal)
        {
            this.vPrincipal = vPrincipal;
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(Candidata.getListadoMatriculas());
        }
        /*
         *	Método: comboBox1_SelectedIndexChanged
         *	==============================================
         *  Me permite generar el evento de obtener los da-
         *  tos de la candidata que he seleccionado previa-
         *  mente.
         */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Candidata c = Candidata.buscarXnumMatricula(comboBox1.Text.Trim());
            this.cand = c;
            labelName.Text = c.Nombre;
            labelApe.Text = c.Apellido;
            Debug.WriteLine("\n> FOTO:" + c.Foto.GetType() + "\n");
            if (c.Foto is not string)
                pictureBox1.Load(c.Foto);
            textAlbunes.Lines = Candidata.buscarAlbunesXnumMatricula(c.CodMatricula);
        }

        /*
         *	Método: btnCancelar_Click
         *	==============================
         *	Me permite activar el evento 
         *  para volver a la pantalla pri-
         *  ncipal.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            vPrincipal.Show();
        }

        /*
         *	Método: button2_Click
         *	==============================
         *	Me permite activar el evento 
         *  para crear el album a la can-
         *  didata seleccionada y con el 
         *  nombre seleccionado.
         */
        private void button2_Click(object sender, EventArgs e)
        {
            if (Candidata.ValidarSiYaExisteAlbum(cand.CodMatricula, textNameAlb.Text.Trim()) == 0)
            {
                this.cand.crearDirectorio(cand, textNameAlb.Text.Trim());
                this.Hide();
                vPrincipal.Show();
            }
            else
                MessageBox.Show("El album que desea crear ya existe en el directorio", "Reina FIEC-Crear Album", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}