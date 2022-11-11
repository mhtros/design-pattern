using State.States;
using State.Users;

namespace State.Documents;

public class Document
{
    public bool PassReview;

    public Document(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public IDocumentState State { get; set; } = new DraftState();
    public string Content { get; set; }

    public string Title { get; }

    public void Publish(User user)
    {
        State.Publish(this, user);
    }
}