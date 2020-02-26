namespace AlexaSettings
{
    class AlexaOptions
    {
        public string GreetingMessage { get; set; }
        public string OwnerName { get; set; }

        public string GetMessage()
        {
            return GreetingMessage.Replace("{" + nameof(OwnerName) + "}", OwnerName);
        }
    }
}
