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
        public int IdAdherent { get; set; }
        public int IdActivite { get; set; }
        public int InscriptionFinie { get; set; }
        public const string motifPrix = @"[0-9]";
        public FormInscriptionActivite()
        {
            InitializeComponent();
        }

        private void buttonInscrireAdherentActivite_Click(object sender, EventArgs e)
        {
            if (!IsPrix(textBoxNombreInvite.Text))
            {
                MessageBox.Show("Le nombre d'invité(s) n'est pas valide");
            }
            else
            {
                int nb = inscriptionTableAdapter1.Insert(DateTime.Now, Convert.ToInt32(textBoxNombreInvite.Text), IdAdherent, IdActivite);
                if (nb == 0)
                {
                    MessageBox.Show("L'inscription ne s'est pas réalisée");
                    return;
                }
                InscriptionFinie = 1;
                Close();
            }
        }

        public static bool IsPrix(string prix)
        {
            if (prix != null) return Regex.IsMatch(prix, motifPrix);
            else return false;
        }

        private void buttonFermerActivite_Click(object sender, EventArgs e)
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
    }
}
