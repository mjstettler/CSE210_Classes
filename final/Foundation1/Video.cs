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
    public void SetComment(string aName, string aText)
    {
        _comments.Add(new Comment(aName, aText));
    }
    public void DisplayComments()
    {
        int i= 1;
        foreach (Comment comment in _comments)
        {   
            Console.WriteLine($"{i} - {comment.GetCommentInfo()}");
            i++;
        }
        
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Length of video: {_vidLength}, Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine($"Comments:\n");
        DisplayComments();
    }
}