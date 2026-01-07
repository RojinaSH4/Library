using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Information;


namespace EditLip
{
    /// <summary>
    /// Form for editing existing book records.
    /// Allows modifying, deleting, and validating books.
    /// </summary>
    public partial class frmEdit : Form
    {
        // Editable copy of the book list (temporary changes)
        private List<BookInfo> books = new List<BookInfo>();

        // Reference to the original book list (changes applied on save)
        private List<BookInfo> originalBooks;

        /// <summary>
        /// Constructor: Initializes the edit form and binds cloned books.
        /// </summary>
        public frmEdit(List<BookInfo> Inputbooks)
        {
            InitializeComponent();
            originalBooks = Inputbooks;

            // Attach validation and change events
            dgvEdit.CellValidating += dgvEdit_CellValidating;
            dgvEdit.CellValueChanged += dgvEdit_CellValueChanged;

            // Clone books to prevent direct modification of the original list
            foreach (var book in Inputbooks)
            {
                books.Add(BookFactory.Clone(book));
            }

            // Bind editable book list to DataGridView
            dgvEdit.DataSource = books;
        }

        /// <summary>
        /// Deletes the selected book from the list.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEdit.CurrentRow == null)
            {
                MessageBox.Show("Please select a book to delete.", "Warning");
                return;
            }

            var removeBook = dgvEdit.CurrentRow.DataBoundItem as BookInfo;
            if (removeBook != null)
            {
                books.Remove(removeBook);

                // Refresh DataGridView after deletion
                dgvEdit.DataSource = new BindingList<BookInfo>(books);
            }
        }

        /// <summary>
        /// Validates DataGridView cell input for Type and Year columns.
        /// </summary>
        private void dgvEdit_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = dgvEdit.Columns[e.ColumnIndex].Name;

            // Validate book type input
            if (columnName == "Type")
            {
                string newType = e.FormattedValue?.ToString();
                string[] validType = { "Printed", "EBook", "AudioBook" };

                if (!validType.Contains(newType))
                {
                    dgvEdit.Rows[e.RowIndex].ErrorText =
                        "Valid types: Printed, EBook, AudioBook";

                    TypeErrorProvider.SetError(
                        dgvEdit,
                        "Invalid book type. Use Printed, EBook, or AudioBook."
                    );

                    e.Cancel = true;
                }
                else
                {
                    dgvEdit.Rows[e.RowIndex].ErrorText = string.Empty;
                    TypeErrorProvider.SetError(dgvEdit, string.Empty);
                }
            }

            // Validate year (must be 3 or 4 digits)
            if (columnName == "Year")
            {
                if (!int.TryParse(e.FormattedValue?.ToString(), out int year) ||
                    year < 100 || year > 9999)
                {
                    dgvEdit.Rows[e.RowIndex].ErrorText =
                        "Year must be a 3 or 4 digit number.";

                    MessageBox.Show(
                        "Please enter a valid year (3 or 4 digits).",
                        "Invalid Year"
                    );

                    e.Cancel = true;
                }
                else
                {
                    dgvEdit.Rows[e.RowIndex].ErrorText = string.Empty;
                }
            }
        }

        /// <summary>
        /// Handles changes to DataGridView cells.
        /// Recreates the book object if the Type changes.
        /// </summary>
        private void dgvEdit_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Only handle Type changes
            if (dgvEdit.Columns[e.ColumnIndex].Name == "Type")
            {
                var oldBook = dgvEdit.Rows[e.RowIndex].DataBoundItem as BookInfo;
                if (oldBook == null) return;

                string newType = dgvEdit.Rows[e.RowIndex].Cells["Type"].Value?.ToString();

                if (oldBook.Type == newType)
                    return;

                // Determine the numeric value to preserve
                double value = oldBook switch
                {
                    PrintedBook p => p.Pages,
                    EBook eBook => eBook.FileSize,
                    AudioBook audio => audio.Duration,
                    _ => oldBook.Size
                };

                // Create a new book instance with the new type
                BookInfo newBook = BookFactory.CreateBook(
                    oldBook.Title,
                    oldBook.Author,
                    oldBook.Year,
                    newType,
                    value
                );

                // Replace old book with new one
                int index = books.IndexOf(oldBook);
                books[index] = newBook;

                // Refresh DataGridView
                dgvEdit.DataSource = new BindingList<BookInfo>(books);
            }
        }


        /// <summary>
        /// Saves all changes and updates the original book list.
        /// </summary>
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            originalBooks.Clear();
            foreach (var book in books)
                originalBooks.Add(BookFactory.Clone(book));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
