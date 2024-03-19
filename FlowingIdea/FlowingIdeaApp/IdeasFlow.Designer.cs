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
            pictureBoxOwl1 = new PictureBox();
            Username = new TextBox();
            Password = new TextBox();
            LinkForgotPassword = new LinkLabel();
            ButtonShowPassword = new CheckBox();
            UsenameLable = new Label();
            PasswordLabel = new Label();
            buttonLogIn = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOwl1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxOwl1
            // 
            pictureBoxOwl1.Location = new Point(51, 53);
            pictureBoxOwl1.Margin = new Padding(3, 2, 3, 2);
            pictureBoxOwl1.Name = "pictureBoxOwl1";
            pictureBoxOwl1.Size = new Size(287, 236);
            pictureBoxOwl1.TabIndex = 0;
            pictureBoxOwl1.TabStop = false;
            // 
            // Username
            // 
            Username.Location = new Point(378, 118);
            Username.Margin = new Padding(3, 2, 3, 2);
            Username.Name = "Username";
            Username.Size = new Size(271, 23);
            Username.TabIndex = 1;
            // 
            // Password
            // 
            Password.Location = new Point(378, 176);
            Password.Margin = new Padding(3, 2, 3, 2);
            Password.Name = "Password";
            Password.Size = new Size(271, 23);
            Password.TabIndex = 2;
            // 
            // LinkForgotPassword
            // 
            LinkForgotPassword.AutoSize = true;
            LinkForgotPassword.Location = new Point(519, 201);
            LinkForgotPassword.Name = "LinkForgotPassword";
            LinkForgotPassword.Size = new Size(117, 15);
            LinkForgotPassword.TabIndex = 3;
            LinkForgotPassword.TabStop = true;
            LinkForgotPassword.Text = "Forgotten password?";
            // 
            // ButtonShowPassword
            // 
            ButtonShowPassword.AutoSize = true;
            ButtonShowPassword.Location = new Point(378, 198);
            ButtonShowPassword.Margin = new Padding(3, 2, 3, 2);
            ButtonShowPassword.Name = "ButtonShowPassword";
            ButtonShowPassword.Size = new Size(108, 19);
            ButtonShowPassword.TabIndex = 4;
            ButtonShowPassword.Text = "Show password";
            ButtonShowPassword.UseVisualStyleBackColor = true;
            // 
            // UsenameLable
            // 
            UsenameLable.AutoSize = true;
            UsenameLable.Location = new Point(378, 101);
            UsenameLable.Name = "UsenameLable";
            UsenameLable.Size = new Size(59, 15);
            UsenameLable.TabIndex = 5;
            UsenameLable.Text = "username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(378, 159);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "password";
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = Color.FromArgb(192, 255, 192);
            buttonLogIn.ForeColor = Color.Black;
            buttonLogIn.Location = new Point(378, 237);
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
            buttonCancel.BackColor = Color.Bisque;
            buttonCancel.Location = new Point(566, 237);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(82, 22);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // IdeasFlow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogIn);
            Controls.Add(PasswordLabel);
            Controls.Add(UsenameLable);
            Controls.Add(ButtonShowPassword);
            Controls.Add(LinkForgotPassword);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(pictureBoxOwl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "IdeasFlow";
            Text = "IdeasFlow";
            Load += IdeasFlow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxOwl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxOwl1;
		private TextBox Username;
		private TextBox Password;
		private LinkLabel LinkForgotPassword;
		private CheckBox ButtonShowPassword;
		private Label UsenameLable;
		private Label PasswordLabel;
		private Button buttonLogIn;
		private Button buttonCancel;
	}
}