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
	private SqlConnection connection;
	private UserIdeaBusinessLogic userIdeaBusinessLogic = new UserIdeaBusinessLogic();
	private int editId = 0;
	public IdeasFlow()
	{
		InitializeComponent();
		InitializeConnection();
		instance = this;
	}
	private void InitializeConnection()
	{
		connection = new SqlConnection(@"Server = LAPTOP-Q0EAJ4ES\SQLEXPRESS; 
											 Database = FlowingIdeas; 
											 Integrated security = true; 
											 Encrypt = false;");
		try
		{
			connection.Open();
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}



	/// <summary>
	///	this button handles the click event of the login.
	/// It establishes a database connection, checks if the username exists and
	/// shows an error message if the username doesn't exist.
	/// </summary>

	private void buttonLogIn_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(txtUsername.Text))
		{
			emptyUsernameBoxError.SetError(txtUsername, "Username is required.");
			return;
		}
		using (var command = new SqlCommand("SELECT * FROM LoginTable WHERE username = @username", connection))
		{
			command.Parameters.AddWithValue("@username", txtUsername.Text);

			using (var reader = command.ExecuteReader())
			{
				if (reader.Read())
				{
					Hide();
					WritingYourIdeasHere formWriteIdeas = new WritingYourIdeasHere();
					formWriteIdeas.Show();
				}
				else
				{
					accountDoesNotExistError.SetError(txtUsername, "No account available with this username.");
				}
			}
		}
		connection.Close();

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
		var command = new SqlCommand("select * from LoginTable where username='" + txtUsername.Text + "'", connection);

		if (string.IsNullOrEmpty(txtUsername.Text))
		{
			emptyUsernameBoxError.SetError(txtUsername, "Username is required.");
			return;
		}
		else if (txtUsername.Text.Length < 3 )
		{
			shortUsernameError.SetError(txtUsername, "Your usename needs to be longer!");
			return;
		}
		else if (txtUsername.Text.Length > 15)
		{
			longUsernameError.SetError(txtUsername, "Your usename needs to be shorter!");
		}

		using (command = new SqlCommand("SELECT COUNT(*) FROM LoginTable WHERE username = @username", connection))
		{
			command.Parameters.AddWithValue("@username", txtUsername.Text);
			int count = (int)command.ExecuteScalar();

			if (count > 0)
			{
				MessageBox.Show("Username already exists. Please try another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
		using (command = new SqlCommand("INSERT INTO LoginTable (username) VALUES (@username)", connection))
		{
			command.Parameters.AddWithValue("@username", txtUsername.Text);
			command.ExecuteNonQuery();
			MessageBox.Show("Your account has been created. Please log in now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		connection.Close();
	}
	private void IdeasFlow_Load(object sender, EventArgs e)
	{

	}
}

