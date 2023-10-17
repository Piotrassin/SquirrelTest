using Squirrel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        UpdateManager manager;

        public Form1()
        {
            InitializeComponent();

        }

        private async void OnInitialization()
        {
            manager = await UpdateManager.GitHubUpdateManager(@"https://github.com/Piotrassin/SquirrelTest");
            versionTextBox.Text = manager.CurrentlyInstalledVersion().ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var updateInfo = await manager.CheckForUpdate();

            if (updateInfo.ReleasesToApply.Count > 0)
            {
                UpdateButton.Enabled = true;
            }
            else
            {
                UpdateButton.Enabled = false;
            }
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            await manager.UpdateApp();

            MessageBox.Show("Zaktualizowano. Zrestartuj by zastosowaæ zmiany.");
        }
    }
}