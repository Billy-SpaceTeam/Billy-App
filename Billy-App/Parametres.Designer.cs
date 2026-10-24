namespace Billy_App
{
    partial class Parametres
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_LblApparence = new System.Windows.Forms.Label();
            this.m_BpThemes = new System.Windows.Forms.Button();
            this.m_LblMiseAJour = new System.Windows.Forms.Label();
            this.m_BpVerifMaj = new System.Windows.Forms.Button();
            this.m_BpMetAJour = new System.Windows.Forms.Button();
            this.m_LblImportFichier = new System.Windows.Forms.Label();
            this.m_LblInformations = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_LblStockage = new System.Windows.Forms.Label();
            this.m_TxtBoxStockTrans = new System.Windows.Forms.TextBox();
            this.m_LblRaccourcis = new System.Windows.Forms.Label();
            this.m_TxtBoxRaccourciIp = new System.Windows.Forms.TextBox();
            this.m_TxtBoxRaccourciMdp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.m_BpLienGithub = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_TxtBoxStockDonnees = new System.Windows.Forms.TextBox();
            this.m_TxtBoxStockExp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.m_LblMajStatus = new System.Windows.Forms.Label();
            this.m_LblVMajVersion = new System.Windows.Forms.Label();
            this.m_LblMajDate = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_LblApparence
            // 
            this.m_LblApparence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblApparence.AutoSize = true;
            this.m_LblApparence.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblApparence.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblApparence.Location = new System.Drawing.Point(35, 54);
            this.m_LblApparence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblApparence.Name = "m_LblApparence";
            this.m_LblApparence.Size = new System.Drawing.Size(118, 26);
            this.m_LblApparence.TabIndex = 2;
            this.m_LblApparence.Text = "Apparence";
            // 
            // m_BpThemes
            // 
            this.m_BpThemes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpThemes.Location = new System.Drawing.Point(39, 86);
            this.m_BpThemes.Margin = new System.Windows.Forms.Padding(2);
            this.m_BpThemes.Name = "m_BpThemes";
            this.m_BpThemes.Size = new System.Drawing.Size(90, 33);
            this.m_BpThemes.TabIndex = 3;
            this.m_BpThemes.Text = "Thème Sombre";
            this.m_BpThemes.UseVisualStyleBackColor = true;
            this.m_BpThemes.Click += new System.EventHandler(this.m_BpThemes_Click);
            // 
            // m_LblMiseAJour
            // 
            this.m_LblMiseAJour.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblMiseAJour.AutoSize = true;
            this.m_LblMiseAJour.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblMiseAJour.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblMiseAJour.Location = new System.Drawing.Point(35, 159);
            this.m_LblMiseAJour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblMiseAJour.Name = "m_LblMiseAJour";
            this.m_LblMiseAJour.Size = new System.Drawing.Size(126, 26);
            this.m_LblMiseAJour.TabIndex = 4;
            this.m_LblMiseAJour.Text = "Mise à Jour";
            // 
            // m_BpVerifMaj
            // 
            this.m_BpVerifMaj.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpVerifMaj.Location = new System.Drawing.Point(39, 192);
            this.m_BpVerifMaj.Margin = new System.Windows.Forms.Padding(2);
            this.m_BpVerifMaj.Name = "m_BpVerifMaj";
            this.m_BpVerifMaj.Size = new System.Drawing.Size(85, 33);
            this.m_BpVerifMaj.TabIndex = 5;
            this.m_BpVerifMaj.Text = "Vérifier";
            this.m_BpVerifMaj.UseVisualStyleBackColor = true;
            // 
            // m_BpMetAJour
            // 
            this.m_BpMetAJour.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpMetAJour.Location = new System.Drawing.Point(39, 239);
            this.m_BpMetAJour.Margin = new System.Windows.Forms.Padding(2);
            this.m_BpMetAJour.Name = "m_BpMetAJour";
            this.m_BpMetAJour.Size = new System.Drawing.Size(85, 33);
            this.m_BpMetAJour.TabIndex = 6;
            this.m_BpMetAJour.Text = "Mettre à jour";
            this.m_BpMetAJour.UseVisualStyleBackColor = true;
            // 
            // m_LblImportFichier
            // 
            this.m_LblImportFichier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_LblImportFichier.AutoSize = true;
            this.m_LblImportFichier.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblImportFichier.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblImportFichier.Location = new System.Drawing.Point(449, 368);
            this.m_LblImportFichier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblImportFichier.Name = "m_LblImportFichier";
            this.m_LblImportFichier.Size = new System.Drawing.Size(136, 16);
            this.m_LblImportFichier.TabIndex = 17;
            this.m_LblImportFichier.Text = "Version du logiciel :";
            // 
            // m_LblInformations
            // 
            this.m_LblInformations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_LblInformations.AutoSize = true;
            this.m_LblInformations.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblInformations.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblInformations.Location = new System.Drawing.Point(448, 305);
            this.m_LblInformations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblInformations.Name = "m_LblInformations";
            this.m_LblInformations.Size = new System.Drawing.Size(141, 26);
            this.m_LblInformations.TabIndex = 18;
            this.m_LblInformations.Text = "Informations";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 393);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date :";
            // 
            // m_LblStockage
            // 
            this.m_LblStockage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_LblStockage.AutoSize = true;
            this.m_LblStockage.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblStockage.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblStockage.Location = new System.Drawing.Point(448, 54);
            this.m_LblStockage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblStockage.Name = "m_LblStockage";
            this.m_LblStockage.Size = new System.Drawing.Size(104, 26);
            this.m_LblStockage.TabIndex = 20;
            this.m_LblStockage.Text = "Stockage";
            // 
            // m_TxtBoxStockTrans
            // 
            this.m_TxtBoxStockTrans.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_TxtBoxStockTrans.Location = new System.Drawing.Point(453, 122);
            this.m_TxtBoxStockTrans.Name = "m_TxtBoxStockTrans";
            this.m_TxtBoxStockTrans.Size = new System.Drawing.Size(235, 20);
            this.m_TxtBoxStockTrans.TabIndex = 21;
            // 
            // m_LblRaccourcis
            // 
            this.m_LblRaccourcis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblRaccourcis.AutoSize = true;
            this.m_LblRaccourcis.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblRaccourcis.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblRaccourcis.Location = new System.Drawing.Point(34, 330);
            this.m_LblRaccourcis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblRaccourcis.Name = "m_LblRaccourcis";
            this.m_LblRaccourcis.Size = new System.Drawing.Size(118, 26);
            this.m_LblRaccourcis.TabIndex = 22;
            this.m_LblRaccourcis.Text = "Raccourcis";
            // 
            // m_TxtBoxRaccourciIp
            // 
            this.m_TxtBoxRaccourciIp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_TxtBoxRaccourciIp.Location = new System.Drawing.Point(73, 372);
            this.m_TxtBoxRaccourciIp.Name = "m_TxtBoxRaccourciIp";
            this.m_TxtBoxRaccourciIp.Size = new System.Drawing.Size(176, 20);
            this.m_TxtBoxRaccourciIp.TabIndex = 23;
            // 
            // m_TxtBoxRaccourciMdp
            // 
            this.m_TxtBoxRaccourciMdp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_TxtBoxRaccourciMdp.Location = new System.Drawing.Point(149, 408);
            this.m_TxtBoxRaccourciMdp.Name = "m_TxtBoxRaccourciMdp";
            this.m_TxtBoxRaccourciMdp.Size = new System.Drawing.Size(100, 20);
            this.m_TxtBoxRaccourciMdp.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 372);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ip :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 408);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mot de Passe :";
            // 
            // m_BpLienGithub
            // 
            this.m_BpLienGithub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_BpLienGithub.Location = new System.Drawing.Point(453, 427);
            this.m_BpLienGithub.Margin = new System.Windows.Forms.Padding(2);
            this.m_BpLienGithub.Name = "m_BpLienGithub";
            this.m_BpLienGithub.Size = new System.Drawing.Size(136, 30);
            this.m_BpLienGithub.TabIndex = 27;
            this.m_BpLienGithub.Text = "Github du Projet";
            this.m_BpLienGithub.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(450, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Chemin des fichiers de transfert :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(450, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Chemin des données :";
            // 
            // m_TxtBoxStockDonnees
            // 
            this.m_TxtBoxStockDonnees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_TxtBoxStockDonnees.Location = new System.Drawing.Point(453, 178);
            this.m_TxtBoxStockDonnees.Name = "m_TxtBoxStockDonnees";
            this.m_TxtBoxStockDonnees.Size = new System.Drawing.Size(235, 20);
            this.m_TxtBoxStockDonnees.TabIndex = 30;
            // 
            // m_TxtBoxStockExp
            // 
            this.m_TxtBoxStockExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_TxtBoxStockExp.Location = new System.Drawing.Point(453, 238);
            this.m_TxtBoxStockExp.Name = "m_TxtBoxStockExp";
            this.m_TxtBoxStockExp.Size = new System.Drawing.Size(235, 20);
            this.m_TxtBoxStockExp.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(450, 219);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Chemin des exportations :";
            // 
            // m_LblMajStatus
            // 
            this.m_LblMajStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblMajStatus.AutoSize = true;
            this.m_LblMajStatus.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblMajStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblMajStatus.Location = new System.Drawing.Point(138, 200);
            this.m_LblMajStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblMajStatus.Name = "m_LblMajStatus";
            this.m_LblMajStatus.Size = new System.Drawing.Size(62, 16);
            this.m_LblMajStatus.TabIndex = 33;
            this.m_LblMajStatus.Text = "Status :";
            // 
            // m_LblVMajVersion
            // 
            this.m_LblVMajVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblVMajVersion.AutoSize = true;
            this.m_LblVMajVersion.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblVMajVersion.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblVMajVersion.Location = new System.Drawing.Point(138, 219);
            this.m_LblVMajVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblVMajVersion.Name = "m_LblVMajVersion";
            this.m_LblVMajVersion.Size = new System.Drawing.Size(73, 16);
            this.m_LblVMajVersion.TabIndex = 34;
            this.m_LblVMajVersion.Text = "Versions :";
            // 
            // m_LblMajDate
            // 
            this.m_LblMajDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblMajDate.AutoSize = true;
            this.m_LblMajDate.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblMajDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblMajDate.Location = new System.Drawing.Point(138, 238);
            this.m_LblMajDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblMajDate.Name = "m_LblMajDate";
            this.m_LblMajDate.Size = new System.Drawing.Size(49, 16);
            this.m_LblMajDate.TabIndex = 35;
            this.m_LblMajDate.Text = "Date :";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(449, 344);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(240, 16);
            this.label14.TabIndex = 36;
            this.label14.Text = "Developpée par Clément et Jérémie";
            // 
            // Parametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.m_LblMajDate);
            this.Controls.Add(this.m_LblVMajVersion);
            this.Controls.Add(this.m_LblMajStatus);
            this.Controls.Add(this.m_TxtBoxStockExp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.m_TxtBoxStockDonnees);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.m_BpLienGithub);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.m_TxtBoxRaccourciMdp);
            this.Controls.Add(this.m_TxtBoxRaccourciIp);
            this.Controls.Add(this.m_LblRaccourcis);
            this.Controls.Add(this.m_TxtBoxStockTrans);
            this.Controls.Add(this.m_LblStockage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_LblInformations);
            this.Controls.Add(this.m_LblImportFichier);
            this.Controls.Add(this.m_BpMetAJour);
            this.Controls.Add(this.m_BpVerifMaj);
            this.Controls.Add(this.m_LblMiseAJour);
            this.Controls.Add(this.m_BpThemes);
            this.Controls.Add(this.m_LblApparence);
            this.Name = "Parametres";
            this.Size = new System.Drawing.Size(802, 512);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LblApparence;
        private System.Windows.Forms.Button m_BpThemes;
        private System.Windows.Forms.Label m_LblMiseAJour;
        private System.Windows.Forms.Button m_BpVerifMaj;
        private System.Windows.Forms.Button m_BpMetAJour;
        private System.Windows.Forms.Label m_LblImportFichier;
        private System.Windows.Forms.Label m_LblInformations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label m_LblStockage;
        private System.Windows.Forms.TextBox m_TxtBoxStockTrans;
        private System.Windows.Forms.Label m_LblRaccourcis;
        private System.Windows.Forms.TextBox m_TxtBoxRaccourciIp;
        private System.Windows.Forms.TextBox m_TxtBoxRaccourciMdp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button m_BpLienGithub;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox m_TxtBoxStockDonnees;
        private System.Windows.Forms.TextBox m_TxtBoxStockExp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label m_LblMajStatus;
        private System.Windows.Forms.Label m_LblVMajVersion;
        private System.Windows.Forms.Label m_LblMajDate;
        private System.Windows.Forms.Label label14;
    }
}
