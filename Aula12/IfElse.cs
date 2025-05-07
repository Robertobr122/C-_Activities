#nullable disable
using System;

class Aula12
{
    static void Main()
    {
        /*
        //if é o mesmo que Se a expressão lógica for verdadeiro ele executa
        int nota1, nota2, nota3, nota4, media;
        nota1 = nota2 = nota3 = nota4 = media = 0;
        string resultado = "Reprovado";

        Console.WriteLine("Digite a nota 1 do aluno: ");
        nota1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 2 do aluno: ");
        nota2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 3 do aluno: ");
        nota3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 4 do aluno: ");
        nota4 = int.Parse(Console.ReadLine());

        media = (nota1 + nota2 + nota3 + nota4) / 4;
        Console.WriteLine("A média do aluno foi {0}", media);

        if (media >= 60)
        {
            resultado = "Aprovado!";
        }

        Console.WriteLine("Resultado: {0}", resultado);
        */


        /*
        //usando comando else:
        //else é o caso contrario do if, se não for verdadeiro a condição logica 
        int nota1, nota2, nota3, nota4, media;
        nota1 = nota2 = nota3 = nota4 = media = 0;
        string resultado;

        Console.WriteLine("Digite a nota 1 do aluno: ");
        nota1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 2 do aluno: ");
        nota2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 3 do aluno: ");
        nota3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 4 do aluno: ");
        nota4 = int.Parse(Console.ReadLine());

        media = (nota1 + nota2 + nota3 + nota4) / 4;

        if (media < 40)
        {
            resultado = "Reprovado!";
        } 
        else if(media < 60){
            resultado = "Recuperação!";
        }
        else{
            resultado = "Aprovado!";
        }

        Console.WriteLine("media: {1} -- Resultado: {0}", resultado, media);

*/

        //if aninhado, é quando temos um if dentro do outro

        int nota1, nota2, nota3, nota4, media;
        nota1 = nota2 = nota3 = nota4 = media = 0;
        string resultado;

        Console.WriteLine("Digite a nota 1 do aluno: ");
        nota1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 2 do aluno: ");
        nota2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 3 do aluno: ");
        nota3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 4 do aluno: ");
        nota4 = int.Parse(Console.ReadLine());

        media = (nota1 + nota2 + nota3 + nota4) / 4;

        if (media >=60)
        {
            if(media >= 90){
                if(media>=99){
                    resultado= "Aprovado com Super Louvor";
                }else{
                resultado = "Aprovado com louvor";
                }
            }else {
                resultado = "Aprovado";
            }
        }
        else{
            if (media >= 40){
                resultado ="Recuperação";
            } else{
                resultado ="Reprovado";
            }
        }

        Console.WriteLine("media: {1} -- Resultado: {0}", resultado, media);
    }
}