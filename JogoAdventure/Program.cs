
using static System.Console;
using System.Media;
using System.Reflection;
using System.IO;
using System.Resources;
using System.Diagnostics;

namespace JogoAdventure
{

    public class Program
    {
        static void Main(string[] args)
        {
            if (OperatingSystem.IsWindows())
            {
                //var soundPath = (@"C:\Users\cesar\source\repos\JogoAdventure\Sounds\intro.wav");
                SoundPlayer fundo = new SoundPlayer("intro.wav");
                fundo.Load();
                fundo.PlayLooping();
                //fundo.Play();
            }



            Console.WriteLine("\n\t\t\t\t\t\tSEJA BEM VINDO AO\n");
            Console.WriteLine("    :::      :::::::::   :::     :::  ::::::::::  ::::    :::  :::::::::::  :::    :::  :::::::::   :::::::::: ");
            Console.WriteLine("  :+: :+:    :+:    :+:  :+:     :+:  :+:         :+:+:   :+:      :+:      :+:    :+:  :+:    :+:  :+:        ");
            Console.WriteLine(" +:+   +:+   +:+    +:+  +:+     +:+  +:+         :+:+:+  +:+      +:+      +:+    +:+  +:+    +:+  +:+        ");
            Console.WriteLine("+#++:++#++:  +#+    +:+  +#+     +:+  +#++:++#    +#+ +:+ +#+      +#+      +#+    +:+  +#++:++#:   +#++:++#   ");
            Console.WriteLine("+#+     +#+  +#+    +#+   +#+   +#+   +#+         +#+  +#+#+#      +#+      +#+    +#+  +#+    +#+  +#+       ");
            Console.WriteLine("#+#     #+#  #+#    #+#    #+#+#+#    #+#         #+#   #+#+#      #+#      #+#    #+#  #+#    #+#  #+#       ");
            Console.WriteLine("###     ###  #########       ###      ##########  ###    ####      ###       ########   ###    ###  ########## \n\n");
            Console.WriteLine("Para começar, será necessário escolher um nome\n\n" +
                "digite um nome para o personagem\n\n");

            #region Nomeando Personagem

            String opcao;
            Heroi personagem = new Heroi();
            Heroi vida = new Heroi();
            vida.vida = 100;

            personagem.nome = Console.ReadLine().ToUpper();

            Console.WriteLine($"\no nome escolhido foi: {personagem.nome}\n\n" +
                $"Confirma?\n" +
                $"Digite SIM NÃO\n");
            opcao = Console.ReadLine().ToLower().Replace("não", "nao");

            if (opcao != "sim" && opcao != "nao")
            {
                while (opcao != "sim" && opcao != "nao")
                {
                    Console.WriteLine("\nERRO: Favor, insira uma opção válida (SIM ou NÃO)");
                    opcao = Console.ReadLine().ToLower().Replace("não", "nao");
                }
            }

            if (opcao == "sim")
            {
                Console.Clear();
                Console.WriteLine($"OK {personagem.nome}, vamos começar o jogo.\n");
            }

            if (opcao == "nao" || opcao == "não")
            {
                while (opcao != "sim")
                {
                    Console.WriteLine("\nOk, Escolha um novo nome para o personagem\n");
                    personagem.nome = Console.ReadLine().ToUpper();
                    Console.WriteLine($"\no nome escolhido foi: {personagem.nome}\n\n" +
                       $"Confirma?\n" +
                       $"Digite SIM NÃO");
                    opcao = Console.ReadLine().ToLower().Replace("não", "nao");

                    if (opcao == "sim")
                    {
                        Console.Clear();
                        Console.WriteLine($"OK {personagem.nome}, vamos começar o jogo.\n");
                    }

                    if (opcao != "sim" && opcao != "nao")
                    {
                        while (opcao != "sim" && opcao != "nao")
                        {
                            Console.WriteLine("ERRO: Favor, insira uma opção válida (SIM ou NÃO)\n");
                            opcao = Console.ReadLine().ToLower().Replace("não", "nao");
                        }

                    }

                }

            }

            #endregion

            #region Jogo
            Console.WriteLine("região jogo");
            

            #endregion
        }


    }

}
