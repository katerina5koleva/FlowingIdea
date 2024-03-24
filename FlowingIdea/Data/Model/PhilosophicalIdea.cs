using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model;

public class PhilosophicalIdea //: Idea
{
	public int Id { get; set; }
	public int IdeaType { get; set; }
	
	public int UserId { get; set; }
	public string TextOfPhilosophicalIdea { get; set; }

}
