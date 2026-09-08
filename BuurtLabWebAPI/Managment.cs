namespace BuurtLabWebAPI;

public class Managment: User
{
    public string winner { get; set; }
    public string loser { get; set; }

    public Managment(string winner, string loser, string name, double password, string email, string adres, string number, bool isAdmin, string id)
        : base(name, password, email, adres, number, isAdmin, id)
    {
        this.winner = winner;
        this.loser = loser;
    }
}
