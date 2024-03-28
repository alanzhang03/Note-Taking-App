namespace NoteTakingApp
{
    partial class NoteTaker
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
            titleBox = new TextBox();
            noteBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            previousNotes = new DataGridView();
            saveButton = new Button();
            deleteButton = new Button();
            newNoteButton = new Button();
            loadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // titleBox
            // 
            titleBox.Location = new Point(384, 35);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(404, 23);
            titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            noteBox.Location = new Point(384, 85);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(404, 362);
            noteBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(384, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 2;
            label1.Text = "Title:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.No;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(384, 61);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 3;
            label2.Text = "Notes:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // previousNotes
            // 
            previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNotes.BackgroundColor = SystemColors.ButtonFace;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.Location = new Point(12, 12);
            previousNotes.Name = "previousNotes";
            previousNotes.Size = new Size(366, 307);
            previousNotes.TabIndex = 4;
            previousNotes.CellDoubleClick += previousNotes_CellDoubleClick;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(196, 325);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(182, 58);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(196, 389);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(182, 58);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // newNoteButton
            // 
            newNoteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newNoteButton.Location = new Point(12, 389);
            newNoteButton.Name = "newNoteButton";
            newNoteButton.Size = new Size(178, 58);
            newNoteButton.TabIndex = 8;
            newNoteButton.Text = "New Note";
            newNoteButton.UseVisualStyleBackColor = true;
            newNoteButton.Click += newNoteButton_Click;
            // 
            // loadButton
            // 
            loadButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadButton.Location = new Point(8, 325);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(182, 58);
            loadButton.TabIndex = 10;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // NoteTaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(loadButton);
            Controls.Add(newNoteButton);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(previousNotes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(noteBox);
            Controls.Add(titleBox);
            Name = "NoteTaker";
            Text = "Note Taker";
            Load += NoteTaker_Load;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleBox;
        private TextBox noteBox;
        private Label label1;
        private Label label2;
        private DataGridView previousNotes;
        private Button saveButton;
        private Button deleteButton;
        private Button newNoteButton;
        private Button loadButton;
    }
}
