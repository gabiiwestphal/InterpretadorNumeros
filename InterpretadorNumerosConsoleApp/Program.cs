using System;
using System.Collections.Generic;
using System.IO;

namespace InterpretadorNumerosConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "      __   __        __   __   __   __   __   __  \n" +
                          "   |  __|  __| |__| |__  |__     | |__| |__| |  | \n" +
                          "   | |__   __|    |  __| |__|    | |__|  __| |__| ";


            StringReader leitorTexto = new StringReader(texto);

            String primeiraLinha = leitorTexto.ReadLine();
            char[] arrayPrimeiraLinha = primeiraLinha.ToCharArray();

            string segundaLinha = leitorTexto.ReadLine();
            char[] arraySegundaLinha = segundaLinha.ToCharArray();

            string terceiraLinha = leitorTexto.ReadLine();
            char[] arrayTerceiraLinha = terceiraLinha.ToCharArray();

            int indicePrimeiraColuna = 0;
            int indiceUltimaColuna = 3;

            for (int i = indicePrimeiraColuna; i < indiceUltimaColuna; i++)
            {
                if (indicePrimeiraColuna >= arrayPrimeiraLinha.Length)
                {
                    break;
                }

                var estruturaDoNumero = new bool[7] { false, 
                                                        false, 
                                                        false, 
                                                        false, 
                                                        false, 
                                                        false, 
                                                        false  
                                                               };

                var caracter = arrayPrimeiraLinha[indicePrimeiraColuna + 1];
                if (caracter == '_')
                {
                    estruturaDoNumero[0] = true;
                }

                caracter = arraySegundaLinha[indicePrimeiraColuna];
                if (caracter == '|')
                {
                    estruturaDoNumero[5] = true;
                }

                caracter = arraySegundaLinha[indicePrimeiraColuna + 1];
                if (caracter == '_')
                {
                    estruturaDoNumero[6] = true;
                }

                caracter = arraySegundaLinha[indicePrimeiraColuna + 3];
                if (caracter == '|')
                {
                    estruturaDoNumero[1] = true;
                }

                caracter = arrayTerceiraLinha[indicePrimeiraColuna];
                if (caracter == '|')
                {
                    estruturaDoNumero[4] = true;
                }

                caracter = arrayTerceiraLinha[indicePrimeiraColuna + 1];
                if (caracter == '_')
                {
                    estruturaDoNumero[3] = true;
                }

                caracter = arrayTerceiraLinha[indicePrimeiraColuna + 3];
                if (caracter == '|')
                {
                    estruturaDoNumero[2] = true; // Inferior Direito
                }

                indicePrimeiraColuna += 5;
                indiceUltimaColuna += 5;

                if (estruturaDoNumero[0] == false && estruturaDoNumero[1] && estruturaDoNumero[2] &&
                estruturaDoNumero[3] == false && estruturaDoNumero[4] == false && estruturaDoNumero[5] == false &&
                estruturaDoNumero[6] == false)
                {
                    Console.Write("1");
                }
                else if (estruturaDoNumero[0] && estruturaDoNumero[1] && estruturaDoNumero[6] &&
                estruturaDoNumero[4] && estruturaDoNumero[3] && estruturaDoNumero[5] == false &&
                estruturaDoNumero[2] == false)
                {
                    Console.Write("2");
                }
                else if (estruturaDoNumero[0] && estruturaDoNumero[1] && estruturaDoNumero[2] &&
                estruturaDoNumero[3] && estruturaDoNumero[4] == false && estruturaDoNumero[5] == false &&
                estruturaDoNumero[6])
                {
                    Console.Write("3");
                }
                else if (estruturaDoNumero[0] == false && estruturaDoNumero[1] && estruturaDoNumero[2] &&
                estruturaDoNumero[3] == false && estruturaDoNumero[4] == false && estruturaDoNumero[5] &&
                estruturaDoNumero[6])
                {
                    Console.Write("4");
                }
                else if (estruturaDoNumero[0] && estruturaDoNumero[1] == false && estruturaDoNumero[2] &&
                estruturaDoNumero[3] && estruturaDoNumero[4] == false && estruturaDoNumero[5] &&
                estruturaDoNumero[6])
                {
                    Console.Write("5");
                }
                else if (estruturaDoNumero[0] && estruturaDoNumero[1] == false && estruturaDoNumero[2] &&
                estruturaDoNumero[3] && estruturaDoNumero[4] && estruturaDoNumero[5] &&
                estruturaDoNumero[6])
                {
                    Console.Write("6");
                }
                else if (estruturaDoNumero[0] && estruturaDoNumero[1] && estruturaDoNumero[2] &&
                estruturaDoNumero[3] == false && estruturaDoNumero[4] == false && estruturaDoNumero[5] == false &&
                estruturaDoNumero[6] == false)
                {
                    Console.Write("7");
                }
                else if (estruturaDoNumero[0] && estruturaDoNumero[1] && estruturaDoNumero[2] &&
                estruturaDoNumero[3] && estruturaDoNumero[4] && estruturaDoNumero[5] &&
                estruturaDoNumero[6])
                {
                    Console.Write("8");
                }
                else if (estruturaDoNumero[0] && estruturaDoNumero[1] && estruturaDoNumero[2] &&
                estruturaDoNumero[3] && estruturaDoNumero[4] == false && estruturaDoNumero[5] &&
                estruturaDoNumero[6])
                {
                    Console.Write("9");
                }
                else if (estruturaDoNumero[0] && estruturaDoNumero[1] && estruturaDoNumero[2] &&
                estruturaDoNumero[3] && estruturaDoNumero[4] && estruturaDoNumero[5] &&
                estruturaDoNumero[6] == false)
                {
                    Console.Write("0");
                }
            }

            Console.ReadLine();

        }
    }
}
