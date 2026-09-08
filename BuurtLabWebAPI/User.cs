namespace BuurtLabWebAPI;

public class User
{
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Adres { get; set; }
    public string Number { get; set; }
    public string Id { get; set; }
    public string CarteNumber { get; set; }
    public int  Age { get; set; }
    public int Payment { get; set; }
    public bool IsTrainer { get; set; }
    public bool IsAdmin { get; set; }


    public User(string name, string password, string email, string adres, string number, bool isAdmin, string id, int age, int payment, bool isTrainer, string carteNumber)
    {
            Name = name;
            Password = password;
            Email = email;
            Adres = adres;
            Number = number;
            IsAdmin = isAdmin;
            Id = id;
            Age = age;
            Payment = payment;
            IsTrainer = isTrainer;
            CarteNumber = carteNumber;
    }

    
    public void CreateUser(string name, string password, string email, string adres, string number, bool isAdmin, int age, int payment, bool isTrainer, string carteNumber)
    {
        while (Name == null && Password == null && Email == null && Adres == null && Number == null && Age >0 && CarteNumber.Length == 8)
        {
            Name = name;
            Password = password;
            Email = email;
            Adres = adres;
            Number = number;
            IsAdmin = isAdmin;
            Age = age;
            Payment = payment;
            IsTrainer = isTrainer;
            CarteNumber = carteNumber;
        }
    }
    
    public void DeleteUser()
    {
        
    }

    public void ChangePassword(string newPassword)
    {
        Password = newPassword;
    }
    public void ChangeEmail(string newEmail)
    {
        Email = newEmail;
    }
    public void ChangeNumber(string newNumber)
    {
        Number = newNumber;
    }

    public void ChangeCarteNumber(string newCarteNumber)
    {
        CarteNumber = newCarteNumber;
    }

    public void ChangeAdress(string newAdress) 
    {
        Adres = newAdress;
    }
    public void Login(string email, string password)
    {
        if (Email == email && Password == password)
        {
            // Login successful
        }
        else
        {
            // Login failed
        }
    }


}
