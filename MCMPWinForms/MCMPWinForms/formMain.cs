using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace MCMPWinForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FillIntegral();
            if (inscriptionsBindingSource.Count == 0)
            {
                buttonDesinscrireAdherent.Enabled = false;
            }
            else
            {
                buttonDesinscrireAdherent.Enabled = true;

            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void adherentsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            



            if (adherentsBindingSource.Current != null)
            {

                cda27_bd2DataSet.adherentsRow currentRow = (cda27_bd2DataSet.adherentsRow)((DataRowView)adherentsBindingSource.Current).Row;
                // TODO: cette ligne de code charge les données dans la table 'cda27_bd2DataSet.activite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
                this.inscriptionsTableAdapter.Fill(this.cda27_bd2DataSet.inscriptions, currentRow.IdAdherent);

            }
            if (inscriptionsBindingSource.Count != 0)
            {
                buttonDesinscrireAdherent.Enabled = true;
            }
            else
            {
                buttonDesinscrireAdherent.Enabled = false;

            }

        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            using (formDetailAdherent formDetailAdherent = new formDetailAdherent())
            {
                cda27_bd2DataSet.adherentsRow currentRow = (cda27_bd2DataSet.adherentsRow)((DataRowView)adherentsBindingSource.Current).Row;
                formDetailAdherent.textBoxNom.Text = currentRow.Nom;
                formDetailAdherent.textBoxPrenom.Text = currentRow.Prénom;
                formDetailAdherent.textBoxAge.Text = null;
                formDetailAdherent.dateTimePickerDateDeNaissance.Value = currentRow.Date_de_naissance;
                formDetailAdherent.dateTimePickerDateAdhesion.Value = currentRow._Date_d_adhésion;
                formDetailAdherent.textBoxAdresse.Text = currentRow.Adresse;
                formDetailAdherent.textBoxCodePostale.Text = currentRow.Code_postale;
                formDetailAdherent.textBoxVille.Text = currentRow.Ville;
                formDetailAdherent.textBoxEmail.Text = currentRow.Email;
                formDetailAdherent.textBoxTelephone.Text = currentRow.Téléphone;
                formDetailAdherent.textBoxLogin.Text = currentRow.Login;
                if (currentRow.Organisateur == 1)
                {
                    formDetailAdherent.checkBoxOrganisateur.Checked = true;
                }
                else
                {
                    formDetailAdherent.checkBoxOrganisateur.Checked = false;
                }
                if (currentRow.Activé == 1)
                {
                    formDetailAdherent.checkBoxActive.Checked = true;

                }
                else
                {
                    formDetailAdherent.checkBoxActive.Checked = false;
                }
                formDetailAdherent.textBoxCylindree.Text = currentRow.Cylindrée;
                formDetailAdherent.textBoxAPropos.Text = currentRow.A_propos;
                formDetailAdherent.inscriptionsTableAdapter.Fill(formDetailAdherent.cda27_bd2DataSet.inscriptions, currentRow.IdAdherent);
                string FileAvatar = currentRow.IsAvatarNull() ? Properties.Resources.STR_AVATAR_PAR_DEFAUT : currentRow.Avatar;
                formDetailAdherent.pictureBoxAvatar.ImageLocation = Properties.Resources.STR_ADRESSE_AVATAR + FileAvatar;
                formDetailAdherent.btAjouter.Visible = false;

                formDetailAdherent.adherentbind = adherentsBindingSource;
                formDetailAdherent.ShowDialog();
                if (formDetailAdherent.IsClose == 1)
                {
                    FillIntegral();
                    adherentsBindingSource.Position = adherentsBindingSource.Find("IdAdherent", formDetailAdherent.LastInsert);
                    formDetailAdherent.IsClose = 0;
                }
            }


        }


        private void buttonModifierActivite_Click(object sender, EventArgs e)
        {
            using (formDetailActivite frmDetailActivite = new formDetailActivite())
            {
                frmDetailActivite.adherentbind = activitesBindingSourceListeAct;
                cda27_bd2DataSet.activitesRow currentRow = (cda27_bd2DataSet.activitesRow)((DataRowView)activitesBindingSourceListeAct.Current).Row;
                frmDetailActivite.IdActivite = currentRow.IdActivite;
                frmDetailActivite.buttonAjouterActivite.Visible = false;
                frmDetailActivite.textBoxPrenomResp.Text = currentRow.Prénom_du_responsable;
                frmDetailActivite.textBoxNomResp.Text = currentRow.Nom_du_responsable;
                frmDetailActivite.textBoxTarifInvite.Text = currentRow.Tarif_invité;
                frmDetailActivite.textBoxTarifAdherent.Text = currentRow.Tarif_adhérent;
                frmDetailActivite.textBoxIntituleAct.Text = currentRow.Intitulé;
                frmDetailActivite.dateTimePickerDateDebut.Value = currentRow.Date_de_début;
                frmDetailActivite.dateTimePickerDateFin.Value = currentRow.Date_de_fin;
                frmDetailActivite.dateTimePickerDateLimite.Value = currentRow._Date_limite_d_inscription;
                frmDetailActivite.textBoxDescription.Text = Convert.ToString(currentRow.Description);
                frmDetailActivite.IdType = currentRow.IdType;
                frmDetailActivite.ModifEnCours = 1;
                frmDetailActivite.ShowDialog();
                if (frmDetailActivite.IsClose == 1)
                {
                    activitesBindingSourceListeAct.Position = activitesBindingSourceListeAct.Find("IdActivite", frmDetailActivite.LastInsert);
                    this.FillIntegral();
                    frmDetailActivite.IsClose = 0;
                    frmDetailActivite.ModifEnCours = 0;
                }
            }

        }

        private void buttonRafraichirActivite_Click(object sender, EventArgs e)
        {
            FillIntegral();
        }

        private void buttonRafraichirAdherent_Click(object sender, EventArgs e)
        {
            FillIntegral();
        }

        private void buttonAjouterAdherent_Click(object sender, EventArgs e)
        {
            using (formDetailAdherent frmDetailAdherent = new formDetailAdherent())
            {
                frmDetailAdherent.dataGridViewFormDetailAdherentInscrits.Visible = false;
                frmDetailAdherent.lblInscritsAuxActivites.Visible = false;
                frmDetailAdherent.dateTimePickerDateAdhesion.Enabled = false;
                frmDetailAdherent.btModifier.Visible = false;
                frmDetailAdherent.btSupprimer.Visible = false;
                frmDetailAdherent.btDesinscrireAdherent.Visible = false;
                frmDetailAdherent.ShowDialog();
                if (frmDetailAdherent.IsClose == 1)
                {
                    FillIntegral();
                    adherentsBindingSource.Position = adherentsBindingSource.Find("IdAdherent", frmDetailAdherent.LastInsert);
                    frmDetailAdherent.IsClose = 0;
                }
            }
        }

        private void buttonAjouterActivite_Click(object sender, EventArgs e)
        {
            using (formDetailActivite frmDetailActivite = new formDetailActivite())
            {
                frmDetailActivite.buttonModifierActivite.Visible = false;
                frmDetailActivite.buttonSupprimerActivite.Visible = false;
                frmDetailActivite.lblInscrits.Visible = false;
                frmDetailActivite.dataGridViewInscrits.Visible = false;
                frmDetailActivite.ShowDialog();
                if (frmDetailActivite.IsClose == 1)
                {
                    FillIntegral();
                    activitesBindingSourceListeAct.Position = activitesBindingSourceListeAct.Find("IdActivite", frmDetailActivite.LastInsert);
                    frmDetailActivite.IsClose = 0;
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult DiagResult = MessageBox.Show(Properties.Resources.STR_MESSAGE_FERMER, Properties.Resources.STR_TITRE_FERMER, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (DiagResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void buttonFermerActivite_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonFermerAdherent_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void FillIntegral()
        {
            if (checkBoxChoisirDate.Checked)
            {
                this.activitesTableAdapter.FillByDate(this.cda27_bd2DataSet.activites, dateTimePickerFirstDate.Value, dateTimePickerSecondDate.Value); ;

            }
            else
            {
                this.activitesTableAdapter.Fill(this.cda27_bd2DataSet.activites);
            }
            cda27_bd2DataSet.activitesRow currentRow = (cda27_bd2DataSet.activitesRow)((DataRowView)activitesBindingSourceListeAct.Current).Row;

            // TODO: cette ligne de code charge les données dans la table 'cda27_bd2DataSet1.adherentinscription'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.adherentinscriptionTableAdapter.FillBy(this.cda27_bd2DataSet1.adherentinscription, currentRow.IdActivite);
            // TODO: cette ligne de code charge les données dans la table 'cda27_bd2DataSet1.adherents2'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.adherents2TableAdapter.FillBy(this.cda27_bd2DataSet1.adherents2, currentRow.IdActivite);

            this.adherentsTableAdapter.Fill(this.cda27_bd2DataSet.adherents);
            cda27_bd2DataSet.adherentsRow currentRow2 = (cda27_bd2DataSet.adherentsRow)((DataRowView)adherentsBindingSource.Current).Row;
            this.inscriptionsTableAdapter.Fill(this.cda27_bd2DataSet.inscriptions, currentRow2.IdAdherent);
            dataGridViewNonInscrits.ClearSelection();
            dataGridViewInscrits.ClearSelection();
        }


        private void checkBoxChoisirDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChoisirDate.Checked)
            {
                dateTimePickerFirstDate.Enabled = true;
                dateTimePickerSecondDate.Enabled = true;
                buttonSearch.Enabled = true;
            }
            else
            {
                dateTimePickerFirstDate.Enabled = false;
                dateTimePickerSecondDate.Enabled = false;
                buttonSearch.Enabled = false;
                FillIntegral();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FillIntegral();
        }

        private void dataGridViewNonInscrits_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewInscrits.ClearSelection();
            buttonInscrireAdherentActivite.Enabled = true;
            buttonDesinscrireAdherentActivite.Enabled = false;

        }

        private void dataGridViewInscrits_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewNonInscrits.ClearSelection();
            buttonInscrireAdherentActivite.Enabled = false;
            buttonDesinscrireAdherentActivite.Enabled = true;
        }

        private void activitesBindingSourceListeAct_CurrentChanged_1(object sender, EventArgs e)
        {
            if (activitesBindingSourceListeAct.Current != null)
            {
                cda27_bd2DataSet.activitesRow currentRow = (cda27_bd2DataSet.activitesRow)((DataRowView)activitesBindingSourceListeAct.Current).Row;

                // TODO: cette ligne de code charge les données dans la table 'cda27_bd2DataSet1.adherentinscription'. Vous pouvez la déplacer ou la supprimer selon les besoins.
                this.adherentinscriptionTableAdapter.FillBy(this.cda27_bd2DataSet1.adherentinscription, currentRow.IdActivite);
                // TODO: cette ligne de code charge les données dans la table 'cda27_bd2DataSet1.adherents2'. Vous pouvez la déplacer ou la supprimer selon les besoins.
                this.adherents2TableAdapter.FillBy(this.cda27_bd2DataSet1.adherents2, currentRow.IdActivite);

            }
        }

        private void buttonDesinscrireAdherent_Click(object sender, EventArgs e)
        {
            cda27_bd2DataSet.inscriptionsRow currentRow = (cda27_bd2DataSet.inscriptionsRow)((DataRowView)inscriptionsBindingSource.Current).Row;
            int IdAdherent = currentRow.IdAdherent;
            DialogResult DiagResult = MessageBox.Show(Properties.Resources.STR_MESSAGE_SUPPRIMER_INSCRIPTION, Properties.Resources.STR_TITRE_SUPPRIMER_INSCRIPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (DiagResult == DialogResult.No)
            {
                return;
            }
            int nb = inscriptionTableAdapter1.Delete(currentRow.IdInscription,
                currentRow._Date_d_inscription,
                currentRow._Nombre_d_invités,
                currentRow.IdAdherent,
                currentRow.IdActivite);
            if (nb == 0)
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_PROBLEME_SUPPRESSION_INSCRIPTION, Properties.Resources.STR_TITRE_PROBLEME_SUPPRESSION_INSCRIPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FillIntegral();
            adherentsBindingSource.Position = adherentsBindingSource.Find("IdAdherent", IdAdherent);
        }

        private void buttonInscrireAdherentActivite_Click(object sender, EventArgs e)
        {
            cda27_bd2DataSet.activitesRow currentRow = (cda27_bd2DataSet.activitesRow)((DataRowView)activitesBindingSourceListeAct.Current).Row;
            int IdActivite = currentRow.IdActivite;
            cda27_bd2DataSet.adherents2Row currentRow2 = (cda27_bd2DataSet.adherents2Row)((DataRowView)adherents2BindingSource.Current).Row;
            using (FormInscriptionActivite frmInscriptionActivite = new FormInscriptionActivite())
            {
                frmInscriptionActivite.IdActivite = currentRow.IdActivite;
                frmInscriptionActivite.IdAdherent = currentRow2.IdAdherent;
                frmInscriptionActivite.textBoxIntituleAct.Text = currentRow.Intitulé;
                frmInscriptionActivite.textBoxDescription.Text = currentRow.Description;
                frmInscriptionActivite.textBoxTarifAdherent.Text = currentRow.Tarif_adhérent;
                frmInscriptionActivite.textBoxTarifInvite.Text = currentRow.Tarif_invité;
                frmInscriptionActivite.dateTimePickerDateDebutAct.Value = currentRow.Date_de_début;
                frmInscriptionActivite.dateTimePickerDateFinAct.Value = currentRow.Date_de_fin;
                frmInscriptionActivite.dateTimePickerDateLimiteAct.Value = currentRow._Date_limite_d_inscription;
                frmInscriptionActivite.textBoxNombreInvite.Text = "0";
                frmInscriptionActivite.textBoxLogin.Text = currentRow2.Login;
                frmInscriptionActivite.textBoxNom.Text = currentRow2.Nom;
                frmInscriptionActivite.textBoxPrenom.Text = currentRow2.Prénom;
                frmInscriptionActivite.textBoxCylindrée.Text = currentRow2.Cylindrée;
                frmInscriptionActivite.ShowDialog();
                if (frmInscriptionActivite.InscriptionFinie == 1)
                {
                    FillIntegral();
                    frmInscriptionActivite.InscriptionFinie = 0;
                    activitesBindingSourceListeAct.Position = activitesBindingSourceListeAct.Find("IdActivite", IdActivite);

                }

            }
        }

        private void buttonDesinscrireAdherentActivite_Click(object sender, EventArgs e)
        {
            cda27_bd2DataSet.adherentinscriptionRow currentRow2 = (cda27_bd2DataSet.adherentinscriptionRow)((DataRowView)adherentinscriptionBindingSource.Current).Row;
            cda27_bd2DataSet.activitesRow currentRow = (cda27_bd2DataSet.activitesRow)((DataRowView)activitesBindingSourceListeAct.Current).Row;
            int IdActivite = currentRow.IdActivite;
            
            DialogResult DiagResult = MessageBox.Show(String.Format(Properties.Resources.STR_MESSAGE_CONFIRMATION_SUPPRESSION, currentRow2.Prénom),
                                                        String.Format(Properties.Resources.STR_TITRE_CONFIRMATION_SUPPRESSION, currentRow2.Prénom, currentRow2.Nom),
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Information,
                                                        MessageBoxDefaultButton.Button2);
            if (DiagResult == DialogResult.Yes)
            {
                int nb = inscriptionTableAdapter1.Delete(currentRow2.IdInscription, currentRow2.DInscription, currentRow2.NbInvités,
                    currentRow2.IdAdherent, currentRow2.IdActivite);
                if (nb == 0)
                {
                    MessageBox.Show(Properties.Resources.STR_MESSAGE_DESINSCRIPTION_ERREUR, Properties.Resources.STR_TITRE_DESINSCRIPTION_ERREUR, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                return;
            }
            FillIntegral();
            activitesBindingSourceListeAct.Position = activitesBindingSourceListeAct.Find("IdActivite", IdActivite);
        }

        private void buttonSupprimerAdherent_Click(object sender, EventArgs e)
        {
            cda27_bd2DataSet.adherentsRow currentRow = (cda27_bd2DataSet.adherentsRow)((DataRowView)adherentsBindingSource.Current).Row;
            DialogResult DiagResult = MessageBox.Show(String.Format(Properties.Resources.STR_MESSAGE_SUPPRESSION_ADHERENT), String.Format(Properties.Resources.STR_TITRE_SUPPRESSION_ADHERENT), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (DiagResult == DialogResult.Yes)
            {
                int nb = adherentTableAdapter.Delete(currentRow.IdAdherent, currentRow.Nom, currentRow.Prénom, currentRow.Date_de_naissance, currentRow.Adresse,
                    null, currentRow.Code_postale, currentRow.Ville, currentRow.Email, currentRow.Téléphone, currentRow._Date_d_adhésion, currentRow.Organisateur,
                    currentRow.Admin, currentRow.Login, currentRow.Password, currentRow.Cylindrée, currentRow.Activé);
                if (nb == 0)
                {
                    MessageBox.Show(Properties.Resources.STR_MESSAGE_SUPPRESSION_FAIL, Properties.Resources.STR_TITRE_SUPPRESSION_FAIL, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FillIntegral();
            }
        }

        private void dataGridViewActiviteRelationAdherent_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSupprimerActivite_Click(object sender, EventArgs e)
        {
            cda27_bd2DataSet.activitesRow currentRow = (cda27_bd2DataSet.activitesRow)((DataRowView)activitesBindingSourceListeAct.Current).Row;
            DialogResult DiagResult = MessageBox.Show("Voulez-vous vraiment supprimer cette activité ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (DiagResult == DialogResult.Yes)
            {
                int nb = activiteTableAdapter1.Delete(currentRow.IdActivite, currentRow.Intitulé, currentRow.Date_de_début,
                    currentRow.Date_de_fin, currentRow.Description, currentRow.Tarif_adhérent, currentRow.Tarif_invité,
                    currentRow._Date_limite_d_inscription, currentRow.IdAdherent, currentRow.IdType, currentRow.Publié);
                if (nb == 0)
                {
                    MessageBox.Show("La suppression ne s'est pas effectuée");
                }
                FillIntegral();
            }
        }
    }
}
