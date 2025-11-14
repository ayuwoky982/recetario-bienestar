namespace WindowsFormsApp17
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel2 = new System.Windows.Forms.Panel();
            this.picVerContra = new System.Windows.Forms.PictureBox();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.lblGuarCamb = new System.Windows.Forms.Label();
            this.cboTipoDiab = new System.Windows.Forms.ComboBox();
            this.cboTienesDiab = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.Kg = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCalcularIMC = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblModUsuario = new System.Windows.Forms.Label();
            this.lblFavoritos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerContra)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.picVerContra);
            this.panel2.Controls.Add(this.lblCancelar);
            this.panel2.Controls.Add(this.lblGuarCamb);
            this.panel2.Controls.Add(this.cboTipoDiab);
            this.panel2.Controls.Add(this.cboTienesDiab);
            this.panel2.Controls.Add(this.txtEdad);
            this.panel2.Controls.Add(this.txtPeso);
            this.panel2.Controls.Add(this.txtContraseña);
            this.panel2.Controls.Add(this.Kg);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblNombreUsuario);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 434);
            this.panel2.TabIndex = 3;
            // 
            // picVerContra
            // 
            this.picVerContra.Image = global::WindowsFormsApp17.Properties.Resources.ojo;
            this.picVerContra.Location = new System.Drawing.Point(764, 111);
            this.picVerContra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picVerContra.Name = "picVerContra";
            this.picVerContra.Size = new System.Drawing.Size(32, 20);
            this.picVerContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVerContra.TabIndex = 27;
            this.picVerContra.TabStop = false;
            this.picVerContra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picVerContra_MouseDown);
            this.picVerContra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picVerContra_MouseUp);
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCancelar.Location = new System.Drawing.Point(708, 340);
            this.lblCancelar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(173, 40);
            this.lblCancelar.TabIndex = 23;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.Visible = false;
            this.lblCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
            // 
            // lblGuarCamb
            // 
            this.lblGuarCamb.AutoSize = true;
            this.lblGuarCamb.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuarCamb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblGuarCamb.Location = new System.Drawing.Point(480, 321);
            this.lblGuarCamb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuarCamb.Name = "lblGuarCamb";
            this.lblGuarCamb.Size = new System.Drawing.Size(162, 80);
            this.lblGuarCamb.TabIndex = 22;
            this.lblGuarCamb.Text = "Guardar\r\ncambios";
            this.lblGuarCamb.Visible = false;
            this.lblGuarCamb.Click += new System.EventHandler(this.lblGuarCamb_Click);
            // 
            // cboTipoDiab
            // 
            this.cboTipoDiab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDiab.Enabled = false;
            this.cboTipoDiab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDiab.FormattingEnabled = true;
            this.cboTipoDiab.Items.AddRange(new object[] {
            "Tipo 1",
            "Tipo 2",
            "Tipo 3"});
            this.cboTipoDiab.Location = new System.Drawing.Point(841, 252);
            this.cboTipoDiab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTipoDiab.Name = "cboTipoDiab";
            this.cboTipoDiab.Size = new System.Drawing.Size(179, 33);
            this.cboTipoDiab.TabIndex = 21;
            // 
            // cboTienesDiab
            // 
            this.cboTienesDiab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTienesDiab.Enabled = false;
            this.cboTienesDiab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTienesDiab.FormattingEnabled = true;
            this.cboTienesDiab.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboTienesDiab.Location = new System.Drawing.Point(581, 251);
            this.cboTienesDiab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTienesDiab.Name = "cboTienesDiab";
            this.cboTienesDiab.Size = new System.Drawing.Size(179, 33);
            this.cboTienesDiab.TabIndex = 20;
            this.cboTienesDiab.SelectedIndexChanged += new System.EventHandler(this.cboTienesDiab_SelectedIndexChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(340, 252);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(171, 29);
            this.txtEdad.TabIndex = 19;
            // 
            // txtPeso
            // 
            this.txtPeso.Enabled = false;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(840, 106);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(131, 29);
            this.txtPeso.TabIndex = 18;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(587, 106);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(171, 29);
            this.txtContraseña.TabIndex = 17;
            // 
            // Kg
            // 
            this.Kg.AutoSize = true;
            this.Kg.BackColor = System.Drawing.Color.White;
            this.Kg.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kg.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Kg.Location = new System.Drawing.Point(972, 103);
            this.Kg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kg.Name = "Kg";
            this.Kg.Size = new System.Drawing.Size(56, 36);
            this.Kg.TabIndex = 16;
            this.Kg.Text = "Kg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(861, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 40);
            this.label11.TabIndex = 15;
            this.label11.Text = "Peso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(847, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 80);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tipo de\r\ndiabetes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(573, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 80);
            this.label9.TabIndex = 13;
            this.label9.Text = " ¿Tienes \r\ndiabetes?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(561, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 40);
            this.label8.TabIndex = 12;
            this.label8.Text = "Contraseña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(369, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 40);
            this.label7.TabIndex = 11;
            this.label7.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(363, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "Usuario";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNombreUsuario.Location = new System.Drawing.Point(372, 106);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(132, 36);
            this.lblNombreUsuario.TabIndex = 5;
            this.lblNombreUsuario.Text = "usuario";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.panel3.Controls.Add(this.lblCalcularIMC);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lblModUsuario);
            this.panel3.Controls.Add(this.lblFavoritos);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 434);
            this.panel3.TabIndex = 3;
            // 
            // lblCalcularIMC
            // 
            this.lblCalcularIMC.AutoSize = true;
            this.lblCalcularIMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.lblCalcularIMC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCalcularIMC.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcularIMC.ForeColor = System.Drawing.Color.White;
            this.lblCalcularIMC.Location = new System.Drawing.Point(8, 172);
            this.lblCalcularIMC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalcularIMC.Name = "lblCalcularIMC";
            this.lblCalcularIMC.Size = new System.Drawing.Size(293, 90);
            this.lblCalcularIMC.TabIndex = 4;
            this.lblCalcularIMC.Text = "Calculadora \r\n    de IMC";
            this.lblCalcularIMC.Click += new System.EventHandler(this.lblCalcularIMC_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(40, 353);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 47);
            this.label12.TabIndex = 3;
            this.label12.Text = "Regresar";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblModUsuario
            // 
            this.lblModUsuario.AutoSize = true;
            this.lblModUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.lblModUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblModUsuario.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModUsuario.ForeColor = System.Drawing.Color.White;
            this.lblModUsuario.Location = new System.Drawing.Point(36, 23);
            this.lblModUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModUsuario.Name = "lblModUsuario";
            this.lblModUsuario.Size = new System.Drawing.Size(221, 45);
            this.lblModUsuario.TabIndex = 2;
            this.lblModUsuario.Text = "Modificar";
            this.lblModUsuario.Click += new System.EventHandler(this.lblModUsuario_Click);
            // 
            // lblFavoritos
            // 
            this.lblFavoritos.AutoSize = true;
            this.lblFavoritos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.lblFavoritos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFavoritos.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoritos.ForeColor = System.Drawing.Color.White;
            this.lblFavoritos.Location = new System.Drawing.Point(36, 101);
            this.lblFavoritos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFavoritos.Name = "lblFavoritos";
            this.lblFavoritos.Size = new System.Drawing.Size(218, 45);
            this.lblFavoritos.TabIndex = 0;
            this.lblFavoritos.Text = "Favoritos";
            this.lblFavoritos.Click += new System.EventHandler(this.lblFavoritos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(548, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos generales";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 123);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(412, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "Usuario";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perfil de:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerContra)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFavoritos;
        private System.Windows.Forms.Label lblModUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Kg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCalcularIMC;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ComboBox cboTipoDiab;
        private System.Windows.Forms.ComboBox cboTienesDiab;
        private System.Windows.Forms.Label lblGuarCamb;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.PictureBox picVerContra;
    }
}