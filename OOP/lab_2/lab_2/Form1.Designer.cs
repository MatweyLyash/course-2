namespace lab_2
{
    partial class Airport
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
            MainLabel = new Label();
            Id = new Label();
            Type = new Label();
            typeOfAir = new ComboBox();
            ModelText = new Label();
            ModelOne = new RadioButton();
            ModelTwo = new RadioButton();
            ModelThree = new RadioButton();
            ModelFour = new RadioButton();
            AmountText = new Label();
            amountPassejer = new NumericUpDown();
            Capacity = new TrackBar();
            capacityText = new Label();
            year = new DomainUpDown();
            releaseYear = new Label();
            IdMask = new MaskedTextBox();
            inspection = new Label();
            DateService = new MaskedTextBox();
            person = new Label();
            fio = new Label();
            position = new Label();
            old = new Label();
            Стаж = new Label();
            fioText = new RichTextBox();
            oldInput = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            positionInput = new ComboBox();
            save = new Button();
            openJournal = new Button();
            menuStrip1 = new MenuStrip();
            поискToolStripMenuItem = new ToolStripMenuItem();
            сортировкаПоToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            очиститьToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            действиеToolStripMenuItem = new ToolStripMenuItem();
            вперёдToolStripMenuItem = new ToolStripMenuItem();
            назадToolStripMenuItem = new ToolStripMenuItem();
            time = new Label();
            amountJournal = new Label();
            lastUpdate = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            visiblePanel = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)amountPassejer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Capacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oldInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            MainLabel.Location = new Point(106, 38);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(349, 54);
            MainLabel.TabIndex = 0;
            MainLabel.Text = "Форма аэропорта";
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Id.Location = new Point(44, 87);
            Id.Name = "Id";
            Id.Size = new Size(35, 28);
            Id.TabIndex = 1;
            Id.Text = "ID:";
            // 
            // Type
            // 
            Type.AutoSize = true;
            Type.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Type.Location = new Point(369, 92);
            Type.Name = "Type";
            Type.Size = new Size(50, 28);
            Type.TabIndex = 2;
            Type.Text = "Тип:";
            // 
            // typeOfAir
            // 
            typeOfAir.DropDownStyle = ComboBoxStyle.DropDownList;
            typeOfAir.FormattingEnabled = true;
            typeOfAir.Items.AddRange(new object[] { "Пассажирский", "Грузовой", "Военный" });
            typeOfAir.Location = new Point(369, 123);
            typeOfAir.Name = "typeOfAir";
            typeOfAir.Size = new Size(151, 28);
            typeOfAir.TabIndex = 4;
            // 
            // ModelText
            // 
            ModelText.AutoSize = true;
            ModelText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModelText.Location = new Point(369, 160);
            ModelText.Name = "ModelText";
            ModelText.Size = new Size(88, 28);
            ModelText.TabIndex = 6;
            ModelText.Text = "Модель:";
            // 
            // ModelOne
            // 
            ModelOne.AutoSize = true;
            ModelOne.Location = new Point(369, 191);
            ModelOne.Name = "ModelOne";
            ModelOne.Size = new Size(72, 24);
            ModelOne.TabIndex = 7;
            ModelOne.TabStop = true;
            ModelOne.Text = "Airbus";
            ModelOne.UseVisualStyleBackColor = true;
            // 
            // ModelTwo
            // 
            ModelTwo.AutoSize = true;
            ModelTwo.Location = new Point(369, 221);
            ModelTwo.Name = "ModelTwo";
            ModelTwo.Size = new Size(77, 24);
            ModelTwo.TabIndex = 8;
            ModelTwo.TabStop = true;
            ModelTwo.Text = "Boeing";
            ModelTwo.UseVisualStyleBackColor = true;
            // 
            // ModelThree
            // 
            ModelThree.AutoSize = true;
            ModelThree.Location = new Point(369, 251);
            ModelThree.Name = "ModelThree";
            ModelThree.Size = new Size(86, 24);
            ModelThree.TabIndex = 9;
            ModelThree.TabStop = true;
            ModelThree.Text = "Antonov";
            ModelThree.UseVisualStyleBackColor = true;
            // 
            // ModelFour
            // 
            ModelFour.AutoSize = true;
            ModelFour.Location = new Point(369, 281);
            ModelFour.Name = "ModelFour";
            ModelFour.Size = new Size(74, 24);
            ModelFour.TabIndex = 10;
            ModelFour.TabStop = true;
            ModelFour.Text = "Sukhoi";
            ModelFour.UseVisualStyleBackColor = true;
            // 
            // AmountText
            // 
            AmountText.AutoSize = true;
            AmountText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AmountText.Location = new Point(44, 155);
            AmountText.Name = "AmountText";
            AmountText.Size = new Size(262, 28);
            AmountText.TabIndex = 11;
            AmountText.Text = "Кол-во пассажирских мест:";
            // 
            // amountPassejer
            // 
            amountPassejer.Location = new Point(48, 200);
            amountPassejer.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            amountPassejer.Name = "amountPassejer";
            amountPassejer.Size = new Size(150, 27);
            amountPassejer.TabIndex = 12;
            // 
            // Capacity
            // 
            Capacity.Location = new Point(35, 281);
            Capacity.Maximum = 160;
            Capacity.Minimum = 20;
            Capacity.Name = "Capacity";
            Capacity.Size = new Size(274, 56);
            Capacity.SmallChange = 20;
            Capacity.TabIndex = 14;
            Capacity.TickFrequency = 20;
            Capacity.Value = 20;
            Capacity.Scroll += Capacity_Scroll;
            // 
            // capacityText
            // 
            capacityText.AutoSize = true;
            capacityText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            capacityText.Location = new Point(44, 246);
            capacityText.Name = "capacityText";
            capacityText.Size = new Size(195, 28);
            capacityText.TabIndex = 15;
            capacityText.Text = "Грузоподъёмность: ";
            // 
            // year
            // 
            year.Items.Add("1984");
            year.Items.Add("1996");
            year.Items.Add("2004");
            year.Items.Add("2007");
            year.Items.Add("2021");
            year.Location = new Point(48, 361);
            year.Name = "year";
            year.Size = new Size(150, 27);
            year.TabIndex = 16;
            year.Text = "Выберите";
            // 
            // releaseYear
            // 
            releaseYear.AutoSize = true;
            releaseYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            releaseYear.Location = new Point(48, 321);
            releaseYear.Name = "releaseYear";
            releaseYear.Size = new Size(129, 28);
            releaseYear.TabIndex = 17;
            releaseYear.Text = "Год выпуска:";
            // 
            // IdMask
            // 
            IdMask.Location = new Point(48, 125);
            IdMask.Mask = "0000000000";
            IdMask.Name = "IdMask";
            IdMask.Size = new Size(125, 27);
            IdMask.TabIndex = 18;
            IdMask.ValidatingType = typeof(int);
            // 
            // inspection
            // 
            inspection.AutoEllipsis = true;
            inspection.AutoSize = true;
            inspection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inspection.Location = new Point(369, 303);
            inspection.MaximumSize = new Size(200, 100);
            inspection.MinimumSize = new Size(100, 30);
            inspection.Name = "inspection";
            inspection.Size = new Size(188, 56);
            inspection.TabIndex = 19;
            inspection.Text = "Дата последнего тех. обслуживания:";
            // 
            // DateService
            // 
            DateService.Location = new Point(369, 360);
            DateService.Mask = "0000";
            DateService.Name = "DateService";
            DateService.Size = new Size(125, 27);
            DateService.TabIndex = 20;
            // 
            // person
            // 
            person.AutoSize = true;
            person.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            person.Location = new Point(203, 415);
            person.Name = "person";
            person.Size = new Size(170, 32);
            person.TabIndex = 21;
            person.Text = "Член экипажа";
            // 
            // fio
            // 
            fio.AutoSize = true;
            fio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fio.Location = new Point(48, 453);
            fio.Name = "fio";
            fio.Size = new Size(61, 28);
            fio.TabIndex = 22;
            fio.Text = "ФИО:";
            // 
            // position
            // 
            position.AutoSize = true;
            position.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            position.Location = new Point(375, 453);
            position.Name = "position";
            position.Size = new Size(119, 28);
            position.TabIndex = 23;
            position.Text = "Должность:";
            // 
            // old
            // 
            old.AutoSize = true;
            old.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            old.Location = new Point(44, 528);
            old.Name = "old";
            old.Size = new Size(87, 28);
            old.TabIndex = 24;
            old.Text = "Возраст:";
            // 
            // Стаж
            // 
            Стаж.AutoSize = true;
            Стаж.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Стаж.Location = new Point(375, 528);
            Стаж.Name = "Стаж";
            Стаж.Size = new Size(61, 28);
            Стаж.TabIndex = 25;
            Стаж.Text = "Стаж:";
            // 
            // fioText
            // 
            fioText.Location = new Point(44, 484);
            fioText.Name = "fioText";
            fioText.Size = new Size(240, 33);
            fioText.TabIndex = 26;
            fioText.Text = "";
            // 
            // oldInput
            // 
            oldInput.Location = new Point(44, 559);
            oldInput.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            oldInput.Name = "oldInput";
            oldInput.Size = new Size(150, 27);
            oldInput.TabIndex = 27;
            oldInput.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(375, 559);
            numericUpDown4.Maximum = new decimal(new int[] { 78, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(150, 27);
            numericUpDown4.TabIndex = 29;
            // 
            // positionInput
            // 
            positionInput.FormattingEnabled = true;
            positionInput.Items.AddRange(new object[] { "Пилот", "Стюард", "Диспетчер" });
            positionInput.Location = new Point(369, 484);
            positionInput.Name = "positionInput";
            positionInput.Size = new Size(151, 28);
            positionInput.TabIndex = 30;
            // 
            // save
            // 
            save.Location = new Point(257, 595);
            save.Name = "save";
            save.Size = new Size(94, 29);
            save.TabIndex = 31;
            save.Text = "Сохранить";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // openJournal
            // 
            openJournal.Location = new Point(446, 595);
            openJournal.Name = "openJournal";
            openJournal.Size = new Size(142, 29);
            openJournal.TabIndex = 32;
            openJournal.Text = "Открыть журнал";
            openJournal.UseVisualStyleBackColor = true;
            openJournal.Click += openJournal_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { поискToolStripMenuItem, сортировкаПоToolStripMenuItem, сохранитьToolStripMenuItem, очиститьToolStripMenuItem, оПрограммеToolStripMenuItem, действиеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(601, 28);
            menuStrip1.TabIndex = 33;
            menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            поискToolStripMenuItem.Size = new Size(66, 24);
            поискToolStripMenuItem.Text = "Поиск";
            поискToolStripMenuItem.Click += поискToolStripMenuItem_Click;
            // 
            // сортировкаПоToolStripMenuItem
            // 
            сортировкаПоToolStripMenuItem.Name = "сортировкаПоToolStripMenuItem";
            сортировкаПоToolStripMenuItem.Size = new Size(131, 24);
            сортировкаПоToolStripMenuItem.Text = "Сортировка по:";
            сортировкаПоToolStripMenuItem.Click += сортировкаПоToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(97, 24);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // очиститьToolStripMenuItem
            // 
            очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            очиститьToolStripMenuItem.Size = new Size(87, 24);
            очиститьToolStripMenuItem.Text = "Очистить";
            очиститьToolStripMenuItem.Click += очиститьToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(118, 24);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // действиеToolStripMenuItem
            // 
            действиеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вперёдToolStripMenuItem, назадToolStripMenuItem });
            действиеToolStripMenuItem.Name = "действиеToolStripMenuItem";
            действиеToolStripMenuItem.Size = new Size(88, 24);
            действиеToolStripMenuItem.Text = "Действие";
            // 
            // вперёдToolStripMenuItem
            // 
            вперёдToolStripMenuItem.Name = "вперёдToolStripMenuItem";
            вперёдToolStripMenuItem.Size = new Size(143, 26);
            вперёдToolStripMenuItem.Text = "Вперёд";
            вперёдToolStripMenuItem.Click += вперёдToolStripMenuItem_Click;
            // 
            // назадToolStripMenuItem
            // 
            назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            назадToolStripMenuItem.Size = new Size(143, 26);
            назадToolStripMenuItem.Text = "Назад";
            назадToolStripMenuItem.Click += назадToolStripMenuItem_Click;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Location = new Point(444, 28);
            time.Name = "time";
            time.Size = new Size(50, 20);
            time.TabIndex = 34;
            time.Text = "label1";
            // 
            // amountJournal
            // 
            amountJournal.AutoSize = true;
            amountJournal.Location = new Point(12, 635);
            amountJournal.Name = "amountJournal";
            amountJournal.Size = new Size(50, 20);
            amountJournal.TabIndex = 35;
            amountJournal.Text = "label1";
            // 
            // lastUpdate
            // 
            lastUpdate.AutoSize = true;
            lastUpdate.Location = new Point(172, 635);
            lastUpdate.Name = "lastUpdate";
            lastUpdate.Size = new Size(50, 20);
            lastUpdate.TabIndex = 36;
            lastUpdate.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // visiblePanel
            // 
            visiblePanel.AutoSize = true;
            visiblePanel.Location = new Point(8, 30);
            visiblePanel.Name = "visiblePanel";
            visiblePanel.Size = new Size(245, 24);
            visiblePanel.TabIndex = 37;
            visiblePanel.Text = "Открыть панель инструментов";
            visiblePanel.UseVisualStyleBackColor = true;
            visiblePanel.CheckedChanged += visiblePanel_CheckedChanged;
            // 
            // Airport
            // 
            ClientSize = new Size(601, 682);
            Controls.Add(visiblePanel);
            Controls.Add(lastUpdate);
            Controls.Add(amountJournal);
            Controls.Add(time);
            Controls.Add(openJournal);
            Controls.Add(save);
            Controls.Add(positionInput);
            Controls.Add(numericUpDown4);
            Controls.Add(oldInput);
            Controls.Add(fioText);
            Controls.Add(Стаж);
            Controls.Add(old);
            Controls.Add(position);
            Controls.Add(fio);
            Controls.Add(person);
            Controls.Add(DateService);
            Controls.Add(inspection);
            Controls.Add(IdMask);
            Controls.Add(releaseYear);
            Controls.Add(year);
            Controls.Add(capacityText);
            Controls.Add(Capacity);
            Controls.Add(amountPassejer);
            Controls.Add(AmountText);
            Controls.Add(ModelFour);
            Controls.Add(ModelThree);
            Controls.Add(ModelTwo);
            Controls.Add(ModelOne);
            Controls.Add(ModelText);
            Controls.Add(typeOfAir);
            Controls.Add(Type);
            Controls.Add(Id);
            Controls.Add(MainLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Airport";
            ((System.ComponentModel.ISupportInitialize)amountPassejer).EndInit();
            ((System.ComponentModel.ISupportInitialize)Capacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)oldInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainLabel;
        private Label Id;
        private Label Type;
        private ComboBox typeOfAir;
        private Label ModelText;
        private RadioButton ModelOne;
        private RadioButton ModelTwo;
        private RadioButton ModelThree;
        private RadioButton ModelFour;
        private Label AmountText;
        private NumericUpDown amountPassejer;
        private TrackBar Capacity;
        private Label capacityText;
        private DomainUpDown year;
        private Label releaseYear;
        private MaskedTextBox IdMask;
        private Label inspection;
        private MaskedTextBox DateService;
        private Label person;
        private Label fio;
        private Label position;
        private Label old;
        private Label Стаж;
        private RichTextBox fioText;
        private NumericUpDown oldInput;
        private NumericUpDown numericUpDown4;
        private ComboBox positionInput;
        private Button save;
        private Button openJournal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripMenuItem сортировкаПоToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Label time;
        private Label amountJournal;
        public Label lastUpdate;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private CheckBox visiblePanel;
        private ToolStripMenuItem действиеToolStripMenuItem;
        private ToolStripMenuItem вперёдToolStripMenuItem;
        private ToolStripMenuItem назадToolStripMenuItem;
    }
}