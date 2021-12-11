using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace WebTruyen.Infrastructure
{
    public static class SessionExtensions
    {
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T Getjson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);
            if (sessionData == null)
            {
                return default;
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(sessionData);
            }
        }
    }
}
