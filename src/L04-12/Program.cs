﻿using L04_12.AbstractHandler;
using L04_12.AbstractHandler.DerivedClasses;
using System.Security.Claims;

Document document;
foreach (DocumentType documentType in Enum.GetValues(typeof(DocumentType)))
{
    document = new Document(documentType);
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