namespace Billy_App
{
    partial class Données
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.m_ChartPhotodiode = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.m_LblLiaisonSerie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_ChartGyroscope = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.m_LblGyro = new System.Windows.Forms.Label();
            this.m_LblGyroModele = new System.Windows.Forms.Label();
            this.m_LblPhotoModele = new System.Windows.Forms.Label();
            this.m_LblPhoto = new System.Windows.Forms.Label();
            this.m_LblPhotoConstructeur = new System.Windows.Forms.Label();
            this.m_LblGyroConstructeur = new System.Windows.Forms.Label();
            this.m_BpDonneesChartGyro = new System.Windows.Forms.Button();
            this.m_BpDonneesChartPhoto = new System.Windows.Forms.Button();
            this.m_TimerGraph = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartPhotodiode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartGyroscope)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ChartPhotodiode
            // 
            this.m_ChartPhotodiode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.m_ChartPhotodiode.ChartAreas.Add(chartArea3);
            this.m_ChartPhotodiode.Location = new System.Drawing.Point(421, 254);
            this.m_ChartPhotodiode.Margin = new System.Windows.Forms.Padding(2);
            this.m_ChartPhotodiode.Name = "m_ChartPhotodiode";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            this.m_ChartPhotodiode.Series.Add(series3);
            this.m_ChartPhotodiode.Size = new System.Drawing.Size(382, 258);
            this.m_ChartPhotodiode.TabIndex = 0;
            this.m_ChartPhotodiode.Text = "PhotoDiode";
            // 
            // m_LblLiaisonSerie
            // 
            this.m_LblLiaisonSerie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblLiaisonSerie.AutoSize = true;
            this.m_LblLiaisonSerie.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblLiaisonSerie.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblLiaisonSerie.Location = new System.Drawing.Point(34, 55);
            this.m_LblLiaisonSerie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblLiaisonSerie.Name = "m_LblLiaisonSerie";
            this.m_LblLiaisonSerie.Size = new System.Drawing.Size(93, 20);
            this.m_LblLiaisonSerie.TabIndex = 2;
            this.m_LblLiaisonSerie.Text = "Gyroscope";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "PhotoDiode";
            // 
            // m_ChartGyroscope
            // 
            this.m_ChartGyroscope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea4.Name = "ChartArea1";
            this.m_ChartGyroscope.ChartAreas.Add(chartArea4);
            this.m_ChartGyroscope.Location = new System.Drawing.Point(0, 254);
            this.m_ChartGyroscope.Margin = new System.Windows.Forms.Padding(2);
            this.m_ChartGyroscope.Name = "m_ChartGyroscope";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "Series1";
            this.m_ChartGyroscope.Series.Add(series4);
            this.m_ChartGyroscope.Size = new System.Drawing.Size(388, 258);
            this.m_ChartGyroscope.TabIndex = 4;
            this.m_ChartGyroscope.Text = "Gyroscope";
            // 
            // m_LblGyro
            // 
            this.m_LblGyro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblGyro.AutoSize = true;
            this.m_LblGyro.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblGyro.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblGyro.Location = new System.Drawing.Point(35, 135);
            this.m_LblGyro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblGyro.Name = "m_LblGyro";
            this.m_LblGyro.Size = new System.Drawing.Size(56, 16);
            this.m_LblGyro.TabIndex = 5;
            this.m_LblGyro.Text = "Valeur :";
            // 
            // m_LblGyroModele
            // 
            this.m_LblGyroModele.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblGyroModele.AutoSize = true;
            this.m_LblGyroModele.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblGyroModele.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblGyroModele.Location = new System.Drawing.Point(35, 94);
            this.m_LblGyroModele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblGyroModele.Name = "m_LblGyroModele";
            this.m_LblGyroModele.Size = new System.Drawing.Size(61, 16);
            this.m_LblGyroModele.TabIndex = 6;
            this.m_LblGyroModele.Text = "Modèle :";
            // 
            // m_LblPhotoModele
            // 
            this.m_LblPhotoModele.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblPhotoModele.AutoSize = true;
            this.m_LblPhotoModele.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblPhotoModele.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblPhotoModele.Location = new System.Drawing.Point(449, 94);
            this.m_LblPhotoModele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblPhotoModele.Name = "m_LblPhotoModele";
            this.m_LblPhotoModele.Size = new System.Drawing.Size(61, 16);
            this.m_LblPhotoModele.TabIndex = 7;
            this.m_LblPhotoModele.Text = "Modèle :";
            // 
            // m_LblPhoto
            // 
            this.m_LblPhoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblPhoto.AutoSize = true;
            this.m_LblPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblPhoto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblPhoto.Location = new System.Drawing.Point(449, 135);
            this.m_LblPhoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblPhoto.Name = "m_LblPhoto";
            this.m_LblPhoto.Size = new System.Drawing.Size(56, 16);
            this.m_LblPhoto.TabIndex = 8;
            this.m_LblPhoto.Text = "Valeur :";
            // 
            // m_LblPhotoConstructeur
            // 
            this.m_LblPhotoConstructeur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblPhotoConstructeur.AutoSize = true;
            this.m_LblPhotoConstructeur.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblPhotoConstructeur.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblPhotoConstructeur.Location = new System.Drawing.Point(449, 110);
            this.m_LblPhotoConstructeur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblPhotoConstructeur.Name = "m_LblPhotoConstructeur";
            this.m_LblPhotoConstructeur.Size = new System.Drawing.Size(98, 16);
            this.m_LblPhotoConstructeur.TabIndex = 9;
            this.m_LblPhotoConstructeur.Text = "Constructeur :";
            // 
            // m_LblGyroConstructeur
            // 
            this.m_LblGyroConstructeur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblGyroConstructeur.AutoSize = true;
            this.m_LblGyroConstructeur.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblGyroConstructeur.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblGyroConstructeur.Location = new System.Drawing.Point(35, 110);
            this.m_LblGyroConstructeur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblGyroConstructeur.Name = "m_LblGyroConstructeur";
            this.m_LblGyroConstructeur.Size = new System.Drawing.Size(98, 16);
            this.m_LblGyroConstructeur.TabIndex = 10;
            this.m_LblGyroConstructeur.Text = "Constructeur :";
            // 
            // m_BpDonneesChartGyro
            // 
            this.m_BpDonneesChartGyro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpDonneesChartGyro.Location = new System.Drawing.Point(38, 211);
            this.m_BpDonneesChartGyro.Margin = new System.Windows.Forms.Padding(2);
            this.m_BpDonneesChartGyro.Name = "m_BpDonneesChartGyro";
            this.m_BpDonneesChartGyro.Size = new System.Drawing.Size(89, 26);
            this.m_BpDonneesChartGyro.TabIndex = 11;
            this.m_BpDonneesChartGyro.Text = "Télécharger";
            this.m_BpDonneesChartGyro.UseVisualStyleBackColor = true;
            this.m_BpDonneesChartGyro.Click += new System.EventHandler(this.m_BpDonneesChartGyro_Click);
            // 
            // m_BpDonneesChartPhoto
            // 
            this.m_BpDonneesChartPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_BpDonneesChartPhoto.Location = new System.Drawing.Point(452, 211);
            this.m_BpDonneesChartPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.m_BpDonneesChartPhoto.Name = "m_BpDonneesChartPhoto";
            this.m_BpDonneesChartPhoto.Size = new System.Drawing.Size(89, 26);
            this.m_BpDonneesChartPhoto.TabIndex = 12;
            this.m_BpDonneesChartPhoto.Text = "Télécharger";
            this.m_BpDonneesChartPhoto.UseVisualStyleBackColor = true;
            this.m_BpDonneesChartPhoto.Click += new System.EventHandler(this.m_BpDonneesChartPhoto_Click);
            // 
            // m_TimerGraph
            // 
            this.m_TimerGraph.Enabled = true;
            this.m_TimerGraph.Tick += new System.EventHandler(this.m_TimerGraph_Tick);
            // 
            // Données
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_BpDonneesChartPhoto);
            this.Controls.Add(this.m_BpDonneesChartGyro);
            this.Controls.Add(this.m_LblGyroConstructeur);
            this.Controls.Add(this.m_LblPhotoConstructeur);
            this.Controls.Add(this.m_LblPhoto);
            this.Controls.Add(this.m_LblPhotoModele);
            this.Controls.Add(this.m_LblGyroModele);
            this.Controls.Add(this.m_LblGyro);
            this.Controls.Add(this.m_ChartGyroscope);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_LblLiaisonSerie);
            this.Controls.Add(this.m_ChartPhotodiode);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Données";
            this.Size = new System.Drawing.Size(802, 512);
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartPhotodiode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartGyroscope)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart m_ChartPhotodiode;
        private System.Windows.Forms.Label m_LblLiaisonSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart m_ChartGyroscope;
        private System.Windows.Forms.Label m_LblGyro;
        private System.Windows.Forms.Label m_LblGyroModele;
        private System.Windows.Forms.Label m_LblPhotoModele;
        private System.Windows.Forms.Label m_LblPhoto;
        private System.Windows.Forms.Label m_LblPhotoConstructeur;
        private System.Windows.Forms.Label m_LblGyroConstructeur;
        private System.Windows.Forms.Button m_BpDonneesChartGyro;
        private System.Windows.Forms.Button m_BpDonneesChartPhoto;
        private System.Windows.Forms.Timer m_TimerGraph;
    }
}
