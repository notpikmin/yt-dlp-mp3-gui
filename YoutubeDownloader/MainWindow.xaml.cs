using System.Diagnostics;
using System.Windows;

namespace YoutubeDownloader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Download(object sender, RoutedEventArgs e)
        {
            string url = VideoUrl.Text;
            Process process = new Process();
            var args = "-x --audio-format mp3 " + url + " -o '%(title)s.%(ext)s'";
            process.StartInfo = new ProcessStartInfo("yt-dlp.exe", args);
            process.Start();
        }
    }
}