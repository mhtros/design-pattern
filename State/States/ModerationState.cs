using State.Documents;
using State.Users;

namespace State.States;

public class ModerationState : IDocumentState
{
    public void Publish(Document document, User user)
    {
        switch (user.Privilege)
        {
            case (int) UserPrivileges.Administrator:
                user.ReviewDocument(document);
                switch (document.PassReview)
                {
                    case true:
                        Console.WriteLine(
                            $"----\nUser {user.Name?.ToUpper()} has approved the document [{document.Title}].");
                        Console.WriteLine($"REASON: '{document.Content}' is a very interesting document!\n----");
                        document.State = new PublishedState();
                        break;
                    default:
                        Console.WriteLine(
                            $"----\nUser {user.Name?.ToUpper()} has reject the document [{document.Title}].");
                        Console.WriteLine($"REASON: '{document.Content}' is not a very interesting document!\n----");
                        document.State = new DraftState();
                        break;
                }

                break;
            case (int) UserPrivileges.Basic:
                Console.WriteLine($"User {user.Name?.ToUpper()} don't have the privilege to approve a review!");
                break;
        }
    }
}