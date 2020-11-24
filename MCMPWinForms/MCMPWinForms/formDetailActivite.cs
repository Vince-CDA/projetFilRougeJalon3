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
        public BindingSource activitebind { get; set; }

        public BindingSource adherentbind { set; get; }
        public long LastInsert { get; set; }
        public int IdType { get; set; }
        public const string motifPrix = @"[0-9]{1,}[.,]{0,1}[0-9]{0,2}";
        public int IsClose { get; set; }
        public int ModifEnCours { get; set; }
        public int IdActivite { get; set; }
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

        private void buttonAjouterActivite_Click(object sender, EventArgs e)
        {
            cda27_bd2DataSet.type_activiteRow currentRow = (cda27_bd2DataSet.type_activiteRow)((DataRowView)typeactiviteBindingSource.Current).Row;
            int publier = checkBoxPublic.Checked ? 1 : 0;
            if (String.IsNullOrWhiteSpace(textBoxIntituleAct.Text) 
                || String.IsNullOrWhiteSpace(textBoxDescription.Text)
                || String.IsNullOrWhiteSpace(textBoxTarifAdherent.Text)
                || String.IsNullOrWhiteSpace(textBoxTarifInvite.Text))
            {
                MessageBox.Show("Un champs n'est pas rempli.");
                return;
            }
            if (dateTimePickerDateDebut.Value < DateTime.Now 
                && dateTimePickerDateDebut.Value > dateTimePickerDateFin.Value
                && dateTimePickerDateLimite.Value < dateTimePickerDateDebut.Value
                && dateTimePickerDateLimite.Value > dateTimePickerDateFin.Value)
            {
                MessageBox.Show("La date de début doit être supérieur à la date d'aujourd'hui," +
                    " la date limite doit être supérieur à la date de début ainsi qu'inférieur à la date de fin " +
                    "et la date de fin doit être supérieur à la date limite.");
                return;
            }
            else if (!IsPrix(textBoxTarifAdherent.Text) || !IsPrix(textBoxTarifInvite.Text))
            {
                MessageBox.Show("Il y a un problème avec les tarifs, merci de taper un tarif avec des chiffres et une seule virgule si besoin sans le symbole €.");
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
                MessageBox.Show("L'activité à bien été ajoutée");
                LastInsert = activiteTableAdapter.Adapter.InsertCommand.InsertId;
                IsClose = 1;
                Close();
            }
            else
            {
                MessageBox.Show("Il y a un problème pour l'ajout de cette activité");
            }
        }

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
                MessageBox.Show("Un champs n'est pas rempli.");
                return;
            }
            if (dateTimePickerDateDebut.Value < DateTime.Now
                && dateTimePickerDateDebut.Value > dateTimePickerDateFin.Value
                && dateTimePickerDateLimite.Value < dateTimePickerDateDebut.Value
                && dateTimePickerDateLimite.Value > dateTimePickerDateFin.Value)
            {
                MessageBox.Show("La date de début doit être supérieur à la date d'aujourd'hui," +
                    " la date limite doit être supérieur à la date de début ainsi qu'inférieur à la date de fin " +
                    "et la date de fin doit être supérieur à la date limite.");
                return;
            }
            else if (!IsPrix(textBoxTarifAdherent.Text) || !IsPrix(textBoxTarifInvite.Text))
            {
                MessageBox.Show("Il y a un problème avec les tarifs, merci de taper un tarif avec des chiffres et une seule virgule si besoin sans le symbole €.");
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
                MessageBox.Show("La mise à jour ne s'est pas réalisée");
                return;
            }
            LastInsert = activiteTableAdapter.Adapter.UpdateCommand.InsertId;
            IsClose = 1;
            Close();

        }

        

        public static bool IsPrix(string prix)
        {
            if (prix != null) return Regex.IsMatch(prix, motifPrix);
            else return false;
        }

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

        private void formDetailActivite_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
