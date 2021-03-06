﻿using System;
using System.Runtime.Serialization;

namespace UserClass
{
    [Serializable]
    internal class UserExistsException : Exception
    {
        public UserExistsException()
        {
        }

        public UserExistsException(string message) : base(message)
        {
        }

        public UserExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}