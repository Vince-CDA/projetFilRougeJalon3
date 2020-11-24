﻿namespace MCMPWinForms
{
    partial class FormInscriptionActivite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscriptionActivite));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFermerActivite = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateDebutAct = new System.Windows.Forms.Label();
            this.lblIntituleAct = new System.Windows.Forms.Label();
            this.lblDateDeFinAct = new System.Windows.Forms.Label();
            this.lblTarifAdherent = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDateLimite = new System.Windows.Forms.Label();
            this.lblTarifInvite = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIntituleAct = new System.Windows.Forms.TextBox();
            this.textBoxTarifAdherent = new System.Windows.Forms.TextBox();
            this.textBoxTarifInvite = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxNombreInvite = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateDebutAct = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateLimiteAct = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateFinAct = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCC = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCylindrée = new System.Windows.Forms.TextBox();
            this.buttonInscrireAdherentActivite = new System.Windows.Forms.Button();
            this.inscriptionTableAdapter1 = new MCMPWinForms.cda27_bd2DataSetTableAdapters.inscriptionTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonFermerActivite, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonInscrireAdherentActivite, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.87707F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.06147F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.06147F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(677, 407);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonFermerActivite
            // 
            this.buttonFermerActivite.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonFermerActivite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFermerActivite.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFermerActivite.Image = global::MCMPWinForms.Properties.Resources.output_onlinepngtools__7_;
            this.buttonFermerActivite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFermerActivite.Location = new System.Drawing.Point(0, 353);
            this.buttonFermerActivite.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFermerActivite.Name = "buttonFermerActivite";
            this.buttonFermerActivite.Size = new System.Drawing.Size(677, 54);
            this.buttonFermerActivite.TabIndex = 18;
            this.buttonFermerActivite.Text = "&Fermer";
            this.buttonFermerActivite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFermerActivite.UseVisualStyleBackColor = false;
            this.buttonFermerActivite.Click += new System.EventHandler(this.buttonFermerActivite_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel2.Controls.Add(this.lblDateDebutAct, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblIntituleAct, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDateDeFinAct, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTarifAdherent, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblDescription, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblDateLimite, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTarifInvite, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxIntituleAct, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTarifAdherent, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTarifInvite, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDescription, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNombreInvite, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerDateDebutAct, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerDateLimiteAct, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerDateFinAct, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 3, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(671, 294);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // lblDateDebutAct
            // 
            this.lblDateDebutAct.AutoSize = true;
            this.lblDateDebutAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateDebutAct.Location = new System.Drawing.Point(343, 0);
            this.lblDateDebutAct.Name = "lblDateDebutAct";
            this.lblDateDebutAct.Size = new System.Drawing.Size(118, 36);
            this.lblDateDebutAct.TabIndex = 1;
            this.lblDateDebutAct.Text = "Date de début :";
            this.lblDateDebutAct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIntituleAct
            // 
            this.lblIntituleAct.AutoSize = true;
            this.lblIntituleAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIntituleAct.Location = new System.Drawing.Point(3, 0);
            this.lblIntituleAct.Name = "lblIntituleAct";
            this.lblIntituleAct.Size = new System.Drawing.Size(164, 36);
            this.lblIntituleAct.TabIndex = 0;
            this.lblIntituleAct.Text = "Intitulé de l\'activité :";
            this.lblIntituleAct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateDeFinAct
            // 
            this.lblDateDeFinAct.AutoSize = true;
            this.lblDateDeFinAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateDeFinAct.Location = new System.Drawing.Point(3, 36);
            this.lblDateDeFinAct.Name = "lblDateDeFinAct";
            this.lblDateDeFinAct.Size = new System.Drawing.Size(164, 36);
            this.lblDateDeFinAct.TabIndex = 2;
            this.lblDateDeFinAct.Text = "Date de fin :";
            this.lblDateDeFinAct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTarifAdherent
            // 
            this.lblTarifAdherent.AutoSize = true;
            this.lblTarifAdherent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTarifAdherent.Location = new System.Drawing.Point(3, 72);
            this.lblTarifAdherent.Name = "lblTarifAdherent";
            this.lblTarifAdherent.Size = new System.Drawing.Size(164, 36);
            this.lblTarifAdherent.TabIndex = 4;
            this.lblTarifAdherent.Text = "Tarif adhérent :";
            this.lblTarifAdherent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(3, 108);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(164, 150);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description :";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateLimite
            // 
            this.lblDateLimite.AutoSize = true;
            this.lblDateLimite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateLimite.Location = new System.Drawing.Point(343, 36);
            this.lblDateLimite.Name = "lblDateLimite";
            this.lblDateLimite.Size = new System.Drawing.Size(118, 36);
            this.lblDateLimite.TabIndex = 3;
            this.lblDateLimite.Text = "Date limite :";
            this.lblDateLimite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTarifInvite
            // 
            this.lblTarifInvite.AutoSize = true;
            this.lblTarifInvite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTarifInvite.Location = new System.Drawing.Point(343, 72);
            this.lblTarifInvite.Name = "lblTarifInvite";
            this.lblTarifInvite.Size = new System.Drawing.Size(118, 36);
            this.lblTarifInvite.TabIndex = 5;
            this.lblTarifInvite.Text = "Tarif invité :";
            this.lblTarifInvite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 36);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nombre d\'invité(s) :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxIntituleAct
            // 
            this.textBoxIntituleAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIntituleAct.Enabled = false;
            this.textBoxIntituleAct.Location = new System.Drawing.Point(173, 8);
            this.textBoxIntituleAct.Name = "textBoxIntituleAct";
            this.textBoxIntituleAct.Size = new System.Drawing.Size(164, 20);
            this.textBoxIntituleAct.TabIndex = 8;
            // 
            // textBoxTarifAdherent
            // 
            this.textBoxTarifAdherent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTarifAdherent.Enabled = false;
            this.textBoxTarifAdherent.Location = new System.Drawing.Point(173, 80);
            this.textBoxTarifAdherent.Name = "textBoxTarifAdherent";
            this.textBoxTarifAdherent.Size = new System.Drawing.Size(164, 20);
            this.textBoxTarifAdherent.TabIndex = 9;
            // 
            // textBoxTarifInvite
            // 
            this.textBoxTarifInvite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTarifInvite.Enabled = false;
            this.textBoxTarifInvite.Location = new System.Drawing.Point(467, 80);
            this.textBoxTarifInvite.Name = "textBoxTarifInvite";
            this.textBoxTarifInvite.Size = new System.Drawing.Size(201, 20);
            this.textBoxTarifInvite.TabIndex = 10;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Enabled = false;
            this.textBoxDescription.Location = new System.Drawing.Point(173, 111);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(164, 144);
            this.textBoxDescription.TabIndex = 11;
            // 
            // textBoxNombreInvite
            // 
            this.textBoxNombreInvite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombreInvite.Location = new System.Drawing.Point(173, 266);
            this.textBoxNombreInvite.Name = "textBoxNombreInvite";
            this.textBoxNombreInvite.Size = new System.Drawing.Size(164, 20);
            this.textBoxNombreInvite.TabIndex = 12;
            // 
            // dateTimePickerDateDebutAct
            // 
            this.dateTimePickerDateDebutAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateDebutAct.Enabled = false;
            this.dateTimePickerDateDebutAct.Location = new System.Drawing.Point(467, 8);
            this.dateTimePickerDateDebutAct.Name = "dateTimePickerDateDebutAct";
            this.dateTimePickerDateDebutAct.Size = new System.Drawing.Size(201, 20);
            this.dateTimePickerDateDebutAct.TabIndex = 13;
            // 
            // dateTimePickerDateLimiteAct
            // 
            this.dateTimePickerDateLimiteAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateLimiteAct.Enabled = false;
            this.dateTimePickerDateLimiteAct.Location = new System.Drawing.Point(467, 44);
            this.dateTimePickerDateLimiteAct.Name = "dateTimePickerDateLimiteAct";
            this.dateTimePickerDateLimiteAct.Size = new System.Drawing.Size(201, 20);
            this.dateTimePickerDateLimiteAct.TabIndex = 14;
            // 
            // dateTimePickerDateFinAct
            // 
            this.dateTimePickerDateFinAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateFinAct.Enabled = false;
            this.dateTimePickerDateFinAct.Location = new System.Drawing.Point(173, 44);
            this.dateTimePickerDateFinAct.Name = "dateTimePickerDateFinAct";
            this.dateTimePickerDateFinAct.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerDateFinAct.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblLogin);
            this.flowLayoutPanel1.Controls.Add(this.lblPrenom);
            this.flowLayoutPanel1.Controls.Add(this.lblNom);
            this.flowLayoutPanel1.Controls.Add(this.lblCC);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(343, 111);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(118, 144);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(3, 8);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(52, 18);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(3, 34);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(69, 18);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(3, 60);
            this.lblNom.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(49, 18);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCC.Location = new System.Drawing.Point(3, 86);
            this.lblCC.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(77, 18);
            this.lblCC.TabIndex = 2;
            this.lblCC.Text = "Cylindrée :";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.textBoxLogin);
            this.flowLayoutPanel2.Controls.Add(this.textBoxPrenom);
            this.flowLayoutPanel2.Controls.Add(this.textBoxNom);
            this.flowLayoutPanel2.Controls.Add(this.textBoxCylindrée);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(467, 111);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(201, 144);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Enabled = false;
            this.textBoxLogin.Location = new System.Drawing.Point(3, 5);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(198, 20);
            this.textBoxLogin.TabIndex = 3;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Enabled = false;
            this.textBoxPrenom.Location = new System.Drawing.Point(3, 33);
            this.textBoxPrenom.Margin = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(198, 20);
            this.textBoxPrenom.TabIndex = 0;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Enabled = false;
            this.textBoxNom.Location = new System.Drawing.Point(3, 61);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(198, 20);
            this.textBoxNom.TabIndex = 1;
            // 
            // textBoxCylindrée
            // 
            this.textBoxCylindrée.Enabled = false;
            this.textBoxCylindrée.Location = new System.Drawing.Point(3, 89);
            this.textBoxCylindrée.Margin = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.textBoxCylindrée.Name = "textBoxCylindrée";
            this.textBoxCylindrée.Size = new System.Drawing.Size(198, 20);
            this.textBoxCylindrée.TabIndex = 2;
            // 
            // buttonInscrireAdherentActivite
            // 
            this.buttonInscrireAdherentActivite.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonInscrireAdherentActivite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInscrireAdherentActivite.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInscrireAdherentActivite.Image = global::MCMPWinForms.Properties.Resources.inscrire_act;
            this.buttonInscrireAdherentActivite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInscrireAdherentActivite.Location = new System.Drawing.Point(0, 300);
            this.buttonInscrireAdherentActivite.Margin = new System.Windows.Forms.Padding(0);
            this.buttonInscrireAdherentActivite.Name = "buttonInscrireAdherentActivite";
            this.buttonInscrireAdherentActivite.Size = new System.Drawing.Size(677, 53);
            this.buttonInscrireAdherentActivite.TabIndex = 16;
            this.buttonInscrireAdherentActivite.Text = "&Inscrire l\'adhérent";
            this.buttonInscrireAdherentActivite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInscrireAdherentActivite.UseVisualStyleBackColor = false;
            this.buttonInscrireAdherentActivite.Click += new System.EventHandler(this.buttonInscrireAdherentActivite_Click);
            // 
            // inscriptionTableAdapter1
            // 
            this.inscriptionTableAdapter1.ClearBeforeFill = true;
            // 
            // FormInscriptionActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInscriptionActivite";
            this.Text = "Inscription à l\'activité - MCMP";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonInscrireAdherentActivite;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDateDebutAct;
        private System.Windows.Forms.Label lblIntituleAct;
        private System.Windows.Forms.Label lblDateDeFinAct;
        private System.Windows.Forms.Label lblDateLimite;
        private System.Windows.Forms.Label lblTarifAdherent;
        private System.Windows.Forms.Label lblTarifInvite;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox textBoxIntituleAct;
        internal System.Windows.Forms.TextBox textBoxTarifAdherent;
        internal System.Windows.Forms.TextBox textBoxTarifInvite;
        internal System.Windows.Forms.TextBox textBoxDescription;
        internal System.Windows.Forms.DateTimePicker dateTimePickerDateDebutAct;
        internal System.Windows.Forms.DateTimePicker dateTimePickerDateLimiteAct;
        internal System.Windows.Forms.DateTimePicker dateTimePickerDateFinAct;
        internal System.Windows.Forms.TextBox textBoxNombreInvite;
        private cda27_bd2DataSetTableAdapters.inscriptionTableAdapter inscriptionTableAdapter1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        internal System.Windows.Forms.TextBox textBoxPrenom;
        internal System.Windows.Forms.TextBox textBoxNom;
        internal System.Windows.Forms.TextBox textBoxCylindrée;
        internal System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonFermerActivite;
    }
}