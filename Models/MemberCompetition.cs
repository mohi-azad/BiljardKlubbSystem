
public class MemberCompetition 
{ 
    public int MemberID { get; set; }
    public int TournamentID { get; set; }
    public int? Result {  get; set; }

    public MemberCompetition(int memberID,  int tournamentID, int? result)
    {
        MemberID = memberID;
        TournamentID = tournamentID;
        Result = result;
    }

}
