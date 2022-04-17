using _1337check.parser;
using System.Diagnostics;

namespace _1337check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            loadReload();


        }

        public void loadReload()
        {
            var resGame = check.game();
            var resApp = check.app();
            var resMovie = check.movie();

            //change groupbox attributes
            nameSoftware.Text = resApp.Item1 + "\n" + resApp.Item2 + "\n" + "Seeders: " + resApp.Item4 + "\n" +"Leechers: " + resApp.Item3;
            nameGame.Text = resGame.Item1 + "\n" + resGame.Item2 + "\n" + "Seeders: " + resGame.Item4 + "\n" + "Leechers: " + resGame.Item3;
            nameMovie.Text = resMovie.Item1 + "\n" + resMovie.Item2 + "\n" + "Seeders: " + resMovie.Item4 + "\n" + "Leechers: " + resMovie.Item3;
        }

        private void nomegame_TextChanged(object sender, EventArgs e)
        {

        }
        //App GB Buttons
        private void magneticSoftware_Click(object sender, EventArgs e)
        {
            var software = check.app();
            Clipboard.SetText(software.Item6);
            MessageBox.Show("Copied to Clipboard!", "Done");
        }

        
        private void openSoftware_Click(object sender, EventArgs e)
        {
            var software = check.app();
            Process.Start(new ProcessStartInfo("https://www.1377x.to" + software.Item5) { UseShellExecute=true});
        }

        // Games GB buttons
        private void openGame_Click(object sender, EventArgs e)
        {
            var game = check.game();
            Process.Start(new ProcessStartInfo("https://www.1377x.to" + game.Item5) { UseShellExecute = true });
        }
        private void magneticgame_Click(object sender, EventArgs e)
        {
            var game = check.game();
            Clipboard.SetText(game.Item6);
            MessageBox.Show("Copied to Clipboard!", "Done");
        }

        //Movie GB Buttons
        private void magneticMovie_Click(object sender, EventArgs e)
        {
            var movie = check.movie();
            Clipboard.SetText(movie.Item6);
            MessageBox.Show("Copied to Clipboard!", "Done");
        }

        private void openMovie_Click(object sender, EventArgs e)
        {
            var movie = check.movie();
            Process.Start(new ProcessStartInfo("https://www.1377x.to" + movie.Item5) { UseShellExecute = true });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadReload();
            MessageBox.Show("Reloaded!", "Done!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/BombeT0/1337-Data-Scraper") { UseShellExecute = true });
        }
    }
}