using TallerCodeChallenge.Domain;

namespace TallerCodeChallenge.Infrastructure;
public class UserRepository
{
    public User? GetUser(string username)
    {
        try
        {
            if (username == "vini")
            {
                return new User { Name = "Vinicius", Username = username };

            }
            else
            {
                return null;
            }
        }
        finally
        {
            //close connection
        }
    }
}
