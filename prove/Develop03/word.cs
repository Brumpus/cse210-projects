public class Word
{
    private string _text = "";
    private bool _isHidden = false;

    public Word(string content)
    {
        _text = (content);
    }

   public void Hide()
   {
     _isHidden = true;
   }

   public void Show()
   {
    _isHidden = false;
   }

   public bool IsHidden()
   {
    return _isHidden;
   }

   public string GetDisplayText()
   {
    if (IsHidden() == true)
    {
        string hiddenWord = "";
        int helpMe = _text.Count() - 1;
        for(int i = 0; i < helpMe; i++)
        {
            
            hiddenWord = hiddenWord + "_";
        }
        hiddenWord = ($"{hiddenWord} ");
        

        return hiddenWord;
    }
    else
    {
        return _text;
    }
   }
}