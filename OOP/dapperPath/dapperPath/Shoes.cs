using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dapperPath
{
    public class Shoes
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string AvailableSizes { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Sex { get; set; }
        public void Save()
        {
            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText("journal.json", json);
        }
    }

}
