namespace FrontCine.Formularios.Reportes
{
    partial class ReporteBillHistory
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
            this.btnconsultar = new System.Windows.Forms.Button();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnconsultar
            // 
            this.btnconsultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnconsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnconsultar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnconsultar.Location = new System.Drawing.Point(589, 33);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(143, 41);
            this.btnconsultar.TabIndex = 2;
            this.btnconsultar.Text = "CONSULTAR";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // dtpfin
            // 
            this.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfin.Location = new System.Drawing.Point(203, 47);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(110, 27);
            this.dtpfin.TabIndex = 1;
            // 
            // dtpinicio
            // 
            this.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpinicio.Location = new System.Drawing.Point(26, 47);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(109, 27);
            this.dtpinicio.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Location = new System.Drawing.Point(0, 100);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(812, 418);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha de inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Fin";
            // 
            // ReporteBillHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.dtpfin);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteBillHistory";
            this.Text = "ReporteBillHistory";
            this.Load += new System.EventHandler(this.ReporteBillHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnconsultar;
        private DateTimePicker dtpfin;
        private DateTimePicker dtpinicio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Label label1;
        private Label label2;
    }
}