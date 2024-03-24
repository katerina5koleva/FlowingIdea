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
	public int Id { get; set; }
	public int ideaType;
	override public int IdeaType
	{
		get
		{
			return this.ideaType;
		}
		set
		{
			this.ideaType = 3;
		}
	}
	override public int UserId { get; set; }
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
	public WorkIdea()
	{
		
	}
	public WorkIdea(int userId, string textOfWorkIdea)
	{
		int Id;
		this.IdeaType = 3;
		this.UserId = userId;
		this.TextOfIdea = textOfWorkIdea;
	}
}
