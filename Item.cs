namespace CharTable
{
    internal class Item
    {
        public char Char { get; set; }
        public HashSet<string> Keywords { get; private set; } = new HashSet<string>();
        public int UseCount { get; set; }
        public bool IsLike { get; set; }
        public Item(char ch,IEnumerable<string> keywords)
        {
            Char = ch;
            keywords.All((s) =>
            {
                Keywords.Add(s);
                return true;
            });
        }

    }
}
