using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
    
    Fraction f1 = new Fraction(); //aqui esta criando uma fracao usando o construtor vazio
    Console.WriteLine(f1.GetFractionString());
    Console.WriteLine(f1.GetDecimalValue());

    Fraction f2 = new Fraction(5); //aqui ele ira usar o construtor com um parametro de numero inteiro
    Console.WriteLine(f2.GetFractionString());
    Console.WriteLine(f2.GetDecimalValue());

    Fraction f3 = new Fraction(3, 4);  //aqui ja pega o construtor com dois parametros
    Console.WriteLine(f3.GetFractionString());
    Console.WriteLine(f3.GetDecimalValue());

    Fraction f4 = new Fraction(1, 3);
    Console.WriteLine(f4.GetFractionString());
    Console.WriteLine(f4.GetDecimalValue());
    }
}