using System;
using System.Globalization;

namespace ExerciciosFixacao
{
    class Program
    {
        #region Exercícios Propostos

        #region Exercício 02

        //static void Main(string[] args)
        //{
        //    double b, a, area, perimetro, diagonal;

        //    b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //    a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //    area = b * a;
        //    perimetro = 2 * (b + a);
        //    diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

        //    Console.WriteLine("Área = " + area.ToString("F4", CultureInfo.InvariantCulture));
        //    Console.WriteLine("Perímetro = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
        //    Console.WriteLine("Diagonal = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

        //    Console.ReadLine();
        //}

        #endregion

        #region Exercício 03
        //static void Main(string[] args)
        //{
        //    string nome1, nome2;
        //    int idade1, idade2;
        //    double media;

        //    string[] vet;

        //    vet = Console.ReadLine().Split(' ');
        //    nome1 = vet[0];
        //    idade1 = int.Parse(vet[1]);
        //    vet = Console.ReadLine().Split(' ');
        //    nome2 = vet[0];
        //    idade2 = int.Parse(vet[1]);

        //    media = (idade1 + idade2) / 2.0;

        //    Console.WriteLine("A idade média de Maria é " + nome1 + " e " + nome2 + " é de " 
        //        + media.ToString("F1", CultureInfo.InvariantCulture) + " anos");

        //    Console.ReadLine();
        //}

        #endregion

        #endregion

        #region URI INICIANTE

        #region URI 1001 - Extremamente Básico
        //static void Main(string[] args)
        //{

        //    int A, B, X;

        //    A = int.Parse(Console.ReadLine());
        //    B = int.Parse(Console.ReadLine());

        //    X = A + B;

        //    Console.WriteLine("X = " + X);
        //}
        #endregion

        #region URI 1002 - Área do Círculo
        //static void Main(string[] args)
        //{
        //    const double n = 3.14159;
        //    double raio, area;

        //    raio = double.Parse(Console.ReadLine());

        //    area = n * Math.Pow(raio, 2);

        //    Console.WriteLine("A=" + area.ToString("F4"));

        //    Console.ReadLine();
        //}
        #endregion

        #region URI 1003 - Soma Simples
        //static void Main(string[] args)
        //{

        //    int A, B, SOMA;

        //    A = int.Parse(Console.ReadLine());
        //    B = int.Parse(Console.ReadLine());

        //    SOMA = A + B;

        //    Console.WriteLine("SOMA = " + SOMA);

        //    Console.ReadLine();
        //}

        #endregion

        #region URI 1004 - Produto Simples
        //static void Main(string[] args)
        //{
        //    int A, B, PROD;

        //    A = int.Parse(Console.ReadLine());
        //    B = int.Parse(Console.ReadLine());

        //    PROD = A * B;

        //    Console.WriteLine("PROD = " + PROD);

        //    Console.ReadLine();
        //}
        #endregion

        #region URI 1005 - Média 1
        //static void Main(string[] args)
        //{
        //    double A, B, MEDIA;

        //    A = double.Parse(Console.ReadLine());
        //    B = double.Parse(Console.ReadLine());

        //    MEDIA = ((A * 3.5) + (B * 7.5)) / 11;

        //    Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));

        //    Console.ReadLine();
        //}
        #endregion

        #region URI 1006 - Média 2
        //static void Main(string[] args)
        //{
        //    double A, B, C, MEDIA;
        //    const double P1 = 2.0;
        //    const double P2 = 3.0;
        //    const double P3 = 5.0;

        //    A = double.Parse(Console.ReadLine());
        //    B = double.Parse(Console.ReadLine());
        //    C = double.Parse(Console.ReadLine());

        //    MEDIA = ((A * P1) + (B * P2) + (C * P3)) / 10.0;

        //    Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));

        //    Console.ReadLine();
        //}

        #endregion

        #region URI 1007 - Diferença
        //static void Main(string[] args)
        //{
        //    int A, B, C, D, DIFERENCA;

        //    A = int.Parse(Console.ReadLine());
        //    B = int.Parse(Console.ReadLine());
        //    C = int.Parse(Console.ReadLine());
        //    D = int.Parse(Console.ReadLine());

        //    DIFERENCA = (A * B) - (C * D);

        //    Console.WriteLine("DIFERENCA = " + DIFERENCA.ToString(CultureInfo.InvariantCulture));

        //    Console.ReadLine();

        //}
        #endregion

        #region URI 1009 - String

        #endregion

        #region URI 1010 - Cálculo Simples
        //static void Main(string[] args)
        //{
        //    int codPeca1, numPeca1, codPeca2, numPeca2;
        //    double valor1, valor2, totalPeca1, totalPeca2, totalGeral;

        //    string[] peca1 = Console.ReadLine().Split(' ');
        //    string[] peca2 = Console.ReadLine().Split(' ');

        //    codPeca1 =  int.Parse(peca1[0]);
        //    numPeca1 =  int.Parse(peca1[1]);
        //    valor1 =  double.Parse(peca1[2]);

        //    codPeca2 = int.Parse(peca2[0]);
        //    numPeca2 = int.Parse(peca2[1]);
        //    valor2 = double.Parse(peca2[2]);

        //    totalPeca1 = numPeca1 * valor1;
        //    totalPeca2 = numPeca2 * valor2;

        //    totalGeral = totalPeca1 + totalPeca2;

        //    Console.WriteLine("VALOR A PAGAR: R$ " + totalGeral.ToString("F2"));

        //    Console.ReadLine();
        //}
        #endregion

        #region URI 1011 - Casting

        #endregion

        #region URI 1012 - Geometria

        #endregion

        #region URI 1013 - Abs

        #endregion

        #region URI 1014 - Consumo
        //static void Main(string[] args)
        //{
        //    double Y, Z;
        //    int X;

        //    X = int.Parse(Console.ReadLine());
        //    Y = double.Parse(Console.ReadLine());

        //    Z = X / Y;

        //    Console.WriteLine(Z.ToString("F3") + " km/l");

        //    Console.ReadLine();
        //}
        #endregion

        #region URI 1015 - Sqrt, Pow

        #endregion

        #region URI 1016 - Distância
        //static void Main(string[] args)
        //{
        //    int distancia, tempo;

        //    distancia = int.Parse(Console.ReadLine());

        //    tempo = distancia * 2;

        //    Console.WriteLine(tempo + " minutos");

        //    Console.ReadLine();
        //}
        #endregion

        #region URI 1017 - Gasto de Combustível
        //static void Main(string[] args)
        //{
        //    const int c = 12;
        //    int t, vm;
        //    double s;

        //    t = int.Parse(Console.ReadLine());
        //    vm = int.Parse(Console.ReadLine());

        //    s = (double)(t * vm) / c;

        //    Console.WriteLine(s.ToString("F3", CultureInfo.InvariantCulture));

        //    Console.ReadLine();
        //}
        #endregion

        #endregion
    }
}
