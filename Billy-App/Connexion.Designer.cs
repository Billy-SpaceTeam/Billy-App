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
            this.m_BpDetecterSerialPort = new System.Windows.Forms.Button();
            this.m_LblLiaisonSerie = new System.Windows.Forms.Label();
            this.m_LblLiaisonWifi = new System.Windows.Forms.Label();
            this.m_BoxPorts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_BoxBauds = new System.Windows.Forms.ComboBox();
            this.m_BpConnecterSerialPort = new System.Windows.Forms.Button();
            this.m_TxtBoxConnection = new System.Windows.Forms.RichTextBox();
            this.m_BpDetecterWifi = new System.Windows.Forms.Button();
            this.m_BpConnecterWifi = new System.Windows.Forms.Button();
            this.m_TxtBoxConnecterMdp = new System.Windows.Forms.TextBox();
            this.m_TxtBoxConnecterIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_BpDetecterSerialPort
            // 
            this.m_BpDetecterSerialPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpDetecterSerialPort.Location = new System.Drawing.Point(39, 97);
            this.m_BpDetecterSerialPort.Margin = new System.Windows.Forms.Padding(2);
            this.m_BpDetecterSerialPort.Name = "m_BpDetecterSerialPort";
            this.m_BpDetecterSerialPort.Size = new System.Drawing.Size(85, 33);
            this.m_BpDetecterSerialPort.TabIndex = 0;
            this.m_BpDetecterSerialPort.Text = "Détecter";
            this.m_BpDetecterSerialPort.UseVisualStyleBackColor = true;
            this.m_BpDetecterSerialPort.Click += new System.EventHandler(this.m_BpDetecter_Click);
            // 
            // m_LblLiaisonSerie
            // 
            this.m_LblLiaisonSerie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblLiaisonSerie.AutoSize = true;
            this.m_LblLiaisonSerie.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblLiaisonSerie.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblLiaisonSerie.Location = new System.Drawing.Point(35, 54);
            this.m_LblLiaisonSerie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblLiaisonSerie.Name = "m_LblLiaisonSerie";
            this.m_LblLiaisonSerie.Size = new System.Drawing.Size(114, 20);
            this.m_LblLiaisonSerie.TabIndex = 1;
            this.m_LblLiaisonSerie.Text = "Liaison Serie";
            // 
            // m_LblLiaisonWifi
            // 
            this.m_LblLiaisonWifi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_LblLiaisonWifi.AutoSize = true;
            this.m_LblLiaisonWifi.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblLiaisonWifi.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblLiaisonWifi.Location = new System.Drawing.Point(468, 54);
            this.m_LblLiaisonWifi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblLiaisonWifi.Name = "m_LblLiaisonWifi";
            this.m_LblLiaisonWifi.Size = new System.Drawing.Size(106, 20);
            this.m_LblLiaisonWifi.TabIndex = 2;
            this.m_LblLiaisonWifi.Text = "Liaison Wifi";
            // 
            // m_BoxPorts
            // 
            this.m_BoxPorts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BoxPorts.FormattingEnabled = true;
            this.m_BoxPorts.Location = new System.Drawing.Point(136, 104);
            this.m_BoxPorts.Margin = new System.Windows.Forms.Padding(2);
            this.m_BoxPorts.Name = "m_BoxPorts";
            this.m_BoxPorts.Size = new System.Drawing.Size(86, 21);
            this.m_BoxPorts.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ports";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bauds";
            // 
            // m_BoxBauds
            // 
            this.m_BoxBauds.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BoxBauds.FormattingEnabled = true;
            this.m_BoxBauds.Location = new System.Drawing.Point(136, 141);
            this.m_BoxBauds.Margin = new System.Windows.Forms.Padding(2);
            this.m_BoxBauds.Name = "m_BoxBauds";
            this.m_BoxBauds.Size = new System.Drawing.Size(86, 21);
            this.m_BoxBauds.TabIndex = 5;
            // 
            // m_BpConnecterSerialPort
            // 
            this.m_BpConnecterSerialPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpConnecterSerialPort.Location = new System.Drawing.Point(136, 175);
            this.m_BpConnecterSerialPort.Margin = new System.Windows.Forms.Padding(2);
            this.m_BpConnecterSerialPort.Name = "m_BpConnecterSerialPort";
            this.m_BpConnecterSerialPort.Size = new System.Drawing.Size(85, 33);
            this.m_BpConnecterSerialPort.TabIndex = 7;
            this.m_BpConnecterSerialPort.Text = "Se Connecter";
            this.m_BpConnecterSerialPort.UseVisualStyleBackColor = true;
            this.m_BpConnecterSerialPort.Click += new System.EventHandler(this.m_BpConnecter_Click);
            // 
            // m_TxtBoxConnection
            // 
            this.m_TxtBoxConnection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_TxtBoxConnection.EnableAutoDragDrop = true;
            this.m_TxtBoxConnection.Location = new System.Drawing.Point(0, 312);
            this.m_TxtBoxConnection.Margin = new System.Windows.Forms.Padding(2);
            this.m_TxtBoxConnection.Name = "m_TxtBoxConnection";
            this.m_TxtBoxConnection.ReadOnly = true;
            this.m_TxtBoxConnection.Size = new System.Drawing.Size(802, 200);
            this.m_TxtBoxConnection.TabIndex = 8;
            this.m_TxtBoxConnection.Text = "";
            // 
            // m_BpDetecterWifi
            // 
            this.m_BpDetecterWifi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_BpDetecterWifi.Location = new System.Drawing.Point(472, 97);
            this.m_BpDetecterWifi.Margin = new System.Windows.Forms.Padding(2);
            this.m_BpDetecterWifi.Name = "m_BpDetecterWifi";
            this.m_BpDetecterWifi.Size = new System.Drawing.Size(85, 33);
            this.m_BpDetecterWifi.TabIndex = 9;
            this.m_BpDetecterWifi.Text = "Détecter";
            this.m_BpDetecterWifi.UseVisualStyleBackColor = true;
            this.m_BpDetecterWifi.Click += new System.EventHandler(this.m_BpDetecterWifi_Click);
            // 
            // m_BpConnecterWifi
            // 
            this.m_BpConnecterWifi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_BpConnecterWifi.Location = new System.Drawing.Point(586, 175);
            this.m_BpConnecterWifi.Margin = new System.Windows.Forms.Padding(2);
            this.m_BpConnecterWifi.Name = "m_BpConnecterWifi";
            this.m_BpConnecterWifi.Size = new System.Drawing.Size(85, 33);
            this.m_BpConnecterWifi.TabIndex = 11;
            this.m_BpConnecterWifi.Text = "Se Connecter";
            this.m_BpConnecterWifi.UseVisualStyleBackColor = true;
            this.m_BpConnecterWifi.Click += new System.EventHandler(this.m_BpConnecterWifi_Click);
            // 
            // m_TxtBoxConnecterMdp
            // 
            this.m_TxtBoxConnecterMdp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_TxtBoxConnecterMdp.Location = new System.Drawing.Point(571, 141);
            this.m_TxtBoxConnecterMdp.Name = "m_TxtBoxConnecterMdp";
            this.m_TxtBoxConnecterMdp.Size = new System.Drawing.Size(100, 20);
            this.m_TxtBoxConnecterMdp.TabIndex = 12;
            // 
            // m_TxtBoxConnecterIp
            // 
            this.m_TxtBoxConnecterIp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_TxtBoxConnecterIp.Location = new System.Drawing.Point(571, 104);
            this.m_TxtBoxConnecterIp.Name = "m_TxtBoxConnecterIp";
            this.m_TxtBoxConnecterIp.Size = new System.Drawing.Size(100, 20);
            this.m_TxtBoxConnecterIp.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(676, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ip";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(676, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mdp";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_TxtBoxConnecterIp);
            this.Controls.Add(this.m_TxtBoxConnecterMdp);
            this.Controls.Add(this.m_BpConnecterWifi);
            this.Controls.Add(this.m_BpDetecterWifi);
            this.Controls.Add(this.m_LblLiaisonWifi);
            this.Controls.Add(this.m_TxtBoxConnection);
            this.Controls.Add(this.m_BpConnecterSerialPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_BoxBauds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_BoxPorts);
            this.Controls.Add(this.m_LblLiaisonSerie);
            this.Controls.Add(this.m_BpDetecterSerialPort);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Connexion";
            this.Size = new System.Drawing.Size(802, 512);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_BpDetecterSerialPort;
        private System.Windows.Forms.Label m_LblLiaisonSerie;
        private System.Windows.Forms.Label m_LblLiaisonWifi;
        private System.Windows.Forms.ComboBox m_BoxPorts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox m_BoxBauds;
        private System.Windows.Forms.Button m_BpConnecterSerialPort;
        private System.Windows.Forms.RichTextBox m_TxtBoxConnection;
        private System.Windows.Forms.Button m_BpDetecterWifi;
        private System.Windows.Forms.Button m_BpConnecterWifi;
        private System.Windows.Forms.TextBox m_TxtBoxConnecterMdp;
        private System.Windows.Forms.TextBox m_TxtBoxConnecterIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
