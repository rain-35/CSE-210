
public class Passage
{
    private List<Word> _rm_words = new List<Word>();

    public void RmPassageBuilder(string rmInputPassage)
    {
         foreach (string word in rmInputPassage.Split(" "))
         {
            Word newWord = new Word();
            newWord.RmWordBuilder(word);
            _rm_words.Add(new Word());
        }
    }
    
    public string RmToString()
    {
        string rmPassage = "";
        foreach (Word word in _rm_words)
        {
            rmPassage += word.RmToString() + " ";
        }
        return rmPassage;
    }

}