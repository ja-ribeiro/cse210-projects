class Reference
{

    // encapsulamento, aqui ira armazenar esses dados
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    // aqui tem dois construtores, um com apenas um versiculo e outro para mais de um
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // aqui vai retornar ja formatado, entao a classe scripture nao precisa como funciona

    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return _book + " " + _chapter + ":" + _verse;
        }
        else
        {
            return _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
        }
    }
}
