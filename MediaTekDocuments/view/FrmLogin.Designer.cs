namespace MediaTekDocuments.view
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbMdp = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblLogin
            //
            this.lblLogin.Location = new System.Drawing.Point(20, 25);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(90, 20);
            this.lblLogin.Text = "Login :";
            //
            // txbLogin
            //
            this.txbLogin.Location = new System.Drawing.Point(115, 22);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(170, 20);
            this.txbLogin.TabIndex = 0;
            //
            // lblMdp
            //
            this.lblMdp.Location = new System.Drawing.Point(20, 58);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(90, 20);
            this.lblMdp.Text = "Mot de passe :";
            //
            // txbMdp
            //
            this.txbMdp.Location = new System.Drawing.Point(115, 55);
            this.txbMdp.Name = "txbMdp";
            this.txbMdp.PasswordChar = '*';
            this.txbMdp.Size = new System.Drawing.Size(170, 20);
            this.txbMdp.TabIndex = 1;
            //
            // btnConnexion
            //
            this.btnConnexion.Location = new System.Drawing.Point(115, 90);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(100, 28);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            //
            // FrmLogin
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 140);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.txbMdp);
            this.Controls.Add(this.btnConnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbMdp;
        private System.Windows.Forms.Button btnConnexion;
    }
}
