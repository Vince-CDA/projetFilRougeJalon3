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
    public partial class formDetailAdherent : Form
    {
        public BindingSource adherentbind { set; get; }
        public int IsClose { get; set; }
        public long LastInsert { get; set; }
        // Expression régulière utilisée pour valider l'adresse e-mail.
        public const string motifMail =
        @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        // Expression régulière utilisée pour valider un numéro de téléphone.
        public const string motifTel = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
        public const string motifName = @"^[\p{L}\p{M}' \.\-]+$";
        public const string motifCodePostale = @"^\d{5}$";
        public const string motifAdresse = @"^[A-Za-zéèàê0-9]+(?:\s[A-Za-zéèàê0-9'_-]+)+$";
        public const string motifVille = @"^\p{Lu}\p{L}*(?:[\s-]\p{Lu}\p{L}*)*$";
        public const string motifCylindree = @"^[0-9]{1,5}$";
        public formDetailAdherent()
        {
            InitializeComponent();
        }
        const string ADRESSE_IMAGE = "http://cda27.s1.2isa.org/upload/images/winform/";

        private void formDetailAdherent_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'cda27_bd2DataSet.adherents'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.adherentsTableAdapter.Fill(this.cda27_bd2DataSet.adherents);
            string FileAvatar = "1598527711.png";
            this.pictureBoxAvatar.ImageLocation = ADRESSE_IMAGE + FileAvatar;
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            int active = checkBoxActive.Checked ? 1 : 0;
            int organisateur = checkBoxOrganisateur.Checked ? 1 : 0;
            if (String.IsNullOrWhiteSpace(textBoxNom.Text) ||
                String.IsNullOrWhiteSpace(textBoxPrenom.Text) ||
                String.IsNullOrWhiteSpace(textBoxAdresse.Text) ||
                String.IsNullOrWhiteSpace(textBoxCodePostale.Text) ||
                String.IsNullOrWhiteSpace(textBoxVille.Text) ||
                String.IsNullOrWhiteSpace(textBoxTelephone.Text) ||
                String.IsNullOrWhiteSpace(textBoxLogin.Text) ||
                String.IsNullOrWhiteSpace(textBoxCylindree.Text) ||
                String.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                String.IsNullOrWhiteSpace(textBoxAPropos.Text))
            {
                MessageBox.Show("Un champs n'est pas saisie");
                return;
            }
            else if (!IsEmail(textBoxEmail.Text))
            {
                MessageBox.Show("L'adresse mail saisie n'est pas valide");
                return;
            }
            else if (!IsPhoneNbr(textBoxTelephone.Text))
            {
                MessageBox.Show("Le numéro de téléphone saisie n'est pas valide (0XXXXXXXXX souhaité)");
                return;
            }
            else if (!IsName(textBoxNom.Text) || !IsName(textBoxNom.Text))
            {
                MessageBox.Show("Le nom ou le prénom n'est pas valide");
                return;
            }
            else if (!IsCodePostale(textBoxCodePostale.Text))
            {
                MessageBox.Show("Le code postale saisie n'est pas valide");
                return;
            }
            else if (!IsAdresse(textBoxAdresse.Text))
            {
                MessageBox.Show("L'adresse saisie est invalide");
                return;
            }
            else if (!IsVille(textBoxVille.Text))
            {
                MessageBox.Show("La ville saisie est invalide");
                return;
            }
            else if (!IsCylindree(textBoxCylindree.Text))
            {
                MessageBox.Show("La cylindrée saisie n'est pas correcte (Seulement de 0 à 9999.)");
                return;
            }

            int nb = adherentTableAdapter1.Insert(
                                                    textBoxNom.Text,
                                                    textBoxPrenom.Text,
                                                    dateTimePickerDateDeNaissance.Value,
                                                    textBoxAdresse.Text,
                                                    null,
                                                    textBoxCodePostale.Text,
                                                    textBoxVille.Text,
                                                    textBoxEmail.Text,
                                                    textBoxTelephone.Text,
                                                    dateTimePickerDateAdhesion.Value,
                                                    (short?)organisateur,
                                                    0,
                                                    textBoxLogin.Text,
                                                    "123456",
                                                    textBoxCylindree.Text,
                                                    null,
                                                    active,
                                                    textBoxAPropos.Text);
            if (nb == 1)
            {
                MessageBox.Show("L'adhérent"+textBoxNom.Text+" "+textBoxPrenom.Text+" a bien été ajouté");
                LastInsert = adherentTableAdapter1.Adapter.InsertCommand.InsertId;
                IsClose = 1;
                Close();
            }
            else
            {
                MessageBox.Show("Il y a un problème pour l'ajout de l'adhérent...");
            }

        }

        public static bool IsEmail(string email)
        {
            if (email != null) return Regex.IsMatch(email, motifMail);
            else return false;
        }
        public static bool IsPhoneNbr(string number)
        {
            if (number != null) return Regex.IsMatch(number, motifTel);
            else return false;
        }
        public static bool IsName(string name)
        {
            if (name != null) return Regex.IsMatch(name, motifName);
            else return false;
        }
        public static bool IsAdresse(string adresse)
        {
            if (adresse != null) return Regex.IsMatch(adresse, motifAdresse);
            else return false;
        }
        public static bool IsVille(string ville)
        {
            if (ville != null) return Regex.IsMatch(ville, motifVille);
            else return false;
        }
        public static bool IsCylindree(string cc)
        {
            if (cc != null) return Regex.IsMatch(cc, motifCylindree);
            else return false;
        }
        public static bool IsCodePostale(string codePostale)
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(motifCodePostale, options);
            if (codePostale != null) return regex.IsMatch(codePostale);
            else return false;
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            cda27_bd2DataSet.adherentsRow currentRow = (cda27_bd2DataSet.adherentsRow)((DataRowView)adherentbind.Current).Row;

            short? Organisateur;
            if (checkBoxOrganisateur.Checked == true)
            {
                Organisateur = 1;
            }
            else
            {
                Organisateur = 0;
            }
            int Active;
            if (checkBoxActive.Checked == true)
            {
                Active = 1;
            }
            else
            {
                Active = 0;
            }

            int nb = adherentTableAdapter.Update(textBoxNom.Text,
                    textBoxPrenom.Text,
                    dateTimePickerDateDeNaissance.Value,
                    textBoxAdresse.Text,
                    null,
                    textBoxCodePostale.Text,
                    textBoxVille.Text,
                    textBoxEmail.Text,
                    textBoxTelephone.Text,
                    currentRow._Date_d_adhésion,
                    Organisateur,
                    0,
                    textBoxLogin.Text,
                    currentRow.Password,
                    textBoxCylindree.Text,
                    currentRow.Avatar,
                    Active,
                    textBoxAPropos.Text,
                    currentRow.IdAdherent,
                    currentRow.Nom,
                    currentRow.Prénom,
                    currentRow.Date_de_naissance,
                    currentRow.Adresse,
                    currentRow.Adresse2,
                    currentRow.Code_postale,
                    currentRow.Ville,
                    currentRow.Email,
                    currentRow.Téléphone,
                    currentRow._Date_d_adhésion,
                    currentRow.Organisateur,
                    currentRow.Admin,
                    currentRow.Login,
                    currentRow.Password,
                    currentRow.Cylindrée,
                    currentRow.Activé);
            if (nb == 1)
            {
                MessageBox.Show("La modification a été réalisée");
                LastInsert = adherentTableAdapter.Adapter.UpdateCommand.InsertId;
                IsClose = 1;
                Close();
            }
            else
            {
                MessageBox.Show("Problème dans la modification de l'adhérent");
            }
        }

        private void buttonAnnulerDetailAdherent_Click(object sender, EventArgs e)
        {
            DialogResult DiagResult = MessageBox.Show("Voulez-vous vraiment annuler et fermer cette fenêtre ?", "Annuler", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (DiagResult == DialogResult.No)
            {
                return;
            }
            Close();
        }

        private void formDetailAdherent_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            cda27_bd2DataSet.adherentsRow currentRow = (cda27_bd2DataSet.adherentsRow)((DataRowView)adherentbind.Current).Row;
            int nb = adherentTableAdapter.Delete(currentRow.IdAdherent, 
                                        currentRow.Nom, 
                                        currentRow.Prénom, 
                                        currentRow.Date_de_naissance, 
                                        currentRow.Adresse,
                                        null, 
                                        currentRow.Code_postale, 
                                        currentRow.Ville, 
                                        currentRow.Email, 
                                        currentRow.Téléphone, 
                                        currentRow._Date_d_adhésion,
                                        currentRow.Organisateur, 
                                        currentRow.Admin, 
                                        currentRow.Login, 
                                        currentRow.Password, 
                                        currentRow.Cylindrée, 
                                        currentRow.Activé);
            if (nb == 0)
            {
                MessageBox.Show("La suppression n'a pas été effectuée");
            }
            else
            {
                IsClose = 1;
                Close();
            }

        }
        
    }
}
