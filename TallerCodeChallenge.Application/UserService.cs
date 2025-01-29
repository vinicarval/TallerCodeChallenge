using TallerCodeChallenge.Infrastructure;

namespace TallerCodeChallenge.Application;
public class UserService
{
    public string GreetValidUser(string userName)
    {
        UserRepository userRepository = new UserRepository();

        var user = userRepository.GetUser(userName);
        if (user == null)
        {
            return "User not found.";
        }

        return $"Hello {user.Name}!";
    }
}
