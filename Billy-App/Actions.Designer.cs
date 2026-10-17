namespace Billy_App
{
    partial class Actions
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
            this.m_LblLiaisonSerie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_LblLiaisonSerie
            // 
            this.m_LblLiaisonSerie.AutoSize = true;
            this.m_LblLiaisonSerie.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblLiaisonSerie.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblLiaisonSerie.Location = new System.Drawing.Point(45, 68);
            this.m_LblLiaisonSerie.Name = "m_LblLiaisonSerie";
            this.m_LblLiaisonSerie.Size = new System.Drawing.Size(196, 26);
            this.m_LblLiaisonSerie.TabIndex = 3;
            this.m_LblLiaisonSerie.Text = "Moteur à Réaction";
            // 
            // Actions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_LblLiaisonSerie);
            this.Name = "Actions";
            this.Size = new System.Drawing.Size(1070, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LblLiaisonSerie;
    }
}
