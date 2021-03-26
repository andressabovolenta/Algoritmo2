using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmo2
{
    class ControleAcesso
    {
        public string login = "andressabovolenta";
        public string senha = "unalome21";

        public bool EfetuarLogin()
        {
            bool retorno = false;
            Console.WriteLine("Digite seu nome de usuário:");
            string loginDigitado = Console.ReadLine();

            if (loginDigitado == login)
            {
                int count = 0;

                while (count < 3)
                {
                    Console.WriteLine("Digite sua senha:");
                    string senhaDigitada = Console.ReadLine();

                    if (senhaDigitada == senha)
                    {
                        retorno = true;
                    }

                    count++;
                }
            }
            return retorno;
        }
    }
}
