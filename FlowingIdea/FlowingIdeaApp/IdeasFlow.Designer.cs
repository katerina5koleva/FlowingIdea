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
            emptyUsernameBoxError = new ErrorProvider(components);
            shortUsernameError = new ErrorProvider(components);
            longUsernameError = new ErrorProvider(components);
            accountDoesNotExistError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)owlbertImage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptyUsernameBoxError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shortUsernameError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)longUsernameError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountDoesNotExistError).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(416, 147);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(271, 23);
            txtUsername.TabIndex = 1;
            // 
            // UsenameLable
            // 
            UsenameLable.AutoSize = true;
            UsenameLable.Font = new Font("Rockwell", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            UsenameLable.ForeColor = Color.Brown;
            UsenameLable.Location = new Point(416, 127);
            UsenameLable.Name = "UsenameLable";
            UsenameLable.Size = new Size(81, 18);
            UsenameLable.TabIndex = 5;
            UsenameLable.Text = "Username:";
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = Color.FromArgb(192, 255, 192);
            buttonLogIn.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogIn.ForeColor = Color.SeaGreen;
            buttonLogIn.Location = new Point(424, 188);
            buttonLogIn.Margin = new Padding(3, 2, 3, 2);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(82, 22);
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
            buttonCancel.Location = new Point(600, 188);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(82, 22);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // owlbertImage1
            // 
            owlbertImage1.Image = FlowingIdeaApp.Properties.Resources.owlbert22;
            owlbertImage1.Location = new Point(10, 22);
            owlbertImage1.Margin = new Padding(3, 2, 3, 2);
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
            buttonSignUp.Location = new Point(511, 188);
            buttonSignUp.Margin = new Padding(3, 2, 3, 2);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(82, 22);
            buttonSignUp.TabIndex = 10;
            buttonSignUp.Text = "Sign up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click_1;
            // 
            // emptyUsernameBoxError
            // 
            emptyUsernameBoxError.ContainerControl = this;
            // 
            // shortUsernameError
            // 
            shortUsernameError.ContainerControl = this;
            // 
            // longUsernameError
            // 
            longUsernameError.ContainerControl = this;
            // 
            // accountDoesNotExistError
            // 
            accountDoesNotExistError.ContainerControl = this;
            // 
            // IdeasFlow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightYellow;
            ClientSize = new Size(741, 424);
            Controls.Add(buttonSignUp);
            Controls.Add(owlbertImage1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogIn);
            Controls.Add(UsenameLable);
            Controls.Add(txtUsername);
            Margin = new Padding(3, 2, 3, 2);
            Name = "IdeasFlow";
            Text = "IdeasFlow";
            Load += IdeasFlow_Load;
            ((System.ComponentModel.ISupportInitialize)owlbertImage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptyUsernameBoxError).EndInit();
            ((System.ComponentModel.ISupportInitialize)shortUsernameError).EndInit();
            ((System.ComponentModel.ISupportInitialize)longUsernameError).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountDoesNotExistError).EndInit();
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
		private ErrorProvider emptyUsernameBoxError;
		private ErrorProvider shortUsernameError;
		private ErrorProvider longUsernameError;
		private ErrorProvider accountDoesNotExistError;
	}
}