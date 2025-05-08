using System;
class Aula17
{
    static void Main(string[] args)
    {
        /*
        //int n1, n2, n3, n4, n5;
        int[] n = new int[5]; //Estou criando um array do tipo inteiro, ao qual informo o tamanho do meu array com 5 elementos
        int[] num = new int[3] { 55, 77, 99 }; //outra forma de criar array, dessa maneira já declarei meu array e iniciei com valores. Se eu tentar atribuir mais de 3 dará um erro
        int[] num2 = { 66, 88, 22 };// dessa forma eu atribuo diretamente, esse formato já deixa o tamanho do array o numero de elementos utilizado
        string[] veiculos = new string[3]; //array de string

        veiculos[0] = "carro";
        veiculos[1] = "avião";
        veiculos[2] = "Navio";

        //armazenando valores com os indices
        n[0] = 111;
        n[1] = 222;
        n[2] = 333;
        n[3] = 444;
        n[4] = 555;

        //imprimindo valores do array
        Console.WriteLine(n[0]);
        Console.WriteLine(num[1]);
        Console.WriteLine(num2[2]);
        Console.WriteLine(veiculos[0]);
        */

        //Array Bidimensional / Matriz
        int[,] n = new int[3, 5]; //temos dois indices. nesse caso tenho 3 linhas e 5 colinas 
        /*
        Esse é o exemplo de matriz que iremos construir
        1ª linhas - 10, 20, 30, 40, 50
        2ª linhas - 60, 70, 80, 90, 15
        3ª linhas - 25, 35, 45, 55, 65
        */

        //Cadastrando valores a Matriz
        n[0, 0] = 10;
        n[0, 1] = 20;
        n[0, 2] = 30;
        n[0, 3] = 40;
        n[0, 4] = 50;

        n[1, 0] = 60;
        n[1, 1] = 70;
        n[1, 2] = 80;
        n[1, 3] = 90;
        n[1, 4] = 15;

        n[2, 0] = 25;
        n[2, 1] = 35;
        n[2, 2] = 45;
        n[2, 3] = 55;
        n[2, 4] = 65;

        Console.WriteLine(n[1,1]);
        Console.WriteLine(n[2,1]);

        int [,] num=new int[2,2]{{10,20}, {30,40}}; // podemos fazer dessa forma para criarmos matriz também

    }
}