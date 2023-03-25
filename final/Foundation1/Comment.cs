using System;

public class Comment
{
    private string _name;
    private string _commentText;

    public Comment(string aName, string aText)
    {
        _name = aName;
        _commentText = aText;
    }

    public string GetCommentInfo()
    {
        return $"Commenter Name: {_name}. Comment: {_commentText}";
    }
}