using Data;
using Data.Model;
using System.Configuration;
using System.Data.Entity;
namespace Business;

public class UserIdeaBusinessLogic
{
	private UserIdeaContext ideaContext;
	//public bool CheckIfAccountExists(string writtenUsername)
	//{
	//	using (ideaContext = new UserIdeaContext())
	//	{
	//		User user = new User();
	//		user.Username = writtenUsername;
	//		foreach (var item in ideaContext.Users)
	//		{
	//			if (item.Username.Contains(writtenUsername))
	//			{
	//			return true;
	//			}
	//		}
	//			return false;
	//	}
	//
	//}
	//public void CreateAccount(User user)
	//{
	//	using (ideaContext = new UserIdeaContext())
	//	{
	//		ideaContext.Users.Add(user);
	//		ideaContext.SaveChanges();
	//	}
	//}

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

	public void AddNewArtisticIdea( string textOfArtisticIdea) //???
	{
		using (ideaContext = new UserIdeaContext())
		{

			ArtisticIdea artisticIdea = new ArtisticIdea();
			ideaContext.SaveChanges();
		}
	}
	public void AddNewWorkIdea( string textOfWorkIdea) //???
	{
		using (ideaContext = new UserIdeaContext())
		{
			WorkIdea workIdea = new WorkIdea();
			ideaContext.SaveChanges();
		}
	}
	public void AddNewPhilosophicalIdea( string textOfPhilosophicalIdea) //???
	{
		using (ideaContext = new UserIdeaContext())
		{

			PhilosophicalIdea philosophicalIdea = new PhilosophicalIdea();

			ideaContext.SaveChanges();
		}
	}

	
	public List<ArtisticIdea> GetAllArtistic()
	{
		using (ideaContext = new UserIdeaContext())
		{
			return ideaContext.ArtisticIdeas.ToList();
		}
	}
	public List<WorkIdea> GetAllWork()
	{
		using (ideaContext = new UserIdeaContext())
		{
			return ideaContext.WorkIdeas.ToList();
		}
	}
	public List<PhilosophicalIdea> GetAllPhilosophical()
	{
		using (ideaContext = new UserIdeaContext())
		{
			return ideaContext.PhilosophicalIdeas.ToList();
		}
	}

	public List<Idea> GetAll()
	{
		using (ideaContext = new UserIdeaContext())
		{
			return ideaContext.Ideas.ToList();
		}
	}

	public void Delete(int id)
	{
		using (ideaContext = new UserIdeaContext())
		{
			var idea = ideaContext.Ideas.Find(id);
			if (idea != null)
			{
				ideaContext.Ideas.Remove(idea);
				ideaContext.SaveChanges();
			}
		}
	}
	public void Update(Idea idea)
	{
		using (ideaContext = new UserIdeaContext())
		{

			var item = ideaContext.Ideas.Find(idea.Id);
			if (item != null)
			{
				ideaContext.Entry(item).CurrentValues.SetValues(idea);
				ideaContext.SaveChanges();
			}

		}
	}

	public Idea Get(int id)
	{
		using (ideaContext = new UserIdeaContext())
		{
			return ideaContext.Ideas.Find(id);

		}
	}
}
