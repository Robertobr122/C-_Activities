using System;

class Aula19{
    static void Main(string[] args){
        int [] num=new int[10];

        for(int i=0; i < 10; i++){ //se eu colocar 11 na validação ele vai dar erro, pois o n indice estará fora dos limites da matriz, para evitar esse erro podemos usar num.length
            num[i]= 0;
            Console.WriteLine("valor de num na pos{0}: {1}",i,num[i]);
        }
    }
}