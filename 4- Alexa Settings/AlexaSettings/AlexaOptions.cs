using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AlexaSettings
{
    class AlexaOptions
    {
        private readonly Dictionary<string, PropertyInfo> formatters;

        public AlexaOptions()
        {
            formatters = typeof(AlexaOptions).GetProperties()
                .Where(p => p.Name != nameof(GreetingMessage))
                .ToDictionary(p => $"{{{p.Name}}}", p => p);
        }

        public string GreetingMessage { get; set; }
        public string OwnerName { get; set; }

        public string GetMessage()
        {
            var res = GreetingMessage;
            foreach (var formatter in formatters)
            {
                res = res.Replace(formatter.Key, formatter.Value.GetValue(this)?.ToString());
            }
            return res;
        }
    }
}
