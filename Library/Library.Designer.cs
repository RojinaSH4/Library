namespace Library
{
    partial class FrmLibrary
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibrary));
            label1 = new Label();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblYear = new Label();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtYear = new TextBox();
            lblType = new Label();
            cmbType = new ComboBox();
            txtPageOrSize = new TextBox();
            Books = new ListBox();
            lblPageOrSize = new Label();
            btnAddInfo = new Button();
            btnEdit = new Button();
            ttRightIn = new ToolTip(components);
            btnSaveList = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(250, 230, 160);
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(145, 27);
            label1.TabIndex = 0;
            label1.Text = "Information :";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(250, 230, 160);
            lblTitle.Location = new Point(23, 74);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(49, 18);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title : ";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAuthor.ForeColor = Color.FromArgb(250, 230, 160);
            lblAuthor.Location = new Point(21, 113);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(61, 18);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Author :";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblYear.ForeColor = Color.FromArgb(250, 230, 160);
            lblYear.Location = new Point(21, 155);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(46, 18);
            lblYear.TabIndex = 3;
            lblYear.Text = "Year :";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(255, 252, 240);
            txtTitle.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(131, 73);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 5;
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = Color.FromArgb(255, 252, 240);
            txtAuthor.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAuthor.Location = new Point(131, 113);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 6;
            // 
            // txtYear
            // 
            txtYear.BackColor = Color.FromArgb(255, 252, 240);
            txtYear.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtYear.Location = new Point(131, 155);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 7;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.ForeColor = Color.FromArgb(250, 230, 160);
            lblType.Location = new Point(23, 199);
            lblType.Name = "lblType";
            lblType.Size = new Size(85, 18);
            lblType.TabIndex = 9;
            lblType.Text = "Book Type :";
            // 
            // cmbType
            // 
            cmbType.BackColor = Color.FromArgb(255, 252, 240);
            cmbType.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Printed", "EBook", "AudioBook" });
            cmbType.Location = new Point(131, 193);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(100, 24);
            cmbType.TabIndex = 10;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged_1;
            // 
            // txtPageOrSize
            // 
            txtPageOrSize.BackColor = Color.FromArgb(255, 252, 240);
            txtPageOrSize.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPageOrSize.Location = new Point(131, 222);
            txtPageOrSize.Name = "txtPageOrSize";
            txtPageOrSize.Size = new Size(48, 23);
            txtPageOrSize.TabIndex = 11;
            // 
            // Books
            // 
            Books.BackColor = Color.FromArgb(255, 252, 240);
            Books.Font = new Font("Sylfaen", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Books.FormattingEnabled = true;
            Books.ItemHeight = 18;
            Books.Location = new Point(255, 24);
            Books.Name = "Books";
            Books.Size = new Size(409, 310);
            Books.TabIndex = 12;
            // 
            // lblPageOrSize
            // 
            lblPageOrSize.AutoSize = true;
            lblPageOrSize.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPageOrSize.ForeColor = Color.FromArgb(250, 230, 160);
            lblPageOrSize.Location = new Point(23, 228);
            lblPageOrSize.Name = "lblPageOrSize";
            lblPageOrSize.Size = new Size(0, 18);
            lblPageOrSize.TabIndex = 13;
            // 
            // btnAddInfo
            // 
            btnAddInfo.BackColor = Color.FromArgb(250, 230, 160);
            btnAddInfo.FlatStyle = FlatStyle.Flat;
            btnAddInfo.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddInfo.Location = new Point(21, 261);
            btnAddInfo.Name = "btnAddInfo";
            btnAddInfo.Size = new Size(100, 32);
            btnAddInfo.TabIndex = 8;
            btnAddInfo.Text = "Add Info";
            btnAddInfo.UseVisualStyleBackColor = false;
            btnAddInfo.Click += btnAddInfo_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(250, 230, 160);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(131, 261);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 32);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit Info";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSaveList
            // 
            btnSaveList.BackColor = Color.FromArgb(250, 230, 160);
            btnSaveList.FlatStyle = FlatStyle.Flat;
            btnSaveList.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveList.Location = new Point(21, 302);
            btnSaveList.Name = "btnSaveList";
            btnSaveList.Size = new Size(210, 32);
            btnSaveList.TabIndex = 15;
            btnSaveList.Text = "Save List";
            btnSaveList.UseVisualStyleBackColor = false;
            btnSaveList.Click += btnSaveList_Click;
            // 
            // FrmLibrary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 67, 32);
            ClientSize = new Size(687, 355);
            Controls.Add(btnSaveList);
            Controls.Add(btnEdit);
            Controls.Add(lblPageOrSize);
            Controls.Add(Books);
            Controls.Add(txtPageOrSize);
            Controls.Add(cmbType);
            Controls.Add(lblType);
            Controls.Add(btnAddInfo);
            Controls.Add(txtYear);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(lblYear);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmLibrary";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Library";
            Load += FrmLibrary_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblYear;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtYear;
        private Label lblType;
        private ComboBox cmbType;
        private TextBox txtPageOrSize;
        private ListBox Books;
        private Label lblPageOrSize;
        private Button btnAddInfo;
        private Button btnEdit;
        private ToolTip ttRightIn;
        private Button btnSaveList;
    }
}
