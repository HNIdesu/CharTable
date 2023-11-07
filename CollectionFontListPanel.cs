namespace CharTable
{
    internal class CollectionFontListPanel:FontListPanel
    {
        public CollectionFontListPanel()
        {
            LoadItems();
        }

        private void LoadItems()
        {
            ClearItems();
            AddItems(ResourceManager.Instance.QueryItems("SELECT * from data WHERE like = 1"));
        }

        public override void OnItemUpdated(object sender, Item status)
        {
            if (status.IsLike)
                AddItem(status);
            else
                RemoveItem(status);
        }
        public override void OnItemInserted(object sender, Item status)
        {
            if(status.IsLike)
                AddItem(status);
        }

        public override void OnItemRemoved(object sender, Item status)
        {
            if (status.IsLike)
                RemoveItem(status);
        }
    }
}
