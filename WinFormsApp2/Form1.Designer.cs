namespace WinFormsApp2
{
    partial class Form1
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 23);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(280, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "search";
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Location = new Point(20, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(600, 300);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            ClientSize = new Size(650, 400);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Note Search";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}
