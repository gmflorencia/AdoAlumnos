namespace Vista
{
    partial class frmAlumnos
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
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.GbAlta = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblEdad = new System.Windows.Forms.Label();
            this.LblDni = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.GbAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(402, 63);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.Size = new System.Drawing.Size(622, 322);
            this.dgvAlumnos.TabIndex = 18;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);
            // 
            // GbAlta
            // 
            this.GbAlta.Controls.Add(this.txtApellido);
            this.GbAlta.Controls.Add(this.LblApellido);
            this.GbAlta.Controls.Add(this.BtnGuardar);
            this.GbAlta.Controls.Add(this.BtnModificar);
            this.GbAlta.Controls.Add(this.txtEmail);
            this.GbAlta.Controls.Add(this.txtEdad);
            this.GbAlta.Controls.Add(this.txtDni);
            this.GbAlta.Controls.Add(this.txtNombre);
            this.GbAlta.Controls.Add(this.LblEmail);
            this.GbAlta.Controls.Add(this.LblEdad);
            this.GbAlta.Controls.Add(this.LblDni);
            this.GbAlta.Controls.Add(this.LblNombre);
            this.GbAlta.Location = new System.Drawing.Point(12, 63);
            this.GbAlta.Name = "GbAlta";
            this.GbAlta.Size = new System.Drawing.Size(383, 370);
            this.GbAlta.TabIndex = 19;
            this.GbAlta.TabStop = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(119, 81);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(191, 22);
            this.txtApellido.TabIndex = 2;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(6, 81);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(71, 16);
            this.LblApellido.TabIndex = 10;
            this.LblApellido.Text = "APELLIDO";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(30, 299);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(214, 299);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 219);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(119, 173);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(191, 22);
            this.txtEdad.TabIndex = 4;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(119, 131);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(191, 22);
            this.txtDni.TabIndex = 3;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(7, 225);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(46, 16);
            this.LblEmail.TabIndex = 3;
            this.LblEmail.Text = "EMAIL";
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Location = new System.Drawing.Point(7, 173);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(45, 16);
            this.LblEdad.TabIndex = 2;
            this.LblEdad.Text = "EDAD";
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Location = new System.Drawing.Point(7, 131);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(30, 16);
            this.LblDni.TabIndex = 1;
            this.LblDni.Text = "DNI";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(6, 39);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(66, 16);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "NOMBRE";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(512, 402);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 20;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(854, 402);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 21;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 510);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.GbAlta);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "frmAlumnos";
            this.Text = "Alta/Baja/Modificación";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.GbAlta.ResumeLayout(false);
            this.GbAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.GroupBox GbAlta;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label LblApellido;
    }
}

