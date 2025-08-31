namespace Proyecto_Discrod_2.BE
{
    public class Mensajes
    {
        public string Texto { get; set; }
        public DateTime FechaEnvio { get; set; }
        public DateTime FechaLectura { get; set; }
        public int UsuarioOrigen { get; set; }
        public int UsuarioDestino { get; set; }

        public Mensajes(string texto, DateTime fechaEnvio, DateTime fechaLectura, int usuarioOrigen, int usuarioDestino)
        {
            Texto = texto;
            FechaEnvio = fechaEnvio;
            FechaLectura = fechaLectura;
            UsuarioOrigen = usuarioOrigen;
            UsuarioDestino = usuarioDestino;
        }
    }
}