public class Prompt {

    public List<string> _prompts = new List<string>();
    //This is the list of prompts used
    
    
    public string GetRandomPrompt()
    {   
        //Generates a random prompt to use in the journal entry
        Random randomGenerator = new Random();
        int promptNumber = randomGenerator.Next(0, 4);

        _prompts.Add("Did you see any cool bugs today?");
        _prompts.Add("Did you go anywhere today?");
        _prompts.Add("What emotions did you feel the most today?");
        _prompts.Add("What was your favorite song that you heard today?");
        _prompts.Add("Is there anything that you wanted to do today but didn't?");

        string prompt = _prompts[promptNumber];
        
        return prompt;

    }
}