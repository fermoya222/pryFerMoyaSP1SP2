namespace pryMoyaSP2
{
    partial class FrmCabañas
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
            this.MrcTipoCab = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.LblDias = new System.Windows.Forms.Label();
            this.lstPersonas = new System.Windows.Forms.ComboBox();
            this.LblPersonas = new System.Windows.Forms.Label();
            this.LstTipo = new System.Windows.Forms.ComboBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.MrcAdicionales = new System.Windows.Forms.GroupBox();
            this.chkTelevision = new System.Windows.Forms.CheckBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.MrcFormas = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTarjetas = new System.Windows.Forms.Label();
            this.BtnTarjeta = new System.Windows.Forms.RadioButton();
            this.BtnEfectivo = new System.Windows.Forms.RadioButton();
            this.MrcTitular = new System.Windows.Forms.GroupBox();
            this.txtTelefonosTitular = new System.Windows.Forms.TextBox();
            this.txtNombreTitular = new System.Windows.Forms.TextBox();
            this.lblTelefonos = new System.Windows.Forms.Label();
            this.lblNombreTitular = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.MrcTipoCab.SuspendLayout();
            this.MrcAdicionales.SuspendLayout();
            this.MrcFormas.SuspendLayout();
            this.MrcTitular.SuspendLayout();
            this.SuspendLayout();
            // 
            // MrcTipoCab
            // 
            this.MrcTipoCab.Controls.Add(this.txtDias);
            this.MrcTipoCab.Controls.Add(this.LblDias);
            this.MrcTipoCab.Controls.Add(this.lstPersonas);
            this.MrcTipoCab.Controls.Add(this.LblPersonas);
            this.MrcTipoCab.Controls.Add(this.LstTipo);
            this.MrcTipoCab.Controls.Add(this.LblTipo);
            this.MrcTipoCab.Location = new System.Drawing.Point(39, 23);
            this.MrcTipoCab.Name = "MrcTipoCab";
            this.MrcTipoCab.Size = new System.Drawing.Size(704, 129);
            this.MrcTipoCab.TabIndex = 0;
            this.MrcTipoCab.TabStop = false;
            this.MrcTipoCab.Text = "Tipo de Cabañas";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(546, 70);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 20);
            this.txtDias.TabIndex = 5;
            // 
            // LblDias
            // 
            this.LblDias.AutoSize = true;
            this.LblDias.Location = new System.Drawing.Point(494, 72);
            this.LblDias.Name = "LblDias";
            this.LblDias.Size = new System.Drawing.Size(28, 13);
            this.LblDias.TabIndex = 4;
            this.LblDias.Text = "Dias";
            // 
            // lstPersonas
            // 
            this.lstPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lstPersonas.Location = new System.Drawing.Point(319, 69);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(121, 21);
            this.lstPersonas.TabIndex = 3;
            this.lstPersonas.SelectedIndexChanged += new System.EventHandler(this.lstPersonas_SelectedIndexChanged);
            // 
            // LblPersonas
            // 
            this.LblPersonas.AutoSize = true;
            this.LblPersonas.Location = new System.Drawing.Point(245, 72);
            this.LblPersonas.Name = "LblPersonas";
            this.LblPersonas.Size = new System.Drawing.Size(51, 13);
            this.LblPersonas.TabIndex = 2;
            this.LblPersonas.Text = "Personas";
            // 
            // LstTipo
            // 
            this.LstTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LstTipo.FormattingEnabled = true;
            this.LstTipo.Items.AddRange(new object[] {
            "A",
            "B"});
            this.LstTipo.Location = new System.Drawing.Point(98, 69);
            this.LstTipo.Name = "LstTipo";
            this.LstTipo.Size = new System.Drawing.Size(117, 21);
            this.LstTipo.TabIndex = 1;
            this.LstTipo.SelectedIndexChanged += new System.EventHandler(this.LstTipo_SelectedIndexChanged);
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(54, 72);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(28, 13);
            this.LblTipo.TabIndex = 0;
            this.LblTipo.Text = "Tipo";
            // 
            // MrcAdicionales
            // 
            this.MrcAdicionales.Controls.Add(this.chkTelevision);
            this.MrcAdicionales.Controls.Add(this.chkHeladera);
            this.MrcAdicionales.Controls.Add(this.chkCocina);
            this.MrcAdicionales.Location = new System.Drawing.Point(39, 176);
            this.MrcAdicionales.Name = "MrcAdicionales";
            this.MrcAdicionales.Size = new System.Drawing.Size(206, 145);
            this.MrcAdicionales.TabIndex = 1;
            this.MrcAdicionales.TabStop = false;
            this.MrcAdicionales.Text = "Adicionales";
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
            // MrcFormas
            // 
            this.MrcFormas.Controls.Add(this.comboBox1);
            this.MrcFormas.Controls.Add(this.lblTarjetas);
            this.MrcFormas.Controls.Add(this.BtnTarjeta);
            this.MrcFormas.Controls.Add(this.BtnEfectivo);
            this.MrcFormas.Location = new System.Drawing.Point(278, 176);
            this.MrcFormas.Name = "MrcFormas";
            this.MrcFormas.Size = new System.Drawing.Size(465, 145);
            this.MrcFormas.TabIndex = 2;
            this.MrcFormas.TabStop = false;
            this.MrcFormas.Text = "Forma de pago";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // lblTarjetas
            // 
            this.lblTarjetas.AutoSize = true;
            this.lblTarjetas.Location = new System.Drawing.Point(48, 65);
            this.lblTarjetas.Name = "lblTarjetas";
            this.lblTarjetas.Size = new System.Drawing.Size(45, 13);
            this.lblTarjetas.TabIndex = 2;
            this.lblTarjetas.Text = "Tarjetas";
            // 
            // BtnTarjeta
            // 
            this.BtnTarjeta.AutoSize = true;
            this.BtnTarjeta.Location = new System.Drawing.Point(188, 31);
            this.BtnTarjeta.Name = "BtnTarjeta";
            this.BtnTarjeta.Size = new System.Drawing.Size(58, 17);
            this.BtnTarjeta.TabIndex = 1;
            this.BtnTarjeta.TabStop = true;
            this.BtnTarjeta.Text = "Tarjeta";
            this.BtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // BtnEfectivo
            // 
            this.BtnEfectivo.AutoSize = true;
            this.BtnEfectivo.Location = new System.Drawing.Point(48, 31);
            this.BtnEfectivo.Name = "BtnEfectivo";
            this.BtnEfectivo.Size = new System.Drawing.Size(64, 17);
            this.BtnEfectivo.TabIndex = 0;
            this.BtnEfectivo.TabStop = true;
            this.BtnEfectivo.Text = "Efectivo";
            this.BtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // MrcTitular
            // 
            this.MrcTitular.Controls.Add(this.txtTelefonosTitular);
            this.MrcTitular.Controls.Add(this.txtNombreTitular);
            this.MrcTitular.Controls.Add(this.lblTelefonos);
            this.MrcTitular.Controls.Add(this.lblNombreTitular);
            this.MrcTitular.Location = new System.Drawing.Point(39, 359);
            this.MrcTitular.Name = "MrcTitular";
            this.MrcTitular.Size = new System.Drawing.Size(704, 100);
            this.MrcTitular.TabIndex = 3;
            this.MrcTitular.TabStop = false;
            this.MrcTitular.Text = "Titular de la reserva";
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
            // FrmCabañas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 532);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.MrcTitular);
            this.Controls.Add(this.MrcFormas);
            this.Controls.Add(this.MrcAdicionales);
            this.Controls.Add(this.MrcTipoCab);
            this.Name = "FrmCabañas";
            this.Text = "Reserva de Cabañas";
            this.MrcTipoCab.ResumeLayout(false);
            this.MrcTipoCab.PerformLayout();
            this.MrcAdicionales.ResumeLayout(false);
            this.MrcAdicionales.PerformLayout();
            this.MrcFormas.ResumeLayout(false);
            this.MrcFormas.PerformLayout();
            this.MrcTitular.ResumeLayout(false);
            this.MrcTitular.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MrcTipoCab;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label LblDias;
        private System.Windows.Forms.ComboBox lstPersonas;
        private System.Windows.Forms.Label LblPersonas;
        private System.Windows.Forms.ComboBox LstTipo;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.GroupBox MrcAdicionales;
        private System.Windows.Forms.CheckBox chkTelevision;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.GroupBox MrcFormas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTarjetas;
        private System.Windows.Forms.RadioButton BtnTarjeta;
        private System.Windows.Forms.RadioButton BtnEfectivo;
        private System.Windows.Forms.GroupBox MrcTitular;
        private System.Windows.Forms.TextBox txtTelefonosTitular;
        private System.Windows.Forms.TextBox txtNombreTitular;
        private System.Windows.Forms.Label lblTelefonos;
        private System.Windows.Forms.Label lblNombreTitular;
        private System.Windows.Forms.Button btnAceptar;
    }
}

