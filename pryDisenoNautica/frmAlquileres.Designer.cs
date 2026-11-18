namespace pryDisenoNautica
{
    partial class frmAlquileres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gboDatosCliente = new GroupBox();
            lblHoras = new Label();
            tboHoras = new TextBox();
            cboEmbargacion = new ComboBox();
            lblEmbargacion = new Label();
            tboDni = new TextBox();
            tboNombre = new TextBox();
            lblDni = new Label();
            lblNombre = new Label();
            gboTurno = new GroupBox();
            rbtMañana = new RadioButton();
            rbtTarde = new RadioButton();
            gboDatosCliente.SuspendLayout();
            gboTurno.SuspendLayout();
            SuspendLayout();
            // 
            // gboDatosCliente
            // 
            gboDatosCliente.Controls.Add(gboTurno);
            gboDatosCliente.Controls.Add(lblHoras);
            gboDatosCliente.Controls.Add(tboHoras);
            gboDatosCliente.Controls.Add(cboEmbargacion);
            gboDatosCliente.Controls.Add(lblEmbargacion);
            gboDatosCliente.Controls.Add(tboDni);
            gboDatosCliente.Controls.Add(tboNombre);
            gboDatosCliente.Controls.Add(lblDni);
            gboDatosCliente.Controls.Add(lblNombre);
            gboDatosCliente.Location = new Point(12, 12);
            gboDatosCliente.Name = "gboDatosCliente";
            gboDatosCliente.Size = new Size(338, 347);
            gboDatosCliente.TabIndex = 0;
            gboDatosCliente.TabStop = false;
            gboDatosCliente.Text = "Datos cliente";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(16, 156);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(41, 15);
            lblHoras.TabIndex = 7;
            lblHoras.Text = "Horas:";
            // 
            // tboHoras
            // 
            tboHoras.Location = new Point(102, 153);
            tboHoras.MaxLength = 1;
            tboHoras.Name = "tboHoras";
            tboHoras.Size = new Size(100, 23);
            tboHoras.TabIndex = 6;
            // 
            // cboEmbargacion
            // 
            cboEmbargacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmbargacion.FormattingEnabled = true;
            cboEmbargacion.Items.AddRange(new object[] { "Kayak simple", "Kayak doble", "Tabla SUP" });
            cboEmbargacion.Location = new Point(102, 112);
            cboEmbargacion.Name = "cboEmbargacion";
            cboEmbargacion.Size = new Size(191, 23);
            cboEmbargacion.TabIndex = 5;
            // 
            // lblEmbargacion
            // 
            lblEmbargacion.AutoSize = true;
            lblEmbargacion.Location = new Point(16, 115);
            lblEmbargacion.Name = "lblEmbargacion";
            lblEmbargacion.Size = new Size(80, 15);
            lblEmbargacion.TabIndex = 4;
            lblEmbargacion.Text = "Embargación:";
            // 
            // tboDni
            // 
            tboDni.Location = new Point(102, 74);
            tboDni.MaxLength = 8;
            tboDni.Name = "tboDni";
            tboDni.Size = new Size(147, 23);
            tboDni.TabIndex = 3;
            // 
            // tboNombre
            // 
            tboNombre.Location = new Point(102, 37);
            tboNombre.MaxLength = 100;
            tboNombre.Name = "tboNombre";
            tboNombre.Size = new Size(190, 23);
            tboNombre.TabIndex = 2;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(16, 77);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 1;
            lblDni.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(16, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // gboTurno
            // 
            gboTurno.Controls.Add(rbtMañana);
            gboTurno.Controls.Add(rbtTarde);
            gboTurno.Location = new Point(6, 195);
            gboTurno.Name = "gboTurno";
            gboTurno.Size = new Size(233, 59);
            gboTurno.TabIndex = 8;
            gboTurno.TabStop = false;
            gboTurno.Text = "Turno";
            // 
            // rbtMañana
            // 
            rbtMañana.AutoSize = true;
            rbtMañana.Location = new Point(10, 22);
            rbtMañana.Name = "rbtMañana";
            rbtMañana.Size = new Size(68, 19);
            rbtMañana.TabIndex = 9;
            rbtMañana.TabStop = true;
            rbtMañana.Text = "Mañana";
            rbtMañana.UseVisualStyleBackColor = true;
            // 
            // rbtTarde
            // 
            rbtTarde.AutoSize = true;
            rbtTarde.Location = new Point(122, 22);
            rbtTarde.Name = "rbtTarde";
            rbtTarde.Size = new Size(54, 19);
            rbtTarde.TabIndex = 10;
            rbtTarde.TabStop = true;
            rbtTarde.Text = "Tarde";
            rbtTarde.UseVisualStyleBackColor = true;
            // 
            // frmAlquileres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 371);
            Controls.Add(gboDatosCliente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAlquileres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAlquileres";
            Load += frmAlquileres_Load;
            gboDatosCliente.ResumeLayout(false);
            gboDatosCliente.PerformLayout();
            gboTurno.ResumeLayout(false);
            gboTurno.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboDatosCliente;
        private TextBox tboDni;
        private TextBox tboNombre;
        private Label lblDni;
        private Label lblNombre;
        private ComboBox cboEmbargacion;
        private Label lblEmbargacion;
        private TextBox tboHoras;
        private Label lblHoras;
        private GroupBox gboTurno;
        private RadioButton rbtMañana;
        private RadioButton rbtTarde;
    }
}