namespace MCMPWinForms
{
    partial class formDetailAdherent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDetailAdherent));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btAjouter = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btDesinscrireAdherent = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAnnulerDetailAdherent = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCylindree = new System.Windows.Forms.TextBox();
            this.textBoxAPropos = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxCodePostale = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.lblDateDeNaissance = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblCodePostale = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblApropos = new System.Windows.Forms.Label();
            this.lblCylindree = new System.Windows.Forms.Label();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.lblInscritsAuxActivites = new System.Windows.Forms.Label();
            this.dataGridViewFormDetailAdherentInscrits = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDateDeNaissance = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.lblDateAdhesion = new System.Windows.Forms.Label();
            this.dateTimePickerDateAdhesion = new System.Windows.Forms.DateTimePicker();
            this.lblOrganisateur = new System.Windows.Forms.Label();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.checkBoxOrganisateur = new System.Windows.Forms.CheckBox();
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
            this.inscriptionsTableAdapter = new MCMPWinForms.cda27_bd2DataSetTableAdapters.inscriptionsTableAdapter();
            this.adherentsTableAdapter = new MCMPWinForms.cda27_bd2DataSetTableAdapters.adherentsTableAdapter();
            this.adherentTableAdapter1 = new MCMPWinForms.cda27_bd2DataSetTableAdapters.adherentTableAdapter();
            this.adherentTableAdapter = new MCMPWinForms.cda27_bd2DataSetTableAdapters.adherentTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormDetailAdherentInscrits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda27_bd2DataSet)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.flowLayoutPanel1.Controls.Add(this.btAjouter);
            this.flowLayoutPanel1.Controls.Add(this.btModifier);
            this.flowLayoutPanel1.Controls.Add(this.btSupprimer);
            this.flowLayoutPanel1.Controls.Add(this.btDesinscrireAdherent);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(798, 68);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btAjouter
            // 
            this.btAjouter.BackColor = System.Drawing.Color.GhostWhite;
            this.btAjouter.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouter.Image = global::MCMPWinForms.Properties.Resources.output_onlinepngtools;
            this.btAjouter.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAjouter.Location = new System.Drawing.Point(0, 0);
            this.btAjouter.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(168, 64);
            this.btAjouter.TabIndex = 17;
            this.btAjouter.Text = "&Ajouter cet adhérent";
            this.btAjouter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAjouter.UseVisualStyleBackColor = false;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // btModifier
            // 
            this.btModifier.BackColor = System.Drawing.Color.GhostWhite;
            this.btModifier.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModifier.Image = global::MCMPWinForms.Properties.Resources.output_onlinepngtools__1_;
            this.btModifier.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btModifier.Location = new System.Drawing.Point(188, 0);
            this.btModifier.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(168, 64);
            this.btModifier.TabIndex = 14;
            this.btModifier.Text = "&Modifier cet adhérent";
            this.btModifier.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btModifier.UseVisualStyleBackColor = false;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.BackColor = System.Drawing.Color.GhostWhite;
            this.btSupprimer.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimer.Image = global::MCMPWinForms.Properties.Resources.output_onlinepngtools__2_;
            this.btSupprimer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSupprimer.Location = new System.Drawing.Point(376, 0);
            this.btSupprimer.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(168, 64);
            this.btSupprimer.TabIndex = 15;
            this.btSupprimer.Text = "&Supprimer cet adhérent";
            this.btSupprimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSupprimer.UseVisualStyleBackColor = false;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btDesinscrireAdherent
            // 
            this.btDesinscrireAdherent.BackColor = System.Drawing.Color.GhostWhite;
            this.btDesinscrireAdherent.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesinscrireAdherent.Image = global::MCMPWinForms.Properties.Resources.unsubscribenews_1092__1_;
            this.btDesinscrireAdherent.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDesinscrireAdherent.Location = new System.Drawing.Point(0, 64);
            this.btDesinscrireAdherent.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btDesinscrireAdherent.MaximumSize = new System.Drawing.Size(996, 679);
            this.btDesinscrireAdherent.MinimumSize = new System.Drawing.Size(996, 679);
            this.btDesinscrireAdherent.Name = "btDesinscrireAdherent";
            this.btDesinscrireAdherent.Size = new System.Drawing.Size(996, 679);
            this.btDesinscrireAdherent.TabIndex = 16;
            this.btDesinscrireAdherent.Text = "&Désinscrire de l\'activité";
            this.btDesinscrireAdherent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDesinscrireAdherent.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonAnnulerDetailAdherent);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(807, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(164, 68);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // buttonAnnulerDetailAdherent
            // 
            this.buttonAnnulerDetailAdherent.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonAnnulerDetailAdherent.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnulerDetailAdherent.Image = global::MCMPWinForms.Properties.Resources.output_onlinepngtools__7_;
            this.buttonAnnulerDetailAdherent.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAnnulerDetailAdherent.Location = new System.Drawing.Point(86, 0);
            this.buttonAnnulerDetailAdherent.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAnnulerDetailAdherent.Name = "buttonAnnulerDetailAdherent";
            this.buttonAnnulerDetailAdherent.Size = new System.Drawing.Size(78, 64);
            this.buttonAnnulerDetailAdherent.TabIndex = 18;
            this.buttonAnnulerDetailAdherent.Text = "&Annuler";
            this.buttonAnnulerDetailAdherent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAnnulerDetailAdherent.UseVisualStyleBackColor = false;
            this.buttonAnnulerDetailAdherent.Click += new System.EventHandler(this.buttonAnnulerDetailAdherent_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.84222F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.15778F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxCylindree, 4, 7);
            this.tableLayoutPanel3.Controls.Add(this.textBoxAPropos, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.textBoxLogin, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.textBoxTelephone, 4, 4);
            this.tableLayoutPanel3.Controls.Add(this.textBoxEmail, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.textBoxVille, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBoxCodePostale, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBoxAdresse, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBoxAge, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblDateDeNaissance, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxPrenom, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblPrenom, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblNom, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxNom, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblAdresse, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblAge, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblCodePostale, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblVille, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblEmail, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblLogin, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblActive, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblTelephone, 3, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblApropos, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.lblCylindree, 3, 7);
            this.tableLayoutPanel3.Controls.Add(this.lblAvatar, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.lblInscritsAuxActivites, 3, 8);
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewFormDetailAdherentInscrits, 4, 8);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerDateDeNaissance, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxAvatar, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.lblDateAdhesion, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerDateAdhesion, 4, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblOrganisateur, 3, 6);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxActive, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxOrganisateur, 4, 6);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(974, 554);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // textBoxCylindree
            // 
            this.textBoxCylindree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCylindree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCylindree.Location = new System.Drawing.Point(639, 308);
            this.textBoxCylindree.Name = "textBoxCylindree";
            this.textBoxCylindree.Size = new System.Drawing.Size(308, 29);
            this.textBoxCylindree.TabIndex = 49;
            // 
            // textBoxAPropos
            // 
            this.textBoxAPropos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAPropos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAPropos.Location = new System.Drawing.Point(211, 308);
            this.textBoxAPropos.Name = "textBoxAPropos";
            this.textBoxAPropos.Size = new System.Drawing.Size(240, 29);
            this.textBoxAPropos.TabIndex = 47;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(211, 222);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(240, 29);
            this.textBoxLogin.TabIndex = 39;
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelephone.Location = new System.Drawing.Point(639, 179);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(308, 29);
            this.textBoxTelephone.TabIndex = 37;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(211, 179);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(240, 29);
            this.textBoxEmail.TabIndex = 35;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVille.Location = new System.Drawing.Point(211, 136);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(240, 29);
            this.textBoxVille.TabIndex = 31;
            // 
            // textBoxCodePostale
            // 
            this.textBoxCodePostale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCodePostale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodePostale.Location = new System.Drawing.Point(639, 93);
            this.textBoxCodePostale.Name = "textBoxCodePostale";
            this.textBoxCodePostale.Size = new System.Drawing.Size(308, 29);
            this.textBoxCodePostale.TabIndex = 29;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdresse.Location = new System.Drawing.Point(211, 93);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(240, 29);
            this.textBoxAdresse.TabIndex = 27;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(639, 50);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(308, 29);
            this.textBoxAge.TabIndex = 25;
            // 
            // lblDateDeNaissance
            // 
            this.lblDateDeNaissance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateDeNaissance.AutoSize = true;
            this.lblDateDeNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDeNaissance.Location = new System.Drawing.Point(3, 43);
            this.lblDateDeNaissance.Name = "lblDateDeNaissance";
            this.lblDateDeNaissance.Size = new System.Drawing.Size(202, 43);
            this.lblDateDeNaissance.TabIndex = 6;
            this.lblDateDeNaissance.Text = "Date de naissance :";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenom.Location = new System.Drawing.Point(639, 7);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(308, 29);
            this.textBoxPrenom.TabIndex = 4;
            // 
            // lblPrenom
            // 
            this.lblPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(466, 9);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(167, 25);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(3, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(202, 25);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(211, 7);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(240, 29);
            this.textBoxNom.TabIndex = 1;
            // 
            // lblAdresse
            // 
            this.lblAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.Location = new System.Drawing.Point(3, 95);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(202, 25);
            this.lblAdresse.TabIndex = 7;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblAge
            // 
            this.lblAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(466, 52);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(167, 25);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "Age :";
            // 
            // lblCodePostale
            // 
            this.lblCodePostale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodePostale.AutoSize = true;
            this.lblCodePostale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodePostale.Location = new System.Drawing.Point(466, 95);
            this.lblCodePostale.Name = "lblCodePostale";
            this.lblCodePostale.Size = new System.Drawing.Size(167, 25);
            this.lblCodePostale.TabIndex = 5;
            this.lblCodePostale.Text = "Code postale :";
            // 
            // lblVille
            // 
            this.lblVille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(3, 138);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(202, 25);
            this.lblVille.TabIndex = 10;
            this.lblVille.Text = "Ville :";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(3, 181);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(202, 25);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Adresse e-mail :";
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(3, 224);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(202, 25);
            this.lblLogin.TabIndex = 13;
            this.lblLogin.Text = "Nom d\'utilisateur :";
            // 
            // lblActive
            // 
            this.lblActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.Location = new System.Drawing.Point(3, 267);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(202, 25);
            this.lblActive.TabIndex = 16;
            this.lblActive.Text = "Activé :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(466, 181);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(167, 25);
            this.lblTelephone.TabIndex = 15;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblApropos
            // 
            this.lblApropos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApropos.AutoSize = true;
            this.lblApropos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApropos.Location = new System.Drawing.Point(3, 310);
            this.lblApropos.Name = "lblApropos";
            this.lblApropos.Size = new System.Drawing.Size(202, 25);
            this.lblApropos.TabIndex = 18;
            this.lblApropos.Text = "A propos :";
            // 
            // lblCylindree
            // 
            this.lblCylindree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCylindree.AutoSize = true;
            this.lblCylindree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCylindree.Location = new System.Drawing.Point(466, 310);
            this.lblCylindree.Name = "lblCylindree";
            this.lblCylindree.Size = new System.Drawing.Size(167, 25);
            this.lblCylindree.TabIndex = 21;
            this.lblCylindree.Text = "Cylindrée :";
            // 
            // lblAvatar
            // 
            this.lblAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvatar.Location = new System.Drawing.Point(3, 436);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(202, 25);
            this.lblAvatar.TabIndex = 19;
            this.lblAvatar.Text = "Avatar :";
            // 
            // lblInscritsAuxActivites
            // 
            this.lblInscritsAuxActivites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInscritsAuxActivites.AutoSize = true;
            this.lblInscritsAuxActivites.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscritsAuxActivites.Location = new System.Drawing.Point(466, 424);
            this.lblInscritsAuxActivites.Name = "lblInscritsAuxActivites";
            this.lblInscritsAuxActivites.Size = new System.Drawing.Size(167, 50);
            this.lblInscritsAuxActivites.TabIndex = 50;
            this.lblInscritsAuxActivites.Text = "Inscrit aux activités :";
            // 
            // dataGridViewFormDetailAdherentInscrits
            // 
            this.dataGridViewFormDetailAdherentInscrits.AllowUserToAddRows = false;
            this.dataGridViewFormDetailAdherentInscrits.AllowUserToDeleteRows = false;
            this.dataGridViewFormDetailAdherentInscrits.AutoGenerateColumns = false;
            this.dataGridViewFormDetailAdherentInscrits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFormDetailAdherentInscrits.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFormDetailAdherentInscrits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormDetailAdherentInscrits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewFormDetailAdherentInscrits.DataSource = this.inscriptionsBindingSource;
            this.dataGridViewFormDetailAdherentInscrits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFormDetailAdherentInscrits.Location = new System.Drawing.Point(639, 347);
            this.dataGridViewFormDetailAdherentInscrits.Name = "dataGridViewFormDetailAdherentInscrits";
            this.dataGridViewFormDetailAdherentInscrits.ReadOnly = true;
            this.dataGridViewFormDetailAdherentInscrits.RowHeadersVisible = false;
            this.dataGridViewFormDetailAdherentInscrits.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFormDetailAdherentInscrits.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFormDetailAdherentInscrits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFormDetailAdherentInscrits.Size = new System.Drawing.Size(308, 204);
            this.dataGridViewFormDetailAdherentInscrits.StandardTab = true;
            this.dataGridViewFormDetailAdherentInscrits.TabIndex = 51;
            // 
            // dateTimePickerDateDeNaissance
            // 
            this.dateTimePickerDateDeNaissance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateDeNaissance.Location = new System.Drawing.Point(211, 54);
            this.dateTimePickerDateDeNaissance.Name = "dateTimePickerDateDeNaissance";
            this.dateTimePickerDateDeNaissance.Size = new System.Drawing.Size(240, 20);
            this.dateTimePickerDateDeNaissance.TabIndex = 53;
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(211, 347);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(240, 204);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAvatar.TabIndex = 54;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // lblDateAdhesion
            // 
            this.lblDateAdhesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateAdhesion.AutoSize = true;
            this.lblDateAdhesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAdhesion.Location = new System.Drawing.Point(466, 224);
            this.lblDateAdhesion.Name = "lblDateAdhesion";
            this.lblDateAdhesion.Size = new System.Drawing.Size(167, 25);
            this.lblDateAdhesion.TabIndex = 14;
            this.lblDateAdhesion.Text = "Adhésion :";
            // 
            // dateTimePickerDateAdhesion
            // 
            this.dateTimePickerDateAdhesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateAdhesion.Location = new System.Drawing.Point(639, 226);
            this.dateTimePickerDateAdhesion.Name = "dateTimePickerDateAdhesion";
            this.dateTimePickerDateAdhesion.Size = new System.Drawing.Size(308, 20);
            this.dateTimePickerDateAdhesion.TabIndex = 52;
            // 
            // lblOrganisateur
            // 
            this.lblOrganisateur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrganisateur.AutoSize = true;
            this.lblOrganisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganisateur.Location = new System.Drawing.Point(466, 267);
            this.lblOrganisateur.Name = "lblOrganisateur";
            this.lblOrganisateur.Size = new System.Drawing.Size(167, 25);
            this.lblOrganisateur.TabIndex = 9;
            this.lblOrganisateur.Text = "Organisateur :";
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActive.Location = new System.Drawing.Point(211, 265);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(240, 28);
            this.checkBoxActive.TabIndex = 55;
            this.checkBoxActive.Text = "Est activé";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // checkBoxOrganisateur
            // 
            this.checkBoxOrganisateur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxOrganisateur.AutoSize = true;
            this.checkBoxOrganisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOrganisateur.Location = new System.Drawing.Point(639, 265);
            this.checkBoxOrganisateur.Name = "checkBoxOrganisateur";
            this.checkBoxOrganisateur.Size = new System.Drawing.Size(308, 28);
            this.checkBoxOrganisateur.TabIndex = 56;
            this.checkBoxOrganisateur.Text = "Est un organisateur";
            this.checkBoxOrganisateur.UseVisualStyleBackColor = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Visible = false;
            this.nomDataGridViewTextBoxColumn.Width = 35;
            // 
            // prénomDataGridViewTextBoxColumn
            // 
            this.prénomDataGridViewTextBoxColumn.DataPropertyName = "Prénom";
            this.prénomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prénomDataGridViewTextBoxColumn.Name = "prénomDataGridViewTextBoxColumn";
            this.prénomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prénomDataGridViewTextBoxColumn.Visible = false;
            this.prénomDataGridViewTextBoxColumn.Width = 49;
            // 
            // intituléDeLactivitéDataGridViewTextBoxColumn
            // 
            this.intituléDeLactivitéDataGridViewTextBoxColumn.DataPropertyName = "Intitulé de l\'activité";
            this.intituléDeLactivitéDataGridViewTextBoxColumn.HeaderText = "Intitulé de l\'activité";
            this.intituléDeLactivitéDataGridViewTextBoxColumn.Name = "intituléDeLactivitéDataGridViewTextBoxColumn";
            this.intituléDeLactivitéDataGridViewTextBoxColumn.ReadOnly = true;
            this.intituléDeLactivitéDataGridViewTextBoxColumn.Width = 109;
            // 
            // dateDeDébutDataGridViewTextBoxColumn
            // 
            this.dateDeDébutDataGridViewTextBoxColumn.DataPropertyName = "Date de début";
            this.dateDeDébutDataGridViewTextBoxColumn.HeaderText = "Date de début";
            this.dateDeDébutDataGridViewTextBoxColumn.Name = "dateDeDébutDataGridViewTextBoxColumn";
            this.dateDeDébutDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDeDébutDataGridViewTextBoxColumn.Visible = false;
            this.dateDeDébutDataGridViewTextBoxColumn.Width = 92;
            // 
            // dateDeFinDataGridViewTextBoxColumn
            // 
            this.dateDeFinDataGridViewTextBoxColumn.DataPropertyName = "Date de fin";
            this.dateDeFinDataGridViewTextBoxColumn.HeaderText = "Date de fin";
            this.dateDeFinDataGridViewTextBoxColumn.Name = "dateDeFinDataGridViewTextBoxColumn";
            this.dateDeFinDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDeFinDataGridViewTextBoxColumn.Visible = false;
            this.dateDeFinDataGridViewTextBoxColumn.Width = 68;
            // 
            // dateDinscriptionDataGridViewTextBoxColumn
            // 
            this.dateDinscriptionDataGridViewTextBoxColumn.DataPropertyName = "Date d\'inscription";
            this.dateDinscriptionDataGridViewTextBoxColumn.HeaderText = "Date d\'inscription";
            this.dateDinscriptionDataGridViewTextBoxColumn.Name = "dateDinscriptionDataGridViewTextBoxColumn";
            this.dateDinscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDinscriptionDataGridViewTextBoxColumn.Width = 104;
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
            // inscriptionsTableAdapter
            // 
            this.inscriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // adherentsTableAdapter
            // 
            this.adherentsTableAdapter.ClearBeforeFill = true;
            // 
            // adherentTableAdapter1
            // 
            this.adherentTableAdapter1.ClearBeforeFill = true;
            // 
            // adherentTableAdapter
            // 
            this.adherentTableAdapter.ClearBeforeFill = true;
            // 
            // formDetailAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(996, 679);
            this.MinimumSize = new System.Drawing.Size(996, 679);
            this.Name = "formDetailAdherent";
            this.Text = "Adhérent - Moto Club Millau Passion";
            this.Load += new System.EventHandler(this.formDetailAdherent_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormDetailAdherentInscrits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda27_bd2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonAnnulerDetailAdherent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        internal System.Windows.Forms.TextBox textBoxCylindree;
        internal System.Windows.Forms.TextBox textBoxAPropos;
        internal System.Windows.Forms.TextBox textBoxLogin;
        internal System.Windows.Forms.TextBox textBoxTelephone;
        internal System.Windows.Forms.TextBox textBoxEmail;
        internal System.Windows.Forms.TextBox textBoxVille;
        internal System.Windows.Forms.TextBox textBoxCodePostale;
        internal System.Windows.Forms.TextBox textBoxAdresse;
        internal System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label lblDateDeNaissance;
        internal System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        internal System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblCodePostale;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblOrganisateur;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblApropos;
        private System.Windows.Forms.Label lblCylindree;
        private System.Windows.Forms.Label lblAvatar;
        internal System.Windows.Forms.DataGridView dataGridViewFormDetailAdherentInscrits;
        internal cda27_bd2DataSet cda27_bd2DataSet;
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
        internal System.Windows.Forms.BindingSource inscriptionsBindingSource;
        internal cda27_bd2DataSetTableAdapters.inscriptionsTableAdapter inscriptionsTableAdapter;
        internal System.Windows.Forms.DateTimePicker dateTimePickerDateAdhesion;
        internal System.Windows.Forms.DateTimePicker dateTimePickerDateDeNaissance;
        internal System.Windows.Forms.PictureBox pictureBoxAvatar;
        private cda27_bd2DataSetTableAdapters.adherentsTableAdapter adherentsTableAdapter;
        private cda27_bd2DataSetTableAdapters.adherentTableAdapter adherentTableAdapter1;
        internal System.Windows.Forms.CheckBox checkBoxActive;
        internal System.Windows.Forms.CheckBox checkBoxOrganisateur;
        internal System.Windows.Forms.Label lblDateAdhesion;
        internal System.Windows.Forms.Label lblInscritsAuxActivites;
        internal System.Windows.Forms.Button btModifier;
        internal System.Windows.Forms.Button btSupprimer;
        internal System.Windows.Forms.Button btDesinscrireAdherent;
        internal System.Windows.Forms.Button btAjouter;
        private cda27_bd2DataSetTableAdapters.adherentTableAdapter adherentTableAdapter;
    }
}