namespace ISSProiect
{
    partial class Login
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
            LoginButton = new Button();
            SignUpButton = new Button();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            UserLabel = new Label();
            PasswordLabel = new Label();
            bindingSource1 = new BindingSource(components);
            NumeTextBox = new TextBox();
            AdresaTextBox = new TextBox();
            TelefonTextBox = new TextBox();
            NumeLabel = new Label();
            AdresaLabel = new Label();
            TelefonLabel = new Label();
            BackButton = new Button();
            NewAccountButton = new Button();
            AlreadyHasAccountButton = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(236, 231);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(440, 257);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(94, 29);
            SignUpButton.TabIndex = 1;
            SignUpButton.Text = "Sign up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(210, 65);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(160, 27);
            UsernameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(210, 146);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(160, 27);
            PasswordTextBox.TabIndex = 3;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(64, 65);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(111, 20);
            UserLabel.TabIndex = 5;
            UserLabel.Text = "username(CNP)";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(103, 146);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(72, 20);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "password";
            // 
            // NumeTextBox
            // 
            NumeTextBox.Location = new Point(524, 65);
            NumeTextBox.Name = "NumeTextBox";
            NumeTextBox.Size = new Size(125, 27);
            NumeTextBox.TabIndex = 7;
            // 
            // AdresaTextBox
            // 
            AdresaTextBox.Location = new Point(524, 125);
            AdresaTextBox.Name = "AdresaTextBox";
            AdresaTextBox.Size = new Size(125, 27);
            AdresaTextBox.TabIndex = 8;
            // 
            // TelefonTextBox
            // 
            TelefonTextBox.Location = new Point(524, 178);
            TelefonTextBox.Name = "TelefonTextBox";
            TelefonTextBox.Size = new Size(125, 27);
            TelefonTextBox.TabIndex = 9;
            // 
            // NumeLabel
            // 
            NumeLabel.AutoSize = true;
            NumeLabel.Location = new Point(413, 65);
            NumeLabel.Name = "NumeLabel";
            NumeLabel.Size = new Size(105, 20);
            NumeLabel.TabIndex = 11;
            NumeLabel.Text = "nume complet";
            // 
            // AdresaLabel
            // 
            AdresaLabel.AutoSize = true;
            AdresaLabel.Location = new Point(440, 125);
            AdresaLabel.Name = "AdresaLabel";
            AdresaLabel.Size = new Size(53, 20);
            AdresaLabel.TabIndex = 12;
            AdresaLabel.Text = "adresa";
            // 
            // TelefonLabel
            // 
            TelefonLabel.AutoSize = true;
            TelefonLabel.Location = new Point(440, 185);
            TelefonLabel.Name = "TelefonLabel";
            TelefonLabel.Size = new Size(56, 20);
            TelefonLabel.TabIndex = 13;
            TelefonLabel.Text = "telefon";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(35, 338);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 14;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // NewAccountButton
            // 
            NewAccountButton.Location = new Point(524, 338);
            NewAccountButton.Name = "NewAccountButton";
            NewAccountButton.Size = new Size(107, 29);
            NewAccountButton.TabIndex = 15;
            NewAccountButton.Text = "New Account";
            NewAccountButton.UseVisualStyleBackColor = true;
            NewAccountButton.Click += NewAccountButton_Click;
            // 
            // AlreadyHasAccountButton
            // 
            AlreadyHasAccountButton.Location = new Point(515, 338);
            AlreadyHasAccountButton.Name = "AlreadyHasAccountButton";
            AlreadyHasAccountButton.Size = new Size(116, 29);
            AlreadyHasAccountButton.TabIndex = 16;
            AlreadyHasAccountButton.Text = "I have account";
            AlreadyHasAccountButton.UseVisualStyleBackColor = true;
            AlreadyHasAccountButton.Click += AlreadyHasAccountButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 384);
            Controls.Add(AlreadyHasAccountButton);
            Controls.Add(NewAccountButton);
            Controls.Add(BackButton);
            Controls.Add(TelefonLabel);
            Controls.Add(AdresaLabel);
            Controls.Add(NumeLabel);
            Controls.Add(TelefonTextBox);
            Controls.Add(AdresaTextBox);
            Controls.Add(NumeTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UserLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(SignUpButton);
            Controls.Add(LoginButton);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Label UserLabel;
        private Label PasswordLabel;
        private BindingSource bindingSource1;
        private TextBox NumeTextBox;
        private TextBox AdresaTextBox;
        private TextBox TelefonTextBox;
        private Label NumeLabel;
        private Label AdresaLabel;
        private Label TelefonLabel;
        private Button LoginButton;
        private Button SignUpButton;
        private Button BackButton;
        private Button NewAccountButton;
        private Button AlreadyHasAccountButton;
    }
}