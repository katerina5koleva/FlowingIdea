using Business;
using Data;
using Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FlowingIdeas.Presentation;

public partial class WritingYourIdeasHere : Form
{
	//Checked boxes need to be done 
	public WritingYourIdeasHere()
	{
		InitializeComponent();
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
	
	//private Idea GetEditedIdea()
	//{
	//	Idea editedIdea = new Idea();
	//	editedIdea.Id = editId;
	//	var editedtext = txtIdea.Text;
	//	return editedIdea;
	//}

	
	private void UpdateGrid()
	{
		dataGridView1.DataSource = ideaBusinessLogic.GetAll();
		dataGridView1.ReadOnly = true;
		dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
	}


	private void addArtisticButton_Click(object sender, EventArgs e)
	{
		errorProvider1.Clear();
		bool addBool = true;

		var newIdeaText = txtIdea.Text;
		ArtisticIdea artisticIdea = new ArtisticIdea();
		artisticIdea.textOfIdea = newIdeaText;
		//artisticIdea.textOfArtisticIdea = newIdeaText.ToString();
		//UserIdeaBusinessLogic.AddNewIdea(newIdeaText);
		UpdateGrid();
		ClearTextBoxes();
		if (string.IsNullOrEmpty(txtIdea.Text))
		{
			errorProvider1.SetError(txtIdea, "Required");
			addBool = false;
		}
		if (newIdeaText.Length < 3)
		{
			errorProvider1.SetError(txtIdea, "Your artistic idea should be longer!!!");
			addBool = false;
		}
		if (newIdeaText.Length > 400)
		{
			errorProvider1.SetError(txtIdea, "Please, write a shorter artistic idea!!!");
		}

		if (addBool)
		{
			MessageBox.Show("Your artistic idea was created!");
		}

	}

	private void addWorkIdea_Click(object sender, EventArgs e)
	{
		errorProvider1.Clear();
		bool addBool = true;

		var newIdeaText = txtIdea.Text;
		WorkIdea workIdea = new WorkIdea();
		workIdea.textOfIdea = newIdeaText;
		if (string.IsNullOrEmpty(txtIdea.Text))
		{
			errorProvider1.SetError(txtIdea, "Required");
			addBool = false;
		}
		if (newIdeaText.Length < 3)
		{
			errorProvider1.SetError(txtIdea, "Your work idea should be longer!!!");
			addBool = false;
		}
		if (newIdeaText.Length > 400)
		{
			errorProvider1.SetError(txtIdea, "Please, write a shorter work idea!!!");
		}

		if (addBool)
		{
			MessageBox.Show("Your work idea was created!");
		}
	}

	private void addPhilosophicalIdea_Click(object sender, EventArgs e)
	{
		errorProvider1.Clear();
		bool addBool = true;

		var newIdeaText = txtIdea.Text;
		PhilosophicalIdea philosophicalIdea = new PhilosophicalIdea();
		philosophicalIdea.textOfIdea = newIdeaText;
		if (string.IsNullOrEmpty(txtIdea.Text))
		{
			errorProvider1.SetError(txtIdea, "Required");
			addBool = false;
		}
		if (newIdeaText.Length < 3)
		{
			errorProvider1.SetError(txtIdea, "Your  philosophical idea should be longer!!!");
			addBool = false;
		}
		if (newIdeaText.Length > 400)
		{
			errorProvider1.SetError(txtIdea, "Please, write a shorter philosophical idea!!!");
		}

		if (addBool)
		{
			MessageBox.Show("Your philosophical idea was created!");
		}
	}

	
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
		if (editIdeaText.Length < 3)
		{
			errorProvider1.SetError(txtIdea, "Your edited idea should be longer!!!");
			addBool = false;
		}
		if (editIdeaText.Length > 400)
		{
			errorProvider1.SetError(txtIdea, "Please, write a shorter idea!!!");
		}

		if (addBool)
		{
			MessageBox.Show("Your idea was updated!");
		}
	}

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
	private void btnSave_Click(object sender, EventArgs e)
	{
		//Idea editedIdea = GetEditedIdea();
		//ideaBusinessLogic.Update(editedIdea);
		UpdateGrid();
		ResetSelect();
		ToggleSaveUpdate();
	}

	private void FlowingIdeaForm_Load(object sender, EventArgs e)
	{

	}
}
