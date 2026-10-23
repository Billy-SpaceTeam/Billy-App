namespace Billy_App
{
    partial class Transfert
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
            this.m_LblTransfert = new System.Windows.Forms.Label();
            this.m_TxtBoxTransfert = new System.Windows.Forms.RichTextBox();
            this.m_BpTransfert = new System.Windows.Forms.Button();
            this.m_BoxTransfert = new System.Windows.Forms.ComboBox();
            this.m_BpImportFichier = new System.Windows.Forms.Button();
            this.m_PanelImportFichier = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // m_LblTransfert
            // 
            this.m_LblTransfert.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblTransfert.AutoSize = true;
            this.m_LblTransfert.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblTransfert.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblTransfert.Location = new System.Drawing.Point(35, 54);
            this.m_LblTransfert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblTransfert.Name = "m_LblTransfert";
            this.m_LblTransfert.Size = new System.Drawing.Size(227, 26);
            this.m_LblTransfert.TabIndex = 2;
            this.m_LblTransfert.Text = "Transfert Programme";
            // 
            // m_TxtBoxTransfert
            // 
            this.m_TxtBoxTransfert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_TxtBoxTransfert.EnableAutoDragDrop = true;
            this.m_TxtBoxTransfert.Location = new System.Drawing.Point(0, 290);
            this.m_TxtBoxTransfert.Margin = new System.Windows.Forms.Padding(2);
            this.m_TxtBoxTransfert.Name = "m_TxtBoxTransfert";
            this.m_TxtBoxTransfert.ReadOnly = true;
            this.m_TxtBoxTransfert.Size = new System.Drawing.Size(802, 222);
            this.m_TxtBoxTransfert.TabIndex = 9;
            this.m_TxtBoxTransfert.Text = "";
            // 
            // m_BpTransfert
            // 
            this.m_BpTransfert.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpTransfert.Location = new System.Drawing.Point(312, 181);
            this.m_BpTransfert.Margin = new System.Windows.Forms.Padding(2);
            this.m_BpTransfert.Name = "m_BpTransfert";
            this.m_BpTransfert.Size = new System.Drawing.Size(85, 33);
            this.m_BpTransfert.TabIndex = 10;
            this.m_BpTransfert.Text = "Transférer";
            this.m_BpTransfert.UseVisualStyleBackColor = true;
            this.m_BpTransfert.Click += new System.EventHandler(this.m_BpTransfert_Click);
            // 
            // m_BoxTransfert
            // 
            this.m_BoxTransfert.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BoxTransfert.FormattingEnabled = true;
            this.m_BoxTransfert.Location = new System.Drawing.Point(50, 107);
            this.m_BoxTransfert.Margin = new System.Windows.Forms.Padding(2);
            this.m_BoxTransfert.Name = "m_BoxTransfert";
            this.m_BoxTransfert.Size = new System.Drawing.Size(101, 21);
            this.m_BoxTransfert.TabIndex = 11;
            // 
            // m_BpImportFichier
            // 
            this.m_BpImportFichier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpImportFichier.Location = new System.Drawing.Point(76, 252);
            this.m_BpImportFichier.Margin = new System.Windows.Forms.Padding(2);
            this.m_BpImportFichier.Name = "m_BpImportFichier";
            this.m_BpImportFichier.Size = new System.Drawing.Size(120, 34);
            this.m_BpImportFichier.TabIndex = 12;
            this.m_BpImportFichier.Text = "Importer un fichier";
            this.m_BpImportFichier.UseVisualStyleBackColor = true;
            // 
            // m_PanelImportFichier
            // 
            this.m_PanelImportFichier.AllowDrop = true;
            this.m_PanelImportFichier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_PanelImportFichier.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.m_PanelImportFichier.Location = new System.Drawing.Point(50, 147);
            this.m_PanelImportFichier.Name = "m_PanelImportFichier";
            this.m_PanelImportFichier.Size = new System.Drawing.Size(200, 100);
            this.m_PanelImportFichier.TabIndex = 13;
            // 
            // Transfert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_PanelImportFichier);
            this.Controls.Add(this.m_BpImportFichier);
            this.Controls.Add(this.m_BoxTransfert);
            this.Controls.Add(this.m_BpTransfert);
            this.Controls.Add(this.m_TxtBoxTransfert);
            this.Controls.Add(this.m_LblTransfert);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Transfert";
            this.Size = new System.Drawing.Size(802, 512);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LblTransfert;
        private System.Windows.Forms.RichTextBox m_TxtBoxTransfert;
        private System.Windows.Forms.Button m_BpTransfert;
        private System.Windows.Forms.ComboBox m_BoxTransfert;
        private System.Windows.Forms.Button m_BpImportFichier;
        private System.Windows.Forms.Panel m_PanelImportFichier;
    }
}
