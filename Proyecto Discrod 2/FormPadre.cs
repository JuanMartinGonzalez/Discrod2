﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Discrod_2.FE;

namespace Proyecto_Discrod_2
{
    public partial class FormPadre : Form
    {
        public FormPadre()
        {
            InitializeComponent();
        }
        static string rutaArchivo = "C:\\Instituto80\\Proyecto Discrod2\\Discrod2\\Proyecto Discrod 2\\config\\cadena.txt";
        static SqlConnection conexion = new SqlConnection(ObtenerCadena(rutaArchivo));
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FormRegistro lForm = new FormRegistro();
            lForm.MdiParent = this;
            lForm.Show();
        }
        public static SqlConnection? ObtenerConexion()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void FormPadre_Load(object sender, EventArgs e)
        {
            ObtenerConexion();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistro lForm = new FormRegistro();
            lForm.MdiParent = this;
            lForm.Show();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngreso lForm1 = new FormIngreso();
            lForm1.MdiParent = this;
            lForm1.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActualizar lForm2 = new FormActualizar();
            lForm2.MdiParent = this;
            lForm2.Show();
        }
        public static string ObtenerCadena(string rutaArchivo)
        {
            try
            {
                if (System.IO.File.Exists(rutaArchivo))
                {
                    return System.IO.File.ReadAllText(rutaArchivo);
                }
                else
                {
                    MessageBox.Show("El archivo no existe: " + rutaArchivo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

    }
}
