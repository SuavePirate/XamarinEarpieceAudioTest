using System;
namespace AudioTest.Services
{
    public interface IAudioService
    {
        void PlaySoundThroughSpeaker();
        void PlaySoundThroughEarPiece();
    }
}
