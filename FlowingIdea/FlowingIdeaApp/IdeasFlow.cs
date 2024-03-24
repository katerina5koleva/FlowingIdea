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
using System.Data.SqlClient;
namespace FlowingIdeas.Presentation;
/// <summary>
/// This is the first window that is an implementation of a login/signup functionality
/// for managing user ideas in a Windows Forms application, with database interaction handled through SQL commands.
/// </summary>
public partial class IdeasFlow : Form
{
    private static string connectionString = "Server = LAPTOP-Q0EAJ4ES\\SQLEXPRESS;" +
                                                 "Database = FlowingIdeas;" +
                                                "Integrated security = true;" +
                                                "Encrypt = false;";
    private static SqlConnection connection = new SqlConnection(connectionString);

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
        connection.Close();
        connection.Open();

        if (txtUsername.Text != string.Empty)
        {
            var command = new SqlCommand($"SELECT * FROM Users WHERE Username = @Username", connection);
            command.Parameters.AddWithValue("@Username", txtUsername.Text);
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
                MessageBox.Show("No account avaliable with this username! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            emptyUsernameBoxError.Clear();
            bool addBool = true;
            var logInUsername = txtUsername.Text;
            //User writtenUsernameInBox = new User();
            //writtenUsernameInBox.Username = logInUsername;
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                emptyUsernameBoxError.SetError(txtUsername, "Required");
                addBool = false;
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

    
    private void IdeasFlow_Load(object sender, EventArgs e)
    {

    }

    private void buttonSignUp_Click_1(object sender, EventArgs e)
    {
        connection.Close();
        connection.Open();
        var command = new SqlCommand($"SELECT * FROM Users WHERE Username = @Username", connection);
        command.Parameters.AddWithValue("@Username", txtUsername.Text);
        var dr = command.ExecuteReader();
        var addedUsernameText = txtUsername.Text;
        emptyUsernameBoxError.Clear();
        bool addBool = true;
        if (dr.Read())
        {
            MessageBox.Show("Username already exist please try another! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dr.Close();
        }
        else if (string.IsNullOrEmpty(txtUsername.Text))
        {
            var logInUsername = txtUsername.Text;
            emptyUsernameBoxError.SetError(txtUsername, "Required");
            addBool = false;
        }
        else if (addedUsernameText.Length > 15)
        {
            emptyUsernameBoxError.SetError(txtUsername, "Your username needs to be shorter!");
            addBool = false;
        }
        else if (addedUsernameText.Length < 3)
        {
            emptyUsernameBoxError.SetError(txtUsername, "Your username needs to be longer!");
            addBool = false;
        }
        else
        {
            dr.Close();
            command = new SqlCommand("INSERT INTO Users VALUES(@Username)", connection);
            command.Parameters.AddWithValue("@Username", txtUsername.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Your account has been created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

