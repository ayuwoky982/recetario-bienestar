namespace WindowsFormsApp17
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlFavRec = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chkAzucares = new System.Windows.Forms.CheckBox();
            this.chkProteinas = new System.Windows.Forms.CheckBox();
            this.chkCalorias = new System.Windows.Forms.CheckBox();
            this.chkCarbohidratos = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnEliminarFav = new System.Windows.Forms.Button();
            this.btnAgregarFav = new System.Windows.Forms.Button();
            this.cboTipoComida = new System.Windows.Forms.ComboBox();
            this.picMenuFav = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbConsejos = new System.Windows.Forms.RadioButton();
            this.rdbRecetas = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timerEstrellaAumentar = new System.Windows.Forms.Timer(this.components);
            this.timerEstrellaDisminuir = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlFavRec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuFav)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-1, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 353);
            this.panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(195, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(605, 353);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pnlFavRec);
            this.panel3.Controls.Add(this.picMenuFav);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 353);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Descargar favoritos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pnlFavRec
            // 
            this.pnlFavRec.Controls.Add(this.label12);
            this.pnlFavRec.Controls.Add(this.numericUpDown4);
            this.pnlFavRec.Controls.Add(this.numericUpDown3);
            this.pnlFavRec.Controls.Add(this.numericUpDown2);
            this.pnlFavRec.Controls.Add(this.numericUpDown1);
            this.pnlFavRec.Controls.Add(this.chkAzucares);
            this.pnlFavRec.Controls.Add(this.chkProteinas);
            this.pnlFavRec.Controls.Add(this.chkCalorias);
            this.pnlFavRec.Controls.Add(this.chkCarbohidratos);
            this.pnlFavRec.Controls.Add(this.label28);
            this.pnlFavRec.Controls.Add(this.btnEliminarFav);
            this.pnlFavRec.Controls.Add(this.btnAgregarFav);
            this.pnlFavRec.Controls.Add(this.cboTipoComida);
            this.pnlFavRec.Location = new System.Drawing.Point(8, 90);
            this.pnlFavRec.Name = "pnlFavRec";
            this.pnlFavRec.Size = new System.Drawing.Size(171, 260);
            this.pnlFavRec.TabIndex = 16;
            this.pnlFavRec.Click += new System.EventHandler(this.pnlFavRec_Click);
            this.pnlFavRec.MouseEnter += new System.EventHandler(this.pnlFavRec_MouseEnter);
            this.pnlFavRec.MouseLeave += new System.EventHandler(this.pnlFavRec_MouseLeave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(6, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 38);
            this.label12.TabIndex = 6;
            this.label12.Text = "Regresar";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(101, 135);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown4.TabIndex = 17;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(102, 109);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown3.TabIndex = 16;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(102, 83);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown2.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(101, 57);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 14;
            // 
            // chkAzucares
            // 
            this.chkAzucares.AutoSize = true;
            this.chkAzucares.Location = new System.Drawing.Point(4, 138);
            this.chkAzucares.Name = "chkAzucares";
            this.chkAzucares.Size = new System.Drawing.Size(70, 17);
            this.chkAzucares.TabIndex = 13;
            this.chkAzucares.Text = "Azúcares";
            this.chkAzucares.UseVisualStyleBackColor = true;
            // 
            // chkProteinas
            // 
            this.chkProteinas.AutoSize = true;
            this.chkProteinas.Location = new System.Drawing.Point(4, 112);
            this.chkProteinas.Name = "chkProteinas";
            this.chkProteinas.Size = new System.Drawing.Size(72, 17);
            this.chkProteinas.TabIndex = 12;
            this.chkProteinas.Text = "Proteínas";
            this.chkProteinas.UseVisualStyleBackColor = true;
            // 
            // chkCalorias
            // 
            this.chkCalorias.AutoSize = true;
            this.chkCalorias.Location = new System.Drawing.Point(4, 86);
            this.chkCalorias.Name = "chkCalorias";
            this.chkCalorias.Size = new System.Drawing.Size(65, 17);
            this.chkCalorias.TabIndex = 11;
            this.chkCalorias.Text = "Calorías";
            this.chkCalorias.UseVisualStyleBackColor = true;
            // 
            // chkCarbohidratos
            // 
            this.chkCarbohidratos.AutoSize = true;
            this.chkCarbohidratos.Location = new System.Drawing.Point(4, 60);
            this.chkCarbohidratos.Name = "chkCarbohidratos";
            this.chkCarbohidratos.Size = new System.Drawing.Size(91, 17);
            this.chkCarbohidratos.TabIndex = 10;
            this.chkCarbohidratos.Text = "Carbohidratos";
            this.chkCarbohidratos.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(13, 33);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(65, 18);
            this.label28.TabIndex = 4;
            this.label28.Text = "Filtrado";
            // 
            // btnEliminarFav
            // 
            this.btnEliminarFav.Location = new System.Drawing.Point(-5, 161);
            this.btnEliminarFav.Name = "btnEliminarFav";
            this.btnEliminarFav.Size = new System.Drawing.Size(83, 36);
            this.btnEliminarFav.TabIndex = 3;
            this.btnEliminarFav.Text = "Eliminar de Favoritos";
            this.btnEliminarFav.UseVisualStyleBackColor = true;
            this.btnEliminarFav.Click += new System.EventHandler(this.btnEliminarFav_Click);
            // 
            // btnAgregarFav
            // 
            this.btnAgregarFav.Location = new System.Drawing.Point(78, 161);
            this.btnAgregarFav.Name = "btnAgregarFav";
            this.btnAgregarFav.Size = new System.Drawing.Size(83, 36);
            this.btnAgregarFav.TabIndex = 2;
            this.btnAgregarFav.Text = "Agregar a Favoritos";
            this.btnAgregarFav.UseVisualStyleBackColor = true;
            this.btnAgregarFav.Click += new System.EventHandler(this.btnAgregarFav_Click);
            // 
            // cboTipoComida
            // 
            this.cboTipoComida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoComida.FormattingEnabled = true;
            this.cboTipoComida.Items.AddRange(new object[] {
            "Desayuno",
            "Comida",
            "Cena"});
            this.cboTipoComida.Location = new System.Drawing.Point(13, 0);
            this.cboTipoComida.Name = "cboTipoComida";
            this.cboTipoComida.Size = new System.Drawing.Size(82, 21);
            this.cboTipoComida.TabIndex = 0;
            this.cboTipoComida.SelectedIndexChanged += new System.EventHandler(this.cboTipoComida_SelectedIndexChanged);
            // 
            // picMenuFav
            // 
            this.picMenuFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMenuFav.Location = new System.Drawing.Point(3, 299);
            this.picMenuFav.Name = "picMenuFav";
            this.picMenuFav.Size = new System.Drawing.Size(55, 54);
            this.picMenuFav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuFav.TabIndex = 15;
            this.picMenuFav.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(303, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 38);
            this.label7.TabIndex = 3;
            this.label7.Text = "Consejos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 100);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbConsejos);
            this.groupBox1.Controls.Add(this.rdbRecetas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(207, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbConsejos
            // 
            this.rdbConsejos.AutoSize = true;
            this.rdbConsejos.Location = new System.Drawing.Point(320, 57);
            this.rdbConsejos.Name = "rdbConsejos";
            this.rdbConsejos.Size = new System.Drawing.Size(40, 17);
            this.rdbConsejos.TabIndex = 5;
            this.rdbConsejos.TabStop = true;
            this.rdbConsejos.Text = "ver";
            this.rdbConsejos.UseVisualStyleBackColor = true;
            this.rdbConsejos.CheckedChanged += new System.EventHandler(this.rdbConsejos_CheckedChanged);
            // 
            // rdbRecetas
            // 
            this.rdbRecetas.AutoSize = true;
            this.rdbRecetas.Location = new System.Drawing.Point(13, 58);
            this.rdbRecetas.Name = "rdbRecetas";
            this.rdbRecetas.Size = new System.Drawing.Size(40, 17);
            this.rdbRecetas.TabIndex = 4;
            this.rdbRecetas.TabStop = true;
            this.rdbRecetas.Text = "ver";
            this.rdbRecetas.UseVisualStyleBackColor = true;
            this.rdbRecetas.CheckedChanged += new System.EventHandler(this.rdbRecetas_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recetas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 38);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ver perfil";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // timerEstrellaAumentar
            // 
            this.timerEstrellaAumentar.Tick += new System.EventHandler(this.timerEstrellaAumentar_Tick);
            // 
            // timerEstrellaDisminuir
            // 
            this.timerEstrellaDisminuir.Tick += new System.EventHandler(this.timerEstrellaDisminuir_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlFavRec.ResumeLayout(false);
            this.pnlFavRec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuFav)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbConsejos;
        private System.Windows.Forms.RadioButton rdbRecetas;
        private System.Windows.Forms.Timer timerEstrellaAumentar;
        private System.Windows.Forms.Timer timerEstrellaDisminuir;
        private System.Windows.Forms.PictureBox picMenuFav;
        private System.Windows.Forms.Panel pnlFavRec;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox chkAzucares;
        private System.Windows.Forms.CheckBox chkProteinas;
        private System.Windows.Forms.CheckBox chkCalorias;
        private System.Windows.Forms.CheckBox chkCarbohidratos;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnEliminarFav;
        private System.Windows.Forms.Button btnAgregarFav;
        private System.Windows.Forms.ComboBox cboTipoComida;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}