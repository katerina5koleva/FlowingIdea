using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model;

public class WorkIdea : Idea
{
	[Key]
	public int Id { get; private set; }
	public int ideaType;
	public int IdeaType
	{
		get
		{
			return this.ideaType;
		}
		private set
		{
			this.ideaType = 3;
		}
	}
	[ForeignKey(nameof(User.Id))]
	public int UserId { get; private set; }

	public string textOfIdea;
	private string textOfWorkIdea;


	public override string TextOfIdea
	{
		get
		{
			return textOfWorkIdea;
		}
		set
		{

			this.textOfWorkIdea = value;
		}
	}
}
