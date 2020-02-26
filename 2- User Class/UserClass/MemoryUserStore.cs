using System.Collections.Generic;

namespace UserClass
{
    internal class MemoryUserStore : IUserStore
    {
        private static readonly List<string> store;

        static MemoryUserStore() => store = new List<string>();

        public void Add(string username)
        {
            store.Add(username);
        }

        public bool Contains(string username)
        {
            return store.Contains(username);
        }

        public int Count()
        {
            return store.Count;
        }
    }
}