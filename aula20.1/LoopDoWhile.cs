using System;

class aula20
{
    static void Main(string[] args)
    {
        //Do while
        //Eu garanto que pelo menos uma vez os comandos serão executados, com o while eu não tenho essa garantia
        /*
        int num = 5;
        do
        {
            Console.WriteLine("RB cursos") // ele irá imprimir pois será executado pelo menos uma vez , já no while não
            while (num<5); 
        }
        */

        string senha = "123";
        string senhauser;
        int tentativa=0;



        do
        {
            Console.Clear();
            Console.WriteLine("Digite a senha: ");
            senhauser = Console.ReadLine();
            tentativa++;
        } while (senha != senhauser); // se a senha tiver incorreta ela fica em loop

        Console.WriteLine("Senha Correta, tentativas {0}", tentativa);
    }
}