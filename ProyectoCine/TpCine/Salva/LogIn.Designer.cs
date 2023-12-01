namespace TpLab.Salva
{
    partial class LogIn
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBoxPP = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.LblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.MaskedTextBox();
            this.TxtPass = new System.Windows.Forms.MaskedTextBox();
            this.lblNoValido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPP)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TpLab.Properties.Resources.LogoPng;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PictureBoxPP
            // 
            this.PictureBoxPP.Image = global::TpLab.Properties.Resources.LoginPP;
            this.PictureBoxPP.Location = new System.Drawing.Point(221, 52);
            this.PictureBoxPP.Name = "PictureBoxPP";
            this.PictureBoxPP.Size = new System.Drawing.Size(183, 165);
            this.PictureBoxPP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxPP.TabIndex = 1;
            this.PictureBoxPP.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.Image = global::TpLab.Properties.Resources.Remove64x64;
            this.BtnExit.Location = new System.Drawing.Point(565, 12);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(44, 41);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(154, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Iniciar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Miriam Libre", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUser.Location = new System.Drawing.Point(235, 244);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(138, 39);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Usuario:";
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("Miriam Libre", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPass.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblPass.Location = new System.Drawing.Point(211, 363);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(187, 39);
            this.LblPass.TabIndex = 7;
            this.LblPass.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Alef", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUser.Location = new System.Drawing.Point(178, 286);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(267, 32);
            this.txtUser.TabIndex = 9;
            // 
            // TxtPass
            // 
            this.TxtPass.Font = new System.Drawing.Font("Alef", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPass.Location = new System.Drawing.Point(178, 405);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(267, 32);
            this.TxtPass.TabIndex = 10;
            this.TxtPass.UseSystemPasswordChar = true;
            // 
            // lblNoValido
            // 
            this.lblNoValido.AutoSize = true;
            this.lblNoValido.ForeColor = System.Drawing.Color.Red;
            this.lblNoValido.Location = new System.Drawing.Point(121, 462);
            this.lblNoValido.Name = "lblNoValido";
            this.lblNoValido.Size = new System.Drawing.Size(387, 20);
            this.lblNoValido.TabIndex = 11;
            this.lblNoValido.Text = "Se ha proporcionado un usuario o contraseña incorrectos";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(621, 580);
            this.Controls.Add(this.lblNoValido);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.PictureBoxPP);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox PictureBoxPP;
        private Button BtnExit;
        private Button button1;
        private Label lblUser;
        private Label LblPass;
        private MaskedTextBox txtUser;
        private MaskedTextBox TxtPass;
        private Label lblNoValido;
    }
}