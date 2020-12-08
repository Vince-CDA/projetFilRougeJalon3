using System;
using System.Data;
using System.Windows.Forms;

namespace MCMPWinForms
{
    public partial class FormMain : Form
    {
        bool VaSeFermer = false;
        #region Au démarrage
        /// <summary>
        /// A l'ouverture de la FormMain
        /// </summary>
        public FormMain()
        {
            /// Initialisation des composants (des contrôles etc...)
            InitializeComponent();
            /// FillIntegral (voir plus bas)
            FillIntegral();
            /// Si la liste des inscription est vide désactivation du bouton "Désinscrire l'adhérent"
            if (inscriptionsBindingSource.Count == 0)
            {
                buttonDesinscrireAdherent.Enabled = false;
                buttonModifierInscriptionActivite.Enabled = false;
            }
            /// Sinon activation du bouton
            else
            {
                buttonDesinscrireAdherent.Enabled = true;
                buttonModifierInscriptionActivite.Enabled = true;
            }
        }

        /// <summary>
        /// Au chargement de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Boutons rafraîchir
        /// <summary>
        /// Au clique du bouton rafraîchir, FillIntegral exécuté
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRafraichirActivite_Click(object sender, EventArgs e)
        {
            FillIntegral();
        }

        /// <summary>
        /// Au clique du bouton rafraîchir, FillIntegral exécuté
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRafraichirAdherent_Click(object sender, EventArgs e)
        {
            FillIntegral();
        }
        #endregion

        #region Adhérents
        #region Ajout adhérent
        /// <summary>
        /// Action après le clique "Ajouter" dans l'onglet Adhérent (Ajouter un adhérent)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouterAdherent_Click(object sender, EventArgs e)
        {
            /// Using de la formDetailAdherent (nouvelle fenêtre) pour faire un "dispose" à la fermeture
            using (formDetailAdherent frmDetailAdherent = new formDetailAdherent())
            {
                /// Les choses inutiles dans l'ajout d'un adhérents deviennent invisibles
                frmDetailAdherent.dataGridViewFormDetailAdherentInscrits.Visible = false;
                frmDetailAdherent.lblInscritsAuxActivites.Visible = false;
                frmDetailAdherent.btModifier.Visible = false;
                frmDetailAdherent.btSupprimer.Visible = false;
                frmDetailAdherent.btDesinscrireAdherent.Visible = false;
                /// Je rends la date d'adhésion non modifiable (L'adhérent aura la date du jour comme date d'adhésion)
                frmDetailAdherent.dateTimePickerDateAdhesion.Enabled = false;
                /// J'affiche la fenêtre en mode Dialog (le using n'aurait pas été possible sans ça)
                frmDetailAdherent.ShowDialog();
                /// Si la fenêtre se ferme
                if (frmDetailAdherent.IsClose)
                {
                    /// Je FillIntegral
                    FillIntegral();
                    /// Je me repositionne sur la ligne que je viens d'ajouter via l'IdAdherent
                    adherentsBindingSource.Position = adherentsBindingSource.Find("IdAdherent", frmDetailAdherent.LastInsert);
                    /// Je rétablie IsClose à 0
                    frmDetailAdherent.IsClose = false;
                }
            }
        }
        #endregion

