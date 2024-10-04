using System.Net;
using NAudio;
using NAudio.WaveFormRenderer; 

namespace music_visualiser;

class Program
{
    // var renderingConfig = new StandardWaveFormRendererSettings();

    static void Main(string[] args)
    {
        // SOUND VISUALISER MADE BY BANSKY (NOT THE BRI'ISH ARTIST)

        System.Console.WriteLine("=====SOUND-VISUALISER=====");
        System.Console.Write("Choose your file path (mp3 file)");
        string mp3FilePathChoice = Console.ReadLine();
        System.Console.WriteLine("Now, choose your config");
        System.Console.Write("Choose the width for your image in px (640px recomended): ");
        int userWidthValue  = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Choose the top height: ");
        int userTopHeightValue = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Choose the bottom height: ");
        int userBottomHeightValue = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Choose the output file name (without the file extension at the end): ");
        string userOutputFileName = Console.ReadLine();

        //TODO: refractor and fix

        var renderingSettings = new StandardWaveFormRendererSettings();
        var audioPeakProvider = new MaxPeakProvider();
        renderingSettings.Width = userWidthValue;
        renderingSettings.TopHeight = userTopHeightValue;
        renderingSettings.BottomHeight = userBottomHeightValue;

        var renderer = new WaveFormRenderer();
        string audioFilePath = "sound.mp3";
        var image = renderer.Render(audioFilePath, audioPeakProvider, renderingSettings);

        image.Save(userOutputFileName);
    }

    public void visualiseSound(){

    }
}
