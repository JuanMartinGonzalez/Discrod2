using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Discrod_2.DAL;

namespace Proyecto_Discrod_2.BE
{
    public class BEMensaje
    {
        public string Error { get; set; }
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
                mensajeDal.Error = "Error en la verificacion";
                return false;
            }
        }
        public bool ModificarMensaje(int mensajeId, Mensajes mensaje)
        {
            DAL.MensajeDal mensajeDal = new DAL.MensajeDal();
            try
            {
                return mensajeDal.ModificarMensaje(mensajeId, mensaje);
            }
            catch (Exception)
            {
                mensajeDal.Error = "Error en la modificacion del mensaje";
                return false;
            }
        }
        public int EliminarMensaje(int mensajeId)
        {
            DAL.MensajeDal mensajeDal = new DAL.MensajeDal();
            try
            {
                return mensajeDal.EliminarMensaje(mensajeId);
            }
            catch (Exception ex)
            {
                mensajeDal.Error = "Error en la eliminacion del mensaje" + ex.Message;
                return -1;
            }
        }
        public bool MarcarMensajeComoRecibido(int mensajeId)
        {
            DAL.MensajeDal mensajeDal = new DAL.MensajeDal();
            try
            {
                return mensajeDal.MarcarMensajeComoRecibido(mensajeId);
            }
            catch (Exception)
            {
                mensajeDal.Error = "Error en marcar como leido";
                return false;
            }
        }
        public List<Mensajes> ObtenerMensajesEntreUsuarios(int usuarioOrigenId, int usuarioDestinoId)
        {
            DAL.MensajeDal mensajeDal = new DAL.MensajeDal();
            try
            {
                return mensajeDal.ObtenerMensajesEntreUsuarios(usuarioOrigenId, usuarioDestinoId);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los usuarios: " + ex.Message);
            }

        }
    }
}