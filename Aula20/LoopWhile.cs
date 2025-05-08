using System;

class aula20
{
    static void Main(string[] args)
    {
        //usamos quando sei quantas vezes quero repetir e while quando não sei quantas vezes desejo repetir
        int[] num = new int[10];

        int i = 0;//tenho que ter a variavel já criada diferente do for
        while (i < num.Length)
        { //ele usa apenas uma expressão para executar enquanto verdadeiro
            num[i]=0;
            Console.WriteLine(num[i]);
            i++;
        }
            Console.WriteLine("FIM DO LOOP");
    }
}