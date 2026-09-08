namespace BuurtLabWebAPI;

public class Parents : Player
{
    public string NameParent { get; set; }
    public string NumberParent { get; set; }

    public string NameChild { get; set; }

    public Parents(string name, double password, string email, string adres, string number, int score, int age, string position, string team, bool isAdmin, string nameParent, string numberParent, string nameChild, string id)
        : base(name, password, email, adres, number, score, age, position, team, isAdmin, id)
    {
        NameParent = nameParent;
        NumberParent = numberParent;
        NameChild = nameChild;
    }

}
