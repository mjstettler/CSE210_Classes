using System;

public class Comment
{
    string _name;
    string _commentText;

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