using System;

class Aula11
{
    static void Main()
    {
        int n1 = 10;
        float n2 = n1;

        Console.WriteLine(n2); //conversão implicita segura ele faz automaticamente sem falar nada

        /*
                float n3 =10.5f;
                int n4= n3;

                Console.WriteLine(n4); //Recepemos um erro pois é uma conversão explicita precisa de CAST
        */
        float n3 = 10.5f;
        int n4 = (int)n3; //typecast

        Console.WriteLine(n4); //ele converte e perdemos o .

        int vInt = 10;
        short vShort = (short)vInt;

        Console.WriteLine(vShort);


    }

}