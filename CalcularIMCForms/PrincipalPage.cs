using CalcularIMCForms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIMCForms
{
    public partial class PrincipalPage : Form
    {
        public PrincipalPage()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            AddUser addUserForm = new AddUser();
            addUserForm.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(addUserForm);
        }

        private void PrincipalPage_Load(object sender, EventArgs e)
        {
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            UpdateUser updateUser = new UpdateUser();
            updateUser.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(updateUser);
        }

        private void btnAddPesoYTalla_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            AddValues addValues = new AddValues();
            addValues.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(addValues);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(deleteUser);
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            SeguimientoDelPaciente seguimiento = new SeguimientoDelPaciente();
            seguimiento.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(seguimiento);
        }
    }
}
