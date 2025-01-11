using System;

namespace ServicesLib.Services
{
    public abstract class Service<T> where T : class, new()
    {
        public static T Instance()
        {
            return new T();
        }
    }
}
