using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdventure
{
    public class Verificador
    {
        public static bool ValidaOpcao()
        {
        Inicio:
            string opcao = Console.ReadLine().ToUpperInvariant().Replace("NÃO", "NAO");

            if (opcao != "SIM" && opcao != "NAO")
            {
                Console.WriteLine("Erro, digite uma opção válida (SIM ou NAO)");
                goto Inicio;
            }
            switch (opcao)
            {
                case "SIM":
                    return true;                    

                case "NAO":
                    return false;
            }
            return ValidaOpcao();
        }
    }
}
