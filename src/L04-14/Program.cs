using L04_14.Document;
using L04_14.Document.Parts;

Title title = new Title();
title.Content = "Контракт";

Body body = new Body();
body.Content = "Тело контракта...";

Footer footer = new Footer();
footer.Content = "Директор: Иванов И.И.";

Document document = new Document(title, body, footer);
document.Show();