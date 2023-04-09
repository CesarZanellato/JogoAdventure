using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdventure
{
    public class Textos
    {
        public static string texto;
        #region INICIO
        public static void Estoria()
        {
              texto = "\nEsta é a história não contada de um caçador, que um dia foi para a floresta para fazer exatamente isso, caçar. Em sua viagem, " +
                "ele decidiu mudar de rumo para dar diversidade ao seu ofício, então ele virou seu caminhão e o estacionou em frente a uma área de floresta " +
                "desconhecida que tinha a reputação de ser abundante em grandes presas. Ele estava com sua espingarda presa nas mãos, esperando por algum animal " +
                "descuidado, mas não conseguiu ver mais longe do que seu nariz, pois de repente, uma forte neblina veio sobre o local. Era tão espesso e profuso " +
                "que o caçador não conseguia encontrar seu curso original, e vagueou mais profundamente na floresta do que havia planejado. Ele andava e andava, " +
                "esfregando as mãos nos antebraços, pois o nevoeiro trazia consigo um arrepio atroz que arrefeceu o pobre caçador até a medula, enquanto uma " +
                "fumaça branca distinta subia de sua boca a cada respiração.\r\n\r\n\n";

            Metodos.Digitador(texto);
        }
        #endregion

        
    }
}
