using System;

class Aula010{
    enum DiasSemanas{Domingo,Segunda, Terça, Quarta, Quinta, Sexta, Sábado}; //meu numerados recebe os dias da semana
    //Cada dia refere-se a um indice que inicia em 0
    static void Main(){
        DiasSemanas ds = DiasSemanas.Domingo; //quando dou o . eu vejo os valores que posso usar 
        Console.WriteLine(ds); //Dentro de ds possuo o valor Domingo

    //Posso trabalhar com indece também
    //DiasSemanas ds = 3; //Ocorre um erro pois não consegue converter um int para DiasSemana
    DiasSemanas ds2 = (DiasSemanas)3; //Dessa Forma ele pega o valor pelo indice
        Console.WriteLine(ds2); //Dentro de ds possuo o valor Domingo


    int ds3=(int)DiasSemanas.Sexta;// dessa forma ele pega o indice de sexta
    Console.WriteLine(ds3);
    }
}