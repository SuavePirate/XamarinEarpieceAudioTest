using System;
using Android.Content;
using Android.Media;
using AudioTest.Droid;
using AudioTest.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(IAudioService))]
namespace AudioTest.Droid.Services
{
    public class AudioService : IAudioService
    {
        public AudioService()
        {
        }

        public void PlaySoundThroughEarPiece()
        {
            var mediaPlayer = MediaPlayer.Create(Android.App.Application.Context, Resource.Raw.sample_sound);
            mediaPlayer.SetAudioStreamType(Stream.VoiceCall);

            mediaPlayer.Start();
        }

        public void PlaySoundThroughSpeaker()
        {
            var mediaPlayer = MediaPlayer.Create(Android.App.Application.Context, Resource.Raw.sample_sound);
            mediaPlayer.SetAudioStreamType(Stream.Music);

            mediaPlayer.Start();
        }
    }
}
