using System;

namespace UserClass
{
    internal class User
    {
        int count = 0;

        internal void Add(string userName)
        {
            count++;
        }

        internal int GetUsersCount()
        {
            return count;
        }
    }
}