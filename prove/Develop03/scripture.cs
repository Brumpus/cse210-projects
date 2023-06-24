public class Scripture
{
    
    private Reference _reference = new Reference(); 

    private List<Word> _words = new List<Word>();
    private int unhiddenWords = 0;
    
    public void HideRandomWords()
    {   
        unhiddenWords = _words.Count();
        foreach(Word word in _words)
        {   
            
            if(word.IsHidden() == false)
            {
                
                Random randomGenerator2 = new Random();
                int wordPicker = randomGenerator2.Next(0,20);
                if (wordPicker >= 10)
                {
                    word.Hide();

                }
             
            }
            if(word.IsHidden() == true)
            {
                unhiddenWords -= 1;
            }
        }

        
        // Random randomGenerator = new Random();
        // int wordHider = randomGenerator.Next(1,unhiddenWords);
        // for(int s = 0; s <= wordHider; s+=1)
        // {   
            
        //     Random randomGenerator2 = new Random();
        //     int wordPicker = randomGenerator2.Next(0,unhiddenWords);
        //     Word word2 = _words[wordPicker];
        //     if(word2.IsHidden() == false)
        //     {
        //         word2.Hide();
        //     }
        //     else
        //     {
                
        //     }
            
            
           

        // } 
        
        

    }

    public string GetDisplayText()
    {
        string referenceText =  _reference.GetDisplayText();
        string verse = "";
        foreach (Word word in _words)
        {
            string newWord = word.GetDisplayText();
            verse = verse + newWord;
        }
        string fullScripture = ($"{referenceText} - {verse}");
        return fullScripture;
    }

    public bool IsCompletelyHidden()
    {
        if(unhiddenWords == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
        

    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split();
        foreach(string word in words)
        {
            string word1 = ($"{word} ");
            Word word2 = new Word(word1);
            
            _words.Add(word2);
        }

    }
}

