using System.Media;

namespace JogoAdventure
{
    public class MusicPlayer
    {
        public static void musicaIntro()
        {
            try
            {
                string soundPath = (@"C:\Users\cesar\source\repos\JogoAdventure\Sounds");

                SoundPlayer fundo = new SoundPlayer($"{soundPath}\\intro.wav");
                fundo.PlayLooping();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao reproduzir a música: {0}", ex.Message);
            }
        }
    }
}
