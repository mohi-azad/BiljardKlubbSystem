
public class MemberCompetition
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? Score { get; set; }
    public string TournamentType { get; set; }

    public MemberCompetition(string firstName, string lastName, int? score, string tournamentType)
    {
        FirstName = firstName;
        LastName = lastName;
        Score = score;
        TournamentType = tournamentType;
    }
}

