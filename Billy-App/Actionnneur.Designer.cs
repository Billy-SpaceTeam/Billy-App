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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.m_LblLiaisonSerie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_LblMoteurConstructeur = new System.Windows.Forms.Label();
            this.m_LblServoConstructeur = new System.Windows.Forms.Label();
            this.m_LblServo = new System.Windows.Forms.Label();
            this.m_LblServoModele = new System.Windows.Forms.Label();
            this.m_LblMoteurModele = new System.Windows.Forms.Label();
            this.m_LblMoteur = new System.Windows.Forms.Label();
            this.m_TimerGraph = new System.Windows.Forms.Timer(this.components);
            this.m_ChartMoteur = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.m_ChartServo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.m_BpExporterMoteur = new System.Windows.Forms.Button();
            this.m_BpExporterServo = new System.Windows.Forms.Button();
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
            this.m_LblLiaisonSerie.Location = new System.Drawing.Point(34, 55);
            this.m_LblLiaisonSerie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblLiaisonSerie.Name = "m_LblLiaisonSerie";
            this.m_LblLiaisonSerie.Size = new System.Drawing.Size(158, 20);
            this.m_LblLiaisonSerie.TabIndex = 3;
            this.m_LblLiaisonSerie.Text = "Moteur à Réaction";
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
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ServoMoteur";
            // 
            // m_LblMoteurConstructeur
            // 
            this.m_LblMoteurConstructeur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblMoteurConstructeur.AutoSize = true;
            this.m_LblMoteurConstructeur.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblMoteurConstructeur.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblMoteurConstructeur.Location = new System.Drawing.Point(35, 105);
            this.m_LblMoteurConstructeur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblMoteurConstructeur.Name = "m_LblMoteurConstructeur";
            this.m_LblMoteurConstructeur.Size = new System.Drawing.Size(98, 16);
            this.m_LblMoteurConstructeur.TabIndex = 16;
            this.m_LblMoteurConstructeur.Text = "Constructeur :";
            // 
            // m_LblServoConstructeur
            // 
            this.m_LblServoConstructeur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblServoConstructeur.AutoSize = true;
            this.m_LblServoConstructeur.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblServoConstructeur.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblServoConstructeur.Location = new System.Drawing.Point(449, 105);
            this.m_LblServoConstructeur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblServoConstructeur.Name = "m_LblServoConstructeur";
            this.m_LblServoConstructeur.Size = new System.Drawing.Size(98, 16);
            this.m_LblServoConstructeur.TabIndex = 15;
            this.m_LblServoConstructeur.Text = "Constructeur :";
            // 
            // m_LblServo
            // 
            this.m_LblServo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblServo.AutoSize = true;
            this.m_LblServo.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblServo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblServo.Location = new System.Drawing.Point(449, 130);
            this.m_LblServo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblServo.Name = "m_LblServo";
            this.m_LblServo.Size = new System.Drawing.Size(56, 16);
            this.m_LblServo.TabIndex = 14;
            this.m_LblServo.Text = "Valeur :";
            // 
            // m_LblServoModele
            // 
            this.m_LblServoModele.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblServoModele.AutoSize = true;
            this.m_LblServoModele.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblServoModele.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblServoModele.Location = new System.Drawing.Point(449, 89);
            this.m_LblServoModele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblServoModele.Name = "m_LblServoModele";
            this.m_LblServoModele.Size = new System.Drawing.Size(61, 16);
            this.m_LblServoModele.TabIndex = 13;
            this.m_LblServoModele.Text = "Modèle :";
            // 
            // m_LblMoteurModele
            // 
            this.m_LblMoteurModele.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblMoteurModele.AutoSize = true;
            this.m_LblMoteurModele.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblMoteurModele.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblMoteurModele.Location = new System.Drawing.Point(35, 89);
            this.m_LblMoteurModele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblMoteurModele.Name = "m_LblMoteurModele";
            this.m_LblMoteurModele.Size = new System.Drawing.Size(61, 16);
            this.m_LblMoteurModele.TabIndex = 12;
            this.m_LblMoteurModele.Text = "Modèle :";
            // 
            // m_LblMoteur
            // 
            this.m_LblMoteur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblMoteur.AutoSize = true;
            this.m_LblMoteur.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblMoteur.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblMoteur.Location = new System.Drawing.Point(35, 130);
            this.m_LblMoteur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblMoteur.Name = "m_LblMoteur";
            this.m_LblMoteur.Size = new System.Drawing.Size(56, 16);
            this.m_LblMoteur.TabIndex = 11;
            this.m_LblMoteur.Text = "Valeur :";
            // 
            // m_TimerGraph
            // 
            this.m_TimerGraph.Enabled = true;
            this.m_TimerGraph.Tick += new System.EventHandler(this.m_TimerGraph_Tick);
            // 
            // m_ChartMoteur
            // 
            this.m_ChartMoteur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea5.Name = "ChartArea1";
            this.m_ChartMoteur.ChartAreas.Add(chartArea5);
            this.m_ChartMoteur.Location = new System.Drawing.Point(0, 254);
            this.m_ChartMoteur.Margin = new System.Windows.Forms.Padding(2);
            this.m_ChartMoteur.Name = "m_ChartMoteur";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Name = "Series1";
            this.m_ChartMoteur.Series.Add(series5);
            this.m_ChartMoteur.Size = new System.Drawing.Size(388, 258);
            this.m_ChartMoteur.TabIndex = 17;
            this.m_ChartMoteur.Text = "Moteur a Réaction";
            // 
            // m_ChartServo
            // 
            this.m_ChartServo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea6.Name = "ChartArea1";
            this.m_ChartServo.ChartAreas.Add(chartArea6);
            this.m_ChartServo.Location = new System.Drawing.Point(414, 254);
            this.m_ChartServo.Margin = new System.Windows.Forms.Padding(2);
            this.m_ChartServo.Name = "m_ChartServo";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Name = "Series1";
            this.m_ChartServo.Series.Add(series6);
            this.m_ChartServo.Size = new System.Drawing.Size(388, 258);
            this.m_ChartServo.TabIndex = 18;
            this.m_ChartServo.Text = "Gyroscope";
            // 
            // m_BpExporterMoteur
            // 
            this.m_BpExporterMoteur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpExporterMoteur.Location = new System.Drawing.Point(38, 203);
            this.m_BpExporterMoteur.Margin = new System.Windows.Forms.Padding(2);
            this.m_BpExporterMoteur.Name = "m_BpExporterMoteur";
            this.m_BpExporterMoteur.Size = new System.Drawing.Size(89, 26);
            this.m_BpExporterMoteur.TabIndex = 19;
            this.m_BpExporterMoteur.Text = "Exporter";
            this.m_BpExporterMoteur.UseVisualStyleBackColor = true;
            this.m_BpExporterMoteur.Click += new System.EventHandler(this.m_BpExporterMoteur_Click);
            // 
            // m_BpExporterServo
            // 
            this.m_BpExporterServo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpExporterServo.Location = new System.Drawing.Point(452, 203);
            this.m_BpExporterServo.Margin = new System.Windows.Forms.Padding(2);
            this.m_BpExporterServo.Name = "m_BpExporterServo";
            this.m_BpExporterServo.Size = new System.Drawing.Size(89, 26);
            this.m_BpExporterServo.TabIndex = 20;
            this.m_BpExporterServo.Text = "Exporter";
            this.m_BpExporterServo.UseVisualStyleBackColor = true;
            this.m_BpExporterServo.Click += new System.EventHandler(this.m_BpExporterServo_Click);
            // 
            // Actionnneur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_BpExporterServo);
            this.Controls.Add(this.m_BpExporterMoteur);
            this.Controls.Add(this.m_ChartServo);
            this.Controls.Add(this.m_ChartMoteur);
            this.Controls.Add(this.m_LblMoteurConstructeur);
            this.Controls.Add(this.m_LblServoConstructeur);
            this.Controls.Add(this.m_LblServo);
            this.Controls.Add(this.m_LblServoModele);
            this.Controls.Add(this.m_LblMoteurModele);
            this.Controls.Add(this.m_LblMoteur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_LblLiaisonSerie);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Actionnneur";
            this.Size = new System.Drawing.Size(802, 512);
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
        private System.Windows.Forms.Label m_LblMoteur;
        private System.Windows.Forms.Timer m_TimerGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart m_ChartMoteur;
        private System.Windows.Forms.DataVisualization.Charting.Chart m_ChartServo;
        private System.Windows.Forms.Button m_BpExporterMoteur;
        private System.Windows.Forms.Button m_BpExporterServo;
    }
}
