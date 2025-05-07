using System;

class Aula7{
    static void Main(){
        const string canal = "RBraga cursos"; //não é uma variavel mas sim uma constante
        const double pi = 3.1415;

        //canal ="Roberto"; ---- Ele da um erro pois constante não se altera ao longo do programa

        Console.WriteLine("Canal {0}\nPi: {1}", canal, pi);
    }
}