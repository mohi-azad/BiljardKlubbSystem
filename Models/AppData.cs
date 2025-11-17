namespace Laboration_2.Models
{
    public class AppData
    {
        public static List<Member> Members = new List<Member>()
        {
            new Member(1, "Mohsen", "Azad", 26, 1000),
            new Member(2, "Alex", "Lundberg", 32, 2000),
            new Member(3, "Jona", "Simonsson", 19, 3000)
        };

        public static List<Tournament> Tournaments = new List<Tournament>()
        {
            new Tournament(1, "8-boll", new DateTime(2025,11,16), new TimeSpan(17, 0,0)),
            new Tournament(2, "9-boll", new DateTime(2025,11,20), new TimeSpan(18,0,0)),
            new Tournament(3, "10-boll", new DateTime(2025,11,24), new TimeSpan(18,0,0))
        };
        public static List<MemberCompetition> MemberCompetitions = new List<MemberCompetition>()
        {
            new MemberCompetition(1, 1, 100),  
            new MemberCompetition(2, 2, 200),  
            new MemberCompetition(3, 3, 150),  
            new MemberCompetition(1, 2, 180)
        };
    }
}
