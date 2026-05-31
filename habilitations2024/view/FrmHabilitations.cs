using habilitations2024.controller;
using habilitations2024.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace habilitations2024.view
{
    public partial class FrmHabilitations : Form
    {
        private readonly FrmHabilitationsController controller = new FrmHabilitationsController();
        private List<Developpeur> lesDeveloppeurs;
        private List<Profil> lesProfils;

        public FrmHabilitations()
        {
            InitializeComponent();
        }

        // ── CHARGEMENT ────────────────────────────────────────────────
        private void FrmHabilitations_Load(object sender, EventArgs e)
        {
            ChargerProfils();
            ChargerDeveloppeurs();
        }

        private void ChargerProfils()
        {
            lesProfils = controller.GetAllProfils();
            cboProfil.DataSource = lesProfils;
            cboProfil.DisplayMember = "LibelleProfil";
            cboProfil.ValueMember = "IdProfil";
        }

        private void ChargerDeveloppeurs()
        {
            lesDeveloppeurs = controller.GetAllDeveloppeurs();
            dgvDeveloppeurs.DataSource = null;
            dgvDeveloppeurs.Rows.Clear();
            dgvDeveloppeurs.Columns.Clear();

            dgvDeveloppeurs.Columns.Add("colNom", "Nom");
            dgvDeveloppeurs.Columns.Add("colPrenom", "Prénom");
            dgvDeveloppeurs.Columns.Add("colTel", "Téléphone");
            dgvDeveloppeurs.Columns.Add("colMail", "Mail");
            dgvDeveloppeurs.Columns.Add("colProfil", "Profil");

            foreach (Developpeur dev in lesDeveloppeurs)
            {
                dgvDeveloppeurs.Rows.Add(dev.Nom, dev.Prenom, dev.Tel, dev.Mail, dev.LeProfil.LibelleProfil);
            }

            if (dgvDeveloppeurs.Rows.Count > 0)
                dgvDeveloppeurs.Rows[0].Selected = true;
        }

        // ── SÉLECTION DANS LA GRILLE ──────────────────────────────────
        private void dgvDeveloppeurs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeveloppeurs.SelectedRows.Count == 0) return;
            int index = dgvDeveloppeurs.SelectedRows[0].Index;
            if (index >= lesDeveloppeurs.Count) return;

            Developpeur dev = lesDeveloppeurs[index];
            txtNom.Text = dev.Nom;
            txtPrenom.Text = dev.Prenom;
            txtTel.Text = dev.Tel;
            txtMail.Text = dev.Mail;
            cboProfil.SelectedValue = dev.LeProfil.IdProfil;
        }

        // ── AJOUTER ───────────────────────────────────────────────────
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!SaisieValide()) return;

            Profil profil = (Profil)cboProfil.SelectedItem;
            Developpeur dev = new Developpeur(0, txtNom.Text.Trim(), txtPrenom.Text.Trim(),
                txtTel.Text.Trim(), txtMail.Text.Trim(), txtNom.Text.Trim(), profil);

            controller.AddDeveloppeur(dev);
            MessageBox.Show("Développeur ajouté. Mot de passe par défaut : " + txtNom.Text.Trim(),
                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ChargerDeveloppeurs();
        }

        // ── MODIFIER ──────────────────────────────────────────────────
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvDeveloppeurs.SelectedRows.Count == 0) return;
            if (!SaisieValide()) return;

            int index = dgvDeveloppeurs.SelectedRows[0].Index;
            Developpeur dev = lesDeveloppeurs[index];
            dev.Nom = txtNom.Text.Trim();
            dev.Prenom = txtPrenom.Text.Trim();
            dev.Tel = txtTel.Text.Trim();
            dev.Mail = txtMail.Text.Trim();
            dev.LeProfil = (Profil)cboProfil.SelectedItem;

            controller.UpdateDeveloppeur(dev);
            MessageBox.Show("Développeur modifié.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ChargerDeveloppeurs();
        }

        // ── SUPPRIMER ─────────────────────────────────────────────────
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvDeveloppeurs.SelectedRows.Count == 0) return;
            int index = dgvDeveloppeurs.SelectedRows[0].Index;
            Developpeur dev = lesDeveloppeurs[index];

            DialogResult result = MessageBox.Show(
                $"Supprimer {dev.Prenom} {dev.Nom} ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                controller.DeleteDeveloppeur(dev.IdDeveloppeur);
                ChargerDeveloppeurs();
            }
        }

        // ── MODIFIER MOT DE PASSE ─────────────────────────────────────
        private void btnModifierPwd_Click(object sender, EventArgs e)
        {
            if (dgvDeveloppeurs.SelectedRows.Count == 0) return;
            int index = dgvDeveloppeurs.SelectedRows[0].Index;
            Developpeur dev = lesDeveloppeurs[index];

            string nouveauPwd = Microsoft.VisualBasic.Interaction.InputBox(
                $"Nouveau mot de passe pour {dev.Prenom} {dev.Nom} :",
                "Modifier le mot de passe", "");

            if (!string.IsNullOrWhiteSpace(nouveauPwd))
            {
                controller.UpdatePwd(dev.IdDeveloppeur, nouveauPwd);
                MessageBox.Show("Mot de passe modifié.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ── VALIDATION ────────────────────────────────────────────────
        private bool SaisieValide()
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                MessageBox.Show("Nom et prénom sont obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
