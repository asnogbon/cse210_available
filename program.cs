using System;
class Program
{
    public List<entries> _entries;

    public void AddEntry(Entry newEntry)
    {

    }

    public void DisplayAll()
    {

    }
    public void LoadFromFile(file:string)
    {

    }
    public void SaveToFile(file:string)
    {
        Console.WriteLine("");

        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }


       


}
