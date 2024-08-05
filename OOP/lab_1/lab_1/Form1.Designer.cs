namespace lab_1
{
    partial class Calc
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
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calc());
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            one_input = new Button();
            two_input = new Button();
            three_input = new Button();
            four_input = new Button();
            six_input = new Button();
            five_input = new Button();
            eight_input = new Button();
            seven_input = new Button();
            nine_input = new Button();
            plus = new Button();
            cell = new Button();
            del_memory = new Button();
            rest = new Button();
            division = new Button();
            new_memory = new Button();
            clear = new Button();
            minus = new Button();
            textBox = new RichTextBox();
            multi = new Button();
            nol = new Button();
            ravno = new Button();
            SuspendLayout();
            // 
            // one_input
            // 
            one_input.Location = new Point(44, 200);
            one_input.Name = "one_input";
            one_input.Size = new Size(60, 50);
            one_input.TabIndex = 1;
            one_input.Text = "1";
            one_input.UseVisualStyleBackColor = true;
            one_input.Click += button1_Click;
            // 
            // two_input
            // 
            two_input.Location = new Point(110, 200);
            two_input.Name = "two_input";
            two_input.Size = new Size(60, 50);
            two_input.TabIndex = 2;
            two_input.Text = "2";
            two_input.UseVisualStyleBackColor = true;
            two_input.Click += two_input_Click;
            // 
            // three_input
            // 
            three_input.Location = new Point(176, 200);
            three_input.Name = "three_input";
            three_input.Size = new Size(60, 50);
            three_input.TabIndex = 3;
            three_input.Text = "3";
            three_input.UseVisualStyleBackColor = true;
            three_input.Click += three_input_Click;
            // 
            // four_input
            // 
            four_input.Location = new Point(44, 256);
            four_input.Name = "four_input";
            four_input.Size = new Size(60, 50);
            four_input.TabIndex = 4;
            four_input.Text = "4";
            four_input.UseVisualStyleBackColor = true;
            four_input.Click += button4_Click;
            // 
            // six_input
            // 
            six_input.Location = new Point(176, 256);
            six_input.Name = "six_input";
            six_input.Size = new Size(60, 50);
            six_input.TabIndex = 5;
            six_input.Text = "6";
            six_input.UseVisualStyleBackColor = true;
            six_input.Click += six_input_Click;
            // 
            // five_input
            // 
            five_input.Location = new Point(110, 256);
            five_input.Name = "five_input";
            five_input.Size = new Size(60, 50);
            five_input.TabIndex = 6;
            five_input.Text = "5";
            five_input.UseVisualStyleBackColor = true;
            five_input.Click += five_input_Click;
            // 
            // eight_input
            // 
            eight_input.Location = new Point(110, 312);
            eight_input.Name = "eight_input";
            eight_input.Size = new Size(60, 50);
            eight_input.TabIndex = 7;
            eight_input.Text = "8";
            eight_input.UseVisualStyleBackColor = true;
            eight_input.Click += eight_input_Click;
            // 
            // seven_input
            // 
            seven_input.Location = new Point(44, 312);
            seven_input.Name = "seven_input";
            seven_input.Size = new Size(60, 50);
            seven_input.TabIndex = 8;
            seven_input.Text = "7";
            seven_input.UseVisualStyleBackColor = true;
            seven_input.Click += seven_input_Click;
            // 
            // nine_input
            // 
            nine_input.Location = new Point(176, 312);
            nine_input.Name = "nine_input";
            nine_input.Size = new Size(60, 50);
            nine_input.TabIndex = 9;
            nine_input.Text = "9";
            nine_input.UseVisualStyleBackColor = true;
            nine_input.Click += nine_input_Click;
            // 
            // plus
            // 
            plus.Location = new Point(46, 119);
            plus.Name = "plus";
            plus.Size = new Size(60, 30);
            plus.TabIndex = 10;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // cell
            // 
            cell.Location = new Point(178, 155);
            cell.Name = "cell";
            cell.Size = new Size(60, 30);
            cell.TabIndex = 11;
            cell.Text = "cell";
            cell.UseVisualStyleBackColor = true;
            cell.Click += cell_button;
            // 
            // del_memory
            // 
            del_memory.Location = new Point(242, 156);
            del_memory.Name = "del_memory";
            del_memory.Size = new Size(60, 30);
            del_memory.TabIndex = 12;
            del_memory.Text = "DM";
            del_memory.UseVisualStyleBackColor = true;
            del_memory.Click += del_memory_Click;
            // 
            // rest
            // 
            rest.Location = new Point(178, 119);
            rest.Name = "rest";
            rest.Size = new Size(60, 30);
            rest.TabIndex = 13;
            rest.Text = "%";
            rest.UseVisualStyleBackColor = true;
            rest.Click += rest_Click;
            // 
            // division
            // 
            division.FlatStyle = FlatStyle.System;
            division.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            division.Location = new Point(114, 155);
            division.Name = "division";
            division.Size = new Size(60, 30);
            division.TabIndex = 14;
            division.Text = "/";
            division.UseVisualStyleBackColor = true;
            division.Click += division_button;
            // 
            // new_memory
            // 
            new_memory.Location = new Point(242, 119);
            new_memory.Name = "new_memory";
            new_memory.Size = new Size(60, 30);
            new_memory.TabIndex = 15;
            new_memory.Text = "NM";
            new_memory.UseVisualStyleBackColor = true;
            new_memory.Click += new_memory_button;
            // 
            // clear
            // 
            clear.Location = new Point(242, 200);
            clear.Name = "clear";
            clear.Size = new Size(60, 50);
            clear.TabIndex = 16;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // minus
            // 
            minus.Location = new Point(115, 119);
            minus.Name = "minus";
            minus.Size = new Size(60, 30);
            minus.TabIndex = 17;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_button;
            // 
            // textBox
            // 
            textBox.Location = new Point(36, 12);
            textBox.Name = "textBox";
            textBox.Size = new Size(300, 100);
            textBox.TabIndex = 19;
            textBox.Text = "";
            textBox.TextChanged += textBox_TextChanged;
            // 
            // multi
            // 
            multi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            multi.Location = new Point(46, 155);
            multi.Name = "multi";
            multi.Size = new Size(60, 30);
            multi.TabIndex = 18;
            multi.Text = "*";
            multi.UseVisualStyleBackColor = true;
            multi.Click += multi_bottun;
            // 
            // nol
            // 
            nol.Location = new Point(241, 312);
            nol.Name = "nol";
            nol.Size = new Size(60, 50);
            nol.TabIndex = 20;
            nol.Text = "0";
            nol.UseVisualStyleBackColor = true;
            nol.Click += nol_Click;
            // 
            // ravno
            // 
            ravno.Location = new Point(242, 256);
            ravno.Name = "ravno";
            ravno.Size = new Size(59, 50);
            ravno.TabIndex = 22;
            ravno.Text = "=";
            ravno.UseVisualStyleBackColor = true;
            ravno.Click += ravno_button;
            // 
            // Calc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 397);
            Controls.Add(ravno);
            Controls.Add(nol);
            Controls.Add(textBox);
            Controls.Add(multi);
            Controls.Add(minus);
            Controls.Add(clear);
            Controls.Add(new_memory);
            Controls.Add(division);
            Controls.Add(rest);
            Controls.Add(del_memory);
            Controls.Add(cell);
            Controls.Add(plus);
            Controls.Add(nine_input);
            Controls.Add(seven_input);
            Controls.Add(eight_input);
            Controls.Add(five_input);
            Controls.Add(six_input);
            Controls.Add(four_input);
            Controls.Add(three_input);
            Controls.Add(two_input);
            Controls.Add(one_input);
            Name = "Calc";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button one_input;
        private Button two_input;
        private Button three_input;
        private Button four_input;
        private Button six_input;
        private Button five_input;
        private Button eight_input;
        private Button seven_input;
        private Button nine_input;
        private Button plus;
        private Button cell;
        private Button del_memory;
        private Button rest;
        private Button division;
        private Button new_memory;
        private Button clear;
        private Button minus;
        private RichTextBox textBox;
        private Button multi;
        private Button nol;
        private Button ravno;
    }
}