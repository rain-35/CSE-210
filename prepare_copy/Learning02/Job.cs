public class Job
{
    public string _jobTitile;
    public string _company;
    public string _startYear;
    public string _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitile} ({_company}) {_startYear}-{_endYear}");
        
    }
}