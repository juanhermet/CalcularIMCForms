using CalcularIMCForms.Data;
using CalcularIMCForms.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIMCForms.Views
{
    public partial class AddUser : UserControl
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombre.Text)& !string.IsNullOrEmpty(txtApellido.Text)&
                !string.IsNullOrEmpty(txtDireccion.Text)& !string.IsNullOrEmpty(txtDNI.Text)&
                !string.IsNullOrEmpty(txtTelefono.Text))
            {
                Pacientes paciente = new Pacientes()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    DNI = txtDNI.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text
                };
                ABMPacientes.agregarPaciente(paciente);
                MessageBox.Show("datos cargados con éxito!");
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDNI.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese todos los valores.");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
