namespace Proyecto_Discrod_2.BE
{
    public class Mensajes
    {
        public string Texto { get; set; }
        public DateTime FechaEnvio { get; set; }
        public DateTime FechaLectura { get; set; }
        public Usuarios UsuarioOrigen { get; set; }
        public Usuarios UsuarioDestino { get; set; }

        public Mensajes(string texto, DateTime fechaEnvio, DateTime fechaLectura, Usuarios usuarioOrigen, Usuarios usuarioDestino)
        {
            Texto = texto;
            FechaEnvio = fechaEnvio;
            FechaLectura = fechaLectura;
            UsuarioOrigen = usuarioOrigen;
            UsuarioDestino = usuarioDestino;
        }
    }
}