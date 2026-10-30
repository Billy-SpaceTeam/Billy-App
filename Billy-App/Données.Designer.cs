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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.m_CheckGyro_x = new System.Windows.Forms.CheckBox();
            this.m_CheckGyro_z = new System.Windows.Forms.CheckBox();
            this.m_CheckGyro_y = new System.Windows.Forms.CheckBox();
            this.m_CheckAcc_y = new System.Windows.Forms.CheckBox();
            this.m_CheckAcc_z = new System.Windows.Forms.CheckBox();
            this.m_CheckAcc_x = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartPhotodiode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartGyroscope)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_ChartPhotodiode
            // 
            chartArea1.Name = "ChartArea1";
            this.m_ChartPhotodiode.ChartAreas.Add(chartArea1);
            this.m_ChartPhotodiode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_ChartPhotodiode.Location = new System.Drawing.Point(537, 211);
            this.m_ChartPhotodiode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_ChartPhotodiode.Name = "m_ChartPhotodiode";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.m_ChartPhotodiode.Series.Add(series1);
            this.m_ChartPhotodiode.Size = new System.Drawing.Size(529, 417);
            this.m_ChartPhotodiode.TabIndex = 0;
            this.m_ChartPhotodiode.Text = "PhotoDiode";
            // 
            // m_LblLiaisonSerie
            // 
            this.m_LblLiaisonSerie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblLiaisonSerie.AutoSize = true;
            this.m_LblLiaisonSerie.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblLiaisonSerie.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblLiaisonSerie.Location = new System.Drawing.Point(40, -6);
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
            this.label1.Location = new System.Drawing.Point(85, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "PhotoDiode";
            // 
            // m_ChartGyroscope
            // 
            chartArea2.Name = "ChartArea1";
            this.m_ChartGyroscope.ChartAreas.Add(chartArea2);
            this.m_ChartGyroscope.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_ChartGyroscope.Location = new System.Drawing.Point(3, 211);
            this.m_ChartGyroscope.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_ChartGyroscope.Name = "m_ChartGyroscope";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.m_ChartGyroscope.Series.Add(series2);
            this.m_ChartGyroscope.Size = new System.Drawing.Size(528, 417);
            this.m_ChartGyroscope.TabIndex = 4;
            this.m_ChartGyroscope.Text = "Gyroscope";
            // 
            // m_LblGyro_x
            // 
            this.m_LblGyro_x.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblGyro_x.AutoSize = true;
            this.m_LblGyro_x.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblGyro_x.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblGyro_x.Location = new System.Drawing.Point(67, 89);
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
            this.m_LblGyroModele.Location = new System.Drawing.Point(41, 30);
            this.m_LblGyroModele.Name = "m_LblGyroModele";
            this.m_LblGyroModele.Size = new System.Drawing.Size(74, 19);
            this.m_LblGyroModele.TabIndex = 6;
            this.m_LblGyroModele.Text = "Modèle :";
            this.m_LblGyroModele.Click += new System.EventHandler(this.m_LblGyroModele_Click);
            // 
            // m_LblPhotoModele
            // 
            this.m_LblPhotoModele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_LblPhotoModele.AutoSize = true;
            this.m_LblPhotoModele.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblPhotoModele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_LblPhotoModele.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblPhotoModele.Location = new System.Drawing.Point(85, 31);
            this.m_LblPhotoModele.Name = "m_LblPhotoModele";
            this.m_LblPhotoModele.Size = new System.Drawing.Size(74, 19);
            this.m_LblPhotoModele.TabIndex = 7;
            this.m_LblPhotoModele.Text = "Modèle :";
            this.m_LblPhotoModele.Click += new System.EventHandler(this.m_LblPhotoModele_Click);
            // 
            // m_LblPhoto
            // 
            this.m_LblPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_LblPhoto.AutoSize = true;
            this.m_LblPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblPhoto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblPhoto.Location = new System.Drawing.Point(87, 94);
            this.m_LblPhoto.Name = "m_LblPhoto";
            this.m_LblPhoto.Size = new System.Drawing.Size(67, 19);
            this.m_LblPhoto.TabIndex = 8;
            this.m_LblPhoto.Text = "Valeur :";
            // 
            // m_LblPhotoConstructeur
            // 
            this.m_LblPhotoConstructeur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_LblPhotoConstructeur.AutoSize = true;
            this.m_LblPhotoConstructeur.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblPhotoConstructeur.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblPhotoConstructeur.Location = new System.Drawing.Point(85, 49);
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
            this.m_LblGyroConstructeur.Location = new System.Drawing.Point(41, 48);
            this.m_LblGyroConstructeur.Name = "m_LblGyroConstructeur";
            this.m_LblGyroConstructeur.Size = new System.Drawing.Size(118, 19);
            this.m_LblGyroConstructeur.TabIndex = 10;
            this.m_LblGyroConstructeur.Text = "Constructeur :";
            // 
            // m_BpDonneesChartGyro
            // 
            this.m_BpDonneesChartGyro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpDonneesChartGyro.Location = new System.Drawing.Point(45, 175);
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
            this.m_BpDonneesChartPhoto.Location = new System.Drawing.Point(91, 176);
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
            this.m_BpDonneesPlay.Location = new System.Drawing.Point(440, 176);
            this.m_BpDonneesPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_BpDonneesPlay.Name = "m_BpDonneesPlay";
            this.m_BpDonneesPlay.Size = new System.Drawing.Size(67, 32);
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
            this.m_LblGyro_y.Location = new System.Drawing.Point(67, 107);
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
            this.m_LblGyro_z.Location = new System.Drawing.Point(65, 126);
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
            this.m_LblAccel_z.Location = new System.Drawing.Point(297, 127);
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
            this.m_LblAccel_y.Location = new System.Drawing.Point(299, 109);
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
            this.m_LblAccel_x.Location = new System.Drawing.Point(299, 89);
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
            this.label5.Location = new System.Drawing.Point(41, 73);
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
            this.label6.Location = new System.Drawing.Point(271, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Accelerometre";
            // 
            // m_CheckGyro_x
            // 
            this.m_CheckGyro_x.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_CheckGyro_x.AutoSize = true;
            this.m_CheckGyro_x.Checked = true;
            this.m_CheckGyro_x.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_CheckGyro_x.Location = new System.Drawing.Point(45, 91);
            this.m_CheckGyro_x.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_CheckGyro_x.Name = "m_CheckGyro_x";
            this.m_CheckGyro_x.Size = new System.Drawing.Size(18, 17);
            this.m_CheckGyro_x.TabIndex = 22;
            this.m_CheckGyro_x.UseVisualStyleBackColor = true;
            this.m_CheckGyro_x.CheckedChanged += new System.EventHandler(this.m_CheckGyro_x_CheckedChanged);
            // 
            // m_CheckGyro_z
            // 
            this.m_CheckGyro_z.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_CheckGyro_z.AutoSize = true;
            this.m_CheckGyro_z.Checked = true;
            this.m_CheckGyro_z.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_CheckGyro_z.Location = new System.Drawing.Point(45, 128);
            this.m_CheckGyro_z.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_CheckGyro_z.Name = "m_CheckGyro_z";
            this.m_CheckGyro_z.Size = new System.Drawing.Size(18, 17);
            this.m_CheckGyro_z.TabIndex = 23;
            this.m_CheckGyro_z.UseVisualStyleBackColor = true;
            this.m_CheckGyro_z.CheckedChanged += new System.EventHandler(this.m_CheckGyro_z_CheckedChanged);
            // 
            // m_CheckGyro_y
            // 
            this.m_CheckGyro_y.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_CheckGyro_y.AutoSize = true;
            this.m_CheckGyro_y.Checked = true;
            this.m_CheckGyro_y.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_CheckGyro_y.Location = new System.Drawing.Point(45, 110);
            this.m_CheckGyro_y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_CheckGyro_y.Name = "m_CheckGyro_y";
            this.m_CheckGyro_y.Size = new System.Drawing.Size(18, 17);
            this.m_CheckGyro_y.TabIndex = 24;
            this.m_CheckGyro_y.UseVisualStyleBackColor = true;
            this.m_CheckGyro_y.CheckedChanged += new System.EventHandler(this.m_CheckGyro_y_CheckedChanged);
            // 
            // m_CheckAcc_y
            // 
            this.m_CheckAcc_y.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_CheckAcc_y.AutoSize = true;
            this.m_CheckAcc_y.Checked = true;
            this.m_CheckAcc_y.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_CheckAcc_y.Location = new System.Drawing.Point(275, 111);
            this.m_CheckAcc_y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_CheckAcc_y.Name = "m_CheckAcc_y";
            this.m_CheckAcc_y.Size = new System.Drawing.Size(18, 17);
            this.m_CheckAcc_y.TabIndex = 27;
            this.m_CheckAcc_y.UseVisualStyleBackColor = true;
            this.m_CheckAcc_y.CheckedChanged += new System.EventHandler(this.m_CheckAcc_y_CheckedChanged);
            // 
            // m_CheckAcc_z
            // 
            this.m_CheckAcc_z.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_CheckAcc_z.AutoSize = true;
            this.m_CheckAcc_z.Checked = true;
            this.m_CheckAcc_z.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_CheckAcc_z.Location = new System.Drawing.Point(275, 129);
            this.m_CheckAcc_z.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_CheckAcc_z.Name = "m_CheckAcc_z";
            this.m_CheckAcc_z.Size = new System.Drawing.Size(18, 17);
            this.m_CheckAcc_z.TabIndex = 26;
            this.m_CheckAcc_z.UseVisualStyleBackColor = true;
            this.m_CheckAcc_z.CheckedChanged += new System.EventHandler(this.m_CheckAcc_z_CheckedChanged);
            // 
            // m_CheckAcc_x
            // 
            this.m_CheckAcc_x.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_CheckAcc_x.AutoSize = true;
            this.m_CheckAcc_x.Checked = true;
            this.m_CheckAcc_x.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_CheckAcc_x.Location = new System.Drawing.Point(275, 93);
            this.m_CheckAcc_x.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_CheckAcc_x.Name = "m_CheckAcc_x";
            this.m_CheckAcc_x.Size = new System.Drawing.Size(18, 17);
            this.m_CheckAcc_x.TabIndex = 25;
            this.m_CheckAcc_x.UseVisualStyleBackColor = true;
            this.m_CheckAcc_x.CheckedChanged += new System.EventHandler(this.m_CheckAcc_x_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_ChartGyroscope, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.m_ChartPhotodiode, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1069, 630);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_BpDonneesChartGyro);
            this.panel2.Controls.Add(this.m_BpDonneesPlay);
            this.panel2.Controls.Add(this.m_CheckAcc_y);
            this.panel2.Controls.Add(this.m_LblLiaisonSerie);
            this.panel2.Controls.Add(this.m_CheckAcc_z);
            this.panel2.Controls.Add(this.m_LblGyro_x);
            this.panel2.Controls.Add(this.m_CheckAcc_x);
            this.panel2.Controls.Add(this.m_LblGyroModele);
            this.panel2.Controls.Add(this.m_CheckGyro_y);
            this.panel2.Controls.Add(this.m_LblGyroConstructeur);
            this.panel2.Controls.Add(this.m_CheckGyro_z);
            this.panel2.Controls.Add(this.m_LblGyro_y);
            this.panel2.Controls.Add(this.m_CheckGyro_x);
            this.panel2.Controls.Add(this.m_LblGyro_z);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.m_LblAccel_x);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.m_LblAccel_y);
            this.panel2.Controls.Add(this.m_LblAccel_z);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 201);
            this.panel2.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_BpDonneesChartPhoto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_LblPhotoConstructeur);
            this.panel1.Controls.Add(this.m_LblPhotoModele);
            this.panel1.Controls.Add(this.m_LblPhoto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(538, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 201);
            this.panel1.TabIndex = 29;
            // 
            // Données
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Données";
            this.Size = new System.Drawing.Size(1069, 630);
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartPhotodiode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartGyroscope)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox m_CheckGyro_x;
        private System.Windows.Forms.CheckBox m_CheckGyro_z;
        private System.Windows.Forms.CheckBox m_CheckGyro_y;
        private System.Windows.Forms.CheckBox m_CheckAcc_y;
        private System.Windows.Forms.CheckBox m_CheckAcc_z;
        private System.Windows.Forms.CheckBox m_CheckAcc_x;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
