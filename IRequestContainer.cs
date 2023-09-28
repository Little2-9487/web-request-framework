namespace L2
{
    public interface IRequestContainer<T>
    {
        void SetRequest(T _data);
        T GetRequest();
    }
}
