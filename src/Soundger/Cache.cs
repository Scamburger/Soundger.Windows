using System;

namespace Soundger
{
    internal static class Cache
    {
        private readonly static IDictionary<string, object> Objects = new Dictionary<string, object>();

        public static T GetOrAdd<T>(string key, Func<T> objectFactory)
        {
            T value;

            if (Objects.ContainsKey(key) == false)
            {
                value = objectFactory.Invoke();
                Objects.Add(key, value);
            }
            else
            {
                value = (T)Objects[key];
            }

            return value;
        }
    }
}
