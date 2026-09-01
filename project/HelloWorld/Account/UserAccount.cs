namespace Account;

internal class UserAccount
{
    #region Fields
    private string _username;
    private string _password;
    private int _loginAttempts;
    private readonly string _accountId;
    private static int _nextAccountId =0 ;
    #endregion
    #region Properties
    public string Username
    {
        get;
        private set;
    }
    public string AccountId
    {
        get { return _accountId; }
    }
    public string Password
    {
        private get { return  _password; }
        set
        {
            if (value.Length >= 6)
            {
                _password = value;
            }
            else
            {
                Console.WriteLine("password must be at least 6 characters long");
            }
        }
    }
    #endregion
    #region Constructors
    public UserAccount(string username, string password)
    {
        Username = username;
        Password = password;
        _loginAttempts = 0;
        _accountId = "ACC-"+_nextAccountId;
        _nextAccountId ++;
    }
    #endregion
    #region methods
    public bool Login (string password)
    {
        if (_password == password)
        {
            _loginAttempts = 0;
            return true;
        }
        else 
        {
            _loginAttempts++;
            if (_loginAttempts >= 3)
            {
                Console.WriteLine("Account locked due to too many failed login attempts.");
            }
            return false;
        }
        
            
        
    }
    #endregion

}