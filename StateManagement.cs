public class UserSession
{
    public string UserName { get; set; }
    public bool IsLoggedIn { get; set; }
}

private UserSession CurrentSession = new UserSession();
