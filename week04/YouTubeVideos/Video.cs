using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, string time, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = ParseLength(time);
        _comments = comments ?? new List<Comment>();
    }

    public string GetVideo()
    {
        return $"{_title},{_author},{_length}";
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public IReadOnlyList<Comment> GetComments()
    {
        return _comments.AsReadOnly();
    }

    private int ParseLength(string time)
    {
        string[] timeParts = time.Split(':');

        if (timeParts.Length == 3)
        {
            int hours = int.Parse(timeParts[0]);
            int minutes = int.Parse(timeParts[1]);
            int seconds = int.Parse(timeParts[2]);
            return hours * 3600 + minutes * 60 + seconds;
        }
        else if (timeParts.Length == 2)
        {
            int minutes = int.Parse(timeParts[0]);
            int seconds = int.Parse(timeParts[1]);
            return minutes * 60 + seconds;
        }
        else if (timeParts.Length == 1)
        {
            return int.Parse(timeParts[0]);
        }

        return 0;
    }
}
