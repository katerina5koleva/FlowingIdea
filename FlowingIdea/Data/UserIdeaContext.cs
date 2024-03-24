using System.Data.Entity;
using Data.Model;
namespace Data;

public class UserIdeaContext : DbContext
{
    public UserIdeaContext() : base("name=UserIdeaContext")
    {

    }
    public DbSet<ArtisticIdea> ArtisticIdeas { get; set; }
    public DbSet<PhilosophicalIdea> PhilosophicalIdeas { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<WorkIdea> WorkIdeas { get; set; }
    public DbSet<Idea> Ideas { get; set; }
}
