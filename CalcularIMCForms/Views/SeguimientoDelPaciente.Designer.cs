
namespace CalcularIMCForms.Views
{
    partial class SeguimientoDelPaciente
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
            this.btnBuscarDni = new System.Windows.Forms.Button();
            this.txtDniBusqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarHistorial = new System.Windows.Forms.Button();
            this.dgvSeguimiento = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguimiento)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarDni
            // 
            this.btnBuscarDni.BackColor = System.Drawing.Color.Teal;
            this.btnBuscarDni.FlatAppearance.BorderSize = 0;
            this.btnBuscarDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDni.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDni.Location = new System.Drawing.Point(471, 18);
            this.btnBuscarDni.Name = "btnBuscarDni";
            this.btnBuscarDni.Size = new System.Drawing.Size(83, 35);
            this.btnBuscarDni.TabIndex = 25;
            this.btnBuscarDni.Text = "Buscar";
            this.btnBuscarDni.UseVisualStyleBackColor = false;
            this.btnBuscarDni.Click += new System.EventHandler(this.btnBuscarDni_Click);
            // 
            // txtDniBusqueda
            // 
            this.txtDniBusqueda.Location = new System.Drawing.Point(279, 24);
            this.txtDniBusqueda.Name = "txtDniBusqueda";
            this.txtDniBusqueda.Size = new System.Drawing.Size(155, 20);
            this.txtDniBusqueda.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ingrese el DNI:";
            // 
            // btnEliminarHistorial
            // 
            this.btnEliminarHistorial.BackColor = System.Drawing.Color.Teal;
            this.btnEliminarHistorial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEliminarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarHistorial.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHistorial.Location = new System.Drawing.Point(0, 420);
            this.btnEliminarHistorial.Name = "btnEliminarHistorial";
            this.btnEliminarHistorial.Size = new System.Drawing.Size(588, 44);
            this.btnEliminarHistorial.TabIndex = 31;
            this.btnEliminarHistorial.Text = "Eliminar Historial";
            this.btnEliminarHistorial.UseVisualStyleBackColor = false;
            this.btnEliminarHistorial.Click += new System.EventHandler(this.btnEliminarHistorial_Click);
            // 
            // dgvSeguimiento
            // 
            this.dgvSeguimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeguimiento.Location = new System.Drawing.Point(3, 83);
            this.dgvSeguimiento.Name = "dgvSeguimiento";
            this.dgvSeguimiento.Size = new System.Drawing.Size(571, 321);
            this.dgvSeguimiento.TabIndex = 37;
            this.dgvSeguimiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeguimiento_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDniBusqueda);
            this.panel1.Controls.Add(this.btnBuscarDni);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 77);
            this.panel1.TabIndex = 38;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SeguimientoDelPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSeguimiento);
            this.Controls.Add(this.btnEliminarHistorial);
            this.Name = "SeguimientoDelPaciente";
            this.Size = new System.Drawing.Size(588, 464);
            this.Load += new System.EventHandler(this.SeguimientoDelPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguimiento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarDni;
        private System.Windows.Forms.TextBox txtDniBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarHistorial;
        private System.Windows.Forms.DataGridView dgvSeguimiento;
        private System.Windows.Forms.Panel panel1;
    }
}
