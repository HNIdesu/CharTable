
namespace CharTable
{
    internal class OftenUseFontListPanel : FontListPanel
    {
        public OftenUseFontListPanel()
        {
            LoadItems();
        }
        public override void OnItemRemoved(object sender, Item status)
        {
            RemoveItem(status);
        }
        public override void OnItemInserted(object sender, Item status)
        {
            if (status.UseCount == 0)
                return;
            LoadItems();
        }
        public override void OnItemUpdated(object sender, Item status)
        {

            if(status.UseCount!=0 || DataBinding.ContainsKey(status))
                LoadItems();
        }

        private void LoadItems()
        {
            ClearItems();
            AddItems(ResourceManager.Instance.QueryItems("SELECT * from data WHERE use_count>0 ORDER BY use_count DESC"));
        }
    }
}
