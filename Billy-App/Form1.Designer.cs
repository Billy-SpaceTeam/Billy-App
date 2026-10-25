namespace Billy_App
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.m_StatBarre = new System.Windows.Forms.StatusStrip();
            this.m_LblStatusConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_TxtStatusConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_ProgressBarConnexion = new System.Windows.Forms.ToolStripProgressBar();
            this.m_LblStatusPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_TxtStatusPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_LblStatusBauds = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_TxtStatusBauds = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_LblStatusMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_TxtStatusMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_Menu = new System.Windows.Forms.MenuStrip();
            this.m_MenuConnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.m_MenuDonnées = new System.Windows.Forms.ToolStripMenuItem();
            this.m_MenuActions = new System.Windows.Forms.ToolStripMenuItem();
            this.m_MenuModes = new System.Windows.Forms.ToolStripMenuItem();
            this.m_MenuTransfert = new System.Windows.Forms.ToolStripMenuItem();
            this.m_MenuParametre = new System.Windows.Forms.ToolStripMenuItem();
            this.m_SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.m_PanelMenu = new System.Windows.Forms.Panel();
            this.m_StatBarre.SuspendLayout();
            this.m_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_StatBarre
            // 
            this.m_StatBarre.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.m_StatBarre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_LblStatusConnection,
            this.m_TxtStatusConnection,
            this.m_ProgressBarConnexion,
            this.m_LblStatusPort,
            this.m_TxtStatusPort,
            this.m_LblStatusBauds,
            this.m_TxtStatusBauds,
            this.m_LblStatusMode,
            this.m_TxtStatusMode});
            this.m_StatBarre.Location = new System.Drawing.Point(0, 450);
            this.m_StatBarre.Name = "m_StatBarre";
            this.m_StatBarre.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.m_StatBarre.Size = new System.Drawing.Size(789, 24);
            this.m_StatBarre.TabIndex = 1;
            this.m_StatBarre.Text = "Port: ";
            // 
            // m_LblStatusConnection
            // 
            this.m_LblStatusConnection.Name = "m_LblStatusConnection";
            this.m_LblStatusConnection.Size = new System.Drawing.Size(45, 19);
            this.m_LblStatusConnection.Text = "Status :";
            // 
            // m_TxtStatusConnection
            // 
            this.m_TxtStatusConnection.Name = "m_TxtStatusConnection";
            this.m_TxtStatusConnection.Size = new System.Drawing.Size(17, 19);
            this.m_TxtStatusConnection.Text = "xx";
            // 
            // m_ProgressBarConnexion
            // 
            this.m_ProgressBarConnexion.Name = "m_ProgressBarConnexion";
            this.m_ProgressBarConnexion.Size = new System.Drawing.Size(75, 18);
            // 
            // m_LblStatusPort
            // 
            this.m_LblStatusPort.Name = "m_LblStatusPort";
            this.m_LblStatusPort.Size = new System.Drawing.Size(35, 19);
            this.m_LblStatusPort.Text = "Port :";
            // 
            // m_TxtStatusPort
            // 
            this.m_TxtStatusPort.Name = "m_TxtStatusPort";
            this.m_TxtStatusPort.Size = new System.Drawing.Size(17, 19);
            this.m_TxtStatusPort.Text = "xx";
            // 
            // m_LblStatusBauds
            // 
            this.m_LblStatusBauds.Name = "m_LblStatusBauds";
            this.m_LblStatusBauds.Size = new System.Drawing.Size(45, 19);
            this.m_LblStatusBauds.Text = "Bauds :";
            // 
            // m_TxtStatusBauds
            // 
            this.m_TxtStatusBauds.Name = "m_TxtStatusBauds";
            this.m_TxtStatusBauds.Size = new System.Drawing.Size(17, 19);
            this.m_TxtStatusBauds.Text = "xx";
            // 
            // m_LblStatusMode
            // 
            this.m_LblStatusMode.Name = "m_LblStatusMode";
            this.m_LblStatusMode.Size = new System.Drawing.Size(47, 19);
            this.m_LblStatusMode.Text = "Mode : ";
            // 
            // m_TxtStatusMode
            // 
            this.m_TxtStatusMode.Name = "m_TxtStatusMode";
            this.m_TxtStatusMode.Size = new System.Drawing.Size(17, 19);
            this.m_TxtStatusMode.Text = "xx";
            // 
            // m_Menu
            // 
            this.m_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.m_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_MenuConnexion,
            this.m_MenuDonnées,
            this.m_MenuActions,
            this.m_MenuModes,
            this.m_MenuTransfert,
            this.m_MenuParametre});
            this.m_Menu.Location = new System.Drawing.Point(0, 0);
            this.m_Menu.Name = "m_Menu";
            this.m_Menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.m_Menu.Size = new System.Drawing.Size(789, 24);
            this.m_Menu.TabIndex = 2;
            this.m_Menu.Text = "menuStrip1";
            // 
            // m_MenuConnexion
            // 
            this.m_MenuConnexion.Name = "m_MenuConnexion";
            this.m_MenuConnexion.Size = new System.Drawing.Size(76, 20);
            this.m_MenuConnexion.Text = "Connexion";
            this.m_MenuConnexion.Click += new System.EventHandler(this.m_MenuConnection_Click);
            // 
            // m_MenuDonnées
            // 
            this.m_MenuDonnées.Name = "m_MenuDonnées";
            this.m_MenuDonnées.Size = new System.Drawing.Size(65, 20);
            this.m_MenuDonnées.Text = "Données";
            this.m_MenuDonnées.Click += new System.EventHandler(this.m_MenuDonnées_Click);
            // 
            // m_MenuActions
            // 
            this.m_MenuActions.Name = "m_MenuActions";
            this.m_MenuActions.Size = new System.Drawing.Size(78, 20);
            this.m_MenuActions.Text = "Actionneur";
            this.m_MenuActions.Click += new System.EventHandler(this.m_MenuActions_Click);
            // 
            // m_MenuModes
            // 
            this.m_MenuModes.Name = "m_MenuModes";
            this.m_MenuModes.Size = new System.Drawing.Size(55, 20);
            this.m_MenuModes.Text = "Modes";
            this.m_MenuModes.Click += new System.EventHandler(this.m_MenuModes_Click);
            // 
            // m_MenuTransfert
            // 
            this.m_MenuTransfert.Name = "m_MenuTransfert";
            this.m_MenuTransfert.Size = new System.Drawing.Size(65, 20);
            this.m_MenuTransfert.Text = "Transfert";
            this.m_MenuTransfert.Click += new System.EventHandler(this.m_MenuTransfert_Click);
            // 
            // m_MenuParametre
            // 
            this.m_MenuParametre.Name = "m_MenuParametre";
            this.m_MenuParametre.Size = new System.Drawing.Size(78, 20);
            this.m_MenuParametre.Text = "Paramètres";
            this.m_MenuParametre.Click += new System.EventHandler(this.m_MenuParametre_Click);
            // 
            // m_SerialPort
            // 
            this.m_SerialPort.DtrEnable = true;
            this.m_SerialPort.RtsEnable = true;
            // 
            // m_PanelMenu
            // 
            this.m_PanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_PanelMenu.Location = new System.Drawing.Point(0, 24);
            this.m_PanelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.m_PanelMenu.Name = "m_PanelMenu";
            this.m_PanelMenu.Size = new System.Drawing.Size(789, 426);
            this.m_PanelMenu.TabIndex = 3;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 474);
            this.Controls.Add(this.m_PanelMenu);
            this.Controls.Add(this.m_StatBarre);
            this.Controls.Add(this.m_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "Form1";
            this.Text = "Billy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.m_StatBarre.ResumeLayout(false);
            this.m_StatBarre.PerformLayout();
            this.m_Menu.ResumeLayout(false);
            this.m_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip m_StatBarre;
        private System.Windows.Forms.MenuStrip m_Menu;
        private System.Windows.Forms.ToolStripMenuItem m_MenuConnexion;
        private System.Windows.Forms.ToolStripMenuItem m_MenuDonnées;
        private System.Windows.Forms.ToolStripMenuItem m_MenuActions;
        private System.Windows.Forms.ToolStripMenuItem m_MenuModes;
        private System.IO.Ports.SerialPort m_SerialPort;
        private System.Windows.Forms.ToolStripStatusLabel m_LblStatusConnection;
        private System.Windows.Forms.ToolStripStatusLabel m_TxtStatusConnection;
        private System.Windows.Forms.Panel m_PanelMenu;
        private System.Windows.Forms.ToolStripProgressBar m_ProgressBarConnexion;
        private System.Windows.Forms.ToolStripStatusLabel m_LblStatusPort;
        private System.Windows.Forms.ToolStripStatusLabel m_TxtStatusPort;
        private System.Windows.Forms.ToolStripMenuItem m_MenuTransfert;
        private System.Windows.Forms.ToolStripStatusLabel m_LblStatusBauds;
        private System.Windows.Forms.ToolStripStatusLabel m_TxtStatusBauds;
        private System.Windows.Forms.ToolStripStatusLabel m_LblStatusMode;
        private System.Windows.Forms.ToolStripStatusLabel m_TxtStatusMode;
        private System.Windows.Forms.ToolStripMenuItem m_MenuParametre;
    }
}

