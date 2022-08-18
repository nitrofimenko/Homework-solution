using L04_12.AbstractHandler;
using L04_12.AbstractHandler.DerivedClasses;

AbstractHandler ReturnHandler(Document document)
{
    switch (document.TypeOfDocument)
    {
        case DocumentType.XML:
            return new XMLHandler();
        case DocumentType.TXT:
            return new TXTHandler();
        case DocumentType.DOC:
            return new DOCHandler();
        default:
            return new TXTHandler();
    }
}

Document document;
AbstractHandler handler;
DocumentType[] documentTypes =
{
    DocumentType.XML,
    DocumentType.TXT,
    DocumentType.DOC
};
foreach (var dt in documentTypes)
{
    document = new Document(dt);
    handler = ReturnHandler(document);
    Console.WriteLine($"{dt} document");
    handler.Open();
    handler.Create();
    handler.Change();
    handler.Save();
    Console.WriteLine();
}

enum DocumentType
{
    XML,
    TXT,
    DOC
}
struct Document
{
    public DocumentType TypeOfDocument;
    public Document(DocumentType typeOfDocument)
    {
        TypeOfDocument = typeOfDocument;
    }
}
