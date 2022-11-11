namespace State.Documents;

public class ReviewDocumentArgs
{
    public ReviewDocumentArgs(Document document)
    {
        Document = document;
    }

    public Document Document { get; }
}