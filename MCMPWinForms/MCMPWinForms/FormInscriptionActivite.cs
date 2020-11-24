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
    public partial class FormInscriptionActivite : Form
    {
        #region Get/Set pour le lien entre la formMain et sa fille
        public int IdAdherent { get; set; }
        public int IdActivite { get; set; }
        public int InscriptionFinie { get; set; }
        #endregion

        public FormInscriptionActivite()
        {
            InitializeComponent();
        }

        #region Inscription d'un adhérent à l'activité
        private void buttonInscrireAdherentActivite_Click(object sender, EventArgs e)
        {
            if (!IsPrix(textBoxNombreInvite.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_NBINVITE_NONVALIDE, 
                    Properties.Resources.STR_TITRE_NBINVITE_NONVALIDE, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else
            {
                int nb = inscriptionTableAdapter1.Insert(DateTime.Now, Convert.ToInt32(textBoxNombreInvite.Text), IdAdherent, IdActivite);
                if (nb == 0)
                {
                    MessageBox.Show(Properties.Resources.STR_MESSAGE_INSCRIPTION_FAIL,
                        Properties.Resources.STR_TITRE_INSCRIPTION_FAIL,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
                InscriptionFinie = 1;
                Close();
            }
        }
        #endregion

        #region Bouton fermeture de la fenêtre
        private void buttonFermerActivite_Click(object sender, EventArgs e)
        {
            DialogResult DiagResult = MessageBox.Show(Properties.Resources.STR_MESSAGE_ANNULER_ET_FERMER, Properties.Resources.STR_TITRE_ANNULER_ET_FERMER, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
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

        #region Fonction expression régulière
        public static bool IsPrix(string prix)
        {
            if (prix != null) return Regex.IsMatch(prix, Properties.Resources.STR_MOTIF_PRIX);
            else return false;
        }
        #endregion

    }
}
