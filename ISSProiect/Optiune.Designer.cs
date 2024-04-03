namespace ISSProiect
{
    partial class Optiune
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
            InchiriazaButton = new Button();
            ReturneazaButton = new Button();
            label1 = new Label();
            LogoutButton = new Button();
            SuspendLayout();
            // 
            // InchiriazaButton
            // 
            InchiriazaButton.Location = new Point(112, 137);
            InchiriazaButton.Name = "InchiriazaButton";
            InchiriazaButton.Size = new Size(94, 29);
            InchiriazaButton.TabIndex = 0;
            InchiriazaButton.Text = "Inchiriaza";
            InchiriazaButton.UseVisualStyleBackColor = true;
            InchiriazaButton.Click += InchiriazaButton_Click;
            // 
            // ReturneazaButton
            // 
            ReturneazaButton.Location = new Point(337, 137);
            ReturneazaButton.Name = "ReturneazaButton";
            ReturneazaButton.Size = new Size(94, 29);
            ReturneazaButton.TabIndex = 1;
            ReturneazaButton.Text = "Returneaza";
            ReturneazaButton.UseVisualStyleBackColor = true;
            ReturneazaButton.Click += ReturneazaButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 55);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 2;
            label1.Text = "Alege actiunea dorita";
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(220, 227);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(94, 29);
            LogoutButton.TabIndex = 3;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // Optiune
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 268);
            Controls.Add(LogoutButton);
            Controls.Add(label1);
            Controls.Add(ReturneazaButton);
            Controls.Add(InchiriazaButton);
            Name = "Optiune";
            Text = "Optiune";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InchiriazaButton;
        private Button ReturneazaButton;
        private Label label1;
        private Button LogoutButton;
    }
}