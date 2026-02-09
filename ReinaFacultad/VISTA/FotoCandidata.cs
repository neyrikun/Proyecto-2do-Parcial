/*
 *	Archivo: FotoCandidata.cs
 *	Descripcion: Contiene la clase FotoCandidata que maneja 
 *               la presentacion de la foto personal de la 
 *               candidata.
 *	Autor:	 Franklin Parrales
 *	Fecha de creacion: 2007-07-07
 */
using MODELO;
using System;
using System.Windows.Forms;

namespace OBJETO_VISTA
{
    public partial class FotoCandidata : PictureBox
    {
        Candidata c;
        /*
         *	Método: FotoCandidata
         *	=======================================
         *	Crea una nueva foto de la candidatas 
         */
        public FotoCandidata(Candidata cand, int columna, int fila)
        {
            #region Maneja Excepcion - Cargar Imagen

            try
            {
                Image = System.Drawing.Image.FromFile(cand.Foto);
            }

            catch (System.Exception)
            {
                Console.WriteLine("Error al cargar la imagen " + cand.Foto);
            }

            #endregion

            Location = new System.Drawing.Point((120 * columna) + 50, (135 * fila) + 100);
            Name = cand.CodMatricula;
            Size = new System.Drawing.Size(106, 90);
            SizeMode = PictureBoxSizeMode.StretchImage;
            BorderStyle = BorderStyle.FixedSingle;
            Cursor = System.Windows.Forms.Cursors.Hand;

            this.c = cand;
        }

        #region Get&Set
        public Candidata C
        {
            set
            {
                this.c = value;
            }

            get
            {
                return (this.c);
            }

        }
        #endregion

    }
}
