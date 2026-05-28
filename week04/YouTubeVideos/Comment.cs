using System;

public class Comment
{
    private string Name;
    private string Text;
    int count = 0;

    public string GetComment(string commented)
    {
        string[] Parts = commented.Split(':');
        count ++;
        Name = Parts[0];
        Text = Parts[1];

        return $"User {Name} : said \"{Text}\"";
    }
    public string GetCount(string commented)
    {
        return $"This video has {count} comments.";
    }

}
