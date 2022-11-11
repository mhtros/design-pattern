using State.Documents;
using State.Users;

namespace State.States;

public class PublishedState : IDocumentState
{
    public void Publish(Document document, User user)
    {
        Console.WriteLine($"The document [{document.Title}] is already published!!!");
    }
}