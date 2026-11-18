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
            btnLimpiar = new Button();
            btnCalcular = new Button();
            cboSocio = new CheckBox();
            gboTurno = new GroupBox();
            rbtMañana = new RadioButton();
            rbtTarde = new RadioButton();
            lblHoras = new Label();
            tboHoras = new TextBox();
            cboEmbargacion = new ComboBox();
            lblEmbargacion = new Label();
            tboDni = new TextBox();
            tboNombre = new TextBox();
            lblDni = new Label();
            lblNombre = new Label();
            gboImporte = new GroupBox();
            lblTotal2 = new Label();
            lblDescuento2 = new Label();
            lblSubtotal2 = new Label();
            lblTotal = new Label();
            lblDescuento = new Label();
            lblSubtotal = new Label();
            gboDatosCliente.SuspendLayout();
            gboTurno.SuspendLayout();
            gboImporte.SuspendLayout();
            SuspendLayout();
            // 
            // gboDatosCliente
            // 
            gboDatosCliente.Controls.Add(btnLimpiar);
            gboDatosCliente.Controls.Add(btnCalcular);
            gboDatosCliente.Controls.Add(cboSocio);
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
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(183, 276);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(109, 42);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(40, 276);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(109, 42);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // cboSocio
            // 
            cboSocio.AutoSize = true;
            cboSocio.Location = new Point(217, 217);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(76, 19);
            cboSocio.TabIndex = 11;
            cboSocio.Text = "Soy socio";
            cboSocio.UseVisualStyleBackColor = true;
            // 
            // gboTurno
            // 
            gboTurno.Controls.Add(rbtMañana);
            gboTurno.Controls.Add(rbtTarde);
            gboTurno.Location = new Point(6, 195);
            gboTurno.Name = "gboTurno";
            gboTurno.Size = new Size(196, 59);
            gboTurno.TabIndex = 8;
            gboTurno.TabStop = false;
            gboTurno.Text = "Turno";
            // 
            // rbtMañana
            // 
            rbtMañana.AutoSize = true;
            rbtMañana.Location = new Point(22, 22);
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
            rbtTarde.Location = new Point(117, 22);
            rbtTarde.Name = "rbtTarde";
            rbtTarde.Size = new Size(54, 19);
            rbtTarde.TabIndex = 10;
            rbtTarde.TabStop = true;
            rbtTarde.Text = "Tarde";
            rbtTarde.UseVisualStyleBackColor = true;
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
            tboHoras.TextChanged += tboHoras_TextChanged;
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
            cboEmbargacion.SelectedIndexChanged += cboEmbargacion_SelectedIndexChanged;
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
            tboDni.TextChanged += tboDni_TextChanged_1;
            // 
            // tboNombre
            // 
            tboNombre.Location = new Point(102, 37);
            tboNombre.MaxLength = 100;
            tboNombre.Name = "tboNombre";
            tboNombre.Size = new Size(190, 23);
            tboNombre.TabIndex = 2;
            tboNombre.TextChanged += tboNombre_TextChanged;
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
            // gboImporte
            // 
            gboImporte.Controls.Add(lblTotal2);
            gboImporte.Controls.Add(lblDescuento2);
            gboImporte.Controls.Add(lblSubtotal2);
            gboImporte.Controls.Add(lblTotal);
            gboImporte.Controls.Add(lblDescuento);
            gboImporte.Controls.Add(lblSubtotal);
            gboImporte.Location = new Point(12, 374);
            gboImporte.Name = "gboImporte";
            gboImporte.Size = new Size(338, 147);
            gboImporte.TabIndex = 1;
            gboImporte.TabStop = false;
            gboImporte.Text = "Importe";
            // 
            // lblTotal2
            // 
            lblTotal2.AutoSize = true;
            lblTotal2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal2.Location = new Point(123, 107);
            lblTotal2.Name = "lblTotal2";
            lblTotal2.Size = new Size(48, 15);
            lblTotal2.TabIndex = 5;
            lblTotal2.Text = "$ 0 , 00";
            // 
            // lblDescuento2
            // 
            lblDescuento2.AutoSize = true;
            lblDescuento2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescuento2.Location = new Point(123, 72);
            lblDescuento2.Name = "lblDescuento2";
            lblDescuento2.Size = new Size(27, 15);
            lblDescuento2.TabIndex = 4;
            lblDescuento2.Text = "% 0";
            // 
            // lblSubtotal2
            // 
            lblSubtotal2.AutoSize = true;
            lblSubtotal2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal2.Location = new Point(123, 34);
            lblSubtotal2.Name = "lblSubtotal2";
            lblSubtotal2.Size = new Size(47, 15);
            lblSubtotal2.TabIndex = 3;
            lblSubtotal2.Text = "$ 0 , 00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(16, 107);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total:";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(16, 72);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(66, 15);
            lblDescuento.TabIndex = 1;
            lblDescuento.Text = "Descuento:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(16, 34);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(54, 15);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "Subtotal:";
            // 
            // frmAlquileres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 533);
            Controls.Add(gboImporte);
            Controls.Add(gboDatosCliente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAlquileres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Náutica Los Molinos ";
            Load += frmAlquileres_Load;
            gboDatosCliente.ResumeLayout(false);
            gboDatosCliente.PerformLayout();
            gboTurno.ResumeLayout(false);
            gboTurno.PerformLayout();
            gboImporte.ResumeLayout(false);
            gboImporte.PerformLayout();
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
        private CheckBox cboSocio;
        private Button btnLimpiar;
        private Button btnCalcular;
        private GroupBox gboImporte;
        private Label lblTotal;
        private Label lblDescuento;
        private Label lblSubtotal;
        private Label lblTotal2;
        private Label lblDescuento2;
        private Label lblSubtotal2;
    }
}