using System.Collections;
using MODELO;

namespace CONTROLADOR
{
    public class ComentarioController
    {
        // =========================================
        // GUARDAR COMENTARIO
        // =========================================
        public void GuardarComentario(string codMatricula, string usuario, string album,
        string nombFoto, string titulo, string descripcion)
        {
            // validar si ya existe
            int existe = Comentario.ValidarComentario(codMatricula, album, nombFoto, titulo);


        if (existe > 0)
                throw new System.Exception("Ya existe un comentario con ese título en esa foto");

            Comentario c = new Comentario(codMatricula, usuario, album, nombFoto, titulo, descripcion);
            c.guardarComentario(c);
        }

        // =========================================
        // OBTENER TITULOS DE COMENTARIOS DE FOTO
        // =========================================
        public object[] ObtenerTitulosComentarios(Foto foto)
        {
            return Comentario.buscarComentariosXFotos(foto);
        }

        // =========================================
        // OBTENER COMENTARIO POR TITULO
        // =========================================
        public string ObtenerComentarioPorTitulo(Foto foto, string titulo)
        {
            return Comentario.buscarComentarioXFotoAndTitulo(foto, titulo);
        }

        // =========================================
        // GENERAR TOP 5 MAS COMENTADAS
        // =========================================
        public ArrayList GenerarTop5MasComentadas()
        {
            Comentario c = new Comentario();
            return c.generarMasComentareadas();
        }

        // =========================================
        // OBTENER NUMERO COMENTARIOS CANDIDATA
        // =========================================
        public int ObtenerNumeroComentarios(string codMatricula)
        {
            Comentario c = new Comentario();
            return c.obtenerComentarioCandidata(codMatricula);
        }

        // =========================================
        // OBTENER MAS COMENTADA (MATRICULA)
        // =========================================
        public string ObtenerMasComentada()
        {
            Comentario c = new Comentario();
            return c.obtenerMasComentareada();
        }

        // =========================================
        // OBTENER TOP CANDIDATAS OBJETO COMPLETO
        // =========================================
        public ArrayList ObtenerCandidatasMasComentadas()
        {
            Comentario c = new Comentario();
            return c.lCandidatasMasComentareadas();
        }
    }
}
