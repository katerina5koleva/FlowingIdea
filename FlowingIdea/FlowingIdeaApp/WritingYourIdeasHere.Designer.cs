namespace FlowingIdeas.Presentation
{
	partial class WritingYourIdeasHere
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			dataGridView1 = new DataGridView();
			PhlosophicalCheckBox = new CheckBox();
			artisticIdeaCheckBox = new CheckBox();
			workIdeaCheckBox = new CheckBox();
			owlbertImage2 = new PictureBox();
			addArtisticButton = new Button();
			editButton = new Button();
			deleteButton = new Button();
			saveButton = new Button();
			txtIdea = new TextBox();
			label1 = new Label();
			addWorkIdea = new Button();
			addPhilosophicalIdea = new Button();
			errorProvider1 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)owlbertImage2).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = Color.BlanchedAlmond;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.GridColor = Color.FloralWhite;
			dataGridView1.Location = new Point(420, 155);
			dataGridView1.Margin = new Padding(3, 2, 3, 2);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(516, 295);
			dataGridView1.TabIndex = 0;
			// 
			// PhlosophicalCheckBox
			// 
			PhlosophicalCheckBox.AutoSize = true;
			PhlosophicalCheckBox.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			PhlosophicalCheckBox.ForeColor = Color.Brown;
			PhlosophicalCheckBox.Location = new Point(20, 18);
			PhlosophicalCheckBox.Margin = new Padding(3, 2, 3, 2);
			PhlosophicalCheckBox.Name = "PhlosophicalCheckBox";
			PhlosophicalCheckBox.Size = new Size(163, 22);
			PhlosophicalCheckBox.TabIndex = 1;
			PhlosophicalCheckBox.Text = "Philosophical ideas";
			PhlosophicalCheckBox.UseVisualStyleBackColor = true;
			// 
			// artisticIdeaCheckBox
			// 
			artisticIdeaCheckBox.AutoSize = true;
			artisticIdeaCheckBox.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			artisticIdeaCheckBox.ForeColor = Color.Brown;
			artisticIdeaCheckBox.Location = new Point(20, 62);
			artisticIdeaCheckBox.Margin = new Padding(3, 2, 3, 2);
			artisticIdeaCheckBox.Name = "artisticIdeaCheckBox";
			artisticIdeaCheckBox.Size = new Size(119, 22);
			artisticIdeaCheckBox.TabIndex = 2;
			artisticIdeaCheckBox.Text = "Artistic ideas";
			artisticIdeaCheckBox.UseVisualStyleBackColor = true;
			// 
			// workIdeaCheckBox
			// 
			workIdeaCheckBox.AutoSize = true;
			workIdeaCheckBox.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			workIdeaCheckBox.ForeColor = Color.Firebrick;
			workIdeaCheckBox.Location = new Point(20, 106);
			workIdeaCheckBox.Margin = new Padding(3, 2, 3, 2);
			workIdeaCheckBox.Name = "workIdeaCheckBox";
			workIdeaCheckBox.Size = new Size(105, 22);
			workIdeaCheckBox.TabIndex = 3;
			workIdeaCheckBox.Text = "Work ideas";
			workIdeaCheckBox.UseVisualStyleBackColor = true;
			// 
			// owlbertImage2
			// 
			owlbertImage2.Image = FlowingIdeaApp.Properties.Resources.owlbert1;
			owlbertImage2.Location = new Point(4, 138);
			owlbertImage2.Margin = new Padding(3, 2, 3, 2);
			owlbertImage2.Name = "owlbertImage2";
			owlbertImage2.Size = new Size(406, 405);
			owlbertImage2.TabIndex = 4;
			owlbertImage2.TabStop = false;
			// 
			// addArtisticButton
			// 
			addArtisticButton.Location = new Point(336, 18);
			addArtisticButton.Margin = new Padding(3, 2, 3, 2);
			addArtisticButton.Name = "addArtisticButton";
			addArtisticButton.Size = new Size(134, 22);
			addArtisticButton.TabIndex = 5;
			addArtisticButton.Text = "Add an artistic idea";
			addArtisticButton.UseVisualStyleBackColor = true;
			addArtisticButton.Click += addArtisticButton_Click;
			// 
			// editButton
			// 
			editButton.Location = new Point(225, 18);
			editButton.Margin = new Padding(3, 2, 3, 2);
			editButton.Name = "editButton";
			editButton.Size = new Size(82, 22);
			editButton.TabIndex = 6;
			editButton.Text = "Edit";
			editButton.UseVisualStyleBackColor = true;
			editButton.Click += editButton_Click;
			// 
			// deleteButton
			// 
			deleteButton.Location = new Point(854, 44);
			deleteButton.Margin = new Padding(3, 2, 3, 2);
			deleteButton.Name = "deleteButton";
			deleteButton.Size = new Size(82, 22);
			deleteButton.TabIndex = 7;
			deleteButton.Text = "Delete";
			deleteButton.UseVisualStyleBackColor = true;
			deleteButton.Click += deleteButton_Click;
			// 
			// saveButton
			// 
			saveButton.Location = new Point(854, 18);
			saveButton.Margin = new Padding(3, 2, 3, 2);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(82, 22);
			saveButton.TabIndex = 8;
			saveButton.Text = "Save";
			saveButton.UseVisualStyleBackColor = true;
			// 
			// txtIdea
			// 
			txtIdea.Location = new Point(420, 75);
			txtIdea.Margin = new Padding(3, 2, 3, 2);
			txtIdea.Multiline = true;
			txtIdea.Name = "txtIdea";
			txtIdea.Size = new Size(516, 76);
			txtIdea.TabIndex = 10;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(420, 62);
			label1.Name = "label1";
			label1.Size = new Size(116, 15);
			label1.TabIndex = 12;
			label1.Text = "Write your idea here:";
			// 
			// addWorkIdea
			// 
			addWorkIdea.Location = new Point(499, 18);
			addWorkIdea.Margin = new Padding(3, 2, 3, 2);
			addWorkIdea.Name = "addWorkIdea";
			addWorkIdea.Size = new Size(164, 22);
			addWorkIdea.TabIndex = 13;
			addWorkIdea.Text = "Add a work related idea";
			addWorkIdea.UseVisualStyleBackColor = true;
			addWorkIdea.Click += addWorkIdea_Click;
			// 
			// addPhilosophicalIdea
			// 
			addPhilosophicalIdea.Location = new Point(682, 18);
			addPhilosophicalIdea.Margin = new Padding(3, 2, 3, 2);
			addPhilosophicalIdea.Name = "addPhilosophicalIdea";
			addPhilosophicalIdea.Size = new Size(166, 22);
			addPhilosophicalIdea.TabIndex = 14;
			addPhilosophicalIdea.Text = "Add a philosophical idea";
			addPhilosophicalIdea.UseVisualStyleBackColor = true;
			addPhilosophicalIdea.Click += addPhilosophicalIdea_Click;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// WritingYourIdeasHere
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightYellow;
			ClientSize = new Size(948, 548);
			Controls.Add(addPhilosophicalIdea);
			Controls.Add(addWorkIdea);
			Controls.Add(label1);
			Controls.Add(txtIdea);
			Controls.Add(saveButton);
			Controls.Add(deleteButton);
			Controls.Add(editButton);
			Controls.Add(addArtisticButton);
			Controls.Add(owlbertImage2);
			Controls.Add(workIdeaCheckBox);
			Controls.Add(artisticIdeaCheckBox);
			Controls.Add(PhlosophicalCheckBox);
			Controls.Add(dataGridView1);
			ForeColor = SystemColors.ControlText;
			Margin = new Padding(3, 2, 3, 2);
			Name = "WritingYourIdeasHere";
			Text = "FlowingIdeas";
			Load += WritingYourIdeasHere_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)owlbertImage2).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private CheckBox PhlosophicalCheckBox;
		private CheckBox artisticIdeaCheckBox;
		private CheckBox workIdeaCheckBox;
		private PictureBox owlbertImage2;
		private Button addArtisticButton;
		private Button editButton;
		private Button deleteButton;
		private Button saveButton;
		private TextBox txtIdea;
		private Label label1;
		private Button addWorkIdea;
		private Button addPhilosophicalIdea;
		private ErrorProvider errorProvider1;
	}
}