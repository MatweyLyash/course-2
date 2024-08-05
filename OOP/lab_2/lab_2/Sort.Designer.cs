namespace lab_2
{
    partial class Sort
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
            sortText = new Label();
            resultSort = new RichTextBox();
            saveButton = new Button();
            byReleaseYear = new RadioButton();
            byService = new RadioButton();
            SuspendLayout();
            // 
            // sortText
            // 
            sortText.AutoSize = true;
            sortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sortText.Location = new Point(32, 27);
            sortText.Name = "sortText";
            sortText.Size = new Size(123, 28);
            sortText.TabIndex = 0;
            sortText.Text = "Сортировка";
            // 
            // resultSort
            // 
            resultSort.Location = new Point(32, 160);
            resultSort.Name = "resultSort";
            resultSort.Size = new Size(720, 201);
            resultSort.TabIndex = 1;
            resultSort.Text = "";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(658, 367);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 4;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // byReleaseYear
            // 
            byReleaseYear.AutoSize = true;
            byReleaseYear.Location = new Point(40, 73);
            byReleaseYear.Name = "byReleaseYear";
            byReleaseYear.Size = new Size(145, 24);
            byReleaseYear.TabIndex = 5;
            byReleaseYear.TabStop = true;
            byReleaseYear.Text = "По году выпуска";
            byReleaseYear.UseVisualStyleBackColor = true;
            byReleaseYear.CheckedChanged += byReleaseYear_CheckedChanged;
            // 
            // byService
            // 
            byService.AutoSize = true;
            byService.Location = new Point(38, 119);
            byService.Name = "byService";
            byService.Size = new Size(299, 24);
            byService.TabIndex = 6;
            byService.TabStop = true;
            byService.Text = "По дате последнего тех.обслуживания";
            byService.UseVisualStyleBackColor = true;
            byService.CheckedChanged += byService_CheckedChanged;
            // 
            // Sort
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(byService);
            Controls.Add(byReleaseYear);
            Controls.Add(saveButton);
            Controls.Add(resultSort);
            Controls.Add(sortText);
            Name = "Sort";
            Text = "Sort";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sortText;
        private RichTextBox resultSort;
        private Button saveButton;
        private RadioButton byReleaseYear;
        private RadioButton byService;
    }
}