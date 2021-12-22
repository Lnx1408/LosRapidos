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
    public partial class frmConsultarAmbulanciacs : Form
    {
      //  frmActualizarEstudiantes frActualizar = new frmActualizarEstudiantes();
        List<Object> lst_ambulancia_tmp;
        ClsAmbulancia Al;
      

        public frmConsultarAmbulanciacs()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        public frmConsultarAmbulanciacs(ClsAmbulancia Al)
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.Al = Al;
            this.lst_ambulancia_tmp = Al.listar();
            bloquear();
            llenar_datagridview_ambulancia();
            buttonactualizar.Enabled = false;

        }

        public void llenar_datagridview_ambulancia()
        {
            dgv_listarTodos.Rows.Clear();
            dgv_listarTodos.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var ambulancia in lst_ambulancia_tmp)
            {
                System.Type type = ambulancia.GetType();

            
                String modelo = (String)type.GetProperty("modelo").GetValue(ambulancia);
                String tipoAmbulancia = (String)type.GetProperty("tipoAmbulancia").GetValue(ambulancia);
                String placa = (String)type.GetProperty("placa").GetValue(ambulancia);
                String matricula = (String)type.GetProperty("matricula").GetValue(ambulancia);
                String fechaActivacion = (String)type.GetProperty("fechaActivacion").GetValue(ambulancia);
                String estado = (String)type.GetProperty("estado").GetValue(ambulancia);
                String observacion = (String)type.GetProperty("observacion").GetValue(ambulancia);


                dgv_listarTodos.Rows.Add(modelo, tipoAmbulancia, placa, matricula, fechaActivacion, estado, observacion);
            }

        }

        public void bloquear()
        {
            textBoxModelo.Enabled = false;
            txtplaca.Enabled = false;
            textBoxTipoAmbulancia.Enabled = false;
            txtMatricula.Enabled = false;
            txtAñoActivacion.Enabled = false;
            textBoxEstado.Enabled = false;
            richTextBoxObservacion.Enabled = false;

        }

        public void limpiar()
        {
            textBoxModelo.Clear();
            txtplaca.Clear();
            textBoxTipoAmbulancia.Clear();
            txtMatricula.Clear();
            txtAñoActivacion.Clear();
            textBoxEstado.Clear();
            richTextBoxObservacion.Clear();
        }

      /*  public void llenarframeActualizar() // cargar datos de un frame a otro 
        {
            frActualizar = new frmActualizarEstudiantes(txtcedula.Text, Al);
            frActualizar.textBoxcedula.Text = textcedula.Text;
            frActualizar.txtnombres.Text = txtnombres.Text;
            frActualizar.txtapellidos.Text = txtapellidos.Text;
            frActualizar.txtedad.Text = txtedad.Text.ToString();
            frActualizar.txtdireccion.Text = txtdireccion.Text;
            frActualizar.txtsemestre.Text = txtsemestre.Text.ToString();
            frActualizar.pictureBox1Actualizar.Image = pictureBox1Consultar.Image;

            if (textsexo.Text.Equals("Masculino"))
            {
                frActualizar.radioButtonMasculino.Text = textsexo.Text.ToString();
                frActualizar.radioButtonMasculino.Select();
            }
            if (textsexo.Text.Equals("Femenino"))
            {

                frActualizar.radioButtonFemenino.Text = textsexo.Text.ToString();
                frActualizar.radioButtonFemenino.Select();
            }

        }
      */
        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGuardarAmbulancia frmEst = new frmGuardarAmbulancia(Al);
            frmEst.Show();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_listarTodos.Rows.Clear();
                dgv_listarTodos.Refresh();
                limpiar();
                lst_ambulancia_tmp = Al.buscar(txtnunplaca.Text);

                foreach (var ambulancia in lst_ambulancia_tmp)
                {
                    if (ambulancia != null)
                    {
                        System.Type type = ambulancia.GetType();

                        String modelo = (String)type.GetProperty("modelo").GetValue(ambulancia);
                        String tipoAmbulancia = (String)type.GetProperty("tipoAmbulancia").GetValue(ambulancia);
                        String placa = (String)type.GetProperty("placa").GetValue(ambulancia);
                        String matricula = (String)type.GetProperty("matricula").GetValue(ambulancia);
                        String fechaActivacion = (String)type.GetProperty("fechaActivacion").GetValue(ambulancia);
                        String estado = (String)type.GetProperty("estado").GetValue(ambulancia);
                        String observacion = (String)type.GetProperty("observacion").GetValue(ambulancia);


                        textBoxModelo.Text = modelo;
                        textBoxTipoAmbulancia.Text = tipoAmbulancia;
                        txtplaca.Text = placa;
                        txtMatricula.Text = matricula;
                        txtAñoActivacion.Text = fechaActivacion;
                        textBoxEstado.Text = estado;
                        richTextBoxObservacion.Text = observacion;

                        dgv_listarTodos.Rows.Add(modelo, tipoAmbulancia, placa, matricula, fechaActivacion, estado, observacion);
                        buttonactualizar.Enabled = true;

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void buttonactualizar_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            buttonactualizar.Enabled = false;
            frActualizar = new frmActualizarEstudiantes(txtcedula.Text, Al);
            llenarframeActualizar();
            frActualizar.Show();*/
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            limpiar();
            this.lst_ambulancia_tmp = Al.listar();
            llenar_datagridview_ambulancia();
            buttonactualizar.Enabled = false;
        }

        private void txtnunplaca_TextChanged(object sender, EventArgs e)
        {
            buttonactualizar.Enabled = false;

        }
    }
}