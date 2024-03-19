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
        public void CreateAccount(User user)
        {
            using (ideaContext = new UserIdeaContext())
            {
                ideaContext.Users.Add(user);
                ideaContext.SaveChanges();
            }
        }

        //public void LogIn(string writtenUsername, string writtenPassword)
        //{
        //    using (ideaContext = new UserIdeaContext())
        //    {
        //        if (CheckIfAccountExists(writtenUsername))
        //        {
        //            if (User.Password.Contains(writtenPassword))
        //            {
        //                
        //            }
        //            else
        //            {
        //            throw new ArgumentException("You have entered a wrong password!");
        //            }
        //        }
        //    }
        //}

        public void AddNewIdea(User user, int IdeaType, string textIdea)
        {
            using (ideaContext = new UserIdeaContext())
            {
                if (IdeaType == 1)
                {
                    ArtisticIdea artisticIdea = new ArtisticIdea();
                }
                if (IdeaType == 2)
                {
                    PhilosophicalIdea philosophicalIdea = new PhilosophicalIdea();
                }
                else
                {
                    WorkIdea workIdea = new WorkIdea();
                }
                ideaContext.SaveChanges();
            }
        }
    }
}
