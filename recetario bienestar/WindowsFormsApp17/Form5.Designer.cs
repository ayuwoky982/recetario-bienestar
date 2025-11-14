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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlMenuRecetas = new System.Windows.Forms.Panel();
            this.btnDescargarFav = new System.Windows.Forms.Button();
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
            this.lblRegresar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbConsejos = new System.Windows.Forms.RadioButton();
            this.rdbRecetas = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVerPerfilUsuario = new System.Windows.Forms.Label();
            this.timerEstrellaAumentar = new System.Windows.Forms.Timer(this.components);
            this.timerEstrellaDisminuir = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.picMenuFav = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlMenuRecetas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuFav)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-1, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 434);
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeight = 29;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Location = new System.Drawing.Point(268, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(799, 434);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.panel3.Controls.Add(this.pnlMenuRecetas);
            this.panel3.Controls.Add(this.lblRegresar);
            this.panel3.Location = new System.Drawing.Point(0, -34);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 469);
            this.panel3.TabIndex = 3;
            // 
            // pnlMenuRecetas
            // 
            this.pnlMenuRecetas.Controls.Add(this.btnDescargarFav);
            this.pnlMenuRecetas.Controls.Add(this.numericUpDown4);
            this.pnlMenuRecetas.Controls.Add(this.numericUpDown3);
            this.pnlMenuRecetas.Controls.Add(this.numericUpDown2);
            this.pnlMenuRecetas.Controls.Add(this.numericUpDown1);
            this.pnlMenuRecetas.Controls.Add(this.chkAzucares);
            this.pnlMenuRecetas.Controls.Add(this.chkProteinas);
            this.pnlMenuRecetas.Controls.Add(this.chkCalorias);
            this.pnlMenuRecetas.Controls.Add(this.chkCarbohidratos);
            this.pnlMenuRecetas.Controls.Add(this.label28);
            this.pnlMenuRecetas.Controls.Add(this.btnEliminarFav);
            this.pnlMenuRecetas.Controls.Add(this.btnAgregarFav);
            this.pnlMenuRecetas.Controls.Add(this.cboTipoComida);
            this.pnlMenuRecetas.Location = new System.Drawing.Point(4, 34);
            this.pnlMenuRecetas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMenuRecetas.Name = "pnlMenuRecetas";
            this.pnlMenuRecetas.Size = new System.Drawing.Size(260, 372);
            this.pnlMenuRecetas.TabIndex = 16;
            // 
            // btnDescargarFav
            // 
            this.btnDescargarFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarFav.Location = new System.Drawing.Point(41, 292);
            this.btnDescargarFav.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDescargarFav.Name = "btnDescargarFav";
            this.btnDescargarFav.Size = new System.Drawing.Size(179, 52);
            this.btnDescargarFav.TabIndex = 19;
            this.btnDescargarFav.Text = "Descargar recetas favoritos";
            this.btnDescargarFav.UseVisualStyleBackColor = true;
            this.btnDescargarFav.Click += new System.EventHandler(this.btnDescargarFav_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(171, 166);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown4.TabIndex = 17;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(172, 134);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown3.TabIndex = 16;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(172, 102);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown2.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(171, 70);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown1.TabIndex = 14;
            // 
            // chkAzucares
            // 
            this.chkAzucares.AutoSize = true;
            this.chkAzucares.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAzucares.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.chkAzucares.Location = new System.Drawing.Point(5, 170);
            this.chkAzucares.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAzucares.Name = "chkAzucares";
            this.chkAzucares.Size = new System.Drawing.Size(102, 24);
            this.chkAzucares.TabIndex = 13;
            this.chkAzucares.Text = "Azúcares";
            this.chkAzucares.UseVisualStyleBackColor = true;
            // 
            // chkProteinas
            // 
            this.chkProteinas.AutoSize = true;
            this.chkProteinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProteinas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.chkProteinas.Location = new System.Drawing.Point(5, 138);
            this.chkProteinas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkProteinas.Name = "chkProteinas";
            this.chkProteinas.Size = new System.Drawing.Size(102, 24);
            this.chkProteinas.TabIndex = 12;
            this.chkProteinas.Text = "Proteínas";
            this.chkProteinas.UseVisualStyleBackColor = true;
            // 
            // chkCalorias
            // 
            this.chkCalorias.AutoSize = true;
            this.chkCalorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCalorias.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.chkCalorias.Location = new System.Drawing.Point(5, 106);
            this.chkCalorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCalorias.Name = "chkCalorias";
            this.chkCalorias.Size = new System.Drawing.Size(93, 24);
            this.chkCalorias.TabIndex = 11;
            this.chkCalorias.Text = "Calorías";
            this.chkCalorias.UseVisualStyleBackColor = true;
            // 
            // chkCarbohidratos
            // 
            this.chkCarbohidratos.AutoSize = true;
            this.chkCarbohidratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCarbohidratos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.chkCarbohidratos.Location = new System.Drawing.Point(5, 74);
            this.chkCarbohidratos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCarbohidratos.Name = "chkCarbohidratos";
            this.chkCarbohidratos.Size = new System.Drawing.Size(136, 24);
            this.chkCarbohidratos.TabIndex = 10;
            this.chkCarbohidratos.Text = "Carbohidratos";
            this.chkCarbohidratos.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label28.Location = new System.Drawing.Point(79, 42);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(84, 25);
            this.label28.TabIndex = 4;
            this.label28.Text = "Filtrado";
            // 
            // btnEliminarFav
            // 
            this.btnEliminarFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFav.Location = new System.Drawing.Point(133, 217);
            this.btnEliminarFav.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarFav.Name = "btnEliminarFav";
            this.btnEliminarFav.Size = new System.Drawing.Size(120, 49);
            this.btnEliminarFav.TabIndex = 3;
            this.btnEliminarFav.Text = "Eliminar de Favoritos";
            this.btnEliminarFav.UseVisualStyleBackColor = true;
            this.btnEliminarFav.Click += new System.EventHandler(this.btnEliminarFav_Click);
            // 
            // btnAgregarFav
            // 
            this.btnAgregarFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFav.Location = new System.Drawing.Point(5, 217);
            this.btnAgregarFav.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarFav.Name = "btnAgregarFav";
            this.btnAgregarFav.Size = new System.Drawing.Size(120, 49);
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
            this.cboTipoComida.Location = new System.Drawing.Point(76, 11);
            this.cboTipoComida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTipoComida.Name = "cboTipoComida";
            this.cboTipoComida.Size = new System.Drawing.Size(108, 24);
            this.cboTipoComida.TabIndex = 0;
            this.cboTipoComida.SelectedIndexChanged += new System.EventHandler(this.cboTipoComida_SelectedIndexChanged);
            // 
            // lblRegresar
            // 
            this.lblRegresar.AutoSize = true;
            this.lblRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(23)))), ((int)(((byte)(48)))));
            this.lblRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegresar.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegresar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegresar.Location = new System.Drawing.Point(27, 410);
            this.lblRegresar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegresar.Name = "lblRegresar";
            this.lblRegresar.Size = new System.Drawing.Size(200, 47);
            this.lblRegresar.TabIndex = 6;
            this.lblRegresar.Text = "Regresar";
            this.lblRegresar.Click += new System.EventHandler(this.lblRegresar_Click);
            this.lblRegresar.MouseEnter += new System.EventHandler(this.lblRegresar_MouseEnter);
            this.lblRegresar.MouseLeave += new System.EventHandler(this.lblRegresar_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(341, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 45);
            this.label7.TabIndex = 3;
            this.label7.Text = "Consejos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.picMenuFav);
            this.panel1.Controls.Add(this.lblVerPerfilUsuario);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 123);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbConsejos);
            this.groupBox1.Controls.Add(this.rdbRecetas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(276, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(627, 102);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rdbConsejos
            // 
            this.rdbConsejos.AutoSize = true;
            this.rdbConsejos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbConsejos.Location = new System.Drawing.Point(379, 59);
            this.rdbConsejos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbConsejos.Name = "rdbConsejos";
            this.rdbConsejos.Size = new System.Drawing.Size(127, 35);
            this.rdbConsejos.TabIndex = 5;
            this.rdbConsejos.TabStop = true;
            this.rdbConsejos.Text = "Mostrar";
            this.rdbConsejos.UseVisualStyleBackColor = true;
            this.rdbConsejos.CheckedChanged += new System.EventHandler(this.rdbConsejos_CheckedChanged);
            // 
            // rdbRecetas
            // 
            this.rdbRecetas.AutoSize = true;
            this.rdbRecetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRecetas.Location = new System.Drawing.Point(119, 59);
            this.rdbRecetas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbRecetas.Name = "rdbRecetas";
            this.rdbRecetas.Size = new System.Drawing.Size(127, 35);
            this.rdbRecetas.TabIndex = 4;
            this.rdbRecetas.TabStop = true;
            this.rdbRecetas.Text = "Mostrar";
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
            this.label1.Location = new System.Drawing.Point(67, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recetas";
            // 
            // lblVerPerfilUsuario
            // 
            this.lblVerPerfilUsuario.AutoSize = true;
            this.lblVerPerfilUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(23)))), ((int)(((byte)(48)))));
            this.lblVerPerfilUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVerPerfilUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblVerPerfilUsuario.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerPerfilUsuario.ForeColor = System.Drawing.Color.White;
            this.lblVerPerfilUsuario.Location = new System.Drawing.Point(12, 36);
            this.lblVerPerfilUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerPerfilUsuario.Name = "lblVerPerfilUsuario";
            this.lblVerPerfilUsuario.Size = new System.Drawing.Size(217, 45);
            this.lblVerPerfilUsuario.TabIndex = 4;
            this.lblVerPerfilUsuario.Text = "Ver perfil";
            this.lblVerPerfilUsuario.Click += new System.EventHandler(this.lblVerPerfilUsuario_Click);
            // 
            // timerEstrellaAumentar
            // 
            this.timerEstrellaAumentar.Tick += new System.EventHandler(this.timerEstrellaAumentar_Tick);
            // 
            // timerEstrellaDisminuir
            // 
            this.timerEstrellaDisminuir.Tick += new System.EventHandler(this.timerEstrellaDisminuir_Tick);
            // 
            // picMenuFav
            // 
            this.picMenuFav.Image = ((System.Drawing.Image)(resources.GetObject("picMenuFav.Image")));
            this.picMenuFav.Location = new System.Drawing.Point(959, 44);
            this.picMenuFav.Margin = new System.Windows.Forms.Padding(4);
            this.picMenuFav.Name = "picMenuFav";
            this.picMenuFav.Size = new System.Drawing.Size(67, 62);
            this.picMenuFav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuFav.TabIndex = 18;
            this.picMenuFav.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlMenuRecetas.ResumeLayout(false);
            this.pnlMenuRecetas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuFav)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVerPerfilUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbConsejos;
        private System.Windows.Forms.RadioButton rdbRecetas;
        private System.Windows.Forms.Timer timerEstrellaAumentar;
        private System.Windows.Forms.Timer timerEstrellaDisminuir;
        private System.Windows.Forms.Panel pnlMenuRecetas;
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
        private System.Windows.Forms.PictureBox picMenuFav;
        private System.Windows.Forms.Label lblRegresar;
        private System.Windows.Forms.Button btnDescargarFav;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}