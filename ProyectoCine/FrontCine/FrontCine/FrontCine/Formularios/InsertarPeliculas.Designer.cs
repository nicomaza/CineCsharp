namespace FrontCine.Formularios
{
    partial class InsertarPeliculas
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrasuperior = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEstreno = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDirectores = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDistribuidoras = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboPaises = new System.Windows.Forms.ComboBox();
            this.cboClasificaciones = new System.Windows.Forms.ComboBox();
            this.cboGeneros = new System.Windows.Forms.ComboBox();
            this.seleccion = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.barrasuperior.SuspendLayout();
            this.seleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(868, 636);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.AllowUserToDeleteRows = false;
            this.dgvPeliculas.AllowUserToOrderColumns = true;
            this.dgvPeliculas.AllowUserToResizeColumns = false;
            this.dgvPeliculas.AllowUserToResizeRows = false;
            this.dgvPeliculas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Duracion,
            this.Clasificacion,
            this.Genero});
            this.dgvPeliculas.Location = new System.Drawing.Point(309, 114);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.RowHeadersVisible = false;
            this.dgvPeliculas.RowHeadersWidth = 51;
            this.dgvPeliculas.RowTemplate.Height = 29;
            this.dgvPeliculas.Size = new System.Drawing.Size(710, 492);
            this.dgvPeliculas.TabIndex = 17;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.MinimumWidth = 6;
            this.Duracion.Name = "Duracion";
            // 
            // Clasificacion
            // 
            this.Clasificacion.HeaderText = "Clasificacion";
            this.Clasificacion.MinimumWidth = 6;
            this.Clasificacion.Name = "Clasificacion";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            // 
            // barrasuperior
            // 
            this.barrasuperior.BackColor = System.Drawing.Color.Maroon;
            this.barrasuperior.Controls.Add(this.label9);
            this.barrasuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barrasuperior.Location = new System.Drawing.Point(0, 0);
            this.barrasuperior.Name = "barrasuperior";
            this.barrasuperior.Size = new System.Drawing.Size(1049, 76);
            this.barrasuperior.TabIndex = 18;
            this.barrasuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.barrasuperior_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 36);
            this.label9.TabIndex = 20;
            this.label9.Text = "Carga de peliculas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Distribuidora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Director";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(35, 194);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(80, 27);
            this.txtDuracion.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Genero";
            // 
            // dtpEstreno
            // 
            this.dtpEstreno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEstreno.Location = new System.Drawing.Point(35, 127);
            this.dtpEstreno.Name = "dtpEstreno";
            this.dtpEstreno.Size = new System.Drawing.Size(121, 27);
            this.dtpEstreno.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Clasificacion";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(35, 61);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(194, 27);
            this.txtTitulo.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Titulo ";
            // 
            // cboDirectores
            // 
            this.cboDirectores.FormattingEnabled = true;
            this.cboDirectores.Location = new System.Drawing.Point(35, 374);
            this.cboDirectores.Name = "cboDirectores";
            this.cboDirectores.Size = new System.Drawing.Size(151, 28);
            this.cboDirectores.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fecha de Estreno";
            // 
            // cboDistribuidoras
            // 
            this.cboDistribuidoras.FormattingEnabled = true;
            this.cboDistribuidoras.Location = new System.Drawing.Point(35, 257);
            this.cboDistribuidoras.Name = "cboDistribuidoras";
            this.cboDistribuidoras.Size = new System.Drawing.Size(151, 28);
            this.cboDistribuidoras.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Duracion";
            // 
            // cboPaises
            // 
            this.cboPaises.FormattingEnabled = true;
            this.cboPaises.Location = new System.Drawing.Point(35, 317);
            this.cboPaises.Name = "cboPaises";
            this.cboPaises.Size = new System.Drawing.Size(151, 28);
            this.cboPaises.TabIndex = 4;
            // 
            // cboClasificaciones
            // 
            this.cboClasificaciones.FormattingEnabled = true;
            this.cboClasificaciones.Location = new System.Drawing.Point(35, 502);
            this.cboClasificaciones.Name = "cboClasificaciones";
            this.cboClasificaciones.Size = new System.Drawing.Size(151, 28);
            this.cboClasificaciones.TabIndex = 7;
            // 
            // cboGeneros
            // 
            this.cboGeneros.FormattingEnabled = true;
            this.cboGeneros.Location = new System.Drawing.Point(35, 437);
            this.cboGeneros.Name = "cboGeneros";
            this.cboGeneros.Size = new System.Drawing.Size(151, 28);
            this.cboGeneros.TabIndex = 6;
            // 
            // seleccion
            // 
            this.seleccion.Controls.Add(this.cboGeneros);
            this.seleccion.Controls.Add(this.cboClasificaciones);
            this.seleccion.Controls.Add(this.cboPaises);
            this.seleccion.Controls.Add(this.label8);
            this.seleccion.Controls.Add(this.cboDistribuidoras);
            this.seleccion.Controls.Add(this.label7);
            this.seleccion.Controls.Add(this.cboDirectores);
            this.seleccion.Controls.Add(this.label6);
            this.seleccion.Controls.Add(this.txtTitulo);
            this.seleccion.Controls.Add(this.label5);
            this.seleccion.Controls.Add(this.dtpEstreno);
            this.seleccion.Controls.Add(this.label4);
            this.seleccion.Controls.Add(this.txtDuracion);
            this.seleccion.Controls.Add(this.label3);
            this.seleccion.Controls.Add(this.label1);
            this.seleccion.Controls.Add(this.label2);
            this.seleccion.Dock = System.Windows.Forms.DockStyle.Left;
            this.seleccion.Location = new System.Drawing.Point(0, 76);
            this.seleccion.Name = "seleccion";
            this.seleccion.Size = new System.Drawing.Size(273, 622);
            this.seleccion.TabIndex = 19;
            this.seleccion.Paint += new System.Windows.Forms.PaintEventHandler(this.seleccion_Paint);
            // 
            // InsertarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 698);
            this.Controls.Add(this.seleccion);
            this.Controls.Add(this.barrasuperior);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertarPeliculas";
            this.Text = "InsertarPeliculas";
            this.Load += new System.EventHandler(this.InsertarPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.barrasuperior.ResumeLayout(false);
            this.barrasuperior.PerformLayout();
            this.seleccion.ResumeLayout(false);
            this.seleccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private DataGridView dgvPeliculas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Clasificacion;
        private DataGridViewTextBoxColumn Genero;
        private Panel barrasuperior;
        private Label label9;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtDuracion;
        private Label label4;
        private DateTimePicker dtpEstreno;
        private Label label5;
        private TextBox txtTitulo;
        private Label label6;
        private ComboBox cboDirectores;
        private Label label7;
        private ComboBox cboDistribuidoras;
        private Label label8;
        private ComboBox cboPaises;
        private ComboBox cboClasificaciones;
        private ComboBox cboGeneros;
        private Panel seleccion;
    }
}