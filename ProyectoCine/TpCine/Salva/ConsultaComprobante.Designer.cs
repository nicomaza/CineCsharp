namespace TpLab.Salva
{
    partial class ConsultaComprobante
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
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dataSetTotalYear1 = new TpLab.Nicolas.DataSetTotalYear();
            this.dgvComprobante = new System.Windows.Forms.DataGridView();
            this.Col_cpNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coL_f_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.cbFormaVenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTotalYear1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(143, 35);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(140, 23);
            this.dtpDesde.TabIndex = 0;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(328, 35);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(140, 23);
            this.dtpHasta.TabIndex = 1;
            // 
            // dataSetTotalYear1
            // 
            this.dataSetTotalYear1.DataSetName = "DataSetTotalYear";
            this.dataSetTotalYear1.Namespace = "http://tempuri.org/DataSetTotalYear.xsd";
            this.dataSetTotalYear1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvComprobante
            // 
            this.dgvComprobante.AllowUserToAddRows = false;
            this.dgvComprobante.AllowUserToDeleteRows = false;
            this.dgvComprobante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComprobante.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprobante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_cpNum,
            this.Col_Fecha,
            this.coL_f_venta,
            this.Col_Precio});
            this.dgvComprobante.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvComprobante.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvComprobante.Location = new System.Drawing.Point(10, 130);
            this.dgvComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvComprobante.Name = "dgvComprobante";
            this.dgvComprobante.ReadOnly = true;
            this.dgvComprobante.RowHeadersVisible = false;
            this.dgvComprobante.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvComprobante.RowTemplate.Height = 29;
            this.dgvComprobante.Size = new System.Drawing.Size(662, 275);
            this.dgvComprobante.TabIndex = 2;
            this.dgvComprobante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComprobante_CellContentClick);
            // 
            // Col_cpNum
            // 
            this.Col_cpNum.HeaderText = "Comprobante Num.";
            this.Col_cpNum.MinimumWidth = 6;
            this.Col_cpNum.Name = "Col_cpNum";
            this.Col_cpNum.ReadOnly = true;
            // 
            // Col_Fecha
            // 
            this.Col_Fecha.HeaderText = "Fecha";
            this.Col_Fecha.MinimumWidth = 6;
            this.Col_Fecha.Name = "Col_Fecha";
            this.Col_Fecha.ReadOnly = true;
            // 
            // coL_f_venta
            // 
            this.coL_f_venta.HeaderText = "Forma Venta";
            this.coL_f_venta.MinimumWidth = 6;
            this.coL_f_venta.Name = "coL_f_venta";
            this.coL_f_venta.ReadOnly = true;
            // 
            // Col_Precio
            // 
            this.Col_Precio.HeaderText = "Precio";
            this.Col_Precio.MinimumWidth = 6;
            this.Col_Precio.Name = "Col_Precio";
            this.Col_Precio.ReadOnly = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFiltrar.Location = new System.Drawing.Point(520, 28);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(106, 36);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TpLab.Properties.Resources.LogoPng;
            this.pictureBox1.Location = new System.Drawing.Point(10, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUser.Location = new System.Drawing.Point(143, 11);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(67, 22);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Desde:";
            // 
            // cbFormaVenta
            // 
            this.cbFormaVenta.FormattingEnabled = true;
            this.cbFormaVenta.Location = new System.Drawing.Point(297, 92);
            this.cbFormaVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFormaVenta.Name = "cbFormaVenta";
            this.cbFormaVenta.Size = new System.Drawing.Size(172, 23);
            this.cbFormaVenta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(328, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(143, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Forma de Pago:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TpLab.Properties.Resources.document;
            this.pictureBox2.Location = new System.Drawing.Point(625, 362);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::TpLab.Properties.Resources.BackArrowPNG;
            this.button1.Location = new System.Drawing.Point(11, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 34);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultaComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(700, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbFormaVenta);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvComprobante);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsultaComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Comprobantes";
            this.Load += new System.EventHandler(this.ConsultaComprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTotalYear1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Nicolas.DataSetTotalYear dataSetTotalYear1;
        private DataGridView dgvComprobante;
        private Button btnFiltrar;
        private PictureBox pictureBox1;
        private Label lblUser;
        private ComboBox cbFormaVenta;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn Col_cpNum;
        private DataGridViewTextBoxColumn Col_Fecha;
        private DataGridViewTextBoxColumn coL_f_venta;
        private DataGridViewTextBoxColumn Col_Precio;
        private Button button1;
    }
}