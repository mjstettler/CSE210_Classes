using System;

public class Video
{
    List<Comment> _comments;
    string _title;
    string _author;
    double _vidLength;

    public Video(string aTitle, string aAuthor, double aSeconds)
    {
        _title = aTitle;
        _author = aAuthor;
        _vidLength = aSeconds;

        _comments = new List<Comment>();
    }
    public Video()
    {
        
    }
    public int GetNumberOfComments()
    {
        return _comments.Count();
    }
}