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
        #region Les Get/Set pour faire le lien avec la FormMain et sa fille
        /// <summary>
        /// Ces get, set me permettrons de faire passer des informations du FormMain à cette fille ou inversement
        /// </summary>
        public BindingSource adherentbind { set; get; }
        public bool IsClose { get; set; }
        public long LastInsert { get; set; }
        public string Login { get; set; }
        #endregion

        #region Motif pour expression régulière
        /// <summary>
        /// Les motifs qui me permettrons de tester les champs saisis
        /// Un mail correctement formé, un téléphone, nom, prénom, code postale, adresse, ville et cylindrée
        /// </summary>
        public const string motifMail = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        public const string motifTel = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
        public const string motifName = @"^[\p{L}\p{M}' \.\-]+$";
        public const string motifCodePostale = @"^\d{5}$";
        public const string motifAdresse = @"^[A-Za-zéèàê0-9]+(?:\s[A-Za-zéèàê0-9'_-]+)+$";
        public const string motifVille = @"^([a-zA-Z\u0080-\u024F]+(?:.|-||'))*[a-zA-Z\u0080-\u024F]*$";
        public const string motifCylindree = @"^[0-9]{1,5}$";

        #endregion

        /// <summary>
        /// Initialisation des composants (contrôles etc...)
        /// </summary>
        public formDetailAdherent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Au chargement de la fenêtre (ShowDialog)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formDetailAdherent_Load(object sender, EventArgs e)
        {
            /// L'image Avatar sera par défaut chargée
            this.pictureBoxAvatar.ImageLocation = Properties.Resources.STR_ADRESSE_AVATAR + Properties.Resources.STR_AVATAR_PAR_DEFAUT;
        }

        #region Ajouter
        /// <summary>
        /// Au bouton "Ajouter" (Ajouter l'adhérent)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAjouter_Click(object sender, EventArgs e)
        {
            /// Active sera à 1 ou 0 suivant la case cochée ou non
            int active = checkBoxActive.Checked ? 1 : 0;
            /// La même chose pour organisateur
            int organisateur = checkBoxOrganisateur.Checked ? 1 : 0;
            /// Vérification des champs : Si ils sont à null ou comportent seulement des espaces
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
                /// Message indiquant qu'un champs n'est pas saisie
                MessageBox.Show(Properties.Resources.STR_MESSAGE_CHAMPS_NON_REMPLI, 
                    Properties.Resources.STR_TITRE_CHAMPS_NON_REMPLI, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                /// Je quitte l'évenement
                return;
            }
            /// Vérification de chaque champs avec les fonctions Regex (expressions régulière)
            /// Suivi d'un message d'erreur et d'une sortie d'évenement
            else if (!IsEmail(textBoxEmail.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_ADRESSE_MAIL_NON_VALIDE,
                    Properties.Resources.STR_TITRE_ADRESSE_MAIL_NON_VALIDE,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!IsPhoneNbr(textBoxTelephone.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_NUMERO_NON_VALIDE,
                    Properties.Resources.STR_TITRE_NUMERO_NON_VALIDE, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else if (!IsName(textBoxNom.Text) || !IsName(textBoxNom.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_NOM_NON_VALIDE,
                    Properties.Resources.STR_TITRE_NOM_NON_VALIDE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else if (!IsCodePostale(textBoxCodePostale.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_CODEPOSTALE_NON_VALIDE,
                    Properties.Resources.STR_TITRE_CODEPOSTALE_NON_VALIDE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else if (!IsAdresse(textBoxAdresse.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_EMAIL_NON_VALIDE,
                    Properties.Resources.STR_TITRE_EMAIL_NON_VALIDE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else if (!IsVille(textBoxVille.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_VILLE_NON_VALIDE,
                    Properties.Resources.STR_TITRE_VILLE_NON_VALIDE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else if (!IsCylindree(textBoxCylindree.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_CYLINDREE_NON_VALIDE,
                    Properties.Resources.STR_TITRE_CYLINDREE_NON_VALIDE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            int countNb = Convert.ToInt32(adherentsTableAdapter.Count(textBoxLogin.Text));
            if (countNb == 1)
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_LOGIN_EXISTANT,
                    Properties.Resources.STR_TITRE_LOGIN_EXISTANT,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            else if (textBoxAPropos.Text.Length > 250)
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_ERREUR_APROPOS,
                    Properties.Resources.STR_TITRE_ERREUR_APROPOS,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else if (textBoxLogin.Text.Length > 30)
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_LOGIN_TROP_LONG,
                    Properties.Resources.STR_TITRE_LOGIN_TROP_LONG,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            /// Fin de vérification de chaque champs avec les fonctions Regex (expressions régulière)
            ///Sinon, si toutes les vérifications ont réussis
            else
            {
                /// J'insert tous les champs dans la table adhérent en insérant le résultat de la requête dans une variable nb
                /// Si nb vaut 1, la requête a donné un résultat, sinon, la requête a échoué
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
                /// Si la requête à réussi
                if (nb == 1)
                {
                    /// Message de succès
                    MessageBox.Show(String.Format(Properties.Resources.STR_MESSAGE_ADHERENT_BIEN_AJOUTE, textBoxNom.Text, textBoxPrenom.Text),
                        Properties.Resources.STR_TITRE_ADHERENT_BIEN_AJOUTE,
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    /// Mise en variable du LastInsert pour un positionnage dans le formMain (on transfert la variable chez la fenêtre mère)
                    LastInsert = adherentTableAdapter1.Adapter.InsertCommand.InsertId;
                    /// IsClose est à 1, la FormMain va intéragir avec cela
                    IsClose = true;
                    /// Je close la fenêtre
                    Close();
                }
                /// La requête n'a pas réussi
                else
                {
                    /// Affichage d'un message d'erreur
                    MessageBox.Show(Properties.Resources.STR_MESSAGE_PROBLEME_AJOUT_ADHERENT,
                        Properties.Resources.STR_TITRE_PROBLEME_AJOUT_ADHERENT,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

        }
        #endregion

        #region Modifier
        /// <summary>
        /// Au bouton "Modifier" (Modifier l'adhérent)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModifier_Click(object sender, EventArgs e)
        {
            string Avatar = null;
            /// Je récupère la ligne courante de l'adhérent de la fenêtre MainForm par une variable transférée (adherentbind)
            cda27_bd2DataSet.adherentsRow currentRow = (cda27_bd2DataSet.adherentsRow)((DataRowView)adherentbind.Current).Row;
            /// Récupération de l'IdAdherent pour une récupération dans la fenêtre main pour un repositionnage sur l'adhérent
            LastInsert = currentRow.IdAdherent;
            /// J'initialise l'organisateur en short? (type short nullable
            short? Organisateur;
            /// Si le checkBox organisateur est coché alors Organisateur vaut 1
            if (checkBoxOrganisateur.Checked == true)
            {
                Organisateur = 1;
            }
            /// Sinon il vaut 0
            else
            {
                Organisateur = 0;
            }
            /// J'initialise Active en int
            int Active;
            /// Si Activé est coché alors Active vaut 1
            if (checkBoxActive.Checked == true)
            {
                Active = 1;
            }
            /// Sinon il vaut 0
            else
            {
                Active = 0;
            }
            /// Vérification de mes champs, si ils sont null ou comportent des espaces
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
                // Messsage d'erreur, un champs n'est pas saisie puis je quitte l'évenement
                MessageBox.Show(Properties.Resources.STR_MESSAGE_CHAMPS_NON_REMPLI,
                    Properties.Resources.STR_TITRE_CHAMPS_NON_REMPLI,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            /// Vérification de mes champs avec des Regex (expressions régulières)
            /// Message d'erreur si ils ne sont pas valides
            else if (!IsEmail(textBoxEmail.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_EMAIL_NON_VALIDE,
                    Properties.Resources.STR_TITRE_EMAIL_NON_VALIDE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else if (!IsPhoneNbr(textBoxTelephone.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_NUMERO_NON_VALIDE,
                    Properties.Resources.STR_TITRE_NUMERO_NON_VALIDE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else if (!IsName(textBoxNom.Text) || !IsName(textBoxNom.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_NOM_NON_VALIDE,
                    Properties.Resources.STR_TITRE_NOM_NON_VALIDE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else if (!IsCodePostale(textBoxCodePostale.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_CODEPOSTALE_NON_VALIDE,
                    Properties.Resources.STR_TITRE_CODEPOSTALE_NON_VALIDE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else if (!IsAdresse(textBoxAdresse.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_ADRESSE_NON_VALIDE,
                    Properties.Resources.STR_TITRE_ADRESSE_NON_VALIDE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else if (!IsVille(textBoxVille.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_VILLE_NON_VALIDE,
                    Properties.Resources.STR_TITRE_VILLE_NON_VALIDE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else if (!IsCylindree(textBoxCylindree.Text))
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_CYLINDREE_NON_VALIDE,
                    Properties.Resources.STR_TITRE_CYLINDREE_NON_VALIDE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else if (textBoxAPropos.Text.Length > 250)
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_ERREUR_APROPOS,
                    Properties.Resources.STR_TITRE_ERREUR_APROPOS,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information););
                return;
            }
            else if (textBoxLogin.Text.Length > 30)
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_LOGIN_TROP_LONG,
                    Properties.Resources.STR_TITRE_LOGIN_TROP_LONG,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            /// Fin de vérification de mes champs avec des Regex (expressions régulières)
            /// Mise en variable de la requête de Count du Login
            int countNb = Convert.ToInt32(adherentsTableAdapter.Count(textBoxLogin.Text));
            /// Si il existe déjà et qu'il n'est pas le login current
            if (countNb == 1 && textBoxLogin.Text != Login)
            {
                /// Message d'erreur, un adhérent a déjà ce login
                MessageBox.Show(Properties.Resources.STR_MESSAGE_LOGIN_EXISTANT,
                    Properties.Resources.STR_TITRE_LOGIN_EXISTANT,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            /// Si toutes les vérifications sont OK
            else
            {
                if (currentRow.IsAvatarNull())
                {
                    Avatar = null;
                }
                else
                {
                    Avatar = currentRow.Avatar;
                }
                /// Je fais la mise à jour en utilisant tous les champs 
                /// Comme anciennes valeurs j'utilise le currentRow du BindingSource précédemment transféré de la fenêtre MainForm
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
                    Avatar,
                    Active,
                    textBoxAPropos.Text,
                    currentRow.IdAdherent,
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
                /// Si la requête réussi
                if (nb == 1)
                {
                    /// Message de succès
                    MessageBox.Show(Properties.Resources.STR_MESSAGE_MODIFICATION_SUCCES,
                        Properties.Resources.STR_TITRE_MODIFICATION_SUCCES,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    /// La fenêtre va se fermer, la variable sera utilisée dans une condition dans le FormMain
                    IsClose = true;
                    /// Je ferme la fenêtre
                    Close();
                }
                /// Sinon, il y a un problème dans l'ajout
                else
                {
                    /// Message d'erreur : Problème dans la modification de l'adhérent
                    MessageBox.Show(Properties.Resources.STR_MESSAGE_PROBLEME_MODIF_ADHERENT,
                        Properties.Resources.STR_TITRE_PROBLEME_MODIF_ADHERENT,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region Supprimer
        /// <summary>
        /// Au bouton "Supprimer" (Supprimer l'adhérent)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSupprimer_Click(object sender, EventArgs e)
        {
            /// Je récupère la ligne adhérent du FormMain avec la variable BindingSource précédemment transférée (adherentbind)
            cda27_bd2DataSet.adherentsRow currentRow = (cda27_bd2DataSet.adherentsRow)((DataRowView)adherentbind.Current).Row;
            /// Je supprime l'adhérent avec les valeurs de la ligne séléctionnée
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
            /// Si la requête n'a pas réussi
            if (nb == 0)
            {
                /// Message d'erreur
                MessageBox.Show(Properties.Resources.STR_MESSAGE_SUPPRESSION_FAIL,
                    Properties.Resources.STR_TITRE_SUPPRESSION_FAIL,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            /// Si la requête a réussi
            else
            {
                /// Variable IsClose est à 1, elle me servira dans le FormMain
                IsClose = true;
                /// Je close la fenêtre
                Close();
            }
        }
        #endregion

        #region Annuler
        /// <summary>
        /// Action du bouton Annuler (Annuler l'ajout, la modification de l'adhérent)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnulerDetailAdherent_Click(object sender, EventArgs e)
        {
            /// Message de confirmation d'annulation
            DialogResult DiagResult = MessageBox.Show(Properties.Resources.STR_MESSAGE_ANNULER_ET_FERMER,
                Properties.Resources.STR_TITRE_ANNULER_ET_FERMER,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);
            /// Bouton Non séléctionné
            if (DiagResult == DialogResult.No)
            {
                /// Je quitte l'évenement sans fermer la fenêtre
                return;
            }
            /// Sinon je ferme la fenêtre
            Close();
        }
        #endregion

        #region Fonctions d'expression régulières
        /// <summary>
        /// Regex (expressions régulières correspondant à toutes les vérifications possibles pour un type de champs)
        /// </summary>
        /// <returns>True ou False</returns>
        public static bool IsEmail(string email)
        {
            if (email != null && email.Length < 250) return Regex.IsMatch(email, motifMail);
            else return false;
        }
        public static bool IsPhoneNbr(string number)
        {
            if (number != null) return Regex.IsMatch(number, motifTel);
            else return false;
        }
        public static bool IsName(string name)
        {
            if (name != null && name.Length < 250) return Regex.IsMatch(name, motifName);
            else return false;
        }
        public static bool IsAdresse(string adresse)
        {
            if (adresse != null && adresse.Length < 250) return Regex.IsMatch(adresse, motifAdresse);
            else return false;
        }
        public static bool IsVille(string ville)
        {
            if (ville != null && ville.Length < 250) return Regex.IsMatch(ville, motifVille);
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
        /// Fin des expressions régulières
        #endregion


    }
}
