using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMPWinForms
{
    public partial class formDetailActivite : Form
    {
        #region GET/SET pour faire le lien entre la FormMain et sa fille
        public BindingSource activitebind { get; set; }
        public BindingSource adherentbind { set; get; }
        public long LastInsert { get; set; }
        public int IdType { get; set; }
        public int IsClose { get; set; }
        public int ModifEnCours { get; set; }
        public int IdActivite { get; set; }
        #endregion

        public formDetailActivite()
        {
            InitializeComponent();
        }

        private void formDetailActivite_Load(object sender, EventArgs e)
        {
            inscriptionsTableAdapter.FillBy(this.cda27_bd2DataSet.inscriptions, IdActivite);
            // TODO: cette ligne de code charge les données dans la table 'cda27_bd2DataSet2.type_activite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.type_activiteTableAdapter.Fill(this.cda27_bd2DataSet2.type_activite);
            if (ModifEnCours == 1)
            {
            typeactiviteBindingSource.Position = typeactiviteBindingSource.Find("IdType", IdType);
            }

        }
        #region Ajouter
        private void buttonAjouterActivite_Click(object sender, EventArgs e)
        {
            cda27_bd2DataSet.type_activiteRow currentRow = (cda27_bd2DataSet.type_activiteRow)((DataRowView)typeactiviteBindingSource.Current).Row;
            int publier = checkBoxPublic.Checked ? 1 : 0;
            if (String.IsNullOrWhiteSpace(textBoxIntituleAct.Text) 
                || String.IsNullOrWhiteSpace(textBoxDescription.Text)
                || String.IsNullOrWhiteSpace(textBoxTarifAdherent.Text)
                || String.IsNullOrWhiteSpace(textBoxTarifInvite.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_CHAMPS_NON_REMPLI, 
                    Properties.Resources.STR_TITRE_CHAMPS_NON_REMPLI,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            if (dateTimePickerDateDebut.Value < DateTime.Now 
                && dateTimePickerDateDebut.Value > dateTimePickerDateFin.Value
                && dateTimePickerDateLimite.Value < dateTimePickerDateDebut.Value
                && dateTimePickerDateLimite.Value > dateTimePickerDateFin.Value)
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_DATE_ACT_PROBLEME,
                    Properties.Resources.STR_TITRE_DATE_ACT_PROBLEME,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else if (!IsPrix(textBoxTarifAdherent.Text) || !IsPrix(textBoxTarifInvite.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_TARIF_PROBLEME,
                    Properties.Resources.STR_TITRE_TARIF_PROBLEME,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            int nb = activiteTableAdapter.Insert(
                textBoxIntituleAct.Text,
                dateTimePickerDateDebut.Value,
                dateTimePickerDateFin.Value,
                textBoxDescription.Text,
                textBoxTarifAdherent.Text,
                textBoxTarifInvite.Text,
                dateTimePickerDateLimite.Value,
                100,
                currentRow.IdType,
                null,
                publier
                );
            if (nb == 1)
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_ACTIVITE_AJOUT_SUCCESS,
                    Properties.Resources.STR_TITRE_ACTIVITE_AJOUT_SUCCESS,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LastInsert = activiteTableAdapter.Adapter.InsertCommand.InsertId;
                IsClose = 1;
                Close();
            }
            else
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_PROBLEME_AJOUT_ACT,
                    Properties.Resources.STR_TITRE_PROBLEME_AJOUT_ACT,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Modifier
        private void buttonModifierActivite_Click(object sender, EventArgs e)
        {
            cda27_bd2DataSet.activitesRow currentRowAdh = (cda27_bd2DataSet.activitesRow)((DataRowView)activitebind.Current).Row;
            cda27_bd2DataSet.type_activiteRow currentRow = (cda27_bd2DataSet.type_activiteRow)((DataRowView)typeactiviteBindingSource.Current).Row;
            int publier = checkBoxPublic.Checked ? 1 : 0;
            if (String.IsNullOrWhiteSpace(textBoxIntituleAct.Text)
                || String.IsNullOrWhiteSpace(textBoxDescription.Text)
                || String.IsNullOrWhiteSpace(textBoxTarifAdherent.Text)
                || String.IsNullOrWhiteSpace(textBoxTarifInvite.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_CHAMPS_NON_REMPLI, 
                    Properties.Resources.STR_TITRE_CHAMPS_NON_REMPLI, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                return;
            }
            if (dateTimePickerDateDebut.Value < DateTime.Now
                && dateTimePickerDateDebut.Value > dateTimePickerDateFin.Value
                && dateTimePickerDateLimite.Value < dateTimePickerDateDebut.Value
                && dateTimePickerDateLimite.Value > dateTimePickerDateFin.Value)
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_DATE_ACT_PROBLEME, 
                    Properties.Resources.STR_TITRE_DATE_ACT_PROBLEME, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                return;
            }
            else if (!IsPrix(textBoxTarifAdherent.Text) || !IsPrix(textBoxTarifInvite.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_TARIF_PROBLEME, 
                    Properties.Resources.STR_TITRE_TARIF_PROBLEME,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            int nb = activiteTableAdapter.Update(
                textBoxIntituleAct.Text,
                dateTimePickerDateDebut.Value,
                dateTimePickerDateFin.Value,
                textBoxDescription.Text,
                textBoxTarifAdherent.Text,
                textBoxTarifInvite.Text,
                dateTimePickerDateLimite.Value,
                100,
                currentRow.IdType,
                null,
                publier,
                currentRowAdh.IdActivite,
                currentRowAdh.Intitulé, 
                currentRowAdh.Date_de_début, 
                currentRowAdh.Date_de_fin, 
                currentRowAdh.Description, 
                currentRowAdh.Tarif_adhérent, 
                currentRowAdh.Tarif_invité, 
                currentRowAdh._Date_limite_d_inscription, 
                currentRowAdh.IdAdherent, 
                currentRowAdh.IdType, 
                currentRowAdh.Publié
                );
            if (nb == 0)
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_MAJ_NON_REALISEE, 
                    Properties.Resources.STR_TITRE_MAJ_NON_REALISEE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            LastInsert = activiteTableAdapter.Adapter.UpdateCommand.InsertId;
            IsClose = 1;
            Close();
        }
        #endregion

        #region Supprimer
        private void buttonSupprimerActivite_Click(object sender, EventArgs e)
        {
            cda27_bd2DataSet.activitesRow currentRowAdh = (cda27_bd2DataSet.activitesRow)((DataRowView)activitebind.Current).Row;
            DialogResult DiagResult = MessageBox.Show(Properties.Resources.STR_MESSAGE_SUPPRESSION_ACTIVITE, Properties.Resources.STR_TITRE_SUPPRESSION_ACTIVITE, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (DiagResult == DialogResult.Yes)
            {
                int nb = activiteTableAdapter.Delete(currentRowAdh.IdActivite,
                currentRowAdh.Intitulé,
                currentRowAdh.Date_de_début,
                currentRowAdh.Date_de_fin,
                currentRowAdh.Description,
                currentRowAdh.Tarif_adhérent,
                currentRowAdh.Tarif_invité,
                currentRowAdh._Date_limite_d_inscription,
                currentRowAdh.IdAdherent,
                currentRowAdh.IdType,
                currentRowAdh.Publié);
                if (nb == 0)
                {
                    MessageBox.Show(Properties.Resources.STR_MESSAGE_SUPPRESSION_FAIL, 
                        Properties.Resources.STR_TITRE_SUPPRESSION_FAIL,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                return;
            } 
        }
        #endregion

        #region Bouton annuler
        private void buttonAnnulerActivite_Click(object sender, EventArgs e)
        {
            DialogResult DiagResult = MessageBox.Show("Voulez-vous vraiment annuler et fermer cette fenêtre ?", "Annuler", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (DiagResult == DialogResult.Yes)
            {
               Close();
            }
            else
            {
                return;
            }
        }
        #endregion

        #region Expression régulière
        public static bool IsPrix(string prix)
        {
            if (prix != null) return Regex.IsMatch(prix, Properties.Resources.STR_MOTIF_PRIX);
            else return false;
        }
        #endregion

    }
}
