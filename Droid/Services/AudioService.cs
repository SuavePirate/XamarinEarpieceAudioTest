using System;
using Android.Content;
using Android.Media;
using AudioTest.Droid;
using AudioTest.Services;
using Xamarin.Forms;
using AudioTest.Droid.Services;

[assembly: Dependency(typeof(AudioService))]
namespace AudioTest.Droid.Services
{
    public class AudioService : IAudioService
    {
        public AudioService()
        {
        }

        public void PlaySoundThroughEarPiece()
        {
            var mediaPlayer = new MediaPlayer();

            mediaPlayer.Reset();

            var audioManager = (AudioManager)Android.App.Application.Context.GetSystemService(Context.AudioService);
            mediaPlayer.SetAudioStreamType(Stream.VoiceCall);
            audioManager.Mode = Mode.InCall;
            audioManager.SpeakerphoneOn = false;
            mediaPlayer.SetDataSource(Android.App.Application.Context, Android.Net.Uri.Parse("android.resource://com.suavepirate.audiotest/raw/sample_sound"));
            mediaPlayer.Prepare();
            mediaPlayer.Start();
        }

        public void PlaySoundThroughSpeaker()
        {
            var mediaPlayer = MediaPlayer.Create(Android.App.Application.Context, Resource.Raw.sample_sound);


            var audioManager = (AudioManager)Android.App.Application.Context.GetSystemService(Context.AudioService);
            mediaPlayer.SetAudioStreamType(Stream.Music);
            audioManager.Mode = Mode.Normal;
            audioManager.SpeakerphoneOn = true;

            mediaPlayer.Start();
        }
    }
}
