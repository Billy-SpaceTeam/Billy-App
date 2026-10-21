namespace Billy_App
{
    partial class Connexion
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
            this.m_BpDetecter = new System.Windows.Forms.Button();
            this.m_LblLiaisonSerie = new System.Windows.Forms.Label();
            this.m_LblLiaisonWifi = new System.Windows.Forms.Label();
            this.m_BoxPorts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_BoxBauds = new System.Windows.Forms.ComboBox();
            this.m_BpConnecter = new System.Windows.Forms.Button();
            this.m_TxtBoxConnection = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // m_BpDetecter
            // 
            this.m_BpDetecter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpDetecter.Location = new System.Drawing.Point(52, 119);
            this.m_BpDetecter.Name = "m_BpDetecter";
            this.m_BpDetecter.Size = new System.Drawing.Size(113, 41);
            this.m_BpDetecter.TabIndex = 0;
            this.m_BpDetecter.Text = "Détecter";
            this.m_BpDetecter.UseVisualStyleBackColor = true;
            this.m_BpDetecter.Click += new System.EventHandler(this.m_BpDetecter_Click);
            // 
            // m_LblLiaisonSerie
            // 
            this.m_LblLiaisonSerie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblLiaisonSerie.AutoSize = true;
            this.m_LblLiaisonSerie.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblLiaisonSerie.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblLiaisonSerie.Location = new System.Drawing.Point(47, 66);
            this.m_LblLiaisonSerie.Name = "m_LblLiaisonSerie";
            this.m_LblLiaisonSerie.Size = new System.Drawing.Size(142, 26);
            this.m_LblLiaisonSerie.TabIndex = 1;
            this.m_LblLiaisonSerie.Text = "Liaison Serie";
            // 
            // m_LblLiaisonWifi
            // 
            this.m_LblLiaisonWifi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_LblLiaisonWifi.AutoSize = true;
            this.m_LblLiaisonWifi.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblLiaisonWifi.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblLiaisonWifi.Location = new System.Drawing.Point(624, 66);
            this.m_LblLiaisonWifi.Name = "m_LblLiaisonWifi";
            this.m_LblLiaisonWifi.Size = new System.Drawing.Size(128, 26);
            this.m_LblLiaisonWifi.TabIndex = 2;
            this.m_LblLiaisonWifi.Text = "Liaison Wifi";
            // 
            // m_BoxPorts
            // 
            this.m_BoxPorts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BoxPorts.FormattingEnabled = true;
            this.m_BoxPorts.Location = new System.Drawing.Point(182, 128);
            this.m_BoxPorts.Name = "m_BoxPorts";
            this.m_BoxPorts.Size = new System.Drawing.Size(113, 24);
            this.m_BoxPorts.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ports";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bauds";
            // 
            // m_BoxBauds
            // 
            this.m_BoxBauds.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BoxBauds.FormattingEnabled = true;
            this.m_BoxBauds.Location = new System.Drawing.Point(182, 174);
            this.m_BoxBauds.Name = "m_BoxBauds";
            this.m_BoxBauds.Size = new System.Drawing.Size(113, 24);
            this.m_BoxBauds.TabIndex = 5;
            // 
            // m_BpConnecter
            // 
            this.m_BpConnecter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpConnecter.Location = new System.Drawing.Point(182, 215);
            this.m_BpConnecter.Name = "m_BpConnecter";
            this.m_BpConnecter.Size = new System.Drawing.Size(113, 41);
            this.m_BpConnecter.TabIndex = 7;
            this.m_BpConnecter.Text = "Se Connecter";
            this.m_BpConnecter.UseVisualStyleBackColor = true;
            this.m_BpConnecter.Click += new System.EventHandler(this.m_BpConnecter_Click);
            // 
            // m_TxtBoxConnection
            // 
            this.m_TxtBoxConnection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_TxtBoxConnection.EnableAutoDragDrop = true;
            this.m_TxtBoxConnection.Location = new System.Drawing.Point(0, 400);
            this.m_TxtBoxConnection.Name = "m_TxtBoxConnection";
            this.m_TxtBoxConnection.ReadOnly = true;
            this.m_TxtBoxConnection.Size = new System.Drawing.Size(1070, 230);
            this.m_TxtBoxConnection.TabIndex = 8;
            this.m_TxtBoxConnection.Text = "";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.m_LblLiaisonWifi);
            this.Controls.Add(this.m_TxtBoxConnection);
            this.Controls.Add(this.m_BpConnecter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_BoxBauds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_BoxPorts);
            this.Controls.Add(this.m_LblLiaisonSerie);
            this.Controls.Add(this.m_BpDetecter);
            this.Name = "Connexion";
            this.Size = new System.Drawing.Size(1070, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_BpDetecter;
        private System.Windows.Forms.Label m_LblLiaisonSerie;
        private System.Windows.Forms.Label m_LblLiaisonWifi;
        private System.Windows.Forms.ComboBox m_BoxPorts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox m_BoxBauds;
        private System.Windows.Forms.Button m_BpConnecter;
        private System.Windows.Forms.RichTextBox m_TxtBoxConnection;
    }
}
