using System.IO; 
public class Journal {

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        //This adds the entries to the list of entries
        _entries.Add(newEntry);
    }
    
    public void DisplayAll()
    {
        //displays all the entries in the journal to the console
        foreach (Entry diary in _entries)
        {
            diary.Display();
            Console.WriteLine("");
        
        }
    }

    public void SaveToFile(string file)
    {
        //This saves all the prompts that have been written to a csv file
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry diary in _entries)
            {
                outputFile.WriteLine($"{diary._date} | {diary._prompt} | {diary._diary}");
            }
        }
        

    }

    public void LoadFromFile(string file)
    {
        //This replaces all the entries in the _entries list with the ones from a saved file
        _entries.Clear();
        
        string[] lines = System.IO.File.ReadAllLines(file);


        foreach (String diary in lines)
        {
            string[] parts = diary.Split("|"); 

            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            Entry entry2 = new Entry();
            entry2._date = date;
            entry2._prompt = prompt;
            entry2._diary = entry;

            _entries.Add(entry2);


        }
    }


}