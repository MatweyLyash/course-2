using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace dapperPath.Model
{
    public class JsonManager
    {
        private string path;
        public string move;
        public JsonManager(string path)
        {
            this.path = path;
        }
        public void Serialize(Shoes jornal)
        {
            List<Shoes> list = Deserialize();
            list.Add(jornal);
            string json = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(path, json);
            

        }
        public List<Shoes> Deserialize()
        {
            string json = File.ReadAllText(path);
            List<Shoes> journals = JsonConvert.DeserializeObject<List<Shoes>>(json);
            return journals;


        }

        public void Clear()
        {
            string json = File.ReadAllText(path);
            List<Shoes> journalList = JsonConvert.DeserializeObject<List<Shoes>>(json);
            journalList?.Clear();
            string updatedJson = JsonConvert.SerializeObject(journalList, Formatting.Indented);
            File.WriteAllText(path, updatedJson);

        }
    }
}
