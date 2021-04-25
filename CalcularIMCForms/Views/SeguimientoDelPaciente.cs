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
    public partial class SeguimientoDelPaciente : UserControl
    {
        public SeguimientoDelPaciente()
        {
            InitializeComponent();
        }

        private void SeguimientoDelPaciente_Load(object sender, EventArgs e)
        {
            
            DataGridViewTextBoxColumn columnaPeso = new DataGridViewTextBoxColumn();
            columnaPeso.HeaderText = "Peso";
            columnaPeso.Width = 125;
            columnaPeso.ReadOnly = true;

            DataGridViewTextBoxColumn columnaTalla = new DataGridViewTextBoxColumn();
            columnaTalla.HeaderText = "Talla";
            columnaTalla.Width = 125;
            columnaTalla.ReadOnly = true;

            DataGridViewTextBoxColumn columnaFecha = new DataGridViewTextBoxColumn();
            columnaFecha.HeaderText = "Fecha";
            columnaFecha.Width = 125;
            columnaFecha.ReadOnly = true;

            DataGridViewTextBoxColumn columnaIMC = new DataGridViewTextBoxColumn();
            columnaIMC.HeaderText = "IMC";
            columnaIMC.Width = 125;
            columnaIMC.ReadOnly = true;

            dgvSeguimiento.Columns.Add(columnaPeso);
            dgvSeguimiento.Columns.Add(columnaTalla);
            dgvSeguimiento.Columns.Add(columnaFecha);
            dgvSeguimiento.Columns.Add(columnaIMC);
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDniBusqueda.Text))
            {
                List<Valores> listaValores = ABMValores.obtenerTodosLosValoresDelPaciente(txtDniBusqueda.Text);
                if (listaValores != null)
                {
                    foreach (var item in listaValores)
                    {
                        dgvSeguimiento.Rows.Add(item.Peso,item.Talla,item.Fecha, Math.Round(item.IMC));
                    }
                }
            }
            else
            {
                MessageBox.Show("ingrese un Dni.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSeguimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarHistorial_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿de verdad quieres borrar el historial?","confirmación de eliminado de historial:",MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtDniBusqueda.Text != "")
                {
                    if (ABMPacientes.obtenerIdmedianteDNI(txtDniBusqueda.Text) != 0)
                    {
                        ABMValores.borrarHistorialCompleto(ABMPacientes.obtenerIdmedianteDNI(txtDniBusqueda.Text));
                        List<Valores> listaValores = ABMValores.obtenerTodosLosValoresDelPaciente(txtDniBusqueda.Text);
                        if (listaValores != null)
                        {
                            foreach (var item in listaValores)
                            {
                                dgvSeguimiento.Rows.Add(item.Peso, item.Talla, item.Fecha, Math.Round(item.IMC));
                            }
                        }
                        txtDniBusqueda.Focus();
                    }
                }
            }
        }
    }
}
