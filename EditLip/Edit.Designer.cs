namespace EditLip
{
    partial class frmEdit
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit));
            dgvEdit = new DataGridView();
            btnSave = new Button();
            btnDelete = new Button();
            TypeErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TypeErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // dgvEdit
            // 
            dataGridViewCellStyle1.Font = new Font("Sylfaen", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dgvEdit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEdit.BackgroundColor = Color.FromArgb(255, 252, 240);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEdit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEdit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Sylfaen", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEdit.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEdit.Location = new Point(12, 12);
            dgvEdit.Name = "dgvEdit";
            dgvEdit.Size = new Size(544, 265);
            dgvEdit.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(250, 230, 160);
            btnSave.BackgroundImageLayout = ImageLayout.None;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(12, 283);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 32);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(250, 230, 160);
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(456, 283);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 32);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // TypeErrorProvider
            // 
            TypeErrorProvider.ContainerControl = this;
            // 
            // frmEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 67, 32);
            ClientSize = new Size(568, 327);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(dgvEdit);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmEdit";
            Text = "Edit Info";
            ((System.ComponentModel.ISupportInitialize)dgvEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)TypeErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEdit;
        private Button btnSave;
        private Button btnDelete;
        private ErrorProvider TypeErrorProvider;
    }
}