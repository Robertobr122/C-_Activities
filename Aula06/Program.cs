using System;

class Aula6
{
    static void Main()
    {
        int n1, n2, n3;

        n1 = 10;
        n2 = 30;
        n3 = 4;

        Console.WriteLine(n1 + ", " + n2 + ", " + n3); //forma tradicional 

        Console.WriteLine("n1={0}, n2={1}, n3={2}", n1, n2, n3); //dessa maneira eu trabalho com indices

        Console.WriteLine("n1={0}\nn2={1}\nn3={2}", n1, n2, n3); //\n é um caractere de escape ao qual da a quebra de linha

        Console.WriteLine("n1={0}\tn2={1}\tn3={2}", n1, n2, n3); //\n é um caractere de escape da uma tabulação

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "pastel";

        valorVenda=valorCompra+(valorCompra*lucro);

        Console.WriteLine("Produto.........: {0,15}", produto); // 15 é o tamanho do espaço
        Console.WriteLine("Val.Compra......: {0,15:c}", valorCompra); //c é o formato monetário
        Console.WriteLine("Lucro...........: {0,15:p}", lucro); //p é o formato de porcentagem
        Console.WriteLine("Val.Venda.......: {0,15:c}", valorVenda); //c é o formato monetário


    }
}