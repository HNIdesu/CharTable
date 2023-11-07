namespace CharTable
{
    internal interface Observable<T>
    {
        void NotifyItemInserted(T status);
        void NotifyItemRemoved(T status);
        void NotifyItemUpdated(T status);
        void NotifyBatchMotified();
        void RegisterObserver(Observer<T> observer);
        void UnregisterObserver(Observer<T> observer);
    }
}
