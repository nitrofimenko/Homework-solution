using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L04_12.AbstractHandler;
using L04_12.AbstractHandler.DerivedClasses;

internal class Document
{
    public DocumentType DocumentType { get; }
    public AbstractHandler Handler { get; }
    public Document(DocumentType documentType)
    {
        DocumentType = documentType;
        switch (DocumentType)
        {
            case DocumentType.XML:
                Handler = new XMLHandler();
                break;
            case DocumentType.TXT:
                Handler = new TXTHandler();
                break;
            case DocumentType.DOC:
                Handler = new DOCHandler();
                break;
            default:
                Handler = new TXTHandler();
                break;
        }
    }
}
