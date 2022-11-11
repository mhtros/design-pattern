using State.Documents;
using State.Users;

namespace State.States;

public interface IDocumentState
{
    void Publish(Document document, User user);
}