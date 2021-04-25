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
    public partial class UpdateUser : UserControl
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            lblNombre.Visible = false;
            lblApellido.Visible = false;
            lblDireccion.Visible = false;
            lblTelefono.Visible = false;
            lblDni.Visible = false;

            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtDireccion.Visible = false;
            txtTelefono.Visible = false;
            txtDNI.Visible = false;
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            Pacientes paciente = ABMPacientes.buscarPacientePorDNI(txtDniBusqueda.Text);
            if (paciente != null)
            {
                lblNombre.Visible = true;
                lblApellido.Visible = true;
                lblDireccion.Visible = true;
                lblDni.Visible = true;
                lblTelefono.Visible = true;

                txtNombre.Visible = true;
                txtApellido.Visible = true;
                txtDireccion.Visible = true;
                txtTelefono.Visible = true;
                txtDNI.Visible = true;

                txtNombre.Text = paciente.Nombre;
                txtApellido.Text = paciente.Apellido;
                txtDireccion.Text = paciente.Direccion;
                txtTelefono.Text = paciente.Telefono;
                txtDNI.Text = paciente.DNI;

                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Paciente no encontrado.");
            }
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
           
            int idEncontrado = ABMPacientes.obtenerIdmedianteDNI(txtDniBusqueda.Text);
            if(idEncontrado != 0)
            {
                Pacientes paciente = new Pacientes
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    DNI = txtDNI.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text
                };
                ABMPacientes.ModificarPaciente(idEncontrado, paciente);
                MessageBox.Show("Datos cambiados con éxito!");
                lblNombre.Visible = false;
                lblApellido.Visible = false;
                lblDireccion.Visible = false;
                lblTelefono.Visible = false;
                lblDni.Visible = false;

                txtNombre.Visible = false;
                txtApellido.Visible = false;
                txtDireccion.Visible = false;
                txtTelefono.Visible = false;
                txtDNI.Visible = false;

                txtDniBusqueda.Focus();

            }
            else
            {
                MessageBox.Show("Hay un problema con el paciente.");
            }
        }
    }
}
