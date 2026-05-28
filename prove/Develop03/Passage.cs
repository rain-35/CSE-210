
public class Passage
{
    private List<Word> _rm_words = new List<Word>();
    private int wordsHidden = 0;

    public void RmPassageBuilder(string rmInputPassage)
    {
        List<string> rmSplitPassage = new List<string>(rmInputPassage.Split(" "));

         foreach (string word in rmSplitPassage)
         {
            Word newWord = new Word();
            newWord.RmWordBuilder(word);
            _rm_words.Add(newWord);
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

    public bool RmHideWords(int rmWordsToHide)
    {
        int i = 0;
        bool checkHidden = false;
        while (i < rmWordsToHide)
        {
            int rmIndexToHide = new Random().Next(0, _rm_words.Count);
            checkHidden = _rm_words[rmIndexToHide].RmHideWord();
            if (checkHidden == true)
            {
                wordsHidden++;
                i++;
            }
            if (wordsHidden >= _rm_words.Count)
            {
                //return true for failed and done
                return true;
                
            }
        }
        return false;
    }


}