class Book {
  constructor(id, title, author, isbn, publisher, publicationDate, bookshelfId) {
    this.id = id;
    this.title = title;
    this.author = author;
    this.isbn = isbn;
    this.publisher = publisher;
    this.publicationDate = publicationDate;
    this.bookshelfId = bookshelfId;
  }
}

class Bookshelf {
  constructor(id, name, books) {
    this.id = id;
    this.name = name;
    this.books = books;
  }
}

export { Book, Bookshelf };