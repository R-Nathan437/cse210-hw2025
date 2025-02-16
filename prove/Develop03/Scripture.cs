using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry()
    {
        Entry newEntry = new Entry();
        newEntry.GenerateDate();
        newEntry.GeneratePrompt();
        newEntry.GetText();
        _entries.Add(newEntry);
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine(entry._prompt);
            Console.WriteLine(entry._text);
            Console.WriteLine();
        }
    }
    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._prompt);
                outputFile.WriteLine(entry._text);
            }
        }

    }
    public void Clear(string clearFilename)
    {
        using (StreamWriter outputFile = File.CreateText(clearFilename))
        {
            outputFile.Write(string.Empty);
        }
    }
    public void Load(string loadfilename)
    {
        if (loadfilename.EndsWith(".csv"))
        {
            string[] lines = System.IO.File.ReadAllLines(loadfilename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string date = parts[0];
                string prompt = parts[1];
                string text = parts[2];
                Console.WriteLine($"Date: {date}");
                Console.WriteLine(prompt);
                Console.WriteLine(text);
                Console.WriteLine();
            
            }
        }
        else
        {
            using (StreamReader reader = new StreamReader(loadfilename))
            {
                string journalEntries = reader.ReadToEnd();
                Console.Write(journalEntries);
            }
        }
    }
}


////Journal
///add entry method
///display method
///save method
///load method
///menu <list>