class Scripture
{
    // essa classe que ira juntar a referencia com a palavra e controlar a ocultacao
    // lembre uma escritura tem uma referencia, mas uma escritura tem muitas palavras

    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text) // split text into words
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] splitWords = text.Split(" ");
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide) //only visivle words, chosse ramdom word 
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        string text = "";

        for (int i = 0; i < _words.Count; i++)
        {
            text += _words[i].GetDisplayText();

            if (i < _words.Count - 1)
            {
                text += " ";
            }
        }

        return _reference.GetDisplayText() + "\n" + text;
    }
}
