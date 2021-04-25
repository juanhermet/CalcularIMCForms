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
    public partial class AddValues : UserControl
    {
        public AddValues()
        {
            InitializeComponent();
        }

        private void AddValues_Load(object sender, EventArgs e)
        {
            lblNombreCompleto.Visible = false;
            lblNombre.Visible = false;
            lblDniM.Visible = false;
            lblDni.Visible = false;
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            Pacientes paciente = ABMPacientes.buscarPacientePorDNI(txtDniBusqueda.Text);
            if(paciente != null)
            {
                lblDniM.Visible = true;
                lblDni.Visible = true;
                lblNombre.Visible = true;
                lblNombreCompleto.Visible = true;
                lblNombreCompleto.Text = paciente.Nombre + "," + paciente.Apellido;
                lblDniM.Text = paciente.DNI;
                txtPeso.Focus();
            }
            else
            {
                MessageBox.Show("Paciente no encontrado.");
            }
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPeso.Text) & !string.IsNullOrEmpty(txtTalla.Text) |
                (dtpFecha.Value != null | dtpFecha.Value <= DateTime.Now))
            {
                int idPaciente = ABMPacientes.obtenerIdmedianteDNI(txtDniBusqueda.Text);
                if(idPaciente != 0)
                {
                    Valores valor = new Valores()
                    {
                        Peso = Convert.ToDouble(txtPeso.Text),
                        Talla = Convert.ToDouble(txtTalla.Text),
                        Fecha = dtpFecha.Value,
                        PacienteId = idPaciente
                    };
                    ABMValores.agregarValor(valor);
                    
                    MessageBox.Show("Datos cargados con éxito!");
                    
                    lblNombreCompleto.Visible = false;
                    lblNombre.Visible = false;
                    lblDni.Visible = false;
                    lblDniM.Visible = false;
                    txtPeso.Text = "";
                    txtTalla.Text = "";
                    dtpFecha.Refresh();
                    txtDniBusqueda.Text = "";
                    txtDniBusqueda.Focus();
                }
                else
                {
                    MessageBox.Show("paciente no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("ingrese valores válidos.");
            }
        }
    }
}
