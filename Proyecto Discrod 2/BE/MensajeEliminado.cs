using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Discrod_2.BE
{
    public class MensajeEliminado
    {
        public int MensajeID { get; set; }
        public DateTime FechaEliminacion { get; set; }

        public MensajeEliminado(int mensajeId, DateTime fechaEliminacion)
        {
            MensajeID = mensajeId;
            FechaEliminacion = fechaEliminacion;
        }
    }
}
