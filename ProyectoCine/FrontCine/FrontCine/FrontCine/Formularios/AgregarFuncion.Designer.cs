namespace FrontCine.Formularios
{
    partial class AgregarFuncion
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
            this.CBhorarios = new System.Windows.Forms.ComboBox();
            this.CBaudios = new System.Windows.Forms.ComboBox();
            this.CBsalas = new System.Windows.Forms.ComboBox();
            this.TXTprecio = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNcancelar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.barrasuperior = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.barrasuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBpeliculas
            // 
            this.CBpeliculas.FormattingEnabled = true;
            this.CBpeliculas.Location = new System.Drawing.Point(35, 116);
            this.CBpeliculas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBpeliculas.Name = "CBpeliculas";
            this.CBpeliculas.Size = new System.Drawing.Size(166, 28);
            this.CBpeliculas.TabIndex = 0;
            this.CBpeliculas.SelectedIndexChanged += new System.EventHandler(this.CBpeliculas_SelectedIndexChanged);
            // 
            // CBhorarios
            // 
            this.CBhorarios.FormattingEnabled = true;
            this.CBhorarios.Location = new System.Drawing.Point(234, 116);
            this.CBhorarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBhorarios.Name = "CBhorarios";
            this.CBhorarios.Size = new System.Drawing.Size(138, 28);
            this.CBhorarios.TabIndex = 1;
            // 
            // CBaudios
            // 
            this.CBaudios.FormattingEnabled = true;
            this.CBaudios.Location = new System.Drawing.Point(394, 116);
            this.CBaudios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBaudios.Name = "CBaudios";
            this.CBaudios.Size = new System.Drawing.Size(138, 28);
            this.CBaudios.TabIndex = 2;
            // 
            // CBsalas
            // 
            this.CBsalas.FormattingEnabled = true;
            this.CBsalas.Location = new System.Drawing.Point(555, 116);
            this.CBsalas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBsalas.Name = "CBsalas";
            this.CBsalas.Size = new System.Drawing.Size(138, 28);
            this.CBsalas.TabIndex = 3;
            // 
            // TXTprecio
            // 
            this.TXTprecio.Location = new System.Drawing.Point(743, 116);
            this.TXTprecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTprecio.Name = "TXTprecio";
            this.TXTprecio.Size = new System.Drawing.Size(123, 27);
            this.TXTprecio.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(932, 116);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pelicula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Horario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Audio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sala";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(743, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(914, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha de la funcion";
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
            this.column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(35, 239);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1015, 109);
            this.dataGridView1.TabIndex = 13;
            // 
            // column1
            // 
            this.column1.HeaderText = "Pelicula";
            this.column1.MinimumWidth = 6;
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Horario";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Audio";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sala";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fecha de la funcion";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // BTNcancelar
            // 
            this.BTNcancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNcancelar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNcancelar.Location = new System.Drawing.Point(931, 369);
            this.BTNcancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNcancelar.Name = "BTNcancelar";
            this.BTNcancelar.Size = new System.Drawing.Size(119, 50);
            this.BTNcancelar.TabIndex = 7;
            this.BTNcancelar.Text = "Cerrar";
            this.BTNcancelar.UseVisualStyleBackColor = true;
            this.BTNcancelar.Click += new System.EventHandler(this.BTNcancelar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(933, 155);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 63);
            this.button2.TabIndex = 6;
            this.button2.Text = "Agregar Funcion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // barrasuperior
            // 
            this.barrasuperior.BackColor = System.Drawing.Color.Maroon;
            this.barrasuperior.Controls.Add(this.label9);
            this.barrasuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barrasuperior.Location = new System.Drawing.Point(0, 0);
            this.barrasuperior.Name = "barrasuperior";
            this.barrasuperior.Size = new System.Drawing.Size(1075, 76);
            this.barrasuperior.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 36);
            this.label9.TabIndex = 20;
            this.label9.Text = "Crear Funcion";
            // 
            // AgregarFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 441);
            this.Controls.Add(this.barrasuperior);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTNcancelar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TXTprecio);
            this.Controls.Add(this.CBsalas);
            this.Controls.Add(this.CBaudios);
            this.Controls.Add(this.CBhorarios);
            this.Controls.Add(this.CBpeliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AgregarFuncion";
            this.Text = "AgregarFuncion";
            this.Load += new System.EventHandler(this.AgregarFuncion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.barrasuperior.ResumeLayout(false);
            this.barrasuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox CBpeliculas;
        private ComboBox CBhorarios;
        private ComboBox CBaudios;
        private ComboBox CBsalas;
        private TextBox TXTprecio;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button BTNcancelar;
        private Button button2;
        private Panel barrasuperior;
        private Label label9;
    }
}