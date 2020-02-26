using System;

namespace AlexaSettings
{
    internal class Alexa
    {
        private readonly IAlexaOptions options;

        public Alexa()
        {
            //This would be provided maybe by a Alexa factory. To follow the 
            // principle of dependency inversion. Because I couldn't change
            // the main method I decided to stick with this.
            options = new AlexaOptions
            {
                GreetingMessage = "Hello, I am Alexa"
            };
        }

        internal string Talk()
        {
            return options.GetMessage();
        }

        internal void Configure(Action<IAlexaOptions> setup)
        {
            setup(options);
        }
    }
}