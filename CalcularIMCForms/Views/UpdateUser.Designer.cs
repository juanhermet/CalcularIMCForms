
namespace CalcularIMCForms.Views
{
    partial class UpdateUser
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnModificarPaciente = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDniBusqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarDni = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(227, 249);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(155, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(227, 209);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(155, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(227, 137);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(155, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(227, 103);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // btnModificarPaciente
            // 
            this.btnModificarPaciente.BackColor = System.Drawing.Color.Teal;
            this.btnModificarPaciente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnModificarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPaciente.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPaciente.Location = new System.Drawing.Point(0, 334);
            this.btnModificarPaciente.Name = "btnModificarPaciente";
            this.btnModificarPaciente.Size = new System.Drawing.Size(521, 44);
            this.btnModificarPaciente.TabIndex = 7;
            this.btnModificarPaciente.Text = "Modificar";
            this.btnModificarPaciente.UseVisualStyleBackColor = false;
            this.btnModificarPaciente.Click += new System.EventHandler(this.btnAgregarPaciente_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(90, 246);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(100, 22);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(90, 206);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(110, 22);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(90, 134);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(100, 22);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(90, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 22);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDniBusqueda
            // 
            this.txtDniBusqueda.Location = new System.Drawing.Point(227, 41);
            this.txtDniBusqueda.Name = "txtDniBusqueda";
            this.txtDniBusqueda.Size = new System.Drawing.Size(155, 20);
            this.txtDniBusqueda.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ingrese el DNI:";
            // 
            // btnBuscarDni
            // 
            this.btnBuscarDni.BackColor = System.Drawing.Color.Teal;
            this.btnBuscarDni.FlatAppearance.BorderSize = 0;
            this.btnBuscarDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDni.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDni.Location = new System.Drawing.Point(404, 33);
            this.btnBuscarDni.Name = "btnBuscarDni";
            this.btnBuscarDni.Size = new System.Drawing.Size(83, 35);
            this.btnBuscarDni.TabIndex = 1;
            this.btnBuscarDni.Text = "Buscar";
            this.btnBuscarDni.UseVisualStyleBackColor = false;
            this.btnBuscarDni.Click += new System.EventHandler(this.btnBuscarDni_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(227, 175);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(155, 20);
            this.txtDNI.TabIndex = 4;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(90, 172);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(50, 22);
            this.lblDni.TabIndex = 23;
            this.lblDni.Text = "DNI:";
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.btnBuscarDni);
            this.Controls.Add(this.txtDniBusqueda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnModificarPaciente);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "UpdateUser";
            this.Size = new System.Drawing.Size(521, 378);
            this.Load += new System.EventHandler(this.UpdateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnModificarPaciente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDniBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarDni;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDni;
    }
}
