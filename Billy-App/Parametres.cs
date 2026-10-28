using System;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Billy_App
{
    public partial class Parametres : UserControl
    {
        Form1 form;
        private bool themeSombre = false;
        private readonly string SiteProjet = "https://github.com/Billy-SpaceTeam";
        private readonly string m_RepoGitHub = "Billy-SpaceTeam/Billy-App";
        private bool download;
        private string urlDownload;
        public Parametres(Form1 parent)
        {
            InitializeComponent();
            this.form = parent;

            this.m_TxtBoxRaccourciIp.Text = Properties.Settings.Default.Ip;
            this.m_TxtBoxRaccourciMdp.Text = Properties.Settings.Default.MotDePasse;
            this.m_TxtBoxStockTrans.Text = Properties.Settings.Default.CheminTransfert;
            this.m_TxtBoxStockDonnees.Text = Properties.Settings.Default.CheminDonnees;
            this.m_TxtBoxStockExp.Text = Properties.Settings.Default.CheminExp;

            string exePath = Application.ExecutablePath;
            this.m_LblInfoVersion.Text = $"Version actuelle : {Application.ProductVersion}";
            string dateVersion = System.IO.File.GetLastWriteTime(exePath).ToString("dd/MM/yyyy");
            this.m_LblInfoDate.Text = $"Date de la version : {dateVersion}";
        }

        private void m_BpThemes_Click(object sender, EventArgs e)
        {
            form.ThemeSombre = !form.ThemeSombre;
            Properties.Settings.Default.ThemeSombre = form.ThemeSombre;
            Properties.Settings.Default.Save();

            if (form.ThemeSombre)
            {
                m_BpThemes.Text = "Thème Clair";
            }
            else
            {
                m_BpThemes.Text = "Thème Sombre";
            }
            form.AppliquerTheme();
        }

        private void m_TxtBoxRaccourciIp_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Ip = m_TxtBoxRaccourciIp.Text;
            Properties.Settings.Default.Save();
        }

        private void m_TxtBoxRaccourciMdp_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MotDePasse = m_TxtBoxRaccourciMdp.Text;
            Properties.Settings.Default.Save();
        }

        private void m_TxtBoxStockTrans_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheminTransfert = m_TxtBoxStockTrans.Text;
            Properties.Settings.Default.Save();
        }

        private void m_TxtBoxStockDonnees_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheminDonnees = m_TxtBoxStockDonnees.Text;
            Properties.Settings.Default.Save();
        }

        private void m_TxtBoxStockExp_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheminExp = m_TxtBoxStockExp.Text;
            Properties.Settings.Default.Save();
        }

        private void m_BpLienGithub_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(SiteProjet);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private async void m_BpVerifMaj_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("BillyAppUpdater");

                    bool beta = this.m_ChekBoxPreRelease.Checked;
                    string urlApi = beta
                        ? $"https://api.github.com/repos/{m_RepoGitHub}/releases"
                        : $"https://api.github.com/repos/{m_RepoGitHub}/releases/latest";

                    string jsonResponse = await client.GetStringAsync(urlApi);

                    using (JsonDocument doc = JsonDocument.Parse(jsonResponse))
                    {
                        JsonElement derniereRelease;

                        // 1. Extraire la release selon le type de réponse JSON
                        if (beta)
                        {
                            // /releases renvoie un tableau []
                            if (doc.RootElement.ValueKind == JsonValueKind.Array && doc.RootElement.GetArrayLength() > 0)
                            {
                                derniereRelease = doc.RootElement[0];
                            }
                            else
                            {
                                MessageBox.Show("Aucune release trouvée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        else
                        {
                            // /releases/latest renvoie un objet direct {}
                            if (doc.RootElement.ValueKind == JsonValueKind.Object)
                            {
                                derniereRelease = doc.RootElement;
                            }
                            else
                            {
                                MessageBox.Show("Aucune release officielle trouvée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }

                        // 2. Récupération des informations de la release
                        string newVersionTag = derniereRelease.GetProperty("tag_name").GetString();
                        string dateStr = derniereRelease.GetProperty("published_at").GetString();

                        // Formater la date en lisible (ex: 25/10/2026)
                        if (DateTime.TryParse(dateStr, out DateTime datePub))
                        {
                            dateStr = datePub.ToString("dd/MM/yyyy");
                        }

                        // Normalisation pour la comparaison (ex: "v1.0.2.1" ou "1.0.2.1" -> "1021")
                        string versionActuelleClean = Application.ProductVersion.Replace(".", "");
                        string newVersionClean = newVersionTag.Replace(".", "").Replace("v", "").Replace("V", "");

                        if (versionActuelleClean != newVersionClean)
                        {
                            this.m_LblMajStatus.Text = beta ? "Mise à jour Beta disponible" : "Mise à jour disponible";
                            this.m_LblVMajVersion.Text = $"Version : {newVersionTag}" + (beta ? " Beta" : "");
                            this.m_LblMajDate.Text = $"Date : {dateStr}";
                            this.m_LblVMajVersion.Cursor = Cursors.Hand;

                            JsonElement assets = derniereRelease.GetProperty("assets");
                            if (assets.GetArrayLength() > 0)
                            {
                                urlDownload = assets[0].GetProperty("browser_download_url").GetString();
                                this.download = true;
                            }
                        }
                        else
                        {
                            this.m_LblMajStatus.Text = "Status : À jour !";
                            this.m_LblVMajVersion.Text = $"Version : {Application.ProductVersion}";
                            this.m_LblMajDate.Text = $"Date : {DateTime.Now:dd/MM/yyyy}";
                            this.download = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.m_LblMajStatus.Text = "Status : Erreur";
                MessageBox.Show($"Erreur lors de la vérification : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void m_BpMetAJour_Click(object sender, EventArgs e)
        {
            if (!download)
            {
                MessageBox.Show("Aucune mise à jour disponible pour le moment.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string tempPath = Path.GetTempPath();
                string zipPath = Path.Combine(tempPath, "BillyAppUpdate.zip");
                string extractPath = Path.Combine(tempPath, "BillyAppUpdateExtracted");
                string batPath = Path.Combine(tempPath, "update.bat");

                string currentAppPath = AppDomain.CurrentDomain.BaseDirectory;

                // 1. Télécharger le fichier ZIP
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("BillyAppUpdater");
                    byte[] fileBytes = await client.GetByteArrayAsync(urlDownload);
                    File.WriteAllBytes(zipPath, fileBytes);
                }

                // 2. Extraire l'archive
                if (Directory.Exists(extractPath))
                {
                    Directory.Delete(extractPath, true);
                }
                ZipFile.ExtractToDirectory(zipPath, extractPath);

                // 3. Détecter le dossier réel contenant Billy-App.exe (même s'il est dans un sous-dossier)
                string sourceDir = extractPath;
                string[] exeFiles = Directory.GetFiles(extractPath, "Billy-App.exe", SearchOption.AllDirectories);
                if (exeFiles.Length > 0)
                {
                    sourceDir = Path.GetDirectoryName(exeFiles[0]);
                }

                // 4. Générer le script Batch avec le chemin source exact
                string batContent = $@"
@echo off
echo Mise a jour de Billy-App en cours. Veuillez patienter...
timeout /t 2 /nobreak > NUL

:: Copie les fichiers depuis le dossier source vers l'emplacement actuel
xcopy /Y /E ""{sourceDir}\*"" ""{currentAppPath}""

:: Relance l'application
start """" ""{Path.Combine(currentAppPath, "Billy-App.exe")}""

:: Nettoyage
del ""{zipPath}""
rmdir /S /Q ""{extractPath}""
del ""%~f0""
";
                File.WriteAllText(batPath, batContent);

                // 5. Lancer le script et fermer l'application
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = batPath,
                    UseShellExecute = true,
                    WindowStyle = ProcessWindowStyle.Normal
                };
                Process.Start(psi);

                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'installation : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void m_LblInfoVersion_Click(object sender, EventArgs e)
        {
            string urlVersion = $"https://github.com/{m_RepoGitHub}/releases/{Application.ProductVersion}";
            try
            {
                System.Diagnostics.Process.Start(urlVersion);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void m_LblVMajVersion_Click(object sender, EventArgs e)
        {
            string urlVersion = $"https://github.com/{m_RepoGitHub}/releases/latest";
            if (download)
            {
                try
                {
                    System.Diagnostics.Process.Start(urlVersion);
                }
                catch (System.ComponentModel.Win32Exception noBrowser)
                {
                    if (noBrowser.ErrorCode == -2147467259)
                        MessageBox.Show(noBrowser.Message);
                }
                catch (System.Exception other)
                {
                    MessageBox.Show(other.Message);
                }
            }
        }
    }
}
