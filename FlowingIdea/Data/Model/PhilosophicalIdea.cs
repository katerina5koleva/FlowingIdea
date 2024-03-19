using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model;

public class PhilosophicalIdea : Idea
{
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
}
