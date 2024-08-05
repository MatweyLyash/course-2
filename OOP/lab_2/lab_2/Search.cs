using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Search : Form
    {

        List<Journal> searchJournalList;
        private IEnumerable<Journal>? currentSearchResult;

        private void GetSearchResultsByType(string query, List<Journal> totalList)
        {
            Regex pattern = new Regex(query, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            currentSearchResult = totalList.Where(item => pattern.IsMatch(item.TypeOfAir.ToString())).ToList();
        }
        private void GetSearchResultsByAmount(string query, List<Journal> totalList)
        {
            Regex pattern = new Regex(query, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            currentSearchResult = totalList.Where(item => pattern.IsMatch(item.AmountPassajer.ToString())).ToList();
        }
        private void GetSearchResultsByCapacity(string query, List<Journal> totalList)
        {
            Regex pattern = new Regex(query, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            currentSearchResult = totalList.Where(item => pattern.IsMatch(item.Capacity.ToString())).ToList();
        }
        public Search()
        {
            InitializeComponent();

            JsonManager json = new JsonManager("journal.json");
            List<Journal>? journals = new List<Journal>();
            journals = json.Deserialize();
            foreach (var journal in journals)
            {
                resultOutput.Text += $"id: {journal.IdMask}, model: {journal.modelName}," +
                    $" type of air: {journal.TypeOfAir}, amount of passajer: {journal.AmountPassajer}, capacity: {journal.Capacity}, " +
                    $"release year: {journal.Year}, data of last service: {journal.DateService}, FIO: {journal.person.Name}, " +
                    $"position: {journal.person.Position}, seniority: {journal.person.Seniority}, age: {journal.person.Age}, " + '\n'; ;
            }

            currentSearchResult = new List<Journal>();
        }
        private void searchInputType_TextChanged(object sender, EventArgs e)
        {
            resultOutput.Text = string.Empty;
            JsonManager jsonManager = new JsonManager("journal.json");
            List<Journal>? journals = jsonManager.Deserialize();
            string query = searchInputType.Text;
            GetSearchResultsByType(query, journals);
            foreach (var journal in currentSearchResult)
            {
                resultOutput.Text += journal.ToString();
            }
        }



        private void searchInputAmount_TextChanged(object sender, EventArgs e)
        {
            resultOutput.Text = string.Empty;
            JsonManager jsonManager = new JsonManager("journal.json");
            List<Journal>? journals = jsonManager.Deserialize();
            string query = searchInputAmount.Text;
            GetSearchResultsByAmount(query, journals);
            foreach (var journal in currentSearchResult)
            {
                resultOutput.Text += journal.ToString();
            }
        }

        private void searchInputCapacity_TextChanged(object sender, EventArgs e)
        {
            resultOutput.Text = string.Empty;
            JsonManager jsonManager = new JsonManager("journal.json");
            List<Journal>? journals = jsonManager.Deserialize();
            string query = searchInputCapacity.Text;

            GetSearchResultsByCapacity(query, journals);
            foreach (var journal in currentSearchResult)
            {
                resultOutput.Text += journal.ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           
            JsonManager save = new JsonManager("search.json");
            
            foreach (var item in currentSearchResult)
            {
                save.Serialize(item);
            }

        }
    }
}
