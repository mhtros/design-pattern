using State.Documents;
using State.Users;

namespace State.States;

public class DraftState : IDocumentState
{
    public void Publish(Document document, User user)
    {
        switch (user.Privilege)
        {
            case (int) UserPrivileges.Administrator:
                Console.WriteLine(
                    $"Document [{document.Title}] was directly published by admin {user.Name?.ToUpper()}.");
                document.PassReview = true;
                document.State = new PublishedState();
                break;
            case (int) UserPrivileges.Basic:
                Console.WriteLine($"Document [{document.Title}] was proceed for review by {user.Name?.ToUpper()}.");
                document.PassReview = false;
                document.State = new ModerationState();
                break;
        }
    }
}