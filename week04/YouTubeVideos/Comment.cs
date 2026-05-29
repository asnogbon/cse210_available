using System;

public class Comment
{
    private string _Name;
    private string _Text;
    int count = 0;

    public string _GetComment(string commented)
    {
        string[] Parts = commented.Split(':');
        count ++;
        _Name = Parts[0];
        _Text = Parts[1];

        return $"User {_Name} : said \"{_Text}\"";
    }
    

}
