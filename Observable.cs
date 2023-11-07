namespace CharTable
{
    internal interface Observable<T>
    {
        void NotifyItemInserted(T status);
        void NotifyItemRemoved(T status);
        void NotifyItemChanged(T status);
        void RegisterObserver(Observer<T> observer);
        void UnregisterObserver(Observer<T> observer);
    }
}
