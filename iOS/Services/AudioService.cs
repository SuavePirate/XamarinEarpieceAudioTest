using System;
using AudioTest.iOS.Services;
using AudioTest.Services;
using Xamarin.Forms;
using AVFoundation;
using AudioToolbox;
using Foundation;

[assembly: Dependency(typeof(AudioService))]
namespace AudioTest.iOS.Services
{
    public class AudioService : IAudioService
    {
        public AudioService()
        {
        }

        public void PlaySoundThroughEarPiece()
        {
            var session = AVAudioSession.SharedInstance();
            session.SetCategory(AVAudioSessionCategory.PlayAndRecord);
            session.SetActive(true);
            NSError error;
            var player = new AVAudioPlayer(new NSUrl("sample_sound.mp3"), "mp3", out error);
            player.Volume = 1.0f;
            player.Play();

        }

        public void PlaySoundThroughSpeaker()
        {
            var session = AVAudioSession.SharedInstance();
            session.SetCategory(AVAudioSessionCategory.Playback);
            session.SetActive(true);
            NSError error;
            var player = new AVAudioPlayer(new NSUrl("sample_sound.mp3"), "mp3", out error);
            player.Volume = 1.0f;
            player.Play();
            
        }
    }
}
