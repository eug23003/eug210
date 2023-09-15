using System;

public class Job
{
    private string _company;
    private string _jobTitle;
    private int _startYear;
    private int _endYear;

    public string Company
    {
        get { return _company; }
        set { _company = value; }
    }

    public string JobTitle
    {
        get { return _jobTitle; }
        set { _jobTitle = value; }
    }

    public int StartYear
    {
        get { return _startYear; }
        set { _startYear = value; }
    }

    public int EndYear
    {
        get { return _endYear; }
        set { _endYear = value; }
    }

    
    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }

    
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
