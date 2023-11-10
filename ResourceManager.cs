using System.Data.SQLite;

namespace CharTable
{
    internal class ResourceManager: Observable<Item>
    {


        public static readonly string DatabasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Characters.db");
        private static ResourceManager? _instance;
        private List<Observer<Item>> ObserverList = new List<Observer<Item>>();
        private SQLiteConnection _SQLiteConnection;
        public static ResourceManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ResourceManager();
                return _instance;
            }
        }
        public ResourceManager()
        {
            _SQLiteConnection = new SQLiteConnection($"DataSource=\"{DatabasePath}\"");
            _SQLiteConnection.Open();
        }

        public List<Item> QueryItems(string sql)
        {
            SQLiteCommand cmd = _SQLiteConnection.CreateCommand();
            cmd.CommandText = sql;
            var reader=cmd.ExecuteReader();
            List<Item> list = new List<Item>();
            while (reader.Read())
            {
                Item item = new Item((char)reader.GetInt32(0), reader.GetString(1).Split(","));
                item.UseCount = reader.GetInt32(2);
                item.IsLike = reader.GetInt32(3) != 0;
                list.Add(item);
            }
            reader.Close();
            return list;
        }

        public void ClearUseCount()
        {
            using (SQLiteCommand cmd = _SQLiteConnection.CreateCommand())
            {
                cmd.CommandText = "UPDATE data SET use_count=0";
                cmd.ExecuteNonQuery();
                NotifyBatchMotified();
            }
            return;
                
        }

        public void UpdateFont(Item item)
        {
            using (SQLiteCommand cmd = _SQLiteConnection.CreateCommand())
            {
                cmd.CommandText = $"UPDATE data SET keywords=\"{string.Join(",", item.Keywords)}\" ,use_count={item.UseCount} ,like={(item.IsLike ? 1 : 0)} WHERE unicode = {(int)item.Char}";
                cmd.ExecuteNonQuery();
                NotifyItemUpdated(item);
            }

        }
        public Item? GetFont(char ch)
        {
            using (SQLiteCommand cmd = _SQLiteConnection.CreateCommand())
            {
                cmd.CommandText = $"SELECT * FROM data WHERE unicode={(int)ch}";
                SQLiteDataReader reader = cmd.ExecuteReader();
                Item? item=null;
                if (reader.Read())
                {
                    item = new Item((char)reader.GetInt32(0), reader.GetString(1).Split(","));
                    item.UseCount = reader.GetInt32(2);
                    item.IsLike = reader.GetInt32(3) != 0;
                }
                reader.Close();
                return item;
            }
        }

        public void InsertFont(char ch, IEnumerable<string>? keywords)
        {
            using (SQLiteCommand cmd = _SQLiteConnection.CreateCommand())
            {
                Item item = new Item(ch, keywords != null ? keywords : new string[] { ch.ToString() });
                cmd.CommandText = $"INSERT INTO data VALUES ({(int)ch},\"{string.Join(",", item.Keywords)}\",0,0)";
                cmd.ExecuteNonQuery();
                NotifyItemInserted(item);
            }
                
        }

        public List<Item> GetAllFonts()
        {
            using(SQLiteCommand cmd = _SQLiteConnection.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM data";
                SQLiteDataReader reader = cmd.ExecuteReader();
                List<Item> list = new List<Item>();
                while (reader.Read())
                {
                    Item item = new Item((char)reader.GetInt32(0), reader.GetString(1).Split(","));
                    item.UseCount = reader.GetInt32(2);
                    item.IsLike = reader.GetInt32(3) != 0;
                    list.Add(item);
                }
                reader.Close();
                return list;
            }
            
            
        }

        public List<Item> SearchFonts(string keyword)
        {
            using(SQLiteCommand cmd = _SQLiteConnection.CreateCommand())
            {
                cmd.CommandText = $"SELECT * FROM data WHERE keywords LIKE \"%{keyword}%\"";
                SQLiteDataReader reader = cmd.ExecuteReader();
                List<Item> list = new List<Item>();
                while (reader.Read())
                {
                    Item item = new Item((char)reader.GetInt32(0), reader.GetString(1).Split(","));
                    item.UseCount = reader.GetInt32(2);
                    item.IsLike = reader.GetInt32(3) != 0;
                    list.Add(item);
                }
                reader.Close();
                return list;
            }
                        
            
        }

        public void NotifyItemInserted(Item status)
        {
            foreach (var o in ObserverList)
                o.OnItemInserted(this,status);
        }

        public void NotifyItemRemoved(Item status)
        {
            foreach (var o in ObserverList)
                o.OnItemRemoved(this, status);
        }

        public void NotifyItemUpdated(Item status)
        {
            foreach (var o in ObserverList)
                o.OnItemUpdated(this, status);
        }

        public void RegisterObserver(Observer<Item> observer)
        {
            ObserverList.Add(observer);
        }

        public void UnregisterObserver(Observer<Item> observer)
        {
            ObserverList.Remove(observer);
        }

        public void NotifyBatchMotified()
        {
            foreach (var o in ObserverList)
                o.OnBatchModified(this);
        }
    }
}
