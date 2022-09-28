namespace pryMoyaSP2
{
    partial class frmCabañas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCabañas));
            this.mrcTipoCab = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lstPersonas = new System.Windows.Forms.ComboBox();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.lstTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.mrcAdicionales = new System.Windows.Forms.GroupBox();
            this.chkTelevision = new System.Windows.Forms.CheckBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.mrcFormas = new System.Windows.Forms.GroupBox();
            this.lstTarjetas = new System.Windows.Forms.ComboBox();
            this.lblTarjetas = new System.Windows.Forms.Label();
            this.btnTarjeta = new System.Windows.Forms.RadioButton();
            this.btnEfectivo = new System.Windows.Forms.RadioButton();
            this.mrcTitular = new System.Windows.Forms.GroupBox();
            this.txtTelefonosTitular = new System.Windows.Forms.TextBox();
            this.txtNombreTitular = new System.Windows.Forms.TextBox();
            this.lblTelefonos = new System.Windows.Forms.Label();
            this.lblNombreTitular = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.mrcTipoCab.SuspendLayout();
            this.mrcAdicionales.SuspendLayout();
            this.mrcFormas.SuspendLayout();
            this.mrcTitular.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcTipoCab
            // 
            this.mrcTipoCab.Controls.Add(this.txtDias);
            this.mrcTipoCab.Controls.Add(this.lblDias);
            this.mrcTipoCab.Controls.Add(this.lstPersonas);
            this.mrcTipoCab.Controls.Add(this.lblPersonas);
            this.mrcTipoCab.Controls.Add(this.lstTipo);
            this.mrcTipoCab.Controls.Add(this.lblTipo);
            this.mrcTipoCab.Location = new System.Drawing.Point(39, 23);
            this.mrcTipoCab.Name = "mrcTipoCab";
            this.mrcTipoCab.Size = new System.Drawing.Size(704, 129);
            this.mrcTipoCab.TabIndex = 0;
            this.mrcTipoCab.TabStop = false;
            this.mrcTipoCab.Text = "Tipo de Cabañas";
            // 
            // txtDias
            // 
            this.txtDias.Enabled = false;
            this.txtDias.Location = new System.Drawing.Point(546, 70);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 20);
            this.txtDias.TabIndex = 5;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(494, 72);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(28, 13);
            this.lblDias.TabIndex = 4;
            this.lblDias.Text = "Dias";
            // 
            // lstPersonas
            // 
            this.lstPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstPersonas.Enabled = false;
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.Location = new System.Drawing.Point(319, 69);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(121, 21);
            this.lstPersonas.TabIndex = 3;
            this.lstPersonas.SelectedIndexChanged += new System.EventHandler(this.lstPersonas_SelectedIndexChanged);
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(245, 72);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(51, 13);
            this.lblPersonas.TabIndex = 2;
            this.lblPersonas.Text = "Personas";
            // 
            // lstTipo
            // 
            this.lstTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipo.FormattingEnabled = true;
            this.lstTipo.Items.AddRange(new object[] {
            "A",
            "B"});
            this.lstTipo.Location = new System.Drawing.Point(98, 69);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(117, 21);
            this.lstTipo.TabIndex = 1;
            this.lstTipo.SelectedIndexChanged += new System.EventHandler(this.LstTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(54, 72);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // mrcAdicionales
            // 
            this.mrcAdicionales.Controls.Add(this.chkTelevision);
            this.mrcAdicionales.Controls.Add(this.chkHeladera);
            this.mrcAdicionales.Controls.Add(this.chkCocina);
            this.mrcAdicionales.Location = new System.Drawing.Point(39, 176);
            this.mrcAdicionales.Name = "mrcAdicionales";
            this.mrcAdicionales.Size = new System.Drawing.Size(206, 145);
            this.mrcAdicionales.TabIndex = 1;
            this.mrcAdicionales.TabStop = false;
            this.mrcAdicionales.Text = "Adicionales";
            // 
            // chkTelevision
            // 
            this.chkTelevision.AutoSize = true;
            this.chkTelevision.Location = new System.Drawing.Point(28, 77);
            this.chkTelevision.Name = "chkTelevision";
            this.chkTelevision.Size = new System.Drawing.Size(74, 17);
            this.chkTelevision.TabIndex = 2;
            this.chkTelevision.Text = "Televisión";
            this.chkTelevision.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(28, 54);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(69, 17);
            this.chkHeladera.TabIndex = 1;
            this.chkHeladera.Text = "Heladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(28, 30);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(59, 17);
            this.chkCocina.TabIndex = 0;
            this.chkCocina.Text = "Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // mrcFormas
            // 
            this.mrcFormas.Controls.Add(this.lstTarjetas);
            this.mrcFormas.Controls.Add(this.lblTarjetas);
            this.mrcFormas.Controls.Add(this.btnTarjeta);
            this.mrcFormas.Controls.Add(this.btnEfectivo);
            this.mrcFormas.Location = new System.Drawing.Point(278, 176);
            this.mrcFormas.Name = "mrcFormas";
            this.mrcFormas.Size = new System.Drawing.Size(465, 145);
            this.mrcFormas.TabIndex = 2;
            this.mrcFormas.TabStop = false;
            this.mrcFormas.Text = "Forma de pago";
            this.mrcFormas.Enter += new System.EventHandler(this.mrcFormas_Enter);
            // 
            // lstTarjetas
            // 
            this.lstTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTarjetas.FormattingEnabled = true;
            this.lstTarjetas.Items.AddRange(new object[] {
            "Card Red",
            "Card Green",
            "Card Blue"});
            this.lstTarjetas.Location = new System.Drawing.Point(176, 104);
            this.lstTarjetas.Name = "lstTarjetas";
            this.lstTarjetas.Size = new System.Drawing.Size(195, 21);
            this.lstTarjetas.TabIndex = 3;
            this.lstTarjetas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTarjetas
            // 
            this.lblTarjetas.AutoSize = true;
            this.lblTarjetas.Location = new System.Drawing.Point(173, 69);
            this.lblTarjetas.Name = "lblTarjetas";
            this.lblTarjetas.Size = new System.Drawing.Size(45, 13);
            this.lblTarjetas.TabIndex = 2;
            this.lblTarjetas.Text = "Tarjetas";
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.AutoSize = true;
            this.btnTarjeta.Location = new System.Drawing.Point(51, 65);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(58, 17);
            this.btnTarjeta.TabIndex = 1;
            this.btnTarjeta.TabStop = true;
            this.btnTarjeta.Text = "Tarjeta";
            this.btnTarjeta.UseVisualStyleBackColor = true;
            this.btnTarjeta.CheckedChanged += new System.EventHandler(this.BtnTarjeta_CheckedChanged);
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.AutoSize = true;
            this.btnEfectivo.Location = new System.Drawing.Point(51, 29);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(64, 17);
            this.btnEfectivo.TabIndex = 0;
            this.btnEfectivo.TabStop = true;
            this.btnEfectivo.Text = "Efectivo";
            this.btnEfectivo.UseVisualStyleBackColor = true;
            this.btnEfectivo.CheckedChanged += new System.EventHandler(this.BtnEfectivo_CheckedChanged);
            // 
            // mrcTitular
            // 
            this.mrcTitular.Controls.Add(this.txtTelefonosTitular);
            this.mrcTitular.Controls.Add(this.txtNombreTitular);
            this.mrcTitular.Controls.Add(this.lblTelefonos);
            this.mrcTitular.Controls.Add(this.lblNombreTitular);
            this.mrcTitular.Location = new System.Drawing.Point(39, 359);
            this.mrcTitular.Name = "mrcTitular";
            this.mrcTitular.Size = new System.Drawing.Size(704, 100);
            this.mrcTitular.TabIndex = 3;
            this.mrcTitular.TabStop = false;
            this.mrcTitular.Text = "Titular de la reserva";
            // 
            // txtTelefonosTitular
            // 
            this.txtTelefonosTitular.Location = new System.Drawing.Point(152, 68);
            this.txtTelefonosTitular.Name = "txtTelefonosTitular";
            this.txtTelefonosTitular.Size = new System.Drawing.Size(431, 20);
            this.txtTelefonosTitular.TabIndex = 3;
            // 
            // txtNombreTitular
            // 
            this.txtNombreTitular.Location = new System.Drawing.Point(152, 36);
            this.txtNombreTitular.Name = "txtNombreTitular";
            this.txtNombreTitular.Size = new System.Drawing.Size(431, 20);
            this.txtNombreTitular.TabIndex = 2;
            // 
            // lblTelefonos
            // 
            this.lblTelefonos.AutoSize = true;
            this.lblTelefonos.Location = new System.Drawing.Point(25, 68);
            this.lblTelefonos.Name = "lblTelefonos";
            this.lblTelefonos.Size = new System.Drawing.Size(54, 13);
            this.lblTelefonos.TabIndex = 1;
            this.lblTelefonos.Text = "Telefonos";
            // 
            // lblNombreTitular
            // 
            this.lblNombreTitular.AutoSize = true;
            this.lblNombreTitular.Location = new System.Drawing.Point(25, 36);
            this.lblNombreTitular.Name = "lblNombreTitular";
            this.lblNombreTitular.Size = new System.Drawing.Size(44, 13);
            this.lblNombreTitular.TabIndex = 0;
            this.lblNombreTitular.Text = "Nombre";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(668, 497);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmCabañas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 532);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mrcTitular);
            this.Controls.Add(this.mrcFormas);
            this.Controls.Add(this.mrcAdicionales);
            this.Controls.Add(this.mrcTipoCab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCabañas";
            this.Text = "Reserva de Cabañas";
            this.Load += new System.EventHandler(this.frmCabañas_Load);
            this.mrcTipoCab.ResumeLayout(false);
            this.mrcTipoCab.PerformLayout();
            this.mrcAdicionales.ResumeLayout(false);
            this.mrcAdicionales.PerformLayout();
            this.mrcFormas.ResumeLayout(false);
            this.mrcFormas.PerformLayout();
            this.mrcTitular.ResumeLayout(false);
            this.mrcTitular.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcTipoCab;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.ComboBox lstPersonas;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.ComboBox lstTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox mrcAdicionales;
        private System.Windows.Forms.CheckBox chkTelevision;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.GroupBox mrcFormas;
        private System.Windows.Forms.ComboBox lstTarjetas;
        private System.Windows.Forms.Label lblTarjetas;
        private System.Windows.Forms.RadioButton btnTarjeta;
        private System.Windows.Forms.RadioButton btnEfectivo;
        private System.Windows.Forms.GroupBox mrcTitular;
        private System.Windows.Forms.TextBox txtTelefonosTitular;
        private System.Windows.Forms.TextBox txtNombreTitular;
        private System.Windows.Forms.Label lblTelefonos;
        private System.Windows.Forms.Label lblNombreTitular;
        private System.Windows.Forms.Button btnAceptar;
    }
}

