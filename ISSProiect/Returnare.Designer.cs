namespace ISSProiect
{
    partial class Returnare
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
            label1 = new Label();
            MasiniDataGridView = new DataGridView();
            ReturneazaButton = new Button();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)MasiniDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 39);
            label1.Name = "label1";
            label1.Size = new Size(261, 20);
            label1.TabIndex = 0;
            label1.Text = "Alege Masina ce doresti sa o returnezi";
            // 
            // MasiniDataGridView
            // 
            MasiniDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MasiniDataGridView.Location = new Point(121, 90);
            MasiniDataGridView.Name = "MasiniDataGridView";
            MasiniDataGridView.RowHeadersWidth = 51;
            MasiniDataGridView.RowTemplate.Height = 29;
            MasiniDataGridView.Size = new Size(508, 188);
            MasiniDataGridView.TabIndex = 1;
            // 
            // ReturneazaButton
            // 
            ReturneazaButton.Location = new Point(322, 333);
            ReturneazaButton.Name = "ReturneazaButton";
            ReturneazaButton.Size = new Size(94, 29);
            ReturneazaButton.TabIndex = 2;
            ReturneazaButton.Text = "Returneaza";
            ReturneazaButton.UseVisualStyleBackColor = true;
            ReturneazaButton.Click += ReturneazaButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(49, 391);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 3;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // Returnare
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackButton);
            Controls.Add(ReturneazaButton);
            Controls.Add(MasiniDataGridView);
            Controls.Add(label1);
            Name = "Returnare";
            Text = "Returnare";
            ((System.ComponentModel.ISupportInitialize)MasiniDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView MasiniDataGridView;
        private Button ReturneazaButton;
        private Button BackButton;
    }
}