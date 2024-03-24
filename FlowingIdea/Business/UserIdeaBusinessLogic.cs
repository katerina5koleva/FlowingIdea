using Data;
using Data.Model;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Business;

public class UserIdeaBusinessLogic
{
	private static string connectionString = "Server = LAPTOP-Q0EAJ4ES\\SQLEXPRESS;" +
												 "Database = FlowingIdeas;" +
												"Integrated security = true;" +
												"Encrypt = false;";
	private static SqlConnection connection = new SqlConnection(connectionString);
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

	public void AddNewArtisticIdea(string textIdea, int userId)		
	{
		using (ideaContext = new UserIdeaContext())
		{

			ArtisticIdea artIdea = new () 
			{
				IdeaType = 1, 
				UserId = userId, 
				TextOfArtisticIdea = textIdea
			};
			ideaContext.ArtisticIdeas.Add(artIdea);
			ideaContext.SaveChanges();
		}
	}

	public void AddNewPhilosophicalIdea(string textIdea, int userId)
	{
		using (ideaContext = new UserIdeaContext())
		{
			PhilosophicalIdea philosophicalIdea = new()
			{
				IdeaType = 2,
				UserId = userId,
				TextOfPhilosophicalIdea = textIdea,
			};
			ideaContext.PhilosophicalIdeas.Add(philosophicalIdea);
			ideaContext.SaveChanges();
		}
	}

	public void AddNewWorkIdea(string textIdea, int userId)
	{
		using (ideaContext = new UserIdeaContext())
		{
			WorkIdea workIdea = new ()
			{
				IdeaType = 3,
				UserId = userId,
				TextOfWorkIdea = textIdea
			};
			ideaContext.WorkIdeas.Add(workIdea);
			ideaContext.SaveChanges();
		}
	}

	public List<ArtisticIdea> GetAllArtistic(int userId)
	{
		List<ArtisticIdea> artisticIdeas = new List<ArtisticIdea>();
		using (ideaContext = new UserIdeaContext())
		{
			connection.Open();
			var command = new SqlCommand("SELECT TextOfArtisticIdea FROM ArtisticIdeas WHERE UserId=@UserId", connection);
			command.Parameters.AddWithValue("@UserId", userId);
			using (var reader = command.ExecuteReader())
			{ 
				while (reader.Read())
				{
					ArtisticIdea artisticIdea = new ArtisticIdea();
					artisticIdeas.Add(artisticIdea);
				}
			}
			connection.Close();
		}
		return artisticIdeas;
	}
	public List<WorkIdea> GetAllWork(int userId)
	{
		List<WorkIdea> workIdeas = new List<WorkIdea>();
		using (ideaContext = new UserIdeaContext())
		{

			connection.Open();
			var command = new SqlCommand("SELECT TextOfWorkIdea FROM WorkIdeas WHERE UserId=@UserId", connection);
			command.Parameters.AddWithValue("@UserId", userId);
			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					WorkIdea workIdea = new WorkIdea();
					workIdeas.Add(workIdea);
				}
			}
			connection.Close();
		}
		return workIdeas;
	}
	public List<PhilosophicalIdea> GetAllPhilosophical(int userId)
	{
		List<PhilosophicalIdea> philosophicalIdeas = new List<PhilosophicalIdea>();
		using (ideaContext = new UserIdeaContext())
		{
			connection.Open();
			var command = new SqlCommand("SELECT TextOfPhilosophicalIdea FROM PhilosophicalIdeas WHERE UserId=@UserId", connection);
			command.Parameters.AddWithValue("@UserId", userId);
			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					PhilosophicalIdea philosophicalIdea = new PhilosophicalIdea();
					philosophicalIdeas.Add(philosophicalIdea);
				}
			}
			connection.Close();
		}
		return philosophicalIdeas;
	}

	public List<Idea> GetAll(int userId)
	{
		if (userId > 0)
		{
			List<Idea> allIdeas = new List<Idea>();
			using (ideaContext = new UserIdeaContext())
			{
				allIdeas.AddRange(GetAllArtistic(userId) as IEnumerable<Idea>);
				allIdeas.AddRange(GetAllPhilosophical(userId) as IEnumerable<Idea>);
				allIdeas.AddRange(GetAllWork(userId) as IEnumerable<Idea>);
			}
			return allIdeas;
		}
		return null;
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
