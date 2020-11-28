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
        /// <summary>
        /// Les Get/Set pouvant faire le lien entre la fenêtre FormMain et celle-ci
        /// </summary>
        public BindingSource activitebind { get; set; }
        public BindingSource adherentbind { set; get; }
        public long LastInsert { get; set; }
        public int IdType { get; set; }
        public bool IsClose { get; set; }
        public bool ModifEnCours { get; set; }
        public int IdActivite { get; set; }
        /// Je récupère le BindingSource de l'activité de la FormMain 
        public cda27_bd2DataSet.activitesRow currentRowAdh { get; set; }
        public cda27_bd2DataSet.type_activiteRow currentRow { get; set; }
        #endregion

        #region Démarrage de la fenêtre
        /// <summary>
        /// A l'instanciation de la formDetailActivite
        /// </summary>
        public formDetailActivite()
        {
            /// J'initialise les composants (contrôles etc...)
            InitializeComponent();
        }

        /// <summary>
        /// Au chargement de la fenêtre (ShowDialog)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formDetailActivite_Load(object sender, EventArgs e)
        {
            /// Je Fill les inscriptions par rapport à l'IdActivite envoyée de la fenêtre MainForm
            inscriptionsTableAdapter.FillBy(this.cda27_bd2DataSet.inscriptions, IdActivite);
            /// Je Fill les types d'activités
            this.type_activiteTableAdapter.Fill(this.cda27_bd2DataSet2.type_activite);
            /// Si une modification est en cours, je me positionne sur le type d'activité de l'activité à modifier par son IdType
            if (ModifEnCours)
            {
            typeactiviteBindingSource.Position = typeactiviteBindingSource.Find("IdType", IdType);
            }
        }
        #endregion

        #region Ajouter
        /// <summary>
        /// Action de bouton Ajouter (Ajouter l'activité)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouterActivite_Click(object sender, EventArgs e)
        {
            /// Je récupère la ligne du type d'activité qui me servira plus tard
            cda27_bd2DataSet.type_activiteRow currentRow = (cda27_bd2DataSet.type_activiteRow)((DataRowView)typeactiviteBindingSource.Current).Row;
            /// Publier vaut 1 ou 0 si il est coché ou non
            int publier = checkBoxPublic.Checked ? 1 : 0;
            /// Je vérifie les champs, si ils sont null ou comportent seulement des espaces
            if (String.IsNullOrWhiteSpace(textBoxIntituleAct.Text) 
                || String.IsNullOrWhiteSpace(textBoxDescription.Text)
                || String.IsNullOrWhiteSpace(textBoxTarifAdherent.Text)
                || String.IsNullOrWhiteSpace(textBoxTarifInvite.Text))
            {
                /// Message d'erreur de champs non remplis
                MessageBox.Show(Properties.Resources.STR_MESSAGE_CHAMPS_NON_REMPLI, 
                    Properties.Resources.STR_TITRE_CHAMPS_NON_REMPLI,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                /// Je quitte l'évenement
                return;
            }
            /// Si la date de début est inférieur à la date d'aujourd'hui
            /// Et si la date de début est supérieur à la date de fin
            /// Et si la date limite est supérieur à la date de début
            /// Et si la date limite est supérieur à la date de fin
            /// Alors dans cet ordre : Date du jour > Date limite > Date début > date de fin
            if (dateTimePickerDateLimite.Value < DateTime.Now 
                && dateTimePickerDateDebut.Value > dateTimePickerDateFin.Value
                && dateTimePickerDateLimite.Value > dateTimePickerDateDebut.Value
                && dateTimePickerDateLimite.Value > dateTimePickerDateFin.Value)
            {
                /// Message d'erreur, les dates comportent un problème chronologique
                MessageBox.Show(Properties.Resources.STR_MESSAGE_DATE_ACT_PROBLEME,
                    Properties.Resources.STR_TITRE_DATE_ACT_PROBLEME,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                /// Je quitte l'évenement
                return;
            }
            /// Si le prix adhérent / invité n'est pas correct
            else if (!IsPrix(textBoxTarifAdherent.Text) || !IsPrix(textBoxTarifInvite.Text))
            {
                /// Message d'erreur
                MessageBox.Show(Properties.Resources.STR_MESSAGE_TARIF_PROBLEME,
                    Properties.Resources.STR_TITRE_TARIF_PROBLEME,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                /// Je quitte l'évenement
                return;
            }
            else if (textBoxDescription.Text.Length > 15000)
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_DESCRIPTION_PROBLEME,
                    Properties.Resources.STR_TITRE_DESCRIPTION_PROBLEME,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            /// Si je n'ai pas quitté l'évenement avant, j'insert une activité avec les valeurs correspondantes
            /// L'IdAdherent sera celui de la secrétaire
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
            /// Si la requête réussie
            if (nb == 1)
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_ACTIVITE_AJOUT_SUCCESS,
                    Properties.Resources.STR_TITRE_ACTIVITE_AJOUT_SUCCESS,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                /// Le LastInsert sera utilisé dans le FormMain pour le repositionnement sur l'activité qui vient de s'ajouter
                LastInsert = activiteTableAdapter.Adapter.InsertCommand.InsertId;
                /// IsClose servira dans le MainForm indiquant que la fenêtre va se fermer
                IsClose = true;
                /// Je ferme la fenêtre
                Close();
            }
            /// Sinon, l'ajout ne s'est pas réalisé
            else
            {
                /// Message d'echec
                MessageBox.Show(Properties.Resources.STR_MESSAGE_PROBLEME_AJOUT_ACT,
                    Properties.Resources.STR_TITRE_PROBLEME_AJOUT_ACT,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Modifier
        /// <summary>
        /// Action de bouton Modifier (Modifier l'activite)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifierActivite_Click(object sender, EventArgs e)
        {
            /// Je récupère le BindingSource des types d'activité
            cda27_bd2DataSet.type_activiteRow currentRow = (cda27_bd2DataSet.type_activiteRow)((DataRowView)typeactiviteBindingSource.Current).Row;
            /// Si publier est coché alors il vaut 1 sinon il vaut 0
            int publier = checkBoxPublic.Checked ? 1 : 0;
            /// Je vérifie que tous les champs ne sont pas null ou comportent des espaces
            if (String.IsNullOrWhiteSpace(textBoxIntituleAct.Text)
                || String.IsNullOrWhiteSpace(textBoxDescription.Text)
                || String.IsNullOrWhiteSpace(textBoxTarifAdherent.Text)
                || String.IsNullOrWhiteSpace(textBoxTarifInvite.Text))
            {
                /// Si ce n'est pas le cas j'affiche un message d'erreur
                /// Les champs ne sont pas remplis
                MessageBox.Show(Properties.Resources.STR_MESSAGE_CHAMPS_NON_REMPLI, 
                    Properties.Resources.STR_TITRE_CHAMPS_NON_REMPLI, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                /// Je quitte l'évenement
                return;
            }
            /// Si la date de début est inférieur à la date d'aujourd'hui
            /// Et si la date de début est supérieur à la date de fin
            /// Et si la date limite est supérieur à la date de début
            /// Et si la date limite est supérieur à la date de fin
            /// Alors dans cet ordre : Date du jour > Date limite > Date début > date de fin
            if (dateTimePickerDateLimite.Value < DateTime.Now
                && dateTimePickerDateDebut.Value > dateTimePickerDateFin.Value
                && dateTimePickerDateLimite.Value > dateTimePickerDateDebut.Value
                && dateTimePickerDateLimite.Value > dateTimePickerDateFin.Value)
            {
                /// Affichage d'un message "problème de chronologie des dates"
                MessageBox.Show(Properties.Resources.STR_MESSAGE_DATE_ACT_PROBLEME, 
                    Properties.Resources.STR_TITRE_DATE_ACT_PROBLEME, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                /// Je quitte l'évenement
                return;
            }
            /// Vérification des prix Adhérents / Invités par une Regex (expression régulière)
            else if (!IsPrix(textBoxTarifAdherent.Text) || !IsPrix(textBoxTarifInvite.Text))
            {
                /// Si le test échoue, j'affiche un message d'erreur de tarif
                MessageBox.Show(Properties.Resources.STR_MESSAGE_TARIF_PROBLEME, 
                    Properties.Resources.STR_TITRE_TARIF_PROBLEME,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                /// Je quitte l'événement
                return;
            }
            else if (textBoxDescription.Text.Length > 15000)
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_DESCRIPTION_PROBLEME,
                    Properties.Resources.STR_TITRE_DESCRIPTION_PROBLEME,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            /// J'exécute la requête d'update avec les valeurs nouvelles, 
            /// l'IdAdherent sera la secrétaire, 
            /// les valeurs anciennes seront celle du CurrentRow de la FormMain
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

            /// Si la requête échoue
            if (nb == 0)
            {
                /// J'affiche un message : Mise à jour non réalisée
                MessageBox.Show(Properties.Resources.STR_MESSAGE_MAJ_NON_REALISEE, 
                    Properties.Resources.STR_TITRE_MAJ_NON_REALISEE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                /// Je quitte l'évenement
                return;
            }
            else
            {
                /// J'affiche un message : Mise à jour non réalisée
                MessageBox.Show(Properties.Resources.STR_MESSAGE_MAJ_OK,
                    Properties.Resources.STR_TITRE_MAJ_OK,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            /// Je mets en variable l'IdActivité pour me repositionner dans le fenêtre main sur l'activité précédemment séléctionnée
            LastInsert = currentRowAdh.IdActivite;
            /// IsClose me servira pour savoir que la fenêtre va se fermer dans le FormMain
            IsClose = true;
            /// Je ferme la fenêtre
            Close();
            }
        }
        #endregion

        #region Supprimer
        /// <summary>
        /// Action de bouton Supprimer (Supprimer l'activité)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupprimerActivite_Click(object sender, EventArgs e)
        {
            /// Je récupère la ligne courante du FormMain de l'activité
            cda27_bd2DataSet.activitesRow currentRowAdh = (cda27_bd2DataSet.activitesRow)((DataRowView)activitebind.Current).Row;
            /// J'affiche un message de confirmation de suppression
            DialogResult DiagResult = MessageBox.Show(Properties.Resources.STR_MESSAGE_SUPPRESSION_ACTIVITE, Properties.Resources.STR_TITRE_SUPPRESSION_ACTIVITE, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            /// Si l'utilisateur appuie sur le bouton Oui
            if (DiagResult == DialogResult.Yes)
            {
                /// J'exécute la requête de suppression avec les valeurs de la ligne séléctionnée dans le FormMain
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
                /// Si la requête échoue
                if (nb == 0)
                {
                    /// J'affiche un message d'erreur de suppression
                    MessageBox.Show(Properties.Resources.STR_MESSAGE_SUPPRESSION_FAIL, 
                        Properties.Resources.STR_TITRE_SUPPRESSION_FAIL,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            /// Sinon
            else
            {
                /// Je quitte l'évenement
                return;
            } 
        }
        #endregion

        #region Bouton annuler
        /// <summary>
        /// Action du bouton Annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnulerActivite_Click(object sender, EventArgs e)
        {
            /// J'affiche un message de confirmation d'annulation et de fermeture de la fenêtre
            DialogResult DiagResult = MessageBox.Show("Voulez-vous vraiment annuler et fermer cette fenêtre ?", "Annuler", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            /// Si le bouton Oui est séléctionné
            if (DiagResult == DialogResult.Yes)
            {
                /// Je ferme la fenêtre
               Close();
            }
            /// Sinon
            else
            {
                /// Je quitte l'évenement
                return;
            }
        }
        #endregion

        /// <summary>
        /// Motif pour expression régulière
        /// </summary>
        public const string motifPrix = @"[0-9]{1,}[.,]{0,1}[0-9]{0,2}";

        #region Expression régulière
        /// <summary>
        /// Regex correspondant à la vérification du tarif adhérent/invité
        /// </summary>
        /// <param name="prix">Le tarif</param>
        /// <returns>true ou false</returns>
        public static bool IsPrix(string prix)
        {
            if (prix != null && prix.Length < 5) return Regex.IsMatch(prix, motifPrix);
            else return false;
        }
        #endregion

    }
}
