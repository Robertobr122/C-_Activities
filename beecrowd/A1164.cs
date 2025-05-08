using System;

class atividade1164{
    static void Main(){
        int numero;

        do{
        Console.Write("Digite um número para ver se é inteiro: ");
        numero = int.Parse(Console.ReadLine());
        
        } while(numero % numero != 0 || numero % 1 != 0);

        Console.WriteLine("O número é primo");

        }
    }