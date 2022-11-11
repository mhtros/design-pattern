using State.Documents;

namespace State.Users;

public class User
{
    public User(string? name, int privilege)
    {
        Name = name;
        Privilege = privilege;
    }

    public string? Name { get; }
    public int Privilege { get; }

    public event EventHandler<ReviewDocumentArgs>? ReviewDocumentHandler;

    public void ReviewDocument(Document document)
    {
        if (Privilege != (int) UserPrivileges.Administrator) return;

        var args = new ReviewDocumentArgs(document);
        ReviewDocumentHandler?.Invoke(this, args);
    }
}