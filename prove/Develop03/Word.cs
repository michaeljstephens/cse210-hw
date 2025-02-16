class Word
{
    private string _text;
    private bool _isHid;

    public Word(string text)
    {
        _text = text;
        _isHid = false;
    }

    public void Hide()
    {
        _isHid = true;
    }

    public bool IsHid()
    {
        return _isHid;
    }

    public override string ToString()
    {
        if (_isHid)
        {
            return "_____";
        }
        return _text;
    }
}