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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.m_ChartPhotodiode = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.m_LblLiaisonSerie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_ChartGyroscope = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.m_LblGyro_x = new System.Windows.Forms.Label();
            this.m_LblGyroModele = new System.Windows.Forms.Label();
            this.m_LblPhotoModele = new System.Windows.Forms.Label();
            this.m_LblPhoto = new System.Windows.Forms.Label();
            this.m_LblPhotoConstructeur = new System.Windows.Forms.Label();
            this.m_LblGyroConstructeur = new System.Windows.Forms.Label();
            this.m_BpDonneesChartGyro = new System.Windows.Forms.Button();
            this.m_BpDonneesChartPhoto = new System.Windows.Forms.Button();
            this.m_TimerGraph = new System.Windows.Forms.Timer(this.components);
            this.m_BpDonneesPlay = new System.Windows.Forms.Button();
            this.m_LblGyro_y = new System.Windows.Forms.Label();
            this.m_LblGyro_z = new System.Windows.Forms.Label();
            this.m_LblAccel_z = new System.Windows.Forms.Label();
            this.m_LblAccel_y = new System.Windows.Forms.Label();
            this.m_LblAccel_x = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartPhotodiode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartGyroscope)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ChartPhotodiode
            // 
            this.m_ChartPhotodiode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.Name = "ChartArea1";
            this.m_ChartPhotodiode.ChartAreas.Add(chartArea7);
            this.m_ChartPhotodiode.Location = new System.Drawing.Point(551, 313);
            this.m_ChartPhotodiode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_ChartPhotodiode.Name = "m_ChartPhotodiode";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Name = "Series1";
            this.m_ChartPhotodiode.Series.Add(series7);
            this.m_ChartPhotodiode.Size = new System.Drawing.Size(520, 318);
            this.m_ChartPhotodiode.TabIndex = 0;
            this.m_ChartPhotodiode.Text = "PhotoDiode";
            // 
            // m_LblLiaisonSerie
            // 
            this.m_LblLiaisonSerie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblLiaisonSerie.AutoSize = true;
            this.m_LblLiaisonSerie.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblLiaisonSerie.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblLiaisonSerie.Location = new System.Drawing.Point(45, 68);
            this.m_LblLiaisonSerie.Name = "m_LblLiaisonSerie";
            this.m_LblLiaisonSerie.Size = new System.Drawing.Size(117, 26);
            this.m_LblLiaisonSerie.TabIndex = 2;
            this.m_LblLiaisonSerie.Text = "Gyroscope";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "PhotoDiode";
            // 
            // m_ChartGyroscope
            // 
            this.m_ChartGyroscope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea8.Name = "ChartArea1";
            this.m_ChartGyroscope.ChartAreas.Add(chartArea8);
            this.m_ChartGyroscope.Location = new System.Drawing.Point(0, 313);
            this.m_ChartGyroscope.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_ChartGyroscope.Name = "m_ChartGyroscope";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Name = "Series1";
            this.m_ChartGyroscope.Series.Add(series8);
            this.m_ChartGyroscope.Size = new System.Drawing.Size(517, 318);
            this.m_ChartGyroscope.TabIndex = 4;
            this.m_ChartGyroscope.Text = "Gyroscope";
            // 
            // m_LblGyro_x
            // 
            this.m_LblGyro_x.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblGyro_x.AutoSize = true;
            this.m_LblGyro_x.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblGyro_x.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblGyro_x.Location = new System.Drawing.Point(47, 166);
            this.m_LblGyro_x.Name = "m_LblGyro_x";
            this.m_LblGyro_x.Size = new System.Drawing.Size(30, 19);
            this.m_LblGyro_x.TabIndex = 5;
            this.m_LblGyro_x.Text = "x :";
            // 
            // m_LblGyroModele
            // 
            this.m_LblGyroModele.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblGyroModele.AutoSize = true;
            this.m_LblGyroModele.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblGyroModele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_LblGyroModele.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblGyroModele.Location = new System.Drawing.Point(47, 103);
            this.m_LblGyroModele.Name = "m_LblGyroModele";
            this.m_LblGyroModele.Size = new System.Drawing.Size(74, 19);
            this.m_LblGyroModele.TabIndex = 6;
            this.m_LblGyroModele.Text = "Modèle :";
            this.m_LblGyroModele.Click += new System.EventHandler(this.m_LblGyroModele_Click);
            // 
            // m_LblPhotoModele
            // 
            this.m_LblPhotoModele.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblPhotoModele.AutoSize = true;
            this.m_LblPhotoModele.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblPhotoModele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_LblPhotoModele.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblPhotoModele.Location = new System.Drawing.Point(598, 103);
            this.m_LblPhotoModele.Name = "m_LblPhotoModele";
            this.m_LblPhotoModele.Size = new System.Drawing.Size(74, 19);
            this.m_LblPhotoModele.TabIndex = 7;
            this.m_LblPhotoModele.Text = "Modèle :";
            this.m_LblPhotoModele.Click += new System.EventHandler(this.m_LblPhotoModele_Click);
            // 
            // m_LblPhoto
            // 
            this.m_LblPhoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblPhoto.AutoSize = true;
            this.m_LblPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblPhoto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblPhoto.Location = new System.Drawing.Point(599, 166);
            this.m_LblPhoto.Name = "m_LblPhoto";
            this.m_LblPhoto.Size = new System.Drawing.Size(67, 19);
            this.m_LblPhoto.TabIndex = 8;
            this.m_LblPhoto.Text = "Valeur :";
            // 
            // m_LblPhotoConstructeur
            // 
            this.m_LblPhotoConstructeur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblPhotoConstructeur.AutoSize = true;
            this.m_LblPhotoConstructeur.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblPhotoConstructeur.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblPhotoConstructeur.Location = new System.Drawing.Point(598, 122);
            this.m_LblPhotoConstructeur.Name = "m_LblPhotoConstructeur";
            this.m_LblPhotoConstructeur.Size = new System.Drawing.Size(118, 19);
            this.m_LblPhotoConstructeur.TabIndex = 9;
            this.m_LblPhotoConstructeur.Text = "Constructeur :";
            // 
            // m_LblGyroConstructeur
            // 
            this.m_LblGyroConstructeur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblGyroConstructeur.AutoSize = true;
            this.m_LblGyroConstructeur.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblGyroConstructeur.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblGyroConstructeur.Location = new System.Drawing.Point(47, 122);
            this.m_LblGyroConstructeur.Name = "m_LblGyroConstructeur";
            this.m_LblGyroConstructeur.Size = new System.Drawing.Size(118, 19);
            this.m_LblGyroConstructeur.TabIndex = 10;
            this.m_LblGyroConstructeur.Text = "Constructeur :";
            // 
            // m_BpDonneesChartGyro
            // 
            this.m_BpDonneesChartGyro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpDonneesChartGyro.Location = new System.Drawing.Point(51, 249);
            this.m_BpDonneesChartGyro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_BpDonneesChartGyro.Name = "m_BpDonneesChartGyro";
            this.m_BpDonneesChartGyro.Size = new System.Drawing.Size(119, 32);
            this.m_BpDonneesChartGyro.TabIndex = 11;
            this.m_BpDonneesChartGyro.Text = "Exporter";
            this.m_BpDonneesChartGyro.UseVisualStyleBackColor = true;
            this.m_BpDonneesChartGyro.Click += new System.EventHandler(this.m_BpDonneesChartGyro_Click);
            // 
            // m_BpDonneesChartPhoto
            // 
            this.m_BpDonneesChartPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_BpDonneesChartPhoto.Location = new System.Drawing.Point(603, 249);
            this.m_BpDonneesChartPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_BpDonneesChartPhoto.Name = "m_BpDonneesChartPhoto";
            this.m_BpDonneesChartPhoto.Size = new System.Drawing.Size(119, 32);
            this.m_BpDonneesChartPhoto.TabIndex = 12;
            this.m_BpDonneesChartPhoto.Text = "Exporter";
            this.m_BpDonneesChartPhoto.UseVisualStyleBackColor = true;
            this.m_BpDonneesChartPhoto.Click += new System.EventHandler(this.m_BpDonneesChartPhoto_Click);
            // 
            // m_TimerGraph
            // 
            this.m_TimerGraph.Enabled = true;
            this.m_TimerGraph.Tick += new System.EventHandler(this.m_TimerGraph_Tick);
            // 
            // m_BpDonneesPlay
            // 
            this.m_BpDonneesPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_BpDonneesPlay.Location = new System.Drawing.Point(451, 249);
            this.m_BpDonneesPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_BpDonneesPlay.Name = "m_BpDonneesPlay";
            this.m_BpDonneesPlay.Size = new System.Drawing.Size(66, 32);
            this.m_BpDonneesPlay.TabIndex = 13;
            this.m_BpDonneesPlay.Text = "Pause";
            this.m_BpDonneesPlay.UseVisualStyleBackColor = true;
            this.m_BpDonneesPlay.Click += new System.EventHandler(this.m_BpPlay_Click);
            // 
            // m_LblGyro_y
            // 
            this.m_LblGyro_y.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblGyro_y.AutoSize = true;
            this.m_LblGyro_y.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblGyro_y.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblGyro_y.Location = new System.Drawing.Point(47, 185);
            this.m_LblGyro_y.Name = "m_LblGyro_y";
            this.m_LblGyro_y.Size = new System.Drawing.Size(30, 19);
            this.m_LblGyro_y.TabIndex = 14;
            this.m_LblGyro_y.Text = "y :";
            // 
            // m_LblGyro_z
            // 
            this.m_LblGyro_z.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblGyro_z.AutoSize = true;
            this.m_LblGyro_z.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblGyro_z.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblGyro_z.Location = new System.Drawing.Point(46, 204);
            this.m_LblGyro_z.Name = "m_LblGyro_z";
            this.m_LblGyro_z.Size = new System.Drawing.Size(30, 19);
            this.m_LblGyro_z.TabIndex = 15;
            this.m_LblGyro_z.Text = "z :";
            // 
            // m_LblAccel_z
            // 
            this.m_LblAccel_z.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblAccel_z.AutoSize = true;
            this.m_LblAccel_z.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblAccel_z.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblAccel_z.Location = new System.Drawing.Point(276, 204);
            this.m_LblAccel_z.Name = "m_LblAccel_z";
            this.m_LblAccel_z.Size = new System.Drawing.Size(30, 19);
            this.m_LblAccel_z.TabIndex = 18;
            this.m_LblAccel_z.Text = "z :";
            // 
            // m_LblAccel_y
            // 
            this.m_LblAccel_y.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblAccel_y.AutoSize = true;
            this.m_LblAccel_y.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblAccel_y.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblAccel_y.Location = new System.Drawing.Point(277, 185);
            this.m_LblAccel_y.Name = "m_LblAccel_y";
            this.m_LblAccel_y.Size = new System.Drawing.Size(30, 19);
            this.m_LblAccel_y.TabIndex = 17;
            this.m_LblAccel_y.Text = "y :";
            // 
            // m_LblAccel_x
            // 
            this.m_LblAccel_x.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblAccel_x.AutoSize = true;
            this.m_LblAccel_x.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblAccel_x.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblAccel_x.Location = new System.Drawing.Point(277, 166);
            this.m_LblAccel_x.Name = "m_LblAccel_x";
            this.m_LblAccel_x.Size = new System.Drawing.Size(30, 19);
            this.m_LblAccel_x.TabIndex = 16;
            this.m_LblAccel_x.Text = "x :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Gyroscope :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Accelerometre";
            // 
            // Données
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_LblAccel_z);
            this.Controls.Add(this.m_LblAccel_y);
            this.Controls.Add(this.m_LblAccel_x);
            this.Controls.Add(this.m_LblGyro_z);
            this.Controls.Add(this.m_LblGyro_y);
            this.Controls.Add(this.m_BpDonneesPlay);
            this.Controls.Add(this.m_BpDonneesChartPhoto);
            this.Controls.Add(this.m_BpDonneesChartGyro);
            this.Controls.Add(this.m_LblGyroConstructeur);
            this.Controls.Add(this.m_LblPhotoConstructeur);
            this.Controls.Add(this.m_LblPhoto);
            this.Controls.Add(this.m_LblPhotoModele);
            this.Controls.Add(this.m_LblGyroModele);
            this.Controls.Add(this.m_LblGyro_x);
            this.Controls.Add(this.m_ChartGyroscope);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_LblLiaisonSerie);
            this.Controls.Add(this.m_ChartPhotodiode);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Données";
            this.Size = new System.Drawing.Size(1069, 630);
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
        private System.Windows.Forms.Label m_LblGyro_x;
        private System.Windows.Forms.Label m_LblGyroModele;
        private System.Windows.Forms.Label m_LblPhotoModele;
        private System.Windows.Forms.Label m_LblPhoto;
        private System.Windows.Forms.Label m_LblPhotoConstructeur;
        private System.Windows.Forms.Label m_LblGyroConstructeur;
        private System.Windows.Forms.Button m_BpDonneesChartGyro;
        private System.Windows.Forms.Button m_BpDonneesChartPhoto;
        private System.Windows.Forms.Timer m_TimerGraph;
        private System.Windows.Forms.Button m_BpDonneesPlay;
        private System.Windows.Forms.Label m_LblGyro_y;
        private System.Windows.Forms.Label m_LblGyro_z;
        private System.Windows.Forms.Label m_LblAccel_z;
        private System.Windows.Forms.Label m_LblAccel_y;
        private System.Windows.Forms.Label m_LblAccel_x;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
