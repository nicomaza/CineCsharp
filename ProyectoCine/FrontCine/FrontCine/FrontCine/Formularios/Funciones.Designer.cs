namespace FrontCine.Formularios
{
    partial class Funciones
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
            this.CBpeliculas = new System.Windows.Forms.ComboBox();
            this.DTPfecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNconsultarFuncion = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.barrasuperior = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.barrasuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBpeliculas
            // 
            this.CBpeliculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBpeliculas.FormattingEnabled = true;
            this.CBpeliculas.Location = new System.Drawing.Point(37, 186);
            this.CBpeliculas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBpeliculas.Name = "CBpeliculas";
            this.CBpeliculas.Size = new System.Drawing.Size(237, 28);
            this.CBpeliculas.TabIndex = 0;
            this.CBpeliculas.SelectedIndexChanged += new System.EventHandler(this.CBpeliculas_SelectedIndexChanged);
            // 
            // DTPfecha
            // 
            this.DTPfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPfecha.Location = new System.Drawing.Point(37, 254);
            this.DTPfecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DTPfecha.Name = "DTPfecha";
            this.DTPfecha.Size = new System.Drawing.Size(114, 27);
            this.DTPfecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Peliculas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BTNconsultarFuncion
            // 
            this.BTNconsultarFuncion.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNconsultarFuncion.Location = new System.Drawing.Point(37, 319);
            this.BTNconsultarFuncion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNconsultarFuncion.Name = "BTNconsultarFuncion";
            this.BTNconsultarFuncion.Size = new System.Drawing.Size(145, 43);
            this.BTNconsultarFuncion.TabIndex = 2;
            this.BTNconsultarFuncion.Text = "Consultar funcion";
            this.BTNconsultarFuncion.UseVisualStyleBackColor = true;
            this.BTNconsultarFuncion.Click += new System.EventHandler(this.BTNconsultarFuncion_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNsalir.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNsalir.Location = new System.Drawing.Point(1206, 704);
            this.BTNsalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(117, 33);
            this.BTNsalir.TabIndex = 14;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(302, 163);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 511);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID DE LA FUNCION";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOMBRE DE LA PELICULA";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "HORARIO DE LA FUNCION";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "AUDIO";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SALA";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "PRECIO";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "FECHA";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "DAR DE BAJA";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Text = "DAR DE BAJA";
            this.Column8.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(37, 370);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cargar todas las funciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // barrasuperior
            // 
            this.barrasuperior.BackColor = System.Drawing.Color.Maroon;
            this.barrasuperior.Controls.Add(this.label9);
            this.barrasuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barrasuperior.Location = new System.Drawing.Point(0, 0);
            this.barrasuperior.Name = "barrasuperior";
            this.barrasuperior.Size = new System.Drawing.Size(1353, 76);
            this.barrasuperior.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 36);
            this.label9.TabIndex = 20;
            this.label9.Text = "Consultar Funcion";
            // 
            // Funciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1353, 758);
            this.Controls.Add(this.barrasuperior);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.BTNconsultarFuncion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPfecha);
            this.Controls.Add(this.CBpeliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Funciones";
            this.Text = "InsertarFuncion";
            this.Load += new System.EventHandler(this.Funciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.barrasuperior.ResumeLayout(false);
            this.barrasuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CBpeliculas;
        private DateTimePicker DTPfecha;
        private Label label1;
        private Label label5;
        private Button BTNconsultarFuncion;
        private Button BTNsalir;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewButtonColumn Column8;
        private Button button1;
        private Panel barrasuperior;
        private Label label9;
    }
}