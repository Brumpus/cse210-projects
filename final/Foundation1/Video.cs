public class Video{
    private string _author;
    private string _title;
    private float _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string author, float length, string title){
        _author = author;
        _length = length;
        _title = title;
    }
    public void GetVideoComments(){
        foreach(Comment comment in _comments){
            string commentDisplay = comment.GetComment();
            Console.WriteLine(commentDisplay);
        }
    }
    public void DisplayVideo(){
        int comments = GetCommentCount();
        Console.WriteLine($"{_author} | {_title} | {_length} | Comments : {comments}");
        
        GetVideoComments();

    }
    public int GetCommentCount(){
        int commentNumber = _comments.Count();
        return commentNumber;
    }
}