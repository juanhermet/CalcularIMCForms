
namespace CalcularIMCForms
{
    partial class PrincipalPage
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLateralIzquierdo = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSeguimiento = new System.Windows.Forms.Button();
            this.btnAddPesoYTalla = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlLateralIzquierdo.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLateralIzquierdo
            // 
            this.pnlLateralIzquierdo.Controls.Add(this.btnEliminar);
            this.pnlLateralIzquierdo.Controls.Add(this.btnModificar);
            this.pnlLateralIzquierdo.Controls.Add(this.btnSeguimiento);
            this.pnlLateralIzquierdo.Controls.Add(this.btnAddPesoYTalla);
            this.pnlLateralIzquierdo.Controls.Add(this.btnAgregar);
            this.pnlLateralIzquierdo.Controls.Add(this.panel3);
            this.pnlLateralIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateralIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnlLateralIzquierdo.Name = "pnlLateralIzquierdo";
            this.pnlLateralIzquierdo.Size = new System.Drawing.Size(220, 450);
            this.pnlLateralIzquierdo.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Aqua;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(0, 297);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(220, 78);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar Paciente";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSeguimiento
            // 
            this.btnSeguimiento.BackColor = System.Drawing.Color.Aqua;
            this.btnSeguimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeguimiento.FlatAppearance.BorderSize = 0;
            this.btnSeguimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguimiento.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguimiento.Location = new System.Drawing.Point(0, 222);
            this.btnSeguimiento.Name = "btnSeguimiento";
            this.btnSeguimiento.Size = new System.Drawing.Size(220, 75);
            this.btnSeguimiento.TabIndex = 8;
            this.btnSeguimiento.Text = "Seguimiento del Paciente";
            this.btnSeguimiento.UseVisualStyleBackColor = false;
            this.btnSeguimiento.Click += new System.EventHandler(this.btnSeguimiento_Click);
            // 
            // btnAddPesoYTalla
            // 
            this.btnAddPesoYTalla.BackColor = System.Drawing.Color.Aqua;
            this.btnAddPesoYTalla.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddPesoYTalla.FlatAppearance.BorderSize = 0;
            this.btnAddPesoYTalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPesoYTalla.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPesoYTalla.Location = new System.Drawing.Point(0, 136);
            this.btnAddPesoYTalla.Name = "btnAddPesoYTalla";
            this.btnAddPesoYTalla.Size = new System.Drawing.Size(220, 86);
            this.btnAddPesoYTalla.TabIndex = 7;
            this.btnAddPesoYTalla.Text = "Agregar peso y talla del Paciente";
            this.btnAddPesoYTalla.UseVisualStyleBackColor = false;
            this.btnAddPesoYTalla.Click += new System.EventHandler(this.btnAddPesoYTalla_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Aqua;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(0, 60);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(220, 76);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar Paciente";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.panel4);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(220, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(580, 450);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Aqua;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(0, 375);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(220, 75);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar Paciente";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 60);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(580, 100);
            this.panel4.TabIndex = 0;
            // 
            // PrincipalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlLateralIzquierdo);
            this.Name = "PrincipalPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PrincipalPage_Load);
            this.pnlLateralIzquierdo.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLateralIzquierdo;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSeguimiento;
        private System.Windows.Forms.Button btnAddPesoYTalla;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

