using System;
using System.Globalization;

class program
{
    static void Main(string[] args)
    {
        int cdg1, cdg2, qnt1, qnt2;
        double preço1, preço2, total;

        string[] valores = Console.ReadLine().Split(' ');

        cdg1 = int.Parse(valores[0]);
        qnt1 = int.Parse(valores[1]);
        preço1 = double.Parse(valores[2]);

        valores = Console.ReadLine().Split(' ');

        cdg2 = int.Parse(valores[0]);
        qnt2 = int.Parse(valores[1]);
        preço2 = double.Parse(valores[2]);

        total = preço1 * qnt1 + preço2 * qnt2;

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));

        //////no meu Beecrowd não foi necessario o InvariantCulture por estar em inglês 


    }
}