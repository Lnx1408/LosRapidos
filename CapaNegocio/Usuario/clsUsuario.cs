﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Usuario;

namespace CapaNegocio.Usuario
{
    public class clsUsuario
    {
        String nombre;
        String apellido;
        String cedula;
        String correo;
        String password;
        String rutaImagen;


        /* Constructor parametrizado*/
        public clsUsuario(String nombre, String apellido, String cedula, String correo, String password, String rutaImagen)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.correo = correo;
            this.password = password;
            this.rutaImagen = rutaImagen;
        }
        public clsUsuario()
        {

        }


        /* --------------- Getters y Setters ------------------------- */
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public String RutaImagen
        {
            get { return rutaImagen; }
            set { rutaImagen = value; }
        }

        /* -------------------------- Metodos ---------------------- */
        ClsManejador manejadorUsuario = new ClsManejador();

        public String registrarUsuario()
        {
            List<clsParametrosUsuario> lstUsuarios = new List<clsParametrosUsuario>();

                lstUsuarios.Add(new clsParametrosUsuario(Nombre, Apellido, Cedula, Correo,Password, RutaImagen));
            
            return manejadorUsuario.RegistrarUsuario(lstUsuarios); ;
        }

    }




}
