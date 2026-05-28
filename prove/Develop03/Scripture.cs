public class Scripture
{
    private Reference _rm_reference = new Reference();
    private Passage _rm_passage = new Passage();

    public void RmConstructor(string rmInputPassage, string rmBook)
    {
        _rm_reference.RmConstructor(rmBook);
        _rm_passage.RmPassageBuilder(rmInputPassage);
    }
    
    public string RmToString()
    {
        return $"{_rm_reference.RmToString()} \n{_rm_passage.RmToString()}";
    }

    public bool RmHideWord(int rmWordsToHide)
    {
        bool finished = _rm_passage.RmHideWords(rmWordsToHide);

        return finished;
    }


}