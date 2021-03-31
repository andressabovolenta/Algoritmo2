using System;

namespace Algoritmo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //CÁLCULO DE IMC:

            //Console.WriteLine("Digite o seu peso (kg):");
            //int peso = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite a sua altura (m):");
            //double altura = Convert.ToDouble(Console.ReadLine());

            //double imc = peso / (altura * altura);
            //string resultado = "";

            //if (imc < 17)
            //    resultado = "Muito abaixo do peso.";
            //if (imc >= 17 && imc <= 18.49)
            //    resultado = "Abaixo do peso.";
            //if (imc >= 18.5 && imc <= 24.99)
            //    resultado = "Peso normal.";
            //if (imc >= 25 && imc < 29.99)
            //    resultado = "Acima do peso.";
            //if (imc >= 30 && imc <= 34.99)
            //    resultado = "Obesidade nível I.";
            //if (imc >= 35 && imc <= 39.99)
            //    resultado = "Obesidade nível II (severa).";
            //if (imc >= 40)
            //    resultado = "Obesidade nível III (mórbida).";

            //Console.WriteLine(imc + ". " + resultado);


            //NÚMEROS PRIMOS

            //Console.WriteLine("Digite um número:");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //int[] index = new int[4];
            //index[0] = 2;
            //index[1] = 3;
            //index[2] = 5;
            //index[3] = 7;
            //bool primo = true;

            //for (int i = 0; i < 4; i++)
            //{
            //    int resto = numero % index[i];

            //    if (numero != index[i] && resto == 0)
            //    {
            //        primo = false;
            //        break;
            //    }                   
            //}
            //if (primo == true)
            //    Console.WriteLine("Você digitou um número primo.");
            //else
            //    Console.WriteLine("O número que você digitou não é um número primo.");

            //--------------------//

            //NumerosPrimos numerosPrimos = new NumerosPrimos();
            //Console.WriteLine("Digite um limite:");
            //numerosPrimos.limite = Convert.ToInt32(Console.ReadLine());
            //numerosPrimos.CalcularNumerosPrimos();

            
            //CONTROLE DE ACESSO

            //string login = "andressabovolenta";
            //string senha = "unalome21";

            //Console.WriteLine("Digite seu nome de usuário:");
            //string loginDigitado = Console.ReadLine();

            //if (loginDigitado == login)
            //{
            //    int count = 0;

            //    while (count < 3)
            //    {
            //        Console.WriteLine("Digite sua senha:");
            //        string senhaDigitada = Console.ReadLine();

            //        if (senhaDigitada == senha)
            //        {
            //            Console.WriteLine("Login efetuado com sucesso.");
            //            break;
            //        }

            //        count++;
            //    }
            //}

            //--------------------//

            //ControleAcesso controleAcesso = new ControleAcesso();

            //bool logado = controleAcesso.EfetuarLogin();

            //if (logado)
            //{
            //    Console.WriteLine("Login efetuado com sucesso.");
            //}

            //--------------------//


        }
    }
}
