namespace BuurtLabWebAPI;
using BuurtLabWebAPI;

public class Player : User
{
    public int Score { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public string Team { get; set; }

    public Player(string name, double password, string email, string adres, string number, int score, int age, string position, string team, bool isAdmin)
        : base(name, password, email, adres, number)
    {
        Score = score;
        Age = age;
        Position = position;
        Team = team;
        IsAdmin = isAdmin;
    }



}
