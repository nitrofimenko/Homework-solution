using L01_03.Book;

Book userBook1 = new Book();
userBook1.Title = "First book title";
userBook1.Author = "First book author";
userBook1.Content = "First book content";
userBook1.Show();

Book userBook2 = new Book("Second book title", "Second book author", "Second book content");
userBook2.Show();