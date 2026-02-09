using MODELO;

namespace CONTROLADOR
{
    public class FotoController
    {
        // =========================================
        // GUARDAR FOTO
        // =========================================
        public void GuardarFoto(string codMatricula, string album,
        string nombre, string descripcion, string url)
        {
            // validar si ya existe
            int existe = Foto.ValidarSiFotoYaExiste(codMatricula, album, nombre);


        if (existe > 0)
                throw new System.Exception("La foto ya existe en este álbum");

            Foto fotito = new Foto(codMatricula, album, nombre, descripcion, url);
            fotito.aniadirFotoAdb(fotito);
        }

        // =========================================
        // OBTENER LISTADO DE FOTOS DE UNA CANDIDATA
        // =========================================
        public object[] ObtenerFotos(string codMatricula, string album)
        {
            return Foto.buscarFotosXnumMatricula(codMatricula, album);
        }

        // =========================================
        // OBTENER FOTO ESPECIFICA
        // =========================================
        public Foto ObtenerFoto(string codMatricula, string album, string nombreFoto)
        {
            Foto f = new Foto();
            return f.buscarXnombre(codMatricula, album, nombreFoto);
        }

        // =========================================
        // VALIDAR SI FOTO EXISTE
        // =========================================
        public bool ExisteFoto(string codMatricula, string album, string nombreFoto)
        {
            int existe = Foto.ValidarSiFotoYaExiste(codMatricula, album, nombreFoto);
            return existe > 0;
        }
    }
}
