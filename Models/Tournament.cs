// Klassen Tournament
using Laboration_2.Models;

public class Tournament
{
    public int TournamentID { get; set; }
    public string TournamentType { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public Tournament()
    {
        TournamentType = "";
        Date = DateTime.Today;
        StartTime = new TimeSpan();
    }
    public Tournament(int tournamentID, string tournamentType, DateTime date,TimeSpan startTime)
    {
        TournamentID = tournamentID;
        TournamentType = tournamentType;
        StartTime = startTime;
    }
}
