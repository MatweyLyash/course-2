namespace search
{
    partial class Search
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
            searchInput = new TextBox();
            searchText = new Label();
            result = new RichTextBox();
            resultText = new Label();
            SuspendLayout();
            // 
            // searchInput
            // 
            searchInput.Location = new Point(26, 51);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(361, 27);
            searchInput.TabIndex = 0;
            // 
            // searchText
            // 
            searchText.AutoSize = true;
            searchText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchText.Location = new Point(26, 19);
            searchText.Name = "searchText";
            searchText.Size = new Size(73, 28);
            searchText.TabIndex = 1;
            searchText.Text = "Поиск:";
            // 
            // result
            // 
            result.Location = new Point(26, 144);
            result.Name = "result";
            result.Size = new Size(743, 120);
            result.TabIndex = 2;
            result.Text = "";
            // 
            // resultText
            // 
            resultText.AutoSize = true;
            resultText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultText.Location = new Point(26, 103);
            resultText.Name = "resultText";
            resultText.Size = new Size(173, 28);
            resultText.TabIndex = 3;
            resultText.Text = "Результат поиска:";
            resultText.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultText);
            Controls.Add(result);
            Controls.Add(searchText);
            Controls.Add(searchInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchInput;
        private Label searchText;
        private RichTextBox result;
        private Label resultText;
    }
}