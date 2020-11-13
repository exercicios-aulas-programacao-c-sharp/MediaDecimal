using System;

namespace MediaDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeNumeros = 0;
            int numeroExecucoes = 0;
            decimal soma = 0;
            decimal media = 0;
            decimal menorNumero = 0;
            decimal maiorNumero = 0;
            
            Console.Write("Quantos números: ");
            quantidadeNumeros = Convert.ToInt32(Console.ReadLine());

            if (quantidadeNumeros < 1)
            {
                Console.WriteLine("Você deve informar um número maior ou igual a 1");
                Environment.Exit(-1);
            }
            
            while (numeroExecucoes < quantidadeNumeros)
            {
                decimal valorInformado = 0;
                
                numeroExecucoes++;
                Console.Write($"Número #{numeroExecucoes}: ");

                valorInformado = Convert.ToDecimal(Console.ReadLine());
                
                soma += valorInformado;
                
                if (numeroExecucoes == 1){
                    maiorNumero = valorInformado;
                    menorNumero = valorInformado;
                }else{
                    if (valorInformado > maiorNumero)
                        maiorNumero = valorInformado;

                    if (valorInformado < menorNumero)
                        menorNumero = valorInformado;
                }

                
            }
            
            media = soma / quantidadeNumeros;

            Console.WriteLine($"\nSoma...: {soma:N2}");
            Console.WriteLine($"Média..: {media:N2}");
            Console.WriteLine($"Maior..: {maiorNumero:N2}");
            Console.WriteLine($"Menor..: {menorNumero:N2}");
        }
    }
}
