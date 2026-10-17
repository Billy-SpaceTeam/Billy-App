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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.m_StatBarre = new System.Windows.Forms.StatusStrip();
            this.m_Menu = new System.Windows.Forms.MenuStrip();
            this.m_MenuConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.donnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_StatBarre
            // 
            this.m_StatBarre.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.m_StatBarre.Location = new System.Drawing.Point(0, 426);
            this.m_StatBarre.Name = "m_StatBarre";
            this.m_StatBarre.Size = new System.Drawing.Size(800, 24);
            this.m_StatBarre.TabIndex = 1;
            this.m_StatBarre.Text = "statusStrip1";
            // 
            // m_Menu
            // 
            this.m_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.m_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_MenuConnection,
            this.donnéesToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.modesToolStripMenuItem});
            this.m_Menu.Location = new System.Drawing.Point(0, 0);
            this.m_Menu.Name = "m_Menu";
            this.m_Menu.Size = new System.Drawing.Size(800, 28);
            this.m_Menu.TabIndex = 2;
            this.m_Menu.Text = "menuStrip1";
            // 
            // m_MenuConnection
            // 
            this.m_MenuConnection.Name = "m_MenuConnection";
            this.m_MenuConnection.Size = new System.Drawing.Size(98, 24);
            this.m_MenuConnection.Text = "Connection";
            this.m_MenuConnection.Click += new System.EventHandler(this.m_MenuConnection_Click);
            // 
            // donnéesToolStripMenuItem
            // 
            this.donnéesToolStripMenuItem.Name = "donnéesToolStripMenuItem";
            this.donnéesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.donnéesToolStripMenuItem.Text = "Données";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // modesToolStripMenuItem
            // 
            this.modesToolStripMenuItem.Name = "modesToolStripMenuItem";
            this.modesToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.modesToolStripMenuItem.Text = "Modes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_StatBarre);
            this.Controls.Add(this.m_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Billy";
            this.m_Menu.ResumeLayout(false);
            this.m_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip m_StatBarre;
        private System.Windows.Forms.MenuStrip m_Menu;
        private System.Windows.Forms.ToolStripMenuItem m_MenuConnection;
        private System.Windows.Forms.ToolStripMenuItem donnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modesToolStripMenuItem;
    }
}

