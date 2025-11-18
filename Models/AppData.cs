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
        public static List<MemberCompetition> MemberCompetition = new List<MemberCompetition>()
        {
            new MemberCompetition("Mohsen", "Azad", 1000, "8-boll"),  
            new MemberCompetition("Jona", "Simonsson", 3000, "9-boll"),  
            new MemberCompetition("Alex", "Lundberg", 2000, "10-boll")
        };
    }
}
