using System;

class aula22
{
    static void Main(string[] args)
    {
        //FOREACH , serve para interar e poder ler elementos de uma coleção
        int[] num = new int[5] { 11, 22, 33, 44, 55 };
        /*
        int[] num = new int[5] { 11, 22, 33, 44, 55 };

        for (int i = 0; i <= num.Length-1; i++)
        {
            Console.WriteLine(num[i]);
        } //menor igual a 3 devemo diminuir 1 do indice 
    */

        //serve apenas para leitura
        foreach (int i in num)
        {
            System.Console.WriteLine(i);
        }
    }
    
}