namespace ISSProiect
{
    partial class Rezervare
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
            MasiniDataGridView = new DataGridView();
            StartDateTimePicker = new DateTimePicker();
            RezervaButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DescriereTextBox = new TextBox();
            BackButton = new Button();
            SearchButton = new Button();
            NrZileNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)MasiniDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NrZileNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // MasiniDataGridView
            // 
            MasiniDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MasiniDataGridView.Location = new Point(74, 169);
            MasiniDataGridView.Name = "MasiniDataGridView";
            MasiniDataGridView.RowHeadersWidth = 51;
            MasiniDataGridView.RowTemplate.Height = 29;
            MasiniDataGridView.Size = new Size(626, 274);
            MasiniDataGridView.TabIndex = 0;
            MasiniDataGridView.RowHeaderMouseClick += MasiniDataGridView_RowHeaderMouseClick;
            // 
            // StartDateTimePicker
            // 
            StartDateTimePicker.Location = new Point(74, 64);
            StartDateTimePicker.Name = "StartDateTimePicker";
            StartDateTimePicker.Size = new Size(250, 27);
            StartDateTimePicker.TabIndex = 1;
            // 
            // RezervaButton
            // 
            RezervaButton.Location = new Point(451, 490);
            RezervaButton.Name = "RezervaButton";
            RezervaButton.Size = new Size(94, 29);
            RezervaButton.TabIndex = 3;
            RezervaButton.Text = "Rezerva";
            RezervaButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 27);
            label1.Name = "label1";
            label1.Size = new Size(179, 20);
            label1.TabIndex = 4;
            label1.Text = "Selecteaza data Inchirierii";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 27);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 5;
            label2.Text = "Selecteaza nr de zile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 128);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 6;
            label3.Text = "Masini disponibile";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(784, 169);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 7;
            label4.Text = "Descriere masina";
            // 
            // DescriereTextBox
            // 
            DescriereTextBox.Location = new Point(740, 215);
            DescriereTextBox.Multiline = true;
            DescriereTextBox.Name = "DescriereTextBox";
            DescriereTextBox.Size = new Size(264, 171);
            DescriereTextBox.TabIndex = 8;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(50, 523);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 9;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(606, 62);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 10;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // NrZileNumericUpDown
            // 
            NrZileNumericUpDown.Location = new Point(441, 62);
            NrZileNumericUpDown.Name = "NrZileNumericUpDown";
            NrZileNumericUpDown.Size = new Size(86, 27);
            NrZileNumericUpDown.TabIndex = 11;
            // 
            // Rezervare
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 589);
            Controls.Add(NrZileNumericUpDown);
            Controls.Add(SearchButton);
            Controls.Add(BackButton);
            Controls.Add(DescriereTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RezervaButton);
            Controls.Add(StartDateTimePicker);
            Controls.Add(MasiniDataGridView);
            Name = "Rezervare";
            Text = "Rezervare";
            ((System.ComponentModel.ISupportInitialize)MasiniDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)NrZileNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MasiniDataGridView;
        private DateTimePicker StartDateTimePicker;
        private Button RezervaButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox DescriereTextBox;
        private Button BackButton;
        private Button SearchButton;
        private NumericUpDown NrZileNumericUpDown;
    }
}