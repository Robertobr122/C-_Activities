#nullable disable
using System;

class Aula8{
    static void Main(){
        int num1,num2, soma;
        string nome;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine(); //temos read e readLine(quebrar a linha), para ler o que foi lido no teclado
        Console.WriteLine("Nome digitado: {0}", nome);

        Console.WriteLine("Digite o primeiro valor");
        num1 = int.Parse(Console.ReadLine()); // Preciso converter para inteiro se não da erro, pois ele retorna uma string 
        Console.WriteLine("Digite o segundo valor");
        //num2 = Console.ReadLine(); // Preciso converter para inteiro se não da erro, pois ele retorna uma string 
        num2 = Convert.ToInt32(Console.ReadLine()); //serve para converter o que vem como parametro para inteiro também 
        soma = num1 + num2;
        Console.WriteLine("A soma de {0} + {1} é igual a {2}", num1,num2,soma);


    }
}