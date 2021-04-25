
namespace CalcularIMCForms.Views
{
    partial class AddValues
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
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarDni = new System.Windows.Forms.Button();
            this.txtDniBusqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnAgregarValor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPacienteEncontrado = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblDniM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(282, 244);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(155, 20);
            this.txtTalla.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Talla:";
            // 
            // btnBuscarDni
            // 
            this.btnBuscarDni.BackColor = System.Drawing.Color.Teal;
            this.btnBuscarDni.FlatAppearance.BorderSize = 0;
            this.btnBuscarDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDni.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDni.Location = new System.Drawing.Point(378, 17);
            this.btnBuscarDni.Name = "btnBuscarDni";
            this.btnBuscarDni.Size = new System.Drawing.Size(83, 35);
            this.btnBuscarDni.TabIndex = 1;
            this.btnBuscarDni.Text = "Buscar";
            this.btnBuscarDni.UseVisualStyleBackColor = false;
            this.btnBuscarDni.Click += new System.EventHandler(this.btnBuscarDni_Click);
            // 
            // txtDniBusqueda
            // 
            this.txtDniBusqueda.Location = new System.Drawing.Point(201, 25);
            this.txtDniBusqueda.Name = "txtDniBusqueda";
            this.txtDniBusqueda.Size = new System.Drawing.Size(155, 20);
            this.txtDniBusqueda.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ingrese el DNI:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(282, 194);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(155, 20);
            this.txtPeso.TabIndex = 2;
            // 
            // btnAgregarValor
            // 
            this.btnAgregarValor.BackColor = System.Drawing.Color.Teal;
            this.btnAgregarValor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAgregarValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarValor.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarValor.Location = new System.Drawing.Point(0, 385);
            this.btnAgregarValor.Name = "btnAgregarValor";
            this.btnAgregarValor.Size = new System.Drawing.Size(608, 44);
            this.btnAgregarValor.TabIndex = 5;
            this.btnAgregarValor.Text = "Agregar";
            this.btnAgregarValor.UseVisualStyleBackColor = false;
            this.btnAgregarValor.Click += new System.EventHandler(this.btnAgregarPaciente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "Peso:";
            // 
            // lblPacienteEncontrado
            // 
            this.lblPacienteEncontrado.AutoSize = true;
            this.lblPacienteEncontrado.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacienteEncontrado.Location = new System.Drawing.Point(14, 69);
            this.lblPacienteEncontrado.Name = "lblPacienteEncontrado";
            this.lblPacienteEncontrado.Size = new System.Drawing.Size(210, 22);
            this.lblPacienteEncontrado.TabIndex = 33;
            this.lblPacienteEncontrado.Text = "Paciente encontrado:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(282, 296);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(155, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(311, 114);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(60, 22);
            this.lblNombreCompleto.TabIndex = 42;
            this.lblNombreCompleto.Text = "label";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(206, 114);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 22);
            this.lblNombre.TabIndex = 43;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(206, 150);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(50, 22);
            this.lblDni.TabIndex = 45;
            this.lblDni.Text = "DNI:";
            // 
            // lblDniM
            // 
            this.lblDniM.AutoSize = true;
            this.lblDniM.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniM.Location = new System.Drawing.Point(311, 150);
            this.lblDniM.Name = "lblDniM";
            this.lblDniM.Size = new System.Drawing.Size(60, 22);
            this.lblDniM.TabIndex = 44;
            this.lblDniM.Text = "label";
            // 
            // AddValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblDniM);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNombreCompleto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarDni);
            this.Controls.Add(this.txtDniBusqueda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.btnAgregarValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPacienteEncontrado);
            this.Name = "AddValues";
            this.Size = new System.Drawing.Size(608, 429);
            this.Load += new System.EventHandler(this.AddValues_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarDni;
        private System.Windows.Forms.TextBox txtDniBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnAgregarValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPacienteEncontrado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblDniM;
    }
}
