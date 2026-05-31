namespace habilitations2024.view
{
    partial class FrmHabilitations
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            this.dgvDeveloppeurs = new System.Windows.Forms.DataGridView();
            this.grpInfos = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblProfil = new System.Windows.Forms.Label();
            this.cboProfil = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifierPwd = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeveloppeurs)).BeginInit();
            this.grpInfos.SuspendLayout();
            this.SuspendLayout();

            // lblTitre
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(12, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(280, 25);
            this.lblTitre.TabIndex = 10;
            this.lblTitre.Text = "Gestion des habilitations";

            // dgvDeveloppeurs
            this.dgvDeveloppeurs.AllowUserToAddRows = false;
            this.dgvDeveloppeurs.AllowUserToDeleteRows = false;
            this.dgvDeveloppeurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeveloppeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeveloppeurs.Location = new System.Drawing.Point(12, 45);
            this.dgvDeveloppeurs.MultiSelect = false;
            this.dgvDeveloppeurs.Name = "dgvDeveloppeurs";
            this.dgvDeveloppeurs.ReadOnly = true;
            this.dgvDeveloppeurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeveloppeurs.Size = new System.Drawing.Size(760, 200);
            this.dgvDeveloppeurs.TabIndex = 0;
            this.dgvDeveloppeurs.SelectionChanged += new System.EventHandler(this.dgvDeveloppeurs_SelectionChanged);

            // grpInfos
            this.grpInfos.Controls.Add(this.lblNom);
            this.grpInfos.Controls.Add(this.txtNom);
            this.grpInfos.Controls.Add(this.lblPrenom);
            this.grpInfos.Controls.Add(this.txtPrenom);
            this.grpInfos.Controls.Add(this.lblTel);
            this.grpInfos.Controls.Add(this.txtTel);
            this.grpInfos.Controls.Add(this.lblMail);
            this.grpInfos.Controls.Add(this.txtMail);
            this.grpInfos.Controls.Add(this.lblProfil);
            this.grpInfos.Controls.Add(this.cboProfil);
            this.grpInfos.Location = new System.Drawing.Point(12, 260);
            this.grpInfos.Name = "grpInfos";
            this.grpInfos.Size = new System.Drawing.Size(760, 160);
            this.grpInfos.TabIndex = 1;
            this.grpInfos.TabStop = false;
            this.grpInfos.Text = "Informations du développeur";

            // lblNom
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(15, 30);
            this.lblNom.Text = "Nom :";

            // txtNom
            this.txtNom.Location = new System.Drawing.Point(100, 27);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(150, 23);

            // lblPrenom
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(15, 65);
            this.lblPrenom.Text = "Prénom :";

            // txtPrenom
            this.txtPrenom.Location = new System.Drawing.Point(100, 62);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(150, 23);

            // lblTel
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(15, 100);
            this.lblTel.Text = "Téléphone :";

            // txtTel
            this.txtTel.Location = new System.Drawing.Point(100, 97);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(150, 23);

            // lblMail
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(300, 30);
            this.lblMail.Text = "Mail :";

            // txtMail
            this.txtMail.Location = new System.Drawing.Point(380, 27);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 23);

            // lblProfil
            this.lblProfil.AutoSize = true;
            this.lblProfil.Location = new System.Drawing.Point(300, 65);
            this.lblProfil.Text = "Profil :";

            // cboProfil
            this.cboProfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfil.Location = new System.Drawing.Point(380, 62);
            this.cboProfil.Name = "cboProfil";
            this.cboProfil.Size = new System.Drawing.Size(200, 23);

            // btnAjouter
            this.btnAjouter.Location = new System.Drawing.Point(12, 435);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(110, 35);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            // btnModifier
            this.btnModifier.Location = new System.Drawing.Point(135, 435);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(110, 35);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

            // btnSupprimer
            this.btnSupprimer.Location = new System.Drawing.Point(258, 435);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(110, 35);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

            // btnModifierPwd
            this.btnModifierPwd.Location = new System.Drawing.Point(381, 435);
            this.btnModifierPwd.Name = "btnModifierPwd";
            this.btnModifierPwd.Size = new System.Drawing.Size(140, 35);
            this.btnModifierPwd.TabIndex = 5;
            this.btnModifierPwd.Text = "Modifier le mot de passe";
            this.btnModifierPwd.Click += new System.EventHandler(this.btnModifierPwd_Click);

            // FrmHabilitations
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.dgvDeveloppeurs);
            this.Controls.Add(this.grpInfos);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifierPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmHabilitations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Habilitations";
            this.Load += new System.EventHandler(this.FrmHabilitations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeveloppeurs)).EndInit();
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeveloppeurs;
        private System.Windows.Forms.GroupBox grpInfos;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.ComboBox cboProfil;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifierPwd;
        private System.Windows.Forms.Label lblTitre;
    }
}
