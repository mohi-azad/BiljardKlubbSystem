public class Tournament
{
    public int TournamentID { get; set; }
    public string Type { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public Tournament()
    {
        Type = "";
        Date = DateTime.Today;
        StartTime = new TimeSpan();
    }
    public Tournament(int tournamentID, string type,DateTime date,TimeSpan startTime)
    {
        TournamentID = tournamentID;
        Type = type;
        Date = date;
        StartTime = startTime;
    }
}
