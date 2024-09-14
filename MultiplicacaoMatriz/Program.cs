using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicarMatrizesBidimencionais {
    internal class Program {
        static void Main(string[] args) {

            int[,] matriz01 = new int[2, 3];
            int[,] matriz02 = new int[3, 2];
            int[,] resultado = new int[2, 2];

            Console.WriteLine("Preencha os valores da primeira matriz:");
            for (int linha = 0; linha < 2; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    Console.Write($"Matriz 01# Posição [{linha}][{coluna}]: ");
                    matriz01[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nPreencha os valores da segunda matriz");
            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 2; coluna++) {
                    Console.Write($"Matriz 02# Posição [{linha}][{coluna}]: ");
                    matriz02[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }


            #region Sugestão de valores a ser digitado nas matrizes, se feito, gabarito mostrando correto funcionamento do programa
            /*
             * Exemplo de valores para a primeira matriz
             * matriz01[0, 0] = 5;
             * matriz01[0, 1] = 5;
             * matriz01[0, 2] = 3;
             * matriz01[1, 0] = 5;
             * matriz01[1, 1] = 5;
             * matriz01[1, 2] = 1;
             * 
             * Exemplo de valores para a segunda matriz
             * matriz02[0, 0] = 4;
             * matriz02[0, 1] = 2;
             * matriz02[1, 0] = 3;
             * matriz02[1, 1] = 3;
             * matriz02[2, 0] = 1;
             * matriz02[2, 1] = 5;
             * 
             * Se digitado estes valores, o resultado esperado é a matriz
             * 
             * [38 40]
             * [36 30]
             * 
             */
            #endregion


            Console.WriteLine("Resultado da multiplicação da Matriz 01 pela Matriz 02");

            // Calculos da multiplicações entre duas matrizes bidimencionais
            resultado[0, 0] = (matriz01[0, 0] * matriz02[0, 0])
                + (matriz01[0, 1] * matriz02[1, 0])
                + (matriz01[0, 2] * matriz02[2, 0]);

            resultado[0, 1] = (matriz01[0, 0] * matriz02[0, 1])
                + (matriz01[0, 1] * matriz02[1, 1])
                + (matriz01[0, 2] * matriz02[2, 1]);

            resultado[1, 0] = (matriz01[1, 0] * matriz02[0, 0])
                + (matriz01[1, 1] * matriz02[1, 0])
                + (matriz01[1, 2] * matriz02[2, 0]);

            resultado[1, 1] = (matriz01[1, 0] * matriz02[0, 1])
                + (matriz01[1, 1] * matriz02[1, 1])
                + (matriz01[1, 2] * matriz02[2, 1]);

            Console.WriteLine($"[{resultado[0, 0]} {resultado[0, 1]}]");
            Console.WriteLine($"[{resultado[1, 0]} {resultado[1, 1]}]");

            Console.WriteLine();

        }
    }
}
