using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdventure
{
    public class Metodos
    {
        #region ESCOLHE NOME DO PERSONAGEM
        public static string EscolheNome()
        {
            Console.WriteLine("Para começar, será necessário escolher um nome\n\n" +
                "digite um nome para o personagem\n\n");

            Heroi personagem = new Heroi();
            Heroi vida = new Heroi();
            vida.vida = 100;

        inicio:
            personagem.nome = Console.ReadLine().ToUpper();

            Console.WriteLine($"\no nome escolhido foi: {personagem.nome}\n\n" +
                              $"Confirma?\n" +
                              $"Digite SIM NÃO\n");

            var teste = Verificador.ValidaOpcao();

            if (teste != true)
            {
                Console.WriteLine("OK, escolha um novo nome para o personagem");
                goto inicio;
            }

            return personagem.nome;
        }
        #endregion

        #region GERADOR DADO NUMERICO
        
        public static int Dado()
        {
            Console.WriteLine("Aperte qualquer tecla para lançar os dados");
            Console.ReadKey();

            Random random = new Random();

            int dado = random.Next(1, 6);

            Console.WriteLine($"O número gerado foi: {dado}");

            return dado;
        }

        #endregion

        #region DIGITADOR

        public static void Digitador(string texto)
        {
            foreach (char letra in texto)
            {
                Console.Write(letra);
                Thread.Sleep(70);
            }
        }
        #endregion


    }
}
