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
            this.SuspendLayout();
            // 
            // m_LblTransfert
            // 
            this.m_LblTransfert.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblTransfert.AutoSize = true;
            this.m_LblTransfert.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblTransfert.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblTransfert.Location = new System.Drawing.Point(47, 66);
            this.m_LblTransfert.Name = "m_LblTransfert";
            this.m_LblTransfert.Size = new System.Drawing.Size(227, 26);
            this.m_LblTransfert.TabIndex = 2;
            this.m_LblTransfert.Text = "Transfert Programme";
            // 
            // Transfert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_LblTransfert);
            this.Name = "Transfert";
            this.Size = new System.Drawing.Size(1070, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LblTransfert;
    }
}
