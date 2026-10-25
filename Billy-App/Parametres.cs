using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text;
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
        private readonly string m_VersionActuelle = "v1.0.0";
        private readonly string m_DateVersion = "25/10/2026";
        public Parametres(Form1 parent)
        {
            InitializeComponent();
            this.form = parent;

            this.m_TxtBoxRaccourciIp.Text = Properties.Settings.Default.Ip;
            this.m_TxtBoxRaccourciMdp.Text = Properties.Settings.Default.MotDePasse;
            this.m_TxtBoxStockTrans.Text = Properties.Settings.Default.CheminTransfert;
            this.m_TxtBoxStockDonnees.Text = Properties.Settings.Default.CheminDonnees;
            this.m_TxtBoxStockExp.Text = Properties.Settings.Default.CheminExp;

            this.m_LblInfoVersion.Text = $"Version actuelle : {m_VersionActuelle}";
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
            {https://open.spotify.com/track/6TWWauThn6z8xOFpG4XF3O
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
                    if (this.m_ChekBoxPreRelease.CheckState == CheckState.Checked)
                    {
                        urlApi = $"https://api.github.com/repos/{m_RepoGitHub}/releases";
                    }
                    else
                    {
                        urlApi = $"https://api.github.com/repos/{m_RepoGitHub}/releases/latest";
                    }
                    string jsonResponse = await client.GetStringAsync(urlApi);

                    using (JsonDocument doc = JsonDocument.Parse(jsonResponse))
                    {
                        // On vérifie que la réponse est bien un tableau non vide
                        if (doc.RootElement.ValueKind == JsonValueKind.Array && doc.RootElement.GetArrayLength() > 0)
                        {
                            // Récupération de la release la plus récente (1er élément du tableau)
                            JsonElement derniereRelease = doc.RootElement[0];
                            string derniereVersion = derniereRelease.GetProperty("tag_name").GetString();
                            this.m_LblVMajVersion.Text = $"Version : {derniereVersion}";

                            if (derniereVersion != m_VersionActuelle)
                            {
                                DialogResult result = MessageBox.Show(
                                    $"Une nouvelle version ({derniereVersion}) est disponible !\nVoulez-vous la télécharger et l'installer ?",
                                    "Mise à jour disponible",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information);

                                if (result == DialogResult.Yes)
                                {
                                    JsonElement assets = derniereRelease.GetProperty("assets");
                                    if (assets.GetArrayLength() > 0)
                                    {
                                        string urlDownload = assets[0].GetProperty("browser_download_url").GetString();
                                        await InstallerMiseAJour(urlDownload);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Votre application est déjà à jour.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
