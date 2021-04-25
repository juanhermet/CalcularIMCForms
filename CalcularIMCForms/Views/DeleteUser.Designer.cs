
namespace CalcularIMCForms.Views
{
    partial class DeleteUser
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
            this.lblDni = new System.Windows.Forms.Label();
            this.btnBuscarDni = new System.Windows.Forms.Button();
            this.txtDniBusqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.lblDniM = new System.Windows.Forms.Label();
            this.lblDireccionM = new System.Windows.Forms.Label();
            this.lblTelefonoM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(153, 190);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(50, 22);
            this.lblDni.TabIndex = 38;
            this.lblDni.Text = "DNI:";
            // 
            // btnBuscarDni
            // 
            this.btnBuscarDni.BackColor = System.Drawing.Color.Teal;
            this.btnBuscarDni.FlatAppearance.BorderSize = 0;
            this.btnBuscarDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDni.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDni.Location = new System.Drawing.Point(437, 24);
            this.btnBuscarDni.Name = "btnBuscarDni";
            this.btnBuscarDni.Size = new System.Drawing.Size(83, 35);
            this.btnBuscarDni.TabIndex = 25;
            this.btnBuscarDni.Text = "Buscar";
            this.btnBuscarDni.UseVisualStyleBackColor = false;
            this.btnBuscarDni.Click += new System.EventHandler(this.btnBuscarDni_Click);
            // 
            // txtDniBusqueda
            // 
            this.txtDniBusqueda.Location = new System.Drawing.Point(260, 32);
            this.txtDniBusqueda.Name = "txtDniBusqueda";
            this.txtDniBusqueda.Size = new System.Drawing.Size(155, 20);
            this.txtDniBusqueda.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ingrese el DNI:";
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.BackColor = System.Drawing.Color.Teal;
            this.btnEliminarPaciente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEliminarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPaciente.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPaciente.Location = new System.Drawing.Point(0, 376);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(563, 44);
            this.btnEliminarPaciente.TabIndex = 31;
            this.btnEliminarPaciente.Text = "Eliminar";
            this.btnEliminarPaciente.UseVisualStyleBackColor = false;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(153, 290);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(100, 22);
            this.lblTelefono.TabIndex = 36;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(153, 239);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(110, 22);
            this.lblDireccion.TabIndex = 35;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(153, 139);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(100, 22);
            this.lblApellido.TabIndex = 34;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(153, 94);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 22);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNombreM
            // 
            this.lblNombreM.AutoSize = true;
            this.lblNombreM.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreM.Location = new System.Drawing.Point(286, 94);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(100, 22);
            this.lblNombreM.TabIndex = 39;
            this.lblNombreM.Text = "lblNombre";
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoM.Location = new System.Drawing.Point(286, 139);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(100, 22);
            this.lblApellidoM.TabIndex = 40;
            this.lblApellidoM.Text = "lblNombre";
            // 
            // lblDniM
            // 
            this.lblDniM.AutoSize = true;
            this.lblDniM.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniM.Location = new System.Drawing.Point(286, 190);
            this.lblDniM.Name = "lblDniM";
            this.lblDniM.Size = new System.Drawing.Size(100, 22);
            this.lblDniM.TabIndex = 41;
            this.lblDniM.Text = "lblNombre";
            // 
            // lblDireccionM
            // 
            this.lblDireccionM.AutoSize = true;
            this.lblDireccionM.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionM.Location = new System.Drawing.Point(286, 239);
            this.lblDireccionM.Name = "lblDireccionM";
            this.lblDireccionM.Size = new System.Drawing.Size(100, 22);
            this.lblDireccionM.TabIndex = 42;
            this.lblDireccionM.Text = "lblNombre";
            // 
            // lblTelefonoM
            // 
            this.lblTelefonoM.AutoSize = true;
            this.lblTelefonoM.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoM.Location = new System.Drawing.Point(286, 290);
            this.lblTelefonoM.Name = "lblTelefonoM";
            this.lblTelefonoM.Size = new System.Drawing.Size(100, 22);
            this.lblTelefonoM.TabIndex = 43;
            this.lblTelefonoM.Text = "lblNombre";
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblTelefonoM);
            this.Controls.Add(this.lblDireccionM);
            this.Controls.Add(this.lblDniM);
            this.Controls.Add(this.lblApellidoM);
            this.Controls.Add(this.lblNombreM);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.btnBuscarDni);
            this.Controls.Add(this.txtDniBusqueda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminarPaciente);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "DeleteUser";
            this.Size = new System.Drawing.Size(563, 420);
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button btnBuscarDni;
        private System.Windows.Forms.TextBox txtDniBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreM;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.Label lblDniM;
        private System.Windows.Forms.Label lblDireccionM;
        private System.Windows.Forms.Label lblTelefonoM;
    }
}
