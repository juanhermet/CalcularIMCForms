using CalcularIMCForms.Data;
using CalcularIMCForms.DataBusiness;
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
    public partial class DeleteUser : UserControl
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            lblNombre.Visible = false;
            lblApellido.Visible = false;
            lblDireccion.Visible = false;
            lblTelefono.Visible = false;
            lblDni.Visible = false;

            lblNombreM.Visible = false;
            lblApellidoM.Visible = false;
            lblDireccionM.Visible = false;
            lblTelefonoM.Visible = false;
            lblDniM.Visible = false;
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            Pacientes paciente = ABMPacientes.buscarPacientePorDNI(txtDniBusqueda.Text);
            if (paciente.Id != 0)
            {
                lblNombre.Visible = true;
                lblApellido.Visible = true;
                lblDireccion.Visible = true;
                lblDni.Visible = true;
                lblTelefono.Visible = true;

                lblNombreM.Visible = true;
                lblApellidoM.Visible = true;
                lblDireccionM.Visible = true;
                lblTelefonoM.Visible = true;
                lblDniM.Visible = true;

                lblNombreM.Text = paciente.Nombre;
                lblApellidoM.Text = paciente.Apellido;
                lblDireccionM.Text = paciente.Direccion;
                lblTelefonoM.Text = paciente.Telefono;
                lblDniM.Text = paciente.DNI;

            }
            else
            {
                MessageBox.Show("Paciente no encontrado.");
            }
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que desea eliminar este Paciente?", "Eliminar Paciente:",MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
            {
                int idEncontrado = ABMPacientes.obtenerIdmedianteDNI(txtDniBusqueda.Text);
                if (idEncontrado != 0)
                {

                    ABMValores.borrarHistorialCompleto(idEncontrado);
                    ABMPacientes.BorrarPaciente(idEncontrado);
                    
                    MessageBox.Show("El usaurio se eliminó con éxito!");
                    lblNombre.Visible = false;
                    lblApellido.Visible = false;
                    lblDireccion.Visible = false;
                    lblTelefono.Visible = false;
                    lblDni.Visible = false;

                    lblNombreM.Visible = false;
                    lblApellidoM.Visible = false;
                    lblDireccionM.Visible = false;
                    lblTelefonoM.Visible = false;
                    lblDniM.Visible = false;

                    txtDniBusqueda.Focus();
                }
            }
        }
    }
}
