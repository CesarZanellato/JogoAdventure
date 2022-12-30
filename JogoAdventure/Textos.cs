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
        #region INICIO
        public static void Estoria()
        {
             string texto = "O protagonista é um jovem chamado Ethan, que vive com seus pais em uma fazenda isolada no interior. " +
                 "Ethan sempre foi curioso sobre o mundo além da fazenda, mas sua vida tranquila mudou radicalmente quando ele descobriu que era um descendente de uma família " +
                 "de heróis lendários.\r\n\r\nUm dia, Ethan é visitado por um ancião sábio chamado Gideon, que lhe explica que a família de Ethan é responsável por proteger o " +
                 "mundo de uma ameaça mágica há gerações. Gideon diz que Ethan possui um poder mágico único, e que ele deve deixar a fazenda e se juntar à guilda dos heróis " +
                 "para aprender a controlar e usar esse poder.\r\n\r\nEthan fica hesitante em deixar sua vida tranquila na fazenda, mas também sabe que é sua responsabilidade " +
                 "ajudar a proteger o mundo. Ele finalmente decide aceitar o desafio e parte em sua jornada para se juntar à guilda dos heróis e aprender a usar seus poderes " +
                 "para salvar o mundo.";

            Metodos.Digitador(texto);
        }
        #endregion

        
    }
}
