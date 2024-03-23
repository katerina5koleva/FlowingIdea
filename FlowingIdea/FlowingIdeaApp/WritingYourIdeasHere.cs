using Business;
using Data;
using Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FlowingIdeas.Presentation;
/// <summary>
/// This windows form allows users to add, edit, and delete different
/// types of ideas (artistic, work, philosophical) through various button clicks,
/// with data displayed in a DataGridView.
/// </summary>
public partial class WritingYourIdeasHere : Form
{
    private static string connectionString = "Server = LAPTOP-Q0EAJ4ES\\SQLEXPRESS;" +
                                                 "Database = FlowingIdeas;" +
                                                "Integrated security = true;" +
                                                "Encrypt = false;";
    private static SqlConnection connection = new SqlConnection(connectionString);
    //Checked boxes need to be done 
    public WritingYourIdeasHere()
    {
        InitializeComponent();
        UpdateGrid();
    }

    private int editId = 0;
    private UserIdeaBusinessLogic ideaBusinessLogic = new UserIdeaBusinessLogic();

    private void ResetSelect()
    {
        dataGridView1.ClearSelection();
        dataGridView1.Enabled = true;
    }

    private void ToggleSaveUpdate()
    {
        if (editButton.Visible)
        {
            saveButton.Visible = true;
            editButton.Visible = false;
        }
        else
        {
            editButton.Visible = true;
            saveButton.Visible = false;
        }
    }

    private void UpdateTextBoxes(int id)
    {
        Idea update = ideaBusinessLogic.Get(id);
        txtIdea.Text = update.textOfIdea;

    }
    private void ClearTextBoxes()
    {
        txtIdea.Text = "";
    }
    private void DisableSelect()
    {
        dataGridView1.Enabled = false;
    }

    private Idea GetEditedIdea()
    {
        EditedIdea editedIdea = new EditedIdea();
        var editedtext = txtIdea.Text;
        return editedIdea;
    }


    private void UpdateGrid()
    {
        //connection.Open();
        dataGridView1.DataSource = ideaBusinessLogic.GetAll();
        dataGridView1.ReadOnly = true;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }


    private void addArtisticButton_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();
        bool addBool = true;

        var newIdeaText = txtIdea.Text;

        if (string.IsNullOrEmpty(txtIdea.Text))
        {
            errorProvider1.SetError(txtIdea, "Required");
            addBool = false;
        }
        else if (newIdeaText.Length < 3)
        {
            errorProvider1.SetError(txtIdea, "Your artistic idea should be longer!!!");
            addBool = false;
        }
        else if (newIdeaText.Length > 400)
        {
            errorProvider1.SetError(txtIdea, "Please, write a shorter artistic idea!!!");
        }

