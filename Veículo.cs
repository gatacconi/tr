﻿using System;

namespace Aula03Csharp
{
    public class Veiculo
    {
        public string Marca;
        public string PaisDeOrigem;
        public decimal QntTanqueCombustivel;
        public decimal QntTanqueAtual;
        public bool Flex;
        public decimal KmPorLitro ;
        public bool FiltroCombustivelEntupido;
        public string Modelo;
        public int potencia;
        public bool climaruim;
        public decimal viajar = 0;

        public Veiculo(string marca, string paisOrigem, decimal qntTanque, bool flex)
        {
            Marca = marca;
            PaisDeOrigem = paisOrigem;
            QntTanqueCombustivel = qntTanque;
            Flex = flex;
        }

        public Veiculo()
        {

        }

        public void KmLitro(decimal kmPorLitro) { KmPorLitro = kmPorLitro; }

        public decimal AutonomiaAtual() { return QntTanqueAtual * KmPorLitro; }

        public void Abastecer(decimal litros)
        {
            

            if (QntTanqueAtual == QntTanqueCombustivel)
                Console.WriteLine("Tanque cheio!");

            if (QntTanqueAtual < QntTanqueCombustivel)
                if (QntTanqueAtual + litros > QntTanqueCombustivel)
                    QntTanqueAtual = QntTanqueCombustivel;
                else
                    QntTanqueAtual += litros;
            else
                Console.WriteLine($"Carro abastecido! Tanque atual: {Math.Round(QntTanqueAtual,2)}");

            Console.WriteLine("TANQUE ABASTECIDO, CONTINUE SUA VIAGEM!");
        }

       




    }
}
