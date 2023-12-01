namespace FrontCine.Formularios
{
    partial class ComprobanteVenta
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
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_promos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_audio = new System.Windows.Forms.ComboBox();
            this.cbo_horario = new System.Windows.Forms.ComboBox();
            this.cbo_sala = new System.Windows.Forms.ComboBox();
            this.cbo_peli = new System.Windows.Forms.ComboBox();
            this.dgv_tickets = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreciosinDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuentoticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePromo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_comprobante = new System.Windows.Forms.Button();
            this.btn_pagos = new System.Windows.Forms.Button();
            this.btn_butacas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_fVenta = new System.Windows.Forms.ComboBox();
            this.barrasuperior = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).BeginInit();
            this.barrasuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Promo:";
            // 
            // cbo_promos
            // 
            this.cbo_promos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_promos.FormattingEnabled = true;
            this.cbo_promos.Location = new System.Drawing.Point(228, 240);
            this.cbo_promos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_promos.Name = "cbo_promos";
            this.cbo_promos.Size = new System.Drawing.Size(138, 28);
            this.cbo_promos.TabIndex = 5;
            this.cbo_promos.SelectedIndexChanged += new System.EventHandler(this.cbo_promos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Tickets:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(35, 106);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(50, 20);
            this.lbl_fecha.TabIndex = 37;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(35, 130);
            this.dtp_fecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(138, 27);
            this.dtp_fecha.TabIndex = 0;
            this.dtp_fecha.ValueChanged += new System.EventHandler(this.dtp_fecha_ValueChangedAsync);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Sala:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Horario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Audio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Pelicula:";
            // 
            // cbo_audio
            // 
            this.cbo_audio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_audio.FormattingEnabled = true;
            this.cbo_audio.Location = new System.Drawing.Point(35, 238);
            this.cbo_audio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_audio.Name = "cbo_audio";
            this.cbo_audio.Size = new System.Drawing.Size(138, 28);
            this.cbo_audio.TabIndex = 2;
            this.cbo_audio.SelectedIndexChanged += new System.EventHandler(this.cbo_audio_SelectedIndexChanged_1);
            // 
            // cbo_horario
            // 
            this.cbo_horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_horario.FormattingEnabled = true;
            this.cbo_horario.Location = new System.Drawing.Point(228, 130);
            this.cbo_horario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_horario.Name = "cbo_horario";
            this.cbo_horario.Size = new System.Drawing.Size(138, 28);
            this.cbo_horario.TabIndex = 3;
            this.cbo_horario.SelectedIndexChanged += new System.EventHandler(this.cbo_horario_SelectedIndexChanged_1);
            // 
            // cbo_sala
            // 
            this.cbo_sala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sala.FormattingEnabled = true;
            this.cbo_sala.Location = new System.Drawing.Point(228, 186);
            this.cbo_sala.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_sala.Name = "cbo_sala";
            this.cbo_sala.Size = new System.Drawing.Size(138, 28);
            this.cbo_sala.TabIndex = 4;
            this.cbo_sala.SelectedIndexChanged += new System.EventHandler(this.cbo_sala_SelectedIndexChanged_1);
            // 
            // cbo_peli
            // 
            this.cbo_peli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_peli.FormattingEnabled = true;
            this.cbo_peli.Location = new System.Drawing.Point(35, 184);
            this.cbo_peli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_peli.Name = "cbo_peli";
            this.cbo_peli.Size = new System.Drawing.Size(138, 28);
            this.cbo_peli.TabIndex = 1;
            this.cbo_peli.SelectedIndexChanged += new System.EventHandler(this.cbo_peli_SelectedIndexChanged_1);
            // 
            // dgv_tickets
            // 
            this.dgv_tickets.AllowUserToAddRows = false;
            this.dgv_tickets.AllowUserToDeleteRows = false;
            this.dgv_tickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.salaticket,
            this.horarioticket,
            this.tituloTicket,
            this.PreciosinDescuento,
            this.Descuentoticket,
            this.NombrePromo,
            this.PrecioTicket});
            this.dgv_tickets.Location = new System.Drawing.Point(28, 359);
            this.dgv_tickets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_tickets.Name = "dgv_tickets";
            this.dgv_tickets.ReadOnly = true;
            this.dgv_tickets.RowHeadersWidth = 51;
            this.dgv_tickets.RowTemplate.Height = 25;
            this.dgv_tickets.Size = new System.Drawing.Size(837, 263);
            this.dgv_tickets.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Numero de Butaca";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // salaticket
            // 
            this.salaticket.HeaderText = "Sala";
            this.salaticket.MinimumWidth = 6;
            this.salaticket.Name = "salaticket";
            this.salaticket.ReadOnly = true;
            // 
            // horarioticket
            // 
            this.horarioticket.HeaderText = "Horario";
            this.horarioticket.MinimumWidth = 6;
            this.horarioticket.Name = "horarioticket";
            this.horarioticket.ReadOnly = true;
            // 
            // tituloTicket
            // 
            this.tituloTicket.HeaderText = "Titulo";
            this.tituloTicket.MinimumWidth = 6;
            this.tituloTicket.Name = "tituloTicket";
            this.tituloTicket.ReadOnly = true;
            // 
            // PreciosinDescuento
            // 
            this.PreciosinDescuento.HeaderText = "Precio sin descuento";
            this.PreciosinDescuento.MinimumWidth = 6;
            this.PreciosinDescuento.Name = "PreciosinDescuento";
            this.PreciosinDescuento.ReadOnly = true;
            // 
            // Descuentoticket
            // 
            this.Descuentoticket.HeaderText = "Descuento";
            this.Descuentoticket.MinimumWidth = 6;
            this.Descuentoticket.Name = "Descuentoticket";
            this.Descuentoticket.ReadOnly = true;
            // 
            // NombrePromo
            // 
            this.NombrePromo.HeaderText = "Promo";
            this.NombrePromo.MinimumWidth = 6;
            this.NombrePromo.Name = "NombrePromo";
            this.NombrePromo.ReadOnly = true;
            // 
            // PrecioTicket
            // 
            this.PrecioTicket.HeaderText = "PrecioFinal";
            this.PrecioTicket.MinimumWidth = 6;
            this.PrecioTicket.Name = "PrecioTicket";
            this.PrecioTicket.ReadOnly = true;
            // 
            // btn_comprobante
            // 
            this.btn_comprobante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_comprobante.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_comprobante.Location = new System.Drawing.Point(723, 118);
            this.btn_comprobante.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_comprobante.Name = "btn_comprobante";
            this.btn_comprobante.Size = new System.Drawing.Size(142, 55);
            this.btn_comprobante.TabIndex = 9;
            this.btn_comprobante.Text = "Terminar Comprobante";
            this.btn_comprobante.UseVisualStyleBackColor = true;
            this.btn_comprobante.Click += new System.EventHandler(this.btn_comprobante_Click);
            // 
            // btn_pagos
            // 
            this.btn_pagos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pagos.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pagos.Location = new System.Drawing.Point(723, 246);
            this.btn_pagos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_pagos.Name = "btn_pagos";
            this.btn_pagos.Size = new System.Drawing.Size(142, 55);
            this.btn_pagos.TabIndex = 8;
            this.btn_pagos.Text = "Agregar Pagos";
            this.btn_pagos.UseVisualStyleBackColor = true;
            this.btn_pagos.Click += new System.EventHandler(this.btn_pagos_Click);
            // 
            // btn_butacas
            // 
            this.btn_butacas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_butacas.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_butacas.Location = new System.Drawing.Point(723, 183);
            this.btn_butacas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_butacas.Name = "btn_butacas";
            this.btn_butacas.Size = new System.Drawing.Size(142, 55);
            this.btn_butacas.TabIndex = 7;
            this.btn_butacas.Text = "Elegir butacas";
            this.btn_butacas.UseVisualStyleBackColor = true;
            this.btn_butacas.Click += new System.EventHandler(this.btn_butacas_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Forma de Venta:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbo_fVenta
            // 
            this.cbo_fVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_fVenta.FormattingEnabled = true;
            this.cbo_fVenta.Location = new System.Drawing.Point(228, 299);
            this.cbo_fVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_fVenta.Name = "cbo_fVenta";
            this.cbo_fVenta.Size = new System.Drawing.Size(138, 28);
            this.cbo_fVenta.TabIndex = 6;
            this.cbo_fVenta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // barrasuperior
            // 
            this.barrasuperior.BackColor = System.Drawing.Color.Maroon;
            this.barrasuperior.Controls.Add(this.label9);
            this.barrasuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barrasuperior.Location = new System.Drawing.Point(0, 0);
            this.barrasuperior.Name = "barrasuperior";
            this.barrasuperior.Size = new System.Drawing.Size(896, 76);
            this.barrasuperior.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 36);
            this.label9.TabIndex = 20;
            this.label9.Text = "VENTA";
            // 
            // ComprobanteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 665);
            this.Controls.Add(this.barrasuperior);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_fVenta);
            this.Controls.Add(this.btn_butacas);
            this.Controls.Add(this.btn_pagos);
            this.Controls.Add(this.btn_comprobante);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbo_promos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_audio);
            this.Controls.Add(this.cbo_horario);
            this.Controls.Add(this.cbo_sala);
            this.Controls.Add(this.cbo_peli);
            this.Controls.Add(this.dgv_tickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ComprobanteVenta";
            this.Text = "ComprobanteVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).EndInit();
            this.barrasuperior.ResumeLayout(false);
            this.barrasuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label10;
        private ComboBox cbo_promos;
        private Label label7;
        private Label lbl_fecha;
        private DateTimePicker dtp_fecha;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbo_audio;
        private ComboBox cbo_horario;
        private ComboBox cbo_sala;
        private ComboBox cbo_peli;
        private DataGridView dgv_tickets;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn salaticket;
        private DataGridViewTextBoxColumn horarioticket;
        private DataGridViewTextBoxColumn tituloTicket;
        private DataGridViewTextBoxColumn PreciosinDescuento;
        private DataGridViewTextBoxColumn Descuentoticket;
        private DataGridViewTextBoxColumn NombrePromo;
        private DataGridViewTextBoxColumn PrecioTicket;
        private Button btn_comprobante;
        private Button btn_pagos;
        private Button btn_butacas;
        private Label label5;
        private ComboBox cbo_fVenta;
        private Panel barrasuperior;
        private Label label9;
    }
}