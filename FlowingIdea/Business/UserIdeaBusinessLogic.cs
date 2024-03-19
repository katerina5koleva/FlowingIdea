using Data;
using Data.Model;
using System.Configuration;
using System.Data.Entity;
namespace Business
{
    public class UserIdeaBusinessLogic
    {
            private UserIdeaContext ideaContext;
            public bool CheckIfAccountExists(string writtenUsername)
            {
                using (ideaContext = new UserIdeaContext())
                {
                    User user = new User();
                    user.Username = writtenUsername;
                    foreach (var item in ideaContext.Users)
                    {
                        if (item.Username.Contains(writtenUsername))
                        {
                        return true;
                        }
                    }
                        return false;
                }

            }
    }
}
