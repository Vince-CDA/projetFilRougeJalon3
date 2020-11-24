namespace MCMPWinForms
{
    partial class formDetailActivite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDetailActivite));
            this.textBoxTarifAdherent = new System.Windows.Forms.TextBox();
            this.textBoxTarifInvite = new System.Windows.Forms.TextBox();
            this.lblDateLimite = new System.Windows.Forms.Label();
            this.lblIntitule = new System.Windows.Forms.Label();
            this.textBoxIntituleAct = new System.Windows.Forms.TextBox();
            this.lblTarifInvite = new System.Windows.Forms.Label();
            this.lblTarifInvit = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAjouterActivite = new System.Windows.Forms.Button();
            this.buttonModifierActivite = new System.Windows.Forms.Button();
            this.buttonSupprimerActivite = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAnnulerActivite = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.dateTimePickerDateDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateFin = new System.Windows.Forms.DateTimePicker();
            this.lblTypeAct = new System.Windows.Forms.Label();
            this.dateTimePickerDateLimite = new System.Windows.Forms.DateTimePicker();
            this.lblInscrits = new System.Windows.Forms.Label();
            this.dataGridViewInscrits = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intituléDeLactivitéDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeDébutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDinscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDinvitésDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAdherentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idActiviteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscriptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cda27_bd2DataSet = new MCMPWinForms.cda27_bd2DataSet();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.checkBoxPublic = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.typeactiviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cda27_bd2DataSet2 = new MCMPWinForms.cda27_bd2DataSet();
            this.activitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cda27_bd2DataSet1 = new MCMPWinForms.cda27_bd2DataSet();
            this.adherentsTableAdapter = new MCMPWinForms.cda27_bd2DataSetTableAdapters.adherentsTableAdapter();
            this.inscriptionsTableAdapter = new MCMPWinForms.cda27_bd2DataSetTableAdapters.inscriptionsTableAdapter();
            this.adherents2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adherents2TableAdapter = new MCMPWinForms.cda27_bd2DataSetTableAdapters.adherents2TableAdapter();
            this.type_activiteTableAdapter = new MCMPWinForms.cda27_bd2DataSetTableAdapters.type_activiteTableAdapter();
            this.activiteTableAdapter = new MCMPWinForms.cda27_bd2DataSetTableAdapters.activiteTableAdapter();
            this.activitesTableAdapter = new MCMPWinForms.cda27_bd2DataSetTableAdapters.activitesTableAdapter();
            this.textBoxNomResp = new System.Windows.Forms.TextBox();
            this.lblNomResp = new System.Windows.Forms.Label();
            this.textBoxPrenomResp = new System.Windows.Forms.TextBox();
            this.lblPrenomResp = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscrits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda27_bd2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeactiviteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda27_bd2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda27_bd2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherents2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTarifAdherent
            // 
            this.textBoxTarifAdherent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTarifAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTarifAdherent.Location = new System.Drawing.Point(219, 145);
            this.textBoxTarifAdherent.Name = "textBoxTarifAdherent";
            this.textBoxTarifAdherent.Size = new System.Drawing.Size(263, 29);
            this.textBoxTarifAdherent.TabIndex = 33;
            // 
            // textBoxTarifInvite
            // 
            this.textBoxTarifInvite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTarifInvite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTarifInvite.Location = new System.Drawing.Point(676, 145);
            this.textBoxTarifInvite.Name = "textBoxTarifInvite";
            this.textBoxTarifInvite.Size = new System.Drawing.Size(295, 29);
            this.textBoxTarifInvite.TabIndex = 29;
            // 
            // lblDateLimite
            // 
            this.lblDateLimite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateLimite.AutoSize = true;
            this.lblDateLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateLimite.Location = new System.Drawing.Point(3, 263);
            this.lblDateLimite.Name = "lblDateLimite";
            this.lblDateLimite.Size = new System.Drawing.Size(210, 50);
            this.lblDateLimite.TabIndex = 3;
            this.lblDateLimite.Text = "Date limite d\'inscription :";
            // 
            // lblIntitule
            // 
            this.lblIntitule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIntitule.AutoSize = true;
            this.lblIntitule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntitule.Location = new System.Drawing.Point(3, 19);
            this.lblIntitule.Name = "lblIntitule";
            this.lblIntitule.Size = new System.Drawing.Size(210, 25);
            this.lblIntitule.TabIndex = 0;
            this.lblIntitule.Text = "Intitulé de l\'activité :";
            // 
            // textBoxIntituleAct
            // 
            this.textBoxIntituleAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIntituleAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIntituleAct.Location = new System.Drawing.Point(219, 17);
            this.textBoxIntituleAct.Name = "textBoxIntituleAct";
            this.textBoxIntituleAct.Size = new System.Drawing.Size(263, 29);
            this.textBoxIntituleAct.TabIndex = 1;
            // 
            // lblTarifInvite
            // 
            this.lblTarifInvite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarifInvite.AutoSize = true;
            this.lblTarifInvite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifInvite.Location = new System.Drawing.Point(3, 147);
            this.lblTarifInvite.Name = "lblTarifInvite";
            this.lblTarifInvite.Size = new System.Drawing.Size(210, 25);
            this.lblTarifInvite.TabIndex = 7;
            this.lblTarifInvite.Text = "Tarif adhérent :";
            // 
            // lblTarifInvit
            // 
            this.lblTarifInvit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarifInvit.AutoSize = true;
            this.lblTarifInvit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifInvit.Location = new System.Drawing.Point(488, 147);
            this.lblTarifInvit.Name = "lblTarifInvit";
            this.lblTarifInvit.Size = new System.Drawing.Size(182, 25);
            this.lblTarifInvit.TabIndex = 5;
            this.lblTarifInvit.Text = "Tarif invité :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 640);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 563);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(974, 74);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonAjouterActivite);
            this.flowLayoutPanel1.Controls.Add(this.buttonModifierActivite);
            this.flowLayoutPanel1.Controls.Add(this.buttonSupprimerActivite);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(798, 68);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonAjouterActivite
            // 
            this.buttonAjouterActivite.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonAjouterActivite.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterActivite.Image = global::MCMPWinForms.Properties.Resources.ajouter_act;
            this.buttonAjouterActivite.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAjouterActivite.Location = new System.Drawing.Point(0, 0);
            this.buttonAjouterActivite.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.buttonAjouterActivite.Name = "buttonAjouterActivite";
            this.buttonAjouterActivite.Size = new System.Drawing.Size(131, 64);
            this.buttonAjouterActivite.TabIndex = 16;
            this.buttonAjouterActivite.Text = "&Ajouter activité";
            this.buttonAjouterActivite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAjouterActivite.UseVisualStyleBackColor = false;
            this.buttonAjouterActivite.Click += new System.EventHandler(this.buttonAjouterActivite_Click);
            // 
            // buttonModifierActivite
            // 
            this.buttonModifierActivite.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonModifierActivite.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierActivite.Image = global::MCMPWinForms.Properties.Resources.editer_act;
            this.buttonModifierActivite.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonModifierActivite.Location = new System.Drawing.Point(151, 0);
            this.buttonModifierActivite.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.buttonModifierActivite.Name = "buttonModifierActivite";
            this.buttonModifierActivite.Size = new System.Drawing.Size(131, 64);
            this.buttonModifierActivite.TabIndex = 17;
            this.buttonModifierActivite.Text = "&Modifier activité";
            this.buttonModifierActivite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonModifierActivite.UseVisualStyleBackColor = false;
            this.buttonModifierActivite.Click += new System.EventHandler(this.buttonModifierActivite_Click);
            // 
            // buttonSupprimerActivite
            // 
            this.buttonSupprimerActivite.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonSupprimerActivite.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerActivite.Image = global::MCMPWinForms.Properties.Resources.supprimer_act;
            this.buttonSupprimerActivite.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSupprimerActivite.Location = new System.Drawing.Point(302, 0);
            this.buttonSupprimerActivite.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.buttonSupprimerActivite.Name = "buttonSupprimerActivite";
            this.buttonSupprimerActivite.Size = new System.Drawing.Size(131, 64);
            this.buttonSupprimerActivite.TabIndex = 18;
            this.buttonSupprimerActivite.Text = "&Supprimer activité";
            this.buttonSupprimerActivite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSupprimerActivite.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonAnnulerActivite);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(807, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(164, 68);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // buttonAnnulerActivite
            // 
            this.buttonAnnulerActivite.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonAnnulerActivite.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnulerActivite.Image = global::MCMPWinForms.Properties.Resources.output_onlinepngtools__7_;
            this.buttonAnnulerActivite.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAnnulerActivite.Location = new System.Drawing.Point(86, 0);
            this.buttonAnnulerActivite.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAnnulerActivite.Name = "buttonAnnulerActivite";
            this.buttonAnnulerActivite.Size = new System.Drawing.Size(78, 64);
            this.buttonAnnulerActivite.TabIndex = 18;
            this.buttonAnnulerActivite.Text = "&Annuler";
            this.buttonAnnulerActivite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAnnulerActivite.UseVisualStyleBackColor = false;
            this.buttonAnnulerActivite.Click += new System.EventHandler(this.buttonAnnulerActivite_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.19938F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.64646F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.32168F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.83248F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxTarifInvite, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBoxNomResp, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblPrenomResp, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblIntitule, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxIntituleAct, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTarifInvite, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblNomResp, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblTarifInvit, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblDateDebut, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblDateFin, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBoxPrenomResp, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxTarifAdherent, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerDateDebut, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerDateFin, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblDateLimite, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblTypeAct, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerDateLimite, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblInscrits, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewInscrits, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.textBoxDescription, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblDescription, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxPublic, 3, 4);
            this.tableLayoutPanel3.Controls.Add(this.comboBox1, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(974, 554);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.Location = new System.Drawing.Point(3, 211);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(210, 25);
            this.lblDateDebut.TabIndex = 10;
            this.lblDateDebut.Text = "Date de début :";
            // 
            // lblDateFin
            // 
            this.lblDateFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.Location = new System.Drawing.Point(488, 211);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(182, 25);
            this.lblDateFin.TabIndex = 9;
            this.lblDateFin.Text = "Date de fin :";
            // 
            // dateTimePickerDateDebut
            // 
            this.dateTimePickerDateDebut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateDebut.Location = new System.Drawing.Point(219, 214);
            this.dateTimePickerDateDebut.Name = "dateTimePickerDateDebut";
            this.dateTimePickerDateDebut.Size = new System.Drawing.Size(263, 20);
            this.dateTimePickerDateDebut.TabIndex = 52;
            // 
            // dateTimePickerDateFin
            // 
            this.dateTimePickerDateFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateFin.Location = new System.Drawing.Point(676, 214);
            this.dateTimePickerDateFin.Name = "dateTimePickerDateFin";
            this.dateTimePickerDateFin.Size = new System.Drawing.Size(295, 20);
            this.dateTimePickerDateFin.TabIndex = 53;
            // 
            // lblTypeAct
            // 
            this.lblTypeAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTypeAct.AutoSize = true;
            this.lblTypeAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeAct.Location = new System.Drawing.Point(488, 19);
            this.lblTypeAct.Name = "lblTypeAct";
            this.lblTypeAct.Size = new System.Drawing.Size(182, 25);
            this.lblTypeAct.TabIndex = 11;
            this.lblTypeAct.Text = "Type d\'activité :";
            // 
            // dateTimePickerDateLimite
            // 
            this.dateTimePickerDateLimite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateLimite.Location = new System.Drawing.Point(219, 278);
            this.dateTimePickerDateLimite.Name = "dateTimePickerDateLimite";
            this.dateTimePickerDateLimite.Size = new System.Drawing.Size(263, 20);
            this.dateTimePickerDateLimite.TabIndex = 51;
            // 
            // lblInscrits
            // 
            this.lblInscrits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInscrits.AutoSize = true;
            this.lblInscrits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscrits.Location = new System.Drawing.Point(488, 412);
            this.lblInscrits.Name = "lblInscrits";
            this.lblInscrits.Size = new System.Drawing.Size(182, 50);
            this.lblInscrits.TabIndex = 19;
            this.lblInscrits.Text = "Inscrit(s) à l\'activité :";
            // 
            // dataGridViewInscrits
            // 
            this.dataGridViewInscrits.AllowUserToAddRows = false;
            this.dataGridViewInscrits.AllowUserToDeleteRows = false;
            this.dataGridViewInscrits.AutoGenerateColumns = false;
            this.dataGridViewInscrits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewInscrits.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewInscrits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInscrits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prénomDataGridViewTextBoxColumn,
            this.intituléDeLactivitéDataGridViewTextBoxColumn,
            this.dateDeDébutDataGridViewTextBoxColumn,
            this.dateDeFinDataGridViewTextBoxColumn,
            this.dateDinscriptionDataGridViewTextBoxColumn,
            this.nombreDinvitésDataGridViewTextBoxColumn,
            this.idInscriptionDataGridViewTextBoxColumn,
            this.idAdherentDataGridViewTextBoxColumn,
            this.idActiviteDataGridViewTextBoxColumn});
            this.dataGridViewInscrits.DataSource = this.inscriptionsBindingSource;
            this.dataGridViewInscrits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInscrits.Location = new System.Drawing.Point(676, 323);
            this.dataGridViewInscrits.Name = "dataGridViewInscrits";
            this.dataGridViewInscrits.ReadOnly = true;
            this.dataGridViewInscrits.RowHeadersVisible = false;
            this.dataGridViewInscrits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInscrits.Size = new System.Drawing.Size(295, 228);
            this.dataGridViewInscrits.TabIndex = 54;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 54;
            // 
            // prénomDataGridViewTextBoxColumn
            // 
            this.prénomDataGridViewTextBoxColumn.DataPropertyName = "Prénom";
            this.prénomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prénomDataGridViewTextBoxColumn.Name = "prénomDataGridViewTextBoxColumn";
            this.prénomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prénomDataGridViewTextBoxColumn.Width = 68;
            // 
            // intituléDeLactivitéDataGridViewTextBoxColumn
            // 
            this.intituléDeLactivitéDataGridViewTextBoxColumn.DataPropertyName = "Intitulé de l\'activité";
            this.intituléDeLactivitéDataGridViewTextBoxColumn.HeaderText = "Intitulé de l\'activité";
            this.intituléDeLactivitéDataGridViewTextBoxColumn.Name = "intituléDeLactivitéDataGridViewTextBoxColumn";
            this.intituléDeLactivitéDataGridViewTextBoxColumn.ReadOnly = true;
            this.intituléDeLactivitéDataGridViewTextBoxColumn.Visible = false;
            this.intituléDeLactivitéDataGridViewTextBoxColumn.Width = 119;
            // 
            // dateDeDébutDataGridViewTextBoxColumn
            // 
            this.dateDeDébutDataGridViewTextBoxColumn.DataPropertyName = "Date de début";
            this.dateDeDébutDataGridViewTextBoxColumn.HeaderText = "Date de début";
            this.dateDeDébutDataGridViewTextBoxColumn.Name = "dateDeDébutDataGridViewTextBoxColumn";
            this.dateDeDébutDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDeDébutDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDeFinDataGridViewTextBoxColumn
            // 
            this.dateDeFinDataGridViewTextBoxColumn.DataPropertyName = "Date de fin";
            this.dateDeFinDataGridViewTextBoxColumn.HeaderText = "Date de fin";
            this.dateDeFinDataGridViewTextBoxColumn.Name = "dateDeFinDataGridViewTextBoxColumn";
            this.dateDeFinDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDeFinDataGridViewTextBoxColumn.Visible = false;
            this.dateDeFinDataGridViewTextBoxColumn.Width = 84;
            // 
            // dateDinscriptionDataGridViewTextBoxColumn
            // 
            this.dateDinscriptionDataGridViewTextBoxColumn.DataPropertyName = "Date d\'inscription";
            this.dateDinscriptionDataGridViewTextBoxColumn.HeaderText = "Date d\'inscription";
            this.dateDinscriptionDataGridViewTextBoxColumn.Name = "dateDinscriptionDataGridViewTextBoxColumn";
            this.dateDinscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDinscriptionDataGridViewTextBoxColumn.Visible = false;
            this.dateDinscriptionDataGridViewTextBoxColumn.Width = 113;
            // 
            // nombreDinvitésDataGridViewTextBoxColumn
            // 
            this.nombreDinvitésDataGridViewTextBoxColumn.DataPropertyName = "Nombre d\'invités";
            this.nombreDinvitésDataGridViewTextBoxColumn.HeaderText = "Nombre d\'invités";
            this.nombreDinvitésDataGridViewTextBoxColumn.Name = "nombreDinvitésDataGridViewTextBoxColumn";
            this.nombreDinvitésDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDinvitésDataGridViewTextBoxColumn.Width = 101;
            // 
            // idInscriptionDataGridViewTextBoxColumn
            // 
            this.idInscriptionDataGridViewTextBoxColumn.DataPropertyName = "IdInscription";
            this.idInscriptionDataGridViewTextBoxColumn.HeaderText = "IdInscription";
            this.idInscriptionDataGridViewTextBoxColumn.Name = "idInscriptionDataGridViewTextBoxColumn";
            this.idInscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idInscriptionDataGridViewTextBoxColumn.Visible = false;
            this.idInscriptionDataGridViewTextBoxColumn.Width = 89;
            // 
            // idAdherentDataGridViewTextBoxColumn
            // 
            this.idAdherentDataGridViewTextBoxColumn.DataPropertyName = "IdAdherent";
            this.idAdherentDataGridViewTextBoxColumn.HeaderText = "IdAdherent";
            this.idAdherentDataGridViewTextBoxColumn.Name = "idAdherentDataGridViewTextBoxColumn";
            this.idAdherentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAdherentDataGridViewTextBoxColumn.Visible = false;
            this.idAdherentDataGridViewTextBoxColumn.Width = 84;
            // 
            // idActiviteDataGridViewTextBoxColumn
            // 
            this.idActiviteDataGridViewTextBoxColumn.DataPropertyName = "IdActivite";
            this.idActiviteDataGridViewTextBoxColumn.HeaderText = "IdActivite";
            this.idActiviteDataGridViewTextBoxColumn.Name = "idActiviteDataGridViewTextBoxColumn";
            this.idActiviteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idActiviteDataGridViewTextBoxColumn.Visible = false;
            this.idActiviteDataGridViewTextBoxColumn.Width = 76;
            // 
            // inscriptionsBindingSource
            // 
            this.inscriptionsBindingSource.DataMember = "inscriptions";
            this.inscriptionsBindingSource.DataSource = this.cda27_bd2DataSet;
            // 
            // cda27_bd2DataSet
            // 
            this.cda27_bd2DataSet.DataSetName = "cda27_bd2DataSet";
            this.cda27_bd2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(219, 323);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(263, 228);
            this.textBoxDescription.TabIndex = 57;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(3, 424);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(210, 25);
            this.lblDescription.TabIndex = 50;
            this.lblDescription.Text = "Description";
            // 
            // checkBoxPublic
            // 
            this.checkBoxPublic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPublic.AutoSize = true;
            this.checkBoxPublic.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPublic.Location = new System.Drawing.Point(676, 267);
            this.checkBoxPublic.Name = "checkBoxPublic";
            this.checkBoxPublic.Size = new System.Drawing.Size(295, 42);
            this.checkBoxPublic.TabIndex = 59;
            this.checkBoxPublic.Text = "Publié";
            this.checkBoxPublic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPublic.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DataSource = this.typeactiviteBindingSource;
            this.comboBox1.DisplayMember = "IntituleType";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(676, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 32);
            this.comboBox1.TabIndex = 60;
            this.comboBox1.ValueMember = "IdType";
            // 
            // typeactiviteBindingSource
            // 
            this.typeactiviteBindingSource.DataMember = "type_activite";
            this.typeactiviteBindingSource.DataSource = this.cda27_bd2DataSet2;
            // 
            // cda27_bd2DataSet2
            // 
            this.cda27_bd2DataSet2.DataSetName = "cda27_bd2DataSet";
            this.cda27_bd2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activitesBindingSource
            // 
            this.activitesBindingSource.DataMember = "activites";
            this.activitesBindingSource.DataSource = this.cda27_bd2DataSet1;
            // 
            // cda27_bd2DataSet1
            // 
            this.cda27_bd2DataSet1.DataSetName = "cda27_bd2DataSet";
            this.cda27_bd2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adherentsTableAdapter
            // 
            this.adherentsTableAdapter.ClearBeforeFill = true;
            // 
            // inscriptionsTableAdapter
            // 
            this.inscriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // adherents2BindingSource
            // 
            this.adherents2BindingSource.DataMember = "adherents2";
            this.adherents2BindingSource.DataSource = this.cda27_bd2DataSet;
            // 
            // adherents2TableAdapter
            // 
            this.adherents2TableAdapter.ClearBeforeFill = true;
            // 
            // type_activiteTableAdapter
            // 
            this.type_activiteTableAdapter.ClearBeforeFill = true;
            // 
            // activiteTableAdapter
            // 
            this.activiteTableAdapter.ClearBeforeFill = true;
            // 
            // activitesTableAdapter
            // 
            this.activitesTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxNomResp
            // 
            this.textBoxNomResp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNomResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomResp.Location = new System.Drawing.Point(676, 81);
            this.textBoxNomResp.Name = "textBoxNomResp";
            this.textBoxNomResp.Size = new System.Drawing.Size(295, 29);
            this.textBoxNomResp.TabIndex = 25;
            // 
            // lblNomResp
            // 
            this.lblNomResp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomResp.AutoSize = true;
            this.lblNomResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomResp.Location = new System.Drawing.Point(488, 71);
            this.lblNomResp.Name = "lblNomResp";
            this.lblNomResp.Size = new System.Drawing.Size(182, 50);
            this.lblNomResp.TabIndex = 8;
            this.lblNomResp.Text = "Nom du responsable :";
            // 
            // textBoxPrenomResp
            // 
            this.textBoxPrenomResp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrenomResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenomResp.Location = new System.Drawing.Point(219, 81);
            this.textBoxPrenomResp.Name = "textBoxPrenomResp";
            this.textBoxPrenomResp.Size = new System.Drawing.Size(263, 29);
            this.textBoxPrenomResp.TabIndex = 27;
            // 
            // lblPrenomResp
            // 
            this.lblPrenomResp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrenomResp.AutoSize = true;
            this.lblPrenomResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenomResp.Location = new System.Drawing.Point(3, 71);
            this.lblPrenomResp.Name = "lblPrenomResp";
            this.lblPrenomResp.Size = new System.Drawing.Size(210, 50);
            this.lblPrenomResp.TabIndex = 6;
            this.lblPrenomResp.Text = "Prénom du responsable :";
            // 
            // formDetailActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(996, 679);
            this.MinimumSize = new System.Drawing.Size(996, 679);
            this.Name = "formDetailActivite";
            this.Text = "Activité - Moto Club Millau Passion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formDetailActivite_FormClosing);
            this.Load += new System.EventHandler(this.formDetailActivite_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscrits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda27_bd2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeactiviteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda27_bd2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda27_bd2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherents2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private cda27_bd2DataSetTableAdapters.adherentsTableAdapter adherentsTableAdapter;
        internal System.Windows.Forms.TextBox textBoxTarifAdherent;
        internal System.Windows.Forms.TextBox textBoxTarifInvite;
        internal System.Windows.Forms.BindingSource inscriptionsBindingSource;
        internal cda27_bd2DataSet cda27_bd2DataSet;
        private System.Windows.Forms.Label lblDateLimite;
        private System.Windows.Forms.Label lblIntitule;
        internal System.Windows.Forms.TextBox textBoxIntituleAct;
        private System.Windows.Forms.Label lblTarifInvite;
        private System.Windows.Forms.Label lblTarifInvit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonAnnulerActivite;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblTypeAct;
        private System.Windows.Forms.Label lblDescription;
        internal cda27_bd2DataSetTableAdapters.inscriptionsTableAdapter inscriptionsTableAdapter;
        private System.Windows.Forms.BindingSource adherents2BindingSource;
        private cda27_bd2DataSetTableAdapters.adherents2TableAdapter adherents2TableAdapter;
        internal System.Windows.Forms.DateTimePicker dateTimePickerDateDebut;
        internal System.Windows.Forms.DateTimePicker dateTimePickerDateFin;
        internal System.Windows.Forms.DateTimePicker dateTimePickerDateLimite;
        internal System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intituléDeLactivitéDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeDébutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDinscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDinvitésDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAdherentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActiviteDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button buttonAjouterActivite;
        internal System.Windows.Forms.Button buttonModifierActivite;
        internal System.Windows.Forms.Button buttonSupprimerActivite;
        internal System.Windows.Forms.Label lblInscrits;
        internal System.Windows.Forms.DataGridView dataGridViewInscrits;
        private cda27_bd2DataSetTableAdapters.type_activiteTableAdapter type_activiteTableAdapter;
        private cda27_bd2DataSetTableAdapters.activiteTableAdapter activiteTableAdapter;
        internal System.Windows.Forms.CheckBox checkBoxPublic;
        private cda27_bd2DataSet cda27_bd2DataSet1;
        private System.Windows.Forms.BindingSource activitesBindingSource;
        private cda27_bd2DataSetTableAdapters.activitesTableAdapter activitesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private cda27_bd2DataSet cda27_bd2DataSet2;
        internal System.Windows.Forms.BindingSource typeactiviteBindingSource;
        internal System.Windows.Forms.TextBox textBoxNomResp;
        private System.Windows.Forms.Label lblPrenomResp;
        private System.Windows.Forms.Label lblNomResp;
        internal System.Windows.Forms.TextBox textBoxPrenomResp;
    }
}