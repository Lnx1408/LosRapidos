﻿
namespace CapaPresentacion
{
    partial class frmConsultarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarCliente));
            this.btnregresar = new System.Windows.Forms.Button();
            this.buttonactualizar = new System.Windows.Forms.Button();
            this.dgv_listarTodos = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_todos = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.Transparent;
            this.btnregresar.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Image = global::CapaPresentacion.Properties.Resources.salir;
            this.btnregresar.Location = new System.Drawing.Point(928, 381);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(115, 60);
            this.btnregresar.TabIndex = 87;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnregresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // buttonactualizar
            // 
            this.buttonactualizar.BackColor = System.Drawing.Color.Transparent;
            this.buttonactualizar.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.buttonactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonactualizar.Image = global::CapaPresentacion.Properties.Resources.editarConductor;
            this.buttonactualizar.Location = new System.Drawing.Point(421, 377);
            this.buttonactualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonactualizar.Name = "buttonactualizar";
            this.buttonactualizar.Size = new System.Drawing.Size(229, 63);
            this.buttonactualizar.TabIndex = 86;
            this.buttonactualizar.Text = "Actualizar Datos";
            this.buttonactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonactualizar.UseVisualStyleBackColor = false;
            // 
            // dgv_listarTodos
            // 
            this.dgv_listarTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listarTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.nombre,
            this.apellido,
            this.edad,
            this.domicilio,
            this.sexo,
            this.imagen,
            this.codigoCliente});
            this.dgv_listarTodos.Location = new System.Drawing.Point(41, 128);
            this.dgv_listarTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_listarTodos.Name = "dgv_listarTodos";
            this.dgv_listarTodos.ReadOnly = true;
            this.dgv_listarTodos.RowHeadersWidth = 51;
            this.dgv_listarTodos.RowTemplate.Height = 24;
            this.dgv_listarTodos.Size = new System.Drawing.Size(1164, 223);
            this.dgv_listarTodos.TabIndex = 85;
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cédula";
            this.cedula.MinimumWidth = 6;
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Width = 95;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombres";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellidos";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 125;
            // 
            // edad
            // 
            this.edad.HeaderText = "Edad";
            this.edad.MinimumWidth = 6;
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            this.edad.Width = 75;
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.MinimumWidth = 6;
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            this.domicilio.Width = 125;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.MinimumWidth = 6;
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Width = 90;
            // 
            // imagen
            // 
            this.imagen.HeaderText = "Ruta de la imagen";
            this.imagen.MinimumWidth = 6;
            this.imagen.Name = "imagen";
            this.imagen.ReadOnly = true;
            this.imagen.Width = 130;
            // 
            // codigoCliente
            // 
            this.codigoCliente.HeaderText = "Codigo Cliente";
            this.codigoCliente.MinimumWidth = 6;
            this.codigoCliente.Name = "codigoCliente";
            this.codigoCliente.ReadOnly = true;
            this.codigoCliente.Width = 125;
            // 
            // btn_todos
            // 
            this.btn_todos.BackColor = System.Drawing.Color.Transparent;
            this.btn_todos.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btn_todos.Location = new System.Drawing.Point(947, 68);
            this.btn_todos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(153, 30);
            this.btn_todos.TabIndex = 84;
            this.btn_todos.Text = "Mostrar Todos";
            this.btn_todos.UseVisualStyleBackColor = false;
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnbuscar.Location = new System.Drawing.Point(588, 64);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(76, 31);
            this.btnbuscar.TabIndex = 83;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(373, 68);
            this.txtcedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(169, 22);
            this.txtcedula.TabIndex = 82;
            this.txtcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedula_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 26);
            this.label1.TabIndex = 81;
            this.label1.Text = "Ingrese el número de Cédula: ";
            // 
            // frmConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1231, 452);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.buttonactualizar);
            this.Controls.Add(this.dgv_listarTodos);
            this.Controls.Add(this.btn_todos);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultarCliente";
            this.Text = "frmConsultarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button buttonactualizar;
        private System.Windows.Forms.DataGridView dgv_listarTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCliente;
        private System.Windows.Forms.Button btn_todos;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label1;
    }
}