        #region Modification adhérent
        /// <summary>
        /// Action du bouton Modifier dans l'onglet Adhérent (Modifier un adhérent)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModifier_Click(object sender, EventArgs e)
        {
            /// Using de la formDetailAdherent (nouvelle fenêtre) pour faire un "dispose" à la fermeture
            using (formDetailAdherent formDetailAdherent = new formDetailAdherent())
            {
                /// Récupération de la ligne courrante pour une utilisation des valeurs de ses colonnes
                cda27_bd2DataSet.adherentsRow currentRow = (cda27_bd2DataSet.adherentsRow)((DataRowView)adherentsBindingSource.Current).Row;
                if (currentRow.IdAdherent == 100)
                {
                    MessageBox.Show(Properties.Resources.STR_MESSAGE_IMPOSSIBLE_MODIFIER_SECRETAIRE,
                        Properties.Resources.STR_TITRE_IMPOSSIBLE_SUPPRIMER_SECRETAIRE,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
                /// Mise des valeurs dans les TextBox et dateTimePicker correspondant à l'adhérent
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
                formDetailAdherent.Login = currentRow.Login;
                formDetailAdherent.textBoxAge.Text = Convert.ToString(CalculAge(currentRow.Date_de_naissance)) + "ans";
                /// Si la colonne organisateur est à 1 alors la checkBox prévue à cet effet est cochée
                if (currentRow.Organisateur == 1)
                {
                    formDetailAdherent.checkBoxOrganisateur.Checked = true;
                }
                /// Sinon décochée
                else
                {
                    formDetailAdherent.checkBoxOrganisateur.Checked = false;
                }
                /// De même si la colonne activé est à 1 ...
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
                /// Fill du dataGridView des inscriptions de l'adhérent avec comme argument son IdAdherent
                formDetailAdherent.inscriptionsTableAdapter.Fill(formDetailAdherent.cda27_bd2DataSet.inscriptions, currentRow.IdAdherent);
                /// Si un avatar n'est pas défini il prendra une valeur par défaut
                string FileAvatar = currentRow.IsAvatarNull() ? Properties.Resources.STR_AVATAR_PAR_DEFAUT : currentRow.Avatar;
                /// La pictureBox ira alors chercher l'avatar sur internet (cda27.s1.2isa.org)
                formDetailAdherent.pictureBoxAvatar.ImageLocation = Properties.Resources.STR_ADRESSE_AVATAR + FileAvatar;
                /// Injection du bindingSource directement dans le code de la fenêtre fille
                formDetailAdherent.adherentbind = adherentsBindingSource;
                /// Ajouter devient invisible (pas besoin d'ajouter si l'on modifie)
                formDetailAdherent.btAjouter.Visible = false;
                /// On affiche la fenêtre en mode Dialog (Le using aurait été impossible sinon)
                formDetailAdherent.ShowDialog();
                /// Si la fenêtre se ferme
                if (formDetailAdherent.IsClose)
                {
                    /// Je FillIntegral et me positionne sur l'adhérent que je viens de modifier
                    FillIntegral();
                    adherentsBindingSource.Position = adherentsBindingSource.Find("IdAdherent", formDetailAdherent.LastInsert);
                    /// Je rétablie la valeur 0 à IsClose
                    formDetailAdherent.IsClose = false;
                }
            }
        }
        #endregion

        #region Suppression adhérent
        /// <summary>
        /// Action du bouton Supprimer dans l'onglet Adhérent (Supprimer un adhérent)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupprimerAdherent_Click(object sender, EventArgs e)
        {
            /// Je récupère la ligne de l'adhérent séléctionnée
            cda27_bd2DataSet.adherentsRow currentRow = (cda27_bd2DataSet.adherentsRow)((DataRowView)adherentsBindingSource.Current).Row;
            if (currentRow.IdAdherent == 100)
            {
                MessageBox.Show(Properties.Resources.STR_MESSAGE_IMPOSSIBLE_SUPPRIMER_SECRETAIRE,
                    Properties.Resources.STR_TITRE_IMPOSSIBLE_SUPPRIMER_SECRETAIRE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            /// J'affiche un message de confirmation pour cette suppression
            DialogResult DiagResult = MessageBox.Show(String.Format(Properties.Resources.STR_MESSAGE_SUPPRESSION_ADHERENT, currentRow.Login),
                String.Format(Properties.Resources.STR_TITRE_SUPPRESSION_ADHERENT, currentRow.Nom, currentRow.Prénom),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2
                ); ;
            /// Si l'utilisateur accepte la suppression
            if (DiagResult == DialogResult.Yes)
            {
                /// Je supprime l'adhérent en me servant du TableAdapter de l'adhérent avec les données de la ligne active
                /// J'enregistre le résultat de la requête pour vérifier qu'elle a bien été exécutée
                int nb = adherentTableAdapter.Delete(currentRow.IdAdherent, currentRow.Nom, currentRow.Prénom, currentRow.Date_de_naissance, currentRow.Adresse,
                    null, currentRow.Code_postale, currentRow.Ville, currentRow.Email, currentRow.Téléphone, currentRow._Date_d_adhésion, currentRow.Organisateur,
                    currentRow.Admin, currentRow.Login, currentRow.Password, currentRow.Cylindrée, currentRow.Activé);
                /// Si la requête n'a pas aboutie
                if (nb == 0)
                {
                    /// J'affiche un message d'echec
                    MessageBox.Show(Properties.Resources.STR_MESSAGE_SUPPRESSION_FAIL, Properties.Resources.STR_TITRE_SUPPRESSION_FAIL, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                /// Je FillIntegral
                FillIntegral();
            }
        }
        #endregion

        #region Désinscrire adhérent depuis adhérent
        /// <summary>
        /// Action du bouton Désinscrire dans l'onglet Adhérent (Désinscrire un adhérent)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDesinscrireAdherent_Click(object sender, EventArgs e)
        {
            /// Je récupère la ligne correspondant à l'inscription effective de l'adhérent
            cda27_bd2DataSet.inscriptionsRow currentRow = (cda27_bd2DataSet.inscriptionsRow)((DataRowView)inscriptionsBindingSource.Current).Row;
            /// J'enregistre la valeur de la colonne IdAdherent dans une variable integer IdAdherent (Elle me servira plus tard)
            int IdAdherent = currentRow.IdAdherent;
            /// J'affiche un message de confirmation de suppression d'inscription
            DialogResult DiagResult = MessageBox.Show(Properties.Resources.STR_MESSAGE_SUPPRIMER_INSCRIPTION, Properties.Resources.STR_TITRE_SUPPRIMER_INSCRIPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            /// Si l'utilisateur appuie sur "Non" alors j'arrête l'évenement
            if (DiagResult == DialogResult.No)
            {
                return;
            }
            /// Je supprime l'inscription depuis le TableAdapter d'inscription avec les valeurs des variables de la ligne courante
            int nb = inscriptionTableAdapter1.Delete(currentRow.IdInscription,
                currentRow._Date_d_inscription,
                currentRow._Nombre_d_invités,
                currentRow.IdAdherent,
                currentRow.IdActivite);
            /// Si le résultat de la requête est à 0, la suppression n'a pas fonctionnée
            if (nb == 0)
            {
                /// J'affiche un message d'echec de suppression
                MessageBox.Show(Properties.Resources.STR_MESSAGE_PROBLEME_SUPPRESSION_INSCRIPTION, Properties.Resources.STR_TITRE_PROBLEME_SUPPRESSION_INSCRIPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /// Je FillIntegral
            FillIntegral();
            /// Je me repositionne sur l'adhérent précédemment sélectionné (dont j'ai gardé son Id plus haut)
            adherentsBindingSource.Position = adherentsBindingSource.Find("IdAdherent", IdAdherent);
        }
        #endregion
        #endregion

        #region Activité
        #region Ajout activité
        /// <summary>
        /// Action du bouton Ajouter dans l'onglet Activité (Ajouter une activité)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouterActivite_Click(object sender, EventArgs e)
        {
            /// Using de la formDetailActivite (nouvelle fenêtre) pour faire un "dispose" à la fermeture
            using (formDetailActivite frmDetailActivite = new formDetailActivite())
            {
                /// Les choses inutiles dans l'ajout d'une activité deviennent invisibles
                frmDetailActivite.buttonModifierActivite.Visible = false;
                frmDetailActivite.buttonSupprimerActivite.Visible = false;
                frmDetailActivite.lblInscrits.Visible = false;
                frmDetailActivite.dataGridViewInscrits.Visible = false;
                /// J'affiche la fenêtre en mode Dialog (le using n'aurait pas été possible sans ça)
                frmDetailActivite.ShowDialog();
                /// Si la fenêtre se ferme
                if (frmDetailActivite.IsClose)
                {
                    /// Je FillIntegral
                    FillIntegral();
                    /// Je me repositionne sur l'activité ajoutée précédemment
                    activitesBindingSourceListeAct.Position = activitesBindingSourceListeAct.Find("IdActivite", frmDetailActivite.LastInsert);
                    /// IsClose vaut maintenant 0
                    frmDetailActivite.IsClose = false;
                }
            }
        }
        #endregion

        #region Modification activité
        /// <summary>
        /// Action du bouton Modifier dans l'onglet Activité (Modifier une activité)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifierActivite_Click(object sender, EventArgs e)
        {
            /// Using de la formDetailActivite (nouvelle fenêtre) pour faire un "dispose" à la fermeture
            using (formDetailActivite frmDetailActivite = new formDetailActivite())
            {
                /// J'envoie à la fenêtre fille le binding de l'activité
                frmDetailActivite.adherentbind = activitesBindingSourceListeAct;

                /// Récupération de la ligne courrante pour une utilisation des valeurs de ses colonnes
                cda27_bd2DataSet.activitesRow currentRow = (cda27_bd2DataSet.activitesRow)((DataRowView)activitesBindingSourceListeAct.Current).Row;
                frmDetailActivite.currentRowAdh = currentRow;
                /// J'envoie l'IdActivite et l'IdType à la fenêtre fille
                frmDetailActivite.IdActivite = currentRow.IdActivite;
                frmDetailActivite.IdType = currentRow.IdType;
                /// Je rends invisible le bouton ajouter
                frmDetailActivite.buttonAjouterActivite.Visible = false;
                /// Mise des valeurs dans les TextBox et dateTimePicker correspondant à l'adhérent
                /// 
                int publier;
                if (currentRow.Publié == 1)
                {
                    frmDetailActivite.checkBoxPublic.Checked = true;
                }
                else
                {
                    frmDetailActivite.checkBoxPublic.Checked = false;
                }
                frmDetailActivite.textBoxTarifInvite.Text = currentRow.Tarif_invité;
                frmDetailActivite.textBoxTarifAdherent.Text = currentRow.Tarif_adhérent;
                frmDetailActivite.textBoxIntituleAct.Text = currentRow.Intitulé;
                frmDetailActivite.dateTimePickerDateDebut.Value = currentRow.Date_de_début;
                frmDetailActivite.dateTimePickerDateFin.Value = currentRow.Date_de_fin;
                frmDetailActivite.dateTimePickerDateLimite.Value = currentRow._Date_limite_d_inscription;
                frmDetailActivite.textBoxDescription.Text = Convert.ToString(currentRow.Description);
                /// J'indique à la fenêtre fille qu'une modification est en cours
                frmDetailActivite.ModifEnCours = true;
                /// J'affiche la fenêtre en mode Dialog
                frmDetailActivite.ShowDialog();
                /// Si la fenêtre se ferme
                if (frmDetailActivite.IsClose)
                {
                    /// Je FillIntegral
                    FillIntegral();
                    /// Je me repositionne sur l'activité qui vient d'être modifiée précédemment
                    activitesBindingSourceListeAct.Position = activitesBindingSourceListeAct.Find("IdActivite", frmDetailActivite.LastInsert);
                    /// IsClose et ModifEnCours deviennent 0
                    frmDetailActivite.IsClose = false;
                    frmDetailActivite.ModifEnCours = false;
                }
            }
        }
        #endregion

        #region Suppression activité
        /// <summary>
        /// Action du bouton Supprimer dans l'onglet Activité (Supprimer une activité)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupprimerActivite_Click(object sender, EventArgs e)
        {
            /// Récupération de la ligne courrante pour une utilisation des valeurs de ses colonnes
            cda27_bd2DataSet.activitesRow currentRow = (cda27_bd2DataSet.activitesRow)((DataRowView)activitesBindingSourceListeAct.Current).Row;
            /// Affichage d'un message de confirmation de suppression d'activité
            DialogResult DiagResult = MessageBox.Show(Properties.Resources.STR_MESSAGE_SUPPRESSION_ACTIVITE, Properties.Resources.STR_TITRE_SUPPRESSION_ACTIVITE, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            /// Si l'utilisateur clique sur Yes
            if (DiagResult == DialogResult.Yes)
            {
                /// Je supprime l'activité en utilisant les valeurs de la ligne courante
                int nb = activiteTableAdapter1.Delete(currentRow.IdActivite, currentRow.Intitulé, currentRow.Date_de_début,
                    currentRow.Date_de_fin, currentRow.Description, currentRow.Tarif_adhérent, currentRow.Tarif_invité,
                    currentRow._Date_limite_d_inscription, currentRow.IdAdherent, currentRow.IdType, currentRow.Publié);
                /// Si le résultat de la requête est de 0
                if (nb == 0)
                {
                    /// J'affiche un message d'echec
                    MessageBox.Show(Properties.Resources.STR_MESSAGE_SUPPRESSION_FAIL, Properties.Resources.STR_TITRE_SUPPRESSION_FAIL, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                /// Je FillIntegral
                FillIntegral();
            }
        }
        #endregion

        #region Inscrire/Desinscrire un adhérent depuis Activité
        /// <summary>
        /// Action du bouton Inscrire dans l'onglet Activité (Inscrire un adhérent à une activité)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInscrireAdherentActivite_Click(object sender, EventArgs e)
        {
            /// Récupération de la ligne courante Activité et des valeurs de ses colonnes dans une variable currentRow
            cda27_bd2DataSet.activitesRow currentRow = (cda27_bd2DataSet.activitesRow)((DataRowView)activitesBindingSourceListeAct.Current).Row;
            /// Mise en variable de la valeur d'IdActivite de la ligne courante d'activité
            int IdActivite = currentRow.IdActivite;
            /// Récupération de la ligne courante des non-inscrits et de ses valeurs dans une variable currentRow2
            cda27_bd2DataSet.adherents2Row currentRow2 = (cda27_bd2DataSet.adherents2Row)((DataRowView)adherents2BindingSource.Current).Row;
            /// Using de la FormInscriptionActivite (nouvelle fenêtre) pour faire un "dispose" à la fermeture
            using (FormInscriptionActivite frmInscriptionActivite = new FormInscriptionActivite())
            {
                /// Envoie des valeurs des currentRow et currentRow2 dans des variables directement à la fenêtre fille
                frmInscriptionActivite.IdActivite = currentRow.IdActivite;
                frmInscriptionActivite.IdAdherent = currentRow2.IdAdherent;
                frmInscriptionActivite.textBoxIntituleAct.Text = currentRow.Intitulé;
                frmInscriptionActivite.textBoxDescription.Text = currentRow.Description;
                frmInscriptionActivite.textBoxTarifAdherent.Text = currentRow.Tarif_adhérent;
                frmInscriptionActivite.textBoxTarifInvite.Text = currentRow.Tarif_invité;
                frmInscriptionActivite.dateTimePickerDateDebutAct.Value = currentRow.Date_de_début;
                frmInscriptionActivite.dateTimePickerDateFinAct.Value = currentRow.Date_de_fin;
                frmInscriptionActivite.dateTimePickerDateLimiteAct.Value = currentRow._Date_limite_d_inscription;
                frmInscriptionActivite.textBoxLogin.Text = currentRow2.Login;
                frmInscriptionActivite.textBoxNom.Text = currentRow2.Nom;
                frmInscriptionActivite.textBoxPrenom.Text = currentRow2.Prénom;
                frmInscriptionActivite.textBoxCylindrée.Text = currentRow2.Cylindrée;
                /// Initialisation du textBox du nombre d'invité à 0
                frmInscriptionActivite.textBoxNombreInvite.Text = "0";
                /// Affichage de la fenêtre en mode Dialog 
                frmInscriptionActivite.ShowDialog();
                /// Si l'inscription se termine
                if (frmInscriptionActivite.InscriptionFinie == 1)
                {
                    /// Je FillIntegral
                    FillIntegral();
                    /// Je me repositionne sur l'activité précédemment séléctionnée
                    activitesBindingSourceListeAct.Position = activitesBindingSourceListeAct.Find("IdActivite", IdActivite);
                    /// InscriptionFinie est à présent à 0
                    frmInscriptionActivite.InscriptionFinie = 0;
                }
            }
        }

        private void buttonDesinscrireAdherentActivite_Click(object sender, EventArgs e)
        {
            /// Récupération de la ligne courante Activité et des valeurs de ses colonnes dans une variable currentRow
            cda27_bd2DataSet.activitesRow currentRow = (cda27_bd2DataSet.activitesRow)((DataRowView)activitesBindingSourceListeAct.Current).Row;
            /// Récupération de la ligne courante des inscriptions de l'activité et des valeurs de ses colonnes dans une variable currentRow2
            cda27_bd2DataSet.adherentinscriptionRow currentRow2 = (cda27_bd2DataSet.adherentinscriptionRow)((DataRowView)adherentinscriptionBindingSource.Current).Row;
            /// Je stock l'IdActivite de la la ligne courante de l'activité pour l'utilisation future
            int IdActivite = currentRow.IdActivite;
            /// J'affiche un message de confirmation de suppression
            DialogResult DiagResult = MessageBox.Show(String.Format(Properties.Resources.STR_MESSAGE_CONFIRMATION_SUPPRESSION, currentRow2.Prénom),
                                                        String.Format(Properties.Resources.STR_TITRE_CONFIRMATION_SUPPRESSION, currentRow2.Prénom, currentRow2.Nom),
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Information,
                                                        MessageBoxDefaultButton.Button2);
            /// Si l'utilisateur clique sur Oui
            if (DiagResult == DialogResult.Yes)
            {
                /// Je procède à la suppression de l'inscription avec les valeurs de currentRow2
                int nb = inscriptionTableAdapter1.Delete(currentRow2.IdInscription, currentRow2.DInscription, currentRow2.NbInvités,
                    currentRow2.IdAdherent, currentRow2.IdActivite);
                /// Si la suppression a échouée
                if (nb == 0)
                {
                    /// J'affiche un message correspondant
                    MessageBox.Show(Properties.Resources.STR_MESSAGE_DESINSCRIPTION_ERREUR, Properties.Resources.STR_TITRE_DESINSCRIPTION_ERREUR, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            /// Je FillIntegral
            FillIntegral();
            /// Je me repositionne sur l'activité précédemment séléctionnée
            activitesBindingSourceListeAct.Position = activitesBindingSourceListeAct.Find("IdActivite", IdActivite);
        }
        private void buttonModifierInscriptionActivite_Click(object sender, EventArgs e)
        {
            /// Récupération de la ligne courante Activité et des valeurs de ses colonnes dans une variable currentRow
            cda27_bd2DataSet.activitesRow currentRow = (cda27_bd2DataSet.activitesRow)((DataRowView)activitesBindingSourceListeAct.Current).Row;
            /// Je stock l'IdActivite de la la ligne courante de l'activité pour l'utilisation future
            int IdActivite = currentRow.IdActivite;
            /// Récupération de la ligne courante des inscriptions de l'activité et des valeurs de ses colonnes dans une variable currentRow2
            cda27_bd2DataSet.adherentinscriptionRow currentRow2 = (cda27_bd2DataSet.adherentinscriptionRow)((DataRowView)adherentinscriptionBindingSource.Current).Row;
            using (FormInscriptionActivite frmInscriptionActivite = new FormInscriptionActivite())
            {
                /// Envoie des valeurs des currentRow et currentRow2 dans des variables directement à la fenêtre fille
                frmInscriptionActivite.IdActivite = currentRow.IdActivite;
                frmInscriptionActivite.IdAdherent = currentRow2.IdAdherent;
                frmInscriptionActivite.textBoxIntituleAct.Text = currentRow.Intitulé;
                frmInscriptionActivite.textBoxDescription.Text = currentRow.Description;
                frmInscriptionActivite.textBoxTarifAdherent.Text = currentRow.Tarif_adhérent;
                frmInscriptionActivite.textBoxTarifInvite.Text = currentRow.Tarif_invité;
                frmInscriptionActivite.dateTimePickerDateDebutAct.Value = currentRow.Date_de_début;
                frmInscriptionActivite.dateTimePickerDateFinAct.Value = currentRow.Date_de_fin;
                frmInscriptionActivite.dateTimePickerDateLimiteAct.Value = currentRow._Date_limite_d_inscription;
                frmInscriptionActivite.textBoxLogin.Text = currentRow2.Login;
                frmInscriptionActivite.textBoxNom.Text = currentRow2.Nom;
                frmInscriptionActivite.textBoxPrenom.Text = currentRow2.Prénom;
                frmInscriptionActivite.textBoxCylindrée.Text = currentRow2.Cylindrée;
                /// Initialisation du textBox du nombre d'invité à la valeur de l'inscription de l'adhérent
                frmInscriptionActivite.textBoxNombreInvite.Text = Convert.ToString(currentRow2.NbInvités);
                /// Je nomme le bouton 
                frmInscriptionActivite.buttonInscrireAdherentActivite.Text = "Modifier l'inscription de l'adhérent";
                /// Je dis qu'une modification est en cours pour la fenêtre fille
                frmInscriptionActivite.ModificationEnCours = true;
                /// J'envoie le bindingSource à la fenêtre fille
                frmInscriptionActivite.inscriptionAct = adherentinscriptionBindingSource;
                /// Affichage de la fenêtre en mode Dialog 
                frmInscriptionActivite.ShowDialog();
                /// Si l'inscription se termine
                if (frmInscriptionActivite.InscriptionFinie == 1)
                {
                    /// Je FillIntegral
                    FillIntegral();
                    /// Je me repositionne sur l'activité précédemment séléctionnée
                    activitesBindingSourceListeAct.Position = activitesBindingSourceListeAct.Find("IdActivite", IdActivite);
                    /// InscriptionFinie est à présent à 0
                    frmInscriptionActivite.InscriptionFinie = 0;
                }
            }
        }
        #endregion

        #region Gestion du checkbox de tri des activités par date
        /// <summary>
        /// Quand la CheckBox du choix de la date est cochée ou décochée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxChoisirDate_CheckedChanged(object sender, EventArgs e)
        {
            /// Si elle est cochée
            if (checkBoxChoisirDate.Checked)
            {
                /// Les dateTimePicker sont actifs ainsi que le bouton search
                dateTimePickerFirstDate.Enabled = true;
                dateTimePickerSecondDate.Enabled = true;
                buttonSearch.Enabled = true;
            }
            /// Sinon
            else
            {
                ///Les dateTimePicker sont inactifs ainsi que le bouton search
                dateTimePickerFirstDate.Enabled = false;
                dateTimePickerSecondDate.Enabled = false;
                buttonSearch.Enabled = false;
                /// Je FillIntegral
                FillIntegral();
            }
        }
        #endregion
        #endregion

        #region Gestion des RowEnter pour les inscrits/non-inscrits
        /// <summary>
        /// Action quand j'entre sur une ligne des non-inscrits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewNonInscrits_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            /// Je Clear la séléction des inscrits
            dataGridViewInscrits.ClearSelection();
            /// J'active le bouton Inscrire et désactive le bouton Désinscrire
            buttonInscrireAdherentActivite.Enabled = true;
            buttonDesinscrireAdherentActivite.Enabled = false;
            buttonModifierInscriptionActivite.Enabled = false;


        }
        /// <summary>
        /// Action quand j'entre sur une ligne des inscrits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewInscrits_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            /// Je Clear la séléction des non-inscrits
            dataGridViewNonInscrits.ClearSelection();
            /// Je désactive le bouton Inscrire et active le bouton Désinscrire
            buttonInscrireAdherentActivite.Enabled = false;
            buttonDesinscrireAdherentActivite.Enabled = true;
            buttonModifierInscriptionActivite.Enabled = true;

        }
        #endregion

        #region CurrentChanged
        /// <summary>
        /// Action quand la séléction d'un adhérent a changé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adherentsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            /// Si la ligne séléctionnée est présente (non-null)
            if (adherentsBindingSource.Current != null)
            {
                /// Je récupère celle-ci et Fill la liste des inscriptions de cet adhérent par rapport à son IdAdherent
                cda27_bd2DataSet.adherentsRow currentRow = (cda27_bd2DataSet.adherentsRow)((DataRowView)adherentsBindingSource.Current).Row;
                // TODO: cette ligne de code charge les données dans la table 'cda27_bd2DataSet.activite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
                this.inscriptionsTableAdapter.Fill(this.cda27_bd2DataSet.inscriptions, currentRow.IdAdherent);
            }
            /// Si la liste des inscriptions contient quelque chose
            if (inscriptionsBindingSource.Count != 0)
            {
                /// Le bouton Désinscrire est actif
                buttonDesinscrireAdherent.Enabled = true;
                buttonModifierInscriptionActivite.Enabled = true;

            }
            /// Sinon
            else
            {
                /// Le bouton est inactif
                buttonDesinscrireAdherent.Enabled = false;
                buttonModifierInscriptionActivite.Enabled = false;
            }
        }
        /// <summary>
        /// Si la séléction de la liste des activités a changé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void activitesBindingSourceListeAct_CurrentChanged_1(object sender, EventArgs e)
        {
            /// Et si la séléction est différente de null
            if (activitesBindingSourceListeAct.Current != null)
            {
                /// Je récupère la ligne de l'activité
                cda27_bd2DataSet.activitesRow currentRow = (cda27_bd2DataSet.activitesRow)((DataRowView)activitesBindingSourceListeAct.Current).Row;
                /// Je Fill les inscriptions avec comme argument l'IdActivite pour ne séléctionner que les adhérents inscrits à cette activité
                this.adherentinscriptionTableAdapter.FillBy(this.cda27_bd2DataSet1.adherentinscription, currentRow.IdActivite);
                /// Je Fill les inscriptions avec comme argument l'IdActivite pour ne séléctionner que les adhérents non-inscrits à cette activité
                this.adherents2TableAdapter.FillBy(this.cda27_bd2DataSet1.adherents2, currentRow.IdActivite);
            }
        }
        #endregion

        #region Boutons fermeture
        /// <summary>
        /// Action du bouton Fermer 
        /// Un close est exécuté
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFermerActivite_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonFermerAdherent_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region FormClosing
        /// <summary>
        /// Avant que la fermeture soit faite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!VaSeFermer)
            {
                /// J'affiche un message de confirmation de fermeture
                DialogResult DiagResult = MessageBox.Show(Properties.Resources.STR_MESSAGE_FERMER, Properties.Resources.STR_TITRE_FERMER, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                /// Si le bouton "Non" est cliqué
                if (DiagResult == DialogResult.No)
                {
                    /// J'annule la fermeture
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region Fonction Fill et bouton Search
        /// <summary>
        /// Rafraîchissement intégral des dataGridViews
        /// TryCatch si la bdd est déconnectée alors on affiche un message d'erreur et on quitte le logiciel
        /// </summary>
        public void FillIntegral()
        {
            try
            {
                /// Si le filtre par date est coché
                if (checkBoxChoisirDate.Checked)
                {
                    /// Je Fill entre les deux dates la liste des activités
                    this.activitesTableAdapter.FillByDate(this.cda27_bd2DataSet.activites, dateTimePickerFirstDate.Value, dateTimePickerSecondDate.Value); ;
                }
                else
                {
                    /// Sinon je Fill tout court
                    this.activitesTableAdapter.Fill(this.cda27_bd2DataSet.activites);
                }
                if (activitesBindingSourceListeAct.Current != null)
                {
                    /// Je récupère la ligne d'activité séléctionnée
                    cda27_bd2DataSet.activitesRow currentRow = (cda27_bd2DataSet.activitesRow)((DataRowView)activitesBindingSourceListeAct.Current).Row;
                    /// Je Fill les inscriptions des adherents avec l'IdActivite de la ligne séléctionnée
                    this.adherentinscriptionTableAdapter.FillBy(this.cda27_bd2DataSet1.adherentinscription, currentRow.IdActivite);
                    /// Je Fill les adhérents non-inscrits 
                    this.adherents2TableAdapter.FillBy(this.cda27_bd2DataSet1.adherents2, currentRow.IdActivite);
                    /// Je Fill les adherents
                    this.adherentsTableAdapter.Fill(this.cda27_bd2DataSet.adherents);
                    /// Je rends visible les datagrid inscrits et non inscrits car il y a une activité
                    dataGridViewInscrits.Visible = true;
                    dataGridViewNonInscrits.Visible = true;
                }
                /// Sinon je les rends invisible
                else
                {
                    dataGridViewInscrits.Visible = false;
                    dataGridViewNonInscrits.Visible = false;
                }
                if (adherentsBindingSource.Current != null)
                {
                    /// Je récupère la ligne séléctionnée des adhérents
                    cda27_bd2DataSet.adherentsRow currentRow2 = (cda27_bd2DataSet.adherentsRow)((DataRowView)adherentsBindingSource.Current).Row;
                    /// Je Fill les inscriptions pour cet adhérent
                    this.inscriptionsTableAdapter.Fill(this.cda27_bd2DataSet.inscriptions, currentRow2.IdAdherent);
                    /// Si il y a un adhérent alors je rends visible ses inscriptions
                    dataGridViewActiviteRelationAdherent.Visible = true;
                }
                /// Sinon je les rends invisible
                else
                {
                    dataGridViewActiviteRelationAdherent.Visible = false;
                }
                /// Je Clear les selections des inscrits et non inscrits
                dataGridViewNonInscrits.ClearSelection();
                dataGridViewInscrits.ClearSelection();
            }
            catch (Exception ex)
            {
                VaSeFermer = true;
                MessageBox.Show(Properties.Resources.STR_MESSAGE_CONNEXION_BDD_ERROR,
                    Properties.Resources.STR_TITRE_CONNEXION_BDD_ERROR,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                this.Close();
            }
        }
        /// <summary>
        /// Action de Fill au clique du bouton "Search" à côté de filtre par date des activités
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FillIntegral();
        }
        #endregion

        public int CalculAge(DateTime anniversaire)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - anniversaire.Year;
            if (anniversaire > now.AddYears(-age))
                age--;
            return age;
        }


    }
}
