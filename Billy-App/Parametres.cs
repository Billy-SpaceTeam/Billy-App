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
        private readonly string m_DateVersion = "25/10/2026";
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

            this.m_LblInfoVersion.Text = $"Version actuelle : {Application.ProductVersion}";
            this.m_LblInfoDate.Text = $"Date de la version : {m_DateVersion}";
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
            https://open.spotify.com/track/6TWWauThn6z8xOFpG4XF3O
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
                    string urlApi;
                    var versionActuelle = Application.ProductVersion;
                    versionActuelle = versionActuelle.Replace(".", "");
                    var newVersion = "";
                    bool beta;
                    if (this.m_ChekBoxPreRelease.CheckState == CheckState.Checked)
                    {
                        urlApi = $"https://api.github.com/repos/{m_RepoGitHub}/releases";
                        beta = true;
                    }
                    else
                    {
                        urlApi = $"https://api.github.com/repos/{m_RepoGitHub}/releases/latest";
                        beta = false;
                    }
                    string jsonResponse = await client.GetStringAsync(urlApi);

                    using (JsonDocument doc = JsonDocument.Parse(jsonResponse))
                    {
                        // On vérifie que la réponse est bien un tableau non vide
                        if (doc.RootElement.ValueKind == JsonValueKind.Array && doc.RootElement.GetArrayLength() > 0)
                        {
                            // Récupération de la release la plus récente (1er élément du tableau)
                            JsonElement derniereRelease = doc.RootElement[0];
                            newVersion = derniereRelease.GetProperty("tag_name").GetString();
                            string date = derniereRelease.GetProperty("published_at").GetString();
                            string newVersionText = newVersion;
                            newVersion = newVersion.Replace(".", "");
                            this.m_LblVMajVersion.Text = $"Version : {newVersion}";

                            if (versionActuelle != newVersion)
                            {
                                if (beta)
                                {
                                    this.m_LblMajStatus.Text = "Mise à jour Beta disponible";
                                    this.m_LblVMajVersion.Text = $"Version : {newVersionText} Beta";
                                }
                                else
                                {
                                    this.m_LblMajStatus.Text = "Mise à jour disponible";
                                    this.m_LblVMajVersion.Text = $"Version : {newVersionText}";
                                }
                                this.m_LblMajDate.Text = $"Date : {date}";
                                JsonElement assets = derniereRelease.GetProperty("assets");
                                urlDownload = assets[0].GetProperty("browser_download_url").GetString();
                                this.download = true;
                            }
                            else
                            {
                                this.m_LblMajStatus.Text = "Status : A jour !";
                                this.m_LblVMajVersion.Text = $"Version : {Application.ProductVersion}";
                                this.m_LblMajDate.Text = $"Date : {DateTime.Now:dd/MM/yyyy}";
                                this.download = false;
                                //MessageBox.Show("Votre application est déjà à jour.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aucune release n'a été trouvée sur ce dépôt.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private async Task InstallerMiseAJour(string urlDownload)
        {
            // Ouvre le lien de téléchargement direct dans le navigateur par défaut
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = urlDownload,
                UseShellExecute = true
            });

            await Task.CompletedTask;
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
    }
}
