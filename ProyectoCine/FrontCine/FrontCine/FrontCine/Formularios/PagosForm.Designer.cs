namespace FrontCine.Formularios
{
    partial class PagosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagosForm));
            this.btn_terminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_restante = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_lista = new System.Windows.Forms.DataGridView();
            this.FP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tb_monto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_fp = new System.Windows.Forms.ComboBox();
            this.barrasuperior = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).BeginInit();
            this.barrasuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_terminar
            // 
            this.btn_terminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_terminar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_terminar.Location = new System.Drawing.Point(478, 415);
            this.btn_terminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_terminar.Name = "btn_terminar";
            this.btn_terminar.Size = new System.Drawing.Size(107, 43);
            this.btn_terminar.TabIndex = 3;
            this.btn_terminar.Text = "Terminar";
            this.btn_terminar.UseVisualStyleBackColor = true;
            this.btn_terminar.Click += new System.EventHandler(this.btn_terminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregar.Location = new System.Drawing.Point(99, 265);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(112, 39);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_total.Location = new System.Drawing.Point(193, 426);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(66, 24);
            this.lbl_total.TabIndex = 19;
            this.lbl_total.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(40, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Monto Total:";
            // 
            // lbl_restante
            // 
            this.lbl_restante.AutoSize = true;
            this.lbl_restante.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_restante.ForeColor = System.Drawing.Color.Red;
            this.lbl_restante.Location = new System.Drawing.Point(193, 387);
            this.lbl_restante.Name = "lbl_restante";
            this.lbl_restante.Size = new System.Drawing.Size(66, 24);
            this.lbl_restante.TabIndex = 17;
            this.lbl_restante.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Monto Restante:";
            // 
            // dgv_lista
            // 
            this.dgv_lista.AllowUserToAddRows = false;
            this.dgv_lista.AllowUserToDeleteRows = false;
            this.dgv_lista.AllowUserToResizeColumns = false;
            this.dgv_lista.AllowUserToResizeRows = false;
            this.dgv_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FP,
            this.Monto,
            this.eliminar});
            this.dgv_lista.Location = new System.Drawing.Point(333, 105);
            this.dgv_lista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.RowHeadersVisible = false;
            this.dgv_lista.RowHeadersWidth = 51;
            this.dgv_lista.RowTemplate.Height = 25;
            this.dgv_lista.Size = new System.Drawing.Size(252, 282);
            this.dgv_lista.TabIndex = 15;
            this.dgv_lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lista_CellContentClick);
            // 
            // FP
            // 
            this.FP.HeaderText = "Forma Pago";
            this.FP.MinimumWidth = 6;
            this.FP.Name = "FP";
            this.FP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.MinimumWidth = 6;
            this.eliminar.Name = "eliminar";
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tb_monto
            // 
            this.tb_monto.Location = new System.Drawing.Point(40, 200);
            this.tb_monto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_monto.Name = "tb_monto";
            this.tb_monto.Size = new System.Drawing.Size(171, 27);
            this.tb_monto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Monto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Forma de Pago:";
            // 
            // cb_fp
            // 
            this.cb_fp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_fp.FormattingEnabled = true;
            this.cb_fp.Location = new System.Drawing.Point(40, 129);
            this.cb_fp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_fp.Name = "cb_fp";
            this.cb_fp.Size = new System.Drawing.Size(171, 28);
            this.cb_fp.TabIndex = 0;
            // 
            // barrasuperior
            // 
            this.barrasuperior.BackColor = System.Drawing.Color.Maroon;
            this.barrasuperior.Controls.Add(this.btnCerrar);
            this.barrasuperior.Controls.Add(this.label9);
            this.barrasuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barrasuperior.Location = new System.Drawing.Point(0, 0);
            this.barrasuperior.Name = "barrasuperior";
            this.barrasuperior.Size = new System.Drawing.Size(610, 76);
            this.barrasuperior.TabIndex = 37;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Maroon;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(577, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 29);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 36);
            this.label9.TabIndex = 20;
            this.label9.Text = "PAGO";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(333, 417);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(109, 43);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // PagosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 491);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.barrasuperior);
            this.Controls.Add(this.btn_terminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_restante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_lista);
            this.Controls.Add(this.tb_monto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_fp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PagosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).EndInit();
            this.barrasuperior.ResumeLayout(false);
            this.barrasuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_terminar;
        private Button btn_agregar;
        private Label lbl_total;
        private Label label6;
        private Label lbl_restante;
        private Label label3;
        private DataGridView dgv_lista;
        private TextBox tb_monto;
        private Label label2;
        private Label label1;
        private ComboBox cb_fp;
        private Panel barrasuperior;
        private Label label9;
        private PictureBox btnCerrar;
        private DataGridViewTextBoxColumn FP;
        private DataGridViewTextBoxColumn Monto;
        private Button btn_cancelar;
        private DataGridViewButtonColumn eliminar;
    }
}