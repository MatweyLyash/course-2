using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace lab_2
{
    public partial class Airport : Form
    {
        string modelName;
        int indexFirst = 0;
        int indexLast = 0;
        private void UpdateTime()
        {
            time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); 
        }
        public Airport()
        {
            InitializeComponent();
            ModelOne.CheckedChanged += ModalNameChanged;
            ModelTwo.CheckedChanged += ModalNameChanged;
            ModelThree.CheckedChanged += ModalNameChanged;
            ModelFour.CheckedChanged += ModalNameChanged;
            timer1.Interval = 1000;
            timer1.Start();
            UpdateTime();
            JsonManager jsonManager = new JsonManager("journal.json");
            List<Journal>? journals = jsonManager.Deserialize();
            amountJournal.Text = $"���-�� �������� = {journals.Count} |";
            lastUpdate.Text = "��������� ��������: ������� �����";
            menuStrip1.Visible = false;

        }
        private bool Validate(Journal journal)
        {
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(journal, new ValidationContext(journal), results, true))
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var item in results)
                {
                    stringBuilder.Append(item.ErrorMessage + '\n');
                }
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void save_Click(object sender, EventArgs e)
        {

            Journal journal = new Journal(
                modelName,
                IdMask.Text,
                typeOfAir.Text,
                (int)amountPassejer.Value,
                Capacity.Value,
                year.Text,
                DateService.Text,
                fioText.Text,
                positionInput.Text,
                (int)oldInput.Value,
                (int)numericUpDown4.Value
                );
            if (Validate(journal))
            {
                JsonManager jsonManager = new JsonManager("journal.json");
                jsonManager.Serialize(journal);
                lastUpdate.Text = "��������� ��������: ���������� � ������ ";

            }
        }

        private void openJournal_Click(object sender, EventArgs e)
        {
            SeeJournal seeJournal = new SeeJournal();


            JsonManager jsonManager = new JsonManager("journal.json");
            List<Journal> journals = jsonManager.Deserialize() ?? new List<Journal>();
            foreach (var journal in journals)
            {
                seeJournal.readingForm.Text += $"id: {journal.IdMask}, model: {journal.modelName}," +
                    $" type of air: {journal.TypeOfAir}, amount of passajer: {journal.AmountPassajer}, capacity: {journal.Capacity}, " +
                    $"release year: {journal.Year}, data of last service: {journal.DateService}, FIO: {journal.person.Name}, " +
                    $"position: {journal.person.Position}, seniority: {journal.person.Seniority}, age: {journal.person.Age}, " + '\n';
            }

            seeJournal.Show();
            lastUpdate.Text = "��������� ��������: ������ ������";

        }

        public void ModalNameChanged(object? sender, EventArgs e)
        {
            modelName = (sender as RadioButton).Text;
        }



        private void Capacity_Scroll(object sender, EventArgs e)
        {
            string f = Capacity.Value.ToString();
            capacityText.Text = $"����������������: {Capacity.Value} �";
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            lastUpdate.Text = "��������� ��������: ������ �����";
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "������: 1.0\n�����������: ������� ������ ����������",
                "� ���������",
                MessageBoxButtons.OK
                );
            lastUpdate.Text = "��������� ��������: ������� � ���������";
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();
            sort.Show();
            lastUpdate.Text = "��������� ��������: ������� ����������";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdMask.Text = string.Empty;
            ModelOne.Checked = false;
            ModelTwo.Checked = false;
            ModelThree.Checked = false;
            ModelFour.Checked = false;
            amountPassejer.Value = 0;
            capacityText.Text = "����������������: ";
            Capacity.Value = Capacity.Minimum;
            typeOfAir.SelectedIndex = -1;
            year.Text = string.Empty;
            DateService.Text = string.Empty;
            fioText.Text = string.Empty;
            oldInput.Value = oldInput.Minimum;
            numericUpDown4.Value = numericUpDown4.Minimum;
            positionInput.SelectedIndex = -1;
            lastUpdate.Text = "��������� ��������: ������� ����� ";



        }

        private void visiblePanel_CheckedChanged(object sender, EventArgs e)
        {
            if (visiblePanel.Checked == false)
            {
                menuStrip1.Visible = false;
            }
            else
            {
                menuStrip1.Visible = true;
            }
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_Click(sender, e);
        }

        private void insertValues(Journal currentJournal)
        {
            IdMask.Text = currentJournal.IdMask.ToString();
            switch (currentJournal.modelName)
            {
                case "Airbus":
                    {
                        ModelOne.Checked = true;
                        break;
                    }
                case "Boeing":
                    {
                        ModelTwo.Checked = true;
                        break;
                    }
                case "Antonov":
                    {
                        ModelThree.Checked = true;
                        break;
                    }
                case "Sukhoi":
                    {
                        ModelFour.Checked = true;
                        break;
                    }
            }
            amountPassejer.Value = int.Parse(currentJournal.AmountPassajer.ToString());
            capacityText.Text = $"����������������: {currentJournal.Capacity}";
            Capacity.Value = currentJournal.Capacity;
            switch (currentJournal.TypeOfAir)
            {
                case "�������":
                    {
                        typeOfAir.SelectedIndex = 2;
                        break;
                    }
                case "��������":
                    {
                        typeOfAir.SelectedIndex = 1;
                        break;
                    }
                case "������������":
                    {
                        typeOfAir.SelectedIndex = 0;
                        break;
                    }

            }
            year.Text = currentJournal.Year;
            DateService.Text = currentJournal.DateService;
            fioText.Text = currentJournal.person.Name;
            oldInput.Value = currentJournal.person.Age;
            numericUpDown4.Value = currentJournal.person.Seniority;
            switch (currentJournal.person.Position)
            {
                case "�����":
                    {
                        positionInput.SelectedIndex = 0;
                        break;
                    }
                case "������":
                    {
                        positionInput.SelectedIndex = 1;
                        break;
                    }
                case "���������":
                    {
                        positionInput.SelectedIndex = 2;
                        break;
                    }
            }
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JsonManager json = new JsonManager("journal.json");
            List<Journal>? journals = new List<Journal>();
            journals = json.Deserialize();
            Journal currentJournal = journals[indexFirst];
            insertValues(currentJournal);
            if (indexFirst < journals.Count - 1)
            {
                indexFirst++;
            }
            else
            {
                indexFirst = 0;
            }


        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JsonManager json = new JsonManager("journal.json");
            List<Journal>? journals = new List<Journal>();
            journals = json.Deserialize();
            if (indexLast == 0)
            {
                indexLast = journals.Count - 1;
            }
            Journal currentJournal = journals[indexLast];
            insertValues(currentJournal);
            indexLast--;
        }


    }
}