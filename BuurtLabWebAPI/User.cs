namespace BuurtLabWebAPI;

public class User
{
    public string Name { get; set; }
    public double Password { get; set; }
    public string Email { get; set; }
    public string Adres { get; set; }
    public string Number { get; set; }

    public bool IsAdmin { get; set; }


    public User(string name, double password, string email, string adres, string number)
    {
            Name = name;
            Password = password;
            Email = email;
            Adres = adres;
            Number = number;
    }

      

}
