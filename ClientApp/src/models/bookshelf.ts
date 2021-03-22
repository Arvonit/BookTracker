import Book from "./book";

class Bookshelf {
  id: number;
  name: string;
  books: Array<Book>;

  constructor(id: number, name: string, books?: Array<Book>) {
    this.id = id
    this.name = name
    this.books = books ?? new Array<Book>();
  }
}

export default Bookshelf;