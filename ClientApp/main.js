import { Book, Bookshelf } from './models.js';

class BookController {
  static getBooks() {
    fetch('https://localhost:5001/api/book')
      .then(response => response.json())
      .then(books => {
        let table = document.querySelector('#books-table-body');

        books.forEach(book => {
          let row = document.createElement('tr');
          row.innerHTML = `
          <th scope="row">${book.id}</td>
          <td>${book.title}</td>
          <td>${book.author}</td>
          <td>${book.isbn}</td>
          <td>${book.publisher}</td>
          <td>${book.publicationDate}</td>
          <td><a href="./bookshelves.html>${book.bookshelfId}</a></td>
          `;
          table.appendChild(row);
        })
      })
      .catch(() => alert('Unable to connect to server.'));
  }

  static deleteBook(id) {
    fetch()
  }

  static addBook() {
    return new Book();
  }
}

class BookshelfController {
  static addBookshelf() {
    return new Bookshelf();
  }
}

// window.onload = () => {
//   BookController.getBooks();
// }

export default class { BookController };

function getBooks() {
  fetch('https://localhost:5001/api/book')
    .then(response => response.json())
    .catch(() => [
      {
        id: 1,
        title: "foo",
        author: null,
        isbn: null,
        publisher: null,
        publicationDate: new Date('1998-11-03 23:00'),
        bookshelfId: 1,
      },
      {
        id: 2,
        title: "The Adventures of Huckleberry Finn",
        author: null,
        isbn: null,
        publisher: null,
        publicationDate: null,
        bookshelfId: 2,
      },
      {
        id: 3,
        title: "fizz",
        author: null,
        isbn: null,
        publisher: null,
        publicationDate: new Date('2020-12-09 23:00'),
        bookshelfId: 3,
      }
    ])
    .then(books => {
      let table = document.querySelector('#books-table-body');
      books.forEach(book => {
        let row = document.createElement('tr');
        row.innerHTML =
          '<th scope="row">' + book.id + '</td>' +
          '<td>' + book.title + '</td>' +
          '<td>' + book.author + '</td>' +
          '<td>' + book.isbn + '</td>' +
          '<td>' + book.publisher + '</td>' +
          '<td>' + (book.publicationDate == null ? null : new Date(book.publicationDate).toLocaleDateString()) + '</td>' +
          '<td><a href="./bookshelves.html">' + book.bookshelfId + '</a></td>';
        table.appendChild(row);
      })
    });

  // let table = document.querySelector('#books-table-body');
  // books.forEach(book => {
  //   let row = document.createElement('tr');
  //   row.innerHTML =
  //     '<th scope="row">' + book.id + '</td>' +
  //     '<td>' + book.title + '</td>' +
  //     '<td>' + book.author + '</td>' +
  //     '<td>' + book.isbn + '</td>' +
  //     '<td>' + book.publisher + '</td>' +
  //     '<td>' + (book.publicationDate == null ? null : book.publicationDate.toLocaleDateString()) + '</td>' +
  //     '<td><a href="./bookshelves.html">' + book.bookshelfId + '</a></td>';
  //   table.appendChild(row);
  // })
}

function getBookshelves() {
  fetch('https://localhost:5001/api/bookshelf')
    .then(response => response.json())
    .catch(() => [
      {
        id: 1,
        name: "Want to Read"
      },
      {
        id: 2,
        name: "Currently Reading"
      },
      {
        id: 3,
        name: "Read"
      }
    ])
    .then(bookshelves => {
      let table = document.querySelector('#bookshelves-table-body');
      bookshelves.forEach(bookshelf => {
        let row = document.createElement('tr');
        row.innerHTML =
          '<th scope="row">' + bookshelf.id + '</td>' +
          '<td>' + bookshelf.name + '</td>';
        table.appendChild(row);
      })
    });
  // let bookshelves = [
  //   {
  //     id: 1,
  //     name: "Want to Read"
  //   },
  //   {
  //     id: 2,
  //     name: "Currently Reading"
  //   },
  //   {
  //     id: 3,
  //     name: "Read"
  //   }
  // ];

  // let table = document.querySelector('#bookshelves-table-body');
  // bookshelves.forEach(bookshelf => {
  //   let row = document.createElement('tr');
  //   row.innerHTML =
  //     '<th scope="row">' + bookshelf.id + '</td>' +
  //     '<td>' + bookshelf.name + '</td>';
  //   table.appendChild(row);
  // })
}