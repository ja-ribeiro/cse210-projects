using System;

public class Fraction   //aqui esta criando uma classe publica e serve p/ criar objetos
{
    private int _top;
    private int _bottom;

    public Fraction()   //e esse seria um construtor, que seria tipo um metodo (acho?)
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)  //outro construtor
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()  //cria uma string mas nao e salva... ira criar toda vez que chamar o metodo
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()  // aqui ira converter o valor decimal
    {
        return (double)_top / (double)_bottom;
    }
}