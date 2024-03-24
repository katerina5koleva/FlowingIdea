using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model;

/// <summary>
/// This class is the structure of the table "Users" in the database. It validates the username and password.
/// </summary>
public class User
{
	public int Id { get; set; }
	public string Username { get; set; }
	
}
