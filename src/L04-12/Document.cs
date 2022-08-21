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
    public AbstractHandler Handler;
    public Document(DocumentType documentType, AbstractHandler handler)
    {
        DocumentType = documentType;
        Handler = handler;
    }
}
