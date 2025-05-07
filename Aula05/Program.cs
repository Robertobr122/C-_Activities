using System;

class Aula5{
    static void Main(){
        int res = (10+5)*2; // Operador + (soma), * operador de multiplicação

        bool res2 = 10<5; //operador relacional <, mas temos também, >, <= , != , recebe verdadeiro ou falso 
        
        //operador de incremento e decremento
        int num = 10; 

        num = num+1;
        num +=1; //ele resume a operação acima 
        num++; //ele resume ainda mais

        // temos os operadores lógicos - & = AND ; | = OR ; 

        bool res3 = (5>7) | (10<11);
        bool res4 = (5>7) & (10<11);


        Console.WriteLine(res + " " + res2 + " " + num + " " + res3 + " " + res4);

    }
}