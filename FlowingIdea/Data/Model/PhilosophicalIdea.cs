using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model;

public class PhilosophicalIdea : Idea
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
			this.ideaType = 2;
		}
	}
	override public int UserId { get; set; }
	private string textOfPhilIdea;

	public override string TextOfIdea
	{
		get
		{
			return textOfPhilIdea;
		}
		set
		{
			this.textOfPhilIdea = value;
		}
	}
	public PhilosophicalIdea()
	{
			
	}
	public PhilosophicalIdea(int userId, string textOfPhilIdea)
	{
		int Id;
		this.IdeaType = 2;
		this.UserId = userId;
		this.TextOfIdea = textOfPhilIdea;
	}
}
