using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
            JsonManager jsonManager = new JsonManager("journal.json");
            List<Journal>? journals = jsonManager.Deserialize();
            foreach (var journal in journals)
            {
                resultSort.Text += journal.ToString();
            }
        }

        private void byReleaseYear_CheckedChanged(object sender, EventArgs e)
        {
            if (byReleaseYear.Checked)
            {
                resultSort.Text = string.Empty;
                JsonManager jsonManager = new JsonManager("journal.json");
                List<Journal>? journals = jsonManager.Deserialize();
                List<Journal>? sorted = journals.OrderBy(item => item.Year).ToList();
                foreach (var journal in sorted)
                {
                    resultSort.Text += journal.ToString();
                }

            }
        }

        private void byService_CheckedChanged(object sender, EventArgs e)
        {
            if (byService.Checked)
            {
                resultSort.Text = string.Empty;
                JsonManager jsonManager = new JsonManager("journal.json");
                List<Journal>? journals = jsonManager.Deserialize();
                List<Journal>? sorted = journals.OrderBy(item => item.DateService).ToList();
                foreach (var journal in sorted)
                {
                    resultSort.Text += journal.ToString();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            JsonManager jsonManager = new JsonManager("journal.json");
            JsonManager save = new JsonManager("saveSort.json");
            List<Journal>? journals = jsonManager.Deserialize();
            if (byService.Checked)
            {  
                List<Journal>? sorted = journals.OrderBy(item => item.DateService).ToList();
                foreach (var journal in sorted)
                {
                    save.Serialize(journal);
                }
            }
            else if(byReleaseYear.Checked)
            {
                List<Journal>? sorted = journals.OrderBy(item => item.Year).ToList();
                foreach (var journal in sorted)
                {
                    save.Serialize(journal);
                }
            }
            else
            {
                foreach (var item in journals)
                {
                    save.Serialize(item);
                }
            }
        }
    }
}
