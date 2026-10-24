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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.m_LblApparence.Size = new System.Drawing.Size(94, 20);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mise à Jour";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(39, 221);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Vérifier";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(39, 281);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Mettre à jour";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Parametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
