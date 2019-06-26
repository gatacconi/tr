﻿using System;
using System.Collections.Generic;

namespace Aula03Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] carros;
            //string[] motos;
            string retorno = "";
            int i = 0, contador;

            List<Carro> carros = new List<Carro>();
            List<Moto> motos1 = new List<Moto>();
           
                for (i = 0; i < 3; i++)
                {
                    Carro carro = new Carro();

                    Console.WriteLine("DIGITE A MARCA DO VEICULO: ");
                    carro.Marca = Console.ReadLine();

                    Console.WriteLine("DIGITE O MODELO DO VEICULO: ");
                    carro.Modelo = Console.ReadLine();

                    Console.WriteLine("DIGITE O PAIS DE ORIGEM DO VEICULO: ");
                    carro.PaisDeOrigem = Console.ReadLine();

                    Console.WriteLine("O VEICULO É FLEX? sim ou não");
                    retorno = Console.ReadLine();

                    if (retorno == "SIM" || retorno == "sim")
                    {
                        carro.Flex = true;
                    }
                    else
                        carro.Flex = false;

               
                    Console.WriteLine("\nQUAL A QUANTIDADE DE COMBUSTIVEL ATUAL ");
                    carro.QntTanqueAtual = decimal.Parse(Console.ReadLine());

                
                
                    Console.WriteLine("\nQUAL A QUANTIDADA MAXIMA SUPORTADA NO RESERVATORIO DE COMBUSTIVEL?");
                    carro.QntTanqueCombustivel = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nQUANTOS KM/L O VEICULO FAZ? ");
                    carro.KmPorLitro = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nQUANTOS CAVALOS DE POTENCIA O VEICULO TEM?");
                    carro.Cavalos = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nSEU FILTRO DE COMBUSTIVEL ESTÁ ENTUPIDO?");
                    string filtro = Console.ReadLine();

                    if (filtro.ToString().ToUpper() == "SIM") { carro.FiltroCombustivelEntupido = true; }
                    else
                        carro.FiltroCombustivelEntupido = false;


                    carros.Add(carro);
                    Console.WriteLine($"MARCA:{carros[i].Marca}\nMODELO:{carros[i].Modelo}\nPAIS DE ORIGEM:{carros[i].PaisDeOrigem}\nFLEX:{carros[i].Flex}\nQUANTIDADE DE COMBUSTIVEL ATUAL:{carros[i].QntTanqueAtual}\nQUANTIDADE DE COMBUSTIVEL TOTAL SUPORTADA:{carros[i].QntTanqueCombustivel} \n POTENCIA: {carros[i].Cavalos} ");
                }

                for (i = 0; i < 2; i++)
                {
                    Moto moto = new Moto();

                    Console.WriteLine("\n DIGITE A MARCA DA MOTO: ");
                    moto.Marca = Console.ReadLine();

                    Console.WriteLine("\n DIGITE O MODELO DA MOTO: ");
                    moto.Modelo = Console.ReadLine();

                    Console.WriteLine("\n DIGITE O PAIS DE ORIGEM DA MOTO: ");
                    moto.PaisDeOrigem = Console.ReadLine();

                    Console.WriteLine("\nO VEICULO É FLEX? sim ou não");
                    retorno = Console.ReadLine();

                    if (retorno == "SIM" || retorno == "sim")
                    {
                        moto.Flex = true;
                    }
                    else
                        moto.Flex = false;


                    Console.WriteLine("\nQUAL A QUANTIDADE DE COMBUSTIVEL ATUAL ");
                    moto.QntTanqueAtual = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nQUAL A QUANTIDADA MAXIMA SUPORTADA NO RESERVATORIO DE COMBUSTIVEL?");
                    moto.QntTanqueCombustivel = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nQUANTOS KM/L A MOTO FAZ? ");
                    moto.KmPorLitro = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nQUANTAS CILINDRADAS DE POTENCIA ELA TEM?");
                    moto.Cilindradas = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nSEU FILTRO DE COMBUSTIVEL ESTÁ ENTUPIDO?");
                    string filtro2 = Console.ReadLine();

                    if (filtro2.ToString().ToUpper() == "SIM") { moto.FiltroCombustivelEntupido = true; }
                    else
                        moto.FiltroCombustivelEntupido = false;
                    motos1.Add(moto);

                    Console.WriteLine($"MARCA:{motos1[i].Marca}\n MODELO:{motos1[i].Modelo}\n PAIS DE ORIGEM:{motos1[i].PaisDeOrigem}\n FLEX:{motos1[i].Flex}\nQUANTIDADE DE COMBUSTIVEL ATUAL:{motos1[i].QntTanqueAtual}\nQUANTIDADE DE COMBUSTIVEL TOTAL SUPORTADA:{motos1[i].QntTanqueCombustivel}\nPOTENCIA:{motos1[i].Cilindradas} ");
                }

                Console.WriteLine("DIGITE OS KM ATÉ O DESTINO DA VIAGEM ");
                decimal viagem = Convert.ToDecimal(Console.ReadLine());

                Console.Write("PRIMERO IRÃO OS CARROS E EM SEGUIDA AS MOTOS");


                Console.WriteLine("COMO ESTÁ O CLIMA BOM OU RUIM?");
                string clima = Console.ReadLine().ToUpper();



                for (i = 0; i < 3; i++)
                {

                    do
                    {
                        Console.WriteLine("Digite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual");
                        string opcao = Console.ReadLine();

                        switch (opcao)
                        {
                            case "1": { Console.WriteLine("Por quantos km's deseja dirigir ?"); carros[i].Dirigir(Convert.ToDecimal(Console.ReadLine()), clima); break; }

                            case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); carros[i].Abastecer(Convert.ToDecimal(Console.ReadLine())); break; }
                            case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(carros[i].QntTanqueAtual, 2)} litros \n"); break; }

                            default:
                                break;
                        }

                    } while (viagem > carros[i].viajar);

                    Console.WriteLine("O CARRO CHEGOU AO SEU DESTINO, DIGITE ENTER PARA A PROXIMA VIAGEM");
                    Console.ReadLine();
                }

        
            {
                Console.WriteLine("ERRO DIGITE APENAS O DESEJADO" );
            }

           

            for (i = 0; i < 2; i++)
            {
                do
                {
                    Console.WriteLine("Digite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual");
                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1": { Console.WriteLine("Por quantos km's deseja dirigir ?"); motos1[i].Dirigir(Convert.ToDecimal(Console.ReadLine()), clima); break; }
                        case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); motos1[i].Abastecer(Convert.ToDecimal(Console.ReadLine())); break; }
                        case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(motos1[i].QntTanqueAtual, 2)} litros \n"); break; }

                        default:
                            break;
                    }

                } while (viagem > motos1[i].viajar);

                Console.WriteLine("A MOTO CHEGOU AO SEU DESTINO, DIGITE ENTER PARA A PROXIMA VIAGEM");
                Console.ReadLine();

            }

            Console.WriteLine("TODOS CHEGARAM AO FIM DA VIAGEM");
        }

    }
}








