using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Data.Model;
using Microsoft.Data.SqlClient;
namespace FlowingIdeas.Presentation;
/// <summary>
/// This is the first window that is an implementation of a login/signup functionality
/// for managing user ideas in a Windows Forms application, with database interaction handled through SQL commands.
/// </summary>
public partial class IdeasFlow : Form
{
	public static IdeasFlow instance;
	public IdeasFlow()
	{
		InitializeComponent();
		instance = this;
	}
	private UserIdeaBusinessLogic userIdeaBusinessLogic = new UserIdeaBusinessLogic();
	private int editId = 0;

	/// <summary>
	///	this button handles the click event of the login.
	/// It establishes a database connection, checks if the username exists and
	/// shows an error message if the username doesn't exist.
	/// </summary>

	private void buttonLogIn_Click(object sender, EventArgs e)
	{
		var connection = new SqlConnection(@"Server = LAPTOP-Q0EAJ4ES\\SQLEXPRESS; 
												 Database = FlowingIdeas; 
												Integrated security = true; 
												Encrypt = false;");
		connection.Open();

		if (txtUsername.Text != string.Empty)
		{

			var command = new SqlCommand("select * from LoginTable where username='" + txtUsername.Text, connection);
			var dr = command.ExecuteReader();
			if (dr.Read())
			{
				dr.Close();
				this.Hide();
				WritingYourIdeasHere formWriteIdeas = new WritingYourIdeasHere();
				formWriteIdeas.Show();

			}
			else
			{
				dr.Close();
				MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		else
		{
			errorProvider1.Clear();
			bool addBool = true;
			var logInUsername = txtUsername.Text;
			//User writtenUsernameInBox = new User();
			//writtenUsernameInBox.Username = logInUsername;
			if (string.IsNullOrEmpty(txtUsername.Text))
			{
				errorProvider1.SetError(txtUsername, "Required");
				addBool = false;
			}
		}
	}
	/// <summary>
	/// This button closes the form when the cancel is clicked.
	/// </summary>

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		this.Close();
	}
	/// <summary>
	/// This button handles the click event of the sign-up. It checks if the username already exists, 
	/// validates the length of the username, and inserts a new username into the database if validation passes.
	/// </summary>

	private void buttonSignUp_Click(object sender, EventArgs e)
	{

		var connection = new SqlConnection(@"Server = LAPTOP-Q0EAJ4ES\\SQLEXPRESS; 
												 Database = FlowingIdeas; 
												Integrated security = true; 
												Encrypt = false;");
		connection.Open();
		var command = new SqlCommand("select * from LoginTable where username='" + txtUsername.Text + "'", connection);
		var dr = command.ExecuteReader();
		var addedUsernameText = txtUsername.Text;
		errorProvider1.Clear();
		bool addBool = true;
		if (dr.Read())
		{
			dr.Close();
			MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		if (string.IsNullOrEmpty(txtUsername.Text))
		{
			var logInUsername = txtUsername.Text;
			errorProvider1.SetError(txtUsername, "Required");
			addBool = false;
		}
		if (addedUsernameText.Length > 15)
		{
			errorProvider1.SetError(txtUsername, "Your usename needs to be shorter!");
			addBool = false;
		}
		if (addedUsernameText.Length < 3)
		{
			errorProvider1.SetError(txtUsername, "Your usename needs to be longer!");
			addBool = false;
		}
		else
		{
			dr.Close();
			command = new SqlCommand("insert into LoginTable values(@username)", connection);
			command.Parameters.AddWithValue("username", txtUsername.Text);
			command.ExecuteNonQuery();
			MessageBox.Show("Your Account has been created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
	private void IdeasFlow_Load(object sender, EventArgs e)
	{

	}
}

