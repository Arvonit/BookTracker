import Bookshelf from "./bookshelf";

class Book {
  id: number;
  title: string;
  author?: string;
  publisher?: string;
  publicationDate?: Date;
  bookshelf: Bookshelf;

  constructor(
    id: number,
    bookshelf: Bookshelf,
    title: string,
    author?: string,
    publisher?: string,
    publicationDate?: Date
  ) {
    this.id = id;
    this.title = title;
    this.author = author;
    this.publisher = publisher;
    this.publicationDate = publicationDate;
    this.bookshelf = bookshelf;
  }
}

export default Book;