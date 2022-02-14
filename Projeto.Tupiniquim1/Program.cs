using System;

namespace Projeto.Tupiniquim1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool resp;
            do
            {


                Console.WriteLine("===Tupiniquim 1===");
                Console.WriteLine();
                Console.WriteLine("Programa para controle remoto de robôs em Marte: ");
                Console.WriteLine();
                // instruções de uso 
                Console.WriteLine("Como controlar o seu robô; ");
                Console.WriteLine("M para mover o robô a frente");
                Console.WriteLine("E para move-lo 90º a esquerda");
                Console.WriteLine("D para move-lo 90º a direita");
                Console.WriteLine();

                //+instruções
                Console.WriteLine("x, y para area de análise, ex: 5,5");
                Console.WriteLine("x, y, d para coordenadas iniciais do robo, ex (x, y, d): 1, 2, N");
                Console.WriteLine("Comandos são dados sequencialmente (EMEMEMDMDMM)");
                Console.WriteLine("Repita os comandos para utilizar o Robo II");
                //começar a brincar com os dados:
                //interação com o usuario
                Console.WriteLine("Digite a área inicial de análise X: ");
                double pontox = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a área inicial de análise Y: ");
                double pontoy = Convert.ToDouble(Console.ReadLine());
                
                char coordenadas;


                Console.WriteLine("Digite as cordenadas iniciais do robo em X: ");
                pontox = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite as cordenadas iniciais do robo em Y: ");
                pontoy = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a coordenada inicial: N/Norte S/sul L/leste O/Oeste");
                coordenadas = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("As coordenadas são: " + pontox + " " + pontoy +  coordenadas);

                string comandos = "MEMEDMEMDM";

                Console.WriteLine("Digite os comandos do seu robo:");
                comandos = Convert.ToString(Console.ReadLine());

                
                char[] instrucao = comandos.ToCharArray();

                for (int i = 0; i < instrucao.Length; i++)

                {
                    if (instrucao[i] == 'E')
                    {
                        switch (coordenadas)
                        {
                            case 'N':
                                coordenadas = 'O';
                                break;
                            case 'S':
                                coordenadas = 'L';
                                break;
                            case 'L':
                                coordenadas = 'N';
                                break;
                            case 'O':
                                coordenadas = 'S';
                                break;
                        }
                        break;
                    }
                    else if (instrucao[i] == 'D')
                    {
                        switch (coordenadas)
                        {
                            case 'N':
                                coordenadas = 'L';
                                break;
                            case 'S':
                                coordenadas = 'O';
                                break;
                            case 'L':
                                coordenadas = 'S';
                                break;
                            case 'O':
                                coordenadas = 'N';
                                break;
                        }
                        break;
                    }

                    else if (instrucao[i] == 'M')
                    {
                        if (coordenadas == 'N')
                        {
                            pontoy = pontoy + 1;
                            break;

                        }
                        else
                        {
                            if (coordenadas == 'L')
                            {
                                pontox = pontox + 1;
                                break;
                            }
                            else
                            {
                                if (coordenadas == 'S')
                                {
                                    pontoy = pontoy - 1;
                                    break;
                                }
                                else
                                {
                                    if (coordenadas == 'O')
                                    {
                                        pontox = pontox - 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                Console.WriteLine("As coordenadas atingidas foram: " + pontox + pontoy + coordenadas);

                Console.WriteLine("Deseja continuar com mais um robo?: S/sim N/nao");
                char continuar = Convert.ToChar(Console.ReadLine());
                resp = continuar == 'S';

                if (continuar == 'n')
                {
                    break;
                }
               Console.ReadKey();
            }while(true);
        }
    }
}
