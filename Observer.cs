namespace CharTable
{
    internal interface Observer<T>
    {
        
        void OnItemInserted(object sender, T status);
        void OnItemRemoved(object sender, T status);
        void OnItemUpdated(object sender, T status);

    }
}
