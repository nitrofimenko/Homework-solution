using L04_12.AbstractHandler;
using L04_12.AbstractHandler.DerivedClasses;
using System.Security.Claims;

AbstractHandler GetHandler(DocumentType documentType)
{
    switch (documentType)
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

AbstractHandler handler;
Document document;
foreach (DocumentType documentType in Enum.GetValues(typeof(DocumentType)))
{
    document = new Document(documentType, GetHandler(documentType));
    Console.WriteLine($"{documentType} document");
    document.Handler.Open();
    document.Handler.Create();
    document.Handler.Change();
    document.Handler.Save();
    Console.WriteLine();
}

enum DocumentType
{
    XML,
    TXT,
    DOC
}