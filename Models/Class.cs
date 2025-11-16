public class Member
{
    public int MemberID { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public int Age { get; set; }
    public int Score { get; set; }
    public Member()
    {
        FirstName = "";
        LastName = "";
        Age = 0;
        Score = 0;
    }
    public Member(int memberID, String firstName, String lastName, int age, int score)
    {
        MemberID = memberID;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Score = score;
    }
}
