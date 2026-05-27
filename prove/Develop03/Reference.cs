public class Reference
{
    private string _rm_book;
    private int _rm_chapter;
    private int _rm_startVerse;
    private int _rm_endVerse;

    // Parse a reference like "John 3:16-17" or "John 3:16"
    public void RmConstructor(string rmReference)
    {
        if (string.IsNullOrWhiteSpace(rmReference))
        {
            Console.WriteLine("Invalid book, chapter, start verse, or end verse.");
            return;
        }

        var rmParts = rmReference.Split(new[] { ' ' });
        _rm_book = rmParts[0];

        var rmChapParts = rmParts[1].Split(':');
       _rm_chapter = 0;

        var rmVersePart = rmChapParts[1];
        if (rmVersePart.Contains('-'))
        {
            var rmVerse = rmVersePart.Split(new[] { '-' }, 2);
            _rm_startVerse = int.Parse(rmVerse[0]);
            _rm_endVerse = int.Parse(rmVerse[1]);
        }
        else
        {
            _rm_startVerse = int.Parse(rmVersePart);
            _rm_endVerse = 0;
        }
        
    }

    public string RmToString()
    {
        if (_rm_endVerse == 0)
        {
            return $"{_rm_book} {_rm_chapter}:{_rm_startVerse}";
        }
        else
        {
            return $"{_rm_book} {_rm_chapter}:{_rm_startVerse}-{_rm_endVerse}";
        }
    }



}