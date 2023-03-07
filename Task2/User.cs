
internal class User
{
    private string _username;
    private string _password;
    public string Username
    {
        get { return _username; }
        set
        {
            if (!string.IsNullOrEmpty(value.Trim(' ')) && value.Length > 1 && value.Length < 50)
            {
                _username = value;
            }
            else
            {
                Console.WriteLine("Enter correct Username");
            }
        }
    }
    public string Password
    {
        get { return _password; }
        set
        {
            
        }
    }
    public User(string username, string password)
    {
       while (!CheckPassword(password))
        {
            Console.WriteLine("please add valid pswrd");
            password = Console.ReadLine();
        }
    }

    bool CheckPassword(string password)
    {
        bool status = true;
        if (string.IsNullOrEmpty(password))
        {
            status = false;
        }
        if (password.Length < 8)
        {
            status = false;
        }

        bool isUpper = false;
        bool isDigit = false;

        for (int i = 0; i < password.Length; i++)
        {
            if (char.IsUpper(password[i]))
            {
                isUpper = true;
            }
            if (char.IsDigit(password[i]))
            {
                isDigit = true;
            }
        }
        if (!isUpper)
            status = false;
        if (!isDigit) 
            status = false;
        return status;


    }



}