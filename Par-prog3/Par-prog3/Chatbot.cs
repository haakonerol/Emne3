namespace Par_prog3;

public class ChatBot
{
    public string Name { get; }
    private List<string> Responses;

    public ChatBot(string name)
    {
        Name = name;
        Responses = new List<string>();
    }

    public void AddResponse(string response)
    {
        Responses.Add(response);
    }

    public string GetRandomResponse()
    {
        if (Responses.Count == 0)
            return "Jeg har ingen svar ennå!";
            
        Random rnd = new Random();
        return Responses[rnd.Next(Responses.Count)];
    }
}