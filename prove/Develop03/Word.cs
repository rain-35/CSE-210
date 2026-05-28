

public class Word
{
    private string _rm_text;
    private bool _rm_isHidden;

    public void RmWordBuilder(string rmInputWord)
    {
        if (rmInputWord != null)
        {
            _rm_text = rmInputWord;
            _rm_isHidden = false;
        }
        else
        {
            Console.WriteLine("word received is null");
        }
    }

    public bool RmHideWord()
    {
        if (_rm_isHidden == true)
        {
            // if it was already hidden return false for didnt work
            return false;
        }
        else
        {
            _rm_isHidden = true;
            return true;
        }        
    }

    public string RmToString()
    {
        if (_rm_isHidden)
        {
            return ("___");
        }
        else
        {
            return _rm_text;
        }
    }
}