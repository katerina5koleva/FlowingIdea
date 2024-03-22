namespace FlowingIdeas.Presentation
{
	partial class IdeasFlow
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
			txtUsername = new TextBox();
			UsenameLable = new Label();
			buttonLogIn = new Button();
			buttonCancel = new Button();
			owlbertImage1 = new PictureBox();
			buttonSignUp = new Button();
			errorProvider1 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)owlbertImage1).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(451, 196);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(309, 27);
			txtUsername.TabIndex = 1;
			// 
			// UsenameLable
			// 
			UsenameLable.AutoSize = true;
			UsenameLable.Font = new Font("Rockwell", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			UsenameLable.ForeColor = Color.Brown;
			UsenameLable.Location = new Point(448, 171);
			UsenameLable.Name = "UsenameLable";
			UsenameLable.Size = new Size(97, 22);
			UsenameLable.TabIndex = 5;
			UsenameLable.Text = "Username:";
			// 
			// buttonLogIn
			// 
			buttonLogIn.BackColor = Color.FromArgb(192, 255, 192);
			buttonLogIn.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
			buttonLogIn.ForeColor = Color.SeaGreen;
			buttonLogIn.Location = new Point(453, 250);
			buttonLogIn.Name = "buttonLogIn";
			buttonLogIn.Size = new Size(94, 29);
			buttonLogIn.TabIndex = 7;
			buttonLogIn.Text = "Login";
			buttonLogIn.UseVisualStyleBackColor = false;
			buttonLogIn.Click += buttonLogIn_Click;
			// 
			// buttonCancel
			// 
			buttonCancel.BackColor = Color.PeachPuff;
			buttonCancel.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
			buttonCancel.ForeColor = Color.Crimson;
			buttonCancel.Location = new Point(653, 250);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new Size(94, 29);
			buttonCancel.TabIndex = 8;
			buttonCancel.Text = "Cancel";
			buttonCancel.UseVisualStyleBackColor = false;
			buttonCancel.Click += buttonCancel_Click;
			// 
			// owlbertImage1
			// 
			owlbertImage1.Image = FlowingIdeaApp.Properties.Resources.owlbert22;
			owlbertImage1.Location = new Point(12, 29);
			owlbertImage1.Name = "owlbertImage1";
			owlbertImage1.Size = new Size(400, 400);
			owlbertImage1.SizeMode = PictureBoxSizeMode.AutoSize;
			owlbertImage1.TabIndex = 9;
			owlbertImage1.TabStop = false;
			// 
			// buttonSignUp
			// 
			buttonSignUp.BackColor = Color.FromArgb(255, 255, 128);
			buttonSignUp.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
			buttonSignUp.ForeColor = Color.OrangeRed;
			buttonSignUp.Location = new Point(553, 250);
			buttonSignUp.Name = "buttonSignUp";
			buttonSignUp.Size = new Size(94, 29);
			buttonSignUp.TabIndex = 10;
			buttonSignUp.Text = "Sign up";
			buttonSignUp.UseVisualStyleBackColor = false;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// IdeasFlow
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			BackColor = Color.LightYellow;
			ClientSize = new Size(800, 451);
			Controls.Add(buttonSignUp);
			Controls.Add(owlbertImage1);
			Controls.Add(buttonCancel);
			Controls.Add(buttonLogIn);
			Controls.Add(UsenameLable);
			Controls.Add(txtUsername);
			Name = "IdeasFlow";
			Text = "IdeasFlow";
			Load += IdeasFlow_Load;
			((System.ComponentModel.ISupportInitialize)owlbertImage1).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox txtUsername;
		private Label UsenameLable;
		private Button buttonLogIn;
		private Button buttonCancel;
		private PictureBox owlbertImage1;
		private Button buttonSignUp;
		private ErrorProvider errorProvider1;
	}
}