using System;

class Aula09
{
    static void Main()
    {
        //Operadores Bitwise:
        //<< deslocamento para esquerda(dobra valor da variavel) >> deslocammento para esquerda(diminui pela metade)
        //exemplo: 00001010 = 10 << 00010100 = 20 e 00011010 = 26 >> 00001101 = 13 

        int num = 10;

        num = num << 1; //nesse caso eu irei dobrar o valor
        Console.WriteLine(num); //imprime 20

        int num2 = 10;
        num2 = num2 >> 1;
        Console.WriteLine(num2); //imprime 5

    }
}