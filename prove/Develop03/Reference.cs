class Reference
{
    private string _book;        // Book name (private)
    private int _chapter;        // Chapter number (private)
    private int _verseStart;     // Starting verse (private)
    private int _verseEnd;       // Ending verse (private)

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _verseEnd = verse; // Set verseEnd to the same value for single verses
    }

    // Constructor for a verse range
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    // Override the ToString method to format the reference nicely
    public override string ToString()
    {
        if (_verseStart == _verseEnd)
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
    }
}
