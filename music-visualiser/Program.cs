using NAudio;
using NAudio.WaveFormRenderer; 

namespace music_visualiser;

class Program
{
    static void Main(string[] args)
    {
        // SOUND VISUALISER MADE BY BANSKY (NOT THE BRI'ISH ARTIST)

        System.Console.WriteLine("=====SOUND-VISUALISER=====");
        System.Console.Write("Choose your file path (mp3 file)");
        string mp3FilePathChoice = Console.ReadLine();
        System.Console.WriteLine("Now, choose your config");

        //TODO: finish the menu

        var renderingSettings = new StandardWaveFormRendererSettings();
        renderingSettings.Width = 640;
        renderingSettings.TopHeight = 32;
        renderingSettings.BottomHeight = 32;

        var renderer = new WaveFormRenderer();
        var audioFilePath = "sound.mp3";
        var image = renderer.Render(audioFilePath, myPeakProvider, myRendererSettings);

        image.Save("filename.png", ImageFormat.png)
    }
}
