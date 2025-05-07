using System;

class Aula03{
    static void Main(){
        int num = -10; //declarei uma variável num que recebe -10
        char letra = 'a'; //apostofo ' é para char 
        float valor = 9.8f; //para pontos flutuantes 
        byte n1 = 10; //variavel de 8byts - 0 e 255
        string nome = "Roberto";

        var aux = 10; // não especifiquei o tipo, o var não especifico ele é definido no ato da compilação
        var roberto = nome;

        Console.WriteLine(nome);
        Console.Write(roberto);
        Console.WriteLine(" " + n1 + "..."); //+ Serve para concatenar 

        int num1, num2, soma;

        num1 = 10;
        num2 = 20;
        soma = num1 + num2;

        Console.WriteLine("A soma de " + num1 + " + " + num2 + " é igual a = " + soma);
    }
}