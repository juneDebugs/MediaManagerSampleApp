using System;
using System.Collections.Generic;
using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions;
using Plugin.MediaManager.Forms;
using Xamarin.Forms;

namespace MediaManagerSampleApp
{
    public partial class VideoPage : ContentPage
    {
        private IPlaybackController PlaybackController => CrossMediaManager.Current.PlaybackController;

        public VideoPage()
        {
            InitializeComponent();

            CrossMediaManager.Current.PlayingChanged += (sender, e) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    ProgressBar.Progress = e.Progress;
                    Duration.Text = "" + e.Duration.TotalSeconds + " seconds";
                });
            };
        }

        protected override void OnAppearing()
        {
            //PlaybackController.Play();
            videoView.Source = "http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4";
            PlaybackController.Play();
        }

        void PlayClicked(object sender, System.EventArgs e)
        {
            PlaybackController.Play();
        }

        void PauseClicked(object sender, System.EventArgs e)
        {
            PlaybackController.Pause();
        }

        void StopClicked(object sender, System.EventArgs e)
        {
            PlaybackController.Stop();
        }
    }
}
