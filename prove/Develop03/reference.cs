public class Reference
{
    private string _book = "";
    private int _chapter = 0;
    private int _verse = 0;
    private int _endVerse = 0;

    public string GetDisplayText()
    {
        if(_endVerse != 0)
        {
            string reference1 = $"{_book} {_chapter}:{_verse}-{_endVerse}";
            return reference1;
        }
        else 
        {
            string reference1 = $"{_book} {_chapter}:{_verse}";
            return reference1;
        }
         
        
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _verse = verse;
        _chapter = chapter;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    public Reference()
    {
        _book = "";
    }
}