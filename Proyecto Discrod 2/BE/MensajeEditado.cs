using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Discrod_2.BE
{
    public class MensajeEditado
    {
        public int MensajeId { get; set; }
        public string MensajeOriginal { get; set; }
        public string MensajeNuevo { get; set; }
        public DateTime FechaEdicion { get; set; }
        public MensajeEditado (int mensajeId, string mensajeOriginal, string mensajeNuevo, DateTime fechaEdicion)
        {
            MensajeId = mensajeId;
            MensajeOriginal = mensajeOriginal;
            MensajeNuevo = mensajeNuevo;
            FechaEdicion = fechaEdicion;
        }
    }
}
