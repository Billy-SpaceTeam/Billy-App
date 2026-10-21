namespace Billy_App
{
    partial class Modes
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
            this.m_LblModes = new System.Windows.Forms.Label();
            this.m_BoxModes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // m_LblModes
            // 
            this.m_LblModes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblModes.AutoSize = true;
            this.m_LblModes.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblModes.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblModes.Location = new System.Drawing.Point(35, 54);
            this.m_LblModes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblModes.Name = "m_LblModes";
            this.m_LblModes.Size = new System.Drawing.Size(61, 20);
            this.m_LblModes.TabIndex = 2;
            this.m_LblModes.Text = "Modes";
            // 
            // m_BoxModes
            // 
            this.m_BoxModes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BoxModes.FormattingEnabled = true;
            this.m_BoxModes.Location = new System.Drawing.Point(24, 89);
            this.m_BoxModes.Margin = new System.Windows.Forms.Padding(2);
            this.m_BoxModes.Name = "m_BoxModes";
            this.m_BoxModes.Size = new System.Drawing.Size(86, 21);
            this.m_BoxModes.TabIndex = 4;
            this.m_BoxModes.SelectedIndexChanged += new System.EventHandler(this.m_BoxModes_SelectedIndexChanged);
            // 
            // Modes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_BoxModes);
            this.Controls.Add(this.m_LblModes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Modes";
            this.Size = new System.Drawing.Size(802, 512);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LblModes;
        private System.Windows.Forms.ComboBox m_BoxModes;
    }
}
