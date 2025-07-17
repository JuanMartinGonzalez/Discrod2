using Proyecto_Discrod_2.DAL;
﻿using Microsoft.Data.SqlClient;
using Proyecto_Discrod_2.ESTADO;
using Proyecto_Discrod_2.VAL;

namespace Proyecto_Discrod_2.BE
{
    public class BEUsuario
    {
        public string Error { get; set; }  //variable para almacenar errores, comunicar desde capa BA y DAL
        public int AgregarUsuario(Usuarios usuarios)
        {
            DAL.UsuarioDAL usuarioDAL = new UsuarioDAL();
            try
            {
                return usuarioDAL.AgregarUsuario(usuarios);
            }
            catch (Exception ex)
            {
                Error = "Error al agregar el usuario." + ex;
                return -1; // Return a default value in case of an exception
            }
        }

        public int VerificarLoginUsuario(string nombre, string password)
        { 
            DAL.UsuarioDAL usuarioDAL = new UsuarioDAL();
            try
            {
                if (!usuarioDAL.ExisteUsuario(nombre))
                {
                    Error = "El usuario no existe.";
                    return -1;
                }

                // Aquí deberías tener un método que reciba nombre y password
                if (!usuarioDAL.PasswordCorrecta(nombre, password))
                {
                    Error = "La contraseña es incorrecta.";
                    return -2;
                }

                return 1; // Login correcto
            }
            catch (Exception ex)
            {
                Error = "Error al verificar el usuario: " + ex.Message;
                return -1;
            }
        }


        public List<string> ValidarUsuario(Usuarios usuario)
        {
            var validator = new ValidarUsuario();
            // Validar el usuario usando FluentValidation
            var resultado = validator.Validate(usuario);
            // Si hay errores, los convertimos a una lista de strings
            var errores = resultado.Errors.Select(e => e.ErrorMessage).ToList();

            var usuarioDAL = new UsuarioDAL();
            if (usuarioDAL.ExisteUsuario(usuario.Nombre))
            {
                errores.Add("El nombre de usuario ya está registrado.");
            }
            return errores;
        }

        public List<Usuarios> ObtenerUsuarios()
        {
            //llamamos a la capa DAL para obtener la lista de usuarios
            try
            {
                var lista = UsuarioDAL.ObtenerUsuarios();
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los usuarios: " + ex.Message);
            }
        }

        public Usuarios ObtenerUsuariologueado(string nombre, string password)
        {
            // Llamá a la DAL para que traiga el usuario completo que coincida con nombre y password
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.ObtenerUsuarioLogueado(nombre, password);
        }
    }
}
