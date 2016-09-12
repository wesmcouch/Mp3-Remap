using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mp3Remap
{
    public partial class Form1 : Form
    {
        private String songsPath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            String songPath = getSongPath();
            List<String> songList = loadSongs(songPath);
            String csvPath = createTempCSV(songPath, songList);
        }

        private void btnLoadSongs_Click(object sender, EventArgs e)
        {
            loadSongs(txtPath.Text);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private String getSongPath()
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            int size = -1;
            DialogResult result = browser.ShowDialog();

            if (string.IsNullOrWhiteSpace(browser.SelectedPath))
            {
                return "";
            }
            else
            {
                return browser.SelectedPath;
            }
        }

        private List<String> loadSongs(String folder)
        {
            if (!Directory.Exists(folder))
            {
                MessageBox.Show("Please select a valid directory");
                return null;
            }
            songsPath = folder;
            List<String> songFiles = new List<String>(getFileNames(folder, "*.mp3"));
            return songFiles;
        }

        private static string[] getFileNames(string path, string filter)
        {
            string[] files = Directory.GetFiles(path, filter);
            for (int i = 0; i < files.Length; i++)
                files[i] = Path.GetFileName(files[i]);
            return files;
        }

        private String createTempCSV(String folder, List<String> songList)
        {
            String CSVPath = Directory.GetCurrentDirectory() + "\\temp.csv";
            var csv = new StringBuilder();

            foreach(String songFile in songList)
            {
                var artist = getArtist(songFile);
                var songName = getSongName(songFile);
                var newLine = string.Format("{0}, {1}, {2}", artist, songName, songFile);
                csv.AppendLine(newLine);
            }



            File.WriteAllText(CSVPath, csv.ToString());
            System.Diagnostics.Process.Start(CSVPath);
            return "";
        }

        private string getArtist(String songFile)
        {
            String artist = songFile.Split('-')[0];
            return artist.Trim();
        }

        private string getSongName(String songFile)
        {
            String[] splitSong = songFile.Split('-');
            String songName = "";
            for (int i = 1; i < splitSong.Length; i++)
            {
                songName += splitSong[i];
            }
            songName = songName.Replace(".mp3", "");
            return songName;
        }
    }
}
