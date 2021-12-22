﻿using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmGuardarAmbulancia : Form
    {

        ClsAmbulancia Al = new ClsAmbulancia();
        public bool vacio;
        List<Object> lst_ambulancia_tmp;


        public frmGuardarAmbulancia()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public frmGuardarAmbulancia(ClsAmbulancia Al)
        {
            InitializeComponent();
            this.Al = Al;
            this.lst_ambulancia_tmp = Al.listar();

        }


        private void cmdregistrar_Click(object sender, EventArgs e)
        {
            String msj = "";


            try
            {
                Al.Modelo = comboBoxModelo.Text;
                Al.TipoAmbulancia = comboBoxTipo.Text;
                Al.Placa = txtplaca.Text;
                Al.Matricula = txtMatricula.Text;
                Al.FechaActivacion = txtAñoActivacion.Text;
                Al.Estado = comboBoxEstado.Text;
                Al.Observacion = richTextBoxObservacion.Text;


                msj =Al.registrar();
                MessageBox.Show(msj);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
}


        

        private void txtconsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultarAmbulanciacs frmEstCons = new frmConsultarAmbulanciacs(Al);
            frmEstCons.Show();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEliminarAmbulancia frmEliminar = new frmEliminarAmbulancia(Al);
            frmEliminar.Show();

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrinc = new frmPrincipal();
            frmPrinc.Show();
        }

        private void txtAñoActivacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);

       }
        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            else
                if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    
       }
    
}
