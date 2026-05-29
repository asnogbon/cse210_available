using System;
public class Video
{
    private string Title;
    private string Author;
    private int Length;
    public string _GetVideo(string title)
    {
        string[] titleParts = title.Split(',');
        Title = titleParts[0];
        Author = titleParts[1];
        string tt = _getLength(titleParts[2]);
        Length = int.Parse(tt);
        return $"{Title},{Author},{Length}";
    }

    public string _getLength(string time)
    {
        string[] timeParts = time.Split(':');

        if (timeParts.Length == 3)
        {
            int hours = int.Parse(timeParts[0]);
            int minutes = int.Parse(timeParts[1]);
            int seconds = int.Parse(timeParts[2]);
            int totalSeconds = hours * 3600 + minutes * 60 + seconds;
            return totalSeconds.ToString();
        }
        else if (timeParts.Length == 2)
        {
            int minutes = int.Parse(timeParts[0]);
            int seconds = int.Parse(timeParts[1]);
            int totalSeconds = minutes * 60 + seconds;
            return totalSeconds.ToString();
        }
        else if (timeParts.Length == 1)
        {
            int seconds = int.Parse(timeParts[0]);
            return seconds.ToString();
        }

        return "0";
    }

}
