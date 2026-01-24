class Word
{
    private string _text;
    private bool _isHidden;

    //primeiro construtor ire receber a palavra e ira comecar visivel
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide() //metodo
    {
        _isHidden = true;  //isso ira esconder a palavra
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText() //aqui decide se esconde ou nao
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}
