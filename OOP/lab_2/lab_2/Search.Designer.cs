namespace lab_2
{
    partial class Search
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
            searchText = new Label();
            resultText = new Label();
            searchInputType = new TextBox();
            resultOutput = new RichTextBox();
            categoriesText = new Label();
            searchInputAmount = new TextBox();
            searchInputCapacity = new TextBox();
            typeText = new Label();
            amountText = new Label();
            capacityText = new Label();
            saveButton = new Button();
            SuspendLayout();
            // 
            // searchText
            // 
            searchText.AutoSize = true;
            searchText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchText.Location = new Point(12, 20);
            searchText.Name = "searchText";
            searchText.Size = new Size(69, 28);
            searchText.TabIndex = 0;
            searchText.Text = "Поиск";
            // 
            // resultText
            // 
            resultText.AutoSize = true;
            resultText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultText.Location = new Point(12, 181);
            resultText.Name = "resultText";
            resultText.Size = new Size(173, 28);
            resultText.TabIndex = 1;
            resultText.Text = "Результат поиска:";
            // 
            // searchInputType
            // 
            searchInputType.Location = new Point(12, 62);
            searchInputType.Name = "searchInputType";
            searchInputType.Size = new Size(321, 27);
            searchInputType.TabIndex = 2;
            searchInputType.TextChanged += searchInputType_TextChanged;
            // 
            // resultOutput
            // 
            resultOutput.Location = new Point(12, 232);
            resultOutput.Name = "resultOutput";
            resultOutput.Size = new Size(749, 120);
            resultOutput.TabIndex = 3;
            resultOutput.Text = "";
            // 
            // categoriesText
            // 
            categoriesText.AutoSize = true;
            categoriesText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoriesText.Location = new Point(395, 20);
            categoriesText.Name = "categoriesText";
            categoriesText.Size = new Size(112, 28);
            categoriesText.TabIndex = 4;
            categoriesText.Text = "Категории:";
            // 
            // searchInputAmount
            // 
            searchInputAmount.Location = new Point(12, 108);
            searchInputAmount.Name = "searchInputAmount";
            searchInputAmount.Size = new Size(321, 27);
            searchInputAmount.TabIndex = 11;
            searchInputAmount.TextChanged += searchInputAmount_TextChanged;
            // 
            // searchInputCapacity
            // 
            searchInputCapacity.Location = new Point(12, 151);
            searchInputCapacity.Name = "searchInputCapacity";
            searchInputCapacity.Size = new Size(321, 27);
            searchInputCapacity.TabIndex = 12;
            searchInputCapacity.TextChanged += searchInputCapacity_TextChanged;
            // 
            // typeText
            // 
            typeText.AutoSize = true;
            typeText.Location = new Point(395, 62);
            typeText.Name = "typeText";
            typeText.Size = new Size(64, 20);
            typeText.TabIndex = 13;
            typeText.Text = "По типу";
            // 
            // amountText
            // 
            amountText.AutoSize = true;
            amountText.Location = new Point(395, 108);
            amountText.Name = "amountText";
            amountText.Size = new Size(146, 20);
            amountText.TabIndex = 14;
            amountText.Text = "По количеству мест";
            // 
            // capacityText
            // 
            capacityText.AutoSize = true;
            capacityText.Location = new Point(395, 154);
            capacityText.Name = "capacityText";
            capacityText.Size = new Size(141, 20);
            capacityText.TabIndex = 15;
            capacityText.Text = "Грузоподъёмность";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(668, 394);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 16;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveButton);
            Controls.Add(capacityText);
            Controls.Add(amountText);
            Controls.Add(typeText);
            Controls.Add(searchInputCapacity);
            Controls.Add(searchInputAmount);
            Controls.Add(categoriesText);
            Controls.Add(resultOutput);
            Controls.Add(searchInputType);
            Controls.Add(resultText);
            Controls.Add(searchText);
            Name = "Search";
            Text = "Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label searchText;
        private Label resultText;
        private TextBox searchInputType;
        private RichTextBox resultOutput;
        private Label categoriesText;
        private TextBox searchInputAmount;
        private TextBox searchInputCapacity;
        private Label typeText;
        private Label amountText;
        private Label capacityText;
        private Button saveButton;
    }
}