using WinFormsApp2.model;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        context db=new context();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

         
            var results = db.notes
                            .Where(n => n.Title.ToLower().Contains(keyword) ||
                                        n.Category.ToLower().Contains(keyword))
                            .Select(n => new
                            {
                                n.NoteId,
                                n.Title,
                                n.Category,
                                n.CreatedDate,
                                n.ReminderDate
                            })
                            .ToList();

            // lood dataGridView1
            dataGridView1.DataSource = results;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load all data
            dataGridView1.DataSource = db.notes.ToList();
        }

    }
}
