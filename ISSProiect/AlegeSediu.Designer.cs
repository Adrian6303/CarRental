namespace ISSProiect
{
    partial class AlegeSediu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SediiDataGridView = new DataGridView();
            label1 = new Label();
            SelectButton = new Button();
            ((System.ComponentModel.ISupportInitialize)SediiDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SediiDataGridView
            // 
            SediiDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SediiDataGridView.Location = new Point(97, 122);
            SediiDataGridView.Name = "SediiDataGridView";
            SediiDataGridView.RowHeadersWidth = 51;
            SediiDataGridView.Size = new Size(604, 188);
            SediiDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 69);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 1;
            label1.Text = "Selecteaza un Sediu ";
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(335, 352);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(94, 29);
            SelectButton.TabIndex = 2;
            SelectButton.Text = "Select";
            SelectButton.UseVisualStyleBackColor = true;
            // 
            // AlegeSediu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SelectButton);
            Controls.Add(label1);
            Controls.Add(SediiDataGridView);
            Name = "AlegeSediu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)SediiDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView SediiDataGridView;
        private Label label1;
        private Button SelectButton;
    }
}