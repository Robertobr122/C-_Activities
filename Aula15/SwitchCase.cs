#nullable disable
using System;

class Aula15
{

    static void Main()
    {
        /*
         // ele testa uma variavel e com seu resultado ele compara com seus cases, aquele que for igual terá seubloco de comandos executado
         int tempo = 0;
         char escolha = ' ';

         Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
         Console.WriteLine("Escolha o transporte: [a]Avião | [c]Carro | [o]Ônibus");
         escolha = char.Parse(Console.ReadLine());

         switch (escolha)
         {
             case 'a':
             case 'A': //Caso digite a maiusculo
                 tempo = 50;
                 break; //da a parada
             case 'c':
             case 'C':
                 tempo = 480;
                 break;
             case 'o':
             case 'O':

                 tempo = 660;
                 break;

             default: //caso nenhuma das opções seja a correspondente 
                 tempo = -1; //flag para um tempo indefinido
                 break;
         }
         if (tempo < 0)
         {
             Console.WriteLine("Transporte indisponível");
         }
         else
         {
             Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
         }
 */

        //usando Go to
        // ATENÇÃO: O melhor é usar estrutura de repetições
        int tempo = 0;
        char escolha = ' ';

        inicio: //isso é um labo e posso colocar um go to apontando para ele
        Console.Clear(); //Limpa o console


        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o transporte: [a]Avião | [c]Carro | [o]Ônibus");
        escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
            case 'A': //Caso digite a maiusculo
                tempo = 50;
                break; //da a parada
            case 'c':
            case 'C':
                tempo = 480;
                break;
            case 'o':
            case 'O':

                tempo = 660;
                break;

            default: //caso nenhuma das opções seja a correspondente 
                tempo = -1; //flag para um tempo indefinido
                break;
        }
        if (tempo < 0)
        {
            Console.WriteLine("Transporte indisponível");
        }
        else
        {
            Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
        }

        Console.WriteLine("Calcular outro transporte? [s/n]");
        escolha=char.Parse(Console.ReadLine());
        if (escolha == 's' || escolha == 'S'){
            goto inicio;
        } else {
            Console.Clear();
            Console.WriteLine("FIM DO PROGRAMA");
        }
    }
}