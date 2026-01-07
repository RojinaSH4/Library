using Library;

namespace EditLibrary
{
    public partial class frmEdit : Form
    {
        public event Action<List<string>> DataUpdated;

        public frmEdit(List<BookInfo> books)
        {
            InitializeComponent();
            dataGridView1.DataSource = books.Select(b => new
            {
                b.Title,
                b.Author,
                b.Year,
            }).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var updatedData = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string info = $"{row.Cells["Title"].Value} - {row.Cells["Author"].Value} - {row.Cells["Year"].Value} - {row.Cells["PagesOrSize"].Value}";
                updatedData.Add(info);
            }

            DataUpdated?.Invoke(updatedData);

            this.Close();
        }
        
    }
}
