using System;

class Aula04{

    static int num = 10; // dentro dos metodos não pode existir um variavel com esse mesmo nome, pois ela tem esopo global
    static void Main(){
        int num2 = 0; 
        Console.WriteLine(num); // se eu tirar o static ele não funciona 
    }

}