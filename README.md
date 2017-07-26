# XamarinEarpieceAudioTest
Just a sample piece of code for playing audio between the speaker and onboard earpiece (phone calls)

## On iOS:

``` c#

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
```

## On Android:

``` c#
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
```
