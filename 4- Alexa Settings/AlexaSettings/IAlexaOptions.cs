namespace AlexaSettings
{
    internal interface IAlexaOptions
    {
        string GetMessage();
        string GreetingMessage { get; set; }
        string OwnerName { get; set; }
    }
}