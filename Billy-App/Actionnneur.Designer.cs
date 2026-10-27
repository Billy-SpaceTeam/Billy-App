namespace Billy_App
{
    partial class Actionnneur
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.m_LblLiaisonSerie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_LblMoteurConstructeur = new System.Windows.Forms.Label();
            this.m_LblServoConstructeur = new System.Windows.Forms.Label();
            this.m_LblServo = new System.Windows.Forms.Label();
            this.m_LblServoModele = new System.Windows.Forms.Label();
            this.m_LblMoteurModele = new System.Windows.Forms.Label();
            this.m_LblMoteur_x = new System.Windows.Forms.Label();
            this.m_TimerGraph = new System.Windows.Forms.Timer(this.components);
            this.m_ChartMoteur = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.m_ChartServo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.m_BpExporterMoteur = new System.Windows.Forms.Button();
            this.m_BpExporterServo = new System.Windows.Forms.Button();
            this.m_BpActionneurPlay = new System.Windows.Forms.Button();
            this.m_LblMoteur_y = new System.Windows.Forms.Label();
            this.m_LblMoteur_z = new System.Windows.Forms.Label();
            this.m_CheckMoteur_x = new System.Windows.Forms.CheckBox();
            this.m_CheckMoteur_y = new System.Windows.Forms.CheckBox();
            this.m_CheckMoteur_z = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartMoteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartServo)).BeginInit();
            this.SuspendLayout();
            // 
            // m_LblLiaisonSerie
            // 
            this.m_LblLiaisonSerie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblLiaisonSerie.AutoSize = true;
            this.m_LblLiaisonSerie.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblLiaisonSerie.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblLiaisonSerie.Location = new System.Drawing.Point(45, 68);
            this.m_LblLiaisonSerie.Name = "m_LblLiaisonSerie";
            this.m_LblLiaisonSerie.Size = new System.Drawing.Size(196, 26);
            this.m_LblLiaisonSerie.TabIndex = 3;
            this.m_LblLiaisonSerie.Text = "Moteur à Réaction";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "ServoMoteur";
            // 
            // m_LblMoteurConstructeur
            // 
            this.m_LblMoteurConstructeur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblMoteurConstructeur.AutoSize = true;
            this.m_LblMoteurConstructeur.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblMoteurConstructeur.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblMoteurConstructeur.Location = new System.Drawing.Point(47, 129);
            this.m_LblMoteurConstructeur.Name = "m_LblMoteurConstructeur";
            this.m_LblMoteurConstructeur.Size = new System.Drawing.Size(118, 19);
            this.m_LblMoteurConstructeur.TabIndex = 16;
            this.m_LblMoteurConstructeur.Text = "Constructeur :";
            // 
            // m_LblServoConstructeur
            // 
            this.m_LblServoConstructeur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblServoConstructeur.AutoSize = true;
            this.m_LblServoConstructeur.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblServoConstructeur.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblServoConstructeur.Location = new System.Drawing.Point(599, 129);
            this.m_LblServoConstructeur.Name = "m_LblServoConstructeur";
            this.m_LblServoConstructeur.Size = new System.Drawing.Size(118, 19);
            this.m_LblServoConstructeur.TabIndex = 15;
            this.m_LblServoConstructeur.Text = "Constructeur :";
            // 
            // m_LblServo
            // 
            this.m_LblServo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblServo.AutoSize = true;
            this.m_LblServo.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblServo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblServo.Location = new System.Drawing.Point(599, 160);
            this.m_LblServo.Name = "m_LblServo";
            this.m_LblServo.Size = new System.Drawing.Size(67, 19);
            this.m_LblServo.TabIndex = 14;
            this.m_LblServo.Text = "Valeur :";
            // 
            // m_LblServoModele
            // 
            this.m_LblServoModele.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblServoModele.AutoSize = true;
            this.m_LblServoModele.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblServoModele.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblServoModele.Location = new System.Drawing.Point(599, 110);
            this.m_LblServoModele.Name = "m_LblServoModele";
            this.m_LblServoModele.Size = new System.Drawing.Size(74, 19);
            this.m_LblServoModele.TabIndex = 13;
            this.m_LblServoModele.Text = "Modèle :";
            // 
            // m_LblMoteurModele
            // 
            this.m_LblMoteurModele.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblMoteurModele.AutoSize = true;
            this.m_LblMoteurModele.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblMoteurModele.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblMoteurModele.Location = new System.Drawing.Point(47, 110);
            this.m_LblMoteurModele.Name = "m_LblMoteurModele";
            this.m_LblMoteurModele.Size = new System.Drawing.Size(74, 19);
            this.m_LblMoteurModele.TabIndex = 12;
            this.m_LblMoteurModele.Text = "Modèle :";
            // 
            // m_LblMoteur_x
            // 
            this.m_LblMoteur_x.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblMoteur_x.AutoSize = true;
            this.m_LblMoteur_x.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblMoteur_x.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblMoteur_x.Location = new System.Drawing.Point(75, 157);
            this.m_LblMoteur_x.Name = "m_LblMoteur_x";
            this.m_LblMoteur_x.Size = new System.Drawing.Size(30, 19);
            this.m_LblMoteur_x.TabIndex = 11;
            this.m_LblMoteur_x.Text = "x :";
            // 
            // m_TimerGraph
            // 
            this.m_TimerGraph.Enabled = true;
            this.m_TimerGraph.Tick += new System.EventHandler(this.m_TimerGraph_Tick);
            // 
            // m_ChartMoteur
            // 
            this.m_ChartMoteur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea11.Name = "ChartArea1";
            this.m_ChartMoteur.ChartAreas.Add(chartArea11);
            this.m_ChartMoteur.Location = new System.Drawing.Point(0, 313);
            this.m_ChartMoteur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_ChartMoteur.Name = "m_ChartMoteur";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Name = "Series1";
            this.m_ChartMoteur.Series.Add(series11);
            this.m_ChartMoteur.Size = new System.Drawing.Size(517, 318);
            this.m_ChartMoteur.TabIndex = 17;
            this.m_ChartMoteur.Text = "Moteur a Réaction";
            // 
            // m_ChartServo
            // 
            this.m_ChartServo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea12.Name = "ChartArea1";
            this.m_ChartServo.ChartAreas.Add(chartArea12);
            this.m_ChartServo.Location = new System.Drawing.Point(552, 313);
            this.m_ChartServo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_ChartServo.Name = "m_ChartServo";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Name = "Series1";
            this.m_ChartServo.Series.Add(series12);
            this.m_ChartServo.Size = new System.Drawing.Size(517, 318);
            this.m_ChartServo.TabIndex = 18;
            this.m_ChartServo.Text = "Gyroscope";
            // 
            // m_BpExporterMoteur
            // 
            this.m_BpExporterMoteur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpExporterMoteur.Location = new System.Drawing.Point(51, 250);
            this.m_BpExporterMoteur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_BpExporterMoteur.Name = "m_BpExporterMoteur";
            this.m_BpExporterMoteur.Size = new System.Drawing.Size(119, 32);
            this.m_BpExporterMoteur.TabIndex = 19;
            this.m_BpExporterMoteur.Text = "Exporter";
            this.m_BpExporterMoteur.UseVisualStyleBackColor = true;
            this.m_BpExporterMoteur.Click += new System.EventHandler(this.m_BpExporterMoteur_Click);
            // 
            // m_BpExporterServo
            // 
            this.m_BpExporterServo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpExporterServo.Location = new System.Drawing.Point(603, 250);
            this.m_BpExporterServo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_BpExporterServo.Name = "m_BpExporterServo";
            this.m_BpExporterServo.Size = new System.Drawing.Size(119, 32);
            this.m_BpExporterServo.TabIndex = 20;
            this.m_BpExporterServo.Text = "Exporter";
            this.m_BpExporterServo.UseVisualStyleBackColor = true;
            this.m_BpExporterServo.Click += new System.EventHandler(this.m_BpExporterServo_Click);
            // 
            // m_BpActionneurPlay
            // 
            this.m_BpActionneurPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_BpActionneurPlay.Location = new System.Drawing.Point(451, 250);
            this.m_BpActionneurPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_BpActionneurPlay.Name = "m_BpActionneurPlay";
            this.m_BpActionneurPlay.Size = new System.Drawing.Size(66, 32);
            this.m_BpActionneurPlay.TabIndex = 21;
            this.m_BpActionneurPlay.Text = "Pause";
            this.m_BpActionneurPlay.UseVisualStyleBackColor = true;
            this.m_BpActionneurPlay.Click += new System.EventHandler(this.m_BpActionneurPlay_Click);
            // 
            // m_LblMoteur_y
            // 
            this.m_LblMoteur_y.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblMoteur_y.AutoSize = true;
            this.m_LblMoteur_y.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblMoteur_y.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblMoteur_y.Location = new System.Drawing.Point(75, 176);
            this.m_LblMoteur_y.Name = "m_LblMoteur_y";
            this.m_LblMoteur_y.Size = new System.Drawing.Size(30, 19);
            this.m_LblMoteur_y.TabIndex = 22;
            this.m_LblMoteur_y.Text = "y :";
            // 
            // m_LblMoteur_z
            // 
            this.m_LblMoteur_z.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblMoteur_z.AutoSize = true;
            this.m_LblMoteur_z.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblMoteur_z.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblMoteur_z.Location = new System.Drawing.Point(75, 195);
            this.m_LblMoteur_z.Name = "m_LblMoteur_z";
            this.m_LblMoteur_z.Size = new System.Drawing.Size(30, 19);
            this.m_LblMoteur_z.TabIndex = 23;
            this.m_LblMoteur_z.Text = "z :";
            // 
            // m_CheckMoteur_x
            // 
            this.m_CheckMoteur_x.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_CheckMoteur_x.AutoSize = true;
            this.m_CheckMoteur_x.Checked = true;
            this.m_CheckMoteur_x.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_CheckMoteur_x.Location = new System.Drawing.Point(51, 160);
            this.m_CheckMoteur_x.Name = "m_CheckMoteur_x";
            this.m_CheckMoteur_x.Size = new System.Drawing.Size(18, 17);
            this.m_CheckMoteur_x.TabIndex = 26;
            this.m_CheckMoteur_x.UseVisualStyleBackColor = true;
            this.m_CheckMoteur_x.CheckedChanged += new System.EventHandler(this.m_CheckMoteur_x_CheckedChanged);
            // 
            // m_CheckMoteur_y
            // 
            this.m_CheckMoteur_y.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_CheckMoteur_y.AutoSize = true;
            this.m_CheckMoteur_y.Checked = true;
            this.m_CheckMoteur_y.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_CheckMoteur_y.Location = new System.Drawing.Point(51, 179);
            this.m_CheckMoteur_y.Name = "m_CheckMoteur_y";
            this.m_CheckMoteur_y.Size = new System.Drawing.Size(18, 17);
            this.m_CheckMoteur_y.TabIndex = 27;
            this.m_CheckMoteur_y.UseVisualStyleBackColor = true;
            this.m_CheckMoteur_y.CheckedChanged += new System.EventHandler(this.m_CheckMoteur_y_CheckedChanged);
            // 
            // m_CheckMoteur_z
            // 
            this.m_CheckMoteur_z.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_CheckMoteur_z.AutoSize = true;
            this.m_CheckMoteur_z.Checked = true;
            this.m_CheckMoteur_z.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_CheckMoteur_z.Location = new System.Drawing.Point(51, 198);
            this.m_CheckMoteur_z.Name = "m_CheckMoteur_z";
            this.m_CheckMoteur_z.Size = new System.Drawing.Size(18, 17);
            this.m_CheckMoteur_z.TabIndex = 28;
            this.m_CheckMoteur_z.UseVisualStyleBackColor = true;
            this.m_CheckMoteur_z.CheckedChanged += new System.EventHandler(this.m_CheckMoteur_z_CheckedChanged);
            // 
            // Actionnneur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_CheckMoteur_z);
            this.Controls.Add(this.m_CheckMoteur_y);
            this.Controls.Add(this.m_CheckMoteur_x);
            this.Controls.Add(this.m_LblMoteur_z);
            this.Controls.Add(this.m_LblMoteur_y);
            this.Controls.Add(this.m_BpActionneurPlay);
            this.Controls.Add(this.m_BpExporterServo);
            this.Controls.Add(this.m_BpExporterMoteur);
            this.Controls.Add(this.m_ChartServo);
            this.Controls.Add(this.m_ChartMoteur);
            this.Controls.Add(this.m_LblMoteurConstructeur);
            this.Controls.Add(this.m_LblServoConstructeur);
            this.Controls.Add(this.m_LblServo);
            this.Controls.Add(this.m_LblServoModele);
            this.Controls.Add(this.m_LblMoteurModele);
            this.Controls.Add(this.m_LblMoteur_x);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_LblLiaisonSerie);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Actionnneur";
            this.Size = new System.Drawing.Size(1069, 630);
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartMoteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartServo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LblLiaisonSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m_LblMoteurConstructeur;
        private System.Windows.Forms.Label m_LblServoConstructeur;
        private System.Windows.Forms.Label m_LblServo;
        private System.Windows.Forms.Label m_LblServoModele;
        private System.Windows.Forms.Label m_LblMoteurModele;
        private System.Windows.Forms.Label m_LblMoteur_x;
        private System.Windows.Forms.Timer m_TimerGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart m_ChartMoteur;
        private System.Windows.Forms.DataVisualization.Charting.Chart m_ChartServo;
        private System.Windows.Forms.Button m_BpExporterMoteur;
        private System.Windows.Forms.Button m_BpExporterServo;
        private System.Windows.Forms.Button m_BpActionneurPlay;
        private System.Windows.Forms.Label m_LblMoteur_y;
        private System.Windows.Forms.Label m_LblMoteur_z;
        private System.Windows.Forms.CheckBox m_CheckMoteur_x;
        private System.Windows.Forms.CheckBox m_CheckMoteur_y;
        private System.Windows.Forms.CheckBox m_CheckMoteur_z;
    }
}
