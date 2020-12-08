using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MCMPWinForms
{
    public partial class FormInscriptionActivite : Form
    {
        #region Get/Set pour le lien entre la formMain et sa fille
        /// <summary>
        /// Les Get/Set servant de lien avec le FormMain
        /// </summary>
        public int IdAdherent { get; set; }
        public int IdActivite { get; set; }
        public int InscriptionFinie { get; set; }
        public bool ModificationEnCours { get; set; }
        public BindingSource inscriptionAct { set; get; }

        #endregion

        /// <summary>
        /// Action à l'instanciation de la fenêtre
        /// </summary>
        public FormInscriptionActivite()
        {
            /// J'initialise les composants (contrôles etc...)
            InitializeComponent();
        }

        #region Inscription d'un adhérent à l'activité
        /// <summary>
        /// Action du bouton Inscrire (Inscrire l'adhérent à une activité)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInscrireAdherentActivite_Click(object sender, EventArgs e)
        {
            if (ModificationEnCours == true)
            {
                /// Verification du nombre d'invité
                if (!IsNbInvite(textBoxNombreInvite.Text))
                {
                    /// Si l'expression régulière échoue, message : Nombre d'invité non valide
                    MessageBox.Show(Properties.Resources.STR_MESSAGE_NBINVITE_NONVALIDE,
                        Properties.Resources.STR_TITRE_NBINVITE_NONVALIDE,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    /// Sinon, j'exécute la requête d'insertion avec la date du jour,
                    /// L'IdAdherent précédemment extrait du FormMain et du BindingSource
                    /// Et l'IdActivite
                    /// 
                    cda27_bd2DataSet.adherentinscriptionRow currentRow2 = (cda27_bd2DataSet.adherentinscriptionRow)((DataRowView)inscriptionAct.Current).Row;

                    int nb = inscriptionTableAdapter1.Update(DateTime.Now,
                        Convert.ToInt32(textBoxNombreInvite.Text),
                        IdAdherent,
                        IdActivite,
                        currentRow2.IdInscription,
                        currentRow2.DInscription,
                        currentRow2.NbInvités,
                        currentRow2.IdAdherent,
                        currentRow2.IdActivite);
                    /// Si la requête échoue
                    if (nb == 0)
                    {
                        /// J'affiche un message d'echec
                        MessageBox.Show(Properties.Resources.STR_MESSAGE_INSCRIPTION_FAIL,
                            Properties.Resources.STR_TITRE_INSCRIPTION_FAIL,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        /// Je quitte l'évenement
                        return;
                    }
                    /// L'inscription est finie, j'utiliserai la variable InscriptionFinie dans le FormMain
                    InscriptionFinie = 1;
                    /// Je ferme la fenêtre
                    Close();
                }
            }
            else
            {


                /// Verification du nombre d'invité
                if (!IsNbInvite(textBoxNombreInvite.Text))
                {
                    /// Si l'expression régulière échoue, message : Nombre d'invité non valide
                    MessageBox.Show(Properties.Resources.STR_MESSAGE_NBINVITE_NONVALIDE,
                        Properties.Resources.STR_TITRE_NBINVITE_NONVALIDE,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    /// Sinon, j'exécute la requête d'insertion avec la date du jour,
                    /// L'IdAdherent précédemment extrait du FormMain et du BindingSource
                    /// Et l'IdActivite
                    int nb = inscriptionTableAdapter1.Insert(DateTime.Now,
                        Convert.ToInt32(textBoxNombreInvite.Text),
                        IdAdherent,
                        IdActivite);
                    /// Si la requête échoue
                    if (nb == 0)
                    {
                        /// J'affiche un message d'echec
                        MessageBox.Show(Properties.Resources.STR_MESSAGE_INSCRIPTION_FAIL,
                            Properties.Resources.STR_TITRE_INSCRIPTION_FAIL,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        /// Je quitte l'évenement
                        return;
                    }
                    /// L'inscription est finie, j'utiliserai la variable InscriptionFinie dans le FormMain
                    InscriptionFinie = 1;
                    /// Je ferme la fenêtre
                    Close();
                }
            }
        }
        #endregion



        #region Bouton fermeture de la fenêtre
        /// <summary>
        /// Action du bouton Fermer (Fermer la fenêtre)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFermerActivite_Click(object sender, EventArgs e)
        {
            /// Message de confirmation de fermeture
            DialogResult DiagResult = MessageBox.Show(Properties.Resources.STR_MESSAGE_ANNULER_ET_FERMER,
                Properties.Resources.STR_TITRE_ANNULER_ET_FERMER,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);
            /// Si l'utilisateur séléctionne Oui
            if (DiagResult == DialogResult.Yes)
            {
                /// Je ferme la fenêtre
                Close();
            }
            else
            {
                /// Sinon je quitte l'évenement
                return;
            }
        }
        #endregion

        /// <summary>
        /// Motif pour expression régulière
        /// </summary>
        public const string motifPrix = @"[0-9]{1,}[.,]{0,1}[0-9]{0,2}";

        #region Fonction expression régulière
        /// <summary>
        /// Fonction Regex (expression régulière) verifiant le nombre d'invités
        /// </summary>
        /// <param name="nbinvite"></param>
        /// <returns></returns>
        public static bool IsNbInvite(string nbinvite)
        {
            if (nbinvite != null && nbinvite.Length < 5) return Regex.IsMatch(nbinvite, motifPrix);
            else return false;
        }
        #endregion

    }
}
