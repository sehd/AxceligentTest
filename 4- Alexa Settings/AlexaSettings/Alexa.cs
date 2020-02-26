using System;

namespace AlexaSettings
{
    internal class Alexa
    {
        private readonly AlexaOptions options;

        public Alexa()
        {
            options = new AlexaOptions
            {
                GreetingMessage = "Hello, I am Alexa"
            };
        }

        internal string Talk()
        {
            return options.GreetingMessage.Replace("{OwnerName}", options.OwnerName);
        }

        internal void Configure(Action<AlexaOptions> setup)
        {
            setup(options);
        }
    }
}