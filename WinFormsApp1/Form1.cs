using Squirrel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateMyApp();
        }

        private static async Task UpdateMyApp()
        {
            using var mgr = new UpdateManager("https://the.place/you-host/updates");
            var newVersion = await mgr.UpdateApp();

            // optionally restart the app automatically, or ask the user if/when they want to restart
            if (newVersion != null)
            {
                UpdateManager.RestartApp();
            }
        }
    }
}