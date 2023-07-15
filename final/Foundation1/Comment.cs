public class Comment{
    private string _user;
    private string _text;
    public string GetComment(){
        string comment = ($"     {_user} | {_text}");
        return comment;
    }

    public Comment(string user, string text){
        _user = user;
        _text = text;
    }
}