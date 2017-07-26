using AudioTest.Services;
using Xamarin.Forms;

namespace AudioTest
{
    public partial class AudioTestPage : ContentPage
    {
        public AudioTestPage()
        {
            InitializeComponent();
        }

        void Speaker_Clicked(object sender, System.EventArgs e)
        {
            DependencyService.Get<IAudioService>().PlaySoundThroughSpeaker();
        }
        void EarPiece_Clicked(object sender, System.EventArgs e)
        {
            DependencyService.Get<IAudioService>().PlaySoundThroughEarPiece();
        }
    }
}
