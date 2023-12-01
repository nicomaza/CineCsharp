namespace TpLab.Genagamer
{
    partial class consulta_funciones_mas_vendidas
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsultarTickets = new System.Windows.Forms.Button();
            this.txtCantidadTickets = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBgeneros = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloPeliculaCLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoCLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.CBmes = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(706, 680);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 47);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsultarTickets);
            this.groupBox2.Controls.Add(this.txtCantidadTickets);
            this.groupBox2.Location = new System.Drawing.Point(29, 627);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(443, 112);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cantidad de tickets vendidos el año pasado de genero accion";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnConsultarTickets
            // 
            this.btnConsultarTickets.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultarTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarTickets.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultarTickets.Location = new System.Drawing.Point(157, 61);
            this.btnConsultarTickets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultarTickets.Name = "btnConsultarTickets";
            this.btnConsultarTickets.Size = new System.Drawing.Size(114, 31);
            this.btnConsultarTickets.TabIndex = 7;
            this.btnConsultarTickets.Text = "CONSULTAR";
            this.btnConsultarTickets.UseVisualStyleBackColor = false;
            this.btnConsultarTickets.Click += new System.EventHandler(this.btnConsultarTickets_Click);
            // 
            // txtCantidadTickets
            // 
            this.txtCantidadTickets.Location = new System.Drawing.Point(27, 64);
            this.txtCantidadTickets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidadTickets.Name = "txtCantidadTickets";
            this.txtCantidadTickets.Size = new System.Drawing.Size(114, 27);
            this.txtCantidadTickets.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(127, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccione un género:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(448, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seleccione un mes:";
            // 
            // CBgeneros
            // 
            this.CBgeneros.FormattingEnabled = true;
            this.CBgeneros.Location = new System.Drawing.Point(165, 89);
            this.CBgeneros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBgeneros.Name = "CBgeneros";
            this.CBgeneros.Size = new System.Drawing.Size(180, 28);
            this.CBgeneros.TabIndex = 2;
            this.CBgeneros.SelectedIndexChanged += new System.EventHandler(this.CBgeneros_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCLM,
            this.tituloPeliculaCLM,
            this.generoCLM});
            this.dataGridView1.Location = new System.Drawing.Point(29, 152);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(815, 448);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idCLM
            // 
            this.idCLM.HeaderText = "Pelicula";
            this.idCLM.MinimumWidth = 6;
            this.idCLM.Name = "idCLM";
            // 
            // tituloPeliculaCLM
            // 
            this.tituloPeliculaCLM.HeaderText = "Titulo de la pelicula";
            this.tituloPeliculaCLM.MinimumWidth = 6;
            this.tituloPeliculaCLM.Name = "tituloPeliculaCLM";
            // 
            // generoCLM
            // 
            this.generoCLM.HeaderText = "Genero de la pelicula";
            this.generoCLM.MinimumWidth = 6;
            this.generoCLM.Name = "generoCLM";
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_consultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_consultar.Location = new System.Drawing.Point(694, 69);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(138, 47);
            this.btn_consultar.TabIndex = 5;
            this.btn_consultar.Text = "CONSULTAR";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // CBmes
            // 
            this.CBmes.FormattingEnabled = true;
            this.CBmes.Location = new System.Drawing.Point(475, 87);
            this.CBmes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBmes.Name = "CBmes";
            this.CBmes.Size = new System.Drawing.Size(151, 28);
            this.CBmes.TabIndex = 6;
            this.CBmes.SelectedIndexChanged += new System.EventHandler(this.CBmes_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.CBmes);
            this.groupBox1.Controls.Add(this.btn_consultar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.CBgeneros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(-3, -12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(905, 752);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TpLab.Properties.Resources.billPNG;
            this.pictureBox2.Location = new System.Drawing.Point(781, 508);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TpLab.Properties.Resources.LogoPng;
            this.pictureBox1.Location = new System.Drawing.Point(15, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // consulta_funciones_mas_vendidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(878, 739);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "consulta_funciones_mas_vendidas";
            this.Text = "Funciones Mas Vendidas";
            this.Load += new System.EventHandler(this.consulta_funciones_mas_vendidas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnCancelar;
        private GroupBox groupBox2;
        private TextBox txtCantidadTickets;
        private Button btnConsultarTickets;
        private Label label2;
        private Label label3;
        private ComboBox CBgeneros;
        private DataGridView dataGridView1;
        private Button btn_consultar;
        private ComboBox CBmes;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn idCLM;
        private DataGridViewTextBoxColumn tituloPeliculaCLM;
        private DataGridViewTextBoxColumn generoCLM;
    }
}