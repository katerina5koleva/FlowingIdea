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
			dataGridView1.Location = new Point(411, 184);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(590, 393);
			dataGridView1.TabIndex = 0;
			// 
			// PhlosophicalCheckBox
			// 
			PhlosophicalCheckBox.AutoSize = true;
			PhlosophicalCheckBox.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			PhlosophicalCheckBox.ForeColor = Color.Brown;
			PhlosophicalCheckBox.Location = new Point(23, 24);
			PhlosophicalCheckBox.Name = "PhlosophicalCheckBox";
			PhlosophicalCheckBox.Size = new Size(198, 24);
			PhlosophicalCheckBox.TabIndex = 1;
			PhlosophicalCheckBox.Text = "Philosophical ideas";
			PhlosophicalCheckBox.UseVisualStyleBackColor = true;
			PhlosophicalCheckBox.CheckedChanged += PhlosophicalCheckBox_CheckedChanged;
			// 
			// artisticIdeaCheckBox
			// 
			artisticIdeaCheckBox.AutoSize = true;
			artisticIdeaCheckBox.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			artisticIdeaCheckBox.ForeColor = Color.Brown;
			artisticIdeaCheckBox.Location = new Point(23, 83);
			artisticIdeaCheckBox.Name = "artisticIdeaCheckBox";
			artisticIdeaCheckBox.Size = new Size(144, 24);
			artisticIdeaCheckBox.TabIndex = 2;
			artisticIdeaCheckBox.Text = "Artistic ideas";
			artisticIdeaCheckBox.UseVisualStyleBackColor = true;
			artisticIdeaCheckBox.CheckedChanged += artisticIdeaCheckBox_CheckedChanged;
			// 
			// workIdeaCheckBox
			// 
			workIdeaCheckBox.AutoSize = true;
			workIdeaCheckBox.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			workIdeaCheckBox.ForeColor = Color.Firebrick;
			workIdeaCheckBox.Location = new Point(23, 141);
			workIdeaCheckBox.Name = "workIdeaCheckBox";
			workIdeaCheckBox.Size = new Size(127, 24);
			workIdeaCheckBox.TabIndex = 3;
			workIdeaCheckBox.Text = "Work ideas";
			workIdeaCheckBox.UseVisualStyleBackColor = true;
			workIdeaCheckBox.CheckedChanged += workIdeaCheckBox_CheckedChanged;
			// 
			// owlbertImage2
			// 
			owlbertImage2.Image = FlowingIdeaApp.Properties.Resources.owlbert1;
			owlbertImage2.Location = new Point(5, 184);
			owlbertImage2.Name = "owlbertImage2";
			owlbertImage2.Size = new Size(400, 402);
			owlbertImage2.TabIndex = 4;
			owlbertImage2.TabStop = false;
			// 
			// addArtisticButton
			// 
			addArtisticButton.Location = new Point(285, 21);
			addArtisticButton.Name = "addArtisticButton";
			addArtisticButton.Size = new Size(153, 29);
			addArtisticButton.TabIndex = 5;
			addArtisticButton.Text = "Add an artistic idea";
			addArtisticButton.UseVisualStyleBackColor = true;
			addArtisticButton.Click += addArtisticButton_Click;
			// 
			// editButton
			// 
			editButton.Location = new Point(285, 78);
			editButton.Name = "editButton";
			editButton.Size = new Size(94, 29);
			editButton.TabIndex = 6;
			editButton.Text = "Edit";
			editButton.UseVisualStyleBackColor = true;
			editButton.Click += editButton_Click;
			// 
			// deleteButton
			// 
			deleteButton.Location = new Point(285, 136);
			deleteButton.Name = "deleteButton";
			deleteButton.Size = new Size(94, 29);
			deleteButton.TabIndex = 7;
			deleteButton.Text = "Delete";
			deleteButton.UseVisualStyleBackColor = true;
			deleteButton.Click += deleteButton_Click;
			// 
			// saveButton
			// 
			saveButton.Location = new Point(907, 21);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(94, 29);
			saveButton.TabIndex = 8;
			saveButton.Text = "Save";
			saveButton.UseVisualStyleBackColor = true;
			// 
			// txtIdea
			// 
			txtIdea.Location = new Point(411, 78);
			txtIdea.Multiline = true;
			txtIdea.Name = "txtIdea";
			txtIdea.Size = new Size(589, 100);
			txtIdea.TabIndex = 10;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(411, 53);
			label1.Name = "label1";
			label1.Size = new Size(147, 20);
			label1.TabIndex = 12;
			label1.Text = "Write your idea here:";
			// 
			// addWorkIdea
			// 
			addWorkIdea.Location = new Point(475, 21);
			addWorkIdea.Name = "addWorkIdea";
			addWorkIdea.Size = new Size(187, 29);
			addWorkIdea.TabIndex = 13;
			addWorkIdea.Text = "Add a work related idea";
			addWorkIdea.UseVisualStyleBackColor = true;
			addWorkIdea.Click += addWorkIdea_Click;
			// 
			// addPhilosophicalIdea
			// 
			addPhilosophicalIdea.Location = new Point(700, 21);
			addPhilosophicalIdea.Name = "addPhilosophicalIdea";
			addPhilosophicalIdea.Size = new Size(190, 29);
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
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightYellow;
			ClientSize = new Size(1013, 587);
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
			Name = "WritingYourIdeasHere";
			Text = "FlowingIdeas";
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