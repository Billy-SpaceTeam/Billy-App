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
            this.label1 = new System.Windows.Forms.Label();
            this.m_LblImportFichier = new System.Windows.Forms.Label();
            this.m_LblTransfertStatus = new System.Windows.Forms.Label();
            this.m_LblTransfertType = new System.Windows.Forms.Label();
            this.m_LblTransfertVersion = new System.Windows.Forms.Label();
            this.m_LblTransfertDate = new System.Windows.Forms.Label();
            this.m_LblTransfertBranche = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_PanelImportFichier.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_LblTransfert
            // 
            this.m_LblTransfert.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblTransfert.AutoSize = true;
            this.m_LblTransfert.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblTransfert.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblTransfert.Location = new System.Drawing.Point(20, 22);
            this.m_LblTransfert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblTransfert.Name = "m_LblTransfert";
            this.m_LblTransfert.Size = new System.Drawing.Size(181, 20);
            this.m_LblTransfert.TabIndex = 2;
            this.m_LblTransfert.Text = "Transfert Programme";
            // 
            // m_TxtBoxTransfert
            // 
            this.m_TxtBoxTransfert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_TxtBoxTransfert.EnableAutoDragDrop = true;
            this.m_TxtBoxTransfert.Location = new System.Drawing.Point(2, 258);
            this.m_TxtBoxTransfert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_TxtBoxTransfert.Name = "m_TxtBoxTransfert";
            this.m_TxtBoxTransfert.ReadOnly = true;
            this.m_TxtBoxTransfert.Size = new System.Drawing.Size(798, 252);
            this.m_TxtBoxTransfert.TabIndex = 9;
            this.m_TxtBoxTransfert.Text = "";
            // 
            // m_BpTransfert
            // 
            this.m_BpTransfert.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpTransfert.Location = new System.Drawing.Point(524, 202);
            this.m_BpTransfert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.m_BoxTransfert.Location = new System.Drawing.Point(24, 57);
            this.m_BoxTransfert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_BoxTransfert.Name = "m_BoxTransfert";
            this.m_BoxTransfert.Size = new System.Drawing.Size(101, 21);
            this.m_BoxTransfert.TabIndex = 11;
            this.m_BoxTransfert.SelectedIndexChanged += new System.EventHandler(this.m_BoxTransfert_SelectedIndexChanged);
            // 
            // m_BpImportFichier
            // 
            this.m_BpImportFichier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_BpImportFichier.Location = new System.Drawing.Point(60, 202);
            this.m_BpImportFichier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_BpImportFichier.Name = "m_BpImportFichier";
            this.m_BpImportFichier.Size = new System.Drawing.Size(120, 34);
            this.m_BpImportFichier.TabIndex = 12;
            this.m_BpImportFichier.Text = "Importer un fichier";
            this.m_BpImportFichier.UseVisualStyleBackColor = true;
            this.m_BpImportFichier.Click += new System.EventHandler(this.m_BpImportFichier_Click);
            // 
            // m_PanelImportFichier
            // 
            this.m_PanelImportFichier.AllowDrop = true;
            this.m_PanelImportFichier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_PanelImportFichier.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.m_PanelImportFichier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_PanelImportFichier.Controls.Add(this.label1);
            this.m_PanelImportFichier.Location = new System.Drawing.Point(24, 97);
            this.m_PanelImportFichier.Name = "m_PanelImportFichier";
            this.m_PanelImportFichier.Size = new System.Drawing.Size(200, 100);
            this.m_PanelImportFichier.TabIndex = 13;
            this.m_PanelImportFichier.DragDrop += new System.Windows.Forms.DragEventHandler(this.m_PanelImportFichier_DragDrop);
            this.m_PanelImportFichier.DragEnter += new System.Windows.Forms.DragEventHandler(this.m_PanelImportFichier_DragEnter);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Drop un fichier";
            // 
            // m_LblImportFichier
            // 
            this.m_LblImportFichier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblImportFichier.AutoSize = true;
            this.m_LblImportFichier.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblImportFichier.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblImportFichier.Location = new System.Drawing.Point(282, 182);
            this.m_LblImportFichier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblImportFichier.Name = "m_LblImportFichier";
            this.m_LblImportFichier.Size = new System.Drawing.Size(60, 15);
            this.m_LblImportFichier.TabIndex = 16;
            this.m_LblImportFichier.Text = "Chemin :";
            // 
            // m_LblTransfertStatus
            // 
            this.m_LblTransfertStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblTransfertStatus.AutoSize = true;
            this.m_LblTransfertStatus.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblTransfertStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblTransfertStatus.Location = new System.Drawing.Point(282, 112);
            this.m_LblTransfertStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblTransfertStatus.Name = "m_LblTransfertStatus";
            this.m_LblTransfertStatus.Size = new System.Drawing.Size(52, 15);
            this.m_LblTransfertStatus.TabIndex = 17;
            this.m_LblTransfertStatus.Text = "Status :";
            // 
            // m_LblTransfertType
            // 
            this.m_LblTransfertType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblTransfertType.AutoSize = true;
            this.m_LblTransfertType.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblTransfertType.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblTransfertType.Location = new System.Drawing.Point(282, 97);
            this.m_LblTransfertType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblTransfertType.Name = "m_LblTransfertType";
            this.m_LblTransfertType.Size = new System.Drawing.Size(44, 15);
            this.m_LblTransfertType.TabIndex = 18;
            this.m_LblTransfertType.Text = "Type :";
            // 
            // m_LblTransfertVersion
            // 
            this.m_LblTransfertVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblTransfertVersion.AutoSize = true;
            this.m_LblTransfertVersion.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblTransfertVersion.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblTransfertVersion.Location = new System.Drawing.Point(282, 127);
            this.m_LblTransfertVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblTransfertVersion.Name = "m_LblTransfertVersion";
            this.m_LblTransfertVersion.Size = new System.Drawing.Size(63, 15);
            this.m_LblTransfertVersion.TabIndex = 19;
            this.m_LblTransfertVersion.Text = "Version : ";
            this.m_LblTransfertVersion.Click += new System.EventHandler(this.m_LblTransfertVersion_Click);
            // 
            // m_LblTransfertDate
            // 
            this.m_LblTransfertDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblTransfertDate.AutoSize = true;
            this.m_LblTransfertDate.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblTransfertDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblTransfertDate.Location = new System.Drawing.Point(282, 157);
            this.m_LblTransfertDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblTransfertDate.Name = "m_LblTransfertDate";
            this.m_LblTransfertDate.Size = new System.Drawing.Size(43, 15);
            this.m_LblTransfertDate.TabIndex = 20;
            this.m_LblTransfertDate.Text = "Date :";
            // 
            // m_LblTransfertBranche
            // 
            this.m_LblTransfertBranche.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LblTransfertBranche.AutoSize = true;
            this.m_LblTransfertBranche.BackColor = System.Drawing.SystemColors.Control;
            this.m_LblTransfertBranche.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblTransfertBranche.Location = new System.Drawing.Point(282, 142);
            this.m_LblTransfertBranche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LblTransfertBranche.Name = "m_LblTransfertBranche";
            this.m_LblTransfertBranche.Size = new System.Drawing.Size(63, 15);
            this.m_LblTransfertBranche.TabIndex = 21;
            this.m_LblTransfertBranche.Text = "Branche :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_TxtBoxTransfert, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 512);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_BpTransfert);
            this.panel1.Controls.Add(this.m_LblTransfertBranche);
            this.panel1.Controls.Add(this.m_LblTransfert);
            this.panel1.Controls.Add(this.m_LblTransfertDate);
            this.panel1.Controls.Add(this.m_BoxTransfert);
            this.panel1.Controls.Add(this.m_LblTransfertVersion);
            this.panel1.Controls.Add(this.m_BpImportFichier);
            this.panel1.Controls.Add(this.m_LblTransfertType);
            this.panel1.Controls.Add(this.m_PanelImportFichier);
            this.panel1.Controls.Add(this.m_LblTransfertStatus);
            this.panel1.Controls.Add(this.m_LblImportFichier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 250);
            this.panel1.TabIndex = 23;
            // 
            // Transfert
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Transfert";
            this.Size = new System.Drawing.Size(802, 512);
            this.m_PanelImportFichier.ResumeLayout(false);
            this.m_PanelImportFichier.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_LblTransfert;
        private System.Windows.Forms.RichTextBox m_TxtBoxTransfert;
        private System.Windows.Forms.Button m_BpTransfert;
        private System.Windows.Forms.ComboBox m_BoxTransfert;
        private System.Windows.Forms.Button m_BpImportFichier;
        private System.Windows.Forms.Panel m_PanelImportFichier;
        private System.Windows.Forms.Label m_LblImportFichier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m_LblTransfertStatus;
        private System.Windows.Forms.Label m_LblTransfertType;
        private System.Windows.Forms.Label m_LblTransfertVersion;
        private System.Windows.Forms.Label m_LblTransfertDate;
        private System.Windows.Forms.Label m_LblTransfertBranche;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}
