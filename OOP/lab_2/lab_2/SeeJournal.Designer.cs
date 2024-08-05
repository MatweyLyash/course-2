namespace lab_2
{
    partial class SeeJournal
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
            savedForm = new Label();
            readingForm = new RichTextBox();
            cleare = new Button();
            SuspendLayout();
            // 
            // savedForm
            // 
            savedForm.AutoSize = true;
            savedForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            savedForm.Location = new Point(31, 23);
            savedForm.Name = "savedForm";
            savedForm.Size = new Size(208, 28);
            savedForm.TabIndex = 0;
            savedForm.Text = "Сохранённые формы";
            // 
            // readingForm
            // 
            readingForm.Location = new Point(31, 70);
            readingForm.Name = "readingForm";
            readingForm.Size = new Size(757, 173);
            readingForm.TabIndex = 27;
            readingForm.Text = "";
            // 
            // cleare
            // 
            cleare.Location = new Point(694, 387);
            cleare.Name = "cleare";
            cleare.Size = new Size(94, 29);
            cleare.TabIndex = 32;
            cleare.Text = "Очистить";
            cleare.UseVisualStyleBackColor = true;
            cleare.Click += cleare_Click;
            // 
            // SeeJournal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cleare);
            Controls.Add(readingForm);
            Controls.Add(savedForm);
            Location = new Point(100, 200);
            Name = "SeeJournal";
            Text = "SeeJournal";
            Load += SeeJournal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label savedForm;
        public RichTextBox readingForm;
        private Button cleare;
    }
}