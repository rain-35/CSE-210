public class Reference
{
    private string _rm_book;
    private int _rm_chapter;
    private int _rm_startVerse;
    private int _rm_endVerse;

    public void RmConstructor(string rmBook, int rmChapter, int rmStartVerse, int rmEndVerse)
    {
        if (rmBook != null && rmChapter > 0 && rmStartVerse > 0 && rmEndVerse >= 0)
        {
            _rm_book = rmBook;
            _rm_chapter = rmChapter;
            _rm_startVerse = rmStartVerse;
            _rm_endVerse = rmEndVerse;
        }
        else
        {
            Console.WriteLine("Invalid book, chapter, start verse, or end verse.");
        }
    }

    public string RmToString()
    {
        if (_rm_endVerse == 0)
        {
            return $"{_rm_book} {_rm_chapter}:{_rm_startVerse} ";
        }
        else
        {
            return $"{_rm_book} {_rm_chapter}:{_rm_startVerse}-{_rm_endVerse} ";
        }
    }



}