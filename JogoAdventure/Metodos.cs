using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdventure
{
    public class Metodos
    {
        public static string EscolheNome()
        {
            Console.WriteLine("Para começar, será necessário escolher um nome\n\n" +
                "digite um nome para o personagem\n\n");
            
            Heroi personagem = new Heroi();
            Heroi vida = new Heroi();
            vida.vida = 100;

            personagem.nome = Console.ReadLine().ToUpper();

            Console.WriteLine($"\no nome escolhido foi: {personagem.nome}\n\n" +
                              $"Confirma?\n" +
                              $"Digite SIM NÃO\n");

            var teste = Verificador.ValidaOpcao();

            while (teste != true)
            {
                Console.WriteLine("OK, escolha um novo nome para o personagem");
                personagem.nome = Console.ReadLine().ToUpper();

                Console.WriteLine($"\no nome escolhido foi: {personagem.nome}\n\n" +
                                  $"Confirma?\n" +
                                  $"Digite SIM NÃO\n");
                Verificador.ValidaOpcao();
            }
            
            return personagem.nome;
        }
        

        
    }
}
