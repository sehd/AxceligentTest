using System;
using System.Collections.Generic;

namespace UserClass
{
    internal class User
    {
        private readonly IUserStore userStore;

        public User()
        {
            //Based on principle of IoC IUserStore would be provided
            // as argument to this constructor. But since I can't change the
            // layout of Main method I stick to this instead.
            userStore = new MemoryUserStore();
        }

        internal void Add(string userName)
        {
            //These errors should also be handled in the main method if edit was allowed
            if (string.IsNullOrWhiteSpace(userName))
                throw new ArgumentException("Username can not be empty", nameof(userName));

            if (userStore.Contains(userName))
                throw new UserExistsException("User already exists");

            userStore.Add(userName);
        }

        internal int GetUsersCount()
        {
            return userStore.Count();
        }
    }
}