        else if (addBool) 
        {
            connection.Open();
            var command = new SqlCommand($"INSERT INTO ArtisticIdeas (TextOfIdea) VALUES (@ArtIdeaText)\"", connection);
            command.Parameters.AddWithValue("@ArtIdeaText", newIdeaText);
            ArtisticIdea artisticIdea = new ArtisticIdea();
            artisticIdea.textOfIdea = newIdeaText;
            MessageBox.Show("Your artistic idea was created!");
            UpdateGrid();
            ClearTextBoxes();
        }

    }

    private void addWorkIdea_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();
        bool addBool = true;

        var newIdeaText = txtIdea.Text;
        if (string.IsNullOrEmpty(txtIdea.Text))
        {
            errorProvider1.SetError(txtIdea, "Required");
            addBool = false;
        }
        else if (newIdeaText.Length < 3)
        {
            errorProvider1.SetError(txtIdea, "Your work idea should be longer!!!");
            addBool = false;
        }
        else if (newIdeaText.Length > 400)
        {
            errorProvider1.SetError(txtIdea, "Please, write a shorter work idea!!!");
        }

        else if (addBool)
        {
            connection.Open();
            var command = new SqlCommand($"INSERT INTO WorkIdeas (TextOfIdea) VALUES (@WorkIdeaText)\"", connection);
            command.Parameters.AddWithValue("@WorkIdeaText", newIdeaText);
            WorkIdea workIdea = new WorkIdea();
            workIdea.textOfIdea = newIdeaText;
            MessageBox.Show("Your work idea was created!");
        }
    }

    private void addPhilosophicalIdea_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();
        bool addBool = true;

        var newIdeaText = txtIdea.Text;

        if (string.IsNullOrEmpty(txtIdea.Text))
        {
            errorProvider1.SetError(txtIdea, "Required");
            addBool = false;
        }
        else if (newIdeaText.Length < 3)
        {
            errorProvider1.SetError(txtIdea, "Your  philosophical idea should be longer!!!");
            addBool = false;
        }
        else if (newIdeaText.Length > 400)
        {
            errorProvider1.SetError(txtIdea, "Please, write a shorter philosophical idea!!!");
        }

        else if (addBool)
        {
            var command = new SqlCommand($"INSERT INTO PhilosophicalIdeas (TextOfIdea) VALUES (@PhilIdeaText)\"", connection);
            command.Parameters.AddWithValue("@PhilIdeaText", newIdeaText);
            PhilosophicalIdea philosophicalIdea = new PhilosophicalIdea();
            philosophicalIdea.textOfIdea = newIdeaText;
            MessageBox.Show("Your philosophical idea was created!");
        }
    }

    /// <summary>
    /// This handles the edit button click event, retrieves the selected idea for editing
    /// and validates the edited idea.
    /// </summary>
    private void editButton_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();
        bool addBool = true;

        if (dataGridView1.SelectedRows.Count > 0)
        {
            var item = dataGridView1.SelectedRows[0].Cells;
            var id = int.Parse(item[0].Value.ToString());
            editId = id;
            UpdateTextBoxes(id);
            ToggleSaveUpdate();
            DisableSelect();
        }

        var editIdeaText = txtIdea.Text;


        if (string.IsNullOrEmpty(txtIdea.Text))
        {
            errorProvider1.SetError(txtIdea, "Required");
            addBool = false;
        }
        else if (editIdeaText.Length < 3)
        {
            errorProvider1.SetError(txtIdea, "Your edited idea should be longer!!!");
            addBool = false;
        }
        else if (editIdeaText.Length > 400)
        {
            errorProvider1.SetError(txtIdea, "Please, write a shorter idea!!!");
        }

        else if (addBool)
        {
            MessageBox.Show("Your idea was updated!");
        }
    }
    /// <summary>
    /// This button deletes the selected idea.
    /// </summary>
    private void deleteButton_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            var item = dataGridView1.SelectedRows[0].Cells;
            var id = int.Parse(item[0].Value.ToString());
            ideaBusinessLogic.Delete(id);
            UpdateGrid();
            ResetSelect();
        }
    }
    /// <summary>
    /// This handles the save button click event, wich updates the edited idea
    /// </summary>

    private void btnSave_Click(object sender, EventArgs e)
    {
        Idea editedIdea = GetEditedIdea();
        ideaBusinessLogic.Update(editedIdea);
        UpdateGrid();
        ResetSelect();
        ToggleSaveUpdate();
    }

    private void FlowingIdeaForm_Load(object sender, EventArgs e)
    {

    }

    private void PhilosophicalCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        dataGridView1.DataSource = ideaBusinessLogic.GetAllPhilosophical();
        dataGridView1.ReadOnly = true;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        UpdateGrid();
    }

    private void artisticIdeaCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        dataGridView1.DataSource = ideaBusinessLogic.GetAllArtistic();
        dataGridView1.ReadOnly = true;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        UpdateGrid();

    }

    private void workIdeaCheckBox_CheckedChanged(object sender, EventArgs e)
    {

        dataGridView1.DataSource = ideaBusinessLogic.GetAllWork();
        dataGridView1.ReadOnly = true;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        UpdateGrid();
    }

    private void WritingYourIdeasHere_Load(object sender, EventArgs e)
    {

    }
}
