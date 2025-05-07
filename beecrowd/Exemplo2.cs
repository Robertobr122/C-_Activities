/*
Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta 
operação à variável PROD. A seguir mostre a variável PROD com mensagem correspondente.   

Entrada
O arquivo de entrada contém 2 valores inteiros.

Saída
Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco 
antes e depois da igualdade. Não esqueça de imprimir o fim de linha após o produto, caso contrário 
seu programa apresentará a mensagem: “Presentation Error”.
*/

using System;

class Exemplo02{
    static void Main(){
        Console.WriteLine("Digite o 1º número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o 2º número: ");
        int num2 = int.Parse(Console.ReadLine());

        int PROD = num1 * num2;

        Console.WriteLine("PROD = {0}", PROD);
    }
}