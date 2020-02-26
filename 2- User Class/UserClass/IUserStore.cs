namespace UserClass
{
    internal interface IUserStore
    {
        void Add(string username);
        bool Contains(string username);
        int Count();
    }
}