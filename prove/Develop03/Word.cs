class Word
{
    private string _word; // The actual word (private)
    private bool _isHidden; // The visibility state of the word (private)

    // Constructor to initialize the word
    public Word(string word)
    {
        _word = word; // Assign the word
        _isHidden = false; // Start with the word visible
    }

    // Hide the word
    public void Hide()
    {
        _isHidden = true; // Set the visibility state to hidden
    }

    // Display the word (return blanks if hidden)
    public string Display()
    {
        return _isHidden ? "____" : _word; // Show '____' if hidden
    }

    // Check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden; // Return the hidden state
    }
}
