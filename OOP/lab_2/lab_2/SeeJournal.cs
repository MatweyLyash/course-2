using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_2
{
    public partial class SeeJournal : Form

    {
        public SeeJournal()
        {
            InitializeComponent();

        }

        private void SeeJournal_Load(object sender, EventArgs e)
        {

        }

        private void readingForm_TextChanged(object sender, EventArgs e)
        {

        }

        private void cleare_Click(object sender, EventArgs e)
        {
            JsonManager jsonManager = new JsonManager("journal.json");
            jsonManager.Clear();
            readingForm.Text = string.Empty;
        }
    }
}
