import { Box, Center, Container } from '@chakra-ui/layout';
import AddBook from './components/AddBook';
import BookList from './components/BookList';
import { useState } from 'react';
import Header from './components/Header';
import Book from './models/book';

function App() {
  // State variables
  const [showAddBook, setShowAddBook] = useState(false);
  let books = new Array<Book>();

  function toggleAddBook() {
    setShowAddBook(!showAddBook);
  }

  return (
    <Container maxWidth="container.lg">
      <Box paddingTop={4}>
        <Header
          buttonColor={showAddBook ? 'red' : 'green'}
          buttonText={showAddBook ? 'Hide' : 'Add'}
          buttonOnClick={toggleAddBook}
        />
      </Box>

      {showAddBook &&
        <Box>
          <AddBook />
        </Box>
      }

      <Box paddingTop={10}>
        <Center>
          <BookList />
        </Center>
      </Box>
    </Container>
  );
}

export default App;