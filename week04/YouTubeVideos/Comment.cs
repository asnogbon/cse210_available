using System;

public class Comment
{
    private string _name;
    private string _text;

    public Comment(string commented)
    {
        string[] parts = commented.Split(':', 2);
        _name = parts[0].Trim();
        _text = parts.Length > 1 ? parts[1].Trim() : string.Empty;
    }

    public override string ToString()
    {
        return $"User {_name} : said \"{_text}\"";
    }
}
