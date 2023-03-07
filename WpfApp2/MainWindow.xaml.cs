using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String[] files, paths;
        private MediaPlayer mediaPlayer = new MediaPlayer();
        bool loadedPlaylist = false;
        int trackIndex, songDuration;
        public MainWindow()
        {
            InitializeComponent();
            try
            {

                ButtonPlay.Visibility = Visibility.Visible;
                ButtonPause.Visibility = Visibility.Hidden;
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show($"The music visualiser file was not found: '{e}'");
            }
            mediaPlayer.Play();
        }
        private void ButtonSelectSongs_Click(object sender, RoutedEventArgs e)
        {
            selectSongs();
            mediaPlayer.Play();
        }

        private void playNextTrack()
        {
            if (trackIndex < PlaylistListBox.Items.Count - 1)
            {
                trackIndex += 1;
                mediaPlayer.Open(new Uri(paths[trackIndex]));
                mediaPlayer.Play();
                ButtonNext.IsEnabled = true;
            }
            else
            {
                ButtonNext.Opacity = 0.5;        //sets button transparency due to end of the playlist
                ButtonNext.IsEnabled = false;
            }
        }

        private void playPreviousTrack()
        {
            if (trackIndex < PlaylistListBox.Items.Count - 1)
            {
                trackIndex -= 1;
                mediaPlayer.Open(new Uri(paths[trackIndex]));
                mediaPlayer.Play();
                ButtonNext.IsEnabled = true;
            }
        }

        public void selectSongs()
        {             //puts the chosen songs to the playlistListBox

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic); // "C:\\Users\\admin\\Music";
            openFileDialog.Filter = "music files (*.wav)|*.wav|music files (*.mp3)|*.mp3|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    files = openFileDialog.SafeFileNames;    //saves the track names in the tracks array
                    paths = openFileDialog.FileNames;        //saves the path tracks in the tracks array
                    mediaPlayer.Open(new Uri(paths[0]));
                    StartMusic();
                    for (int i = 0; i < files.Length; i++)
                        PlaylistListBox.Items.Add(files[i]);
                    loadedPlaylist = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read the file from disk. Original error: " + ex.Message);
                }
            }
        }
        private void ButtonPrevious_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (trackIndex > 0)
                    trackIndex -= 1;

                mediaPlayer.Open(new Uri(paths[trackIndex]));
                mediaPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonBackwards_MouseDown(object sender, MouseButtonEventArgs e)
        { //sets 10 seconds rewinds in the media and video players
            TimeSpan ts = new TimeSpan(0, 0, 0, (int)(mediaPlayer.Position.Seconds - 10));
            mediaPlayer.Position = ts;
        }

        public void ButtonPause_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (loadedPlaylist == true)
            {
                mediaPlayer.Pause();
                ButtonPlay.Visibility = Visibility.Visible;
                ButtonPause.Visibility = Visibility.Hidden;
            }
        }

        public void ButtonPlay_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (loadedPlaylist == true)
            {
                mediaPlayer.Play();
                ButtonPlay.Visibility = Visibility.Hidden;
                ButtonPause.Visibility = Visibility.Visible;
            }
            else MessageBox.Show("You can add some songs obviously :)");
        }

        private void ButtonForwards_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, (int)(mediaPlayer.Position.Seconds + 10));
            mediaPlayer.Position = ts;
        }

        private void ButtonNext_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                playNextTrack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void MediaPlayerSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaPlayer.Position = TimeSpan.FromSeconds(MediaPlayerSlider.Value);
            TextBlockCurrentTimeSign.Text = TimeSpan.FromSeconds(MediaPlayerSlider.Value).ToString(@"m\:ss");
        }

        private void timer_Tick(object sender, EventArgs e)
        {       //
            try
            {
                if ((mediaPlayer.Source != null) && (mediaPlayer.NaturalDuration.HasTimeSpan))
                {
                    MediaPlayerSlider.Minimum = 0;
                    MediaPlayerSlider.Maximum = mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
                    MediaPlayerSlider.Value = mediaPlayer.Position.TotalSeconds;
                    songDuration = (int)(mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds);
                    TextBlockSongDuration.Text = TimeSpan.FromSeconds(songDuration).ToString(@"m\:ss");

                    if (MediaPlayerSlider.Maximum == MediaPlayerSlider.Value) //if end of the track the media player plays the next track
                        playNextTrack();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PlaylistListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {  //plays the selected track
            try
            {
                StartMusic();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StartMusic()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            mediaPlayer.Play();
            ButtonPlay.Visibility = Visibility.Hidden;
            ButtonPause.Visibility = Visibility.Visible;
            trackIndex = PlaylistListBox.SelectedIndex;
        }

        private void PlaylistListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mediaPlayer.Open(new Uri(paths[PlaylistListBox.SelectedIndex]));
            try
            {
                StartMusic();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PlaylistListBox_Drop(object sender, DragEventArgs e)
        {
            string filename = (string)((DataObject)e.Data).GetFileDropList()[0];
            PlaylistListBox.SelectionMode = SelectionMode.Extended;
            selectSongs();
        }

        private void MenuItemEyeKeeper_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Again1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mediaPlayer.Open(new Uri(paths[trackIndex]));
                mediaPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void stop_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonPlay_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    
    }
}
