using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Discrod_2.BE
{
    public class BEMensaje
    {
        public int AgregarMensaje(Mensajes mensaje)
        {
            DAL.MensajeDal mensajeDAL = new DAL.MensajeDal();
            try
            {
                // Llamo al método de la capa DAL para agregar el mensaje
                return mensajeDAL.AgregarMensaje(mensaje);
            }
            catch (Exception ex)
            {
                mensajeDAL.Error = "Error al agregar el mensaje: " + ex.Message;
                return -1; // Retorno un valor por defecto en caso de error
            }
        }
        public bool ExisteMensaje(int mensajeId)
        {
            DAL.MensajeDal mensajeDal = new DAL.MensajeDal();
            try
            {
                return mensajeDal.ExisteMensaje(mensajeId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}