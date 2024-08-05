using Newtonsoft.Json;

namespace lab_2
{
    public class JsonManager
    {
        private string path;
        public string move;
        public JsonManager(string path)
        {
           this.path = path;
        }
        public void Serialize(Journal jornal)
        {
            List<Journal>? list = Deserialize();
            list.Add(jornal);
            string json = JsonConvert.SerializeObject(list,Formatting.Indented);
            File.WriteAllText(path, json);
            move = "Запись в журнал";
           
        }
        public List<Journal>? Deserialize()
        {
            string json = File.ReadAllText(path);
            List<Journal>? journals = JsonConvert.DeserializeObject<List<Journal>>(json);
            return journals;
            move = "Чтение из журнала";

        }

        public void Clear()
        {
            string json = File.ReadAllText(path);
            List<Journal>? journalList = JsonConvert.DeserializeObject<List<Journal>>(json);
            journalList?.Clear();
            string updatedJson = JsonConvert.SerializeObject(journalList, Formatting.Indented);
            File.WriteAllText(path, updatedJson);
            move = "Очистка журнала";

        }
    }
}
