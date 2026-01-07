using System;
using EditLip;
using Information;
using System.IO;
using System.Text.Json;

namespace Library
{
    /// <summary>
    /// Main form for managing the library and adding new books.
    /// </summary>
    public partial class FrmLibrary : Form
    {
        // Stores all added books
        public List<BookInfo> books = new List<BookInfo>();

        // Initializes the library form.
        public FrmLibrary()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Executes when the form is loaded.
        /// Sets tooltips for user guidance.
        /// </summary>
        private void FrmLibrary_Load(object sender, EventArgs e)
        {
            ttRightIn.ShowAlways = true;

            // Tooltip for numeric input (pages, size, or duration) and selecting book type: 
            ttRightIn.SetToolTip(txtPageOrSize, "Make sure to enter the correct value.");
            ttRightIn.SetToolTip(cmbType, "Make sure to select the correct book type.");
        }

        /// <summary>
        /// Handles the Add button click event.
        /// </summary>
        public void btnAddInfo_Click(object sender, EventArgs e)
        {
            InfoAdding();
        }

        /// <summary>
        /// Collects user input, validates data,
        /// and adds a new book to the list.
        /// </summary>
        public void InfoAdding()
        {
            // Check empty fields
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtYear.Text) ||
                string.IsNullOrWhiteSpace(txtPageOrSize.Text) ||
                cmbType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please fill in all fields before adding the book.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string title = txtTitle.Text;
            string author = txtAuthor.Text;

            // Get selected book type or default to Printed
            string type = cmbType.SelectedItem?.ToString() ?? "Printed";

            // Validate publication year (3 or 4 digits)
            if (!int.TryParse(txtYear.Text, out int year) ||
                  year < 100 || year > 9999)
            {
                MessageBox.Show(
                    "Please enter a valid year (3 or 4 digits).",
                    "Invalid Year"
                );
                return;
            }

            // Validate numeric value based on book type
            if (!double.TryParse(txtPageOrSize.Text, out double num))
            {
                MessageBox.Show(type == "Printed" ? "Please enter a valid number of PAGES!" :
                                type == "EBook" ? "Please enter a valid FILE SIZE!" :
                                "Please enter a valid DURATION!");
                return;
            }

            BookInfo newBook;
            try
            {
                // Create a new book using the factory pattern
                newBook = BookFactory.CreateBook(title, author, year, type, num);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            // Add book to list and display it
            books.Add(newBook);
            Books.Items.Add(newBook.GetInfo());

            // Clear input fields after adding
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            txtPageOrSize.Clear();
            cmbType.ResetText();
        }

        /// <summary>
        /// Updates the label text based on selected book type.
        /// </summary>
        public void cmbType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem.ToString() == "Printed")
            { lblPageOrSize.Text = "Pages:"; }

            else if (cmbType.SelectedItem.ToString() == "EBook")
            { lblPageOrSize.Text = "File Size (MB):"; }

            else
            { lblPageOrSize.Text = "Duration (Min):"; }

            // Clear previous numeric input
            txtPageOrSize.Clear();
        }

        /// <summary>
        /// Opens the edit form to modify existing books.
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEdit frm = new frmEdit(books);
            frm.ShowDialog();

            // Refresh the book list after editing
            Books.Items.Clear();
            foreach (var book in books)
                Books.Items.Add(book.GetInfo());
        }

        /// <summary>
        /// Opens a Save File dialog to save all books as a text file.
        /// Includes a header explaining each type of book (Printed, EBook, AudioBook).
        /// </summary>
        private void btnSaveList_Click(object sender, EventArgs e)
        {
            // Build SaveFileDialog
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.Title = "Save Books As Text File";
                sfd.FileName = "books.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            sw.WriteLine("Title | Author | Year | Type | Pages/File Size/Duration");
                            sw.WriteLine("--------------------------------------------------------");

                            foreach (var book in books)
                            {
                                // Each line: Title - Author - Year - Type - Pages/Size/Duration
                                sw.WriteLine($"  {book.Title}  |  {book.Author}  |  {book.Year}  |  {book.Type}  |  {book.Size} ");
                            }
                        }

                        MessageBox.Show("Books saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}

